using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCalculator
{
    public partial class Form1 : Form
    {
        public static double first;
        public static double second;
        public static char action;
        NumberFormatInfo nfi = NumberFormatInfo.CurrentInfo;

        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Opacity = this.Opacity + 0.1;
            textBox1.Text += "7";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text += ",";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Length > 0)
            textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                double num = Convert.ToDouble(textBox1.Text);
                textBox1.Text = Convert.ToString(num * (-1));
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            first = Convert.ToDouble(textBox1.Text);
            action = '/';
            textBox1.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            first = Convert.ToDouble(textBox1.Text);
            action = '*';
            textBox1.Text = "";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            first = Convert.ToDouble(textBox1.Text);
            action = '-';
            textBox1.Text = "";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            first = Convert.ToDouble(textBox1.Text);
            action = '+';
            textBox1.Text = "";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "")
            {
                second = Convert.ToDouble(textBox1.Text);
                switch (action)
                {
                    case '/':
                        textBox1.Text = Convert.ToString(first / second);
                        break;
                    case '*':
                        textBox1.Text = Convert.ToString(first * second);
                        break;
                    case '-':
                        textBox1.Text = Convert.ToString(first - second);
                        break;
                    case '+':
                        textBox1.Text = Convert.ToString(first + second);
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
