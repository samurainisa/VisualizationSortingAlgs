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
        double[] unsortedArray5;
        double[] unsortedArray6;
        double[] unsortedArray7;
        double[] unsortedArray8;
        double[] unsortedArray9;

        int c;
        int d;

        List<Thread> threads = new List<Thread>();

        Stopwatch sw = new Stopwatch();
        Stopwatch sw1 = new Stopwatch();
        Stopwatch sw2 = new Stopwatch();
        Stopwatch sw3 = new Stopwatch();
        Stopwatch sw4 = new Stopwatch();
        Stopwatch sw5 = new Stopwatch();
        Stopwatch sw6 = new Stopwatch();
        Stopwatch sw7 = new Stopwatch();
        Stopwatch sw8 = new Stopwatch();
        Stopwatch sw9 = new Stopwatch();

        public Form1()
        {
            InitializeComponent();
            if (!revquickcheck.Checked) revquicksort.Visible = false;
            if (!revshaker.Checked) revshakergraph.Visible = false;
            if (!bubblecheck.Checked) BubbleGraph1.Visible = false;
            if (!shakercheck.Checked) ShakerGraph1.Visible = false;
            if (!quickcheck.Checked) QuickGraph1.Visible = false;
            if (!bogocheck.Checked) BogoGraph1.Visible = false;
            if (!Intersectioncheck.Checked) IntersectionGraph1.Visible = false;
            if (!revbubble.Checked) Revbubblegraph.Visible = false;
            if (!revbogocheck.Checked) revbogograph.Visible = false;
            if (!revinsectioncheck.Checked) Revintergraph.Visible = false;

            zedGraphDesign(BubbleGraph1);
            zedGraphDesign(ShakerGraph1);
            zedGraphDesign(QuickGraph1);
            zedGraphDesign(BogoGraph1);
            zedGraphDesign(IntersectionGraph1);
            zedGraphDesign(Revbubblegraph);
            zedGraphDesign(revshakergraph);
            zedGraphDesign(revquicksort);
            zedGraphDesign(Revintergraph);
            zedGraphDesign(revbogograph);
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void zedGraphDesign(ZedGraphControl BubbleGraph1)
        {
            GraphPane graphfield = BubbleGraph1.GraphPane;
            graphfield.Border.Color = Color.Black;
            graphfield.Chart.Border.Color = Color.Black;
            graphfield.Chart.Fill.Color = Color.White;
            graphfield.Title.FontSpec.Fill.Brush = new SolidBrush(Color.White);
            graphfield.Title.FontSpec.Fill.IsVisible = true;
            graphfield.Fill.Type = FillType.Solid;
            graphfield.Fill.Color = Color.FromArgb(50, 49, 69);
            graphfield.Chart.Fill.Type = FillType.Solid;
            graphfield.Chart.Fill.Color = Color.Black;
            graphfield.XAxis.Color = Color.CornflowerBlue;
            graphfield.YAxis.Color = Color.CornflowerBlue;
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
                    if (bubblecheck.Checked) BubbleGraph1.Visible = true;
                    if (shakercheck.Checked) ShakerGraph1.Visible = true;
                    if (quickcheck.Checked) QuickGraph1.Visible = true;
                    if (bogocheck.Checked) BogoGraph1.Visible = true;
                    if (Intersectioncheck.Checked) IntersectionGraph1.Visible = true;
                    if (revbubble.Checked) Revbubblegraph.Visible = true;
                    if (revshaker.Checked) revshakergraph.Visible = true;
                    if (revquickcheck.Checked) revquicksort.Visible = true;
                    if (revinsectioncheck.Checked) Revintergraph.Visible = true;
                    if (revbogocheck.Checked) revbogograph.Visible = true;


                    unsortedArray = null;
                    unsortedArray1 = null;
                    unsortedArray2 = null;
                    unsortedArray3 = null;
                    unsortedArray4 = null;
                    unsortedArray5 = null;
                    unsortedArray6 = null;
                    unsortedArray7 = null;
                    unsortedArray8 = null;
                    unsortedArray9 = null;
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
                MessageBox.Show($"При попытке загрузки из Excel произошла ошибка!\n{exception.Message}", "Error!", MessageBoxButtons.OK,
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
            dataGridView1.Rows.Clear();
            unsortedArray  = null;
            unsortedArray1 = null;
            unsortedArray2 = null;
            unsortedArray3 = null;
            unsortedArray4 = null;
            unsortedArray5 = null;
            unsortedArray6 = null;
            unsortedArray7 = null;
            unsortedArray8 = null;
            unsortedArray9 = null;

            await readAsync();
            if (bubblecheck.Checked) BubbleGraph1.Visible = true;
            if (shakercheck.Checked) ShakerGraph1.Visible = true;
            if (quickcheck.Checked) QuickGraph1.Visible = true;
            if (bogocheck.Checked) BogoGraph1.Visible = true;
            if (Intersectioncheck.Checked) IntersectionGraph1.Visible = true;
            if (revbubble.Checked) Revbubblegraph.Visible = true;
            if (revshaker.Checked) revshakergraph.Visible = true;
            if (revquickcheck.Checked) revquicksort.Visible = true;
            if (revinsectioncheck.Checked) Revintergraph.Visible = true;
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

        private async Task ReadAsync(SpreadsheetsResource.ValuesResource valuesResource)
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
                    dataGridView1[0, row].Value = rnd.Next(100);
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
            unsortedArray5 = new double[dataGridView1.RowCount];
            unsortedArray6 = new double[dataGridView1.RowCount];
            unsortedArray7 = new double[dataGridView1.RowCount];
            unsortedArray8 = new double[dataGridView1.RowCount];
            unsortedArray9 = new double[dataGridView1.RowCount];

            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                unsortedArray[i] = double.Parse(dataGridView1[0, i].Value.ToString());
                unsortedArray1[i] = double.Parse(dataGridView1[0, i].Value.ToString());
                unsortedArray2[i] = double.Parse(dataGridView1[0, i].Value.ToString());
                unsortedArray3[i] = double.Parse(dataGridView1[0, i].Value.ToString());
                unsortedArray4[i] = double.Parse(dataGridView1[0, i].Value.ToString());
                unsortedArray5[i] = double.Parse(dataGridView1[0, i].Value.ToString());
                unsortedArray6[i] = double.Parse(dataGridView1[0, i].Value.ToString());
                unsortedArray7[i] = double.Parse(dataGridView1[0, i].Value.ToString());
                unsortedArray8[i] = double.Parse(dataGridView1[0, i].Value.ToString());
                unsortedArray9[i] = double.Parse(dataGridView1[0, i].Value.ToString());
            }
            dataGridView1.AllowUserToAddRows = true;
        }

        private void genBtn_Click_1(object sender, EventArgs e)
        {
            if (bubblecheck.Checked) BubbleGraph1.Visible = true;
            if (shakercheck.Checked) ShakerGraph1.Visible = true;
            if (quickcheck.Checked) QuickGraph1.Visible = true;
            if (bogocheck.Checked) BogoGraph1.Visible = true;
            if (Intersectioncheck.Checked) IntersectionGraph1.Visible = true;
            if (revbubble.Checked) Revbubblegraph.Visible = true;
            if (revshaker.Checked) revshakergraph.Visible = true;
            if (revquickcheck.Checked) revquicksort.Visible = true;
            if (revinsectioncheck.Checked) Revintergraph.Visible = true;
            if (revbogocheck.Checked) revbogograph.Visible = true;
            GenerateData();
            DtgtoList();
            InitGraphics();
            button1.Enabled = true;
        }

        private void InitGraphics()
        {
            if (revbubble.Checked) RevBubbleGraph();
            if (bubblecheck.Checked) BubbleGraph();
            if (shakercheck.Checked) ShakerGraph();
            if (bogocheck.Checked) BogoGraph();
            if (quickcheck.Checked) QuickGraph();
            if (Intersectioncheck.Checked) InterGraph();
            if (revshaker.Checked) RevShakerGraph();
            if (revquickcheck.Checked) RevQuickSort();
            if (revinsectioncheck.Checked) RevInterSort();
            if (revbogocheck.Checked) RevBogoGraph();
        }

        #endregion

        #region Треды
        public void button1_Click(object sender, EventArgs e)
        {
            try
            {
                c = 0;
                d = 0;
                if (revinsectioncheck.Checked)
                {
                    c++;
                    Thread revinsec = new Thread(new ParameterizedThreadStart(ReverseInterSorting));
                    threads.Add(revinsec);
                    revinsec.Start(unsortedArray8);
                }
                if (revbogocheck.Checked)
                {
                    c++;
                    Thread revbogo = new Thread(new ParameterizedThreadStart(RevBogoSorting));
                    threads.Add(revbogo);
                    revbogo.Start(unsortedArray9);
                }
                if (quickcheck.Checked)
                {
                    Thread quick = new Thread(new ParameterizedThreadStart(CreateQuickSort));
                    threads.Add(quick);
                    quick.Start(unsortedArray3);
                }

                if (bubblecheck.Checked)
                {
                    
                    Thread bubble = new Thread(new ParameterizedThreadStart(BubbleSorting));
                    threads.Add(bubble);
                    bubble.Start(unsortedArray);
                }
                if (revbubble.Checked)
                {
                    c++;
                    Thread revbubble = new Thread(new ParameterizedThreadStart(ReverseBubbleSort));
                    threads.Add(revbubble);
                    revbubble.Start(unsortedArray);
                }

                if (shakercheck.Checked)
                {
                    c++;
                    Thread shaker = new Thread(new ParameterizedThreadStart(ShakerSorting));
                    threads.Add(shaker);
                    shaker.Start(unsortedArray1);
                }

                if (revshaker.Checked)
                {
                    c++;
                    Thread revshaker = new Thread(new ParameterizedThreadStart(RevShakerSorting));
                    threads.Add(revshaker);
                    revshaker.Start(unsortedArray6);
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
                if (revquickcheck.Checked)
                {
                    c++;
                    Thread revquick = new Thread(new ParameterizedThreadStart(ReverseQuickSorting));
                    threads.Add(revquick);
                    revquick.Start(unsortedArray7);
                }

                buttoncheck();
            }
            catch (Exception ex)
            {
                
            }
        }
        #endregion

        #region Визуализация
        private void RevQuickSort()
        {
            GraphPane pane = revquicksort.GraphPane;
            pane.Title.Text = "Reverse QuickSort";
            pane.CurveList.Clear();
            int n = unsortedArray7.Length;
            double[] values = new double[n];
            for (int k = 0; k < n; k++)
            {
                values[k] = unsortedArray7[k];
            }
            BarItem curve = pane.AddBar("Elements", null, values, Color.White);
            pane.BarSettings.MinClusterGap = 0F;
            revquicksort.AxisChange();
            revquicksort.Invalidate();
        }

        private void RevInterSort()
        {
            GraphPane pane = Revintergraph.GraphPane;
            pane.Title.Text = "Reverse InserSort";
            pane.CurveList.Clear();
            int n = unsortedArray8.Length;
            double[] values = new double[n];
            for (int k = 0; k < n; k++)
            {
                values[k] = unsortedArray8[k];
            }
            BarItem curve = pane.AddBar("Elements", null, values, Color.White);
            pane.BarSettings.MinClusterGap = 0F;
            Revintergraph.AxisChange();
            Revintergraph.Invalidate();
        }

        private void BubbleGraph()
        {
            GraphPane pane = BubbleGraph1.GraphPane;
            pane.Title.Text = "BubbleSort";
            pane.CurveList.Clear();
            int n = unsortedArray.Length;
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
            pane.Title.Text = "BogoSort";
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

        private void RevBogoGraph()
        {
            GraphPane pane = revbogograph.GraphPane;
            pane.Title.Text = "Rev BogoSort";
            pane.CurveList.Clear();
            var n = unsortedArray9.Length;
            double[] values = new double[n];
            for (int i = 0; i < n; i++)
            {
                values[i] = unsortedArray9[i];
            }
            BarItem curve = pane.AddBar("Elements", null, values, Color.White);
            pane.BarSettings.MinClusterGap = 0F;
            revbogograph.AxisChange();
            revbogograph.Invalidate();
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

        private void InterGraph()
        {
            GraphPane pane = IntersectionGraph1.GraphPane;
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
            IntersectionGraph1.AxisChange();
            IntersectionGraph1.Invalidate();
        }

        private void RevShakerGraph()
        {
            GraphPane pane = revshakergraph.GraphPane;
            pane.Title.Text = "Reverse ShakerSort";
            pane.CurveList.Clear();
            var n = unsortedArray6.Length;
            double[] values = new double[n];
            for (int k = 0; k < n; k++)
            {
                values[k] = unsortedArray6[k];
            }
            BarItem curve = pane.AddBar("Elements", null, values, Color.White);
            pane.BarSettings.MinClusterGap = 0F;
            revshakergraph.AxisChange();
            revshakergraph.Invalidate();
        }

        private void RevBubbleGraph()
        {
            GraphPane pane = Revbubblegraph.GraphPane;
            pane.Title.Text = "Reverse BubbleSort";
            pane.CurveList.Clear();
            var n = unsortedArray5.Length;
            double[] values = new double[n];
            for (int k = 0; k < n; k++)
            {
                values[k] = unsortedArray5[k];
            }
            BarItem curve = pane.AddBar("Elements", null, values, Color.White);
            pane.BarSettings.MinClusterGap = 0F;
            Revbubblegraph.AxisChange();
            Revbubblegraph.Invalidate();
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
            try
            {
                sw1.Restart();
                sw1.Start();

                if (unsortedArrayy != null)
                {
                    var n = unsortedArray.Length;
                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < n - i - 1; j++)
                        {
                            Thread.Sleep(5);
                            if (unsortedArray[j] > unsortedArray[j + 1])
                            {
                                GraphPane pane = BubbleGraph1.GraphPane;
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
                    var v = unsortedArray.Length;
                    GraphPane pane1 = BubbleGraph1.GraphPane;
                    pane1.CurveList.Clear();
                    double[] values1 = new double[v];
                    for (int k = 0; k < v; k++)
                    {
                        values1[k] = unsortedArray[k];
                    }
                    BarItem curve1 = pane1.AddBar("Elements", null, values1, Color.White);
                    pane1.BarSettings.MinClusterGap = 0F;
                    BubbleGraph1.AxisChange();
                    BubbleGraph1.Invalidate();
                    sw1.Stop();
                }


                Invoke((MethodInvoker)delegate
                {
                    bubbletime.Text = Math.Round((sw1.Elapsed.TotalMilliseconds / 1000), 2).ToString() + "s";
                });
                d++;
                buttoncheck();
            }
            catch (Exception ex)
            {
                
            }

        }

        private void ReverseBubbleSort(object unsarr)
        {
            try
            {
                sw5.Restart();
                sw5.Start();
                if (unsarr != null)
                {
                    var n = unsortedArray5.Length;
                    for (int i = 0; i < n; i++)
                    {

                        for (int j = 0; j < n - i - 1; j++)
                        {
                            Thread.Sleep(5);
                            if (unsortedArray5[j] < unsortedArray5[j + 1])
                            {
                                GraphPane pane = Revbubblegraph.GraphPane;
                                pane.CurveList.Clear();
                                double[] values = new double[n];
                                for (int k = 0; k < n; k++)
                                {
                                    values[k] = unsortedArray5[k];
                                }
                                BarItem curve = pane.AddBar("Elements", null, values, Color.White);
                                pane.BarSettings.MinClusterGap = 0F;
                                Revbubblegraph.AxisChange();
                                Revbubblegraph.Invalidate();
                                Swap(unsortedArray5, j, j + 1);
                            }
                            GraphPane pane1 = Revbubblegraph.GraphPane;
                            pane1.CurveList.Clear();
                            double[] values1 = new double[n];
                            for (int k = 0; k < n; k++)
                            {
                                values1[k] = unsortedArray5[k];
                            }
                            BarItem curve1 = pane1.AddBar("Elements", null, values1, Color.White);
                            pane1.BarSettings.MinClusterGap = 0F;
                            Revbubblegraph.AxisChange();
                            Revbubblegraph.Invalidate();
                        }
                    }
                }
                sw5.Stop();
                Invoke((MethodInvoker)delegate
                {
                    label2.Text = Math.Round((sw5.Elapsed.TotalMilliseconds / 1000), 2).ToString() + "s";

                });
                d++;
                buttoncheck();
            }
            catch (Exception ex)
            {
                
            }
        }
        //шейкерная сортировка
        private void ShakerSorting(object array)
        {
            try
            {
                sw2.Restart();
                sw2.Start();
                if (array != null)
                {
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
                            }
                        }
                        left++;
                    }
                    GraphPane pane1 = ShakerGraph1.GraphPane;
                    pane1.CurveList.Clear();
                    double[] values1 = new double[n];
                    for (int k = 0; k < n; k++)
                    {
                        values1[k] = unsortedArray1[k];
                    }
                    BarItem curve1 = pane1.AddBar("Elements", null, values1, Color.White);
                    pane1.BarSettings.MinClusterGap = 0F;
                    ShakerGraph1.AxisChange();
                    ShakerGraph1.Invalidate();

                }
                sw2.Stop();
                Invoke((MethodInvoker)delegate
                {
                    shakertime.Text = Math.Round((sw2.Elapsed.TotalMilliseconds / 1000), 2).ToString() + "s";
                });
                d++;
                buttoncheck();
            }

            catch (Exception ex)
            {
                
            }
        }

        private void RevShakerSorting(object array1)
        {
            try
            {
                if (array1 != null)
                {
                    GraphPane pane = revshakergraph.GraphPane;
                    GraphPane pane1 = revshakergraph.GraphPane;
                    int n = unsortedArray6.Length;
                    sw6.Restart();
                    sw6.Start();
                    for (int i = 0; i < unsortedArray6.Length / 2; i++)
                    {
                        bool swapped = false;
                        for (int j = i; j < unsortedArray6.Length - i - 1; j++)
                        {
                            if (unsortedArray6[j] < unsortedArray6[j + 1])
                            {
                                double tmp = unsortedArray6[j];
                                unsortedArray6[j] = unsortedArray6[j + 1];
                                unsortedArray6[j + 1] = tmp;
                                swapped = true;

                                Invoke((MethodInvoker)delegate
                                {
                                    pane.CurveList.Clear();
                                });

                                double[] values = new double[n];
                                for (int k = 0; k < n; k++)
                                {
                                    values[k] = unsortedArray6[k];
                                }
                                Invoke((MethodInvoker)delegate
                                {
                                    BarItem curve = pane.AddBar("Elements", null, values, Color.White);
                                    pane.BarSettings.MinClusterGap = 0F;
                                    revshakergraph.AxisChange();
                                    revshakergraph.Invalidate();
                                });
                                Thread.Sleep(5);
                            }
                        }
                        for (int j = unsortedArray6.Length - 2 - i; j > i; j--)
                        {
                            if (unsortedArray6[j] > unsortedArray6[j - 1])
                            {
                                double tmp = unsortedArray6[j];
                                unsortedArray6[j] = unsortedArray6[j - 1];
                                unsortedArray6[j - 1] = tmp;
                                swapped = true;
                            }
                        }

                        if (!swapped) break;
                        Invoke((MethodInvoker)delegate
                        {
                            pane1.CurveList.Clear();
                        });

                        double[] values1 = new double[n];
                        for (int k = 0; k < n; k++)
                        {
                            values1[k] = unsortedArray6[k];
                        }

                        Invoke((MethodInvoker)delegate
                        {
                            BarItem curve1 = pane1.AddBar("Elements", null, values1, Color.White);
                            pane1.BarSettings.MinClusterGap = 0F;
                            revshakergraph.AxisChange();
                            revshakergraph.Invalidate();
                        });
                    }
                }
                sw6.Stop();
                Invoke((MethodInvoker)delegate
                {
                    revshakertime.Text = Math.Round((sw6.Elapsed.TotalMilliseconds / 1000), 2).ToString() + "s";
                });
                d++;
                buttoncheck();
            }
            catch(Exception ex)
            {

            }
        }
        //самая тупая сортировка
        public void BogoSorting(object array2)
        {
            try
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

            catch (Exception ex)
            {

            }
        }

        public bool IsSorted(double[] array)
        {
            try
            {
                if(array != null)
                {
                    for (int i = 0; i < array.Length - 1; i++)
                    {
                        if (array[i] > array[i+1])
                            return false;
                    }
                    return true;
                }
                return true;
            }
            catch
            {
                return true;
            }
        }

        public void RevBogoSorting(object array2)
        {
            try
            {
                sw9.Restart();
                sw9.Start();
                while (!IsSorted1(unsortedArray9))
                {
                    unsortedArray9 = RandomPermutation(unsortedArray9);
                    GraphPane pane = revbogograph.GraphPane;
                    pane.CurveList.Clear();
                    var n = unsortedArray9.Length;
                    double[] values = new double[n];
                    for (int i = 0; i < n; i++)
                    {
                        values[i] = unsortedArray9[i];
                    }
                    BarItem curve = pane.AddBar("Elements", null, values, Color.White);
                    pane.BarSettings.MinClusterGap = 0F;
                    revbogograph.AxisChange();
                    revbogograph.Invalidate();
                }
                d++;
                buttoncheck();
                sw9.Stop();
                Invoke((MethodInvoker)delegate
                {
                    label9.Text = Math.Round((sw9.Elapsed.TotalMilliseconds / 1000), 2).ToString() + "s";
                });
            }

            catch (Exception ex)
            {

            }
        }

        public bool IsSorted1(double[] array)
        {
            try
            {
                if (array != null)
                {
                    for (int i = 0; i < array.Length - 1; i++)
                    {
                        if (array[i+1] > array[i])
                            return false;
                    }
                    return true;
                }
                return true;
            }
            catch
            {
                return true;
            }
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
            sw.Restart();
            sw.Start();

            QuickSort(unsortedArray3, 0, unsortedArray3.Length - 1);

            sw.Stop();
            Invoke((MethodInvoker)delegate
            {
                quicktime.Text = Math.Round((sw.Elapsed.TotalMilliseconds / 1000), 2).ToString() + "s";
            });
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
            QuickGraph1.AxisChange();
            QuickGraph1.Invalidate();
        }

        private int OrderItemsAroundPivot(double[] arr, int leftStart, int pivotLocation, int rightEnd)
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

        private int ChosePivotLocation(double[] arr, int leftStart, int rightEnd)
        {
            var middle = leftStart + (rightEnd - leftStart) / 2;
            return middle;
        }

        //реверс быстрая сорт
        public void ReverseQuickSorting(object array)
        {
            sw7.Restart();
            sw7.Start();
            if (array != null)
            {
                quickSort(unsortedArray7, 0, unsortedArray7.Length - 1);
            }
            sw7.Stop();
            Invoke((MethodInvoker)delegate
            {
                label7.Text = Math.Round((sw7.Elapsed.TotalMilliseconds / 1000), 2).ToString() + "s";
            });
        }

        private void quickSort(double[] array, int p, int r)
        {
            if (p < r)
            {
                int q = partition(array, p, r);
                Thread.Sleep(5);
                quickSort(array, p, q - 1);
                quickSort(array, q + 1, r);
                GraphPane pane = revquicksort.GraphPane;
                pane.CurveList.Clear();
                int n = unsortedArray7.Length;
                double[] values = new double[n];
                for (int k = 0; k < n; k++)
                {
                    values[k] = unsortedArray7[k];
                }
                BarItem curve = pane.AddBar("Elements", null, values, Color.White);
                pane.BarSettings.MinClusterGap = 0F;
                revquicksort.AxisChange();
                revquicksort.Invalidate();
            }
        }

        private int partition(double[] array, int p, int r)
        {
            int i = p - 1;
            int j = p;
            while (j < r)
            {
                /** Just change compare condition **/
                if (array[j] > array[r])
                {
                    Swap(array, i + 1, j);
                    i++;
                }
                j++;
            }
            Swap(array, i + 1, r);
            return i + 1;
        }

        //intersion sort 
        public void InterSorting(object array3)
        {
            try
            {
                sw4.Restart();
                sw4.Start();

                if (array3 != null)
                {
                    var n = unsortedArray4.Length;
                    for (int i = 1; i < n; ++i)
                    {
                        int key = (int)unsortedArray4[i];
                        int j = i - 1;

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
                }
                sw4.Stop();
                Invoke((MethodInvoker)delegate
                {
                    insectime.Text = Math.Round((sw4.Elapsed.TotalMilliseconds / 1000), 2).ToString() + "s";
                });
                d++;
                buttoncheck();
            }

            catch (Exception ex)
            {
                
            }
        }

        //reverse intesion sort
        public void ReverseInterSorting(object array3)
        {
            try
            {
                sw8.Restart();
                sw8.Start();
                if (array3 != null)
                {
                    var n = unsortedArray8.Length;
                    for (int i = 1; i < n; ++i)
                    {
                        int key = (int)unsortedArray8[i];
                        int j = i - 1;

                        GraphPane pane = Revintergraph.GraphPane;
                        pane.CurveList.Clear();
                        double[] values1 = new double[n];
                        for (int k = 0; k < n; k++)
                        {
                            values1[k] = unsortedArray8[k];
                        }
                        BarItem curve1 = pane.AddBar("Elements", null, values1, Color.White);
                        pane.BarSettings.MinClusterGap = 0F;
                        Revintergraph.AxisChange();
                        Revintergraph.Invalidate();

                        while (j >= 0 && unsortedArray8[j] < key)
                        {
                            unsortedArray8[j + 1] = unsortedArray8[j];
                            Thread.Sleep(5);
                            j = j - 1;
                        }
                        unsortedArray8[j + 1] = key;
                    }
                    GraphPane pane1 = Revintergraph.GraphPane;
                    pane1.CurveList.Clear();
                    double[] values = new double[n];
                    for (int k = 0; k < n; k++)
                    {
                        values[k] = unsortedArray8[k];
                    }
                    BarItem curve = pane1.AddBar("Elements", null, values, Color.White);
                    pane1.BarSettings.MinClusterGap = 0F;
                    Revintergraph.AxisChange();
                    Revintergraph.Invalidate();
                }
                sw8.Stop();
                Invoke((MethodInvoker)delegate
                {
                    label4.Text = Math.Round((sw8.Elapsed.TotalMilliseconds / 1000), 2).ToString() + "s";
                });
                d++;
                buttoncheck();
            }
            catch (Exception ex)
            {
                
            }

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

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                  foreach (var item in threads)
                  {
                      if (item.ThreadState != System.Threading.ThreadState.Stopped)
                      {
                          item.Abort();
                      }
                  }
                button1.Enabled = true;
            }

            catch (Exception ex)
            {
/*                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);*/
                Console.WriteLine(ex.Message);
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

        private void очиститьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearAll();
        }
        private void ClearAll()
        {
            try
            {
                foreach (var item in threads)
                {
                    item.Abort();
                }
                GraphPane pane = BubbleGraph1.GraphPane;
                GraphPane pane1 = ShakerGraph1.GraphPane;
                GraphPane pane2 = QuickGraph1.GraphPane;
                GraphPane pane3 = revshakergraph.GraphPane;
                GraphPane pane4 = BogoGraph1.GraphPane;
                GraphPane pane5 = Revbubblegraph.GraphPane;
                GraphPane pane6 = revquicksort.GraphPane;
                GraphPane pane7 = IntersectionGraph1.GraphPane;
                GraphPane pane8 = Revintergraph.GraphPane;
                GraphPane pane9 = Revintergraph.GraphPane;


                dataGridView1.Rows.Clear();
                pane.CurveList.Clear();
                pane1.CurveList.Clear();
                pane2.CurveList.Clear();
                pane3.CurveList.Clear();
                pane4.CurveList.Clear();
                pane5.CurveList.Clear();
                pane6.CurveList.Clear();
                pane7.CurveList.Clear();
                pane8.CurveList.Clear();
                pane9.CurveList.Clear();

                unsortedArray = null;
                unsortedArray1 = null;
                unsortedArray2 = null;
                unsortedArray3 = null;
                unsortedArray4 = null;
                unsortedArray5 = null;
                unsortedArray6 = null;
                unsortedArray7 = null;
                unsortedArray8 = null;
                unsortedArray9 = null;
                BubbleGraph1.Visible = false;
                ShakerGraph1.Visible = false;
                QuickGraph1.Visible = false;
                BogoGraph1.Visible = false;
                IntersectionGraph1.Visible = false;
                Revbubblegraph.Visible = false;
                revshakergraph.Visible = false;
                revquicksort.Visible = false;
                Revintergraph.Visible = false;
                revbogograph.Visible = false;  

                GC.Collect();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
