using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace University7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedIndex>=0)
            {
                listBox2.Items.Add(listBox1.SelectedItem);

                listBox1.Items.Remove(listBox1.SelectedItem);
            }

            else

            {
                MessageBox.Show("Select any one item in the listBox1 and then click in this Button");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add("one");
            listBox1.Items.Add("two");
            listBox1.Items.Add("three");
            listBox1.Items.Add("four");
            listBox1.Items.Add("five");
            listBox1.Items.Add("six");
            listBox1.Items.Add("seven");
            listBox1.Items.Add("eight");
            listBox1.Items.Add("nine");
            listBox1.Items.Add("one");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i, n;

            n = listBox1.SelectedItems.Count;

            for(i=0;i<n;i++)
            {
                listBox2.Items.Add(listBox1.SelectedItems[0]);
                listBox1.Items.Remove(listBox1.SelectedItems[0]);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int i, n;

            n = listBox1.Items.Count;

            for (i = 0; i < n; i++)
            {
                listBox2.Items.Add(listBox1.Items[0]);
                listBox1.Items.Remove(listBox1.Items[0]);
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex >= 0)
            {
                listBox1.Items.Add(listBox2.SelectedItem);

                listBox2.Items.Remove(listBox2.SelectedItem);
            }

            else
                MessageBox.Show("Select any one item in the listBox2 and then click in this Button");
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int i, n;

            n = listBox2.SelectedItems.Count;

            for (i = 0; i < n; i++)
            {
                listBox1.Items.Add(listBox2.SelectedItems[0]);
                listBox2.Items.Remove(listBox2.SelectedItems[0]);
            }


        }

        private void button6_Click(object sender, EventArgs e)
        {
            int i, n;

            n = listBox2.Items.Count;

            for (i = 0; i < n; i++)
            {
                listBox1.Items.Add(listBox2.Items[0]);
                listBox2.Items.Remove(listBox2.Items[0]);
            }
        }
    }
}
