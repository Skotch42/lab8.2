using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random generator = new Random();
            int number = generator.Next(1, 100);
            label1.Visible = true;

            int i = 0;
            int[] prob = new int[8];
            prob[0] = 15;
            prob[1] = 12;
            prob[2] = 8;
            prob[3] = 17;
            prob[4] = 4;
            prob[5] = 11;
            prob[6] = 16;
            prob[7] = 17;

            if (textBox1.Text.Length == 0)
            {
                label1.ForeColor = Color.Black;
                label1.Text = "Сначала введите вопрос!";
            }
            else
            {
                do
                {
                    number -= prob[i];
                    i++;
                } while (number > 0);

                switch (i)
                {
                    case 1:
                        label1.ForeColor = Color.Blue;
                        label1.Text = "Никаких сомнений!";
                        break;
                    case 2:
                        label1.ForeColor = Color.Blue;
                        label1.Text = "Определённо да!";
                        break;
                    case 3:
                        label1.ForeColor = Color.Green;
                        label1.Text = "Мне кажется — «да»!";
                        break;
                    case 4:
                        label1.ForeColor = Color.Green;
                        label1.Text = "Вероятнее всего!";
                        break;
                    case 5:
                        label1.ForeColor = Color.Orange;
                        label1.Text = "Спроси позже!";
                        break;
                    case 6:
                        label1.ForeColor = Color.Orange;
                        label1.Text = "Пока не ясно, попробуй снова!";
                        break;
                    case 7:
                        label1.ForeColor = Color.IndianRed;
                        label1.Text = "Мой ответ — «нет»!";
                        break;
                    case 8:
                        label1.ForeColor = Color.IndianRed;
                        label1.Text = "Даже не думай!";
                        break;
                }
            }


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
