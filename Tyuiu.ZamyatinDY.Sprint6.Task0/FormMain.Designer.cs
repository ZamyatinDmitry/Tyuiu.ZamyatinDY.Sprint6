namespace Tyuiu.ZamyatinDY.Sprint6.Task0
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.groupMain_ZDY = new System.Windows.Forms.GroupBox();
            this.pictureBoxTask_ZDY = new System.Windows.Forms.PictureBox();
            this.groupBoxResultData_ZDY = new System.Windows.Forms.GroupBox();
            this.labelResult_ZDY = new System.Windows.Forms.Label();
            this.textBoxResult_ZDY = new System.Windows.Forms.TextBox();
            this.buttonDone_ZDY = new System.Windows.Forms.Button();
            this.buttonQuest_ZDY = new System.Windows.Forms.Button();
            this.textBoxTask_ZDY = new System.Windows.Forms.TextBox();
            this.groupMain_ZDY.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTask_ZDY)).BeginInit();
            this.groupBoxResultData_ZDY.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupMain_ZDY
            // 
            this.groupMain_ZDY.Controls.Add(this.textBoxTask_ZDY);
            this.groupMain_ZDY.Controls.Add(this.pictureBoxTask_ZDY);
            this.groupMain_ZDY.Location = new System.Drawing.Point(23, 28);
            this.groupMain_ZDY.Name = "groupMain_ZDY";
            this.groupMain_ZDY.Size = new System.Drawing.Size(743, 196);
            this.groupMain_ZDY.TabIndex = 0;
            this.groupMain_ZDY.TabStop = false;
            this.groupMain_ZDY.Text = "Условие";
            // 
            // pictureBoxTask_ZDY
            // 
            this.pictureBoxTask_ZDY.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxTask_ZDY.Image")));
            this.pictureBoxTask_ZDY.Location = new System.Drawing.Point(470, 36);
            this.pictureBoxTask_ZDY.Name = "pictureBoxTask_ZDY";
            this.pictureBoxTask_ZDY.Size = new System.Drawing.Size(267, 35);
            this.pictureBoxTask_ZDY.TabIndex = 1;
            this.pictureBoxTask_ZDY.TabStop = false;
            // 
            // groupBoxResultData_ZDY
            // 
            this.groupBoxResultData_ZDY.Controls.Add(this.labelResult_ZDY);
            this.groupBoxResultData_ZDY.Controls.Add(this.textBoxResult_ZDY);
            this.groupBoxResultData_ZDY.Location = new System.Drawing.Point(548, 250);
            this.groupBoxResultData_ZDY.Name = "groupBoxResultData_ZDY";
            this.groupBoxResultData_ZDY.Size = new System.Drawing.Size(218, 123);
            this.groupBoxResultData_ZDY.TabIndex = 2;
            this.groupBoxResultData_ZDY.TabStop = false;
            this.groupBoxResultData_ZDY.Text = "Вывод данных";
            // 
            // labelResult_ZDY
            // 
            this.labelResult_ZDY.AutoSize = true;
            this.labelResult_ZDY.Location = new System.Drawing.Point(25, 34);
            this.labelResult_ZDY.Name = "labelResult_ZDY";
            this.labelResult_ZDY.Size = new System.Drawing.Size(62, 13);
            this.labelResult_ZDY.TabIndex = 1;
            this.labelResult_ZDY.Text = "Результат:";
            // 
            // textBoxResult_ZDY
            // 
            this.textBoxResult_ZDY.Location = new System.Drawing.Point(28, 53);
            this.textBoxResult_ZDY.Name = "textBoxResult_ZDY";
            this.textBoxResult_ZDY.ReadOnly = true;
            this.textBoxResult_ZDY.Size = new System.Drawing.Size(163, 20);
            this.textBoxResult_ZDY.TabIndex = 0;
            // 
            // buttonDone_ZDY
            // 
            this.buttonDone_ZDY.Location = new System.Drawing.Point(592, 402);
            this.buttonDone_ZDY.Name = "buttonDone_ZDY";
            this.buttonDone_ZDY.Size = new System.Drawing.Size(174, 36);
            this.buttonDone_ZDY.TabIndex = 3;
            this.buttonDone_ZDY.Text = "Выполнить";
            this.buttonDone_ZDY.UseVisualStyleBackColor = true;
            this.buttonDone_ZDY.Click += new System.EventHandler(this.buttonDone_ZDY_Click);
            // 
            // buttonQuest_ZDY
            // 
            this.buttonQuest_ZDY.Location = new System.Drawing.Point(548, 402);
            this.buttonQuest_ZDY.Name = "buttonQuest_ZDY";
            this.buttonQuest_ZDY.Size = new System.Drawing.Size(38, 36);
            this.buttonQuest_ZDY.TabIndex = 3;
            this.buttonQuest_ZDY.Text = "?";
            this.buttonQuest_ZDY.UseVisualStyleBackColor = true;
            this.buttonQuest_ZDY.Click += new System.EventHandler(this.buttonQuest_ZDY_Click);
            // 
            // textBoxTask_ZDY
            // 
            this.textBoxTask_ZDY.Location = new System.Drawing.Point(19, 19);
            this.textBoxTask_ZDY.Multiline = true;
            this.textBoxTask_ZDY.Name = "textBoxTask_ZDY";
            this.textBoxTask_ZDY.Size = new System.Drawing.Size(433, 161);
            this.textBoxTask_ZDY.TabIndex = 2;
            this.textBoxTask_ZDY.Text = "Дано выражение, вычислить его значение при x = 2, результат вывести в TextBox. \r\n" +
    "Округлить до трёх знаков после запятой. \r\nГрафифеческий интерфейс оформить по ша" +
    "блону из лекции.";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonQuest_ZDY);
            this.Controls.Add(this.buttonDone_ZDY);
            this.Controls.Add(this.groupBoxResultData_ZDY);
            this.Controls.Add(this.groupMain_ZDY);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 0 | Вариант 0 | Замятин Д.Ю.";
            this.groupMain_ZDY.ResumeLayout(false);
            this.groupMain_ZDY.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTask_ZDY)).EndInit();
            this.groupBoxResultData_ZDY.ResumeLayout(false);
            this.groupBoxResultData_ZDY.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupMain_ZDY;
        private System.Windows.Forms.PictureBox pictureBoxTask_ZDY;
        private System.Windows.Forms.GroupBox groupBoxResultData_ZDY;
        private System.Windows.Forms.Label labelResult_ZDY;
        private System.Windows.Forms.TextBox textBoxResult_ZDY;
        private System.Windows.Forms.Button buttonDone_ZDY;
        private System.Windows.Forms.Button buttonQuest_ZDY;
        private System.Windows.Forms.TextBox textBoxTask_ZDY;
    }
}

