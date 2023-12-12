using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.ZamyatinDY.Sprint6.Task0.Lib;
namespace Tyuiu.ZamyatinDY.Sprint6.Task0
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonDone_ZDY_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                textBoxResult_ZDY.Text = Convert.ToString(ds.Calculate(2));
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonQuest_ZDY_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Такс 0 выполнил студент группы ИИПб-23-3 Замятин Дмитрий Юрьевич", "Сообщение");
        }
    }
}
