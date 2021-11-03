
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
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.zedGraphControl2 = new ZedGraph.ZedGraphControl();
            this.shakercheck = new System.Windows.Forms.CheckBox();
            this.intergraph = new ZedGraph.ZedGraphControl();
            this.Intersectioncheck = new System.Windows.Forms.CheckBox();
            this.quickgraph = new ZedGraph.ZedGraphControl();
            this.quickcheck = new System.Windows.Forms.CheckBox();
            this.bogograph = new ZedGraph.ZedGraphControl();
            this.bogocheck = new System.Windows.Forms.CheckBox();
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 89);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(243, 524);
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
            this.genBtn.Location = new System.Drawing.Point(77, 645);
            this.genBtn.Name = "genBtn";
            this.genBtn.Size = new System.Drawing.Size(106, 41);
            this.genBtn.TabIndex = 1;
            this.genBtn.Text = "Сгенерировать массив";
            this.genBtn.UseVisualStyleBackColor = true;
            this.genBtn.Click += new System.EventHandler(this.genBtn_Click_1);
            // 
            // arraynum
            // 
            this.arraynum.Location = new System.Drawing.Point(77, 619);
            this.arraynum.Name = "arraynum";
            this.arraynum.Size = new System.Drawing.Size(106, 20);
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
            this.bubblecheck.Location = new System.Drawing.Point(417, 66);
            this.bubblecheck.Name = "bubblecheck";
            this.bubblecheck.Size = new System.Drawing.Size(78, 17);
            this.bubblecheck.TabIndex = 5;
            this.bubblecheck.Text = "BubbleSort";
            this.bubblecheck.UseVisualStyleBackColor = true;
            // 
            // SortLabel
            // 
            this.SortLabel.AutoSize = true;
            this.SortLabel.Location = new System.Drawing.Point(715, 27);
            this.SortLabel.Name = "SortLabel";
            this.SortLabel.Size = new System.Drawing.Size(31, 13);
            this.SortLabel.TabIndex = 6;
            this.SortLabel.Text = "Sorts";
            // 
            // TimeElapsedLabel
            // 
            this.TimeElapsedLabel.AutoSize = true;
            this.TimeElapsedLabel.Location = new System.Drawing.Point(801, 27);
            this.TimeElapsedLabel.Name = "TimeElapsedLabel";
            this.TimeElapsedLabel.Size = new System.Drawing.Size(30, 13);
            this.TimeElapsedLabel.TabIndex = 7;
            this.TimeElapsedLabel.Text = "Time";
            // 
            // ComparisonLabel
            // 
            this.ComparisonLabel.AutoSize = true;
            this.ComparisonLabel.Location = new System.Drawing.Point(912, 27);
            this.ComparisonLabel.Name = "ComparisonLabel";
            this.ComparisonLabel.Size = new System.Drawing.Size(67, 13);
            this.ComparisonLabel.TabIndex = 8;
            this.ComparisonLabel.Text = "Comparisons";
            // 
            // SortCounterLabel
            // 
            this.SortCounterLabel.AutoSize = true;
            this.SortCounterLabel.Location = new System.Drawing.Point(750, 27);
            this.SortCounterLabel.Name = "SortCounterLabel";
            this.SortCounterLabel.Size = new System.Drawing.Size(13, 13);
            this.SortCounterLabel.TabIndex = 9;
            this.SortCounterLabel.Text = "0";
            // 
            // TimeElapsedInt
            // 
            this.TimeElapsedInt.AutoSize = true;
            this.TimeElapsedInt.Location = new System.Drawing.Point(833, 27);
            this.TimeElapsedInt.Name = "TimeElapsedInt";
            this.TimeElapsedInt.Size = new System.Drawing.Size(13, 13);
            this.TimeElapsedInt.TabIndex = 10;
            this.TimeElapsedInt.Text = "0";
            // 
            // ComparisonInt
            // 
            this.ComparisonInt.AutoSize = true;
            this.ComparisonInt.Location = new System.Drawing.Point(984, 27);
            this.ComparisonInt.Name = "ComparisonInt";
            this.ComparisonInt.Size = new System.Drawing.Size(13, 13);
            this.ComparisonInt.TabIndex = 11;
            this.ComparisonInt.Text = "0";
            // 
            // zedGraphControl1
            // 
            this.zedGraphControl1.Location = new System.Drawing.Point(275, 89);
            this.zedGraphControl1.Name = "zedGraphControl1";
            this.zedGraphControl1.ScrollGrace = 0D;
            this.zedGraphControl1.ScrollMaxX = 0D;
            this.zedGraphControl1.ScrollMaxY = 0D;
            this.zedGraphControl1.ScrollMaxY2 = 0D;
            this.zedGraphControl1.ScrollMinX = 0D;
            this.zedGraphControl1.ScrollMinY = 0D;
            this.zedGraphControl1.ScrollMinY2 = 0D;
            this.zedGraphControl1.Size = new System.Drawing.Size(369, 285);
            this.zedGraphControl1.TabIndex = 12;
            this.zedGraphControl1.UseExtendedPrintDialog = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1190, 516);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 53);
            this.button1.TabIndex = 13;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1311, 516);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 53);
            this.button2.TabIndex = 14;
            this.button2.Text = "Reset";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // zedGraphControl2
            // 
            this.zedGraphControl2.Location = new System.Drawing.Point(1099, 89);
            this.zedGraphControl2.Name = "zedGraphControl2";
            this.zedGraphControl2.ScrollGrace = 0D;
            this.zedGraphControl2.ScrollMaxX = 0D;
            this.zedGraphControl2.ScrollMaxY = 0D;
            this.zedGraphControl2.ScrollMaxY2 = 0D;
            this.zedGraphControl2.ScrollMinX = 0D;
            this.zedGraphControl2.ScrollMinY = 0D;
            this.zedGraphControl2.ScrollMinY2 = 0D;
            this.zedGraphControl2.Size = new System.Drawing.Size(377, 285);
            this.zedGraphControl2.TabIndex = 15;
            this.zedGraphControl2.UseExtendedPrintDialog = true;
            // 
            // shakercheck
            // 
            this.shakercheck.AutoSize = true;
            this.shakercheck.Location = new System.Drawing.Point(1255, 66);
            this.shakercheck.Name = "shakercheck";
            this.shakercheck.Size = new System.Drawing.Size(82, 17);
            this.shakercheck.TabIndex = 16;
            this.shakercheck.Text = "Shaker Sort";
            this.shakercheck.UseVisualStyleBackColor = true;
            // 
            // intergraph
            // 
            this.intergraph.Location = new System.Drawing.Point(275, 401);
            this.intergraph.Name = "intergraph";
            this.intergraph.ScrollGrace = 0D;
            this.intergraph.ScrollMaxX = 0D;
            this.intergraph.ScrollMaxY = 0D;
            this.intergraph.ScrollMaxY2 = 0D;
            this.intergraph.ScrollMinX = 0D;
            this.intergraph.ScrollMinY = 0D;
            this.intergraph.ScrollMinY2 = 0D;
            this.intergraph.Size = new System.Drawing.Size(369, 285);
            this.intergraph.TabIndex = 18;
            this.intergraph.UseExtendedPrintDialog = true;
            // 
            // Intersectioncheck
            // 
            this.Intersectioncheck.AutoSize = true;
            this.Intersectioncheck.Location = new System.Drawing.Point(417, 378);
            this.Intersectioncheck.Name = "Intersectioncheck";
            this.Intersectioncheck.Size = new System.Drawing.Size(88, 17);
            this.Intersectioncheck.TabIndex = 17;
            this.Intersectioncheck.Text = "InsectionSort";
            this.Intersectioncheck.UseVisualStyleBackColor = true;
            // 
            // quickgraph
            // 
            this.quickgraph.Location = new System.Drawing.Point(684, 401);
            this.quickgraph.Name = "quickgraph";
            this.quickgraph.ScrollGrace = 0D;
            this.quickgraph.ScrollMaxX = 0D;
            this.quickgraph.ScrollMaxY = 0D;
            this.quickgraph.ScrollMaxY2 = 0D;
            this.quickgraph.ScrollMinX = 0D;
            this.quickgraph.ScrollMinY = 0D;
            this.quickgraph.ScrollMinY2 = 0D;
            this.quickgraph.Size = new System.Drawing.Size(369, 285);
            this.quickgraph.TabIndex = 20;
            this.quickgraph.UseExtendedPrintDialog = true;
            // 
            // quickcheck
            // 
            this.quickcheck.AutoSize = true;
            this.quickcheck.Location = new System.Drawing.Point(826, 378);
            this.quickcheck.Name = "quickcheck";
            this.quickcheck.Size = new System.Drawing.Size(73, 17);
            this.quickcheck.TabIndex = 19;
            this.quickcheck.Text = "QuickSort";
            this.quickcheck.UseVisualStyleBackColor = true;
            // 
            // bogograph
            // 
            this.bogograph.Location = new System.Drawing.Point(684, 89);
            this.bogograph.Name = "bogograph";
            this.bogograph.ScrollGrace = 0D;
            this.bogograph.ScrollMaxX = 0D;
            this.bogograph.ScrollMaxY = 0D;
            this.bogograph.ScrollMaxY2 = 0D;
            this.bogograph.ScrollMinX = 0D;
            this.bogograph.ScrollMinY = 0D;
            this.bogograph.ScrollMinY2 = 0D;
            this.bogograph.Size = new System.Drawing.Size(369, 285);
            this.bogograph.TabIndex = 22;
            this.bogograph.UseExtendedPrintDialog = true;
            // 
            // bogocheck
            // 
            this.bogocheck.AutoSize = true;
            this.bogocheck.Location = new System.Drawing.Point(836, 66);
            this.bogocheck.Name = "bogocheck";
            this.bogocheck.Size = new System.Drawing.Size(57, 17);
            this.bogocheck.TabIndex = 21;
            this.bogocheck.Text = "BOGO";
            this.bogocheck.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1506, 739);
            this.Controls.Add(this.bogograph);
            this.Controls.Add(this.bogocheck);
            this.Controls.Add(this.quickgraph);
            this.Controls.Add(this.quickcheck);
            this.Controls.Add(this.intergraph);
            this.Controls.Add(this.Intersectioncheck);
            this.Controls.Add(this.shakercheck);
            this.Controls.Add(this.zedGraphControl2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.zedGraphControl1);
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
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private ZedGraph.ZedGraphControl zedGraphControl1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private ZedGraph.ZedGraphControl zedGraphControl2;
        private System.Windows.Forms.CheckBox shakercheck;
        private ZedGraph.ZedGraphControl intergraph;
        private System.Windows.Forms.CheckBox Intersectioncheck;
        private ZedGraph.ZedGraphControl quickgraph;
        private System.Windows.Forms.CheckBox quickcheck;
        private ZedGraph.ZedGraphControl bogograph;
        private System.Windows.Forms.CheckBox bogocheck;
    }
}

