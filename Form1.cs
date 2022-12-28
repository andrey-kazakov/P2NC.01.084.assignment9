using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment9_AndreiKazakov
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dictionary<char, int> counts = new Dictionary<char, int>();

            char result = ' ';
            int count = 0;

            foreach (char c in textBox1.Text)
            {
                counts[c] = counts.ContainsKey(c) ? (counts[c] + 1) : 1;

                if (counts[c] >= count)
                {
                    result = c;
                    count = counts[c];
                }
            }

            MessageBox.Show(
                $"The most repeated character is '{result}' ({count} repetitions)",
                "Result"
            );
        }
    }
}
