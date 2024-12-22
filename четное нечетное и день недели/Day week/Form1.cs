using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day_week
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            int N = Convert.ToInt32(comboBox1.Text);
            string day = "";
            switch (N)
            {
                case 1:
                    day = "Понедельник ";
                    break;
                case 2:
                    day = "Вторник ";
                    break;
                case 3:
                    day = "Среда";
                    break;
                case 4:
                    day = "Четверг";
                    break;
                case 5:
                    day = "Пятница";
                    break;
                case 6:
                    day = "Суббота";
                    break;
                case 7:
                    day = "Воскресенье ";
                    break;

                default:
                    break;
            }
            label2.Text = day;
        }
    }
}
