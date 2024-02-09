using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace First11111
{
    public partial class Form1 : Form
    {
        Boolean cleardisplay;

        String op;

        float operand;

        public Form1()
        {
            InitializeComponent();
        }

        private void operator_Click(object sender, EventArgs e)
        {
            if(op!="")
            {
                equal_Click(sender, e);
                op = "";
            }

            op = ((Button)sender).Text;

            operand = Convert.ToSingle(textBox1.Text);

            cleardisplay = true;
        }

        private void operand_Click(object sender, EventArgs e)
        {
            if (((Button)sender).Text == "." && textBox1.Text.IndexOf(".") >= 0)
                return;

            if(cleardisplay==true)
            {
                textBox1.Clear();
                cleardisplay = false;
            }

            textBox1.Text = textBox1.Text + ((Button)sender).Text;

                
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            cleardisplay = false;

            textBox1.Clear();

            op = "";

            operand = 0;
        }

        private void equal_Click(object sender, EventArgs e)
        {
            if (op == "+")
                textBox1.Text = Convert.ToString(operand + Convert.ToSingle(textBox1.Text));

            if (op == "-")
                textBox1.Text = Convert.ToString(operand - Convert.ToSingle(textBox1.Text));

            if (op == "*")
                textBox1.Text = Convert.ToString(operand * Convert.ToSingle(textBox1.Text));

            if (op == "/")
                textBox1.Text = Convert.ToString(operand / Convert.ToSingle(textBox1.Text));
        }
    }
}
