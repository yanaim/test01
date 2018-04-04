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

using System.Data.Entity;

//

using B2.Com;
using B2.BestFunction;
using Npgsql;
using FarPoint.Win.Spread;




#region 修正履歴
/*
 * 20180216  初版
 */
#endregion


namespace B2_BestFunction
{
    public partial class frmYakuhin : frmBFForm
    {
        #region 機能概要
        /*
         *　薬品マスタ情報画面
         */
        #endregion

        #region グローバル定義
        //====================================================
        //　グローバル変数定義
        //====================================================

        #endregion

        #region ローカル定義
        //====================================================
        // ローカル定義
        //====================================================
        string _keyField = string.Empty;
        string _key = string.Empty;

        //----------------------------------------------------
        // 共通パラメータ
        //----------------------------------------------------
        B2Com pb2com;

        //----------------------------------------------------
        //　データコンテキスト
        //----------------------------------------------------
        private pgAccessModel dbc = null;
        private DbContextTransaction tran = null;

        //データアダプター　使用予定なし
        //NpgsqlDataAdapter nAdp;

        //----------------------------------------------------
        /// <summary>Spreadの列インデックス</summary>
        //----------------------------------------------------
        private enum SpreadColum
        {
            pds_code,
            hot_code,
            hot7_code,
            yj_code,
            kobetsu_iyakuhin_code,
            jan_code,
            gtin_code,
            gtin_code_chozaihosotani,
            yakuhin_mei,
            yakuhin_kana,
            kikaku_tanni,
            housou_keitai,
            housou_tanni_qty,
            housou_tanni_tanni,
            housou_souryou_qty,
            housou_suryou_tanni,
            kubun,
            yakkou_bunrui_mei,
            zaikei_kubun_mei,
            seibun_mei,
            yakka,
            dokuyaku_flag,
            gekiyaku_flag,
            mayaku_flag,
            kakuseizai_flag,
            seibutsugakuteki_seizai_flag,
            zoueizai_flag,
            kouseishinyaku_flag,
            seizou_kaisha_mei,
            hanbai_kaisha_mei,
            kokuji_ymd,
            keika_sochi_ymd,
            hanbai_chushi_ymd,
            apply_start_ymd,
            apply_end_ymd,
            insert_user_id,
            insert_nitiji,
            update_user_id,
            update_nitiji,
            update_program_id,
            kanri_zokusei
        }

 //       const int rows_hight = 40;    //行の高さ
 //      const string YAKUHIN_TB = "YAKUHIN_TB";


        #region  Spreadの列属性
        //----------------------------------------------------
        /// <summary>
        /// Spreadの列属性</summary>
        //----------------------------------------------------
        List<fspColumdata> spread_list = new List<fspColumdata>
        {
            new fspColumdata(){colum_position = (int)SpreadColum.pds_code,
                               colum_width_size = 150,
                               colum_label = "PDSコード",
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
           
            new fspColumdata(){colum_position = (int)SpreadColum.hot_code,
                               colum_width_size = 150,
                               colum_label = "HOTコード",
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

           new fspColumdata(){colum_position = (int)SpreadColum.hot7_code,
                              colum_width_size = 150,
                              colum_label = "HOT7コード",
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

          new fspColumdata(){colum_position = (int)SpreadColum.yj_code,
                             colum_width_size=150,
                             colum_label= "YJコード",
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

          new fspColumdata(){colum_position = (int)SpreadColum.kobetsu_iyakuhin_code,
                             colum_width_size=150,
                             colum_label= "個別医薬品コード",
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

           new fspColumdata(){colum_position = (int)SpreadColum.jan_code,
                             colum_width_size=150,
                             colum_label= "JANコード",
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
     
           new fspColumdata(){colum_position = (int)SpreadColum.gtin_code,
                               colum_width_size = 150,
                               colum_label = "GTIN販売包装単位",
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
           
            new fspColumdata(){colum_position = (int)SpreadColum.gtin_code_chozaihosotani,
                               colum_width_size = 150,
                               colum_label = "GTIN調剤包装単位",
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

           new fspColumdata(){colum_position = (int)SpreadColum.yakuhin_mei,
                              colum_width_size = 150,
                              colum_label = "薬品名",
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

          new fspColumdata(){colum_position = (int)SpreadColum.yakuhin_kana,
                             colum_width_size=150,
                             colum_label= "薬品名フリガナ",
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

          new fspColumdata(){colum_position = (int)SpreadColum.kikaku_tanni,
                             colum_width_size=150,
                             colum_label= "規格単位",
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

           new fspColumdata(){colum_position = (int)SpreadColum.housou_keitai,
                             colum_width_size=150,
                             colum_label= "包装形態",
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

           new fspColumdata(){colum_position = (int)SpreadColum.housou_tanni_qty,
                               colum_width_size = 150,
                               colum_label = "包装単位数",
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
           
            new fspColumdata(){colum_position = (int)SpreadColum.housou_tanni_tanni,
                               colum_width_size = 150,
                               colum_label = "包装単位単位",
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

           new fspColumdata(){colum_position = (int)SpreadColum.housou_souryou_qty,
                              colum_width_size = 150,
                              colum_label = "包装総量数",
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

          new fspColumdata(){colum_position = (int)SpreadColum.housou_suryou_tanni,
                             colum_width_size=150,
                             colum_label= "包装数量単位",
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

          new fspColumdata(){colum_position = (int)SpreadColum.kubun,
                             colum_width_size=150,
                             colum_label= "区分",
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

           new fspColumdata(){colum_position = (int)SpreadColum.yakkou_bunrui_mei,
                             colum_width_size=150,
                             colum_label= "薬効分類名",
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

          new fspColumdata(){colum_position = (int)SpreadColum.zaikei_kubun_mei,
                               colum_width_size = 150,
                               colum_label = "剤形区分名",
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
           
            new fspColumdata(){colum_position = (int)SpreadColum.seibun_mei,
                               colum_width_size = 150,
                               colum_label = "成分名",
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

           new fspColumdata(){colum_position = (int)SpreadColum.yakka,
                              colum_width_size = 150,
                              colum_label = "薬価",
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

          new fspColumdata(){colum_position = (int)SpreadColum.dokuyaku_flag,
                             colum_width_size=150,
                             colum_label= "毒薬フラグ",
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

          new fspColumdata(){colum_position = (int)SpreadColum.gekiyaku_flag,
                             colum_width_size=150,
                             colum_label= "劇薬フラグ",
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

           new fspColumdata(){colum_position = (int)SpreadColum.mayaku_flag,
                             colum_width_size=150,
                             colum_label= "麻薬フラグ",
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

          new fspColumdata(){colum_position = (int)SpreadColum.kakuseizai_flag,
                               colum_width_size = 150,
                               colum_label = "覚醒剤フラグ",
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
           
            new fspColumdata(){colum_position = (int)SpreadColum.seibutsugakuteki_seizai_flag,
                               colum_width_size = 150,
                               colum_label = "生物学的製剤フラグ",
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

           new fspColumdata(){colum_position = (int)SpreadColum.zoueizai_flag,
                              colum_width_size = 150,
                              colum_label = "造影剤フラグ",
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

          new fspColumdata(){colum_position = (int)SpreadColum.kouseishinyaku_flag,
                             colum_width_size=150,
                             colum_label= "向精神薬フラグ",
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

          new fspColumdata(){colum_position = (int)SpreadColum.seizou_kaisha_mei,
                             colum_width_size=150,
                             colum_label= "製造会社名",
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

           new fspColumdata(){colum_position = (int)SpreadColum.hanbai_kaisha_mei,
                             colum_width_size=150,
                             colum_label= "販売会社名",
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

           new fspColumdata(){colum_position = (int)SpreadColum.kokuji_ymd,
                               colum_width_size = 150,
                               colum_label = "告知日",
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
           
            new fspColumdata(){colum_position = (int)SpreadColum.keika_sochi_ymd,
                               colum_width_size = 150,
                               colum_label = "経過措置日",
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

           new fspColumdata(){colum_position = (int)SpreadColum.hanbai_chushi_ymd,
                              colum_width_size = 150,
                              colum_label = "販売中止日",
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

          new fspColumdata(){colum_position = (int)SpreadColum.apply_start_ymd,
                             colum_width_size=150,
                             colum_label= "適用開始年月日",
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

          new fspColumdata(){colum_position = (int)SpreadColum.apply_end_ymd,
                             colum_width_size=150,
                             colum_label= "適用終了年月日",
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
                             colum_width_size=150,
                             colum_label= "登録者ID",
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
                               colum_label = "更新者ID",
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

           new fspColumdata(){colum_position = (int)SpreadColum.update_nitiji,
                              colum_width_size = 150,
                              colum_label = "更新日時",
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

          new fspColumdata(){colum_position = (int)SpreadColum.update_program_id,
                             colum_width_size=150,
                             colum_label= "更新プログラムID",
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

          new fspColumdata(){colum_position = (int)SpreadColum.kanri_zokusei,
                             colum_width_size=150,
                             colum_label= "管理属性",
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



        #endregion

        #region 初期処理
        /// <summary>
        /// コンストラクタ　デフォルト
        /// </summary>
        public frmYakuhin()
        {
            InitializeComponent();
        }
        /// <summary>
        ///  コンストラクタ　BestFunction用
        ///  </summary>
        ///  <param name="b2com">B2共通パラメータ</param>
        public frmYakuhin(B2Com b2com)
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
                pb2com.WriteSysLog(B2Com.EXCD_START, pb2com.DB_User, "プログラムを開始します。");

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
                //-----------------------------------------
                //初期化
                //-----------------------------------------
                //プログラムタイトルの設定
                BfCom bfcom = new BfCom();
                this.Text = bfcom.getProgramName(pb2com);

                //背景色等の設定
                pb2com.SetBackColor(this);

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
   //                  InitializeAllControls(split2.Panel2);
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
                         //-------------------------------------------------------------------
                         // ■子コントロール分LOOP
                         //-------------------------------------------------------------------
                         foreach (Control c in pctrl.Controls)
                         {
                             //---------------------------------------------------------------
                             //■コントロール名が設定されている場合
                             //---------------------------------------------------------------
                             if (!string.IsNullOrEmpty((string)c.Tag) && (string)c.Tag == "Initialize")
                            {
                                 //-----------------------------------------------------------------
                                 //■　設定
                                 //-----------------------------------------------------------------

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

                                //------------------------------------------------------------------
                               //■再帰設定
                               //------------------------------------------------------------------
                               InitializeAllControls(c);                                //再帰
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
                if (MessageBox.Show("薬品マスタ" + "を終了します。\r\nよろしいですか？", "確認", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) != DialogResult.Yes)
                {
                    e.Cancel = true;

                    return;
                }

                //プログラム終了ログの出力
                pb2com.WriteSysLog(B2Com.EXCD_EXIT, pb2com.DB_User, "プログラムを終了します。");
                base.UpdateProgress(99999, "薬品マスタを終了します。");
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

        ///// <returns></return>
        //private int getCnvCodeToIndex(string CODE)
        //{
        //      return gcComboBox1.getIndex(CODE);
        //}

        ///// <summary>
        ///// インデックス値からコードを取得
        ///// </summary>
        ///// <param name="INDEX"></param>
        ///// <returns></returns>
        //private string getCnvIndexToCode(int INDEX)
        //{
        //      string str rc = string.Empty;
        //      if (INDEX < 0) return str_rc;
        //      return gcComboBox1.getCode(INDEX);
        //}

        ///// <summary>
        ///// コンボボックスでキーが押下された時
        ///// </summary>
        ///// <param name="sender"></param>
        ///// <param name="e"></param>
        //private void gcComboBox1_keyDown(object sender, keyEventArgs e)
        //{
        //      //Enterキーが押された時
        //      switch (e.keyCode)
        //      {
        //          //エンターキー
        //          case keys.Enter:
        //              e.Handles = true;

        //              if(gcComboBox1.SelectedIndex < 0) return;

        //              decimal p_no = decimal.Parse(getCnvIndexToCode(gcComboBox1.SelectedIndex));

        //              //スプレッド初期化
        //              //mfnc_setInitialize();

        //              break;
        //  }

        //}

        ///// <summary>
        ///// コンボボックスで選択値が変化した時
        ///// </summary>
        ///// <param name="sender"></param>
        ///// <param name="e"></param>
        //private void gcComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //      if (gcComboBox1.SelectedIndex < 0) return;

        //      decimal p_no = decimal.Parse(getCnvIndexToCode(gcComboBox.SelectedIndex));

        //      //スプレッド初期化  
        //      //mfnc_setInitialize();

        //} 
        #endregion

        #region スプレッドの制御、処理
        /// <summary>スプレッド標準キー　を無効にし上位へスルー通知を行う処理</summary>
        /// param name="pspdObj">スプレッドシートインスタンス</param>
        /// <rerurns> true:正常終了　false:エラー</returns>
        /// <remark>
        /// 各起動時に実行して下さい
        /// TAB: フォーカス移動用にします。
        /// ESC: 通常画面の終了に使用します。　など
        /// 
        /// ※ スプレッド読み取り専用の場合必要なし（OperationModeの設定だけ）
        /// 　　標準でキーを取得したい場合に使用します。
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
            Spread.setSpreadColumInfo(fpS1.ActiveSheet, spread_list);

            //奇数行、偶数行の背景色設定 : OK
            Spread.SetColorAlternating(fpS1.ActiveSheet);

            //固定列数の設定 : +1でOK
            Spread.SetFrozenColumn(fpS1.ActiveSheet, (int)SpreadColum.pds_code + 1);

        }


        private void selectData()
        {
            try
            {
                //レコード数をセット
               // fpS1.ActiveSheet.RowCount = 50;

                // データの読込
                if (dbc != null)
                {
                    //再読込時は前回のデータを破棄する必要あるようだ！
                    dbc.Dispose();

                }
                // データベースへの接続
                dbc = new pgAccessModel(pb2com);

                // データの読込
  
                  dbc.YakuhinMaster.Where(x => x.JanCode == _key).OrderBy(x => x.YakuhinMei).Load();

                // スプレッドにデータセットをセット
                yakuhinMasterBindingSource.DataSource = dbc.YakuhinMaster.Local;

                // レコード数をセット
          //      fpS1.ActiveSheet.RowCount = dbc.YakuhinMaster.Local.Count;

                // 再描画
                fpS1.Refresh();
                fpS1.ResumeLayout(true);

                // スプレッドの初期設定
                setSpreadInitialize();

                //スプレッドの行の高さを揃える  :  OK
                Spread.SetRowsHeight(fpS1.ActiveSheet);

                // ボタン制御
                // なし

                // Spread　キーの透過設定
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































        #endregion

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
      {

    }







    }




}       




    
