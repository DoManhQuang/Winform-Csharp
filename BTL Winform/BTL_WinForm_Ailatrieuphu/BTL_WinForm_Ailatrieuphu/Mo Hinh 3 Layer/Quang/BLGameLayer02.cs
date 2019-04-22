using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace BTL_WinForm_Ailatrieuphu.Mo_Hinh_3_Layer.Quang
{
    /*
     *  có 3 form : Giao diện chơi game , giao diện trợ giúp tư vấn , giao diện trợ giúp của khán giả
        Truy vấn database lấy ra TenCH , Dapan , Dapandung , Trogiuptuvan , Trogiupxoa lưu vào 1 list 
        trợ giúp 50:50 sẽ đóng 2 đáp án sai 
         */
    class BLGameLayer02
    {
        DALayer01 Layer01 = new DALayer01();
        public DataTable getQuestion(String MaCH)
        {
            string cmdText = "select * from dbo.ThongTinCauHoi('"+MaCH+"')";
            DataTable  tableCauHoi = Layer01.GetDataTable(cmdText);
            return tableCauHoi;
        }
        public string[] ChuanHoaDapAnTroGiup(string strDapan)
        {
            string[] dapan = null;
            dapan = strDapan.Split(' ');
            return dapan;
        }
        public string[] ChuanHoaDapAn(string dapan)
        {
            string[] dapAn = new string[4];
            string[] strArr = null;
            string[] strDapAn = null;
            strArr = dapan.Split(' ');
            for (int count = 0; count < strArr.Length; count++)
            {
                string chuanHoa = null;
                strDapAn = strArr[count].Split('_');
                for (int i = 0; i < strDapAn.Length; i++)
                {
                    chuanHoa = chuanHoa + strDapAn[i] + " ";
                }
                dapAn[count] = chuanHoa;
            }
            return dapAn;
        }
        public List<string> LayDuLieuMaCauHoiRanDom()
        {
            List<string> lstIDRandom = new List<string>();
            string cmdText = "select * from RanDomMaCauHoiDe ; select * from RanDomMaCauHoiVua ; select * from RanDomMaCauHoiKho";
            DataSet dataSet = Layer01.GetDataSet(cmdText);
            DataTable dtCauHoiDe = dataSet.Tables[0];
            DataTable dtCauHoiVua = dataSet.Tables[1];
            DataTable dtCauHoiKho = dataSet.Tables[2];
            foreach (DataRow dataRow in dtCauHoiDe.Rows)
            {
                lstIDRandom.Add(dataRow["MaCH"].ToString());
            }
            foreach (DataRow dataRow in dtCauHoiVua.Rows)
            {
                lstIDRandom.Add(dataRow["MaCH"].ToString());
            }
            foreach (DataRow dataRow in dtCauHoiKho.Rows)
            {
                lstIDRandom.Add(dataRow["MaCH"].ToString());
            }
            return lstIDRandom;
        }
    }
}
