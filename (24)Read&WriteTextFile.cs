using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace University24
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.IO.FileStream Obj1 = new System.IO.FileStream("E:\\Visual Studio\\file\\file.txt", System.IO.FileMode.OpenOrCreate);

            System.IO.StreamWriter Obj2 = new System.IO.StreamWriter(Obj1);

            Obj2.Write(textBox1.Text);

            MessageBox.Show("Data is written to the file sucessfully:", "Info:");

            Obj2.Close();

            Obj1.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.IO.FileStream Obj3 = new System.IO.FileStream("E:\\Visual Studio\\file\\file.txt", System.IO.FileMode.OpenOrCreate);

            System.IO.StreamReader Obj4 = new System.IO.StreamReader(Obj3);

            textBox2.Text = Obj4.ReadToEnd();

            Obj4.Close();

            Obj4.Close();
        }
    }
}
