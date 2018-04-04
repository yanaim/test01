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
using System.Data.Linq;
using System.Data.Entity;
//
using FarPoint.Win;
using FarPoint.Win.Spread;
using FarPoint.Win.Spread.Model;
using FarPoint.Win.Spread.CellType;
//
using Npgsql;
using NpgsqlTypes;

using B2.Com;
using B2.BestFunction;

#region 修正履歴
/*
 *  20180109　初版
 */
#endregion

namespace B2.BestFunction
{
    public partial class frmMain : Form
    {
        #region 機能概要
        /*
        *  ログイン情報 ユーザーアカウントマスタメンテ機能　メイン画面
        */
        #endregion

        #region グローバル定義
        //＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝
        // グローバル変数定義
        //＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝

        #endregion

        #region ローカル定義
        //＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝
        // ローカル定義
        //＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝
   
        //-----------------------------------------------
        // 共通パラメータ
        //-----------------------------------------------
        clsB2Com pb2com;

        //-----------------------------------------------
        // データコンテキスト
        //-----------------------------------------------
        private pgAccessModel dbc = null;
        private DbContextTransaction tran = null;    

        //データアダプター　使用予定なし
        //NpgsqlDataAdapter nAdp;

        //-----------------------------------------------
        /// <summary>Spreadの列インデックス</summary>
        //-----------------------------------------------
        private enum SpreadColum
        {
            user_id = 0,
            password,
            pds_id,
            mail_address,
            yakkyoku_code,
            kengen,
            account_rank,
            account_kubun,
            account_sakujo_flag,
            account_teishi_flag,
            unei_comment,
            keiyaku_ymd,
            kaijo_ymd,
            insert_user_id,
            insert_nitiji,
            update_user_id,
            update_nitiji,
            update_program_id
        }

        //-----------------------------------------------
        /// <summary>Spreadの列属性</summary>
        //-----------------------------------------------
        List<fspColumdata> spread_list = new List<fspColumdata>
        {
            new fspColumdata(){colum_position = (int)SpreadColum.user_id, 
                               colum_width_size = 150,
                               colum_label = "ユーザID",
                               hyouji_umu=true, 
                               font_name="MS UI Gothic",
                               font_size=8,  
                               suicyoku_ichi=0,
                               suihei_ichi=0,
                               cellType=0,  
                               ketasu=3,     
                               syousuu=0,      
                               ketakugiri=false,  
                               orikaeshi=false },
            
            new fspColumdata(){colum_position = (int)SpreadColum.password, 
                               colum_width_size = 150,
                               colum_label = "パスワード",
                               hyouji_umu=true, 
                               font_name="MS UI Gothic",
                               font_size=8,  
                               suicyoku_ichi=1,
                               suihei_ichi=1,
                               cellType=0,  
                               ketasu=3,     
                               syousuu=0,      
                               ketakugiri=false,  
                               orikaeshi=false },

            new fspColumdata(){colum_position = (int)SpreadColum.pds_id, 
                               colum_width_size = 150,
                               colum_label = "ＰＤＳ＿ＩＤ",
                               hyouji_umu=true, 
                               font_name="MS UI Gothic",
                               font_size=8,  
                               suicyoku_ichi=2,
                               suihei_ichi=2,
                               cellType=1,  
                               ketasu=3,     
                               syousuu=1,      
                               ketakugiri=false,  
                               orikaeshi=false },

            new fspColumdata(){colum_position = (int)SpreadColum.mail_address, 
                               colum_width_size = 150,
                               colum_label = "Ｅメールアドレス",
                               hyouji_umu=true, 
                               font_name="MS UI Gothic",
                               font_size=8,  
                               suicyoku_ichi=0,
                               suihei_ichi=0,
                               cellType=0,  
                               ketasu=3,     
                               syousuu=0,      
                               ketakugiri=false,  
                               orikaeshi=false },

            new fspColumdata(){colum_position = (int)SpreadColum.yakkyoku_code, 
                               colum_width_size = 150,
                               colum_label = "薬局コード",
                               hyouji_umu=true, 
                               font_name="MS UI Gothic",
                               font_size=8,  
                               suicyoku_ichi=0,
                               suihei_ichi=0,
                               cellType=0,  
                               ketasu=3,     
                               syousuu=0,      
                               ketakugiri=false,  
                               orikaeshi=false },

            new fspColumdata(){colum_position = (int)SpreadColum.kengen, 
                               colum_width_size = 150,
                               colum_label = "権限",
                               hyouji_umu=true, 
                               font_name="MS UI Gothic",
                               font_size=8,  
                               suicyoku_ichi=0,
                               suihei_ichi=0,
                               cellType=0,  
                               ketasu=3,     
                               syousuu=0,      
                               ketakugiri=false,  
                               orikaeshi=false },

            new fspColumdata(){colum_position = (int)SpreadColum.account_rank, 
                               colum_width_size = 150,
                               colum_label = "アカウントランク",
                               hyouji_umu=true, 
                               font_name="MS UI Gothic",
                               font_size=8,  
                               suicyoku_ichi=0,
                               suihei_ichi=0,
                               cellType=0,  
                               ketasu=3,     
                               syousuu=0,      
                               ketakugiri=false,  
                               orikaeshi=false },


            new fspColumdata(){colum_position = (int)SpreadColum.account_kubun, 
                               colum_width_size = 150,
                               colum_label = "アカウント区分",
                               hyouji_umu=true, 
                               font_name="MS UI Gothic",
                               font_size=8,  
                               suicyoku_ichi=0,
                               suihei_ichi=0,
                               cellType=0,  
                               ketasu=3,     
                               syousuu=0,      
                               ketakugiri=false,  
                               orikaeshi=false },

            new fspColumdata(){colum_position = (int)SpreadColum.account_sakujo_flag, 
                               colum_width_size = 150,
                               colum_label = "アカウント削除フラグ",
                               hyouji_umu=true, 
                               font_name="MS UI Gothic",
                               font_size=8,  
                               suicyoku_ichi=0,
                               suihei_ichi=0,
                               cellType=0,  
                               ketasu=3,     
                               syousuu=0,      
                               ketakugiri=false,  
                               orikaeshi=false },

            new fspColumdata(){colum_position = (int)SpreadColum.account_teishi_flag, 
                               colum_width_size = 150,
                               colum_label = "アカウント停止フラグ",
                               hyouji_umu=true, 
                               font_name="MS UI Gothic",
                               font_size=8,  
                               suicyoku_ichi=0,
                               suihei_ichi=0,
                               cellType=0,  
                               ketasu=3,     
                               syousuu=0,      
                               ketakugiri=false,  
                               orikaeshi=false },

            new fspColumdata(){colum_position = (int)SpreadColum.unei_comment, 
                               colum_width_size = 150,
                               colum_label = "運営コメント",
                               hyouji_umu=true, 
                               font_name="MS UI Gothic",
                               font_size=8,  
                               suicyoku_ichi=0,
                               suihei_ichi=0,
                               cellType=0,  
                               ketasu=3,     
                               syousuu=0,      
                               ketakugiri=false,  
                               orikaeshi=false },

            new fspColumdata(){colum_position = (int)SpreadColum.keiyaku_ymd, 
                               colum_width_size = 150,
                               colum_label = "契約年月日",
                               hyouji_umu=true, 
                               font_name="MS UI Gothic",
                               font_size=8,  
                               suicyoku_ichi=0,
                               suihei_ichi=0,
                               cellType=0,  
                               ketasu=3,     
                               syousuu=0,      
                               ketakugiri=false,  
                               orikaeshi=false },

            new fspColumdata(){colum_position = (int)SpreadColum.kaijo_ymd, 
                               colum_width_size = 150,
                               colum_label = "解除年月日",
                               hyouji_umu=true, 
                               font_name="MS UI Gothic",
                               font_size=8,  
                               suicyoku_ichi=0,
                               suihei_ichi=0,
                               cellType=0,  
                               ketasu=3,     
                               syousuu=0,      
                               ketakugiri=false,  
                               orikaeshi=false },

            new fspColumdata(){colum_position = (int)SpreadColum.insert_user_id, 
                               colum_width_size = 150,
                               colum_label = "登録者ＩＤ",
                               hyouji_umu=true, 
                               font_name="MS UI Gothic",
                               font_size=8,  
                               suicyoku_ichi=0,
                               suihei_ichi=0,
                               cellType=0,  
                               ketasu=3,     
                               syousuu=0,      
                               ketakugiri=false,  
                               orikaeshi=false },

            new fspColumdata(){colum_position = (int)SpreadColum.insert_nitiji, 
                               colum_width_size = 150,
                               colum_label = "登録日時",
                               hyouji_umu=true, 
                               font_name="MS UI Gothic",
                               font_size=8,  
                               suicyoku_ichi=0,
                               suihei_ichi=0,
                               cellType=0,  
                               ketasu=3,     
                               syousuu=0,      
                               ketakugiri=false,  
                               orikaeshi=false },

            new fspColumdata(){colum_position = (int)SpreadColum.update_user_id, 
                               colum_width_size = 150,
                               colum_label = "更新者ＩＤ",
                               hyouji_umu=true, 
                               font_name="MS UI Gothic",
                               font_size=8,  
                               suicyoku_ichi=0,
                               suihei_ichi=0,
                               cellType=0,  
                               ketasu=3,     
                               syousuu=0,      
                               ketakugiri=false,  
                               orikaeshi=false },

            new fspColumdata(){colum_position = (int)SpreadColum.update_nitiji, 
                               colum_width_size = 150,
                               colum_label = "更新日時",
                               hyouji_umu=true, 
                               font_name="MS UI Gothic",
                               font_size=8,  
                               suicyoku_ichi=0,
                               suihei_ichi=0,
                               cellType=0,  
                               ketasu=3,     
                               syousuu=0,      
                               ketakugiri=false,  
                               orikaeshi=false },

            new fspColumdata(){colum_position = (int)SpreadColum.update_program_id, 
                               colum_width_size = 150,
                               colum_label = "更新プログラムＩＤ",
                               hyouji_umu=true, 
                               font_name="MS UI Gothic",
                               font_size=8,  
                               suicyoku_ichi=0,
                               suihei_ichi=0,
                               cellType=0,  
                               ketasu=3,     
                               syousuu=0,      
                               ketakugiri=false,  
                               orikaeshi=false }
　　　　};


        #endregion
        
        #region 初期処理

        /// <summary>
        /// コンストラクタ デフォルト
        /// </summary>     
        public frmMain()
        {
            InitializeComponent();
        }
        /// <summary>
        /// コンストラクタ BestFunction用
        /// </summary>
        /// <param name="b2com">B2共通パラメータ</param>
        public frmMain(clsB2Com b2com)
        {
            //共通パラメータのセット
            pb2com = b2com;

            //コントロールの初期化
            InitializeComponent();
        }
        #endregion 

        #region メインフォームのイベント処理
        /// <summary>
        /// Loadイベント時の処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>     
        private void frmMain_Load(object sender, EventArgs e)
        {
            try
            {
                //
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

        /// <summary>
        /// 表示イベント時の処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMain_Shown(object sender, EventArgs e)
        {
            try
            {
                //--------------------------------------
                // 初期化
                //--------------------------------------
                //プログラムタイトルの設定
                clsBfCom bfcom = new clsBfCom();
                this.Text = bfcom.getProgramName(pb2com);

                //背景色等の設定
                pb2com.gfncSetBackColor(this);

                //編集・表示領域の初期化
                InitializeEditArea();

                //Sample
                ////コンボボックス用の設定 
                //gcComboBox1.Init(pb2com, "user_account", "pds_id", "password");
                //gcComboBox1.SelectedIndex = 0;

                //データベースへの接続：データコンテキストのインスタンス化　
                dbc = new pgAccessModel(pb2com);

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

       /// <summary>
        /// 編集・表示領域の初期化
        /// </summary>
        private void InitializeEditArea()
        {
            InitializeAllControls(split2.Panel2);
        }
        /// <summary>
        /// コントロールの初期化
        /// </summary>
        /// <param name="pctrl"></param>
        /// <returns></returns>
        private static List<Control> InitializeAllControls(Control pctrl)
        {
            List<Control> llst = new List<Control>();

            try
            {
                //-----------------------------------------------------------------------------
                // ■ 子コントロール分LOOP
                //-----------------------------------------------------------------------------
                foreach (Control c in pctrl.Controls)
                {
                    //-------------------------------------------------------------------------
                    // ■ コントロール名が設定されている場合
                    //-------------------------------------------------------------------------
                    if (!string.IsNullOrEmpty((string)c.Tag) && (string)c.Tag == "Initialize")
                    {
                        //---------------------------------------------------------------------
                        // ■ 設定
                        //---------------------------------------------------------------------

                        if (c is TextBox)
                        {
                            c.Text = "";
                        }
                        else if (c is RichTextBox)
                        {
                            c.Text = "";
                        }
                        else if (c is ListBox)
                        {
                            c.Text = "";
                        }
                        else if (c is ComboBox)
                        {
                        }
                        else if (c is Label)
                        {
                        }
                        else if (c is DateTimePicker)
                        {
                        }
                        else
                        {
                        }

                        //---------------------------------------------------------------------
                        // ■ 再帰設定
                        //---------------------------------------------------------------------
                        InitializeAllControls(c);                                  // 再帰
                    }
                }

                return llst;
            }
            catch (Exception)
            {
                return llst;
            }
        }



        #endregion

        #region 終了処理
        /// <summary>
        /// 終了処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (MessageBox.Show(this.Text + "を終了します。\r\nよろしいですか？", "確認", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) != DialogResult.Yes)
                {
                    //プログラム終了ログの出力
                    pb2com.WriteSysLog(clsB2Com.EXCD_EXIT, pb2com.DB_User, "プログラムを終了します。");

                    e.Cancel = true;
                    return;
                }

            }
            catch (Exception)
            {
                return;
            }
        }
        #endregion

        #region メインフォーム、編集コントロールの処理（イベントに対応）
        #endregion

        #region InputMan コンボボックス　使用サンプル
        ///// <summary>
        ///// コードからインデックス値を取得
        ///// </summary>
        ///// <param name="CODE"></param>
        ///// <returns></returns>
        //private int getCnvCodeToIndex(string CODE)
        //{
        //    return gcComboBox1.getIndex(CODE);
        //}

        ///// <summary>
        ///// インデックス値からコードを取得
        ///// </summary>
        ///// <param name="INDEX"></param>
        ///// <returns></returns>
        //private string getCnvIndexToCode(int INDEX)
        //{
        //    string str_rc = string.Empty;
        //    if (INDEX < 0) return str_rc;
        //    return gcComboBox1.getCode(INDEX);
        //}

        ///// <summary>
        ///// コンボボックスでキーが押下された時
        ///// </summary>
        ///// <param name="sender"></param>
        ///// <param name="e"></param>
        //private void gcComboBox1_KeyDown(object sender, KeyEventArgs e)
        //{
        //    //Enterキーが押された時
        //    switch (e.KeyCode)
        //    {
        //        // エンターキー
        //        case Keys.Enter:
        //            e.Handled = true;

        //            if (gcComboBox1.SelectedIndex < 0) return;

        //            decimal p_no = decimal.Parse(getCnvIndexToCode(gcComboBox1.SelectedIndex));

        //            //スプレッド初期化
        //            //mfnc_setInitialize();

        //            break;
        //    }

        //}

        ///// <summary>
        ///// コンボボックスで選択値が変化した時
        ///// </summary>
        ///// <param name="sender"></param>
        ///// <param name="e"></param>
        //private void gcComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (gcComboBox1.SelectedIndex < 0) return;

        //    decimal p_no = decimal.Parse(getCnvIndexToCode(gcComboBox1.SelectedIndex));

        //    //スプレッド初期化
        //    //mfnc_setInitialize();

        //}
        #endregion

        #region スプレッドの制御、処理
        /// <summary>スプレッド標準キー を無効にし上位へスルー通知を行う処理</summary>
        /// <param name="pspdObj">スプレッドシートインスタンス</param>
        /// <returns>true：正常終了　false：エラー</returns>
        /// <remark>
        /// 各起動時に実行してください。
        /// TAB：フォーカス移動用にします
        /// ESC：通常画面の終了に使用します など
        /// 
        /// ※　スプレッド読み取り専用の場合必要なし(OperationModeの設定だけ)
        /// 　　標準でキーを取得したい場合に使用します
        /// </remark>
        public static bool InitDispInputMap(FpSpread pspdObj)
        {
            try
            {
                InputMap im = new InputMap();

                //【非編集セル】での［Enter］キーを「次行へ移動」とします
                // WhenFocused 入力マップ 
                // コントロールにフォーカスがある場合（セル非編集モード）
                //     im = pspdObj.GetInputMap(FarPoint.Win.Spread.InputMapMode.WhenFocused);
                //im.Put(new Keystroke(Keys.Enter, Keys.None), SpreadActions.MoveToNextRow);    // Enter  次の行
                //     im.Put(new Keystroke(Keys.Enter, Keys.None), SpreadActions.None);        // Enter　何もしない
                //     im.Put(new Keystroke(Keys.Down, Keys.None), SpreadActions.None);         //  ↓ 　 何もしない

                //【編集中セル】での［Enter］キーを「次行へ移動」とします
                // WhenAncestorOfFocused 入力マップ 
                // コントロールまたはその子にフォーカスがある場合（セル編集モード）　
                im = pspdObj.GetInputMap(FarPoint.Win.Spread.InputMapMode.WhenAncestorOfFocused);
                //im.Put(new Keystroke(Keys.Enter, Keys.None), SpreadActions.None);               // Enter　何もしない
                //im.Put(new Keystroke(Keys.Down, Keys.Alt), SpreadActions.None);                 // ALT + ↓ 　何もしない
                //im.Put(new Keystroke(Keys.Down, Keys.None), SpreadActions.None);                //  ↓ 　何もしない
                //im.Put(new Keystroke(Keys.Enter, Keys.None), SpreadActions.MoveToNextRow);      // Enter  次の行
                //im.Put(new Keystroke(Keys.Tab, Keys.None), SpreadActions.None);                 // TAB
                //im.Put(new Keystroke(Keys.Tab, Keys.Shift, false), SpreadActions.None);         // TAB + Shift
                im.Put(new Keystroke(Keys.Escape, Keys.None), SpreadActions.None);            // ESC
                im.Put(new Keystroke(Keys.F1, Keys.None), SpreadActions.None);                // F1
                im.Put(new Keystroke(Keys.F2, Keys.None), SpreadActions.None);                // F2
                im.Put(new Keystroke(Keys.F3, Keys.None), SpreadActions.None);                // F3
                im.Put(new Keystroke(Keys.F4, Keys.None), SpreadActions.None);                // F4
                im.Put(new Keystroke(Keys.F5, Keys.None), SpreadActions.None);                // F5
                im.Put(new Keystroke(Keys.F6, Keys.None), SpreadActions.None);                // F6
                im.Put(new Keystroke(Keys.F7, Keys.None), SpreadActions.None);                // F7
                im.Put(new Keystroke(Keys.F8, Keys.None), SpreadActions.None);                // F8
                im.Put(new Keystroke(Keys.F9, Keys.None), SpreadActions.None);                // F9
                im.Put(new Keystroke(Keys.F10, Keys.None), SpreadActions.None);               // F10
                im.Put(new Keystroke(Keys.F11, Keys.None), SpreadActions.None);               // F11
                im.Put(new Keystroke(Keys.F12, Keys.None), SpreadActions.None);               // F12

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }


        /// <summary>
        /// 明細クリア ???
        /// </summary>
        private void ClearMain()
        {
            // 明細行数の設定
            fpS1.ActiveSheet.RowCount = 0;

            //空明細をクリア
            for (int i = 0; i < fpS1.ActiveSheet.RowCount; i++)
            {
                for (int j = 0; j < fpS1.ActiveSheet.ColumnCount; j++)
                {
                    //クリア
                    fpS1.ActiveSheet.Cells[i, j].Text = "";
                    fpS1.ActiveSheet.Cells[i, j].Value = 0;

                    //セル毎にLOCK
                    fpS1.ActiveSheet.Cells[i, j].Locked = true;
                }
            }
            fpS1.Refresh();
        }

        /// <summary>
        /// スプレッドの初期化
        /// </summary>
        private void setSpreadInitialize()
        {
            try
            {
                //--------------------------------------
                // Spread 表示セルを初期化（クリア）
                //--------------------------------------
        //        ClearMain();

                //--------------------------------------
                // 操作モードの設定
                //--------------------------------------
                fpS1.ActiveSheet.OperationMode = OperationMode.Normal;
                fpS1.HorizontalScrollBarPolicy = ScrollBarPolicy.AsNeeded;
                fpS1.VerticalScrollBarPolicy = ScrollBarPolicy.AsNeeded;
                fpS1.ClipboardOptions = FarPoint.Win.Spread.ClipboardOptions.NoHeaders;
                fpS1.ActiveSheet.ClipboardPaste(FarPoint.Win.Spread.ClipboardPasteOptions.Values);

                //--------------------------------------
                // セルを選択した時のヘッダのハイライト表示を抑制
                //--------------------------------------
                FarPoint.Win.Spread.CellType.EnhancedColumnHeaderRenderer lcolRenderer = new FarPoint.Win.Spread.CellType.EnhancedColumnHeaderRenderer();
                lcolRenderer.SelectedActiveBackgroundColor = Color.FromArgb(195, 202, 214);
                lcolRenderer.SelectedBackgroundColor = Color.FromArgb(215, 223, 235);
                lcolRenderer.SelectedGridLineColor = Color.FromArgb(158, 182, 206);
                fpS1.ActiveSheet.ColumnHeader.DefaultStyle.Renderer = lcolRenderer;

                //--------------------------------------
                // OperationMode制御時にセル背景色が変わらないようにする
                //--------------------------------------
                //                fpS1.ActiveSheet.SelectionBackColor = Color.Empty;
                //                fpS1.ActiveSheet.SelectionStyle = FarPoint.Win.Spread.SelectionStyles.SelectionColors;

                ////--------------------------------------
                //// 行数列数設定
                ////--------------------------------------
                //fpS1.ActiveSheet.ColumnHeader.RowCount = 1;
                //fpS1.ActiveSheet.RowCount = 0;
                //fpS1.ActiveSheet.ColumnCount = (int)SpreadColum.update_program_id + 1;
                ////fpS1.ActiveSheet.ColumnHeader.Columns. = fpSMain.ActiveSheet.GetPreferredRowHeight(i);

                //--------------------------------------
                // Columnパラメータ 設定
                //--------------------------------------
                //fpS1.ActiveSheet.Columns[(int)SpreadColum.pds_id].Locked = true;
                //fpS1.ActiveSheet.Columns[(int)SpreadColum.mail_address].Locked = true;

                //列幅設定
                setSpreadInfo();


                //--------------------------------------
                // 一覧表再描画
                //--------------------------------------
                fpS1.Refresh();
            }
            catch (Exception ex)
            {
                pb2com.ShowErrMsg(ex);
            }
        }

        /// <summary>
        /// スプレッドの列属性設定　列幅など
        /// </summary>
        private void setSpreadInfo()
        {
            ////行ヘッダーの列幅
            //fpS1.ActiveSheet.RowHeader.Columns[0].Width = 25;
            //fpS1.ActiveSheet.RowHeader.Columns[0].Font = new Font("MS UI Gothic", 8);
            //fpS1.ActiveSheet.RowHeader.Columns[0].HorizontalAlignment = CellHorizontalAlignment.Right;
            ////fpS1.ActiveSheet.RowHeader.Columns[0].HorizontalAlignment = CellHorizontalAlignment.Center;

            //// 列の非表示設定 sample
            //fpS1.ActiveSheet.Columns[(int)SpreadColum.user_id].Visible = false;


            ////列幅,他の設定 sample
            //fpS1.ActiveSheet.Columns[(int)SpreadColum.user_id].Width = (float)40;

            ////　テキスト型セル　折り返し無し
            //FarPoint.Win.Spread.CellType.TextCellType textcell_row = new FarPoint.Win.Spread.CellType.TextCellType();
            //textcell_row.WordWrap = false;

            ////  テキスト型セル　折り返し有り
            //FarPoint.Win.Spread.CellType.TextCellType textcell_rows = new FarPoint.Win.Spread.CellType.TextCellType();
            //textcell_rows.Multiline = true;         //改行の入力　Shift+Enterが可能となる。　シフト無しでもOKだった。確定はフォーカスを外すこと。
            //textcell_rows.WordWrap = true;
            //textcell_rows.MaxLength = 2000;         //デフォルトで切られていた為、DBの最大サイズとした。

            ////小数点、桁区切りの設定  
            //// 0
            //FarPoint.Win.Spread.CellType.NumberCellType lobjCellTypeNumberDecimalPlaces0 = new FarPoint.Win.Spread.CellType.NumberCellType();
            //lobjCellTypeNumberDecimalPlaces0.DecimalPlaces = 0;
            //lobjCellTypeNumberDecimalPlaces0.ShowSeparator = false;
            //lobjCellTypeNumberDecimalPlaces0.MaximumValue = 99999999;

            //// 1
            //FarPoint.Win.Spread.CellType.NumberCellType lobjCellTypeNumberDecimalPlaces1 = new FarPoint.Win.Spread.CellType.NumberCellType();
            //lobjCellTypeNumberDecimalPlaces1.DecimalPlaces = 1;
            //lobjCellTypeNumberDecimalPlaces1.ShowSeparator = true;

            //// 2
            //FarPoint.Win.Spread.CellType.NumberCellType lobjCellTypeNumberDecimalPlaces2 = new FarPoint.Win.Spread.CellType.NumberCellType();
            //lobjCellTypeNumberDecimalPlaces2.DecimalPlaces = 2;
            //lobjCellTypeNumberDecimalPlaces2.ShowSeparator = true;

            ////CELL タイプの設定
            //fpS1.ActiveSheet.Columns[(int)SpreadColum.user_id].CellType = (FarPoint.Win.Spread.CellType.NumberCellType)lobjCellTypeNumberDecimalPlaces0.Clone();
            ////パディング設定
            //fpS1.ActiveSheet.Columns[(int)SpreadColum.user_id].CellPadding.Left = (int)5;
            ////水平位置
            //fpS1.ActiveSheet.Columns[(int)SpreadColum.user_id].HorizontalAlignment = CellHorizontalAlignment.Center;


            ////行の高さを設定
            //int rows_count = fpS1.ActiveSheet.RowCount;
            //for (int i = 0; i < rows_count; i++)
            //{
            //    // 最も高さのあるテキストの高さに設定します
            //    fpS1.ActiveSheet.Rows[i].Height = (rows_hight > fpS1.ActiveSheet.GetPreferredRowHeight(i) ? rows_hight : fpS1.ActiveSheet.GetPreferredRowHeight(i));
            //}

            ////列を追加

            //列情報の設定 : NG
            clsSpread.setSpreadColumInfo(fpS1.ActiveSheet, spread_list);

            //奇数行、偶数行の背景色設定 : OK
            clsSpread.SetColorAlternating(fpS1.ActiveSheet);

            //固定列数の設定 : +1でOK
            clsSpread.SetFrozenColumn(fpS1.ActiveSheet, (int)SpreadColum.user_id + 1);

        }
    
        
        
        
        #endregion

        #region メニュー（ファンクションに対応した処理）

        private void 取消終了ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if(tran != null)
                {
                    //ロールバック
                    tran.Rollback();
                    tran = null;
                }

                //--------------------------------------
                // ※終了確認はFormClosingにて実施
                //--------------------------------------
                this.Close();
            }
            catch (NpgsqlException ex)
            {
                pb2com.ShowErrMsg(ex);
                return;
            }
            catch (Exception ex)
            {
                pb2com.ShowErrMsg(ex);
            }

        }

        private void 終了ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (tran != null)
                {
                    //データ更新
                    dbc.SaveChanges();

                    //コミット
                    tran.Commit();
                    tran = null;
                }

                //--------------------------------------
                // ※終了確認はFormClosingにて実施
                //--------------------------------------
                this.Close();
            }
            catch (NpgsqlException ex)
            {
                pb2com.ShowErrMsg(ex);
                return;
            }
            catch (Exception ex)
            {
                pb2com.ShowErrMsg(ex);
            }
        }

        private void 新規ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                if (tran == null)
                {
                    //トランザクションスタート
                    tran = dbc.Database.BeginTransaction();
                }
                
                //レコードの作製                
                var data = dbc.UserAccount.Create();

                //初期値の設定
 //               data.UserId = 0;
                data.Password = "";
                data.PdsId = "";
                data.MailAddress = "";
                data.YakkyokuCode = "";
                data.Kengen = "";
                data.AccountRank = "";
                data.AccountKubun = "";
                data.AccountSakujoFlag = "";
                data.AccountTeishiFlag = "";
                data.UneiComment = "";
                data.KeiyakuYmd = "";
                data.KaijoYmd = "";
                data.InsertUserId = 0;
                data.InsertNitiji = DateTime.Now;
                data.UpdateUserId = 0;
                data.UpdateNitiji = DateTime.Now;
                string wkProgramId = System.Diagnostics.Process.GetCurrentProcess().ProcessName;
                data.UpdateProgramId = wkProgramId.Length > 20 ? wkProgramId.Substring(0, 20) : wkProgramId;


                //データソースへ追加
                userAccountBindingSource.Add(data);
                userAccountBindingSource.ResetBindings(true);

                //fpS1.Show();

                //列幅設定
                //mfnc_SetSpreadInfo();

                //行の高さを設定
                clsSpread.SetRowsHeight(fpS1.ActiveSheet);

                //スプレッドの最下行にフォーカスをあてる
                clsSpread.SetCellFocus(fpS1, (fpS1.ActiveSheet.RowCount - 1), (int)SpreadColum.user_id);

                //編集エリアの先頭にフォーカスをあてる
                yakkyokuCodeTextBox.Focus();

            }
            catch (NpgsqlException ex)
            {
                pb2com.ShowErrMsg(ex);
                return;
            }
            catch (Exception ex)
            {
                pb2com.ShowErrMsg(ex);
            }
        }

        private void 訂正ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (tran == null)
                {
                    //トランザクションスタート
                    tran = dbc.Database.BeginTransaction();
                }

            }
            catch (NpgsqlException ex)
            {
                pb2com.ShowErrMsg(ex);
                return;
            }
            catch (Exception ex)
            {
                pb2com.ShowErrMsg(ex);
                return;
            }

        }

        private void 削除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (tran == null)
                {
                    //トランザクションスタート
                    tran = dbc.Database.BeginTransaction();
                }

                //スプレッドからの削除処理
                int index = fpS1.ActiveSheet.ActiveRowIndex;
                fpS1.ActiveSheet.Rows.Remove(index, 1);
            }
            catch (NpgsqlException ex)
            {
                pb2com.ShowErrMsg(ex);
                return;
            }
            catch (Exception ex)
            {
                pb2com.ShowErrMsg(ex);
                return;
            }
        }

        private void 更新ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                if (tran != null)
                {
                    //データ更新
                    dbc.SaveChanges();

                    //コミット
                    tran.Commit();
                    tran = null;

                    //更新後　再検索
                    検索ToolStripMenuItem.PerformClick();

                }

                //スプレッド初期化(クリア）
                //mfnc_setInitialize();

            }
            catch (NpgsqlException ex)
            {
                pb2com.ShowErrMsg(ex);
                return;
            }
            catch (Exception ex)
            {
                pb2com.ShowErrMsg(ex);
                return;
            }

        }

        private void 検索ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                //レコード数をセット
            　　//fpS1.ActiveSheet.RowCount = 0;
                

                //データの読込
                if(dbc != null)
                {
                    //再読込時は前回のデータを破棄する必要があるようだ！
                    dbc.Dispose();
                }
                //データベースへの接続
                dbc = new pgAccessModel(pb2com);

                //データの読込
                dbc.UserAccount.Where(x => x.YakkyokuCode == txtYakkyokuCode.Text).OrderBy(x => x.UserId).Load();
                
                //スプレッドにデータセットをセット
                userAccountBindingSource.DataSource = dbc.UserAccount.Local;

                //レコード数をセット
                //fpS1.ActiveSheet.RowCount = dbc.UserAccount.Local.Count;


                // 再描画
                //fpS1.Refresh();
                //fpS1.ResumeLayout(true);

                //スプレッドの初期設定
                setSpreadInitialize();

                //スプレッドの行の高さを揃える　：　OK
                clsSpread.SetRowsHeight(fpS1.ActiveSheet);
             
                //ボタン制御
                // なし

                // Spread キーの透過設定　
                InitDispInputMap(fpS1);

                // 直接編集不可とする。
                fpS1.EditMode = false;

                // 読み取り専用
                fpS1.ActiveSheet.OperationMode = FarPoint.Win.Spread.OperationMode.ReadOnly; 

            }
            catch (NpgsqlException ex)
            {
                pb2com.ShowErrMsg(ex);
                return;
            }
            catch (Exception ex)
            {
                pb2com.ShowErrMsg(ex);
                return;
            }
        }

        private void リフレッシュToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ダウンロードToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //PDS-ZEROからダウンロードして登録する
        }

        #endregion

        #region 出力処理
        private void PDF出力ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                //--------------------------------------
                //PDF処理
                //--------------------------------------
                string filter = "PDF files(*.PDF)|*.PDF"; ;

                string fn = "";
                // ファイル保存ダイアログ起動
                using (SaveFileDialog sfd = new SaveFileDialog())
                {
                    sfd.Filter = filter;
                    sfd.FileName = this.Text.ToString() + "_" + DateTime.Now.ToString("yyyyMMdd_HHmmss");
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        fn = sfd.FileName;
                    }
                    else
                    {
                        return;
                    }
                }

                //プリントヘッダー
                fpS1.ActiveSheet.PrintInfo.Header = "/r/fz\"9\"印刷日時：/dl/ts" + Environment.NewLine;

                //プリントフッター
                fpS1.ActiveSheet.PrintInfo.Footer = "";

                //◆PDF出力
                fpS1.ActiveSheet.PrintInfo.PrintToPdf = true;
                fpS1.ActiveSheet.PrintInfo.Orientation = FarPoint.Win.Spread.PrintOrientation.Landscape;
                fpS1.ActiveSheet.PrintInfo.PaperSize = new System.Drawing.Printing.PaperSize("A3", 1169, 1654);
                fpS1.ActiveSheet.PrintInfo.PdfFileName = fn;
                
                //Print Run
                fpS1.PrintSheet(fpS1.ActiveSheetIndex);

            }
            catch (Exception ex)
            {
                pb2com.ShowErrMsg(ex);
            }


        }
        #endregion

        #region ファイル出力処理
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cSV出力ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                //--------------------------------------
                // データが無ければ　戻る
                //--------------------------------------
                if (fpS1.ActiveSheet.RowCount <= 0) { return; }

                clsCnvStr lclsCnvStr = new clsCnvStr();
                string lstrCsv = "";
                string lstrCsvDetail = "";
                string lstrCsvHeader = "";

                //**************************************
                // CSV出力文字作成
                //**************************************
                //--------------------------------------
                // CSVヘッダ部作成
                //--------------------------------------
                lstrCsvHeader = "";
                lstrCsvHeader += this.Text.ToString() + Environment.NewLine;
                lstrCsvHeader += "作成日付:," + DateTime.Today.ToString("yyyy/MM/dd") + Environment.NewLine;
                lstrCsvHeader += "資料名：," + this.Text.ToString() + Environment.NewLine + Environment.NewLine;
                for (int i = 1; i < fpS1.ActiveSheet.ColumnHeader.Columns.Count; i++)
                {
                    lstrCsvHeader += fpS1.ActiveSheet.ColumnHeader.Columns[i].Label + ",";
                }


                //--------------------------------------
                // CSV明細部作成
                //--------------------------------------
                //------------------
                // スプレッドの内容を取得
                //------------------
                lstrCsvDetail = clsSpread.SheetViewToCsv(fpS1.ActiveSheet);

                //--------------------------------------
                // CSV出力文字生成
                //--------------------------------------
                //------------------
                // 明細部 列を右にずらす
                //------------------
                int lintAddColumn = 0;  // ※ずらす列数
                lstrCsvDetail = lstrCsvDetail.Trim().Replace(Environment.NewLine, Environment.NewLine + new string(',', lintAddColumn));
                lstrCsvDetail = new string(',', lintAddColumn) + lstrCsvDetail + Environment.NewLine;

                //------------------
                // ヘッダ部 ＋ 明細部
                //------------------
                lstrCsv = "";
                lstrCsv += lstrCsvHeader;
                //lstrCsv += Environment.NewLine;
                lstrCsv += lstrCsvDetail;
                //**************************************

                //--------------------------------------
                // 『名前を付けて保存』画面表示
                //--------------------------------------
                SaveFileDialog lobjSFD = new SaveFileDialog();
                lobjSFD.FileName = this.Text.ToString() + "_" + DateTime.Today.ToString("yyyyMMdd") + "_" + DateTime.Now.ToString("HHmmss") + "_" + Environment.MachineName + ".csv";
                lobjSFD.Filter = "CSVファイル(*.csv)|*.csv|すべてのファイル(*.*)|*.*";
                if (lobjSFD.ShowDialog() == DialogResult.Cancel)
                {
                    return;
                }

                //--------------------------------------
                // ファイル出力
                //--------------------------------------
                System.IO.Stream lobjStream = lobjSFD.OpenFile();
                System.IO.StreamWriter lobjStreamWriter = new System.IO.StreamWriter(lobjStream, Encoding.GetEncoding("shift_jis"));
                lobjStreamWriter.Write(lstrCsv.Trim() + Environment.NewLine);
                lobjStreamWriter.Close();
                lobjStream.Close();

                //--------------------------------------
                // メッセージ
                //--------------------------------------
                MessageBox.Show("ＣＳＶ出力を完了しました。", this.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ファイル保存に失敗しました。 " + Environment.NewLine + ex.Message);
            }

        }
        #endregion

        #region 編集エリア　コントロールの検証
        ///<summary>
        /// フォーカスが離れるとValidatingイベントが飛び　検証を行う。
        /// 検証が完了し、イベントを中断しなかれば続いてValidatedイベントが通知される。
        /// Validatingイベントで検証処理を行う。
        /// Validatedイベントで正常時の処理を行う。
        ///</summary>

        //薬局コードの検証
        private void yakkyokuCodeTextBox_Validating(object sender, CancelEventArgs e)
        {
            bool error_flag = true;
            if(string.IsNullOrEmpty(yakkyokuCodeTextBox.Text))
            {
                error_flag = false;
            }
            
            if (!error_flag)
            {
                yakkyokuCodeTextBox.BackColor = Color.Red;
                e.Cancel = true;
            }
        }
        //薬局コードの検証完了
        private void yakkyokuCodeTextBox_Validated(object sender, EventArgs e)
        {
            //背景色を白色に設定し次ぎのコントロールへフォーカスを移す
            yakkyokuCodeTextBox.BackColor = Color.White;
            this.SelectNextControl(this.yakkyokuCodeTextBox, true, true, true, true);

        }

        //PDS-IDの検証
        private void pdsIdTextBox_Validating(object sender, CancelEventArgs e)
        {

        }

        //PDS-IDの検証完了
        private void pdsIdTextBox_Validated(object sender, EventArgs e)
        {
            //背景色を白色に設定し次ぎのコントロールへフォーカスを移す
            pdsIdTextBox.BackColor = Color.White;
            this.SelectNextControl(this.pdsIdTextBox, true, true, true, true);

        }

        //パスワードの検証
        private void passwordTextBox_Validating(object sender, CancelEventArgs e)
        {

        }

        //パスワードの検証完了
        private void passwordTextBox_Validated(object sender, EventArgs e)
        {
            //背景色を白色に設定し次ぎのコントロールへフォーカスを移す
            passwordTextBox.BackColor = Color.White;
            this.SelectNextControl(this.passwordTextBox, true, true, true, true);

        }

        //メールアドレスの検証
        private void mailAddressTextBox_Validating(object sender, CancelEventArgs e)
        {

        }

        //メールアドレスの検証完了
        private void mailAddressTextBox_Validated(object sender, EventArgs e)
        {
            //背景色を白色に設定し次ぎのコントロールへフォーカスを移す
            mailAddressTextBox.BackColor = Color.White;
            this.SelectNextControl(this.mailAddressTextBox, true, true, true, true);

        }

        //停止フラグの検証
        private void accountTeishiFlagTextBox_Validating(object sender, CancelEventArgs e)
        {

        }

        //停止フラグの検証完了
        private void accountTeishiFlagTextBox_Validated(object sender, EventArgs e)
        {
            //背景色を白色に設定し次ぎのコントロールへフォーカスを移す
            accountTeishiFlagTextBox.BackColor = Color.White;
            this.SelectNextControl(this.accountTeishiFlagTextBox, true, true, true, true);

        }

        //運用コメントの検証
        private void uneiCommentTextBox_Validating(object sender, CancelEventArgs e)
        {

        }

        //運用コメントの検証完了
        private void uneiCommentTextBox_Validated(object sender, EventArgs e)
        {
            //背景色を白色に設定し次ぎのコントロールへフォーカスを移す
            uneiCommentTextBox.BackColor = Color.White;
            this.SelectNextControl(this.uneiCommentTextBox, true, true, true, true);

        }

        //契約年月日の検証
        private void keiyakuYmdTextBox_Validating(object sender, CancelEventArgs e)
        {

        }

        //契約年月日の検証完了
        private void keiyakuYmdTextBox_Validated(object sender, EventArgs e)
        {
            //背景色を白色に設定し次ぎのコントロールへフォーカスを移す
            keiyakuYmdTextBox.BackColor = Color.White;
            this.SelectNextControl(this.keiyakuYmdTextBox, true, true, true, true);

        }

        //解除年月日の検証
        private void kaijoYmdTextBox_Validating(object sender, CancelEventArgs e)
        {

        }

        //解除年月日の検証完了
        private void kaijoYmdTextBox_Validated(object sender, EventArgs e)
        {
            //背景色を白色に設定し次ぎのコントロールへフォーカスを移す
            kaijoYmdTextBox.BackColor = Color.White;
            this.SelectNextControl(this.kaijoYmdTextBox, true, true, true, true);
        }

        #endregion

        private void fpS1_CellClick(object sender, CellClickEventArgs e)
        {

        }

    }
}
