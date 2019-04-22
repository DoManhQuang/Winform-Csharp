using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using BTL_WinForm_Ailatrieuphu.Mo_Hinh_3_Layer;
using BTL_WinForm_Ailatrieuphu.Nguoi_Choi;
using BTL_WinForm_Ailatrieuphu.Giao_Dien_Vao_Form;
using System.Data.SqlClient;
using BTL_WinForm_Ailatrieuphu.Class;
namespace BTL_WinForm_Ailatrieuphu
{
    public partial class FormDangNhap : Form
    {
        //using System.Media.SoundPlayer player = new SoundPlayer(@"");

        public FormDangNhap()
        {
            InitializeComponent();
        }
        BLLayer02 layer02 = new BLLayer02();
        SecurityMD5 MD5 = new SecurityMD5();
        private void Form1_Load(object sender, EventArgs e)
        {
            txtMatkhau.Clear();
            txtTaikhoan.Clear();
        }
        public String XuLyTachMaTaiKhoan(String matk)
        {

            return matk;
        }
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            try
            {
                string MatkhauMD5 = MD5.getMd5Hash(txtMatkhau.Text.Trim());
                bool KiemTraDangNhap = layer02.Kiemtradangnhap(txtTaikhoan.Text.Trim(), MatkhauMD5);
                int ChucNang = layer02.ChucNangNguoiDung(txtTaikhoan.Text.Trim(), MatkhauMD5);
                
                if (txtTaikhoan.Text.Trim() == "")
                {
                    throw new Taikhoannull();
                }
                if (txtMatkhau.Text.Trim() == "")
                {
                    throw new Matkhaunull();
                }
                if (!KiemTraDangNhap || ChucNang == 0)
                {
                    throw new LoiDangnhap();
                }
                if (ChucNang == 1)
                {
                    GiaoDienNguoiChoi GDNC = new GiaoDienNguoiChoi(txtTaikhoan.Text.Trim());
                    this.Hide();
                    GDNC.ShowDialog();
                    this.Close();
                }
                else if (ChucNang == 2)
                {

                }
                else if(ChucNang == 3)
                {

                }
            }
            catch(LoiDangnhap)
            {
                MessageBox.Show("Đăng Nhập Thất Bại.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form1_Load(sender, e);
            }
            catch (Taikhoannull)
            {
                MessageBox.Show("Không được để trống tài khoản.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form1_Load(sender, e);
            }
            catch (Matkhaunull)
            {
                MessageBox.Show("Không được để trống mất khẩu.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form1_Load(sender, e);
            }
            catch(SqlException sql)
            {
                MessageBox.Show("Đăng Nhập Thất Bại.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Console.WriteLine(sql.ToString());
                Form1_Load(sender, e);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Đăng Nhập Thất Bại.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Console.WriteLine(ex.ToString());
                Form1_Load(sender, e);
            }
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            DangKy dangKy = new DangKy();
            this.Hide();
            dangKy.ShowDialog();
            this.Close();
        }
    }
}
