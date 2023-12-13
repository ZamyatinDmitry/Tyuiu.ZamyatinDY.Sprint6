namespace Tyuiu.ZamyatinDY.Sprint6.Task2.V0
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBoxTask_ZDY = new System.Windows.Forms.GroupBox();
            this.textBoxTask_ZDY = new System.Windows.Forms.TextBox();
            this.groupBoxInputData_ZDY = new System.Windows.Forms.GroupBox();
            this.textBoxStart_ZDY = new System.Windows.Forms.TextBox();
            this.textBoxStop_ZDY = new System.Windows.Forms.TextBox();
            this.labelStart_ZDY = new System.Windows.Forms.Label();
            this.labelStop_ZDY = new System.Windows.Forms.Label();
            this.buttonHelp_ZDY = new System.Windows.Forms.Button();
            this.buttonDone_ZDY = new System.Windows.Forms.Button();
            this.groupBoxOutputData_ZDY = new System.Windows.Forms.GroupBox();
            this.dataGridViewFunction = new System.Windows.Forms.DataGridView();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelResultGrid_ZDY = new System.Windows.Forms.Label();
            this.chartFunction = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBoxTask_ZDY.SuspendLayout();
            this.groupBoxInputData_ZDY.SuspendLayout();
            this.groupBoxOutputData_ZDY.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTask_ZDY
            // 
            this.groupBoxTask_ZDY.Controls.Add(this.textBoxTask_ZDY);
            this.groupBoxTask_ZDY.Location = new System.Drawing.Point(13, 13);
            this.groupBoxTask_ZDY.Name = "groupBoxTask_ZDY";
            this.groupBoxTask_ZDY.Size = new System.Drawing.Size(533, 329);
            this.groupBoxTask_ZDY.TabIndex = 0;
            this.groupBoxTask_ZDY.TabStop = false;
            this.groupBoxTask_ZDY.Text = "Условие";
            // 
            // textBoxTask_ZDY
            // 
            this.textBoxTask_ZDY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxTask_ZDY.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxTask_ZDY.Location = new System.Drawing.Point(3, 16);
            this.textBoxTask_ZDY.Multiline = true;
            this.textBoxTask_ZDY.Name = "textBoxTask_ZDY";
            this.textBoxTask_ZDY.ReadOnly = true;
            this.textBoxTask_ZDY.Size = new System.Drawing.Size(527, 310);
            this.textBoxTask_ZDY.TabIndex = 0;
            this.textBoxTask_ZDY.Text = "Протабулировать функцию sin(x) на заданном диапозоне.\r\nРезультат вывести в DataGr" +
    "idView и построить график функции.";
            // 
            // groupBoxInputData_ZDY
            // 
            this.groupBoxInputData_ZDY.Controls.Add(this.labelStop_ZDY);
            this.groupBoxInputData_ZDY.Controls.Add(this.labelStart_ZDY);
            this.groupBoxInputData_ZDY.Controls.Add(this.textBoxStop_ZDY);
            this.groupBoxInputData_ZDY.Controls.Add(this.textBoxStart_ZDY);
            this.groupBoxInputData_ZDY.Location = new System.Drawing.Point(16, 349);
            this.groupBoxInputData_ZDY.Name = "groupBoxInputData_ZDY";
            this.groupBoxInputData_ZDY.Size = new System.Drawing.Size(269, 69);
            this.groupBoxInputData_ZDY.TabIndex = 1;
            this.groupBoxInputData_ZDY.TabStop = false;
            this.groupBoxInputData_ZDY.Text = "Ввод данных";
            // 
            // textBoxStart_ZDY
            // 
            this.textBoxStart_ZDY.Location = new System.Drawing.Point(18, 38);
            this.textBoxStart_ZDY.Name = "textBoxStart_ZDY";
            this.textBoxStart_ZDY.Size = new System.Drawing.Size(100, 20);
            this.textBoxStart_ZDY.TabIndex = 0;
            // 
            // textBoxStop_ZDY
            // 
            this.textBoxStop_ZDY.Location = new System.Drawing.Point(138, 38);
            this.textBoxStop_ZDY.Name = "textBoxStop_ZDY";
            this.textBoxStop_ZDY.Size = new System.Drawing.Size(100, 20);
            this.textBoxStop_ZDY.TabIndex = 0;
            // 
            // labelStart_ZDY
            // 
            this.labelStart_ZDY.AutoSize = true;
            this.labelStart_ZDY.Location = new System.Drawing.Point(18, 20);
            this.labelStart_ZDY.Name = "labelStart_ZDY";
            this.labelStart_ZDY.Size = new System.Drawing.Size(67, 13);
            this.labelStart_ZDY.TabIndex = 1;
            this.labelStart_ZDY.Text = "Старт шага:";
            // 
            // labelStop_ZDY
            // 
            this.labelStop_ZDY.AutoSize = true;
            this.labelStop_ZDY.Location = new System.Drawing.Point(135, 20);
            this.labelStop_ZDY.Name = "labelStop_ZDY";
            this.labelStop_ZDY.Size = new System.Drawing.Size(69, 13);
            this.labelStop_ZDY.TabIndex = 1;
            this.labelStop_ZDY.Text = "Конец шага:";
            // 
            // buttonHelp_ZDY
            // 
            this.buttonHelp_ZDY.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonHelp_ZDY.Location = new System.Drawing.Point(300, 357);
            this.buttonHelp_ZDY.Name = "buttonHelp_ZDY";
            this.buttonHelp_ZDY.Size = new System.Drawing.Size(81, 60);
            this.buttonHelp_ZDY.TabIndex = 2;
            this.buttonHelp_ZDY.Text = "Справка";
            this.buttonHelp_ZDY.UseVisualStyleBackColor = false;
            // 
            // buttonDone_ZDY
            // 
            this.buttonDone_ZDY.BackColor = System.Drawing.Color.Green;
            this.buttonDone_ZDY.Location = new System.Drawing.Point(393, 357);
            this.buttonDone_ZDY.Name = "buttonDone_ZDY";
            this.buttonDone_ZDY.Size = new System.Drawing.Size(150, 60);
            this.buttonDone_ZDY.TabIndex = 2;
            this.buttonDone_ZDY.Text = "Выполнить";
            this.buttonDone_ZDY.UseVisualStyleBackColor = false;
            this.buttonDone_ZDY.Click += new System.EventHandler(this.buttonDone_ZDY_Click);
            this.buttonDone_ZDY.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonDone_ZDY_MouseDown);
            this.buttonDone_ZDY.MouseEnter += new System.EventHandler(this.buttonDone_ZDY_MouseEnter);
            this.buttonDone_ZDY.MouseLeave += new System.EventHandler(this.buttonDone_ZDY_MouseLeave);
            // 
            // groupBoxOutputData_ZDY
            // 
            this.groupBoxOutputData_ZDY.Controls.Add(this.chartFunction);
            this.groupBoxOutputData_ZDY.Controls.Add(this.labelResultGrid_ZDY);
            this.groupBoxOutputData_ZDY.Controls.Add(this.dataGridViewFunction);
            this.groupBoxOutputData_ZDY.Location = new System.Drawing.Point(552, 13);
            this.groupBoxOutputData_ZDY.Name = "groupBoxOutputData_ZDY";
            this.groupBoxOutputData_ZDY.Size = new System.Drawing.Size(540, 405);
            this.groupBoxOutputData_ZDY.TabIndex = 3;
            this.groupBoxOutputData_ZDY.TabStop = false;
            this.groupBoxOutputData_ZDY.Text = "Вывод данных";
            // 
            // dataGridViewFunction
            // 
            this.dataGridViewFunction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFunction.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.X,
            this.Column2});
            this.dataGridViewFunction.Location = new System.Drawing.Point(7, 39);
            this.dataGridViewFunction.Name = "dataGridViewFunction";
            this.dataGridViewFunction.ReadOnly = true;
            this.dataGridViewFunction.RowHeadersVisible = false;
            this.dataGridViewFunction.Size = new System.Drawing.Size(117, 360);
            this.dataGridViewFunction.TabIndex = 0;
            // 
            // X
            // 
            this.X.HeaderText = "X";
            this.X.Name = "X";
            this.X.Width = 50;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "F(X)";
            this.Column2.Name = "Column2";
            this.Column2.Width = 50;
            // 
            // labelResultGrid_ZDY
            // 
            this.labelResultGrid_ZDY.AutoSize = true;
            this.labelResultGrid_ZDY.Location = new System.Drawing.Point(7, 20);
            this.labelResultGrid_ZDY.Name = "labelResultGrid_ZDY";
            this.labelResultGrid_ZDY.Size = new System.Drawing.Size(62, 13);
            this.labelResultGrid_ZDY.TabIndex = 1;
            this.labelResultGrid_ZDY.Text = "Результат:";
            // 
            // chartFunction
            // 
            chartArea6.Name = "ChartArea1";
            this.chartFunction.ChartAreas.Add(chartArea6);
            legend6.Enabled = false;
            legend6.Name = "Legend1";
            this.chartFunction.Legends.Add(legend6);
            this.chartFunction.Location = new System.Drawing.Point(140, 39);
            this.chartFunction.Name = "chartFunction";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series6.IsVisibleInLegend = false;
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.chartFunction.Series.Add(series6);
            this.chartFunction.Size = new System.Drawing.Size(394, 360);
            this.chartFunction.TabIndex = 2;
            this.chartFunction.Text = "chart1";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 430);
            this.Controls.Add(this.groupBoxOutputData_ZDY);
            this.Controls.Add(this.buttonDone_ZDY);
            this.Controls.Add(this.buttonHelp_ZDY);
            this.Controls.Add(this.groupBoxInputData_ZDY);
            this.Controls.Add(this.groupBoxTask_ZDY);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 2 | Вариант 0 | Замятин Д.Ю.";
            this.groupBoxTask_ZDY.ResumeLayout(false);
            this.groupBoxTask_ZDY.PerformLayout();
            this.groupBoxInputData_ZDY.ResumeLayout(false);
            this.groupBoxInputData_ZDY.PerformLayout();
            this.groupBoxOutputData_ZDY.ResumeLayout(false);
            this.groupBoxOutputData_ZDY.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_ZDY;
        private System.Windows.Forms.TextBox textBoxTask_ZDY;
        private System.Windows.Forms.GroupBox groupBoxInputData_ZDY;
        private System.Windows.Forms.TextBox textBoxStop_ZDY;
        private System.Windows.Forms.TextBox textBoxStart_ZDY;
        private System.Windows.Forms.Label labelStop_ZDY;
        private System.Windows.Forms.Label labelStart_ZDY;
        private System.Windows.Forms.Button buttonHelp_ZDY;
        private System.Windows.Forms.Button buttonDone_ZDY;
        private System.Windows.Forms.GroupBox groupBoxOutputData_ZDY;
        private System.Windows.Forms.DataGridView dataGridViewFunction;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction;
        private System.Windows.Forms.Label labelResultGrid_ZDY;
        private System.Windows.Forms.DataGridViewTextBoxColumn X;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}

