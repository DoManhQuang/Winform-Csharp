using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_WinForm_Ailatrieuphu
{
    public class CauHoiDTO
     {
       
            public string MaCH { get; set; }
            public string MaKTV { get; set; }
            public string TenCH { get; set; }
            public string Dapan { get; set; }
            public string Dapandung { get; set; }
            public int Dokho { get; set; }
            public string Trogiupxoa { get; set; }
            public string Trogiuptuvan { get; set; }
            public CauHoiDTO() { }
            public CauHoiDTO(String mach, String maktv, String tench, String Dapan, String Dapand, int DoKho, String Trogiupxoa, String Trogiuptuvan)
            {
                this.MaCH = mach;
                this.MaKTV = maktv;
                this.TenCH = tench;
                this.Dapan = Dapan;
                this.Dapandung = Dapand;
                this.Dokho = DoKho;
                this.Trogiupxoa = Trogiupxoa;
                this.Trogiuptuvan = Trogiuptuvan;

            

        }
        public CauHoiDTO(String mach)
        {
            this.MaCH = mach;
        }

    }
}
