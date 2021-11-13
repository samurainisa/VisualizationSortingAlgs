using System;
using System.Collections.Generic;
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
using Action = System.Action;
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
        int c;
        int d;
        List<Thread> threads = new List<Thread>();
        public bool pause;
        Stopwatch sw = new Stopwatch();
        Stopwatch sw1 = new Stopwatch();
        Stopwatch sw2 = new Stopwatch();
        Stopwatch sw3 = new Stopwatch();
        Stopwatch sw4 = new Stopwatch();

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
            try
            {
                foreach (var item in threads)
                {
                    item.Abort();
                }
                Thread.Sleep(10);
                GC.Collect();
                Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void zedGraphDesign(ZedGraphControl BubbleGraph1)
        {
            GraphPane graphfield = BubbleGraph1.GraphPane;
            graphfield.Border.Color = Color.Black;
            graphfield.Chart.Border.Color = Color.Black;
            graphfield.Fill.Type = FillType.Solid;
            graphfield.Fill.Color = Color.Black;
            graphfield.Chart.Fill.Type = FillType.Solid;
            graphfield.Chart.Fill.Color = Color.White;
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
            string SpreadsheetId = googleid.Text.ToString();
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
            try
            {
                dataGridView1.AllowUserToAddRows = false;
                dataGridView1.Rows.Clear();
                int Yn = Convert.ToInt32(arraynum.Text);
                Random rnd = new Random();

                for (int row = 0; row < Yn; row++)
                {
                    dataGridView1.Rows.Add();
                    dataGridView1[0, row].Value = rnd.Next(500);
                }
                dataGridView1.AllowUserToAddRows = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


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
            if(bubblecheck.Checked) BubbleGraph();
            if(shakercheck.Checked) ShakerGraph();
            if(bogocheck.Checked) BogoGraph();
            if(quickcheck.Checked) QuickGraph();
            if(Intersectioncheck.Checked) InterGraph(IntersectionGraph1);
        }

        #endregion

        public void buttoncheck()
        {
            Invoke((MethodInvoker)delegate
            {
                if (c == d)
                {
                    button1.Enabled = true;
                }
                else
                {
                    button1.Enabled = false;
                }
            });
        }
        #region Треды


        public void button1_Click(object sender, EventArgs e)
        {
            c = 0;
            d = 0;
            pause = true;

            if (quickcheck.Checked)
            {
                Thread quick = new Thread(new ParameterizedThreadStart(CreateQuickSort));
                threads.Add(quick);
                quick.Start(unsortedArray3);
            }

            if (bubblecheck.Checked)
            {
                c++;
                Thread bubble = new Thread(new ParameterizedThreadStart(BubbleSorting));
                threads.Add(bubble);
                bubble.Start(unsortedArray);
            }

            if (shakercheck.Checked)
            {
                c++;
                Thread shaker = new Thread(new ParameterizedThreadStart(ShakerSorting));
                threads.Add(shaker);
                shaker.Start(unsortedArray1);
            }

            if (bogocheck.Checked)
            {
                c++;
                Thread bogo = new Thread(new ParameterizedThreadStart(BogoSorting));
                threads.Add(bogo);
                bogo.Start(unsortedArray2);
            }

            if (Intersectioncheck.Checked)
            {
                c++;
                Thread inter = new Thread(new ParameterizedThreadStart(InterSorting));
                threads.Add(inter);
                inter.Start(unsortedArray4);
            }
            buttoncheck();
        }


        private void button2_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region Визуализация
        private void BubbleGraph()
        {
            GraphPane pane = BubbleGraph1.GraphPane;
            pane.Title.Text = "BubbleSort";
            pane.CurveList.Clear();
            int n =  unsortedArray.Length;
            double[] values = new double[n];
            for (int k = 0; k < n; k++)
            {
                values[k] = unsortedArray[k];
            }
            BarItem curve = pane.AddBar("Elements", null, values, Color.White);
            pane.BarSettings.MinClusterGap = 0F;
            BubbleGraph1.AxisChange();
            BubbleGraph1.Invalidate();
        }

        private void ShakerGraph()
        {
            GraphPane pane = ShakerGraph1.GraphPane;
            pane.Title.Text = "ShakerSort";
            pane.CurveList.Clear();
            var n = unsortedArray1.Length;
            double[] values = new double[n];
            for (int i = 0; i < n; i++)
            {
                values[i] = unsortedArray1[i];
            }
            BarItem curve = pane.AddBar("Elements", null, values, Color.White);
            pane.BarSettings.MinClusterGap = 0F;
            ShakerGraph1.AxisChange();
            ShakerGraph1.Invalidate();
        }
        private void BogoGraph()
        {
            GraphPane pane = BogoGraph1.GraphPane;
            pane.Title.Text = "BubbleSort";
            pane.CurveList.Clear();
            var n = unsortedArray2.Length;
            double[] values = new double[n];
            for (int i = 0; i < n; i++)
            {
                values[i] = unsortedArray2[i];
            }
            BarItem curve = pane.AddBar("Elements", null, values, Color.White);
            pane.BarSettings.MinClusterGap = 0F;
            BogoGraph1.AxisChange();
            BogoGraph1.Invalidate();
        }
        private void QuickGraph()
        {
            GraphPane pane = QuickGraph1.GraphPane;
            pane.Title.Text = "QuickSort";
            pane.CurveList.Clear();
            var n = unsortedArray3.Length;
            double[] values = new double[n];
            for (int i = 0; i < n; i++)
            {
                values[i] = unsortedArray3[i];
            }
            BarItem curve = pane.AddBar("Elements", null, values, Color.White);
            pane.BarSettings.MinClusterGap = 0F;
            QuickGraph1.AxisChange();
            QuickGraph1.Invalidate();

        }
        private void InterGraph(ZedGraphControl intergraph)
        {
            GraphPane pane = intergraph.GraphPane;
            pane.Title.Text = "IntersionSort";
            pane.CurveList.Clear();
            var n = unsortedArray4.Length;
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
        private void BubbleSorting(object unsortedArrayy)
        {
            sw1.Restart();
            sw1.Start();
            var n = unsortedArray.Length;
            for (int i = 0; i < n; i++)
            {

                for (int j = 0; j < n - i - 1; j++)
                {
                    Thread.Sleep(5);
                    if (unsortedArray[j] > unsortedArray[j + 1])
                    {
                        GraphPane pane = BubbleGraph1.GraphPane;
                        pane.Title.Text = "BubbleSort";
                        pane.CurveList.Clear();
                        double[] values = new double[n];
                        for (int k = 0; k < n; k++)
                        {
                            values[k] = unsortedArray[k];
                        }
                        BarItem curve = pane.AddBar("Elements", null, values, Color.White);
                        pane.BarSettings.MinClusterGap = 0F;
                        BubbleGraph1.AxisChange();
                        BubbleGraph1.Invalidate();
                        Swap(unsortedArray, j, j + 1);
                    }
                }
            }
            Thread.Sleep(500);
            sw1.Stop();
            Invoke((MethodInvoker)delegate
            {
                bubbletime.Text = Math.Round((sw1.Elapsed.TotalMilliseconds / 1000), 2).ToString() + "s";

            });
            d++;
            buttoncheck();
        }

        //шейкерная сортировка
        private void ShakerSorting(object array)
        {
            sw2.Restart();
            sw2.Start();
            var n = unsortedArray1.Length;
            int left = 0,
                right = n - 1;

            while (left < right)
            {
                for (int i = left; i < right; i++)
                {
                    if (unsortedArray1[i] > unsortedArray1[i + 1])
                    {
                        Swap(unsortedArray1, i, i + 1);

                        GraphPane pane = ShakerGraph1.GraphPane;
                        pane.CurveList.Clear();
                        double[] values = new double[n];
                        for (int k = 0; k < n; k++)
                        {
                            values[k] = unsortedArray1[k];
                        }
                        BarItem curve = pane.AddBar("Elements", null, values, Color.White);
                        pane.BarSettings.MinClusterGap = 0F;
                        ShakerGraph1.AxisChange();
                        ShakerGraph1.Invalidate();
                        Thread.Sleep(5);
                    }
                }
                right--;

                for (int i = right; i > left; i--)
                {
                    if (unsortedArray1[i - 1] > unsortedArray1[i])
                    {
                        Swap(unsortedArray1, i - 1, i);
/*                        ShakerGraph(ShakerGraph1);*/
                    }
                }
                left++;
            }
/*            ShakerGraph(ShakerGraph1);*/
            sw2.Stop();
            Invoke((MethodInvoker)delegate
            {
                shakertime.Text = Math.Round((sw2.Elapsed.TotalMilliseconds / 1000), 2).ToString() + "s";
            });
            d++;
            buttoncheck();
        }

        //самая тупая сортировка
        public void BogoSorting(object array2)
        {
            sw3.Restart();
            sw3.Start();
            while (!IsSorted(unsortedArray2))
            {
                unsortedArray2 = RandomPermutation(unsortedArray2);
                GraphPane pane = BogoGraph1.GraphPane;
                pane.CurveList.Clear();
                var n = unsortedArray2.Length;
                double[] values = new double[n];
                for (int i = 0; i < n; i++)
                {
                    values[i] = unsortedArray2[i];
                }
                BarItem curve = pane.AddBar("Elements", null, values, Color.White);
                pane.BarSettings.MinClusterGap = 0F;
                BogoGraph1.AxisChange();
                BogoGraph1.Invalidate();
            }
            d++;
            buttoncheck();
            sw3.Stop();
            Invoke((MethodInvoker)delegate
            {
                bogotime.Text = Math.Round((sw3.Elapsed.TotalMilliseconds / 1000), 2).ToString() + "s";
            });
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

         double[] RandomPermutation(double[] array)
        {
            Random random = new Random();
            var n = dataGridView1.RowCount - 1;
            while (n > 1)
            {
                n--;
                var i = random.Next(n + 1);
                var temp = array[i];
                array[i] = array[n];
                array[n] = temp;
                Thread.Sleep(5);
            }
            return array;
        }

        //quick sort
        private void CreateQuickSort(object array4)
        {
            try
            {
                sw.Restart();
                sw.Start();
                QuickSort(unsortedArray3, 0, unsortedArray3.Length - 1);
                sw.Stop();
                Invoke((MethodInvoker)delegate
                {
                    quicktime.Text = Math.Round((sw.Elapsed.TotalMilliseconds / 1000), 2).ToString() + "s";
                });
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Сгенерируйте данные", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void QuickSort(double[] arr, int leftStart, int rightEnd)
        {
            if (leftStart >= rightEnd)
            {
                return;
            }
            int pivotLocation = ChosePivotLocation(arr, leftStart, rightEnd);
            pivotLocation = OrderItemsAroundPivot(arr, leftStart, pivotLocation, rightEnd);
            Thread.Sleep(5);
            QuickSort(arr, leftStart, pivotLocation - 1);
            QuickSort(arr, pivotLocation + 1, rightEnd);

            //отрисовка
            GraphPane pane = QuickGraph1.GraphPane;

            pane.CurveList.Clear();

            var n = unsortedArray3.Length;
            double[] values = new double[n];
            for (int i = 0; i < n; i++)
            {
                values[i] = unsortedArray3[i];
            }
            BarItem curve = pane.AddBar("Elements", null, values, Color.White);

            Invoke((MethodInvoker)delegate {             
            QuickGraph1.AxisChange();
            QuickGraph1.Invalidate(); });
       }

        private int OrderItemsAroundPivot(double[] arr, int leftStart, int pivotLocation, int rightEnd)
        {
            var pivot = arr[pivotLocation];
            Swap(arr, pivotLocation, rightEnd);
            Thread.Sleep(5);
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

        private int ChosePivotLocation(double[] arr, int leftStart, int rightEnd)
        {
            var middle = leftStart + (rightEnd - leftStart) / 2;
            return middle;
        }

        //intersion sort 
        public void InterSorting(object array3)
        {
            sw4.Restart();
            sw4.Start();


            var n = unsortedArray4.Length;
            for (int i = 1; i < n; ++i)
            {
                int key = (int)unsortedArray4[i];
                int j = i - 1;

                /*Invoke((MethodInvoker)delegate { InterGraph(IntersectionGraph1); });*/

                GraphPane pane = IntersectionGraph1.GraphPane;
                pane.CurveList.Clear();
                double[] values1 = new double[n];
                for (int k = 0; k < n; k++)
                {
                    values1[k] = unsortedArray4[k];
                }
                BarItem curve1 = pane.AddBar("Elements", null, values1, Color.White);
                pane.BarSettings.MinClusterGap = 0F;
                IntersectionGraph1.AxisChange();
                IntersectionGraph1.Invalidate();

                while (j >= 0 && unsortedArray4[j] > key)
                {
                    unsortedArray4[j + 1] = unsortedArray4[j];
                    Thread.Sleep(5);
                    j = j - 1;
                }
                unsortedArray4[j + 1] = key;
            }
            GraphPane pane1 = IntersectionGraph1.GraphPane;
            pane1.CurveList.Clear();
            double[] values = new double[n];
            for (int k = 0; k < n; k++)
            {
                values[k] = unsortedArray4[k];
            }
            BarItem curve = pane1.AddBar("Elements", null, values, Color.White);
            pane1.BarSettings.MinClusterGap = 0F;
            IntersectionGraph1.AxisChange();
            IntersectionGraph1.Invalidate();
            sw4.Stop();
            Invoke((MethodInvoker)delegate
            {
                insectime.Text = Math.Round((sw4.Elapsed.TotalMilliseconds / 1000), 2).ToString() + "s";
            });
            d++;
        }
        #endregion

        private  void button3_Click(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    foreach (var item in threads)
                    {
                        if (item.ThreadState != System.Threading.ThreadState.Stopped)
                        {
                            item.Suspend();
                        }
                    }
                }
                catch (Exception ex) { MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (var item in threads)
                {
                    if (item.ThreadState != System.Threading.ThreadState.Stopped)
                    {
                        item.Resume();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
