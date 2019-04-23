using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using BTL_WinForm_Ailatrieuphu.Giao_Dien_Choi_Game;
namespace BTL_WinForm_Ailatrieuphu
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormDangNhap());
            //Application.Run(new GameAiLaTrieuPhu());
        }
    }
}
