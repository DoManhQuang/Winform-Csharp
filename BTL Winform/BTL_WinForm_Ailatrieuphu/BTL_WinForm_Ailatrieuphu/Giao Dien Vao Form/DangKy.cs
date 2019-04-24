using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using BTL_WinForm_Ailatrieuphu.Mo_Hinh_3_Layer;
using BTL_WinForm_Ailatrieuphu.Class;
using BTL_WinForm_Ailatrieuphu.Nguoi_Choi;

namespace BTL_WinForm_Ailatrieuphu.Giao_Dien_Vao_Form
{
    public partial class DangKy : Form
    {
        public DangKy()
        {
            InitializeComponent();
        }

        BLLayer02 Layer02 = new BLLayer02();
        SecurityMD5 MD5 = new SecurityMD5();

        private void btnDangky_Click(object sender, EventArgs e)
        {
            try
            {
                String MatkhauMD5 = MD5.getMd5Hash(txtMatkhau.Text.Trim());
                int gioiTinh = 0;
                if (rdNam.Checked)
                {
                    gioiTinh = 1;
                }

                if (txtMatkhau.Text.Trim() == "")
                {
                    throw new NullAccount();
                }
                if (txtHovaTen.Text.Trim() == "")
                {
                    throw new NameNull();
                }
                if(Layer02.GetMaTKNew() == null)
                {
                    throw new MaTKNULL();
                }
                if (!Int32.TryParse(txtSDT.Text.Trim(), out int result) && txtSDT.Text.Trim() != "")
                {
                    throw new FormatException();
                }
                if(!Layer02.Kiemtratentaikhoan(txtTaikhoan.Text.Trim()))
                {
                    throw new ErrorAccount();
                }
                if (!Layer02.DangKyTaiKhoanNguoiChoi(Layer02.GetMaTKNew(), txtTaikhoan.Text.Trim(), MatkhauMD5, txtHovaTen.Text.Trim()
                    , gioiTinh, txtSDT.Text.Trim(), txtEmail.Text.Trim(), 0,1))
                {
                    throw new ErrorSignUp();
                }
                MessageBox.Show("Đăng ký tài khoản thành công.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DangKy_Load(sender, e);
            }
            catch (MaTKNULL)
            {
                MessageBox.Show("Không thể tạo mới tài khoản.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (NullAccount)
            {
                MessageBox.Show("Không được bỏ trống thông tin mật khẩu.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (NameNull)
            {
                MessageBox.Show("Không được bỏ trống thông tin Họ và Tên.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (ErrorAccount)
            {
                MessageBox.Show("Đã Tồn Tại Tên Tài Khoản.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (ErrorSignUp)
            {
                MessageBox.Show("Đăng ký thất bại.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DangKy_Load(sender, e);
            }
            catch(FormatException)
            {
                MessageBox.Show("Dữ liệu nhập chưa đúng.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DangKy_Load(sender, e);
            }
            catch(SqlException)
            {
                MessageBox.Show("Đăng ký thất bại.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DangKy_Load(sender, e);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
                DangKy_Load(sender, e);
            }
        }

        private void DangKy_Load(object sender, EventArgs e)
        {
            txtEmail.Clear();
            txtHovaTen.Clear();
            txtMatkhau.Clear();
            txtSDT.Clear();
            txtTaikhoan.Clear();
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            FormDangNhap dangNhap = new FormDangNhap();
            this.Hide();
            dangNhap.ShowDialog();
            this.Close();
        }
    }
}
