﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace B2.Com
{
    public class CnvStr
    {
        #region グローバル関数定義
        //******************************************************************************
        // グローバル関数定義
        //******************************************************************************

        //**********************************************************************
        /// <summary>
        /// DataTable→CSV出力文字変換
        /// </summary>
        /// <param name="lobjDataTable">DataTable</param>
        /// <returns>CSV出力文字</returns>
        //**********************************************************************
        public static string DataTableToCsv(DataTable lobjDataTable)
        {
            string lstrR = "";
            try
            {
                string lstrField;

                //--------------------------------------
                // 引数確認
                //--------------------------------------
                if (lobjDataTable.Columns.Count < 1)
                {
                    return "";
                }

                //--------------------------------------
                // ヘッダ
                //--------------------------------------
                lstrField = "";
                for (int lintC = 0; lintC < lobjDataTable.Columns.Count; lintC++)
                {
                    lstrField += ",";
                    lstrField += mfnc_EncloseDoubleQuotesIfNeed(lobjDataTable.Columns[lintC].Caption);
                }
                lstrR += lstrField.Substring(1) + Environment.NewLine;

                //--------------------------------------
                // レコード
                //--------------------------------------
                foreach (DataRow lRow in lobjDataTable.Rows)
                {
                    lstrField = "";
                    for (int lintC = 0; lintC < lobjDataTable.Columns.Count; lintC++)
                    {
                        lstrField += ",";
                        lstrField += mfnc_EncloseDoubleQuotesIfNeed(lRow[lintC].ToString());
                    }
                    lstrR += lstrField.Substring(1) + Environment.NewLine;
                }
            }
            catch
            {
            }
            return lstrR;
        }


        //**********************************************************************
        /// <summary>
        /// DataRow初期化
        /// </summary>
        /// <remarks>
        /// 全項目に""もしくは0を設定する
        /// </remarks>
        /// <param name="pRow">DataRow</param>
        /// <returns>true:正常 false:異常</returns>
        //**********************************************************************
        public static bool InitDatarow(ref DataRow pRow)
        {
            try
            {
                foreach (DataColumn lobjCol in pRow.Table.Columns)
                {
                    pRow[lobjCol.ColumnName] = TypeConv("", lobjCol.DataType);
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        //**********************************************************************
        /// <summary>
        /// ファイル名称使用不可文字変換
        /// </summary>
        /// <remarks>
        /// ファイル名に使用不可な文字を全角文字に変換
        /// </remarks>
        /// <param name="pstrFileName">ファイル(フォルダ)名称</param>
        /// <returns>ファイル(フォルダ)名称</returns>
        //**********************************************************************
        public static string InvalidFileNameConv(string pstrFileName)
        {
            string lstrR = pstrFileName;
            try
            {
                string[,] lstrConv = new string[,] { 
                 {"\\","￥"}
                ,{"/","／"}
                ,{":","："}
                ,{"*","＊"}
                ,{"?","？"}
                ,{"\"","”"}
                ,{"<","＜"}
                ,{">","＞"}
                ,{"|","｜"}
                };

                // 文字数確認
                lstrR = lstrR.Trim();
                if (lstrR.Length <= 0)
                {
                    return "";
                }

                // 先頭の文字が"."の場合は全角変換
                if (lstrR.Substring(0, 1) == ".")
                {
                    lstrR = "．" + lstrR.Substring(1);
                }

                // ファイル名称使用不可文字は無条件に全角変換
                for (int lintI = 0; lintI < lstrConv.GetLength(0); lintI++)
                {
                    lstrR = lstrR.Replace(lstrConv[lintI, 0], lstrConv[lintI, 1]);
                }
            }
            catch
            {
            }
            return lstrR;
        }

        //**********************************************************************
        /// <summary>
        /// NpgsqlDataReader→DataRow変換
        /// </summary>
        /// <param name="pOraDSRead">OracleDataReader</param>
        /// <param name="pRow">DataRow</param>
        /// <returns>true:正常 false:異常</returns>
        //**********************************************************************
        public static bool ToDatarow(Npgsql.NpgsqlDataReader pOraDSRead, ref DataRow pRow)
        {
            string lstrCol = "";
            string lstrTmp = "";
            try
            {
                //--------------------------------------
                // データ初期化
                //--------------------------------------
                InitDatarow(ref pRow);

                //--------------------------------------
                // DataRowのColumn名称でOracleDataReaderからデータ取得
                // ※ SQLのselect項目にColumn名称が全て無いとエラー
                //--------------------------------------
                foreach (DataColumn lobjCol in pRow.Table.Columns)
                {
                    // DataRowのColumn名取得
                    lstrCol = lobjCol.ColumnName;
                    // DataRowのColumn名でOracleDataReader情報取得
                    try
                    {
                        lstrTmp = pOraDSRead[lstrCol].ToString();
                    }
                    catch
                    {
                        lstrTmp = "";
                    }
                    // DataRowの型に応じてデータ設定
                    pRow[lstrCol] = TypeConv(lstrTmp, lobjCol.DataType);
                }

                return true;
            }
            catch
            {
                return false;
            }
        }

        //**********************************************************************
        /// <summary>
        /// 予定日(yyyyMMdd)取得
        /// </summary>
        /// <param name="pdecBASE_DATE">基準日(yyyyMMdd)</param>
        /// <param name="pdecDEADLINE_DAY">締め日(dd)</param>
        /// <param name="pdecSIGHT_DAY">予定日(dd)</param>
        /// <param name="pdecSIGHT">サイト日数</param>
        /// <returns>予定日(yyyyMMdd)</returns>
        //**********************************************************************
        public static decimal ToSightDate(decimal pdecBASE_DATE, decimal pdecDEADLINE_DAY, decimal pdecSIGHT_DAY, decimal pdecSIGHT)
        {
            try
            {
                decimal ldecR;

                // 基準日(yyyyMMdd)
                DateTime ldteBASE_DATE;
                if (!DateTime.TryParse(ToStringDate(pdecBASE_DATE), out ldteBASE_DATE))
                {
                    return 0M;
                }

                // 締め日(dd)
                int lintDEADLINE_DAY = (int)pdecDEADLINE_DAY;
                if (lintDEADLINE_DAY == 0) { lintDEADLINE_DAY = 31; }

                // 予定日(dd)
                int lintSIGHT_DATE = (int)pdecSIGHT_DAY;
                if (lintSIGHT_DATE == 0) { lintSIGHT_DATE = 31; }

                // サイト日数
                int lintSIGHT = (int)pdecSIGHT;
                if (lintSIGHT == 0) { lintSIGHT = 30; }

                // 基準日(dd) > 締め日(dd) の場合 締め日(yyyyMMdd)は基準日の翌月
                int lintAddMonth = 0;
                if (ldteBASE_DATE.Day > lintDEADLINE_DAY)
                {
                    lintAddMonth = 1;
                }

                // 締め日(yyyyMMdd)
                DateTime ldteTarget = mfnc_getDateTime(ldteBASE_DATE.Year, ldteBASE_DATE.Month + lintAddMonth, lintDEADLINE_DAY);

                // 締め日のサイト日数後の日(yyyyMMdd)
                ldteTarget = ldteTarget.AddDays(lintSIGHT);

                // 締め日のサイト日数後の月の予定日(yyyyMMdd)
                ldteTarget = mfnc_getDateTime(ldteTarget.Year, ldteTarget.Month, lintSIGHT_DATE);

                // 予定日(yyyyMMdd)
                ldecR = decimal.Parse(ldteTarget.ToString("yyyyMMdd"));

                return ldecR;
            }
            catch
            {
                return 0M;
            }
        }

        //**********************************************************************
        /// <summary>
        /// DataRow→string変換
        /// </summary>
        /// <remarks>
        /// データが"0"の場合は""とする
        /// </remarks>
        /// <param name="pobjDataRow">DataRowデータ</param>
        /// <param name="pstrColumnName">Column名称</param>
        /// <returns>stringデータ</returns>
        //**********************************************************************
        public static string ToString(DataRow pobjDataRow, string pstrColumnName)
        {
            string lstrR = "";
            try
            {
                lstrR = ToString(pobjDataRow[pstrColumnName]);
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("'" + pstrColumnName + "'という項目がありません。処理を継続します。", "確認", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
            }
            return lstrR;
        }

        //**********************************************************************
        /// <summary>
        /// object→string変換
        /// </summary>
        /// <remarks>
        /// データが"0"の場合は""とする
        /// </remarks>
        /// <param name="pobjData">objectデータ</param>
        /// <returns>stringデータ</returns>
        //**********************************************************************
        public static string ToString(object pobjData)
        {
            string lstrR = "";
            try
            {
                lstrR = ToString(pobjData.ToString());
            }
            catch
            { }
            return lstrR;
        }

        //**********************************************************************
        /// <summary>
        /// string→string変換
        /// </summary>
        /// <remarks>
        /// データが"0"の場合は""とする
        /// </remarks>
        /// <param name="pstrData">objectデータ</param>
        /// <returns>stringデータ</returns>
        //**********************************************************************
        public static string ToString(string pstrData)
        {
            string lstrR = "";
            try
            {
                lstrR = pstrData.Trim();
                lstrR = (lstrR == "0") ? "" : lstrR;
            }
            catch
            { }
            return lstrR;
        }

        //**********************************************************************
        /// <summary>
        /// DataRow→"#,0"形式string変換
        /// </summary>
        /// <remarks>
        /// データが"0"の場合・数値以外の場合は""とする
        /// </remarks>
        /// <param name="pobjDataRow">DataRowデータ</param>
        /// <param name="pstrColumnName">Column名称</param>
        /// <returns>"#,0"形式stringデータ</returns>
        //**********************************************************************
        public static string ToString1000Separator(DataRow pobjDataRow, string pstrColumnName)
        {
            string lstrR = "";
            try
            {
                lstrR = ToString1000Separator(ToString(pobjDataRow, pstrColumnName));
            }
            catch
            { }
            return lstrR;
        }

        //**********************************************************************
        /// <summary>
        /// object→"#,0"形式string変換
        /// </summary>
        /// <remarks>
        /// データが"0"の場合・数値以外の場合は""とする
        /// </remarks>
        /// <param name="pstrData">objectデータ</param>
        /// <returns>"#,0"形式stringデータ</returns>
        //**********************************************************************
        public static string ToString1000Separator(object pobjData)
        {
            string lstrR = "";
            try
            {
                lstrR = ToString1000Separator(ToString(pobjData));
            }
            catch
            { }
            return lstrR;
        }

        //**********************************************************************
        /// <summary>
        /// object→"#,0"形式string変換
        /// </summary>
        /// <remarks>
        /// データが"0"の場合・数値以外の場合は""とする
        /// </remarks>
        /// <param name="pobjData">objectデータ</param>
        /// <returns>"#,0"形式stringデータ</returns>
        //**********************************************************************
        public static string ToString1000Separator(string pstrData)
        {
            string lstrR = "";
            try
            {
                decimal ldecTmp;
                if (decimal.TryParse(pstrData, out ldecTmp))
                {
                    lstrR = ldecTmp.ToString("#,0");
                }
            }
            catch
            { }
            return lstrR;
        }

        //**********************************************************************
        /// <summary>
        /// DataRow→"yyyy/MM/dd"形式string変換
        /// </summary>
        /// <remarks>
        /// データが"0"の場合は""とする
        /// </remarks>
        /// <param name="pobjDataRow">DataRowデータ</param>
        /// <param name="pstrColumnName">Column名称</param>
        /// <returns>"yyyy/MM/dd"形式stringデータ</returns>
        //**********************************************************************
        public static string ToStringDate(DataRow pobjDataRow, string pstrColumnName)
        {
            string lstrR = "";
            try
            {
                lstrR = ToStringDate(ToString(pobjDataRow, pstrColumnName));
            }
            catch
            { }
            return lstrR;
        }

        //**********************************************************************
        /// <summary>
        /// object→"yyyy/MM/dd"形式string変換
        /// </summary>
        /// <remarks>
        /// データが"0"の場合は""とする
        /// </remarks>
        /// <param name="pobjData">objectデータ</param>
        /// <returns>"yyyy/MM/dd"形式stringデータ</returns>
        //**********************************************************************
        public static string ToStringDate(object pobjData)
        {
            string lstrR = "";
            try
            {
                lstrR = ToStringDate(ToString(pobjData));
            }
            catch
            { }
            return lstrR;
        }

        //**********************************************************************
        /// <summary>
        /// string→"yyyy/MM/dd"形式string変換
        /// </summary>
        /// <remarks>
        /// データが"0"の場合は""とする
        /// </remarks>
        /// <param name="pstrData">stringデータ</param>
        /// <returns>"yyyy/MM/dd"形式stringデータ</returns>
        //**********************************************************************
        public static string ToStringDate(string pstrData)
        {
            string lstrR = "";
            try
            {
                lstrR = ToString(pstrData);
                switch (pstrData.Length)
                {
                    case 6:
                        lstrR = pstrData.Substring(0, 4) + "/" + pstrData.Substring(4, 2);
                        break;
                    case 8:
                        lstrR = pstrData.Substring(0, 4) + "/" + pstrData.Substring(4, 2) + "/" + pstrData.Substring(6, 2);
                        break;
                }
            }
            catch
            { }
            return lstrR;
        }

        //**********************************************************************
        /// <summary>
        /// DataRow→SQL対応string変換
        /// </summary>
        /// <param name="pobjDataRow">DataRowデータ</param>
        /// <param name="pstrColumnName">Column名称</param>
        /// <returns>SQL形式stringデータ</returns>
        //**********************************************************************
        public static string ToStringSql(DataRow pobjDataRow, string pstrColumnName)
        {
            string lstrR = "";
            try
            {
                lstrR = ToStringSql(pobjDataRow[pstrColumnName]);
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("'" + pstrColumnName + "'という項目がありません。処理を継続します。", "確認", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
            }
            return lstrR;
        }

        //**********************************************************************
        /// <summary>
        /// object→SQL対応string変換
        /// </summary>
        /// <param name="pstrData">objectデータ</param>
        /// <returns>SQL形式stringデータ</returns>
        //**********************************************************************
        public static string ToStringSql(object pobjData)
        {
            string lstrR = "";
            try
            {
                lstrR = ToStringSql(pobjData.ToString());
            }
            catch
            { }
            return lstrR;
        }

        //**********************************************************************
        /// <summary>
        /// string→SQL対応string変換
        /// </summary>
        /// <param name="pobjData">objectデータ</param>
        /// <returns>SQL形式stringデータ</returns>
        //**********************************************************************
        public static string ToStringSql(string pstrData)
        {
            string lstrR = "";
            try
            {
                lstrR = pstrData.Trim();
                lstrR = lstrR.Replace("'", "''");
                if (lstrR == "")
                {
                    lstrR = " ";
                }
            }
            catch
            { }
            return lstrR;
        }

        //**********************************************************************
        /// <summary>
        /// 型変換
        /// </summary>
        /// <param name="pstrData">文字情報</param>
        /// <param name="pobjType">型情報</param>
        /// <returns>型変換後データ</returns>
        //**********************************************************************
        public static object TypeConv(string pstrData, Type pobjType)
        {
            object pobjData = "";
            try
            {
                // 型に応じてデータ設定
                switch (pobjType.ToString())
                {
                    case "System.String":
                        // 文字データ
                        pobjData = pstrData;
                        break;
                    case "System.Decimal":
                        // 数値データ
                        decimal ldecTmp;
                        if (!decimal.TryParse(pstrData, out ldecTmp)) { ldecTmp = 0m; }
                        pobjData = ldecTmp;
                        break;
                    case "System.Int32":
                        // 数値データ
                        int lintTmp;
                        if (!int.TryParse(pstrData, out lintTmp)) { lintTmp = 0; }
                        pobjData = lintTmp;
                        break;
                    case "System.Boolean":
                        // ブーリアンデータ
                        pobjData = (pstrData == "1");
                        break;
                    case "System.DateTime":
                        // 日付データ
                        DateTime ldteTmp;
                        if (!DateTime.TryParse(pstrData, out ldteTmp)) { ldteTmp = new DateTime(0); }
                        pobjData = ldteTmp;
                        break;
                    default:
                        pobjData = pstrData;
                        break;
                }
            }
            catch
            {
            }
            return pobjData;
        }

        //**********************************************************************
        /// <summary>
        /// Xml→DataRow変換
        /// </summary>
        /// <param name="pstrXml">Xml</param>
        /// <param name="pRow">DataRow</param>
        /// <returns>true:正常 false:異常</returns>
        //**********************************************************************
        public static bool XmlToDatarow(string pstrXml, ref DataRow pRow)
        {
            string lstrCol = "";
            string lstrTmp = "";
            try
            {
                //--------------------------------------
                // データ初期化
                //--------------------------------------
                InitDatarow(ref pRow);

                //--------------------------------------
                // 引数確認
                //--------------------------------------
                if (pstrXml.Trim() == "") { return false; }

                //--------------------------------------
                // Xml
                //--------------------------------------
                System.Xml.XmlDocument lobjXmlDocument;
                System.Xml.XmlNode lobjXmlNode;
                try
                {
                    lobjXmlDocument = new System.Xml.XmlDocument();
                    lobjXmlDocument.Load(new System.IO.StringReader("<QR>" + pstrXml + "</QR>"));
                    lobjXmlNode = lobjXmlDocument.DocumentElement;
                }
                catch
                {
                    // Xml形式でなければ処理なし
                    return false;
                }

                //--------------------------------------
                // DataRowのColumn名称でXmlからデータ取得
                //--------------------------------------
                foreach (DataColumn lobjCol in pRow.Table.Columns)
                {
                    // DataRowのColumn名取得
                    lstrCol = lobjCol.ColumnName;
                    // DataRowのColumn名でXml情報取得
                    try
                    {
                        lstrTmp = lobjXmlNode.SelectSingleNode(lstrCol).InnerText;
                    }
                    catch
                    {
                        lstrTmp = "";
                    }
                    // DataRowの型に応じてデータ設定
                    pRow[lstrCol] = TypeConv(lstrTmp, lobjCol.DataType);
                }

                return true;
            }
            catch
            {
                return false;
            }
        }








        #endregion

        #region ローカル関数定義
        //******************************************************************************
        // ローカル関数定義
        //******************************************************************************

        //**********************************************************************
        /// <summary>
        /// 文字変換
        /// </summary>
        /// <remarks>
        /// null等、変換に例外が発生する場合は""とする
        /// </remarks>
        /// <param name="pobjData">変換前データ</param>
        /// <returns>文字列</returns>
        //**********************************************************************
        private static  string mfnc_ToString(object pobjData)
        {
            try
            {
                return pobjData.ToString();
            }
            catch
            {
                return "";
            }
        }

        //**********************************************************************
        /// <summary>
        /// 必要ならば、文字列をダブルクォートで囲む
        /// </summary>
        /// <param name="pstrField">対象文字列</param>
        /// <returns>変換後文字列</returns>
        //**********************************************************************
        private static string mfnc_EncloseDoubleQuotesIfNeed(string pstrField)
        {
            if (mfnc_NeedEncloseDoubleQuotes(pstrField))
            {
                return mfnc_EncloseDoubleQuotes(pstrField);
            }
            return pstrField;
        }

        //**********************************************************************
        /// <summary>
        /// 文字列をダブルクォートで囲む
        /// </summary>
        /// <param name="pstrField">対象文字列</param>
        /// <returns>変換後文字列</returns>
        //**********************************************************************
        private static string mfnc_EncloseDoubleQuotes(string pstrField)
        {
            if (pstrField.IndexOf('"') > -1)
            {
                //"を""とする
                pstrField = pstrField.Replace("\"", "\"\"");
            }
            return "\"" + pstrField + "\"";
        }

        //**********************************************************************
        /// <summary>
        /// 文字列をダブルクォートで囲む必要があるか調べる
        /// </summary>
        /// <param name="pstrField">対象文字列</param>
        /// <returns>true:必要 false:不要</returns>
        //**********************************************************************
        private static bool mfnc_NeedEncloseDoubleQuotes(string pstrField)
        {
            return pstrField.IndexOf('"') > -1 ||
                pstrField.IndexOf(',') > -1 ||
                pstrField.IndexOf('\r') > -1 ||
                pstrField.IndexOf('\n') > -1 ||
                pstrField.StartsWith(" ") ||
                pstrField.StartsWith("\t") ||
                pstrField.EndsWith(" ") ||
                pstrField.EndsWith("\t");
        }

        //**********************************************************************
        /// <summary>
        /// DateTime型データ取得
        /// </summary>
        /// <remarks>
        /// new DateTime(year,month,day)と異なる点は month が 1 未満であるか、12 を超えている。または day が 1 未満か、month の月の日数よりも大きい値でも例外を生じさせず対応する
        /// </remarks>
        /// <param name="pintYear">年</param>
        /// <param name="pintMonth">月</param>
        /// <param name="pintDay">日</param>
        /// <returns>DateTime型データ</returns>
        //**********************************************************************
        private static DateTime mfnc_getDateTime(int pintYear, int pintMonth, int pintDay)
        {
            try
            {
                DateTime ldteR;
                int lintYear = pintYear;
                int lintMonth = pintMonth;
                int lintAddMonth = 0;

                // 対象年
                if (pintYear < 1)
                {
                    lintYear = 1;
                }
                else if (pintYear > 9999)
                {
                    lintYear = 9999;
                }

                // 対象月
                if (pintMonth < 1)
                {
                    lintMonth = 1;
                    lintAddMonth = pintMonth - 1;
                }
                else if (pintMonth > 12)
                {
                    lintMonth = 12;
                    lintAddMonth = pintMonth - 12;
                }

                // 対象年月のツイタチ
                ldteR = new DateTime(lintYear, lintMonth, 1);
                ldteR = ldteR.AddMonths(lintAddMonth);

                // 対象年月の末日(dd)
                int lintDayMax = ldteR.AddMonths(1).AddDays(-1).Day;

                // 対象日(dd)
                int lintD = pintDay;
                if (lintD < 1)
                {
                    lintD = 1;
                }
                if (lintD > lintDayMax)
                {
                    lintD = lintDayMax;
                }

                // 対象日(yyyyMMdd)
                ldteR = new DateTime(ldteR.Year, ldteR.Month, lintD);

                return ldteR;
            }
            catch
            {
                return new DateTime();
            }
        }
        #endregion

        //**********************************************************************
        // 川本くん使用のもの　Utilities
        //**********************************************************************
        public static char ToChar(string text)
        {
            char a;
            char.TryParse(text, out a);
            return a;
        }

        public static char ToChar(object obj)
        {
            return ToChar(Convert.ToString(obj));
        }

        public static int ToInt32(string text)
        {
            int a;
            int.TryParse(text, out a);
            return a;
        }

        public static int ToInt32(object obj)
        {
            return ToInt32(Convert.ToString(obj));
        }

        public static double ToDouble(string text)
        {
            double a;
            double.TryParse(text, out a);
            return a;
        }

        public static double ToDouble(object obj)
        {
            return ToDouble(Convert.ToString(obj));
        }

        public static decimal ToDecimal(string text)
        {
            decimal a;
            decimal.TryParse(text, out a);
            return a;
        }

        public static decimal ToDecimal(object obj)
        {
            return ToDecimal(Convert.ToString(obj));
        }

        public static DateTime ToDateTime(string text, string format)
        {
            DateTime a;
            DateTime.TryParseExact(text, format, System.Globalization.DateTimeFormatInfo.InvariantInfo, System.Globalization.DateTimeStyles.None, out a);
            return a;
        }

        public static DateTime ToDateTime(object obj, string format)
        {
            return ToDateTime(Convert.ToString(obj), format);
        }


    }
}
