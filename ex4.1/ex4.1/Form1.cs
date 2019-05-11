using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex4._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);
            double x = Convert.ToDouble(textBox3.Text);
            double y = 0;

            textBox4.Text = "Результат выполнения программы ст. Чистякова Дмитрия" + Environment.NewLine;
            textBox4.Text += "При a = " + a.ToString() + Environment.NewLine;
            textBox4.Text += "При b = " + b.ToString() + Environment.NewLine;
            textBox4.Text += "При x = " + x.ToString() + Environment.NewLine;
            textBox4.Text += "Результат:" + Environment.NewLine;

            if (radioButton1.Checked)
            {
                y = Math.Pow(10, -2) * Math.Pow(x, 3) * Math.Sin(a - b);
                textBox4.Text += "y = " + y.ToString() + Environment.NewLine;
            }
            else if (radioButton2.Checked)
            {
                y = Math.Pow(x, 4) + Math.Cos(2 + Math.Pow(x, 3) - b);
                textBox4.Text += "y = " + y.ToString() + Environment.NewLine;
            }
            else if (radioButton3.Checked)
            {
                y = a * (x * x + 12 * Math.Sqrt(x * x + b * b * b));
                textBox4.Text += "y = " + y.ToString() + Environment.NewLine;
            }
            else textBox4.Text += "Не выбрана формула" + Environment.NewLine;

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Лабораторная работа Чистякова Дмитрий ИАС-18-2";
        }
    }
}
