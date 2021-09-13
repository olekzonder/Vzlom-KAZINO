using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Window1 : Form
    {
        int FinalNumber, Counter, Part;
        double Percent, CurrentPercent;
        public Window1()
        {
            InitializeComponent();
            Random random = new Random();
            FinalNumber = random.Next(5000000, 7500000);
            FinalNumber = FinalNumber - FinalNumber % 125;
            Counter = 0;
            Part = FinalNumber / 125;
            progressBar1.Step = Part;
            Percent = (double)Part / FinalNumber;
            CurrentPercent = 0;
            label1.Text = "Казино взломанно на " + CurrentPercent.ToString("0%") + ".";
            label2.Text = "Выкачанно " + Counter.ToString() + " руб. из " + FinalNumber.ToString() + " руб.";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (progressBar1.Value < 125)
            {
                progressBar1.Value++;
                CurrentPercent += Percent;
                Counter += Part;
                label1.Text = "Казино взломанно на " + CurrentPercent.ToString("0%") + ".";
                label2.Text = "Выкачанно " + Counter.ToString() + " руб. из " + FinalNumber.ToString() + " руб.";
                            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
       "всм",
       "чел ты ошибся кнопкой",
       MessageBoxButtons.OK,
       MessageBoxIcon.Error,
       MessageBoxDefaultButton.Button1,
       MessageBoxOptions.DefaultDesktopOnly);
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
