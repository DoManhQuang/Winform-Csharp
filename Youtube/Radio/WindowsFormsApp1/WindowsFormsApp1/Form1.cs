using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGioitinh_Click(object sender, EventArgs e)
        {
            if(rdNam.Checked == true)
            {
                txtGioiTinh.Text = "Giới tính của tôi là Nam";
            }
            if (rdNu.Checked == true)
            {
                txtGioiTinh.Text = "Giới tính của tôi là Nữ";
            }
            if (rdGTT3.Checked == true)
            {
                txtGioiTinh.Text = "Giới tính của tôi là linh hoạt";
            }
        }
    }
}
