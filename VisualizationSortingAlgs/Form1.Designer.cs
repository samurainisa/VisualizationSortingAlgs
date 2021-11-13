
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
            this.button4 = new System.Windows.Forms.Button();
            this.googleid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
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
            this.dataGridView1.Location = new System.Drawing.Point(30, 36);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(163, 251);
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
            this.genBtn.Location = new System.Drawing.Point(30, 381);
            this.genBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.genBtn.Name = "genBtn";
            this.genBtn.Size = new System.Drawing.Size(163, 26);
            this.genBtn.TabIndex = 1;
            this.genBtn.Text = "Сгенерировать массив";
            this.genBtn.UseVisualStyleBackColor = true;
            this.genBtn.Click += new System.EventHandler(this.genBtn_Click_1);
            // 
            // arraynum
            // 
            this.arraynum.Location = new System.Drawing.Point(30, 356);
            this.arraynum.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.arraynum.Name = "arraynum";
            this.arraynum.Size = new System.Drawing.Size(163, 19);
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
            this.menuStrip1.Size = new System.Drawing.Size(1201, 24);
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
            // TimeElapsedLabel
            // 
            this.TimeElapsedLabel.AutoSize = true;
            this.TimeElapsedLabel.Location = new System.Drawing.Point(784, 262);
            this.TimeElapsedLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TimeElapsedLabel.Name = "TimeElapsedLabel";
            this.TimeElapsedLabel.Size = new System.Drawing.Size(31, 15);
            this.TimeElapsedLabel.TabIndex = 7;
            this.TimeElapsedLabel.Text = "Time";
            // 
            // bogotime
            // 
            this.bogotime.AutoSize = true;
            this.bogotime.Location = new System.Drawing.Point(819, 261);
            this.bogotime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bogotime.Name = "bogotime";
            this.bogotime.Size = new System.Drawing.Size(13, 15);
            this.bogotime.TabIndex = 10;
            this.bogotime.Text = "0";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(30, 293);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(62, 57);
            this.button1.TabIndex = 13;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
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
            this.ShakerGraph1.Location = new System.Drawing.Point(863, 37);
            this.ShakerGraph1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ShakerGraph1.Name = "ShakerGraph1";
            this.ShakerGraph1.ScrollGrace = 0D;
            this.ShakerGraph1.ScrollMaxX = 0D;
            this.ShakerGraph1.ScrollMaxY = 0D;
            this.ShakerGraph1.ScrollMaxY2 = 0D;
            this.ShakerGraph1.ScrollMinX = 0D;
            this.ShakerGraph1.ScrollMinY = 0D;
            this.ShakerGraph1.ScrollMinY2 = 0D;
            this.ShakerGraph1.Size = new System.Drawing.Size(300, 250);
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
            this.IntersectionGraph1.Location = new System.Drawing.Point(218, 311);
            this.IntersectionGraph1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.IntersectionGraph1.Name = "IntersectionGraph1";
            this.IntersectionGraph1.ScrollGrace = 0D;
            this.IntersectionGraph1.ScrollMaxX = 0D;
            this.IntersectionGraph1.ScrollMaxY = 0D;
            this.IntersectionGraph1.ScrollMaxY2 = 0D;
            this.IntersectionGraph1.ScrollMinX = 0D;
            this.IntersectionGraph1.ScrollMinY = 0D;
            this.IntersectionGraph1.ScrollMinY2 = 0D;
            this.IntersectionGraph1.Size = new System.Drawing.Size(300, 250);
            this.IntersectionGraph1.TabIndex = 18;
            this.IntersectionGraph1.UseExtendedPrintDialog = true;
            // 
            // Intersectioncheck
            // 
            this.Intersectioncheck.AutoSize = true;
            this.Intersectioncheck.Location = new System.Drawing.Point(30, 526);
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
            this.QuickGraph1.Location = new System.Drawing.Point(539, 311);
            this.QuickGraph1.Margin = new System.Windows.Forms.Padding(0);
            this.QuickGraph1.Name = "QuickGraph1";
            this.QuickGraph1.ScrollGrace = 0D;
            this.QuickGraph1.ScrollMaxX = 0D;
            this.QuickGraph1.ScrollMaxY = 0D;
            this.QuickGraph1.ScrollMaxY2 = 0D;
            this.QuickGraph1.ScrollMinX = 0D;
            this.QuickGraph1.ScrollMinY = 0D;
            this.QuickGraph1.ScrollMinY2 = 0D;
            this.QuickGraph1.Size = new System.Drawing.Size(300, 250);
            this.QuickGraph1.TabIndex = 20;
            this.QuickGraph1.UseExtendedPrintDialog = true;
            // 
            // quickcheck
            // 
            this.quickcheck.AutoSize = true;
            this.quickcheck.Location = new System.Drawing.Point(30, 501);
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
            this.BogoGraph1.Location = new System.Drawing.Point(539, 37);
            this.BogoGraph1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BogoGraph1.Name = "BogoGraph1";
            this.BogoGraph1.ScrollGrace = 0D;
            this.BogoGraph1.ScrollMaxX = 0D;
            this.BogoGraph1.ScrollMaxY = 0D;
            this.BogoGraph1.ScrollMaxY2 = 0D;
            this.BogoGraph1.ScrollMinX = 0D;
            this.BogoGraph1.ScrollMinY = 0D;
            this.BogoGraph1.ScrollMinY2 = 0D;
            this.BogoGraph1.Size = new System.Drawing.Size(300, 250);
            this.BogoGraph1.TabIndex = 22;
            this.BogoGraph1.UseExtendedPrintDialog = true;
            // 
            // bogocheck
            // 
            this.bogocheck.AutoSize = true;
            this.bogocheck.Location = new System.Drawing.Point(30, 451);
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
            this.bubbletime.Location = new System.Drawing.Point(496, 261);
            this.bubbletime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bubbletime.Name = "bubbletime";
            this.bubbletime.Size = new System.Drawing.Size(13, 15);
            this.bubbletime.TabIndex = 27;
            this.bubbletime.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(461, 261);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 15);
            this.label5.TabIndex = 24;
            this.label5.Text = "Time";
            // 
            // shakertime
            // 
            this.shakertime.AutoSize = true;
            this.shakertime.Location = new System.Drawing.Point(1131, 260);
            this.shakertime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.shakertime.Name = "shakertime";
            this.shakertime.Size = new System.Drawing.Size(13, 15);
            this.shakertime.TabIndex = 33;
            this.shakertime.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1097, 259);
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
            this.quicktime.Location = new System.Drawing.Point(819, 534);
            this.quicktime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.quicktime.Name = "quicktime";
            this.quicktime.Size = new System.Drawing.Size(13, 15);
            this.quicktime.TabIndex = 39;
            this.quicktime.Text = "0";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 7F);
            this.label17.Location = new System.Drawing.Point(784, 534);
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
            this.insectime.Location = new System.Drawing.Point(493, 534);
            this.insectime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.insectime.Name = "insectime";
            this.insectime.Size = new System.Drawing.Size(13, 15);
            this.insectime.TabIndex = 45;
            this.insectime.Text = "0";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Century Gothic", 7F);
            this.label23.Location = new System.Drawing.Point(461, 534);
            this.label23.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(31, 15);
            this.label23.TabIndex = 42;
            this.label23.Text = "Time";
            // 
            // BubbleGraph1
            // 
            this.BubbleGraph1.BackColor = System.Drawing.SystemColors.Control;
            this.BubbleGraph1.Font = new System.Drawing.Font("Century Gothic", 6F);
            this.BubbleGraph1.IsEnableHPan = false;
            this.BubbleGraph1.IsEnableHZoom = false;
            this.BubbleGraph1.IsEnableVZoom = false;
            this.BubbleGraph1.IsEnableWheelZoom = false;
            this.BubbleGraph1.Location = new System.Drawing.Point(218, 36);
            this.BubbleGraph1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BubbleGraph1.Name = "BubbleGraph1";
            this.BubbleGraph1.ScrollGrace = 0D;
            this.BubbleGraph1.ScrollMaxX = 0D;
            this.BubbleGraph1.ScrollMaxY = 0D;
            this.BubbleGraph1.ScrollMaxY2 = 0D;
            this.BubbleGraph1.ScrollMinX = 0D;
            this.BubbleGraph1.ScrollMinY = 0D;
            this.BubbleGraph1.ScrollMinY2 = 0D;
            this.BubbleGraph1.Size = new System.Drawing.Size(300, 250);
            this.BubbleGraph1.TabIndex = 12;
            this.BubbleGraph1.UseExtendedPrintDialog = true;
            // 
            // shakercheck
            // 
            this.shakercheck.AutoSize = true;
            this.shakercheck.Location = new System.Drawing.Point(30, 476);
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
            this.bubblecheck.Location = new System.Drawing.Point(30, 426);
            this.bubblecheck.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.bubblecheck.Name = "bubblecheck";
            this.bubblecheck.Size = new System.Drawing.Size(80, 19);
            this.bubblecheck.TabIndex = 5;
            this.bubblecheck.Text = "BubbleSort";
            this.bubblecheck.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(96, 293);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(97, 28);
            this.button3.TabIndex = 46;
            this.button3.Text = "Pause";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(96, 322);
            this.button4.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(97, 28);
            this.button4.TabIndex = 47;
            this.button4.Text = "Resume";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // googleid
            // 
            this.googleid.Location = new System.Drawing.Point(207, 5);
            this.googleid.Name = "googleid";
            this.googleid.Size = new System.Drawing.Size(190, 19);
            this.googleid.TabIndex = 48;
            this.googleid.Text = "1GoOUEb2OdQWLqPIJbEB_wMnfy4sJwc4cSkdMra2AEKM";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(184, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 15);
            this.label1.TabIndex = 49;
            this.label1.Text = "ID";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1201, 602);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.googleid);
            this.Controls.Add(this.button4);
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
            this.Text = "p";
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
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox googleid;
        private System.Windows.Forms.Label label1;
    }
}

