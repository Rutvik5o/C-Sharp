using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace University233
{
    public partial class Form1 : Form
    {
        int pos;

        public Form1()
        {
            InitializeComponent();
        }

        private void cmdFind_Click(object sender, EventArgs e)

        {

            pos = Editor.Find(textFind.Text, 0, Editor.Text.Length, RichTextBoxFinds.None);

         
            if (pos >= 0)
            {
                Editor.SelectionBackColor = Color.Yellow;
                Editor.Select(pos, textFind.Text.Length);
            }
            else
            {
                MessageBox.Show("The text you are looking for is not Found:", "Error!!");
            }
        }

        private void cmdReplace_Click(object sender, EventArgs e)
        {
            Editor.SelectedText = txtReplace.Text;
        }

        private void cmdFindNext_Click(object sender, EventArgs e)
        {
            if (pos >= 0)
            { 
                pos = Editor.Find(textFind.Text, pos + 1, Editor.Text.Length, RichTextBoxFinds.None);
             
            }
            else
            {
                 MessageBox.Show("The text you are looking for is not Found:", "Error!!");
            }

            if (pos >= 0)
            {
                Editor.SelectionBackColor = Color.Yellow;
                Editor.Select(pos, textFind.Text.Length);
            }
        }

        private void cmdReplaceAll_Click(object sender, EventArgs e)
        {
            pos = 0;

            cmdFind.PerformClick();

            if (pos != -1)
            {
                cmdReplace.PerformClick();

                while (pos != -1)
                {
                    cmdFindNext.PerformClick();

                    if (pos != -1)
                    {
                        cmdReplace.PerformClick();
                    }
                }
            }
        }

        private void Editor_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

