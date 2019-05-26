using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace label
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            lbKetqua.Text = "Kết Quả ";
            if(rdLabel.Checked)
            {
                lbKetqua.Text += " Bạn Trả Lời Đúng !";
            }
            if (rdPictureBox.Checked)
            {
                lbKetqua.Text += " Bạn Trả Lời Sai !";
            }
            if (rdTextbox.Checked)
            {
                lbKetqua.Text += " Bạn Trả Lời Sai !";
            }
            if (rdRadio.Checked)
            {
                lbKetqua.Text += " Bạn Trả Lời Sai !";
            }
        }
    }
}
