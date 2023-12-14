namespace Tyuiu.ZamyatinDY.Sprint6.Task3.V0
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
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.panelTop_ZDY = new System.Windows.Forms.Panel();
            this.groupBoxOutPutData_ZDY = new System.Windows.Forms.GroupBox();
            this.labelStart_ZDY = new System.Windows.Forms.Label();
            this.textBoxStop_ZDY = new System.Windows.Forms.TextBox();
            this.textBoxStart_ZDY = new System.Windows.Forms.TextBox();
            this.groupBoxTask_ZDY = new System.Windows.Forms.GroupBox();
            this.textBoxTask_ZDY = new System.Windows.Forms.TextBox();
            this.panelLeft_ZDy = new System.Windows.Forms.Panel();
            this.panelMid_ZDY = new System.Windows.Forms.Panel();
            this.labelStop_ZDY = new System.Windows.Forms.Label();
            this.buttonHelp_ZDY = new System.Windows.Forms.Button();
            this.buttonSave_ZDY = new System.Windows.Forms.Button();
            this.buttonDone_ZDY = new System.Windows.Forms.Button();
            this.textBoxResult_ZDY = new System.Windows.Forms.TextBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.chartFunction = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelResult_ZDY = new System.Windows.Forms.Label();
            this.panelTop_ZDY.SuspendLayout();
            this.groupBoxOutPutData_ZDY.SuspendLayout();
            this.groupBoxTask_ZDY.SuspendLayout();
            this.panelLeft_ZDy.SuspendLayout();
            this.panelMid_ZDY.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop_ZDY
            // 
            this.panelTop_ZDY.Controls.Add(this.buttonHelp_ZDY);
            this.panelTop_ZDY.Controls.Add(this.buttonSave_ZDY);
            this.panelTop_ZDY.Controls.Add(this.buttonDone_ZDY);
            this.panelTop_ZDY.Controls.Add(this.groupBoxOutPutData_ZDY);
            this.panelTop_ZDY.Controls.Add(this.groupBoxTask_ZDY);
            this.panelTop_ZDY.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop_ZDY.Location = new System.Drawing.Point(0, 0);
            this.panelTop_ZDY.Name = "panelTop_ZDY";
            this.panelTop_ZDY.Size = new System.Drawing.Size(1040, 100);
            this.panelTop_ZDY.TabIndex = 0;
            this.panelTop_ZDY.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTop_ZDY_Paint);
            // 
            // groupBoxOutPutData_ZDY
            // 
            this.groupBoxOutPutData_ZDY.Controls.Add(this.labelStop_ZDY);
            this.groupBoxOutPutData_ZDY.Controls.Add(this.labelStart_ZDY);
            this.groupBoxOutPutData_ZDY.Controls.Add(this.textBoxStop_ZDY);
            this.groupBoxOutPutData_ZDY.Controls.Add(this.textBoxStart_ZDY);
            this.groupBoxOutPutData_ZDY.Location = new System.Drawing.Point(484, 13);
            this.groupBoxOutPutData_ZDY.Name = "groupBoxOutPutData_ZDY";
            this.groupBoxOutPutData_ZDY.Size = new System.Drawing.Size(286, 75);
            this.groupBoxOutPutData_ZDY.TabIndex = 1;
            this.groupBoxOutPutData_ZDY.TabStop = false;
            this.groupBoxOutPutData_ZDY.Text = "Ввод данных";
            // 
            // labelStart_ZDY
            // 
            this.labelStart_ZDY.AutoSize = true;
            this.labelStart_ZDY.Location = new System.Drawing.Point(7, 25);
            this.labelStart_ZDY.Name = "labelStart_ZDY";
            this.labelStart_ZDY.Size = new System.Drawing.Size(67, 13);
            this.labelStart_ZDY.TabIndex = 1;
            this.labelStart_ZDY.Text = "Старт шага:";
            this.labelStart_ZDY.Click += new System.EventHandler(this.labelStart_ZDY_Click);
            // 
            // textBoxStop_ZDY
            // 
            this.textBoxStop_ZDY.Location = new System.Drawing.Point(146, 44);
            this.textBoxStop_ZDY.Name = "textBoxStop_ZDY";
            this.textBoxStop_ZDY.Size = new System.Drawing.Size(129, 20);
            this.textBoxStop_ZDY.TabIndex = 0;
            // 
            // textBoxStart_ZDY
            // 
            this.textBoxStart_ZDY.Location = new System.Drawing.Point(7, 44);
            this.textBoxStart_ZDY.Name = "textBoxStart_ZDY";
            this.textBoxStart_ZDY.Size = new System.Drawing.Size(129, 20);
            this.textBoxStart_ZDY.TabIndex = 0;
            // 
            // groupBoxTask_ZDY
            // 
            this.groupBoxTask_ZDY.Controls.Add(this.textBoxTask_ZDY);
            this.groupBoxTask_ZDY.Location = new System.Drawing.Point(13, 13);
            this.groupBoxTask_ZDY.Name = "groupBoxTask_ZDY";
            this.groupBoxTask_ZDY.Size = new System.Drawing.Size(450, 81);
            this.groupBoxTask_ZDY.TabIndex = 0;
            this.groupBoxTask_ZDY.TabStop = false;
            this.groupBoxTask_ZDY.Text = "Условие";
            // 
            // textBoxTask_ZDY
            // 
            this.textBoxTask_ZDY.Location = new System.Drawing.Point(7, 19);
            this.textBoxTask_ZDY.Multiline = true;
            this.textBoxTask_ZDY.Name = "textBoxTask_ZDY";
            this.textBoxTask_ZDY.ReadOnly = true;
            this.textBoxTask_ZDY.Size = new System.Drawing.Size(437, 56);
            this.textBoxTask_ZDY.TabIndex = 0;
            this.textBoxTask_ZDY.Text = "Протабулировать функцию sin(x) на заданном диапазоне от -5 до 5.\r\nРезультат вывес" +
    "ти в textBox, построить график функции и сохранить в файл\r\nOutPutFileTask.txt по" +
    " нажатию кнопки.";
            // 
            // panelLeft_ZDy
            // 
            this.panelLeft_ZDy.Controls.Add(this.labelResult_ZDY);
            this.panelLeft_ZDy.Controls.Add(this.textBoxResult_ZDY);
            this.panelLeft_ZDy.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft_ZDy.Location = new System.Drawing.Point(0, 100);
            this.panelLeft_ZDy.Name = "panelLeft_ZDy";
            this.panelLeft_ZDy.Size = new System.Drawing.Size(264, 352);
            this.panelLeft_ZDy.TabIndex = 1;
            // 
            // panelMid_ZDY
            // 
            this.panelMid_ZDY.Controls.Add(this.chartFunction);
            this.panelMid_ZDY.Controls.Add(this.splitter1);
            this.panelMid_ZDY.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMid_ZDY.Location = new System.Drawing.Point(264, 100);
            this.panelMid_ZDY.Name = "panelMid_ZDY";
            this.panelMid_ZDY.Size = new System.Drawing.Size(776, 352);
            this.panelMid_ZDY.TabIndex = 3;
            // 
            // labelStop_ZDY
            // 
            this.labelStop_ZDY.AutoSize = true;
            this.labelStop_ZDY.Location = new System.Drawing.Point(143, 25);
            this.labelStop_ZDY.Name = "labelStop_ZDY";
            this.labelStop_ZDY.Size = new System.Drawing.Size(69, 13);
            this.labelStop_ZDY.TabIndex = 1;
            this.labelStop_ZDY.Text = "Конец шага:";
            this.labelStop_ZDY.Click += new System.EventHandler(this.labelStart_ZDY_Click);
            // 
            // buttonHelp_ZDY
            // 
            this.buttonHelp_ZDY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp_ZDY.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonHelp_ZDY.Location = new System.Drawing.Point(951, 17);
            this.buttonHelp_ZDY.Name = "buttonHelp_ZDY";
            this.buttonHelp_ZDY.Size = new System.Drawing.Size(79, 72);
            this.buttonHelp_ZDY.TabIndex = 3;
            this.buttonHelp_ZDY.Text = "Справка";
            this.buttonHelp_ZDY.UseVisualStyleBackColor = false;
            this.buttonHelp_ZDY.Click += new System.EventHandler(this.buttonHelp_ZDY_Click);
            // 
            // buttonSave_ZDY
            // 
            this.buttonSave_ZDY.BackColor = System.Drawing.Color.SlateBlue;
            this.buttonSave_ZDY.Location = new System.Drawing.Point(866, 17);
            this.buttonSave_ZDY.Name = "buttonSave_ZDY";
            this.buttonSave_ZDY.Size = new System.Drawing.Size(79, 72);
            this.buttonSave_ZDY.TabIndex = 4;
            this.buttonSave_ZDY.Text = "Сохранить";
            this.buttonSave_ZDY.UseVisualStyleBackColor = false;
            this.buttonSave_ZDY.Click += new System.EventHandler(this.buttonSave_ZDY_Click);
            // 
            // buttonDone_ZDY
            // 
            this.buttonDone_ZDY.BackColor = System.Drawing.Color.Green;
            this.buttonDone_ZDY.Location = new System.Drawing.Point(778, 17);
            this.buttonDone_ZDY.Name = "buttonDone_ZDY";
            this.buttonDone_ZDY.Size = new System.Drawing.Size(79, 72);
            this.buttonDone_ZDY.TabIndex = 5;
            this.buttonDone_ZDY.Text = "Выполнить";
            this.buttonDone_ZDY.UseVisualStyleBackColor = false;
            this.buttonDone_ZDY.Click += new System.EventHandler(this.buttonDone_ZDY_Click);
            // 
            // textBoxResult_ZDY
            // 
            this.textBoxResult_ZDY.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxResult_ZDY.Location = new System.Drawing.Point(0, 0);
            this.textBoxResult_ZDY.Multiline = true;
            this.textBoxResult_ZDY.Name = "textBoxResult_ZDY";
            this.textBoxResult_ZDY.ReadOnly = true;
            this.textBoxResult_ZDY.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult_ZDY.Size = new System.Drawing.Size(264, 352);
            this.textBoxResult_ZDY.TabIndex = 0;
            this.textBoxResult_ZDY.TextChanged += new System.EventHandler(this.textBoxResult_ZDY_TextChanged);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 352);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // chartFunction
            // 
            chartArea4.Name = "ChartArea1";
            this.chartFunction.ChartAreas.Add(chartArea4);
            this.chartFunction.Dock = System.Windows.Forms.DockStyle.Fill;
            legend4.Enabled = false;
            legend4.Name = "Legend1";
            this.chartFunction.Legends.Add(legend4);
            this.chartFunction.Location = new System.Drawing.Point(3, 0);
            this.chartFunction.Name = "chartFunction";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.IsVisibleInLegend = false;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chartFunction.Series.Add(series4);
            this.chartFunction.Size = new System.Drawing.Size(773, 352);
            this.chartFunction.TabIndex = 1;
            this.chartFunction.Text = "chart1";
            title4.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            title4.Font = new System.Drawing.Font("Comfortaa", 12F);
            title4.ForeColor = System.Drawing.Color.Blue;
            title4.Name = "Title1";
            title4.Text = "График функции sin(x)";
            this.chartFunction.Titles.Add(title4);
            // 
            // labelResult_ZDY
            // 
            this.labelResult_ZDY.AutoSize = true;
            this.labelResult_ZDY.Location = new System.Drawing.Point(10, 3);
            this.labelResult_ZDY.Name = "labelResult_ZDY";
            this.labelResult_ZDY.Size = new System.Drawing.Size(43, 13);
            this.labelResult_ZDY.TabIndex = 1;
            this.labelResult_ZDY.Text = "Вывод:";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 452);
            this.Controls.Add(this.panelMid_ZDY);
            this.Controls.Add(this.panelLeft_ZDy);
            this.Controls.Add(this.panelTop_ZDY);
            this.MinimumSize = new System.Drawing.Size(1056, 491);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 4 | Вариант 0 | Замятин Д.Ю.";
            this.panelTop_ZDY.ResumeLayout(false);
            this.groupBoxOutPutData_ZDY.ResumeLayout(false);
            this.groupBoxOutPutData_ZDY.PerformLayout();
            this.groupBoxTask_ZDY.ResumeLayout(false);
            this.groupBoxTask_ZDY.PerformLayout();
            this.panelLeft_ZDy.ResumeLayout(false);
            this.panelLeft_ZDy.PerformLayout();
            this.panelMid_ZDY.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop_ZDY;
        private System.Windows.Forms.Panel panelLeft_ZDy;
        private System.Windows.Forms.Panel panelMid_ZDY;
        private System.Windows.Forms.GroupBox groupBoxTask_ZDY;
        private System.Windows.Forms.TextBox textBoxTask_ZDY;
        private System.Windows.Forms.GroupBox groupBoxOutPutData_ZDY;
        private System.Windows.Forms.Label labelStart_ZDY;
        private System.Windows.Forms.TextBox textBoxStop_ZDY;
        private System.Windows.Forms.TextBox textBoxStart_ZDY;
        private System.Windows.Forms.Label labelStop_ZDY;
        private System.Windows.Forms.Button buttonHelp_ZDY;
        private System.Windows.Forms.Button buttonSave_ZDY;
        private System.Windows.Forms.Button buttonDone_ZDY;
        private System.Windows.Forms.TextBox textBoxResult_ZDY;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction;
        private System.Windows.Forms.Label labelResult_ZDY;
    }
}

