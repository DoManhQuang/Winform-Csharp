using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using BTL_WinForm_Ailatrieuphu.Nguoi_Choi;

namespace BTL_WinForm_Ailatrieuphu.Giao_Dien_Choi_Game
{
    public partial class GameAiLaTrieuPhu : Form
    {
        private String taiKhoan;
        public GameAiLaTrieuPhu()
        {
            InitializeComponent();
        }
        public GameAiLaTrieuPhu(String TaikhoanDN)
        {
            InitializeComponent();
            this.taiKhoan = TaikhoanDN;
        }
        public String getTaiKhoanDN()
        {
            return taiKhoan;
        }
        private void btnA_Click(object sender, EventArgs e)
        {

        }

        private void btnDauHang_Click(object sender, EventArgs e)
        {
            GiaoDienNguoiChoi giaoDien = new GiaoDienNguoiChoi();
            this.Hide();
            giaoDien.ShowDialog();
            this.Close();
        }
    }
}
