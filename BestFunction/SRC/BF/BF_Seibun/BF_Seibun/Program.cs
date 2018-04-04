using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
//
using B2.Com;
using Npgsql;
using B2.BestFunction;


namespace BF_Seibun
{
    static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
       //     frmMain frm = new frmMain(b2com);
       //     Application.Run(frm);
            Application.Run(new frmMain());

        }
    }
}
