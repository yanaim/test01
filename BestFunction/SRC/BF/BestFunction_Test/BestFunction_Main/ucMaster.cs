using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//
//using System.Data.Linq;
using System.Data.Entity;
//
//using FarPoint.Win;
//using FarPoint.Win.Spread;
//using FarPoint.Win.Spread.Model;
//using FarPoint.Win.Spread.CellType;
//
using Npgsql;
using NpgsqlTypes;

using B2.Com;
using B2.BestFunction;


namespace B2.BestFunction
{
    public partial class ucMaster : UserControl
    {
        //-----------------------------------------------
        // 共通パラメータ
        //-----------------------------------------------
        clsB2Com pb2com;
        
        public ucMaster(clsB2Com　b2com)
        {
                //共通パラメータのセット
            pb2com = b2com;
        
            InitializeComponent();

            this.Load += new System.EventHandler(this.ucMaster_Load);
        }

        private void ucMaster_Load(object sender, EventArgs e)
        {
            //Panelの初期化
            txt10.Text = "テストのためユーザアカウント保守（不要になりました.)を表示します。";
        }

        //-----------------------------------
        // メインFormへ伝えるイベントハンドラを定義
        public event MyEventHandler MyProgressEvent;

        // Form1へイベントを伝える関数を定義
        private void UpdateProgress(int commandNumValue, string commandStringValue)
        {
            MyProgressEvent(new MyEventArgs(commandNumValue, commandStringValue));
        }

        //-----------------------------------
        //イベントハンドラのデリゲートを定義
        public delegate void MyEventHandler(MyEventArgs e);

        //-----------------------------------
        // 渡せるイベントデータ引数、EventArgsを継承したクラスを拡張
        public class MyEventArgs : EventArgs
        {
            private readonly int _commandNumValue;
            private readonly string _commandStringValue;

            public MyEventArgs(int commandNumValue, string commandStringValue)
            {
                _commandNumValue = commandNumValue;
                _commandStringValue = commandStringValue;
            }
            public int commandNumValue { get { return _commandNumValue; } }
            public string commandStringValue { get { return _commandStringValue; } }

        }

        //-------------------------------------------------
        // メインForm側のアップデート（コールバック）
        //-------------------------------------------------

        private void lblBtn1_Click(object sender, EventArgs e)
        {
            UpdateProgress(1, "薬品マスタ");
        }

        private void lblBtn2_Click(object sender, EventArgs e)
        {
            UpdateProgress(2, "成分マスタ");
        }

        private void lblBtn3_Click(object sender, EventArgs e)
        {
            UpdateProgress(3, "薬局マスタ");
        }

        private void lblBtn4_Click(object sender, EventArgs e)
        {
            UpdateProgress(4, "店舗マスタ");
        }

        private void lblBtn5_Click(object sender, EventArgs e)
        {
            UpdateProgress(5, "仕入先マスタ");
        }

        private void lblBtn6_Click(object sender, EventArgs e)
        {
            UpdateProgress(6, "営業日情報");
        }

        private void lblBtn7_Click(object sender, EventArgs e)
        {
            UpdateProgress(7, "手配管理マスタ");
        }

        private void lblBtn8_Click(object sender, EventArgs e)
        {
            UpdateProgress(8, "棚番マスタ");
        }

        private void lblBtn9_Click(object sender, EventArgs e)
        {
            UpdateProgress(9, "自社店舗マスタ");
        }

        private void lblBtn10_Click(object sender, EventArgs e)
        {
            UpdateProgress(10, "発注管理情報");
        }


    }
}
