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
    public partial class frmBestFunction : Form
    {

        //-----------------------------------------------
        // 共通パラメータ
        //-----------------------------------------------
        clsB2Com pb2com;

        frmBFForm runF = null;

        Color saveColor;

        public frmBestFunction()
        {
            InitializeComponent();
        }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="b2com">共通パラメータ</param>
        public frmBestFunction(clsB2Com　b2com)
        {
            //共通パラメータのセット
            pb2com = b2com;

            //コンポーネントの初期化
            InitializeComponent();
        }

        //Load
        private void frmMain_Load(object sender, EventArgs e)
        {
            try
            {
                //日時と薬局名称
                textBox1.Text = Environment.NewLine + DateTime.Today.ToString("yyyy/MM/dd") + Environment.NewLine + Environment.NewLine + "アサイクル薬局";
                
                this.KeyPreview = true;

                //プログラム開始ログの出力
                pb2com.WriteSysLog(clsB2Com.EXCD_START, pb2com.DB_User, "プログラムを開始します。");

                //変数等の初期化

            }
            catch (Exception ex)
            {
                pb2com.ShowErrMsg(ex);
            }
        }

        //初期表示
        private void frmMain_Shown(object sender, EventArgs e)
        {
            try
            {
                //ログイン名称
                label2.Text = "浅井　太郎";

                //--------------------------------------
                // 初期化
                //--------------------------------------
                //プログラムタイトルの設定
                clsBfCom bfcom = new clsBfCom();
                this.Text = bfcom.getProgramName(pb2com);

                //背景色等の設定
                pb2com.gfncSetBackColor(this);

                //
                this.Activate();
            }
            catch (NpgsqlException ex)
            {
                pb2com.ShowErrMsg(ex);
                this.Close();
                return;
            }
            catch (Exception ex)
            {
                pb2com.ShowErrMsg(ex);
                this.Close();
                return;
            }
        }

        //終了
        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (MessageBox.Show(this.Text + "を終了します。\r\nよろしいですか？", "確認", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) != DialogResult.Yes)
                {

                    e.Cancel = true;
                    return;
                }

                //プログラム終了ログの出力
                pb2com.WriteSysLog(clsB2Com.EXCD_EXIT, pb2com.DB_User, "プログラムを終了します。");
            }
            catch (Exception)
            {
                return;
            }
        }

        //マスタメンテナンス
        private void button5_Click(object sender, EventArgs e)
        {
            //ユーザーコントロールのインスタンス化
            ucMaster uc = new ucMaster(pb2com);

            //----------------------------------------------------------------------
            // イベントハンドラの追加（コールバックイベントの追加）
            //----------------------------------------------------------------------
            uc.MyProgressEvent += new ucMaster.MyEventHandler(CallBackEventProgress);

            //フォームのコントロールにユーザーコントロールを追加する
            this.setMainPanelUc(uc);
         
        }

        //検索ボタン
        private void button9_Click(object sender, EventArgs e)
        {
            string fielddata = gcComboBox1.SelectedItem.Text;
            string keydata = textBox2.Text;
            runF.kensaku(fielddata, keydata);
        }

        //ログアウト
        private void gcTextBox1_Click(object sender, EventArgs e)
        {

        }

        //ログアウト
        private void gcTextBox1_DoubleClick(object sender, EventArgs e)
        {

        }

        //動的にフォームをインスタン化して表示する。
        private void setMainPanelform(string filename, string formname)
        {

            ////アセンブリ"WindowsApplication1.exe"を読み込む
            //System.Reflection.Assembly asm =
            //    System.Reflection.Assembly.LoadFile("WindowsApplication1.exe");
            // カレントディレクトリの取得
            string stCurrentDir = System.Environment.CurrentDirectory;
            stCurrentDir = stCurrentDir + @"\" + filename;
            System.Reflection.Assembly asm =
                System.Reflection.Assembly.LoadFile(stCurrentDir);

            ////Form1のTypeを取得する
            //Type t = asm.GetType("WindowsApplication1.Form1");
            Type t = asm.GetType(formname);
            if(t == null)
            {
                MessageBox.Show("Typeの取得で異常です。");
                return;
            }


            //Formのインスタンスを作成する
            object frm = t.InvokeMember(null,
                System.Reflection.BindingFlags.CreateInstance,
                null, null,
                new object[] {pb2com} );

            //Baseフォームにキャスト
            runF = (frmBFForm)frm;

            //frm.Dock = DockStyle.Fill;
            runF.Dock = DockStyle.Fill;
            ////TopLevelをFalseにする
            //frm.TopLevel = false;
            runF.TopLevel = false;

            this.splitContainer2.Panel2.Controls.Add(runF);
            if (this.splitContainer2.Panel2.Controls.Count > 1)
            {
                this.splitContainer2.Panel2.Controls.RemoveAt(0);
            }

            //最前面へ移動
            runF.BringToFront();

            //----------------------------------------------------------------------
            // イベントハンドラの追加（コールバックイベントの追加）
            //----------------------------------------------------------------------
            //f.MyProgressEvent += new frmUserAccount.MyEventHandler(CallBackEventProgress);
            runF.MyProgressEvent += new frmBFForm.MyEventHandler(CallBackEventProgress);

            ////Form1のShowDialogメソッドを呼び出し、フォームを表示する
            //object result = t.InvokeMember("ShowDialog",
            //    System.Reflection.BindingFlags.InvokeMethod,
            //    null, frm,
            //    null);

            //フォームを表示する
            runF.Show();
            //モーダルダイアログとして表示出来ない。
            //f.ShowDialog();
            //button5.BackColor = saveColor;

        }

        //動的にフォームをインスタン化して表示する。
        private void setMainPanelform2(string filename, string formname)
        {

            ////アセンブリ"WindowsApplication1.exe"を読み込む
            //System.Reflection.Assembly asm =
            //    System.Reflection.Assembly.LoadFile("WindowsApplication1.exe");
            // カレントディレクトリの取得
            string stCurrentDir = System.Environment.CurrentDirectory;
            stCurrentDir = stCurrentDir + @"\" + filename;
            System.Reflection.Assembly asm =
                System.Reflection.Assembly.LoadFile(stCurrentDir);

            ////Form1のTypeを取得する
            //Type t = asm.GetType("WindowsApplication1.Form1");
            Type t = asm.GetType(formname);
            if (t == null)
            {
                MessageBox.Show("Typeの取得で異常です。");
                return;
            }

            //Formのインスタンスを作成する
            object frm = t.InvokeMember(null,
                System.Reflection.BindingFlags.CreateInstance,
                null, null,
                new object[] { pb2com });


            ////Form1のShowDialogメソッドを呼び出し、フォームを表示する モーダル　OK
            //object result = t.InvokeMember("ShowDialog",
            //    System.Reflection.BindingFlags.InvokeMethod,
            //    null, frm,
            //    null);

            //Form1のShowDialogメソッドを呼び出し、フォームを表示する モードレス　ＯＫ
            object result = t.InvokeMember("Show",
                System.Reflection.BindingFlags.InvokeMethod,
                null, frm,
                null);

        }

        //パネルにフォームを埋め込む
        private void setMainPanelform(frmBFForm frm)
        {
            frm.Dock = DockStyle.Fill;
            //TopLevelをFalseにする
            frm.TopLevel = false;
            this.splitContainer2.Panel2.Controls.Add(frm);
            if (this.splitContainer2.Panel2.Controls.Count > 1)
            {
                this.splitContainer2.Panel2.Controls.RemoveAt(0);
            }
        }

        //パネルにユーザーコントロールを埋め込む
        private void setMainPanelUc(ucMaster ucontrol)
        {
            ucontrol.Dock = DockStyle.Fill;
            this.splitContainer2.Panel2.Controls.Add(ucontrol);
            if (this.splitContainer2.Panel2.Controls.Count > 1)
            {
                this.splitContainer2.Panel2.Controls.RemoveAt(0);
            }
        }

        //設定（テスト）
        private void button7_Click(object sender, EventArgs e)
        {
            ////ユーザーコントロールのインスタンス化
            //ucMaster uc = new ucMaster(pb2com);

            ////----------------------------------------------------------------------
            //// イベントハンドラの追加（コールバックイベントの追加）
            ////----------------------------------------------------------------------
            //uc.MyProgressEvent += new ucMaster.MyEventHandler(CallBackEventProgress);
            
            ////フォームのコントロールにユーザーコントロールを追加する
            //this.setMainPanelUc(uc);

            //TEST
            if (this.splitContainer2.Panel2.Controls.Count > 0)
            {
                this.splitContainer2.Panel2.Controls.RemoveAt(0);
            }
        }

        //----------------------------------------------------------------------
        // コールバックイベント  from ユーザーコントロール
        //----------------------------------------------------------------------
        private void CallBackEventProgress(ucMaster.MyEventArgs e)
        {
           // MessageBox.Show(e.commandNumValue.ToString() + ":" + e.commandStringValue);

            switch(e.commandNumValue)
            {
                case 1:  //薬品マスタ
                    break;
                
                case 2:  //成分マスタ
                    break;
                
                case 3:  //薬局マスタ
                    break;
                
                case 4:  //店舗マスタ
                    break;
                
                case 5:  //仕入先マスタ
                    break;
                
                case 6:  //営業日情報
                    break;
                
                case 7:  //手配管理マスタ
                    break;
                
                case 8:  //棚番マスタ
                    break;

                case 9:  //自社店舗マスタ
                    gcComboBox1.Init(pb2com, "combodata", "seq_no", "field_data");
                    gcComboBox1.SelectedIndex = 0;

                    ////表示させるフォームのインスタンスを作成
                    //frmUserAccount f = new frmUserAccount(pb2com);
                    //runF = f;   //フォームオブジェクトを退避

                    setMainPanelform2("BF_UserAccount.exe", "B2.BestFunction.frmMain");
                    //setMainPanelform("BF_UserAccount2.exe", "frmUserAccount");
                    break;

                case 10:  //発注管理情報 ユーザアカウント
                    gcComboBox1.Init(pb2com, "combodata", "seq_no", "field_data");
                    gcComboBox1.SelectedIndex = 0;

                    ////表示させるフォームのインスタンスを作成
                    //frmUserAccount f = new frmUserAccount(pb2com);
                    //runF = f;   //フォームオブジェクトを退避

                    setMainPanelform("BF_UserAccount2.exe", "B2.BestFunction.frmUserAccount");
                    //setMainPanelform("BF_UserAccount2.exe", "frmUserAccount");
                    

                    break;

                default:
                    MessageBox.Show("何も設定されていません");
                    break;
            }

            //if (runF == null) return;

            ////TopLevelをFalseにする
            //runF.TopLevel = false;

            //setMainPanelform(runF);

            ////最前面へ移動
            //runF.BringToFront();

            ////----------------------------------------------------------------------
            //// イベントハンドラの追加（コールバックイベントの追加）
            ////----------------------------------------------------------------------
            //runF.MyProgressEvent += new frmBFForm.MyEventHandler(CallBackEventProgress);

            ////フォームを表示する
            //runF.Show();
        }

        //----------------------------------------------------------------------
        // コールバックイベント　from frmUserAccount
        //----------------------------------------------------------------------
        private void CallBackEventProgress(frmBFForm.MyEventArgs e)
        {
    
            //MessageBox.Show(e.commandNumValue.ToString() + ":" + e.commandStringValue);

            switch (e.commandNumValue)
            {
                case 99999:  //ユーザアカウント
                    runF = null;

                    //ユーザアカウント保守が終了したのでユーザーコントロールを表示
                    button5.PerformClick();
                    break;

                default:
                    MessageBox.Show("何も設定されていません");
                    break;
            }

        }

    }
}
