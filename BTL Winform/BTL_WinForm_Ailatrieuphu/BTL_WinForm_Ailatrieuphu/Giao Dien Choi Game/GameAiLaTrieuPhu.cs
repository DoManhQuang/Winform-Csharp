using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using BTL_WinForm_Ailatrieuphu.Nguoi_Choi;
using BTL_WinForm_Ailatrieuphu.Mo_Hinh_3_Layer.Quang;
namespace BTL_WinForm_Ailatrieuphu.Giao_Dien_Choi_Game
{
    public partial class GameAiLaTrieuPhu : Form
    {
        BLGameLayer02 layer02 = new BLGameLayer02();
        private String taiKhoan;
        private static int number = 0;
        private static string trogiupXoa = null;
        private static string trogiuoTuVan = null;
        private static string dapanDung = null;
        private static List<string> lstIDRanDom = new List<string>();
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
        public static void setListIDRanDom(List<string> list)
        {
            lstIDRanDom = list;
        }
        public static List<string> getListIDRanDom()
        {
            return lstIDRanDom;
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
            lstIDRanDom = layer02.LayDuLieuMaCauHoiRanDom();
        }

        private void btnDauHang_Click(object sender, EventArgs e)
        {
            GiaoDienNguoiChoi giaoDien = new GiaoDienNguoiChoi(getTaiKhoanDN());
            this.Hide();
            giaoDien.ShowDialog();
            this.Close();
        }
        private void GameAiLaTrieuPhu_Load(object sender, EventArgs e)
        {
            //List<string> lstMaCH = layer02.LayDuLieuMaCauHoiRanDom(); //vẫn bị trùng ??
            string cauHoi = "";
            lblCauhoi.Text = "";
            btnA.Text = "";
            btnB.Text = "";
            btnC.Text = "";
            btnD.Text = "";
            lblSocauhoiHT.Text = "";
            DataTable tableCauHoi = layer02.getQuestion(getListIDRanDom()[number]);
            string[] DapanChuan = null;
            foreach (DataRow dataRow in tableCauHoi.Rows)
            {
                cauHoi = dataRow["TenCH"].ToString();
                DapanChuan = layer02.ChuanHoaDapAn(dataRow["Dapan"].ToString());
                setDapandung(dataRow["Dapandung"].ToString());
                setTroGiupXoa(dataRow["Trogiupxoa"].ToString());
                setTroGiupTuVan(dataRow["Trogiuptuvan"].ToString());
            }
            lblCauhoi.Text += "Câu Hỏi : " + cauHoi.ToString();
            btnA.Text += "A : " + DapanChuan[0].ToString();
            btnB.Text += "B : " + DapanChuan[1].ToString();
            btnC.Text += "C : " + DapanChuan[2].ToString();
            btnD.Text += "D : " + DapanChuan[3].ToString();
            lblSocauhoiHT.Text += " " + ++number;
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
                            btnA.Text = "";
                            btnA.Enabled = false;
                        }
                        else if (String.Equals("B", item.Trim()))
                        {
                            btnB.Text = "";
                            btnB.Enabled = false;
                        }
                        else if (String.Equals("C", item.Trim()))
                        {
                            btnC.Text = "";
                            btnC.Enabled = false;
                        }
                        else if (String.Equals("D", item.Trim()))
                        {
                            btnD.Text = "";
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
                    if (string.Equals("A", dapanDung.ToUpper().Trim()))
                    {
                        MessageBox.Show("Đó là câu trả lời đúng.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        GameAiLaTrieuPhu_Load(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Đó là câu trả lời sai.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    if (string.Equals("B", dapanDung.ToUpper().Trim()))
                    {
                        MessageBox.Show("Đó là câu trả lời đúng.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        GameAiLaTrieuPhu_Load(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Đó là câu trả lời sai.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    if (string.Equals("C", dapanDung.ToUpper().Trim()))
                    {
                        MessageBox.Show("Đó là câu trả lời đúng.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        GameAiLaTrieuPhu_Load(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Đó là câu trả lời sai.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    if (string.Equals("D", dapanDung.ToUpper().Trim()))
                    {
                        MessageBox.Show("Đó là câu trả lời đúng.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        GameAiLaTrieuPhu_Load(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Đó là câu trả lời sai.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
