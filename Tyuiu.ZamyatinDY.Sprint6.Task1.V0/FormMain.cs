using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.ZamyatinDY.Sprint6.Task1.V0.Lib;
namespace Tyuiu.ZamyatinDY.Sprint6.Task1.V0
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        private void buttonDone_ZDY_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxVarStart_ZDY.Text);
                int stopStep = Convert.ToInt32(textBoxVarStop_ZDY.Text);

                string strLine;
                int len = ds.GetMassFunction(startStep, stopStep).Length;
                double[] valueArray;
                valueArray = new double[len];
                valueArray = ds.GetMassFunction(startStep, stopStep);
                textBoxResule_ZDY.Text = "";
                textBoxResule_ZDY.AppendText("+----------+----------+" + Environment.NewLine);
                textBoxResule_ZDY.AppendText("|     X    |   f(x)   |" + Environment.NewLine);
                textBoxResule_ZDY.AppendText("+----------+----------+" + Environment.NewLine);

                for(int  i = 0; i < len - 1;i++)
                {
                    strLine = string.Format("|{0,5:d}    |  {1, 5:f2}   |", startStep, valueArray[i]);
                    textBoxResule_ZDY.AppendText(strLine + Environment.NewLine);
                    startStep++;
                }
                textBoxResule_ZDY.AppendText("+----------+----------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonHelp_zdy_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Такс 1 выполнил студент группы ИИПб-23-3 Замятин Дмитрий Юрьевич", "Сообщение");
        }
    }
}
