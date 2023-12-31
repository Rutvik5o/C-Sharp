using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace University3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt16(e.KeyChar) == 8)
                return;

            if (e.KeyChar == '.' && textBox1.Text.IndexOf(".") >= 0)

                e.Handled = true;

            if (!Char.IsDigit(e.KeyChar) && !(e.KeyChar == '.'))

                e.Handled = true;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            float f, c;

            if(radioButton1.Checked == true)
            {
                f = Convert.ToSingle(textBox1.Text);

                c = (5 * (f - 32)) / 9;

                MessageBox.Show(Convert.ToString(f) + "  Fahreneheit => " + Convert.ToString(c) +  " Celsius ");
            }

            else
            {

                c = Convert.ToSingle(textBox1.Text);

                f = ((9 * c) / 5) - 32;

                MessageBox.Show(Convert.ToString(c) + " Celsius =>  " + Convert.ToString(f) + " Fahrenheit ");
            }
        }
    }
}
