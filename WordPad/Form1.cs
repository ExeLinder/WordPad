using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WordPad;

namespace WordPad
{
    public partial class Form1 : Form
    {
        WordPad wordPad;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            wordPad.Save(textBox1.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            wordPad = new WordPad();
        }
    }
}
