using System;
using System.Data;
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
        double[] unsortedArray;
        
        public Form1()
        {
            InitializeComponent();
        }


        private void закрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
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
                    dataGridView1[0, row].Value = rnd.Next(100);
                }
                dataGridView1.AllowUserToAddRows = true;
        }


        #endregion


        //From datagridview1 to mass
        private void DtgtoList()
        {
            dataGridView1.AllowUserToAddRows = false;
            unsortedArray = new double[dataGridView1.RowCount];

            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                unsortedArray[i] = double.Parse(dataGridView1[0, i].Value.ToString());
            }

            dataGridView1.AllowUserToAddRows = true;
        }


        private void genBtn_Click_1(object sender, EventArgs e)
        {
            GenerateData();
            DtgtoList();
            CreateGraph3(zedGraphControl1);
        }


        private async void button1_Click(object sender, EventArgs e)
        {
            if (bubblecheck.Checked)
            {
               await buildasync();
            }
        }

        private void CreateGraph3(ZedGraphControl zedGraphControl1)
        {
            // get a reference to the GraphPane
            GraphPane pane = zedGraphControl1.GraphPane;

            // Set the Titles
            pane.Title.Text = "Sorting";
            //Clear current values
            pane.CurveList.Clear();
            var n = unsortedArray.Length;
            // histogram high
            double[] values = new double[n];

            //fill values
            for (int i = 0; i < n; i++)
            {
                values[i] = unsortedArray[i]; //A1 is an array that is currently sort
            }

            //create histogram
            BarItem curve = pane.AddBar("Elements", null, values, Color.Blue);

            pane.BarSettings.MinClusterGap = 0.0F; //set columns references

            zedGraphControl1.AxisChange();
            zedGraphControl1.Invalidate();
        }

        static void Swap(double[] array, int i, int j)
        {
            double glass = array[i];
            array[i] = array[j];
            array[j] = glass;
        }

        private async Task buildasync()
        {
            await Task.Run(() => BubbleSorting(unsortedArray));
        }

        private void BubbleSorting(double[] unsortedArray)
        {
            var n = unsortedArray.Length;
            for (int i = 0; i < n; i++)
            { 
                for (int j = 0; j < n - i - 1; j++)
                {
                    Thread.Sleep(5);
                    if (unsortedArray[j] > unsortedArray[j + 1])
                    {
                        CreateGraph3(zedGraphControl1);
                        Swap(unsortedArray, j, j + 1);
                    }
                }
            }
             CreateGraph3(zedGraphControl1);
        }
        private void ShakerSorting(double[] array)
        {
            var n = unsortedArray.Length;
            int left = 0,
                right = n - 1;

            while (left < right)
            {

                for (int i = left; i < right; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        Swap(array, i, i + 1);
                        CreateGraph3(zedGraphControl1);
                    }
                }
                right--;

                for (int i = right; i > left; i--)
                {
                    if (array[i - 1] > array[i])
                    {
                        Swap(array, i - 1, i);
                        CreateGraph3(zedGraphControl1);
                    }
                }
                left++;
            }
            CreateGraph3(zedGraphControl1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
