using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_WinForm_Ailatrieuphu.Mo_Hinh_3_Layer.Long
{
    class ClassChuanHoaTen
    {
        public string ChuanHoaXau(string xau)
        {
            string kq = "";
            xau = xau.Trim().ToLower();
            for (int i = 0; i < xau.Length; i++)
            {
                if (i == 0)
                    kq += xau[i].ToString().ToUpper();
                else
                    kq += xau[i];
                if (xau[i] == ' ')
                {
                    while (xau[i] == ' ')
                    {
                        i++;
                    }
                    kq += xau[i].ToString().ToUpper();
                }
            }
            return kq.ToString();

        }
    }
}
