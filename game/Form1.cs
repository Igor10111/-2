using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace game
{
    public partial class Form1 : Form
    {
        private int a;
        private int v = 0;
        private int k;


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            a = random.Next(1,101);
            
           
    }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

           
            if (int.TryParse(textBox1.Text, out k))
                {
                v++;
                if (k > a)
                {

                    label1.Text = "Перелет";

                }
                else if (k < a)
                {

                    label1.Text = "Недолет";
                }
                else
                {
                    label1.Text = "Угадал";
                }


            }
             else
            {
                // Сообщение, если введённое значение не является числом
                label1.Text = "Введите корректное число!";
            }

            // Очищаем поле ввода для следующей попытки
            textBox1.Clear();
            textBox1.Focus();

            textBox2.Text = Convert.ToString(v);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
