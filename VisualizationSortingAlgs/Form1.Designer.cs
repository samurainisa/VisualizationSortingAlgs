﻿
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
            this.очиститьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.TimeElapsedLabel = new System.Windows.Forms.Label();
            this.bogotime = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.ShakerGraph1 = new ZedGraph.ZedGraphControl();
            this.IntersectionGraph1 = new ZedGraph.ZedGraphControl();
            this.Intersectioncheck = new System.Windows.Forms.CheckBox();
            this.QuickGraph1 = new ZedGraph.ZedGraphControl();
            this.quickcheck = new System.Windows.Forms.CheckBox();
            this.BogoGraph1 = new ZedGraph.ZedGraphControl();
            this.bogocheck = new System.Windows.Forms.CheckBox();
            this.bubbletime = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.shakertime = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.quicktime = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.insectime = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.BubbleGraph1 = new ZedGraph.ZedGraphControl();
            this.shakercheck = new System.Windows.Forms.CheckBox();
            this.bubblecheck = new System.Windows.Forms.CheckBox();
            this.button3 = new System.Windows.Forms.Button();
            this.googleid = new System.Windows.Forms.TextBox();
            this.revquickcheck = new System.Windows.Forms.CheckBox();
            this.revinsectioncheck = new System.Windows.Forms.CheckBox();
            this.revshaker = new System.Windows.Forms.CheckBox();
            this.revbubble = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.revshakertime = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Revbubblegraph = new ZedGraph.ZedGraphControl();
            this.revshakergraph = new ZedGraph.ZedGraphControl();
            this.revquicksort = new ZedGraph.ZedGraphControl();
            this.Revintergraph = new ZedGraph.ZedGraphControl();
            this.revbogograph = new ZedGraph.ZedGraphControl();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.revbogocheck = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Mass});
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.dataGridView1.Location = new System.Drawing.Point(27, 51);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(155, 251);
            this.dataGridView1.TabIndex = 0;
            // 
            // Mass
            // 
            this.Mass.HeaderText = "Массив";
            this.Mass.Name = "Mass";
            this.Mass.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Mass.Width = 121;
            // 
            // genBtn
            // 
            this.genBtn.BackColor = System.Drawing.Color.White;
            this.genBtn.Location = new System.Drawing.Point(27, 335);
            this.genBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.genBtn.Name = "genBtn";
            this.genBtn.Size = new System.Drawing.Size(156, 26);
            this.genBtn.TabIndex = 1;
            this.genBtn.Text = "Сгенерировать массив";
            this.genBtn.UseVisualStyleBackColor = false;
            this.genBtn.Click += new System.EventHandler(this.genBtn_Click_1);
            // 
            // arraynum
            // 
            this.arraynum.Location = new System.Drawing.Point(27, 310);
            this.arraynum.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.arraynum.Name = "arraynum";
            this.arraynum.Size = new System.Drawing.Size(156, 19);
            this.arraynum.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.menuStrip1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.закрытьToolStripMenuItem,
            this.excelToolStripMenuItem,
            this.googleToolStripMenuItem,
            this.очиститьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1226, 25);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.menuStrip1_MouseDown);
            // 
            // закрытьToolStripMenuItem
            // 
            this.закрытьToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.закрытьToolStripMenuItem.Name = "закрытьToolStripMenuItem";
            this.закрытьToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.закрытьToolStripMenuItem.Text = "Закрыть";
            this.закрытьToolStripMenuItem.Click += new System.EventHandler(this.закрытьToolStripMenuItem_Click);
            // 
            // excelToolStripMenuItem
            // 
            this.excelToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.excelToolStripMenuItem.Name = "excelToolStripMenuItem";
            this.excelToolStripMenuItem.Size = new System.Drawing.Size(51, 21);
            this.excelToolStripMenuItem.Text = "Excel";
            this.excelToolStripMenuItem.Click += new System.EventHandler(this.excelToolStripMenuItem_Click);
            // 
            // googleToolStripMenuItem
            // 
            this.googleToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.googleToolStripMenuItem.Name = "googleToolStripMenuItem";
            this.googleToolStripMenuItem.Size = new System.Drawing.Size(65, 21);
            this.googleToolStripMenuItem.Text = "Google";
            this.googleToolStripMenuItem.Click += new System.EventHandler(this.googleToolStripMenuItem_Click);
            // 
            // очиститьToolStripMenuItem
            // 
            this.очиститьToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.очиститьToolStripMenuItem.Name = "очиститьToolStripMenuItem";
            this.очиститьToolStripMenuItem.Size = new System.Drawing.Size(74, 21);
            this.очиститьToolStripMenuItem.Text = "Очистить";
            this.очиститьToolStripMenuItem.Click += new System.EventHandler(this.очиститьToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // TimeElapsedLabel
            // 
            this.TimeElapsedLabel.AutoSize = true;
            this.TimeElapsedLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.TimeElapsedLabel.Location = new System.Drawing.Point(295, 79);
            this.TimeElapsedLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TimeElapsedLabel.Name = "TimeElapsedLabel";
            this.TimeElapsedLabel.Size = new System.Drawing.Size(31, 15);
            this.TimeElapsedLabel.TabIndex = 7;
            this.TimeElapsedLabel.Text = "Time";
            // 
            // bogotime
            // 
            this.bogotime.AutoSize = true;
            this.bogotime.ForeColor = System.Drawing.SystemColors.Control;
            this.bogotime.Location = new System.Drawing.Point(322, 81);
            this.bogotime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bogotime.Name = "bogotime";
            this.bogotime.Size = new System.Drawing.Size(0, 15);
            this.bogotime.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(190, 310);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 51);
            this.button1.TabIndex = 13;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ShakerGraph1
            // 
            this.ShakerGraph1.BackColor = System.Drawing.SystemColors.Control;
            this.ShakerGraph1.Font = new System.Drawing.Font("Century Gothic", 6F);
            this.ShakerGraph1.IsEnableHPan = false;
            this.ShakerGraph1.IsEnableHZoom = false;
            this.ShakerGraph1.IsEnableVZoom = false;
            this.ShakerGraph1.IsEnableWheelZoom = false;
            this.ShakerGraph1.Location = new System.Drawing.Point(926, 29);
            this.ShakerGraph1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ShakerGraph1.Name = "ShakerGraph1";
            this.ShakerGraph1.ScrollGrace = 0D;
            this.ShakerGraph1.ScrollMaxX = 0D;
            this.ShakerGraph1.ScrollMaxY = 0D;
            this.ShakerGraph1.ScrollMaxY2 = 0D;
            this.ShakerGraph1.ScrollMinX = 0D;
            this.ShakerGraph1.ScrollMinY = 0D;
            this.ShakerGraph1.ScrollMinY2 = 0D;
            this.ShakerGraph1.Size = new System.Drawing.Size(270, 226);
            this.ShakerGraph1.TabIndex = 15;
            this.ShakerGraph1.UseExtendedPrintDialog = true;
            // 
            // IntersectionGraph1
            // 
            this.IntersectionGraph1.Font = new System.Drawing.Font("Century Gothic", 6F);
            this.IntersectionGraph1.IsEnableHPan = false;
            this.IntersectionGraph1.IsEnableHZoom = false;
            this.IntersectionGraph1.IsEnableVZoom = false;
            this.IntersectionGraph1.IsEnableWheelZoom = false;
            this.IntersectionGraph1.Location = new System.Drawing.Point(370, 261);
            this.IntersectionGraph1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.IntersectionGraph1.Name = "IntersectionGraph1";
            this.IntersectionGraph1.ScrollGrace = 0D;
            this.IntersectionGraph1.ScrollMaxX = 0D;
            this.IntersectionGraph1.ScrollMaxY = 0D;
            this.IntersectionGraph1.ScrollMaxY2 = 0D;
            this.IntersectionGraph1.ScrollMinX = 0D;
            this.IntersectionGraph1.ScrollMinY = 0D;
            this.IntersectionGraph1.ScrollMinY2 = 0D;
            this.IntersectionGraph1.Size = new System.Drawing.Size(270, 226);
            this.IntersectionGraph1.TabIndex = 18;
            this.IntersectionGraph1.UseExtendedPrintDialog = true;
            // 
            // Intersectioncheck
            // 
            this.Intersectioncheck.AutoSize = true;
            this.Intersectioncheck.ForeColor = System.Drawing.SystemColors.Control;
            this.Intersectioncheck.Location = new System.Drawing.Point(190, 154);
            this.Intersectioncheck.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Intersectioncheck.Name = "Intersectioncheck";
            this.Intersectioncheck.Size = new System.Drawing.Size(90, 19);
            this.Intersectioncheck.TabIndex = 17;
            this.Intersectioncheck.Text = "InsectionSort";
            this.Intersectioncheck.UseVisualStyleBackColor = true;
            // 
            // QuickGraph1
            // 
            this.QuickGraph1.Font = new System.Drawing.Font("Century Gothic", 6F);
            this.QuickGraph1.IsEnableHPan = false;
            this.QuickGraph1.IsEnableHZoom = false;
            this.QuickGraph1.IsEnableVZoom = false;
            this.QuickGraph1.IsEnableWheelZoom = false;
            this.QuickGraph1.Location = new System.Drawing.Point(648, 261);
            this.QuickGraph1.Margin = new System.Windows.Forms.Padding(0);
            this.QuickGraph1.Name = "QuickGraph1";
            this.QuickGraph1.ScrollGrace = 0D;
            this.QuickGraph1.ScrollMaxX = 0D;
            this.QuickGraph1.ScrollMaxY = 0D;
            this.QuickGraph1.ScrollMaxY2 = 0D;
            this.QuickGraph1.ScrollMinX = 0D;
            this.QuickGraph1.ScrollMinY = 0D;
            this.QuickGraph1.ScrollMinY2 = 0D;
            this.QuickGraph1.Size = new System.Drawing.Size(270, 226);
            this.QuickGraph1.TabIndex = 20;
            this.QuickGraph1.UseExtendedPrintDialog = true;
            // 
            // quickcheck
            // 
            this.quickcheck.AutoSize = true;
            this.quickcheck.ForeColor = System.Drawing.SystemColors.Control;
            this.quickcheck.Location = new System.Drawing.Point(190, 129);
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
            this.BogoGraph1.Font = new System.Drawing.Font("Century Gothic", 6F);
            this.BogoGraph1.IsEnableHPan = false;
            this.BogoGraph1.IsEnableHZoom = false;
            this.BogoGraph1.IsEnableVZoom = false;
            this.BogoGraph1.IsEnableWheelZoom = false;
            this.BogoGraph1.Location = new System.Drawing.Point(648, 29);
            this.BogoGraph1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BogoGraph1.Name = "BogoGraph1";
            this.BogoGraph1.ScrollGrace = 0D;
            this.BogoGraph1.ScrollMaxX = 0D;
            this.BogoGraph1.ScrollMaxY = 0D;
            this.BogoGraph1.ScrollMaxY2 = 0D;
            this.BogoGraph1.ScrollMinX = 0D;
            this.BogoGraph1.ScrollMinY = 0D;
            this.BogoGraph1.ScrollMinY2 = 0D;
            this.BogoGraph1.Size = new System.Drawing.Size(270, 226);
            this.BogoGraph1.TabIndex = 22;
            this.BogoGraph1.UseExtendedPrintDialog = true;
            // 
            // bogocheck
            // 
            this.bogocheck.AutoSize = true;
            this.bogocheck.ForeColor = System.Drawing.SystemColors.Control;
            this.bogocheck.Location = new System.Drawing.Point(190, 79);
            this.bogocheck.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.bogocheck.Name = "bogocheck";
            this.bogocheck.Size = new System.Drawing.Size(59, 19);
            this.bogocheck.TabIndex = 21;
            this.bogocheck.Text = "BOGO";
            this.bogocheck.UseVisualStyleBackColor = true;
            // 
            // bubbletime
            // 
            this.bubbletime.AutoSize = true;
            this.bubbletime.ForeColor = System.Drawing.SystemColors.Control;
            this.bubbletime.Location = new System.Drawing.Point(322, 54);
            this.bubbletime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bubbletime.Name = "bubbletime";
            this.bubbletime.Size = new System.Drawing.Size(0, 15);
            this.bubbletime.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(295, 54);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 15);
            this.label5.TabIndex = 24;
            this.label5.Text = "Time";
            // 
            // shakertime
            // 
            this.shakertime.AutoSize = true;
            this.shakertime.ForeColor = System.Drawing.SystemColors.Control;
            this.shakertime.Location = new System.Drawing.Point(322, 108);
            this.shakertime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.shakertime.Name = "shakertime";
            this.shakertime.Size = new System.Drawing.Size(0, 15);
            this.shakertime.TabIndex = 33;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.Control;
            this.label11.Location = new System.Drawing.Point(295, 106);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 15);
            this.label11.TabIndex = 30;
            this.label11.Text = "Time";
            // 
            // quicktime
            // 
            this.quicktime.AutoSize = true;
            this.quicktime.Font = new System.Drawing.Font("Century Gothic", 7F);
            this.quicktime.ForeColor = System.Drawing.SystemColors.Control;
            this.quicktime.Location = new System.Drawing.Point(322, 133);
            this.quicktime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.quicktime.Name = "quicktime";
            this.quicktime.Size = new System.Drawing.Size(0, 15);
            this.quicktime.TabIndex = 39;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 7F);
            this.label17.ForeColor = System.Drawing.SystemColors.Control;
            this.label17.Location = new System.Drawing.Point(295, 131);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(31, 15);
            this.label17.TabIndex = 36;
            this.label17.Text = "Time";
            // 
            // insectime
            // 
            this.insectime.AutoSize = true;
            this.insectime.Font = new System.Drawing.Font("Century Gothic", 7F);
            this.insectime.ForeColor = System.Drawing.SystemColors.Control;
            this.insectime.Location = new System.Drawing.Point(322, 156);
            this.insectime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.insectime.Name = "insectime";
            this.insectime.Size = new System.Drawing.Size(0, 15);
            this.insectime.TabIndex = 45;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Century Gothic", 7F);
            this.label23.ForeColor = System.Drawing.SystemColors.Control;
            this.label23.Location = new System.Drawing.Point(295, 156);
            this.label23.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(31, 15);
            this.label23.TabIndex = 42;
            this.label23.Text = "Time";
            // 
            // BubbleGraph1
            // 
            this.BubbleGraph1.AutoSize = true;
            this.BubbleGraph1.BackColor = System.Drawing.SystemColors.Control;
            this.BubbleGraph1.Font = new System.Drawing.Font("Century Gothic", 6F);
            this.BubbleGraph1.IsEnableHPan = false;
            this.BubbleGraph1.IsEnableHZoom = false;
            this.BubbleGraph1.IsEnableVZoom = false;
            this.BubbleGraph1.IsEnableWheelZoom = false;
            this.BubbleGraph1.Location = new System.Drawing.Point(370, 29);
            this.BubbleGraph1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BubbleGraph1.Name = "BubbleGraph1";
            this.BubbleGraph1.ScrollGrace = 0D;
            this.BubbleGraph1.ScrollMaxX = 0D;
            this.BubbleGraph1.ScrollMaxY = 0D;
            this.BubbleGraph1.ScrollMaxY2 = 0D;
            this.BubbleGraph1.ScrollMinX = 0D;
            this.BubbleGraph1.ScrollMinY = 0D;
            this.BubbleGraph1.ScrollMinY2 = 0D;
            this.BubbleGraph1.Size = new System.Drawing.Size(270, 226);
            this.BubbleGraph1.TabIndex = 12;
            this.BubbleGraph1.UseExtendedPrintDialog = true;
            // 
            // shakercheck
            // 
            this.shakercheck.AutoSize = true;
            this.shakercheck.ForeColor = System.Drawing.SystemColors.Control;
            this.shakercheck.Location = new System.Drawing.Point(190, 104);
            this.shakercheck.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.shakercheck.Name = "shakercheck";
            this.shakercheck.Size = new System.Drawing.Size(81, 19);
            this.shakercheck.TabIndex = 16;
            this.shakercheck.Text = "Shaker Sort";
            this.shakercheck.UseVisualStyleBackColor = true;
            // 
            // bubblecheck
            // 
            this.bubblecheck.AutoSize = true;
            this.bubblecheck.ForeColor = System.Drawing.SystemColors.Control;
            this.bubblecheck.Location = new System.Drawing.Point(190, 54);
            this.bubblecheck.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.bubblecheck.Name = "bubblecheck";
            this.bubblecheck.Size = new System.Drawing.Size(80, 19);
            this.bubblecheck.TabIndex = 5;
            this.bubblecheck.Text = "BubbleSort";
            this.bubblecheck.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(264, 310);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(62, 51);
            this.button3.TabIndex = 46;
            this.button3.Text = "Pause";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // googleid
            // 
            this.googleid.Location = new System.Drawing.Point(27, 29);
            this.googleid.Name = "googleid";
            this.googleid.Size = new System.Drawing.Size(308, 19);
            this.googleid.TabIndex = 48;
            this.googleid.Text = "1GoOUEb2OdQWLqPIJbEB_wMnfy4sJwc4cSkdMra2AEKM";
            // 
            // revquickcheck
            // 
            this.revquickcheck.AutoSize = true;
            this.revquickcheck.ForeColor = System.Drawing.SystemColors.Control;
            this.revquickcheck.Location = new System.Drawing.Point(189, 235);
            this.revquickcheck.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.revquickcheck.Name = "revquickcheck";
            this.revquickcheck.Size = new System.Drawing.Size(95, 19);
            this.revquickcheck.TabIndex = 53;
            this.revquickcheck.Text = "Rev QuickSort";
            this.revquickcheck.UseVisualStyleBackColor = true;
            // 
            // revinsectioncheck
            // 
            this.revinsectioncheck.AutoSize = true;
            this.revinsectioncheck.ForeColor = System.Drawing.SystemColors.Control;
            this.revinsectioncheck.Location = new System.Drawing.Point(189, 260);
            this.revinsectioncheck.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.revinsectioncheck.Name = "revinsectioncheck";
            this.revinsectioncheck.Size = new System.Drawing.Size(112, 19);
            this.revinsectioncheck.TabIndex = 52;
            this.revinsectioncheck.Text = "Rev InsectionSort";
            this.revinsectioncheck.UseVisualStyleBackColor = true;
            // 
            // revshaker
            // 
            this.revshaker.AutoSize = true;
            this.revshaker.ForeColor = System.Drawing.SystemColors.Control;
            this.revshaker.Location = new System.Drawing.Point(189, 209);
            this.revshaker.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.revshaker.Name = "revshaker";
            this.revshaker.Size = new System.Drawing.Size(103, 19);
            this.revshaker.TabIndex = 51;
            this.revshaker.Text = "Rev Shaker Sort";
            this.revshaker.UseVisualStyleBackColor = true;
            // 
            // revbubble
            // 
            this.revbubble.AutoSize = true;
            this.revbubble.ForeColor = System.Drawing.SystemColors.Control;
            this.revbubble.Location = new System.Drawing.Point(190, 180);
            this.revbubble.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.revbubble.Name = "revbubble";
            this.revbubble.Size = new System.Drawing.Size(102, 19);
            this.revbubble.TabIndex = 50;
            this.revbubble.Text = "Rev BubbleSort";
            this.revbubble.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(322, 182);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 15);
            this.label2.TabIndex = 55;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(295, 180);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 15);
            this.label3.TabIndex = 54;
            this.label3.Text = "Time";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 7F);
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(321, 264);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 15);
            this.label4.TabIndex = 61;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 7F);
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(294, 262);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 15);
            this.label6.TabIndex = 60;
            this.label6.Text = "Time";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 7F);
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(321, 237);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 15);
            this.label7.TabIndex = 59;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 7F);
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(294, 237);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 15);
            this.label8.TabIndex = 58;
            this.label8.Text = "Time";
            // 
            // revshakertime
            // 
            this.revshakertime.AutoSize = true;
            this.revshakertime.ForeColor = System.Drawing.SystemColors.Control;
            this.revshakertime.Location = new System.Drawing.Point(321, 213);
            this.revshakertime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.revshakertime.Name = "revshakertime";
            this.revshakertime.Size = new System.Drawing.Size(0, 15);
            this.revshakertime.TabIndex = 57;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.Control;
            this.label10.Location = new System.Drawing.Point(294, 211);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 15);
            this.label10.TabIndex = 56;
            this.label10.Text = "Time";
            // 
            // Revbubblegraph
            // 
            this.Revbubblegraph.AutoSize = true;
            this.Revbubblegraph.BackColor = System.Drawing.SystemColors.Control;
            this.Revbubblegraph.Font = new System.Drawing.Font("Century Gothic", 6F);
            this.Revbubblegraph.IsEnableHPan = false;
            this.Revbubblegraph.IsEnableHZoom = false;
            this.Revbubblegraph.IsEnableVZoom = false;
            this.Revbubblegraph.IsEnableWheelZoom = false;
            this.Revbubblegraph.Location = new System.Drawing.Point(926, 260);
            this.Revbubblegraph.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Revbubblegraph.Name = "Revbubblegraph";
            this.Revbubblegraph.ScrollGrace = 0D;
            this.Revbubblegraph.ScrollMaxX = 0D;
            this.Revbubblegraph.ScrollMaxY = 0D;
            this.Revbubblegraph.ScrollMaxY2 = 0D;
            this.Revbubblegraph.ScrollMinX = 0D;
            this.Revbubblegraph.ScrollMinY = 0D;
            this.Revbubblegraph.ScrollMinY2 = 0D;
            this.Revbubblegraph.Size = new System.Drawing.Size(270, 226);
            this.Revbubblegraph.TabIndex = 62;
            this.Revbubblegraph.UseExtendedPrintDialog = true;
            // 
            // revshakergraph
            // 
            this.revshakergraph.AutoSize = true;
            this.revshakergraph.BackColor = System.Drawing.SystemColors.Control;
            this.revshakergraph.Font = new System.Drawing.Font("Century Gothic", 6F);
            this.revshakergraph.IsEnableHPan = false;
            this.revshakergraph.IsEnableHZoom = false;
            this.revshakergraph.IsEnableVZoom = false;
            this.revshakergraph.IsEnableWheelZoom = false;
            this.revshakergraph.Location = new System.Drawing.Point(370, 494);
            this.revshakergraph.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.revshakergraph.Name = "revshakergraph";
            this.revshakergraph.ScrollGrace = 0D;
            this.revshakergraph.ScrollMaxX = 0D;
            this.revshakergraph.ScrollMaxY = 0D;
            this.revshakergraph.ScrollMaxY2 = 0D;
            this.revshakergraph.ScrollMinX = 0D;
            this.revshakergraph.ScrollMinY = 0D;
            this.revshakergraph.ScrollMinY2 = 0D;
            this.revshakergraph.Size = new System.Drawing.Size(270, 226);
            this.revshakergraph.TabIndex = 63;
            this.revshakergraph.UseExtendedPrintDialog = true;
            // 
            // revquicksort
            // 
            this.revquicksort.Font = new System.Drawing.Font("Century Gothic", 6F);
            this.revquicksort.IsEnableHPan = false;
            this.revquicksort.IsEnableHZoom = false;
            this.revquicksort.IsEnableVZoom = false;
            this.revquicksort.IsEnableWheelZoom = false;
            this.revquicksort.Location = new System.Drawing.Point(648, 494);
            this.revquicksort.Margin = new System.Windows.Forms.Padding(0);
            this.revquicksort.Name = "revquicksort";
            this.revquicksort.ScrollGrace = 0D;
            this.revquicksort.ScrollMaxX = 0D;
            this.revquicksort.ScrollMaxY = 0D;
            this.revquicksort.ScrollMaxY2 = 0D;
            this.revquicksort.ScrollMinX = 0D;
            this.revquicksort.ScrollMinY = 0D;
            this.revquicksort.ScrollMinY2 = 0D;
            this.revquicksort.Size = new System.Drawing.Size(270, 226);
            this.revquicksort.TabIndex = 64;
            this.revquicksort.UseExtendedPrintDialog = true;
            // 
            // Revintergraph
            // 
            this.Revintergraph.Font = new System.Drawing.Font("Century Gothic", 6F);
            this.Revintergraph.IsEnableHPan = false;
            this.Revintergraph.IsEnableHZoom = false;
            this.Revintergraph.IsEnableVZoom = false;
            this.Revintergraph.IsEnableWheelZoom = false;
            this.Revintergraph.Location = new System.Drawing.Point(926, 494);
            this.Revintergraph.Margin = new System.Windows.Forms.Padding(0);
            this.Revintergraph.Name = "Revintergraph";
            this.Revintergraph.ScrollGrace = 0D;
            this.Revintergraph.ScrollMaxX = 0D;
            this.Revintergraph.ScrollMaxY = 0D;
            this.Revintergraph.ScrollMaxY2 = 0D;
            this.Revintergraph.ScrollMinX = 0D;
            this.Revintergraph.ScrollMinY = 0D;
            this.Revintergraph.ScrollMinY2 = 0D;
            this.Revintergraph.Size = new System.Drawing.Size(270, 226);
            this.Revintergraph.TabIndex = 65;
            this.Revintergraph.UseExtendedPrintDialog = true;
            // 
            // revbogograph
            // 
            this.revbogograph.AutoSize = true;
            this.revbogograph.BackColor = System.Drawing.SystemColors.Control;
            this.revbogograph.Font = new System.Drawing.Font("Century Gothic", 6F);
            this.revbogograph.IsEnableHPan = false;
            this.revbogograph.IsEnableHZoom = false;
            this.revbogograph.IsEnableVZoom = false;
            this.revbogograph.IsEnableWheelZoom = false;
            this.revbogograph.Location = new System.Drawing.Point(92, 494);
            this.revbogograph.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.revbogograph.Name = "revbogograph";
            this.revbogograph.ScrollGrace = 0D;
            this.revbogograph.ScrollMaxX = 0D;
            this.revbogograph.ScrollMaxY = 0D;
            this.revbogograph.ScrollMaxY2 = 0D;
            this.revbogograph.ScrollMinX = 0D;
            this.revbogograph.ScrollMinY = 0D;
            this.revbogograph.ScrollMinY2 = 0D;
            this.revbogograph.Size = new System.Drawing.Size(274, 228);
            this.revbogograph.TabIndex = 66;
            this.revbogograph.UseExtendedPrintDialog = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 7F);
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(321, 289);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 15);
            this.label9.TabIndex = 69;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 7F);
            this.label12.ForeColor = System.Drawing.SystemColors.Control;
            this.label12.Location = new System.Drawing.Point(294, 289);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(31, 15);
            this.label12.TabIndex = 68;
            this.label12.Text = "Time";
            // 
            // revbogocheck
            // 
            this.revbogocheck.AutoSize = true;
            this.revbogocheck.ForeColor = System.Drawing.SystemColors.Control;
            this.revbogocheck.Location = new System.Drawing.Point(189, 285);
            this.revbogocheck.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.revbogocheck.Name = "revbogocheck";
            this.revbogocheck.Size = new System.Drawing.Size(81, 19);
            this.revbogocheck.TabIndex = 67;
            this.revbogocheck.Text = "Rev BOGO";
            this.revbogocheck.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(1226, 748);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.revbogocheck);
            this.Controls.Add(this.revbogograph);
            this.Controls.Add(this.Revintergraph);
            this.Controls.Add(this.revquicksort);
            this.Controls.Add(this.revshakergraph);
            this.Controls.Add(this.Revbubblegraph);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.revshakertime);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.revquickcheck);
            this.Controls.Add(this.revinsectioncheck);
            this.Controls.Add(this.revshaker);
            this.Controls.Add(this.revbubble);
            this.Controls.Add(this.googleid);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.bogotime);
            this.Controls.Add(this.TimeElapsedLabel);
            this.Controls.Add(this.insectime);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.quicktime);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.shakertime);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.bubbletime);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.QuickGraph1);
            this.Controls.Add(this.BogoGraph1);
            this.Controls.Add(this.bogocheck);
            this.Controls.Add(this.quickcheck);
            this.Controls.Add(this.IntersectionGraph1);
            this.Controls.Add(this.Intersectioncheck);
            this.Controls.Add(this.shakercheck);
            this.Controls.Add(this.ShakerGraph1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BubbleGraph1);
            this.Controls.Add(this.bubblecheck);
            this.Controls.Add(this.arraynum);
            this.Controls.Add(this.genBtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Century Gothic", 7F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Визуализация сортировок";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
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
        private System.Windows.Forms.Label TimeElapsedLabel;
        private System.Windows.Forms.Label bogotime;
        private System.Windows.Forms.Button button1;
        private ZedGraph.ZedGraphControl ShakerGraph1;
        private ZedGraph.ZedGraphControl IntersectionGraph1;
        private System.Windows.Forms.CheckBox Intersectioncheck;
        private ZedGraph.ZedGraphControl QuickGraph1;
        private System.Windows.Forms.CheckBox quickcheck;
        private ZedGraph.ZedGraphControl BogoGraph1;
        private System.Windows.Forms.CheckBox bogocheck;
        private System.Windows.Forms.Label bubbletime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label shakertime;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label quicktime;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label insectime;
        private System.Windows.Forms.Label label23;
        private ZedGraph.ZedGraphControl BubbleGraph1;
        private System.Windows.Forms.CheckBox shakercheck;
        private System.Windows.Forms.CheckBox bubblecheck;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox googleid;
        private System.Windows.Forms.ToolStripMenuItem очиститьToolStripMenuItem;
        private System.Windows.Forms.CheckBox revquickcheck;
        private System.Windows.Forms.CheckBox revinsectioncheck;
        private System.Windows.Forms.CheckBox revshaker;
        private System.Windows.Forms.CheckBox revbubble;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label revshakertime;
        private System.Windows.Forms.Label label10;
        private ZedGraph.ZedGraphControl Revbubblegraph;
        private ZedGraph.ZedGraphControl revshakergraph;
        private ZedGraph.ZedGraphControl revquicksort;
        private ZedGraph.ZedGraphControl Revintergraph;
        private ZedGraph.ZedGraphControl revbogograph;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox revbogocheck;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mass;
    }
}

