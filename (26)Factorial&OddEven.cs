using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace University26
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
            int result;

            result = fact(Convert.ToInt16(textBox1.Text));

            MessageBox.Show("Factorial Of " + textBox1.Text + " is " + Convert.ToString(result));
        }

        public int fact(int num)
        {
            int ans, i;

            ans = 1;

            for (i = 1; i <= num; i++)
                ans = ans * i;

            return ans;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            chkoddeven(Convert.ToInt16(textBox2.Text));
        }

        public void chkoddeven(int num)
        {
            if (num % 2 == 0)
                MessageBox.Show(Convert.ToString(num) + " is the Even Number");
            else
                MessageBox.Show(Convert.ToString(num) + " is the ODD Number ");
        }
    }
}
