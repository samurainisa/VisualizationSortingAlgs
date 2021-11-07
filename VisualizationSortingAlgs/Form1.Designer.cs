
namespace Algorithm
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Mass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genBtn = new System.Windows.Forms.Button();
            this.arraynum = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.закрытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.googleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.bubblecheck = new System.Windows.Forms.CheckBox();
            this.SortLabel = new System.Windows.Forms.Label();
            this.TimeElapsedLabel = new System.Windows.Forms.Label();
            this.ComparisonLabel = new System.Windows.Forms.Label();
            this.SortCounterLabel = new System.Windows.Forms.Label();
            this.TimeElapsedInt = new System.Windows.Forms.Label();
            this.ComparisonInt = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ShakerGraph1 = new ZedGraph.ZedGraphControl();
            this.shakercheck = new System.Windows.Forms.CheckBox();
            this.IntersectionGraph1 = new ZedGraph.ZedGraphControl();
            this.Intersectioncheck = new System.Windows.Forms.CheckBox();
            this.QuickGraph1 = new ZedGraph.ZedGraphControl();
            this.quickcheck = new System.Windows.Forms.CheckBox();
            this.BogoGraph1 = new ZedGraph.ZedGraphControl();
            this.bogocheck = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.BubbleGraph1 = new ZedGraph.ZedGraphControl();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Mass});
            this.dataGridView1.Location = new System.Drawing.Point(11, 90);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(242, 524);
            this.dataGridView1.TabIndex = 0;
            // 
            // Mass
            // 
            this.Mass.HeaderText = "Массив";
            this.Mass.Name = "Mass";
            this.Mass.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Mass.Width = 200;
            // 
            // genBtn
            // 
            this.genBtn.Location = new System.Drawing.Point(58, 677);
            this.genBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.genBtn.Name = "genBtn";
            this.genBtn.Size = new System.Drawing.Size(152, 41);
            this.genBtn.TabIndex = 1;
            this.genBtn.Text = "Сгенерировать массив";
            this.genBtn.UseVisualStyleBackColor = true;
            this.genBtn.Click += new System.EventHandler(this.genBtn_Click_1);
            // 
            // arraynum
            // 
            this.arraynum.Location = new System.Drawing.Point(78, 652);
            this.arraynum.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.arraynum.Name = "arraynum";
            this.arraynum.Size = new System.Drawing.Size(106, 19);
            this.arraynum.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.закрытьToolStripMenuItem,
            this.excelToolStripMenuItem,
            this.googleToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1506, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // закрытьToolStripMenuItem
            // 
            this.закрытьToolStripMenuItem.Name = "закрытьToolStripMenuItem";
            this.закрытьToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.закрытьToolStripMenuItem.Text = "Закрыть";
            this.закрытьToolStripMenuItem.Click += new System.EventHandler(this.закрытьToolStripMenuItem_Click);
            // 
            // excelToolStripMenuItem
            // 
            this.excelToolStripMenuItem.Name = "excelToolStripMenuItem";
            this.excelToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.excelToolStripMenuItem.Text = "Excel";
            this.excelToolStripMenuItem.Click += new System.EventHandler(this.excelToolStripMenuItem_Click);
            // 
            // googleToolStripMenuItem
            // 
            this.googleToolStripMenuItem.Name = "googleToolStripMenuItem";
            this.googleToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.googleToolStripMenuItem.Text = "Google";
            this.googleToolStripMenuItem.Click += new System.EventHandler(this.googleToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // bubblecheck
            // 
            this.bubblecheck.AutoSize = true;
            this.bubblecheck.Location = new System.Drawing.Point(416, 66);
            this.bubblecheck.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.bubblecheck.Name = "bubblecheck";
            this.bubblecheck.Size = new System.Drawing.Size(80, 19);
            this.bubblecheck.TabIndex = 5;
            this.bubblecheck.Text = "BubbleSort";
            this.bubblecheck.UseVisualStyleBackColor = true;
            // 
            // SortLabel
            // 
            this.SortLabel.AutoSize = true;
            this.SortLabel.Location = new System.Drawing.Point(739, 48);
            this.SortLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SortLabel.Name = "SortLabel";
            this.SortLabel.Size = new System.Drawing.Size(30, 15);
            this.SortLabel.TabIndex = 6;
            this.SortLabel.Text = "Sorts";
            // 
            // TimeElapsedLabel
            // 
            this.TimeElapsedLabel.AutoSize = true;
            this.TimeElapsedLabel.Location = new System.Drawing.Point(826, 48);
            this.TimeElapsedLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TimeElapsedLabel.Name = "TimeElapsedLabel";
            this.TimeElapsedLabel.Size = new System.Drawing.Size(31, 15);
            this.TimeElapsedLabel.TabIndex = 7;
            this.TimeElapsedLabel.Text = "Time";
            // 
            // ComparisonLabel
            // 
            this.ComparisonLabel.AutoSize = true;
            this.ComparisonLabel.Location = new System.Drawing.Point(904, 48);
            this.ComparisonLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ComparisonLabel.Name = "ComparisonLabel";
            this.ComparisonLabel.Size = new System.Drawing.Size(72, 15);
            this.ComparisonLabel.TabIndex = 8;
            this.ComparisonLabel.Text = "Comparisons";
            // 
            // SortCounterLabel
            // 
            this.SortCounterLabel.AutoSize = true;
            this.SortCounterLabel.Location = new System.Drawing.Point(778, 48);
            this.SortCounterLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SortCounterLabel.Name = "SortCounterLabel";
            this.SortCounterLabel.Size = new System.Drawing.Size(13, 15);
            this.SortCounterLabel.TabIndex = 9;
            this.SortCounterLabel.Text = "0";
            // 
            // TimeElapsedInt
            // 
            this.TimeElapsedInt.AutoSize = true;
            this.TimeElapsedInt.Location = new System.Drawing.Point(858, 48);
            this.TimeElapsedInt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TimeElapsedInt.Name = "TimeElapsedInt";
            this.TimeElapsedInt.Size = new System.Drawing.Size(13, 15);
            this.TimeElapsedInt.TabIndex = 10;
            this.TimeElapsedInt.Text = "0";
            // 
            // ComparisonInt
            // 
            this.ComparisonInt.AutoSize = true;
            this.ComparisonInt.Location = new System.Drawing.Point(976, 48);
            this.ComparisonInt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ComparisonInt.Name = "ComparisonInt";
            this.ComparisonInt.Size = new System.Drawing.Size(13, 15);
            this.ComparisonInt.TabIndex = 11;
            this.ComparisonInt.Text = "0";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1182, 538);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 53);
            this.button1.TabIndex = 13;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1293, 538);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 53);
            this.button2.TabIndex = 14;
            this.button2.Text = "Reset";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ShakerGraph1
            // 
            this.ShakerGraph1.BackColor = System.Drawing.SystemColors.Control;
            this.ShakerGraph1.IsEnableHPan = false;
            this.ShakerGraph1.IsEnableHZoom = false;
            this.ShakerGraph1.IsEnableVZoom = false;
            this.ShakerGraph1.IsEnableWheelZoom = false;
            this.ShakerGraph1.Location = new System.Drawing.Point(1094, 89);
            this.ShakerGraph1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ShakerGraph1.Name = "ShakerGraph1";
            this.ShakerGraph1.ScrollGrace = 0D;
            this.ShakerGraph1.ScrollMaxX = 0D;
            this.ShakerGraph1.ScrollMaxY = 0D;
            this.ShakerGraph1.ScrollMaxY2 = 0D;
            this.ShakerGraph1.ScrollMinX = 0D;
            this.ShakerGraph1.ScrollMinY = 0D;
            this.ShakerGraph1.ScrollMinY2 = 0D;
            this.ShakerGraph1.Size = new System.Drawing.Size(377, 285);
            this.ShakerGraph1.TabIndex = 15;
            this.ShakerGraph1.UseExtendedPrintDialog = true;
            // 
            // shakercheck
            // 
            this.shakercheck.AutoSize = true;
            this.shakercheck.Location = new System.Drawing.Point(1249, 66);
            this.shakercheck.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.shakercheck.Name = "shakercheck";
            this.shakercheck.Size = new System.Drawing.Size(81, 19);
            this.shakercheck.TabIndex = 16;
            this.shakercheck.Text = "Shaker Sort";
            this.shakercheck.UseVisualStyleBackColor = true;
            // 
            // IntersectionGraph1
            // 
            this.IntersectionGraph1.IsEnableHPan = false;
            this.IntersectionGraph1.IsEnableHZoom = false;
            this.IntersectionGraph1.IsEnableVZoom = false;
            this.IntersectionGraph1.IsEnableWheelZoom = false;
            this.IntersectionGraph1.Location = new System.Drawing.Point(275, 433);
            this.IntersectionGraph1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.IntersectionGraph1.Name = "IntersectionGraph1";
            this.IntersectionGraph1.ScrollGrace = 0D;
            this.IntersectionGraph1.ScrollMaxX = 0D;
            this.IntersectionGraph1.ScrollMaxY = 0D;
            this.IntersectionGraph1.ScrollMaxY2 = 0D;
            this.IntersectionGraph1.ScrollMinX = 0D;
            this.IntersectionGraph1.ScrollMinY = 0D;
            this.IntersectionGraph1.ScrollMinY2 = 0D;
            this.IntersectionGraph1.Size = new System.Drawing.Size(377, 285);
            this.IntersectionGraph1.TabIndex = 18;
            this.IntersectionGraph1.UseExtendedPrintDialog = true;
            // 
            // Intersectioncheck
            // 
            this.Intersectioncheck.AutoSize = true;
            this.Intersectioncheck.Location = new System.Drawing.Point(416, 410);
            this.Intersectioncheck.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Intersectioncheck.Name = "Intersectioncheck";
            this.Intersectioncheck.Size = new System.Drawing.Size(90, 19);
            this.Intersectioncheck.TabIndex = 17;
            this.Intersectioncheck.Text = "InsectionSort";
            this.Intersectioncheck.UseVisualStyleBackColor = true;
            // 
            // QuickGraph1
            // 
            this.QuickGraph1.IsEnableHPan = false;
            this.QuickGraph1.IsEnableHZoom = false;
            this.QuickGraph1.IsEnableVZoom = false;
            this.QuickGraph1.IsEnableWheelZoom = false;
            this.QuickGraph1.Location = new System.Drawing.Point(684, 433);
            this.QuickGraph1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.QuickGraph1.Name = "QuickGraph1";
            this.QuickGraph1.ScrollGrace = 0D;
            this.QuickGraph1.ScrollMaxX = 0D;
            this.QuickGraph1.ScrollMaxY = 0D;
            this.QuickGraph1.ScrollMaxY2 = 0D;
            this.QuickGraph1.ScrollMinX = 0D;
            this.QuickGraph1.ScrollMinY = 0D;
            this.QuickGraph1.ScrollMinY2 = 0D;
            this.QuickGraph1.Size = new System.Drawing.Size(378, 285);
            this.QuickGraph1.TabIndex = 20;
            this.QuickGraph1.UseExtendedPrintDialog = true;
            // 
            // quickcheck
            // 
            this.quickcheck.AutoSize = true;
            this.quickcheck.Location = new System.Drawing.Point(827, 410);
            this.quickcheck.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.quickcheck.Name = "quickcheck";
            this.quickcheck.Size = new System.Drawing.Size(73, 19);
            this.quickcheck.TabIndex = 19;
            this.quickcheck.Text = "QuickSort";
            this.quickcheck.UseVisualStyleBackColor = true;
            // 
            // BogoGraph1
            // 
            this.BogoGraph1.Cursor = System.Windows.Forms.Cursors.Default;
            this.BogoGraph1.IsEnableHPan = false;
            this.BogoGraph1.IsEnableHZoom = false;
            this.BogoGraph1.IsEnableVZoom = false;
            this.BogoGraph1.IsEnableWheelZoom = false;
            this.BogoGraph1.Location = new System.Drawing.Point(684, 89);
            this.BogoGraph1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BogoGraph1.Name = "BogoGraph1";
            this.BogoGraph1.ScrollGrace = 0D;
            this.BogoGraph1.ScrollMaxX = 0D;
            this.BogoGraph1.ScrollMaxY = 0D;
            this.BogoGraph1.ScrollMaxY2 = 0D;
            this.BogoGraph1.ScrollMinX = 0D;
            this.BogoGraph1.ScrollMinY = 0D;
            this.BogoGraph1.ScrollMinY2 = 0D;
            this.BogoGraph1.Size = new System.Drawing.Size(378, 285);
            this.BogoGraph1.TabIndex = 22;
            this.BogoGraph1.UseExtendedPrintDialog = true;
            // 
            // bogocheck
            // 
            this.bogocheck.AutoSize = true;
            this.bogocheck.Location = new System.Drawing.Point(835, 66);
            this.bogocheck.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.bogocheck.Name = "bogocheck";
            this.bogocheck.Size = new System.Drawing.Size(59, 19);
            this.bogocheck.TabIndex = 21;
            this.bogocheck.Text = "BOGO";
            this.bogocheck.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(567, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 15);
            this.label1.TabIndex = 28;
            this.label1.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(445, 48);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 15);
            this.label2.TabIndex = 27;
            this.label2.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(365, 48);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 15);
            this.label3.TabIndex = 26;
            this.label3.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(491, 48);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 15);
            this.label4.TabIndex = 25;
            this.label4.Text = "Comparisons";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(413, 48);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 15);
            this.label5.TabIndex = 24;
            this.label5.Text = "Time";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(326, 48);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 15);
            this.label6.TabIndex = 23;
            this.label6.Text = "Sorts";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1395, 48);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 15);
            this.label7.TabIndex = 34;
            this.label7.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1277, 48);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 15);
            this.label8.TabIndex = 33;
            this.label8.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1197, 48);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 15);
            this.label9.TabIndex = 32;
            this.label9.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1323, 48);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 15);
            this.label10.TabIndex = 31;
            this.label10.Text = "Comparisons";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1245, 48);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 15);
            this.label11.TabIndex = 30;
            this.label11.Text = "Time";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1158, 48);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(30, 15);
            this.label12.TabIndex = 29;
            this.label12.Text = "Sorts";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(976, 392);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(13, 15);
            this.label13.TabIndex = 40;
            this.label13.Text = "0";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(858, 392);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(13, 15);
            this.label14.TabIndex = 39;
            this.label14.Text = "0";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(778, 392);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(13, 15);
            this.label15.TabIndex = 38;
            this.label15.Text = "0";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(904, 392);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(72, 15);
            this.label16.TabIndex = 37;
            this.label16.Text = "Comparisons";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(826, 392);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(31, 15);
            this.label17.TabIndex = 36;
            this.label17.Text = "Time";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(739, 392);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(30, 15);
            this.label18.TabIndex = 35;
            this.label18.Text = "Sorts";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(563, 392);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(13, 15);
            this.label19.TabIndex = 46;
            this.label19.Text = "0";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(445, 392);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(13, 15);
            this.label20.TabIndex = 45;
            this.label20.Text = "0";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(365, 392);
            this.label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(13, 15);
            this.label21.TabIndex = 44;
            this.label21.Text = "0";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(491, 392);
            this.label22.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(72, 15);
            this.label22.TabIndex = 43;
            this.label22.Text = "Comparisons";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(413, 392);
            this.label23.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(31, 15);
            this.label23.TabIndex = 42;
            this.label23.Text = "Time";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(326, 392);
            this.label24.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(30, 15);
            this.label24.TabIndex = 41;
            this.label24.Text = "Sorts";
            // 
            // BubbleGraph1
            // 
            this.BubbleGraph1.BackColor = System.Drawing.SystemColors.Control;
            this.BubbleGraph1.IsEnableHPan = false;
            this.BubbleGraph1.IsEnableHZoom = false;
            this.BubbleGraph1.IsEnableVZoom = false;
            this.BubbleGraph1.IsEnableWheelZoom = false;
            this.BubbleGraph1.Location = new System.Drawing.Point(275, 89);
            this.BubbleGraph1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BubbleGraph1.Name = "BubbleGraph1";
            this.BubbleGraph1.ScrollGrace = 0D;
            this.BubbleGraph1.ScrollMaxX = 0D;
            this.BubbleGraph1.ScrollMaxY = 0D;
            this.BubbleGraph1.ScrollMaxY2 = 0D;
            this.BubbleGraph1.ScrollMinX = 0D;
            this.BubbleGraph1.ScrollMinY = 0D;
            this.BubbleGraph1.ScrollMinY2 = 0D;
            this.BubbleGraph1.Size = new System.Drawing.Size(377, 285);
            this.BubbleGraph1.TabIndex = 12;
            this.BubbleGraph1.UseExtendedPrintDialog = true;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(78, 49);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(43, 15);
            this.label25.TabIndex = 47;
            this.label25.Text = "Sorted:";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(127, 49);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(30, 15);
            this.label26.TabIndex = 48;
            this.label26.Text = "false";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1506, 757);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.QuickGraph1);
            this.Controls.Add(this.BogoGraph1);
            this.Controls.Add(this.bogocheck);
            this.Controls.Add(this.quickcheck);
            this.Controls.Add(this.IntersectionGraph1);
            this.Controls.Add(this.Intersectioncheck);
            this.Controls.Add(this.shakercheck);
            this.Controls.Add(this.ShakerGraph1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BubbleGraph1);
            this.Controls.Add(this.ComparisonInt);
            this.Controls.Add(this.TimeElapsedInt);
            this.Controls.Add(this.SortCounterLabel);
            this.Controls.Add(this.ComparisonLabel);
            this.Controls.Add(this.TimeElapsedLabel);
            this.Controls.Add(this.SortLabel);
            this.Controls.Add(this.bubblecheck);
            this.Controls.Add(this.arraynum);
            this.Controls.Add(this.genBtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Century Gothic", 7F);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button genBtn;
        private System.Windows.Forms.TextBox arraynum;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem закрытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem googleToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mass;
        private System.Windows.Forms.CheckBox bubblecheck;
        private System.Windows.Forms.Label SortLabel;
        private System.Windows.Forms.Label TimeElapsedLabel;
        private System.Windows.Forms.Label ComparisonLabel;
        private System.Windows.Forms.Label SortCounterLabel;
        private System.Windows.Forms.Label TimeElapsedInt;
        private System.Windows.Forms.Label ComparisonInt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private ZedGraph.ZedGraphControl ShakerGraph1;
        private System.Windows.Forms.CheckBox shakercheck;
        private ZedGraph.ZedGraphControl IntersectionGraph1;
        private System.Windows.Forms.CheckBox Intersectioncheck;
        private ZedGraph.ZedGraphControl QuickGraph1;
        private System.Windows.Forms.CheckBox quickcheck;
        private ZedGraph.ZedGraphControl BogoGraph1;
        private System.Windows.Forms.CheckBox bogocheck;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private ZedGraph.ZedGraphControl BubbleGraph1;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
    }
}

