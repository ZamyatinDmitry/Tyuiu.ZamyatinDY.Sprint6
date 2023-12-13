using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.ZamyatinDY.Sprint6.Task2.V0.Lib;
namespace Tyuiu.ZamyatinDY.Sprint6.Task2.V0
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
                int startStep = Convert.ToInt32(textBoxStart_ZDY.Text);
                int stopStep = Convert.ToInt32(textBoxStop_ZDY.Text);

                int len = ds.GetMassFunction(startStep, stopStep).Length;
                double[] valueArray;
                valueArray = new double[len];
                valueArray = ds.GetMassFunction(startStep, stopStep);

                this.chartFunction.Titles.Add("График функции sin(x)");
                this.chartFunction.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunction.ChartAreas[0].AxisY.Title = "Ось Y";

                for (int i = 0; i <= len - 1; i++)
                {
                    this.dataGridViewFunction.Rows.Add(Convert.ToString(startStep), Convert.ToString(stopStep));
                    this.chartFunction.Series[0].Points.AddXY(startStep, valueArray[i]);

                    startStep++;
                }
            }
            
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDone_ZDY_MouseEnter(object sender, EventArgs e)
        {
            buttonDone_ZDY.BackColor = Color.Red;
        }

        private void buttonDone_ZDY_MouseLeave(object sender, EventArgs e)
        {
            buttonDone_ZDY.BackColor = Color.Green;
        }

        private void buttonDone_ZDY_MouseDown(object sender, MouseEventArgs e)
        {
            buttonDone_ZDY.BackColor = Color.Blue;
        }
    }
}
