using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_WinForm_Ailatrieuphu
{
    class BLLCauHoi
    {
        DALCauHoi da = new DALCauHoi();
        public DataTable ShowCH()
        {
            string sql = "select * from tblCauHoi";
            DataTable dt = new DataTable();
            dt = da.GetTable(sql);
            return dt;
        }

        SqlConnection conn;
        public void insert( String mach, String maktv, String tench, String Dapan, String Dapand, int DoKho, String Trogiupxoa, String Trogiuptuvan)
        {
           conn= da.getConnect();
            conn.Open();
            String sql = " insert into tblCauHoi values(@MaCH, @MaKTV, @TenCH, @Dapan, @Dapandung, @Dokho, @Trogiupxoa, @Trogiuptuvan)";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("MaCH", mach);
            cmd.Parameters.AddWithValue("MaKTV", maktv);
            cmd.Parameters.AddWithValue("TenCH", tench);
            cmd.Parameters.AddWithValue("Dapan", Dapan);
            cmd.Parameters.AddWithValue("Dapandung", Dapand);
            cmd.Parameters.AddWithValue("Dokho", DoKho);
            cmd.Parameters.AddWithValue("Trogiupxoa", Trogiupxoa);
            cmd.Parameters.AddWithValue("Trogiuptuvan", Trogiuptuvan);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void  update(String mach, String maktv, String tench, String Dapan, String Dapand, int DoKho, String Trogiupxoa, String Trogiuptuvan)
        {
            conn = da.getConnect();
            conn.Open();
            String sql = " update tblCauHoi set MaKTV= @MaKTV,TenCH= @TenCH, Dapan=@Dapan, Dapandung=@Dapandung, Dokho=@Dokho, Trogiupxoa=@Trogiupxoa,Trogiuptuvan= @Trogiuptuvan where MaCH=@MaCH";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("MaCH", mach);
            cmd.Parameters.AddWithValue("MaKTV", maktv);
            cmd.Parameters.AddWithValue("TenCH", tench);
            cmd.Parameters.AddWithValue("Dapan", Dapan);
            cmd.Parameters.AddWithValue("Dapandung", Dapand);
            cmd.Parameters.AddWithValue("Dokho", DoKho);
            cmd.Parameters.AddWithValue("Trogiupxoa", Trogiupxoa);
            cmd.Parameters.AddWithValue("Trogiuptuvan", Trogiuptuvan);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void delete(String mach)
        {
            conn = da.getConnect();
            conn.Open();
            string sql = "delete tblCauHoi where MaCH=@MaCH";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("MaCH", mach);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public DataTable look( String dk)
        {
            conn = da.getConnect();
            conn.Open();
            string sql = " select * from tblCauHoi where MaCH like '%" + dk + "%'";
            DataTable dt = new DataTable();
            dt = da.GetTable(sql);
            return dt;
        }
        public bool kiemtratontai(String mach)
        {
           
           conn = da.getConnect();
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select MaCH from tblCauHoi where MaCH=@MaCH", conn);
            cmd.Parameters.AddWithValue("MaCH", mach);
            SqlDataReader dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                return true;
            }
            conn.Close();
           
            return false;
        }
        public List<CauHoiDTO> ThongTinCauHoi()
        {
            List<CauHoiDTO> ds = new List<CauHoiDTO>();
            conn=da.getConnect();
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select*from tblCauHoi", conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                CauHoiDTO ch = new CauHoiDTO(dr[0].ToString(), dr[1].ToString(),dr[2].ToString(),
                    dr[3].ToString(), dr[4].ToString(), int .Parse(dr[5].ToString()), dr[6].ToString(), dr[7].ToString());
                ds.Add(ch);
            }
            conn.Close();
            return ds;
        }
        public DataSet combo()
        {
            conn = da.getConnect();
            conn.Open();
            string sql = " select distinct DoKho from tblCauHoi";
            SqlCommand cm = new SqlCommand();
            SqlDataAdapter ad = new SqlDataAdapter();
            DataSet ds = new DataSet();
            cm = new SqlCommand(sql, conn);
            ad = new SqlDataAdapter(cm);
            ds = new DataSet();
            ad.Fill(ds);
            return ds;
        }
        public DataSet combo2()
        {
            conn = da.getConnect();
            conn.Open();
            string sql = "select distinct Dapandung from tblCauHoi";
            SqlCommand cm = new SqlCommand();
            SqlDataAdapter ad = new SqlDataAdapter();
            DataSet ds = new DataSet();
            cm = new SqlCommand(sql, conn);
            ad = new SqlDataAdapter(cm);
            ds = new DataSet();
            ad.Fill(ds);
            return ds;
        }
        public string XuLyMaTK(string matk)
        {
            matk = matk.Remove(0, 2);
            int matkNew = int.Parse(matk) + 1;
            if(matkNew<10)
                 matk = "CH00" + matkNew;
            if(matkNew>=10 && matkNew<100)
                matk = "CH0" + matkNew;
            return matk;
        }
        public string GetMaTKNew()
        {
            string cmdText = "select top 1 MaCH from tblCauHoi order by MaCH desc";
            SqlDataReader dataReader = da.GetExecuteReader(cmdText);
            if (dataReader.Read())
            {
                return XuLyMaTK(dataReader[0].ToString());
            }
            return null;
        }
    }
        
    }

