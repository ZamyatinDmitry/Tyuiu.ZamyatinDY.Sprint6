namespace WindowsFormsMyAppFirts
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
            this.buttonPushMe_zdy = new System.Windows.Forms.Button();
            this.groupBoxInputData = new System.Windows.Forms.GroupBox();
            this.textBoxVarA = new System.Windows.Forms.TextBox();
            this.textBoxVarB = new System.Windows.Forms.TextBox();
            this.groupBoxOutPutData = new System.Windows.Forms.GroupBox();
            this.textBoxresult = new System.Windows.Forms.TextBox();
            this.labelVarA = new System.Windows.Forms.Label();
            this.labelVarB = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.buttonDone = new System.Windows.Forms.Button();
            this.radioButtonPlus = new System.Windows.Forms.RadioButton();
            this.radioButtonMinus = new System.Windows.Forms.RadioButton();
            this.radioButtonMult = new System.Windows.Forms.RadioButton();
            this.radioButtonDiv = new System.Windows.Forms.RadioButton();
            this.panelRight = new System.Windows.Forms.Panel();
            this.buttonPanel = new System.Windows.Forms.Button();
            this.groupBoxInputData.SuspendLayout();
            this.groupBoxOutPutData.SuspendLayout();
            this.panelRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonPushMe_zdy
            // 
            this.buttonPushMe_zdy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPushMe_zdy.Location = new System.Drawing.Point(482, 24);
            this.buttonPushMe_zdy.Name = "buttonPushMe_zdy";
            this.buttonPushMe_zdy.Size = new System.Drawing.Size(129, 25);
            this.buttonPushMe_zdy.TabIndex = 0;
            this.buttonPushMe_zdy.Text = "Нажми на меня";
            this.buttonPushMe_zdy.UseVisualStyleBackColor = true;
            this.buttonPushMe_zdy.Click += new System.EventHandler(this.buttonPushMe_zdy_Click);
            // 
            // groupBoxInputData
            // 
            this.groupBoxInputData.Controls.Add(this.radioButtonDiv);
            this.groupBoxInputData.Controls.Add(this.radioButtonMult);
            this.groupBoxInputData.Controls.Add(this.radioButtonMinus);
            this.groupBoxInputData.Controls.Add(this.radioButtonPlus);
            this.groupBoxInputData.Controls.Add(this.labelVarB);
            this.groupBoxInputData.Controls.Add(this.labelVarA);
            this.groupBoxInputData.Controls.Add(this.textBoxVarB);
            this.groupBoxInputData.Controls.Add(this.textBoxVarA);
            this.groupBoxInputData.Location = new System.Drawing.Point(23, 23);
            this.groupBoxInputData.Name = "groupBoxInputData";
            this.groupBoxInputData.Size = new System.Drawing.Size(261, 121);
            this.groupBoxInputData.TabIndex = 1;
            this.groupBoxInputData.TabStop = false;
            this.groupBoxInputData.Text = "Ввод данных";
            // 
            // textBoxVarA
            // 
            this.textBoxVarA.Location = new System.Drawing.Point(12, 37);
            this.textBoxVarA.Name = "textBoxVarA";
            this.textBoxVarA.Size = new System.Drawing.Size(100, 20);
            this.textBoxVarA.TabIndex = 0;
            this.textBoxVarA.TextChanged += new System.EventHandler(this.textBoxVarA_TextChanged);
            // 
            // textBoxVarB
            // 
            this.textBoxVarB.Location = new System.Drawing.Point(12, 79);
            this.textBoxVarB.Name = "textBoxVarB";
            this.textBoxVarB.Size = new System.Drawing.Size(100, 20);
            this.textBoxVarB.TabIndex = 0;
            // 
            // groupBoxOutPutData
            // 
            this.groupBoxOutPutData.Controls.Add(this.labelResult);
            this.groupBoxOutPutData.Controls.Add(this.textBoxresult);
            this.groupBoxOutPutData.Location = new System.Drawing.Point(23, 165);
            this.groupBoxOutPutData.Name = "groupBoxOutPutData";
            this.groupBoxOutPutData.Size = new System.Drawing.Size(150, 71);
            this.groupBoxOutPutData.TabIndex = 2;
            this.groupBoxOutPutData.TabStop = false;
            this.groupBoxOutPutData.Text = "Вывод";
            // 
            // textBoxresult
            // 
            this.textBoxresult.Location = new System.Drawing.Point(12, 36);
            this.textBoxresult.Name = "textBoxresult";
            this.textBoxresult.ReadOnly = true;
            this.textBoxresult.Size = new System.Drawing.Size(122, 20);
            this.textBoxresult.TabIndex = 0;
            // 
            // labelVarA
            // 
            this.labelVarA.AutoSize = true;
            this.labelVarA.Location = new System.Drawing.Point(9, 16);
            this.labelVarA.Name = "labelVarA";
            this.labelVarA.Size = new System.Drawing.Size(17, 13);
            this.labelVarA.TabIndex = 1;
            this.labelVarA.Text = "A:";
            // 
            // labelVarB
            // 
            this.labelVarB.AutoSize = true;
            this.labelVarB.Location = new System.Drawing.Point(9, 63);
            this.labelVarB.Name = "labelVarB";
            this.labelVarB.Size = new System.Drawing.Size(17, 13);
            this.labelVarB.TabIndex = 1;
            this.labelVarB.Text = "B:";
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(9, 20);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(62, 13);
            this.labelResult.TabIndex = 1;
            this.labelResult.Text = "Результат:";
            // 
            // buttonDone
            // 
            this.buttonDone.Location = new System.Drawing.Point(179, 190);
            this.buttonDone.Name = "buttonDone";
            this.buttonDone.Size = new System.Drawing.Size(96, 23);
            this.buttonDone.TabIndex = 3;
            this.buttonDone.Text = "Выполнить";
            this.buttonDone.UseVisualStyleBackColor = true;
            this.buttonDone.Click += new System.EventHandler(this.buttonDone_Click);
            // 
            // radioButtonPlus
            // 
            this.radioButtonPlus.AutoSize = true;
            this.radioButtonPlus.Location = new System.Drawing.Point(141, 40);
            this.radioButtonPlus.Name = "radioButtonPlus";
            this.radioButtonPlus.Size = new System.Drawing.Size(31, 17);
            this.radioButtonPlus.TabIndex = 2;
            this.radioButtonPlus.TabStop = true;
            this.radioButtonPlus.Text = "+";
            this.radioButtonPlus.UseVisualStyleBackColor = true;
            // 
            // radioButtonMinus
            // 
            this.radioButtonMinus.AutoSize = true;
            this.radioButtonMinus.Location = new System.Drawing.Point(141, 66);
            this.radioButtonMinus.Name = "radioButtonMinus";
            this.radioButtonMinus.Size = new System.Drawing.Size(28, 17);
            this.radioButtonMinus.TabIndex = 2;
            this.radioButtonMinus.TabStop = true;
            this.radioButtonMinus.Text = "-";
            this.radioButtonMinus.UseVisualStyleBackColor = true;
            // 
            // radioButtonMult
            // 
            this.radioButtonMult.AutoSize = true;
            this.radioButtonMult.Location = new System.Drawing.Point(192, 40);
            this.radioButtonMult.Name = "radioButtonMult";
            this.radioButtonMult.Size = new System.Drawing.Size(29, 17);
            this.radioButtonMult.TabIndex = 2;
            this.radioButtonMult.TabStop = true;
            this.radioButtonMult.Text = "*";
            this.radioButtonMult.UseVisualStyleBackColor = true;
            // 
            // radioButtonDiv
            // 
            this.radioButtonDiv.AutoSize = true;
            this.radioButtonDiv.Location = new System.Drawing.Point(192, 66);
            this.radioButtonDiv.Name = "radioButtonDiv";
            this.radioButtonDiv.Size = new System.Drawing.Size(30, 17);
            this.radioButtonDiv.TabIndex = 2;
            this.radioButtonDiv.TabStop = true;
            this.radioButtonDiv.Text = "/";
            this.radioButtonDiv.UseVisualStyleBackColor = true;
            // 
            // panelRight
            // 
            this.panelRight.BackColor = System.Drawing.Color.Lime;
            this.panelRight.Controls.Add(this.buttonPanel);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRight.Location = new System.Drawing.Point(617, 0);
            this.panelRight.MinimumSize = new System.Drawing.Size(100, 100);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(124, 455);
            this.panelRight.TabIndex = 4;
            // 
            // buttonPanel
            // 
            this.buttonPanel.Location = new System.Drawing.Point(25, 24);
            this.buttonPanel.Name = "buttonPanel";
            this.buttonPanel.Size = new System.Drawing.Size(75, 23);
            this.buttonPanel.TabIndex = 0;
            this.buttonPanel.Text = "кнопка";
            this.buttonPanel.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 455);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.buttonDone);
            this.Controls.Add(this.groupBoxOutPutData);
            this.Controls.Add(this.groupBoxInputData);
            this.Controls.Add(this.buttonPushMe_zdy);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Май фёрст апп под винду";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxInputData.ResumeLayout(false);
            this.groupBoxInputData.PerformLayout();
            this.groupBoxOutPutData.ResumeLayout(false);
            this.groupBoxOutPutData.PerformLayout();
            this.panelRight.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonPushMe_zdy;
        private System.Windows.Forms.GroupBox groupBoxInputData;
        private System.Windows.Forms.TextBox textBoxVarB;
        private System.Windows.Forms.TextBox textBoxVarA;
        private System.Windows.Forms.GroupBox groupBoxOutPutData;
        private System.Windows.Forms.TextBox textBoxresult;
        private System.Windows.Forms.Label labelVarB;
        private System.Windows.Forms.Label labelVarA;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Button buttonDone;
        private System.Windows.Forms.RadioButton radioButtonDiv;
        private System.Windows.Forms.RadioButton radioButtonMult;
        private System.Windows.Forms.RadioButton radioButtonMinus;
        private System.Windows.Forms.RadioButton radioButtonPlus;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Button buttonPanel;
    }
}

