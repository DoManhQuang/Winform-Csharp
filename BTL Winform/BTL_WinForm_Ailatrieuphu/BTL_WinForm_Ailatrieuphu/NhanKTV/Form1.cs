using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Reflection;
using BTL_WinForm_Ailatrieuphu.NhanKTV.CauHoiResourseTableAdapters;
namespace BTL_WinForm_Ailatrieuphu
{
    public partial class FormKyThuatVien : Form
    {
        private string MaKTVDN = null;
        public string getMaKTVDangNhap()
        {
            return MaKTVDN;
        }
        BLLCauHoi myBLL = new BLLCauHoi();
        public FormKyThuatVien()
        {
            InitializeComponent();
            dgvCauHoi.DataSource = LoadRecored(pageNumber, numberRecord);
            DataSet ds = new DataSet();
            ds = myBLL.combo();
            cbDoKho.DataSource = ds.Tables[0];
            cbDoKho.DisplayMember = "DoKho";
            DataSet ds1 = new DataSet();
            ds1 = myBLL.combo2();
            cbDAD.DataSource = ds1.Tables[0];
            cbDAD.DisplayMember = "Dapandung";
        }
        public FormKyThuatVien( string ma)
        {
            InitializeComponent();
            dgvCauHoi.DataSource = LoadRecored(pageNumber, numberRecord);
            DataSet ds = new DataSet();
            ds = myBLL.combo();
            cbDoKho.DataSource = ds.Tables[0];
            cbDoKho.DisplayMember = "DoKho";
            DataSet ds1 = new DataSet();
            ds1 = myBLL.combo2();
            cbDAD.DataSource = ds1.Tables[0];
            cbDAD.DisplayMember = "Dapandung";
            this.MaKTVDN = ma;
        }
        int pageNumber=1;
        int numberRecord = 6;
        //String maKVT="KTV001";
        DataSet dsTest = new DataSet();
        DataTable dt = new DataTable();
        
        private void btnThem_Click(object sender, EventArgs e)
        {
            totalRecord = myBLL.ThongTinCauHoi().Count();
            //MessageBox.Show(dgvCauHoi.Rows[totalRecord - 2].Cells[0].Value.ToString());
            if (txtTenCH.Text.Equals(""))
            {
                MessageBox.Show(" Mã kỹ thuật viên không  được để trống");
            }
            else if (txtDapan.Text.Equals(""))
            {
                MessageBox.Show(" Đáp án  không  được để trống");
            }
            else if (cbDAD.Text.Equals(""))
            {
                MessageBox.Show("Đáp  án đúng không  được để trống");
            }
            else if (cbDoKho.Text.Equals(""))
            {
                MessageBox.Show("Độ khó không  được để trống");
            }
            else if (txtTroGiup.Text.Equals(""))
            {
                MessageBox.Show(" Trợ giúp xóa không  được để trống");
            }
            else if (txtTuVan.Text.Equals(""))
            {
                MessageBox.Show(" Trợ giúp tư vấn viên không  được để trống");
            }

            else
            {
                try
                {

                    txtMaKTV.Text = getMaKTVDangNhap();
                    string daucach = dauCach(txtDapan.Text);
                    string vhoa = vietHoa(daucach);
                    string themgach = themdaugach(vhoa);
                    
                    txtMaCH.Text= myBLL.GetMaTKNew();
                    myBLL.insert(txtMaCH.Text, txtMaKTV.Text, txtTenCH.Text, themgach, cbDAD.Text, int.Parse(cbDoKho.Text), txtTuVan.Text,txtTuVan.Text);

                    MessageBox.Show(" Thêm thành công");
                }
                catch (FormatException )
                {
                    MessageBox.Show("bạn cần nhập đúng định dạng độ khó");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    MessageBox.Show("thêm không  thành công");
                }
            }
            txtMaCH.Clear();
            txtMaKTV.Clear();
            txtTenCH.Clear();
            txtDapan.Clear();
            txtTroGiup.Clear();
            txtTuVan.Clear();

        }
        static string dauCach(string chuoi)
        {
            string cuoi = chuoi.Trim();
            //xoa dau cach o giua

            for (int j = 0; j < cuoi.Length; j++)
            {
                int dem = 0;
                while (cuoi[j] == ' ' && cuoi[j + 1] == ' ')
                {
                    dem++; j++;
                }
                cuoi = cuoi.Remove(j - dem + 1, dem);
                j = j - dem;
            }

            // loai dau cach truoc dau cham,phay

            for (int j = 1; j < cuoi.Length; j++)
            {
                while ((cuoi[j] == ',' || cuoi[j] == '.') && cuoi[j - 1] == ' ')
                    cuoi = cuoi.Remove(j - 1, 1);
            }

            // sau dau cham,phay co 1 dau cach

            int b = cuoi.Length;
            for (int j = 0; j < b - 1; j++)
            {
                if ((cuoi[j] == ',' || cuoi[j] == '.') && cuoi[j + 1] != ' ')
                {
                    cuoi = cuoi.Substring(0, j + 1) + ' ' + cuoi.Substring(j + 1, b - j - 1);
                    b = b + 1;
                }

            }
            return cuoi;
        }
        static string themdaugach(string chuoi)
        {
            string chuoi2 = "";
            string cuoi = chuoi.Trim();
            for (int j = 0; j < cuoi.Length; j++)
            {
                while (true)
                {
                    if (cuoi[j] != ' ')
                    {
                        chuoi2 = chuoi2 + cuoi[j];
                        j++;
                    }
                    else
                    {
                        chuoi2 = chuoi2 + '_';
                        j++;
                    }
                    if (j >= cuoi.Length)
                        break;
                }

            }
            while (chuoi2.IndexOf("_Dap_an") != -1)
            {
                chuoi2 = chuoi2.Replace("_Dap_an", " Dap_an");
            }
            return chuoi2;
        }
        static string vietHoa(string chuoi)
        {
            int n = chuoi.Length;
            chuoi = chuoi.ToLower();
            string chuoiMoi = ""; ;
            char a = char.ToUpper(chuoi[0]);
            chuoiMoi = chuoiMoi + a + chuoi[1];
            for (int i = 2; i < n; i++)
            {
                if (chuoi[i - 2] == '.')
                    a = char.ToUpper(chuoi[i]);
                else
                    a = chuoi[i];
                chuoiMoi = chuoiMoi + a;
            }


            return chuoiMoi;
        }
        private void btnLayFile_Click(object sender, EventArgs e)
        {

            OpenFileDialog ofd = new OpenFileDialog();
           
            txtFilePath.Text = ofd.ShowDialog() == DialogResult.OK ? ofd.FileName : "";
            
            if (!ValidInput())
                return;

            
            DataTable data = ReadDataFromExcelFile();
         
            ImportIntoDatabase(data);


            Form1_Load(sender,e);

        }
        private bool ValidInput()
        {
            if (txtFilePath.Text.Trim() == "")
            {
                MessageBox.Show("Xin vui lòng chọn tập tin excel cần import");
                return false;
            }
            return true;
        }
        public bool ktra(String s)
        {
            String[] str = { "A", "B", "C", "D" };
            int dem = 0;
            foreach(String a in str)
            {
                if(a.Contains(s))
                {
                    dem++;
                    break;
                }
            }
            if (dem != 0) return true;
           else return false;
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtTenCH.Text.Equals(""))
            {
                MessageBox.Show(" Mã kỹ thuật viên không  được để trống");
            }
            else if (txtDapan.Text.Equals(""))
            {
                MessageBox.Show(" Đáp án  không  được để trống");
            }
            else if (cbDAD.Text.Equals(""))
            {
                MessageBox.Show("Đáp  án đúng không  được để trống");
            }
            else if (cbDoKho.Text.Equals(""))
            {
                MessageBox.Show("Độ khó không  được để trống");
            }
            else if (txtTroGiup.Text.Equals(""))
            {
                MessageBox.Show(" Trợ giúp xóa không  được để trống");
            }
            else if (txtTuVan.Text.Equals(""))
            {
                MessageBox.Show(" Trợ giúp tư vấn viên không  được để trống");
            }
            
            else
            {
                try
                {
                    txtMaKTV.Text = getMaKTVDangNhap();
                    string daucach = dauCach(txtDapan.Text);
                    string vhoa = vietHoa(daucach);
                    string themgach = themdaugach(vhoa);

                    myBLL.update(txtMaCH.Text, txtMaKTV.Text, txtTenCH.Text, themgach, cbDAD.Text, int.Parse(cbDoKho.Text), txtTroGiup.Text, txtTuVan.Text);

                    MessageBox.Show("Sửa thành công");
                }
                catch (FormatException )
                {
                    MessageBox.Show("bạn cần nhập đúng định dạng độ khó");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    MessageBox.Show("Sửa  chưa thành công");
                }
            }
            txtMaCH.Clear();
            txtMaKTV.Clear();
            txtTenCH.Clear();
            txtDapan.Clear();
            txtTroGiup.Clear();
            txtTuVan.Clear();

        }
        int viTri;
        private void dgvCauHoi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            viTri = e.RowIndex;
            if (viTri >= 0)
            {
                txtMaCH.Text = dgvCauHoi.Rows[viTri].Cells[0].Value.ToString();
                txtMaKTV.Text = dgvCauHoi.Rows[viTri].Cells[1].Value.ToString();
                txtTenCH.Text = dgvCauHoi.Rows[viTri].Cells[2].Value.ToString();
                txtDapan.Text = dgvCauHoi.Rows[viTri].Cells[3].Value.ToString();
                cbDAD.Text = dgvCauHoi.Rows[viTri].Cells[4].Value.ToString();
                cbDoKho.Text = dgvCauHoi.Rows[viTri].Cells[5].Value.ToString();
                txtTroGiup.Text = dgvCauHoi.Rows[viTri].Cells[6].Value.ToString();
                txtTuVan.Text = dgvCauHoi.Rows[viTri].Cells[7].Value.ToString();
            }
        }
        
        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dlr = MessageBox.Show("Bạn thực sự muốn xóa câu hỏi  " + txtMaCH.Text + "  không?", "Thông báo", MessageBoxButtons.YesNo);
                if (dlr == DialogResult.Yes)
                {
                    myBLL.delete(txtMaCH.Text);
                    MessageBox.Show(" Xóa thành công");
                }
                else this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            txtMaCH.Clear();
            txtMaKTV.Clear();
            txtTenCH.Clear();
            txtDapan.Clear();
            txtTroGiup.Clear();
            txtTuVan.Clear();

        }

        private void btbThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            Form form = new Form();
            Label label = new Label();
            TextBox textBox = new TextBox();
            Button buttonOk = new Button();
            Button buttonCancel = new Button();
            buttonOk.Text = "OK";
            buttonCancel.Text = "Cancel";
            buttonOk.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;
            label.SetBounds(9, 20, 372, 13);
            textBox.SetBounds(12, 36, 372, 20);
            buttonOk.SetBounds(228, 72, 75, 23);
            buttonCancel.SetBounds(309, 72, 75, 23);
            form.Text = "Tìm kiếm";
            label.Text = "Mời bạn nhập thông tin tìm kiếm";
            form.ClientSize = new Size(396, 107);
            form.Controls.AddRange(new Control[] { label, textBox, buttonOk, buttonCancel });
            form.ClientSize = new Size(Math.Max(300, label.Right + 10), form.ClientSize.Height);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.AcceptButton = buttonOk;
            form.CancelButton = buttonCancel;
            DialogResult dialogResult = form.ShowDialog();
            if (textBox.TextLength == 0 && dialogResult== DialogResult.OK)
            {
                MessageBox.Show("bạn phải nhập thông tin tìm kiếm");
            }
            else if(textBox.TextLength != 0 && dialogResult == DialogResult.OK)
            {
                string dk = textBox.Text;
                if (myBLL.kiemtratontai(dk) == true)
                {
                    DataTable dt = new DataTable();
                    dt = myBLL.look(dk);
                    dgvCauHoi.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Mã câu hỏi "+ textBox.Text+" không tồn tại trong bảng");
                }
            }
            else
            {
                form.Close();
            }

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cauHoiResourse.tblCauhoi' table. You can move, or remove it, as needed.
            //this.tblCauhoiTableAdapter.Fill(this.cauHoiResourse.tblCauhoi);
            // TODO: This line of code loads data into the 'cauHoiResourse.tblCauhoi' table. You can move, or remove it, as needed.
           // this.tblCauhoiTableAdapter.Fill(this.cauHoiResourse.tblCauhoi);
            dgvCauHoi.DataSource = LoadRecored(pageNumber, numberRecord);

        }
       
       
        List<CauHoiDTO> LoadRecored(int page, int recordNum)
        {
            List<CauHoiDTO> resulf = new List<CauHoiDTO>();
            resulf = myBLL.ThongTinCauHoi().Skip((page - 1) * recordNum).Take(recordNum).ToList();
            return resulf;
        }
        int totalRecord = 0;
        private void numTrang_MouseUp(object sender, MouseEventArgs e)
        {
           
            
            totalRecord = myBLL.ThongTinCauHoi().Count();
            if (pageNumber-1< totalRecord / numberRecord)
            {
                pageNumber++;
                dgvCauHoi.DataSource = LoadRecored(pageNumber, numberRecord);
              
                
            }
          
        }
       
        private void numTrang_MouseDown(object sender, MouseEventArgs e)
        {
            pageNumber =int.Parse(numTrang.Value.ToString());
            if (pageNumber > 0)
            {
                pageNumber--;
               
                dgvCauHoi.DataSource = LoadRecored(pageNumber, numberRecord);
            }
        }

      
        
        private DataTable ReadDataFromExcelFile()
        {
            string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + txtFilePath.Text.Trim() + ";Extended Properties=Excel 8.0";

            // Tạo đối tượng kết nối
            OleDbConnection oledbConn = new OleDbConnection(connectionString);
            DataTable data = null;
            try
            {
                
                oledbConn.Open();
                OleDbCommand cmd = new OleDbCommand("SELECT *FROM [sheet1$]", oledbConn);
                OleDbDataAdapter oleda = new OleDbDataAdapter();

                oleda.SelectCommand = cmd;
                DataSet ds = new DataSet();
                oleda.Fill(ds);

                data = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                oledbConn.Close();
            }
            return data;
        }

        private void ImportIntoDatabase(DataTable data)
        {
            if (data == null || data.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để import");
                return;
            }
            
           tblCauhoiTableAdapter adapter = new tblCauhoiTableAdapter();
            String MaCH = "";
            String MaKTV = "";
            String TenCH = "";
            String Dapan = "";
            String Dapandung = "";
            int dokho = 0;
            string trogiupxoa = "";
            String trogiuptuvan = "";
            try
            {
                for (int i = 0; i < data.Rows.Count; i++)
                {
                    MaCH = data.Rows[i]["MaCH"].ToString().Trim();
                    MaKTV = data.Rows[i]["MaKTV"].ToString().Trim();
                    TenCH = data.Rows[i]["TenCH"].ToString().Trim();
                    Dapan = data.Rows[i]["Dapan"].ToString().Trim();
                    Dapandung = data.Rows[i]["Dapandung"].ToString().Trim();
                    dokho = int.Parse(data.Rows[i]["DoKho"].ToString().Trim());
                    trogiupxoa = data.Rows[i]["Trogiupxoa"].ToString().Trim();
                    trogiuptuvan = data.Rows[i]["Trogiuptuvan"].ToString().Trim();
                    bool kt = myBLL.kiemtratontai(MaCH);
                    if (kt==false)
                    {
                        adapter.Insert(MaCH, MaKTV, TenCH, Dapan, Dapandung, dokho, trogiupxoa, trogiuptuvan);
                    }
                   
                    else
                   {
                        adapter.Update(data.Rows[i]);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                MessageBox.Show("Kết thúc import");
            }

           
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvCauHoi.DataSource = LoadRecored(pageNumber, numberRecord);
        }
    }
}



   


