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

namespace tablicaymnojeniya
{
    public partial class Form1 : Form
    {
        private int k = 0;
        private int v = 0;
        private int x = 0;
        public Form1()
        {
            InitializeComponent();
           
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int a = random.Next(1, 9);
            int b = random.Next(1, 9);
            textBox1.Text=Convert.ToString(a);
            textBox2.Text=Convert.ToString(b);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            k++;
            int num1= Convert.ToInt32(textBox1.Text);
            int num2= Convert.ToInt32(textBox2.Text);
            int a; 
            bool isNumeric = int.TryParse(textBox3.Text, out a);
            
            if (isNumeric)
            { int sum = num1 * num2;
                
                if (a == sum)
            {
                    v++;
                   
                    label2.Text = "Верно ";

                }
            else
                {
                    x++;
                    label2.Text = "Неверно";
                }
            }
        
            textBox4.Text=Convert.ToString(k);
            textBox5.Text=Convert.ToString(v);
            textBox6.Text=Convert.ToString(x);
            textBox3.Clear();
            textBox3.Focus();
        }
      
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            label2.Font = new Font("Arial", 16, FontStyle.Bold);
            label2.ForeColor = Color.Red;

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }


        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

       

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
