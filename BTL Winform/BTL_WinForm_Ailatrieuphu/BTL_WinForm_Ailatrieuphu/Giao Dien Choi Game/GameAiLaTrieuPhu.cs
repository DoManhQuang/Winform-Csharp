using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using BTL_WinForm_Ailatrieuphu.Nguoi_Choi;
using BTL_WinForm_Ailatrieuphu.Mo_Hinh_3_Layer.Quang;
using System.Drawing;
using TroGiupKhanGia;
namespace BTL_WinForm_Ailatrieuphu.Giao_Dien_Choi_Game
{
    public partial class GameAiLaTrieuPhu : Form
    {
        BLGameLayer02 layer02 = new BLGameLayer02();
        private String taiKhoan = null;
        private static int number = 0;
        private string tienThuong = null;
        private static string trogiupXoa = null;
        private static string trogiuoTuVan = null;
        private static string dapanDung = null;
        private static string MaCH = null;
        private static List<string> lstIDRanDom = new List<string>();
        private static string btnClick = null;
        public String getTaiKhoanDN()
        {
            return taiKhoan;
        }
        public static void setDapandung(string dapan)
        {
            dapanDung = dapan;
        }
        public static string getDapandung()
        {
            return dapanDung;
        }
        public static void setTroGiupXoa(string tgXoa)
        {
            trogiupXoa = tgXoa;
        }
        public static string getTroGiupXoa()
        {
            return trogiupXoa;
        }
        public static void setTroGiupTuVan(string tgTuvan)
        {
            trogiuoTuVan = tgTuvan;
        }
        public static string getTroGiupTuVan()
        {
            return trogiuoTuVan;
        }
        public static void setMaCauHoi(string ma)
        {
            MaCH = ma;
        }
        public static string getMaCauHoi()
        {
            return MaCH;
        }
        public static void setListIDRanDom(List<string> list)
        {
            lstIDRanDom = list;
        }
        public static List<string> getListIDRanDom()
        {
            return lstIDRanDom;
        }
        public void setTienThuong(string tien)
        {
            tienThuong = tien;
        }
        public string getTienThuong()
        {
            return tienThuong;
        }
        public void setBtnClick(string btn)
        {
            btnClick = btn;
        }
        public string getBtnClick()
        {
            return btnClick;
        }
        public GameAiLaTrieuPhu()
        {
            InitializeComponent();
            lstIDRanDom = layer02.LayDuLieuMaCauHoiRanDom();
        }
        public GameAiLaTrieuPhu(String TaikhoanDN)
        {
            InitializeComponent();
            this.taiKhoan = TaikhoanDN;
            number = 0;
            lstIDRanDom = layer02.LayDuLieuMaCauHoiRanDom();
        }

        private void btnDauHang_Click(object sender, EventArgs e)
        {
            tienThuong = layer02.ChuaHoaTienThuong(getButtonText(number));
            layer02.CapNhapKetQuaNguoiChoi(getTaiKhoanDN(), (number - 1).ToString(), tienThuong);
            GiaoDienNguoiChoi giaoDien = new GiaoDienNguoiChoi(getTaiKhoanDN());
            this.Hide();
            giaoDien.ShowDialog();
            this.Close();
        }
        public void setButtonColor(int number)
        {
            if(number == 1)
            {
                btnCau1.BackColor = Color.GreenYellow;
            }
            else if (number == 2)
            {
                btnCau2.BackColor = Color.GreenYellow;
            }
            else if (number == 3)
            {
                btnCau3.BackColor = Color.GreenYellow;
            }
            else if (number == 4)
            {
                btnCau4.BackColor = Color.GreenYellow;
            }
            else if (number == 5)
            {
                btnCau5.BackColor = Color.Green;
            }
            else if (number == 6)
            {
                btnCau6.BackColor = Color.GreenYellow;
            }
            else if (number == 7)
            {
                btnCau7.BackColor = Color.GreenYellow;
            }
            else if (number == 8)
            {
                btnCau8.BackColor = Color.GreenYellow;
            }
            else if (number == 9)
            {
                btnCau9.BackColor = Color.GreenYellow;
            }
            else if (number == 10)
            {
                btnCau10.BackColor = Color.Green;
            }
            else if (number == 11)
            {
                btnCau11.BackColor = Color.GreenYellow;
            }
            else if (number == 12)
            {
                btnCau12.BackColor = Color.GreenYellow;
            }
            else if (number == 13)
            {
                btnCau13.BackColor = Color.GreenYellow;
            }
            else if (number == 14)
            {
                btnCau14.BackColor = Color.GreenYellow;
            }
            else if (number == 15)
            {
                btnCau15.BackColor = Color.Green;
            }
        }
        public string getButtonText(int number)
        {
            if (number == 1)
            {
                return btnCau1.Text.Trim();
            }
            else if (number == 2)
            {
                return btnCau2.Text.Trim();
            }
            else if (number == 3)
            {
                return btnCau3.Text.Trim();
            }
            else if (number == 4)
            {
                return btnCau4.Text.Trim();
            }
            else if (number == 5)
            {
                return btnCau5.Text.Trim();
            }
            else if (number == 6)
            {
                return btnCau6.Text.Trim();
            }
            else if (number == 7)
            {
                return btnCau7.Text.Trim();
            }
            else if (number == 8)
            {
                return btnCau8.Text.Trim();
            }
            else if (number == 9)
            {
                return btnCau9.Text.Trim();
            }
            else if (number == 10)
            {
                return btnCau10.Text.Trim();
            }
            else if (number == 11)
            {
                return btnCau11.Text.Trim();
            }
            else if (number == 12)
            {
                return btnCau12.Text.Trim();
            }
            else if (number == 13)
            {
                return btnCau13.Text.Trim();
            }
            else if (number == 14)
            {
                return btnCau14.Text.Trim();
            }
            return btnCau15.Text.Trim();
        }
        public void setTextandButton()
        {
            txtCauHoi.Text = "";
            btnA.Text = "";
            btnB.Text = "";
            btnC.Text = "";
            btnD.Text = "";
            btnA.Enabled = true;
            btnB.Enabled = true;
            btnC.Enabled = true;
            btnD.Enabled = true;
            btnA.BackColor = Color.Transparent;
            btnB.BackColor = Color.Transparent;
            btnC.BackColor = Color.Transparent;
            btnD.BackColor = Color.Transparent;
        }
        //public void EventBtnFilcker(string btnName)
        //{
        //    if(string.Equals(btnName,"A"))
        //    {
        //        btnA.BackColor = Color.Green;
        //        timer1.Start();

        //            //layer02.Delay(1000);
        //           // btnA.BackColor = Color.Green;
        //            //layer02.Delay(5000);
        //            //btnA.BackColor = Color.Yellow;
        //            //layer02.Delay(5000);
        //            //btnA.BackColor = Color.Green;
        //    }
        //    else if (string.Equals(btnName, "B"))
        //    {
        //        for (int i = 0; i < 10; i++)
        //        {
        //            btnB.BackColor = Color.Yellow;
        //            layer02.Delay(500);
        //            btnB.BackColor = Color.Green;
        //            layer02.Delay(500);
        //        }
        //    }
        //    else if (string.Equals(btnName, "C"))
        //    {
        //        for (int i = 0; i < 10; i++)
        //        {
        //            btnA.BackColor = Color.Yellow;
        //            layer02.Delay(500);
        //            btnA.BackColor = Color.Green;
        //            layer02.Delay(500);
        //        }
        //    }
        //    else
        //    {
        //        for (int i = 0; i < 10; i++)
        //        {
        //            btnD.BackColor = Color.Yellow;
        //            layer02.Delay(500);
        //            btnD.BackColor = Color.Green;
        //            layer02.Delay(500);
        //        }
        //    }
        //}
        private void GameAiLaTrieuPhu_Load(object sender, EventArgs e)
        {
            string cauHoi = "";
            setTextandButton();
            setMaCauHoi(getListIDRanDom()[number]);
            DataTable tableCauHoi = layer02.getQuestion(getMaCauHoi());
            string[] DapanChuan = null;
            foreach (DataRow dataRow in tableCauHoi.Rows)
            {
                cauHoi = dataRow["TenCH"].ToString();
                DapanChuan = layer02.ChuanHoaDapAn(dataRow["Dapan"].ToString());
                setDapandung(dataRow["Dapandung"].ToString());
                setTroGiupXoa(dataRow["Trogiupxoa"].ToString());
                setTroGiupTuVan(dataRow["Trogiuptuvan"].ToString());
            }  
            btnA.Text +=  DapanChuan[0].ToString().Trim();
            btnB.Text +=  DapanChuan[1].ToString().Trim();
            btnC.Text +=  DapanChuan[2].ToString().Trim();
            btnD.Text +=  DapanChuan[3].ToString().Trim();
            number++;
            txtCauHoi.Text += "Câu Hỏi " + number + " : " + cauHoi + "?";
        }

        private void pbTrogiup5050_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Bạn muốn cho trợ giúp 50:50 ?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.OK)
                {
                    string[] arrSupport = layer02.ChuanHoaDapAnTroGiup(getTroGiupXoa());
                    foreach (var item in arrSupport)
                    {
                        if (String.Equals("A", item.Trim()))
                        {
                            btnA.Text = "A :";
                            btnA.Enabled = false;
                        }
                        else if (String.Equals("B", item.Trim()))
                        {
                            btnB.Text = "B :";
                            btnB.Enabled = false;
                        }
                        else if (String.Equals("C", item.Trim()))
                        {
                            btnC.Text = "C :";
                            btnC.Enabled = false;
                        }
                        else if (String.Equals("D", item.Trim()))
                        {
                            btnD.Text = "D :";
                            btnD.Enabled = false;
                        }
                    }
                    pbTrogiup5050.Hide();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void btnA_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Đây là đáp án bạn lựa chọn ?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.OK)
                {
                    btnA.BackColor = Color.Orange;
                    if (string.Equals("A", dapanDung.ToUpper().Trim()))
                    {
                        //EventBtnFilcker("A");
                        //MessageBox.Show("Đó là câu trả lời đúng.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        setButtonColor(number);
                        GameAiLaTrieuPhu_Load(sender, e);
                    }
                    else
                    {
                        
                        tienThuong = layer02.ChuaHoaTienThuong(getButtonText(number));
                        layer02.CapNhapKetQuaNguoiChoi(getTaiKhoanDN(),(number - 1).ToString(),tienThuong);
                        btnA.BackColor = Color.Red;
                        //MessageBox.Show("Đó là câu trả lời sai.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnDauHang_Click(sender, e);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void btnB_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Đây là đáp án bạn lựa chọn ?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.OK)
                {
                    btnB.BackColor = Color.Orange;
                    if (string.Equals("B", dapanDung.ToUpper().Trim()))
                    {
                        //EventBtnFilcker("B");
                        //MessageBox.Show("Đó là câu trả lời đúng.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        setButtonColor(number);
                        GameAiLaTrieuPhu_Load(sender, e);
                    }
                    else
                    {
                        
                        tienThuong = layer02.ChuaHoaTienThuong(getButtonText(number));
                        layer02.CapNhapKetQuaNguoiChoi(getTaiKhoanDN(), (number - 1).ToString(), tienThuong);
                        btnB.BackColor = Color.Red;
                        //MessageBox.Show("Đó là câu trả lời sai.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnDauHang_Click(sender, e);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Đây là đáp án bạn lựa chọn ?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.OK)
                {
                    btnC.BackColor = Color.Orange;
                    if (string.Equals("C", dapanDung.ToUpper().Trim()))
                    {
                        
                        //EventBtnFilcker("C");
                        MessageBox.Show("Đó là câu trả lời đúng.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        setButtonColor(number);
                        GameAiLaTrieuPhu_Load(sender, e);
                    }
                    else
                    {
                        
                        tienThuong = layer02.ChuaHoaTienThuong(getButtonText(number));
                        layer02.CapNhapKetQuaNguoiChoi(getTaiKhoanDN(), (number - 1).ToString(), tienThuong);
                        btnC.BackColor = Color.Red;
                        //MessageBox.Show("Đó là câu trả lời sai.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnDauHang_Click(sender, e);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Đây là đáp án bạn lựa chọn ?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.OK)
                {
                    btnD.BackColor = Color.Orange;
                    if (string.Equals("D", dapanDung.ToUpper().Trim()))
                    {
                        
                        //EventBtnFilcker("D");
                        //MessageBox.Show("Đó là câu trả lời đúng.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        setButtonColor(number);
                        GameAiLaTrieuPhu_Load(sender, e);
                    }
                    else
                    {
                        
                        tienThuong = layer02.ChuaHoaTienThuong(getButtonText(number));
                        layer02.CapNhapKetQuaNguoiChoi(getTaiKhoanDN(), (number - 1).ToString(), tienThuong);
                        
                        timer1.Start();
                        btnD.BackColor = Color.Red;
                        //MessageBox.Show("Đó là câu trả lời sai.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnDauHang_Click(sender, e);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn Chọn trợ giúp gọi điện cho người thân ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.Yes == dialogResult)
            {
                string dapanGoiDien= layer02.ChuanHoaDapAnTroGiupGoiDien(getTroGiupTuVan());
                MessageBox.Show("Đáp án mà tôi chọn là " + dapanGoiDien, "Trợ Giúp Gọi Điện", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                pictureBox3.Hide();
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn Chọn trợ giúp chuyên gia tư vấn tại chỗ ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.Yes == dialogResult)
            {
                MessageBox.Show("Đáp án mà tôi chọn là " + getDapandung(), "Trợ Giúp Gọi Điện", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                pictureBox5.Hide();
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            GUITroGiupKhanGia troGiupKhanGia = new GUITroGiupKhanGia(getMaCauHoi());
            troGiupKhanGia.Show();
            pictureBox4.Hide();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void lblCauhoi_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
