using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            string text = txtTextBox1.Text;
            MessageBox.Show(text, "Thông Báo");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtTextBox1.Clear();
        }
    }
}
