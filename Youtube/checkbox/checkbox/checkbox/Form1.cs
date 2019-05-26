using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace checkbox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                MessageBox.Show("Đây là checkbox 1 nè !", "Thông báo");
            }
            if (checkBox2.Checked)
            {
                MessageBox.Show("Đây là checkbox 2 nè !", "Thông báo");
            }
             if (checkBox3.Checked)
            {
                MessageBox.Show("Đây là checkbox 3 nè !", "Thông báo");
            }
            if (checkBox4.Checked)
            {
                MessageBox.Show("Đây là checkbox 4 nè !", "Thông báo");
            }

        }
    }
}
