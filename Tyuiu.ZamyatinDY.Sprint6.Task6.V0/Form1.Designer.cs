namespace Tyuiu.ZamyatinDY.Sprint6.Task6.V0
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panelTop_ZDY = new System.Windows.Forms.Panel();
            this.buttonHelp_ZDY = new System.Windows.Forms.Button();
            this.buttonOpenFile_ZDY = new System.Windows.Forms.Button();
            this.buttonDone_ZDY = new System.Windows.Forms.Button();
            this.groupBoxTask_ZDY = new System.Windows.Forms.GroupBox();
            this.textBoxTask_ZDY = new System.Windows.Forms.TextBox();
            this.panelLeft_ZDY = new System.Windows.Forms.Panel();
            this.dataGridViewNums_ZDY = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.labelResult_ZDY = new System.Windows.Forms.Label();
            this.panelMiddle_ZDY = new System.Windows.Forms.Panel();
            this.chartFunction_ZDY = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelTop_ZDY.SuspendLayout();
            this.groupBoxTask_ZDY.SuspendLayout();
            this.panelLeft_ZDY.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNums_ZDY)).BeginInit();
            this.panelMiddle_ZDY.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_ZDY)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop_ZDY
            // 
            this.panelTop_ZDY.Controls.Add(this.buttonHelp_ZDY);
            this.panelTop_ZDY.Controls.Add(this.buttonOpenFile_ZDY);
            this.panelTop_ZDY.Controls.Add(this.buttonDone_ZDY);
            this.panelTop_ZDY.Controls.Add(this.groupBoxTask_ZDY);
            this.panelTop_ZDY.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop_ZDY.Location = new System.Drawing.Point(0, 0);
            this.panelTop_ZDY.Name = "panelTop_ZDY";
            this.panelTop_ZDY.Size = new System.Drawing.Size(905, 100);
            this.panelTop_ZDY.TabIndex = 0;
            // 
            // buttonHelp_ZDY
            // 
            this.buttonHelp_ZDY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp_ZDY.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonHelp_ZDY.Location = new System.Drawing.Point(797, 19);
            this.buttonHelp_ZDY.Name = "buttonHelp_ZDY";
            this.buttonHelp_ZDY.Size = new System.Drawing.Size(91, 66);
            this.buttonHelp_ZDY.TabIndex = 1;
            this.buttonHelp_ZDY.Text = "Справка";
            this.buttonHelp_ZDY.UseVisualStyleBackColor = false;
            this.buttonHelp_ZDY.Click += new System.EventHandler(this.buttonHelp_ZDY_Click);
            // 
            // buttonOpenFile_ZDY
            // 
            this.buttonOpenFile_ZDY.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonOpenFile_ZDY.Location = new System.Drawing.Point(690, 19);
            this.buttonOpenFile_ZDY.Name = "buttonOpenFile_ZDY";
            this.buttonOpenFile_ZDY.Size = new System.Drawing.Size(91, 66);
            this.buttonOpenFile_ZDY.TabIndex = 1;
            this.buttonOpenFile_ZDY.Text = "Открыть файл";
            this.buttonOpenFile_ZDY.UseVisualStyleBackColor = false;
            this.buttonOpenFile_ZDY.Click += new System.EventHandler(this.buttonOpenFile_ZDY_Click);
            // 
            // buttonDone_ZDY
            // 
            this.buttonDone_ZDY.BackColor = System.Drawing.Color.Green;
            this.buttonDone_ZDY.Location = new System.Drawing.Point(582, 19);
            this.buttonDone_ZDY.Name = "buttonDone_ZDY";
            this.buttonDone_ZDY.Size = new System.Drawing.Size(91, 66);
            this.buttonDone_ZDY.TabIndex = 1;
            this.buttonDone_ZDY.Text = "Выполнить";
            this.buttonDone_ZDY.UseVisualStyleBackColor = false;
            this.buttonDone_ZDY.Click += new System.EventHandler(this.buttonDone_ZDY_Click);
            // 
            // groupBoxTask_ZDY
            // 
            this.groupBoxTask_ZDY.Controls.Add(this.textBoxTask_ZDY);
            this.groupBoxTask_ZDY.Location = new System.Drawing.Point(4, 9);
            this.groupBoxTask_ZDY.Name = "groupBoxTask_ZDY";
            this.groupBoxTask_ZDY.Size = new System.Drawing.Size(568, 82);
            this.groupBoxTask_ZDY.TabIndex = 0;
            this.groupBoxTask_ZDY.TabStop = false;
            this.groupBoxTask_ZDY.Text = "Условие:";
            // 
            // textBoxTask_ZDY
            // 
            this.textBoxTask_ZDY.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxTask_ZDY.Location = new System.Drawing.Point(3, 16);
            this.textBoxTask_ZDY.Multiline = true;
            this.textBoxTask_ZDY.Name = "textBoxTask_ZDY";
            this.textBoxTask_ZDY.ReadOnly = true;
            this.textBoxTask_ZDY.Size = new System.Drawing.Size(562, 63);
            this.textBoxTask_ZDY.TabIndex = 0;
            this.textBoxTask_ZDY.Text = "Прочитать данные из файла InPutFileTask5.txt. Вывести в dataGridView\r\nположительн" +
    "ые значения и построить диаграмму по этим значениям.";
            // 
            // panelLeft_ZDY
            // 
            this.panelLeft_ZDY.Controls.Add(this.dataGridViewNums_ZDY);
            this.panelLeft_ZDY.Controls.Add(this.splitter1);
            this.panelLeft_ZDY.Controls.Add(this.labelResult_ZDY);
            this.panelLeft_ZDY.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft_ZDY.Location = new System.Drawing.Point(0, 100);
            this.panelLeft_ZDY.Name = "panelLeft_ZDY";
            this.panelLeft_ZDY.Size = new System.Drawing.Size(221, 363);
            this.panelLeft_ZDY.TabIndex = 1;
            // 
            // dataGridViewNums_ZDY
            // 
            this.dataGridViewNums_ZDY.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNums_ZDY.ColumnHeadersVisible = false;
            this.dataGridViewNums_ZDY.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridViewNums_ZDY.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewNums_ZDY.Location = new System.Drawing.Point(3, 0);
            this.dataGridViewNums_ZDY.Name = "dataGridViewNums_ZDY";
            this.dataGridViewNums_ZDY.ReadOnly = true;
            this.dataGridViewNums_ZDY.RowHeadersVisible = false;
            this.dataGridViewNums_ZDY.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewNums_ZDY.Size = new System.Drawing.Size(218, 363);
            this.dataGridViewNums_ZDY.TabIndex = 4;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 363);
            this.splitter1.TabIndex = 3;
            this.splitter1.TabStop = false;
            // 
            // labelResult_ZDY
            // 
            this.labelResult_ZDY.AutoSize = true;
            this.labelResult_ZDY.Location = new System.Drawing.Point(3, 3);
            this.labelResult_ZDY.Name = "labelResult_ZDY";
            this.labelResult_ZDY.Size = new System.Drawing.Size(83, 13);
            this.labelResult_ZDY.TabIndex = 2;
            this.labelResult_ZDY.Text = "Вывод данных:";
            // 
            // panelMiddle_ZDY
            // 
            this.panelMiddle_ZDY.Controls.Add(this.chartFunction_ZDY);
            this.panelMiddle_ZDY.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMiddle_ZDY.Location = new System.Drawing.Point(221, 100);
            this.panelMiddle_ZDY.Name = "panelMiddle_ZDY";
            this.panelMiddle_ZDY.Size = new System.Drawing.Size(684, 363);
            this.panelMiddle_ZDY.TabIndex = 2;
            // 
            // chartFunction_ZDY
            // 
            chartArea4.Name = "ChartArea1";
            this.chartFunction_ZDY.ChartAreas.Add(chartArea4);
            this.chartFunction_ZDY.Dock = System.Windows.Forms.DockStyle.Fill;
            legend4.Enabled = false;
            legend4.Name = "Legend1";
            this.chartFunction_ZDY.Legends.Add(legend4);
            this.chartFunction_ZDY.Location = new System.Drawing.Point(0, 0);
            this.chartFunction_ZDY.Name = "chartFunction_ZDY";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chartFunction_ZDY.Series.Add(series4);
            this.chartFunction_ZDY.Size = new System.Drawing.Size(684, 363);
            this.chartFunction_ZDY.TabIndex = 0;
            this.chartFunction_ZDY.Text = "chart1";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 463);
            this.Controls.Add(this.panelMiddle_ZDY);
            this.Controls.Add(this.panelLeft_ZDY);
            this.Controls.Add(this.panelTop_ZDY);
            this.MinimumSize = new System.Drawing.Size(921, 502);
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 5 | Вариант 0 | Замятин Д.Ю.";
            this.panelTop_ZDY.ResumeLayout(false);
            this.groupBoxTask_ZDY.ResumeLayout(false);
            this.groupBoxTask_ZDY.PerformLayout();
            this.panelLeft_ZDY.ResumeLayout(false);
            this.panelLeft_ZDY.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNums_ZDY)).EndInit();
            this.panelMiddle_ZDY.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_ZDY)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop_ZDY;
        private System.Windows.Forms.GroupBox groupBoxTask_ZDY;
        private System.Windows.Forms.Panel panelLeft_ZDY;
        private System.Windows.Forms.Panel panelMiddle_ZDY;
        private System.Windows.Forms.TextBox textBoxTask_ZDY;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Label labelResult_ZDY;
        private System.Windows.Forms.Button buttonHelp_ZDY;
        private System.Windows.Forms.Button buttonOpenFile_ZDY;
        private System.Windows.Forms.Button buttonDone_ZDY;
        private System.Windows.Forms.DataGridView dataGridViewNums_ZDY;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_ZDY;
    }
}

