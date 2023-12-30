using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace University2
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

        private void button1_Click(object sender, EventArgs e)
        {
            Double amt, InsAmt, Roint;

            amt = Convert.ToSingle(textBox2.Text);

            Roint = Convert.ToSingle(textBox3.Text);


            Int16 nper;

            nper = Convert.ToInt16(textBox2.Text);

            if (checkBox1.Checked == true)
            {
                InsAmt = Financial.Pmt(Roint / (12 * 100), nper, amt, 0, DueDate.BegOfPeriod);


            }

            else
                InsAmt = Financial.Pmt(Roint / (12 * 100), nper, amt, 0, DueDate.EndOfPeriod);

            textBox4.Text = Convert.ToString(InsAmt);
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

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt16(e.KeyChar) == 8)
                return;
            if(!Char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("Invalid Input");
                e.Handled = true;
            }
        }
    }
}
