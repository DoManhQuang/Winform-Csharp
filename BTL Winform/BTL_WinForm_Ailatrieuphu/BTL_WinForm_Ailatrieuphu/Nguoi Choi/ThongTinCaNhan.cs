using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using BTL_WinForm_Ailatrieuphu.Mo_Hinh_3_Layer;
using BTL_WinForm_Ailatrieuphu.Giao_Dien_Vao_Form;
using BTL_WinForm_Ailatrieuphu.Class;
namespace BTL_WinForm_Ailatrieuphu.Nguoi_Choi
{
    public partial class ThongTinCaNhan : Form
    {
        private String taiKhoan;
        public static String HovaTen;
        public static String tienThuong;
        public ThongTinCaNhan()
        {
            InitializeComponent();
        }
        public ThongTinCaNhan(string taiKhoanDN)
        {
            InitializeComponent();
            this.taiKhoan = taiKhoanDN;
        }
        public void setTaiKhoanDN(string taikhoanCN)
        {
            this.taiKhoan = taikhoanCN;
        }
        public String getTaiKhoanDN()
        {
            return taiKhoan;
        }
        BLLayer02 layer02 = new BLLayer02();
        SecurityMD5 MD5 = new SecurityMD5();
        private void btnCapNhap_Click(object sender, EventArgs e)
        {
            try
            {
                string MaTK = layer02.LayMaTaiKhoan(getTaiKhoanDN());
                int gioiTinh = 0;
                if (rdNam.Checked)
                {
                    gioiTinh = 1;
                }

                if ( txtMatkhau.Text.Trim() == "" )
                {
                    throw new NullAccount();
                }
                if(txtHovaTen.Text.Trim() == "")
                {
                    throw new NameNull();
                }
                if (!Int32.TryParse(txtSDT.Text.Trim(), out int result) && txtSDT.Text.Trim() != "")
                {
                    throw new FormatException();
                }
                if(MaTK == null)
                {
                    throw new NULLException();
                }
                if (!layer02.Kiemtratentaikhoan(txtTaikhoan.Text.Trim()))
                {
                    throw new ErrorAccount();
                }
                if (txtTaikhoan.Text.Trim() == "")
                {
                    layer02.CapNhapThongTinNguoiChoi(MaTK, getTaiKhoanDN(), txtMatkhau.Text.Trim(), txtHovaTen.Text.Trim()
                        , gioiTinh, txtSDT.Text.Trim(), txtEmail.Text.Trim());
                    MessageBox.Show("Cập nhập thành công.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ThongTinCaNhan_Load(sender, e);
                }
                else
                {
                    layer02.CapNhapThongTinNguoiChoi(MaTK, txtTaikhoan.Text.Trim(), txtMatkhau.Text.Trim(), txtHovaTen.Text.Trim()
                        , gioiTinh, txtSDT.Text.Trim(), txtEmail.Text.Trim());
                    MessageBox.Show("Cập nhập thành công.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    setTaiKhoanDN(txtTaikhoan.Text.Trim());
                    ThongTinCaNhan_Load(sender, e);
                }
            }
            catch(NULLException)
            {
                MessageBox.Show("Không có dữ liệu mã tài khoản.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

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
                ThongTinCaNhan_Load(sender, e);
            }
            catch (FormatException)
            {
                MessageBox.Show("Dữ liệu nhập chưa đúng.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ThongTinCaNhan_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                ThongTinCaNhan_Load(sender, e);
            }
        }

        private void ThongTinCaNhan_Load(object sender, EventArgs e)
        {
            dgvThongTinNguoiChoi.DataSource = layer02.LayThongTinNguoiChuoi(getTaiKhoanDN());
            txtEmail.Clear();
            txtHovaTen.Clear();
            txtMatkhau.Clear();
            txtSDT.Clear();
            txtTaikhoan.Clear();
        }

        private void dgvThongTinNguoiChoi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow viewRow = dgvThongTinNguoiChoi.Rows[e.RowIndex];
                if (viewRow != null)
                {
                    //e.ColumnIndex // chọn cột nào 
                    txtTaikhoan.Text = viewRow.Cells[0].Value.ToString();
                    txtMatkhau.Text = viewRow.Cells[1].Value.ToString();
                    txtHovaTen.Text = viewRow.Cells[2].Value.ToString();
                    HovaTen = viewRow.Cells[2].Value.ToString();
                    if (Convert.ToBoolean(viewRow.Cells[3].Value) == true) // kiểm tra giới tính
                    {
                        rdNam.Checked = true;
                    }
                    else
                    {
                        rdNu.Checked = true;
                    }
                    txtSDT.Text = viewRow.Cells[4].Value.ToString();
                    txtEmail.Text = viewRow.Cells[5].Value.ToString();
                }
            }
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            GiaoDienNguoiChoi giaoDien = new GiaoDienNguoiChoi();
            this.Hide();
            giaoDien.ShowDialog();
            this.Close();
        }
    }
}
