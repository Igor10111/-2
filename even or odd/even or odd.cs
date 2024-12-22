using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace even_or_odd
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sum = 0, count = 0;
            int p = 0;
            int i = 0;

            //for (int i = 0; i <= 100; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        richTextBox1.Text += i.ToString() + "\n";
            //        sum += i;
            //        count++;
            //        p *= i;
            //    }
            //    textBox1.Text = count.ToString();
            //    textBox2.Text = sum.ToString();
            //}


            //while (i<=100)
            //{
            //    if (i % 2 == 0)
            //    {
            //richTextBox1.Text += i.ToString() + "\n";
            //sum += i;
            //count++;
            //p *= i;
            //textBox1.Text = count.ToString();
            //textBox2.Text = sum.ToString();
            //    }
            //    i++;
            //}
            do
            {

                if (i % 2 == 0)
                {
                    richTextBox1.Text += i.ToString() + "\n";
                    textBox1.Text = count.ToString();
                    textBox2.Text = sum.ToString();
                    
                    sum += i;
                    count++;
                    p *= i;
                }
                i++;
            }
            while (i <=100);
            
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
