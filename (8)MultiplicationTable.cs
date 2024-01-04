using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace University8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i, sum;

            sum = Convert.ToInt16(numericUpDown1.Value);

            for(i=0;i<=20;i++)
            {
                listBox1.Items.Add(sum + " * " + i + " = " + sum * i);
            }

        }
    }
}
