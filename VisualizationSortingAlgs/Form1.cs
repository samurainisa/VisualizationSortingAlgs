using System;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.Sheets.v4;
using Microsoft.Office.Interop.Excel;
using ZedGraph;
using Application = Microsoft.Office.Interop.Excel.Application;


namespace Algorithm
{
    public partial class Form1 : Form
    {
        private Random rand = new Random();
        double[] unsortedArray;
        double[] unsortedArray1;
        double[] unsortedArray2;
        double[] unsortedArray3;
        double[] unsortedArray4;
        ManualResetEventSlim limiter = new ManualResetEventSlim(true);

        private Stopwatch watch = new Stopwatch();
        private bool startedSort = false;
        /*        double maximum = Math.Pow(2,60);
                double minimum = -1/Math.Pow(2, 60);*/


        public Form1()
        {
            InitializeComponent();
            zedGraphDesign(BubbleGraph1);
            zedGraphDesign(ShakerGraph1);
            zedGraphDesign(QuickGraph1);
            zedGraphDesign(BogoGraph1);
            zedGraphDesign(IntersectionGraph1);
        }


        private void закрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {

            GC.Collect();
            Dispose();
            Close();
        }


        public void zedGraphDesign(ZedGraphControl BubbleGraph1)
        {
            GraphPane graphfield = BubbleGraph1.GraphPane;
            graphfield.Border.Color = Color.Black;
            graphfield.Chart.Border.Color = Color.Black;
            graphfield.Fill.Type = FillType.Solid;
            graphfield.Fill.Color = Color.Black;
            graphfield.Chart.Fill.Type = FillType.Solid;
            graphfield.Chart.Fill.Color = Color.Black;
            graphfield.YAxis.Title.Text = null;
            graphfield.XAxis.Title.Text = null;
        }

        #region парсинг данных и генерация
        private void excelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = String.Empty;
            DialogResult res = openFileDialog1.ShowDialog();
            if (res != DialogResult.OK) return;

            try
            {
                dataGridView1.Rows.Clear();
                Application ObjWorkExcel = new Application();
                Workbook ObjWorkBook = ObjWorkExcel.Workbooks.Open(openFileDialog1.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing); //открыть файл
                Worksheet ObjWorkSheet = (Worksheet)ObjWorkBook.Sheets[1];

                var lastCell = ObjWorkSheet.Cells.SpecialCells(GetXlCellTypeLastCell());
                int lastColumn = lastCell.Column;
                int lastRow = lastCell.Row;

                if (ObjWorkSheet.Rows.CurrentRegion.EntireRow.Count == 1)
                {
                    MessageBox.Show("No data found.");
                }
                else
                {
                    string sx = String.Empty;

                    for (int i = 0; i < lastCell.Row; i++)
                    {
                        sx = ObjWorkSheet.Cells[i + 1, 1].Text.ToString();
                        if (sx.Trim() != String.Empty)
                        {
                            dataGridView1.Rows.Add(sx);
                        }
                    }
                    DtgtoList();
                    InitGraphics();
                    GC.Collect();
                }

                ObjWorkBook.Close(false, Type.Missing, Type.Missing);
                ObjWorkExcel.Quit();
                ObjWorkExcel.Quit();
                GC.Collect();

            }

            catch (Exception exception)
            {
                MessageBox.Show($"При попытке загрузки из Excel произошла обшика!\n{exception.Message}", "Error!", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private static XlCellType GetXlCellTypeLastCell()
        {
            return XlCellType.xlCellTypeLastCell;
        }


        private static readonly string[] Scopes = { SheetsService.Scope.Spreadsheets };
        private const string GoogleCredentialsFileName = @"C:\Users\workspace.DESKTOP-N5S6IG3\source\repos\VisualizationSortingAlgs\VisualizationSortingAlgs\clients_secrets.json";
        private const string ReadRange = "Лист1!A:A";
        private const string SpreadsheetId = "1GoOUEb2OdQWLqPIJbEB_wMnfy4sJwc4cSkdMra2AEKM";

        private async void googleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            await readAsync();
        }
        async Task readAsync()
        {
            var serviceValues = GetSheetsService().Spreadsheets.Values;
            await ReadAsync(serviceValues);
        }

        private static SheetsService GetSheetsService()
        {
            using (var stream = new FileStream(GoogleCredentialsFileName, FileMode.Open, FileAccess.Read))
            {
                var serviceInitializer = new BaseClientService.Initializer
                {
                    HttpClientInitializer = GoogleCredential.FromStream(stream).CreateScoped(Scopes)
                };
                return new SheetsService(serviceInitializer);
            }
        }

        private  async Task ReadAsync(SpreadsheetsResource.ValuesResource valuesResource)
        {
            var response = await valuesResource.Get(SpreadsheetId, ReadRange).ExecuteAsync();
            var values = response.Values;

            if (values == null || !values.Any())
            {
                Console.WriteLine("No data found.");
                return;
            }

            else
            {
                foreach (var row in values.Skip(1))
                {
                    var res = string.Join(" ", row.Select(r => r.ToString()));
                    dataGridView1.Rows.Add(res);
                    DtgtoList();
                    InitGraphics();
                }
            }
        }
        public void GenerateData()
        {
                dataGridView1.AllowUserToAddRows = false;
                dataGridView1.Rows.Clear();
                int Yn = Convert.ToInt32(arraynum.Text);
                Random rnd = new Random();

                for (int row = 0; row < Yn; row++)
                {
                    dataGridView1.Rows.Add();
                    dataGridView1[0, row].Value = rnd.Next(1000);
                }
                dataGridView1.AllowUserToAddRows = true;
        }
        //Максимум и минимум, надо переделать
/*        private void MaxAndMin()
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                if (Convert.ToDouble(dataGridView1[0, i].Value) > maximum)
                {
                    maximum = Convert.ToDouble(dataGridView1[0, i].Value);
                }
                if (Convert.ToDouble(dataGridView1[0, i].Value) < minimum)
                {
                    minimum = Convert.ToDouble(dataGridView1[0, i].Value);
                }
            }
        }*/

        #endregion

        #region Заполнение

        //From datagridview1 to mass
        private void DtgtoList()
        {
            dataGridView1.AllowUserToAddRows = false;
            unsortedArray = new double[dataGridView1.RowCount];
            unsortedArray1 = new double[dataGridView1.RowCount];
            unsortedArray2 = new double[dataGridView1.RowCount];
            unsortedArray3 = new double[dataGridView1.RowCount];
            unsortedArray4 = new double[dataGridView1.RowCount];

            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                unsortedArray[i] = double.Parse(dataGridView1[0, i].Value.ToString());
                unsortedArray1[i] = double.Parse(dataGridView1[0, i].Value.ToString());
                unsortedArray2[i] = double.Parse(dataGridView1[0, i].Value.ToString());
                unsortedArray3[i] = double.Parse(dataGridView1[0, i].Value.ToString());
                unsortedArray4[i] = double.Parse(dataGridView1[0, i].Value.ToString());
            }
            dataGridView1.AllowUserToAddRows = true;
        }


        private void genBtn_Click_1(object sender, EventArgs e)
        {
            GenerateData();
            DtgtoList();
            InitGraphics();
        }

        private void InitGraphics()
        {
            BubbleGraph(BubbleGraph1);
            ShakerGraph(ShakerGraph1);
            BogoGraph(BogoGraph1);
            QuickGraph(QuickGraph1);
            InterGraph(IntersectionGraph1);
        }
        #endregion

        #region Треды
        private void button1_Click(object sender, EventArgs e)
        {

            if (quickcheck.Checked)
            {
                Thread quick = new Thread(new ThreadStart(QuickS));
                quick.Start();
                watch.Restart();
                watch.Start();
            }
            if (bubblecheck.Checked)
            {
                Thread bubble = new Thread(new ThreadStart(BubbleS));
                bubble.Start();
                bubble.Priority = ThreadPriority.Highest;
                watch.Restart();
                watch.Start();
            }

            if (shakercheck.Checked)
            {
                Thread shaker = new Thread(new ThreadStart(ShakerS));
                shaker.Start();
                shaker.Priority = ThreadPriority.Highest;
                watch.Restart();
                watch.Start();
            }
            if (bogocheck.Checked)
            {
                Thread bogo = new Thread(new ThreadStart(BogoS));
                bogo.Start();
                bogo.Priority = ThreadPriority.Lowest;
                watch.Restart();
                watch.Start();
            }
            if (Intersectioncheck.Checked)
            {
                Thread inter = new Thread(new ThreadStart(InterS));
                inter.Start();
                watch.Restart();
                watch.Start();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region Таски сортировок
        private async void QuickS()
        {
            await Task.Run(() => QuickSort(unsortedArray3, 0, unsortedArray3.Length-1));
        }
        private async void BubbleS()
        {
            await Task.Run(() => BubbleSorting(unsortedArray));
        }

        private async void ShakerS()
        {
            await Task.Run(() => ShakerSorting(unsortedArray1));
        }

        private async void BogoS()
        {
            await Task.Run(() => BogoSorting(unsortedArray2));
        }

        private async void InterS()
        {
            await Task.Run(() => InterSorting(unsortedArray4));
        }
        #endregion

        #region Визуализация

        private void BubbleGraph(ZedGraphControl zedGraphControl1)
        {
            GraphPane pane = zedGraphControl1.GraphPane;
            pane.Title.Text = "BubbleSort";
            pane.CurveList.Clear();
            var n = dataGridView1.RowCount-1;
            double[] values = new double[n];
            for (int i = 0; i < n; i++)
            {
                values[i] = unsortedArray[i];
            }
            BarItem curve = pane.AddBar("Elements", null, values, Color.White);
            pane.BarSettings.MinClusterGap = 0F;
            zedGraphControl1.AxisChange();
            zedGraphControl1.Invalidate();
        }

        private void ShakerGraph(ZedGraphControl zedGraphControl2)
        {
            GraphPane pane = zedGraphControl2.GraphPane;
            pane.Title.Text = "ShakerSort";
            pane.CurveList.Clear();
            var n = dataGridView1.RowCount - 1;
            double[] values = new double[n];
            for (int i = 0; i < n; i++)
            {
                values[i] = unsortedArray1[i];
            }
            BarItem curve = pane.AddBar("Elements", null, values, Color.White);
            pane.BarSettings.MinClusterGap = 0F;
            zedGraphControl2.AxisChange();
            zedGraphControl2.Invalidate();
        }
        private void BogoGraph(ZedGraphControl bogograph)
        {
            GraphPane pane = bogograph.GraphPane;
            pane.Title.Text = "BubbleSort";
            pane.CurveList.Clear();
            var n = dataGridView1.RowCount - 1;
            double[] values = new double[n];
            for (int i = 0; i < n; i++)
            {
                values[i] = unsortedArray2[i];
            }
            BarItem curve = pane.AddBar("Elements", null, values, Color.White);
            pane.BarSettings.MinClusterGap = 0F;
            bogograph.AxisChange();
            bogograph.Invalidate();
        }

        private void QuickGraph(ZedGraphControl quickgraph1)
        {
            GraphPane pane = quickgraph1.GraphPane;
            pane.Title.Text = "QuickSort";
            pane.CurveList.Clear();
            var n = dataGridView1.RowCount - 1;
            double[] values = new double[n];
            for (int i = 0; i < n; i++)
            {
                values[i] = unsortedArray3[i];
            }
            BarItem curve = pane.AddBar("Elements", null, values, Color.White);
            pane.BarSettings.MinClusterGap = 0F;
            quickgraph1.AxisChange();
            quickgraph1.Invalidate();
        }
        private void InterGraph(ZedGraphControl intergraph)
        {
            GraphPane pane = intergraph.GraphPane;
            pane.Title.Text = "IntersionSort";
            pane.CurveList.Clear();
            var n = dataGridView1.RowCount - 1;
            double[] values = new double[n];
            for (int i = 0; i < n; i++)
            {
                values[i] = unsortedArray4[i];
            }
            BarItem curve = pane.AddBar("Elements", null, values, Color.White);
            pane.BarSettings.MinClusterGap = 0F;
            intergraph.AxisChange();
            intergraph.Invalidate();
        }
#endregion

        #region Сортировочки

        static void Swap(double[] array, int i, int j)
        {
            double glass = array[i];
            array[i] = array[j];
            array[j] = glass;
        }
        //пузырьковая
        private void BubbleSorting(double[] unsortedArray)
        {
            var n = dataGridView1.RowCount - 1;
            for (int i = 0; i < n; i++)
            { 
                for (int j = 0; j < n - i - 1; j++)
                {
                    Thread.Sleep(5);
                    if (unsortedArray[j] > unsortedArray[j + 1])
                    {
                        BubbleGraph(BubbleGraph1);
                        Swap(unsortedArray, j, j + 1);
                    }
                }
            }
            BubbleGraph(BubbleGraph1);
        }

        //шейкерная сортировка
        private void ShakerSorting(double[] array1)
        {
            var n = dataGridView1.RowCount - 1;
            int left = 0,
                right = n - 1;

            while (left < right)
            {
                for (int i = left; i < right; i++)
                {
                    if (array1[i] > array1[i + 1])
                    {
                        Swap(array1, i, i + 1);
                        ShakerGraph(ShakerGraph1);
                        Thread.Sleep(5);
                    }
                }
                right--;

                for (int i = right; i > left; i--)
                {
                    if (array1[i - 1] > array1[i])
                    {
                        Swap(array1, i - 1, i);
                        ShakerGraph(ShakerGraph1);
                    }
                }
                left++;
            }
            ShakerGraph(ShakerGraph1);
        }

        //самая тупая сортировка
        double[] BogoSorting(double[] array)
        {
            while (!IsSorted(array))
            {
                Thread.Sleep(5);
                array = RandomPermutation(array);
                BogoGraph(BogoGraph1);
            }
            BogoGraph(BogoGraph1);
            return array;
        }

        static bool IsSorted(double[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] > array[i + 1])
                    return false;
            }
            return true;
        }

        static double[] RandomPermutation(double[] array)
        {
            Random random = new Random();
            var n = array.Length;
            while (n > 1)
            {
                n--;
                var i = random.Next(n + 1);
                var temp = array[i];
                array[i] = array[n];
                array[n] = temp;
            }
            return array;
        }

        //quick sort
        private void QuickSort(double[] arr, int leftStart, int rightEnd)
        {
            QuickGraph(QuickGraph1);
            Thread.Sleep(5);
            if (leftStart >= rightEnd)
            {
                return;
            }

            int pivotLocation = ChosePivotLocation(arr, leftStart, rightEnd);

            pivotLocation = OrderItemsAroundPivot(arr, leftStart, pivotLocation, rightEnd);

            QuickSort(arr, leftStart, pivotLocation - 1);

            QuickSort(arr, pivotLocation + 1, rightEnd);
            QuickGraph(QuickGraph1);
        }

        private  int OrderItemsAroundPivot(double[] arr, int leftStart, int pivotLocation, int rightEnd)
        {
            var pivot = arr[pivotLocation];
            Swap(arr, pivotLocation, rightEnd);
            var leftIndex = leftStart;
            var rightIndex = rightEnd - 1;
            while (leftIndex <= rightIndex)
            {
                if (arr[leftIndex] <= pivot)
                {
                    leftIndex++;
                    continue;
                }

                if (arr[rightIndex] >= pivot)
                {
                    rightIndex--;
                    continue;
                }
                Swap(arr, leftIndex, rightIndex);
            }
            Swap(arr, rightEnd, leftIndex);
            return leftIndex;
        }

        private  int ChosePivotLocation(double[] arr, int leftStart, int rightEnd)
        {
            var middle = leftStart + (rightEnd - leftStart) / 2;
            return middle;
        }

        //intersion sort 

        void InterSorting(double[] arr)
        {
            int n = arr.Length;
            for (int i = 1; i < n; ++i)
            {
                int key = (int)arr[i];
                int j = i - 1;
                InterGraph(IntersectionGraph1);

                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                    Thread.Sleep(5);
                    InterGraph(IntersectionGraph1);
                }
                arr[j + 1] = key;
                InterGraph(IntersectionGraph1);
            }
            InterGraph(IntersectionGraph1);
        }
        #endregion

        private void zedGraphControl1_Load(object sender, EventArgs e)
        {

        }


    }
}
