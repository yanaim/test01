namespace B2.BestFunction.Entities
{ 
	using System; 
	using System.Collections.Generic; 
	using System.ComponentModel.DataAnnotations; 
	using System.ComponentModel.DataAnnotations.Schema; 

	/// <summary>BFÚ®Ëe[u</summary>
	[Table("bf_idou")]
	public partial class BfIdou
	{ 
		/// <summary>`[Ô</summary>
		[Key]
		[Column("denpyo_bango")]
		public int? DenpyoBango { get; set; }

		/// <summary>`[æª</summary>
		[Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
		[Column("denpyou_kubun", Order = 0)]
		public int? DenpyouKubun { get; set; }

		/// <summary>Ú®³òÇR[h</summary>
		[Column("idou_tenpo")]
		public string IdouTenpo { get; set; }

		/// <summary>Ÿ×s</summary>
		[Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
		[Column("gyo", Order = 1)]
		public int? Gyo { get; set; }

		/// <summary>üoÉæª</summary>
		[Column("in_out_kubun")]
		public int? InOutKubun { get; set; }

		/// <summary>â¹ú</summary>
		[Column("idou_ymd")]
		public DateTime? IdouYmd { get; set; }

		/// <summary>â¹</summary>
		[Column("idou_time")]
		public DateTime? IdouTime { get; set; }

		/// <summary>Ú®æòÇR[h</summary>
		[Column("moto_saki_tenpo")]
		public string MotoSakiTenpo { get; set; }

		/// <summary>€iR[h</summary>
		[Column("gtin_code")]
		public string GtinCode { get; set; }

		/// <summary>Ú®</summary>
		[Column("suryo")]
		public decimal? Suryo { get; set; }

		/// <summary>düP¿</summary>
		[Column("tanka")]
		public decimal? Tanka { get; set; }

		/// <summary>Ú®àz</summary>
		[Column("kingaku")]
		public decimal? Kingaku { get; set; }

		/// <summary>Mæª</summary>
		[Column("sousin_kubun")]
		public int? SousinKubun { get; set; }

		/// <summary>Ú®mFØœÄ</summary>
		[Column("kakuninhyo_list")]
		public int? KakuninhyoList { get; set; }

		/// <summary>üoÉtO</summary>
		[Column("nyuusyukko_flg")]
		public int? NyuusyukkoFlg { get; set; }

		/// <summary>bgÔ</summary>
		[Column("lot_bango")]
		public string LotBango { get; set; }

		/// <summary>gpúÀ</summary>
		[Column("shiyo_kigen")]
		public DateTime? ShiyoKigen { get; set; }

		/// <summary>Rg</summary>
		[Column("memo")]
		public string Memo { get; set; }

		/// <summary>€iŒÌ</summary>
		[Column("shohin_nm")]
		public string ShohinNm { get; set; }

		/// <summary>Ki</summary>
		[Column("kikaku")]
		public string Kikaku { get; set; }

		/// <summary>³FÛFîñ</summary>
		[Column("ans_flag")]
		public string AnsFlag { get; set; }

		/// <summary>ñú</summary>
		[Column("ans_date")]
		public DateTime? AnsDate { get; set; }

		/// <summary>ñ</summary>
		[Column("ans_time")]
		public int? AnsTime { get; set; }

		/// <summary>ÝÉÊ</summary>
		[Column("zaiko_suryo")]
		public decimal? ZaikoSuryo { get; set; }

		/// <summary>²Ü\ª</summary>
		[Column("yosoku_suryo")]
		public decimal? YosokuSuryo { get; set; }

		/// <summary>³F</summary>
		[Column("ok_suryo")]
		public decimal? OkSuryo { get; set; }

		/// <summary>ùÇtO</summary>
		[Column("kidoku_flag")]
		public int? KidokuFlag { get; set; }

		/// <summary>ùÇú</summary>
		[Column("kidoku_date")]
		public DateTime? KidokuDate { get; set; }

		/// <summary>ùÇ</summary>
		[Column("kidoku_time")]
		public DateTime? KidokuTime { get; set; }

		/// <summary>ËÊ</summary>
		[Column("result")]
		public int? Result { get; set; }

		/// <summary>[úú</summary>
		[Column("nouki_ymd")]
		public DateTime? NoukiYmd { get; set; }

		/// <summary>[úú_ÏXã</summary>
		[Column("nouki_ymd_changed")]
		public DateTime? NoukiYmdChanged { get; set; }

		/// <summary>ÊÏX</summary>
		[Column("suryo_changed")]
		public decimal? SuryoChanged { get; set; }

		/// <summary> RXgN^</summary>
		public BfIdou()
		{

			DenpyoBango = 0;
			DenpyouKubun = 0;
			IdouTenpo = "";
			Gyo = 0;
			InOutKubun = 0;
			IdouYmd = null;
			IdouTime = null;
			MotoSakiTenpo = "";
			GtinCode = "";
			Suryo = 0;
			Tanka = 0;
			Kingaku = 0;
			SousinKubun = 0;
			KakuninhyoList = 0;
			NyuusyukkoFlg = 0;
			LotBango = "";
			ShiyoKigen = null;
			Memo = "";
			ShohinNm = "";
			Kikaku = "";
			AnsFlag = "";
			AnsDate = null;
			AnsTime = 0;
			ZaikoSuryo = 0;
			YosokuSuryo = 0;
			OkSuryo = 0;
			KidokuFlag = 0;
			KidokuDate = null;
			KidokuTime = null;
			Result = 0;
			NoukiYmd = null;
			NoukiYmdChanged = null;
			SuryoChanged = 0;

		}
	} 
} 
