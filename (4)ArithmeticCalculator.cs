using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace University4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Addition");
            comboBox1.Items.Add("Subtraction");
            comboBox1.Items.Add("Multiplication");
            comboBox1.Items.Add("Divison");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Single num1, num2;

            num1 = Convert.ToSingle(textBox1.Text);

            num2 = Convert.ToSingle(textBox2.Text);

            if (comboBox1.Text == "Addition")
                label4.Text = "Result is => " + Convert.ToSingle(num1 + num2);

            else if (comboBox1.Text == "Subtraction")
                label4.Text = "Result is => " + Convert.ToSingle(num1 - num2);

            else if (comboBox1.Text == "Multiplication")
                label4.Text = "Result is => " + Convert.ToSingle(num1 * num2);

            else if (comboBox1.Text == "Divison")
                label4.Text = "Result is => " + Convert.ToSingle(num1 / num2);

            else
                label4.Text = "Select valid Operation ";
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt16(e.KeyChar) == 0)
                return;

            if (e.KeyChar == '.' && textBox1.Text.IndexOf(".") >= 0)
                e.Handled = true;

            if (!Char.IsDigit(e.KeyChar) && !(e.KeyChar == '.'))
                e.Handled = true;

        }
    }
}
