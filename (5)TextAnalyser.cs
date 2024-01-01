using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace University5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int vowels = 0;
            int spaces = 0;
            int digit = 0;
            int spsymbols = 0;
            int consonant = 0;

            for(int i=0;i< textBox1.Text.Length;i++)
            {
                char ch = Char.ToLower(textBox1.Text[i]);

                if (Char.IsDigit(ch))
                    digit++;

                else if (ch == ' ')
                    spaces++;

                else if (!Char.IsLetterOrDigit(ch))
                    spsymbols++;

                else if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == ' ')
                    vowels++;

                else
                    consonant++;

            }

            String str = ("There are ->" + "\nVowels=> " + vowels + "\nDigits=> " + digit + "\nSpaces=> " + spaces + "\nSpecial Symbols=> " + spsymbols + "\nFound on This Text");

            MessageBox.Show(str);

        }
    }
}
