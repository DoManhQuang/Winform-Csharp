using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using BTL_WinForm_Ailatrieuphu.Nguoi_Choi;
using BTL_WinForm_Ailatrieuphu.Giao_Dien_Choi_Game;
using BTL_WinForm_Ailatrieuphu.Giao_Dien_Vao_Form;
using BTL_WinForm_Ailatrieuphu.Nguoi_Choi;
using LichSuChoi;

namespace BTL_WinForm_Ailatrieuphu.Nguoi_Choi
{
    public partial class GiaoDienNguoiChoi : Form
    {
        private String taiKhoan;
        public GiaoDienNguoiChoi()
        {
            InitializeComponent();
        }
        public GiaoDienNguoiChoi(string taiKhoanDN)
        {
            InitializeComponent();
            this.taiKhoan = taiKhoanDN;
        }
        public String getTaiKhoanDN()
        {
            return taiKhoan;
        }
        private void btnThongtin_Click(object sender, EventArgs e)
        {
            ThongTinCaNhan TTCN = new ThongTinCaNhan(getTaiKhoanDN());
            this.Hide();
            TTCN.ShowDialog();
            this.Close();
        }

        private void btnBatDau_Click(object sender, EventArgs e)
        {
            GameAiLaTrieuPhu game = new GameAiLaTrieuPhu(getTaiKhoanDN());
            this.Hide();
            game.ShowDialog();
            this.Close();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            FormDangNhap dangNhap = new FormDangNhap();
            this.Hide();
            dangNhap.ShowDialog();
            this.Close();
        }

        private void btnXepHang_Click(object sender, EventArgs e)
        {
            XepHangNguoiChoi xepHang = new XepHangNguoiChoi();
            xepHang.ShowDialog();
        }
    }
}
