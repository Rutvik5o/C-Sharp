using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace University27
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

        private void form1ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void form2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 Obj1 = new Form2();
            Obj1.MdiParent = this;
            Obj1.Show();
        }

        private void form3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 Obj2 = new Form3();
            Obj2.MdiParent = this;
            Obj2.Show();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Obj1 = this.ActiveMdiChild;
            Obj1.Close(); //Close the active MDI chilld form
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void tileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void tileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void arrangeAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }
    }
}
