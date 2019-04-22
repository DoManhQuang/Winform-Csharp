using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_WinForm_Ailatrieuphu.Mo_Hinh_3_Layer.Quang
{
    class TroGiup
    {
        private String DapAnDung;
        private String Trogiuptuvan;
        private String Trogiupxoa;

        public TroGiup(string dapAnDung, string trogiuptuvan, string trogiupxoa)
        {
            DapAnDung = dapAnDung;
            Trogiuptuvan = trogiuptuvan;
            Trogiupxoa = trogiupxoa;
        }
        public string DapAnDung1 { get => DapAnDung; set => DapAnDung = value; }
        public string Trogiuptuvan1 { get => Trogiuptuvan; set => Trogiuptuvan = value; }
        public string Trogiupxoa1 { get => Trogiupxoa; set => Trogiupxoa = value; }
    }
}
