using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TroGiupKhanGia
{
    public partial class GUITroGiupKhanGia : Form
    {


        private String maCH = null;
        public String GetMaCauHoi()
        {
            return maCH;
        }
        public GUITroGiupKhanGia()
        {
            InitializeComponent();
        }
        public GUITroGiupKhanGia(String ma)
        {
            InitializeComponent();
            maCH = ma;
        }
        String dapAnDung = null;
        private void GUITroGiupKhanGia_Load(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-DI6CE7U\SQLEXPRESS;Initial Catalog=Ailatrieuphu;Integrated Security=True");
            conn.Open();
            String sql = "select Dapandung from tblCauhoi where MaCH = '" + GetMaCauHoi() + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                dapAnDung = dr[0].ToString();
            }
            conn.Close();

            if (dapAnDung == "A")
            {
                timer1.Start();
                pictureTroGiupKhanGia.Image = Image.FromFile(@"G:\Project Winforms\BTL Winform\Image_KhanGia\KG_A_1.png");
            }
            else if (dapAnDung == "B")
            {
                timer1.Start();
                pictureTroGiupKhanGia.Image = Image.FromFile(@"G:\Project Winforms\BTL Winform\Image_KhanGia\KG_B_1.png");
            }
            else if (dapAnDung == "C")
            {
                timer1.Start();
                pictureTroGiupKhanGia.Image = Image.FromFile(@"G:\Project Winforms\BTL Winform\Image_KhanGia\KG_C_1.png");
            }
            else if (dapAnDung == "D")
            {
                timer1.Start();
                pictureTroGiupKhanGia.Image = Image.FromFile(@"G:\Project Winforms\BTL Winform\Image_KhanGia\KG_D_1.png");
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
        }
    }
}
