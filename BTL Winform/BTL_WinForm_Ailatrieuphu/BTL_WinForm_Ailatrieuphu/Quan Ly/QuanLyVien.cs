using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using BTL_WinForm_Ailatrieuphu.Mo_Hinh_3_Layer.Long;
using BTL_WinForm_Ailatrieuphu.Class;
namespace QuanLyVien
{
    public partial class FormQuanLyVien : Form
    {
        private string MaQLV = null;
        
        public FormQuanLyVien()
        {
            InitializeComponent();
        }
        public FormQuanLyVien(string ma)
        {
            InitializeComponent();
            this.MaQLV = ma;
        }
        public string getMaQLV()
        {
            return MaQLV;
        }
        BLL myBLL = new BLL();
        SecurityMD5 MD5 = new SecurityMD5();
        ClassChuanHoaTen ch = new ClassChuanHoaTen();
        ClassChuanHoaEmail email = new ClassChuanHoaEmail();
        
        private void QuanLyVien_Load(object sender, EventArgs e)
        {
            dgvQuanLy.DataSource = myBLL.ShowKyThuatVien();
            
        }
        Boolean gt;
        Boolean trangThai;
        int chucNang = 2;
        private void btnThem_Click_1(object sender, EventArgs e)
        {
            String maKTV = myBLL.GetMaKTVNew();
            String maTK = myBLL.GetMaTKNew();
            
            try
            {
                try
                {
                    if (txtTaiKhoan.Text.Trim() == "")
                    {
                        MessageBox.Show("Không được để trống tên tài khoản");
                    }
                    else if (txtMatKhau.Text.Trim() == "")
                    {
                        MessageBox.Show("Không được để trống mật khẩu");
                    }
                    else if (txtTenNguoiDung.Text.Trim() == "")
                    {
                        MessageBox.Show("Không được để trống tên người dùng");
                    }
                    else
                    {
                        if (rdbNam.Checked) gt = true;
                        else gt = false;

                        if (rdbKichHoat.Checked) trangThai = true;
                        else trangThai = false;
                        string matkhauMD5 = MD5.getMd5Hash(txtMatKhau.Text.Trim());
                        myBLL.InsertTaiKhoan(maTK, txtTaiKhoan.Text, matkhauMD5, ch.ChuanHoaXau(txtTenNguoiDung.Text), gt, txtSoDT.Text, txtEmail.Text, trangThai, chucNang);
                        QuanLyVien_Load(sender, e);
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Thêm không thành công !! \n" + ex.ToString());
                }
                finally
                {
                    myBLL.InsertKyThuatVien(maKTV, getMaQLV(), maTK, txtVaiTro.Text);
                    QuanLyVien_Load(sender, e);
                }
            }
            catch(SqlException ex)
            {
                MessageBox.Show("Lỗi !! \n" + ex.ToString());
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            //String maKTV = myBLL.GetLayMaKTV();
            try
            {
                try
                {
                    if (txtTaiKhoan.Text.Trim() == "")
                    {
                        MessageBox.Show("Không được để trống tên tài khoản");
                    }
                    else if (txtMatKhau.Text.Trim() == "")
                    {
                        MessageBox.Show("Không được để trống mật khẩu");
                    }
                    else if (txtTenNguoiDung.Text.Trim() == "")
                    {
                        MessageBox.Show("Không được để trống tên người dùng");
                    }
                    else
                    {
                        if (rdbNam.Checked) gt = true;
                        else gt = false;

                        if (rdbKichHoat.Checked) trangThai = true;
                        else trangThai = false;
                        string matkhauMD5 = MD5.getMd5Hash(txtMatKhau.Text.Trim());
                        myBLL.UpdateTaiKhoan(txtTaiKhoan.Text, matkhauMD5, ch.ChuanHoaXau(txtTenNguoiDung.Text), gt, txtSoDT.Text, txtEmail.Text, trangThai,chucNang);
                        myBLL.UpdateKyThuatVien(txtTaiKhoan.Text, txtVaiTro.Text);
                        QuanLyVien_Load(sender, e);
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Sửa không thành công !! \n" + ex.ToString());
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi !! \n" + ex.ToString());
            }
        }
        int viTri;
        private void dgvQuanLy_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            viTri = e.RowIndex;
            if(viTri >= 0)
            {
                txtTaiKhoan.Text = dgvQuanLy.Rows[viTri].Cells[0].Value.ToString();
                //txtMatKhau.Text = dgvQuanLy.Rows[viTri].Cells[1].Value.ToString();
                txtTenNguoiDung.Text = dgvQuanLy.Rows[viTri].Cells[2].Value.ToString();
                if (dgvQuanLy.Rows[viTri].Cells[3].Value.Equals(true))
                    gt = true;
                else
                    gt = true;
                txtSoDT.Text = dgvQuanLy.Rows[viTri].Cells[4].Value.ToString();
                txtEmail.Text = dgvQuanLy.Rows[viTri].Cells[5].Value.ToString();
                if (dgvQuanLy.Rows[viTri].Cells[6].Value.Equals(true))
                    trangThai = true;
                else
                    trangThai = true;
                txtVaiTro.Text = dgvQuanLy.Rows[viTri].Cells[7].Value.ToString();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTaiKhoan.TextLength == 0)
                {
                    MessageBox.Show("Bạn phải chọn 1 record để xóa");
                }
                else
                {
                    myBLL.DeleteTaiKhoan(txtTaiKhoan.Text);
                    QuanLyVien_Load(sender, e);
                }
            }catch(SqlException ex)
            {
                MessageBox.Show("Lỗi!\n" + ex.ToString());
            }
        }

        private void btnTK_Click(object sender, EventArgs e)
        {
            if(txtTimKiem.TextLength== 0)
            {
                MessageBox.Show("Bạn chưa nhập từ khóa tìm kiếm");
            }
            else
            {
                try
                {
                    dgvQuanLy.DataSource =  myBLL.timKiemKTV(txtTimKiem.Text);
                    DataTable dt = new DataTable();
                    dgvQuanLy.DataSource = dt;
                }
                catch(SqlException )
                {
                    MessageBox.Show("Không tồn tại tài khoản đó !!");
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult traLoi;
            traLoi = MessageBox.Show("Chắc không?", "Trả lời", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traLoi == DialogResult.OK) Application.Exit();
        }
        
    }
}
