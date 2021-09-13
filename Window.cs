using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace WinFormsApp1
{
    public partial class Window1 : Form
    {
        int FinalNumber, Counter, Part, FlagBondage;
        double Percent, CurrentPercent;
        SoundPlayer PlayerNo = new SoundPlayer();
        SoundPlayer PlayerBondage = new SoundPlayer();
        SoundPlayer PlayerFinished = new SoundPlayer();
        
        public Window1()
        {
            InitializeComponent();
            PlayerNo.SoundLocation = "https://olekzonder.s-ul.eu/gGCRdrmI";
            PlayerBondage.SoundLocation = "https://olekzonder.s-ul.eu/mrLTJy4u";
            PlayerFinished.SoundLocation = "https://olekzonder.s-ul.eu/9IGzSEaW";
            Random random = new Random();
            FinalNumber = random.Next(5000000, 7500000);
            FinalNumber = FinalNumber - FinalNumber % 125;
            Counter = 0;
            FlagBondage = 0;
            Part = FinalNumber / 125;
            progressBar1.Step = Part;
            Percent = (double)Part / FinalNumber;
            CurrentPercent = 0;
            label1.Text = "Казино взломанно на " + CurrentPercent.ToString("0%") + ".";
            label2.Text = "Выкачанно " + Counter.ToString() + " руб. из " + FinalNumber.ToString() + " руб.";
            
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (progressBar1.Value < 75)
            {
                progressBar1.Value++;
                CurrentPercent += Percent;
                Counter += Part;
                label1.Text = "Казино взломанно на " + CurrentPercent.ToString("0%") + ".";
                label2.Text = "Выкачанно " + Counter.ToString() + " руб. из " + FinalNumber.ToString() + " руб.";
                            }
            else if (progressBar1.Value < 125)
            {
                if (FlagBondage == 0)
                {
                    try
                    {
                        PlayerBondage.Play();
                    }
                    catch
                    {

                    };
                    FlagBondage = 1;
                }
                progressBar1.Value++;
                CurrentPercent += Percent;
                Counter += Part;
                Window1.ActiveForm.Text = "Взлом BONDAGE GAY WEBSITE";
                label1.Text = "Bondage gay website взломан на " + CurrentPercent.ToString("0%") + ".";
                label2.Text = "Выкачанно " + Counter.ToString() + " bucks из " + FinalNumber.ToString() + " bucks.";
            }
            else
            {
                try
                {
                    PlayerFinished.Play();
                }
                catch
                {

                };
                button1.Enabled = false;
                label1.Text = "Bondage gay website взломан на " + CurrentPercent.ToString("0%") + ".";
                label2.Text = "Все деньги ушли на оплату fisting.";
                label3.Visible = false;
                if (button2.Enabled == true) button2.Enabled=false;
            }
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                PlayerNo.Play();
            }
            catch
            {

            };
            button2.Enabled = false;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
