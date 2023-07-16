using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculation
{
    public partial class Form1 : Form
    {
        public string action;
        public string number1;
        public bool number2;
        public Form1()
        {
            number2 = false;
            InitializeComponent();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            double given, reresult;

            given = Convert.ToDouble(textBox1.Text);
            result = -given;
            textBox1.Text = result.ToString();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (number2)
            {
                number2 = false;
                textBox1.Text = "0";
            }
            Button B = (Button)sender;
            if(textBox1.Text=="0")
                textBox1.Text = B.Text;
            else
                textBox1.Text = textBox1.Text + B.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            Button B = (Button)sender;
            action = B.Text;
            number1 = textBox1.Text;
            number2 = true;
        }

        private void button24_Click(object sender, EventArgs e)
        {
            double given1, given2, result;
            result = 0;
            given1 = Convert.ToDouble(N1);
            given2 = Convert.ToDouble(textBox1.Text);
            if (action == "+")
            {
                result = given1 + given2;
            }
            if (action == "-")
            {
                result = given1 - given2;
            }
            if (action == "X")
            {
                result = given1 * given2;
            }
            if (action == "/")
            {
                result = given1 / given2;
            }
            if (action == "%")
            {
                result = given1 * given2 / 100;
            }
            action = "=";
            number2 = true;
            textBox1.Text = result.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double given, result;

            given = Convert.ToDouble(textBox1.Text);
            result = Math.Sqrt(given);
            textBox1.Text = result.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double given, result;

            given = Convert.ToDouble(textBox1.Text);
            result = Math.Pow(given, 2);
            textBox1.Text = result.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double given, result;

            given = Convert.ToDouble(textBox1.Text);
            result = 1/ given;
            textBox1.Text = result.ToString();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if(!textBox1.Text.Contains(","))
                textBox1.Text = textBox1.Text + ",";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text=textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            if (textBox1.Text == "")
                textBox1.Text = "0";
        }
    }
}
