using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.ZamyatinDY.Sprint6.Task5.V0.Lib;
using System.IO;
namespace Tyuiu.ZamyatinDY.Sprint6.Task6.V0
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        string path = @"C:\InPutFileTask5V1.txt";
        private void buttonDone_ZDY_Click(object sender, EventArgs e)
        {
            dataGridViewNums_ZDY.ColumnCount = 2;
            dataGridViewNums_ZDY.Columns[0].Width = 20;
            dataGridViewNums_ZDY.Columns[1].Width = 50;

            this.chartFunction_ZDY.ChartAreas[0].AxisX.Title = "Ось X";
            this.chartFunction_ZDY.ChartAreas[0].AxisY.Title = "Ось Y";

            chartFunction_ZDY.Series[0].Points.Clear();

            double[] numsMass = new double[ds.len];
            numsMass = ds.LoadFromDataFile(path);

            for (int i = 0; i < numsMass.Length; i++)
            {
                dataGridViewNums_ZDY.Rows.Add(Convert.ToString(i), Convert.ToString(numsMass[i]));
                chartFunction_ZDY.Series[0].Points.AddXY(i, numsMass[i]);
            }
        }

        private void buttonOpenFile_ZDY_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        private void buttonHelp_ZDY_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Такс 5 выполнил студент группы ИИПб-23-3 Замятин Дмитрий Юрьевич", "Сообщение");
        }
    }
}
