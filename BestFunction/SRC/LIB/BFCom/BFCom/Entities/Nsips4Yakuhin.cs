namespace B2.BestFunction.Entities
{ 
	using System; 
	using System.Collections.Generic; 
	using System.ComponentModel.DataAnnotations; 
	using System.ComponentModel.DataAnnotations.Schema; 

	/// <summary>NSIPSòie[u</summary>
	[Table("nsips4_yakuhin")]
	public partial class Nsips4Yakuhin
	{ 
		/// <summary>L[</summary>
		[Key]
		[Column("nsips4_yakuhin_id")]
		public int? Nsips4YakuhinId { get; set; }

		/// <summary>Nsips0wb_ID</summary>
		[Column("nsips0_header_id")]
		public int? Nsips0HeaderId { get; set; }

		/// <summary>Nsips2ûâ³ID</summary>
		[Column("nsips2_shohosen_id")]
		public int? Nsips2ShohosenId { get; set; }

		/// <summary>Nsips0p@ID</summary>
		[Column("nsips3_yoho_id")]
		public int? Nsips3YohoId { get; set; }

		/// <summary>¯Êq</summary>
		[Column("stype")]
		public int? Stype { get; set; }

		/// <summary>òiÔ</summary>
		[Column("yakuhin_bango")]
		public int? YakuhinBango { get; set; }

		/// <summary>RPÔ</summary>
		[Column("rp_bango")]
		public int? RpBango { get; set; }

		/// <summary>îñæª</summary>
		[Column("jyoho_kubun")]
		public string JyohoKubun { get; set; }

		/// <summary>YJR[h</summary>
		[Column("yj_code")]
		public string YjCode { get; set; }

		/// <summary>ZdZR[h</summary>
		[Column("resedensan_code")]
		public string ResedensanCode { get; set; }

		/// <summary>HOTR[h</summary>
		[Column("hot_code")]
		public string HotCode { get; set; }

		/// <summary>¾×R[h</summary>
		[Column("meisai_code")]
		public string MeisaiCode { get; set; }

		/// <summary>òi¼</summary>
		[Column("yakuhin_mei")]
		public string YakuhinMei { get; set; }

		/// <summary>òiêÊ¼</summary>
		[Column("yakuhin_ippanmei")]
		public string YakuhinIppanmei { get; set; }

		/// <summary>sÏªpÊ(N°)</summary>
		[Column("fukintobunkatsu_fukuyo_ryo_kisho")]
		public decimal? FukintobunkatsuFukuyoRyoKisho { get; set; }

		/// <summary>sÏªpÊ(©)</summary>
		[Column("fukintobunkatsu_fukuyo_ryo_asa")]
		public decimal? FukintobunkatsuFukuyoRyoAsa { get; set; }

		/// <summary>sÏªpÊ()</summary>
		[Column("fukintobunkatsu_fukuyo_ryo_hiru")]
		public decimal? FukintobunkatsuFukuyoRyoHiru { get; set; }

		/// <summary>sÏªpÊ([)</summary>
		[Column("fukintobunkatsu_fukuyo_ryo_yu")]
		public decimal? FukintobunkatsuFukuyoRyoYu { get; set; }

		/// <summary>sÏªpÊ(QéO)</summary>
		[Column("fukintobunkatsu_fukuyo_ryo_nerumae")]
		public decimal? FukintobunkatsuFukuyoRyoNerumae { get; set; }

		/// <summary>sÏªpÊ(\õ)</summary>
		[Column("fukintobunkatsu_fukuyo_ryo_yobi")]
		public decimal? FukintobunkatsuFukuyoRyoYobi { get; set; }

		/// <summary>pÊ</summary>
		[Column("fukuyo_ryo")]
		public decimal? FukuyoRyo { get; set; }

		/// <summary>Í¿tO</summary>
		[Column("rikika_flag")]
		public string RikikaFlag { get; set; }

		/// <summary>pPÊ</summary>
		[Column("fukuyo_tani")]
		public string FukuyoTani { get; set; }

		/// <summary>Pï»æª</summary>
		[Column("ippoka_kubun")]
		public string IppokaKubun { get; set; }

		/// <summary>²Óæª</summary>
		[Column("funsai_kubun")]
		public string FunsaiKubun { get; set; }

		/// <summary>ææª</summary>
		[Column("gazo_kubun")]
		public string GazoKubun { get; set; }

		/// <summary>Êïæª</summary>
		[Column("betsuho_kubun")]
		public string BetsuhoKubun { get; set; }

		/// <summary>\¦æª</summary>
		[Column("hyoji_kubun")]
		public string HyojiKubun { get; set; }

		/// <summary>ò¿</summary>
		[Column("yakka")]
		public decimal? Yakka { get; set; }

		/// <summary>IÔ</summary>
		[Column("tana_bango")]
		public string TanaBango { get; set; }

		/// <summary>bgÔ</summary>
		[Column("lot_bango")]
		public string LotBango { get; set; }

		/// <summary>òiRg1</summary>
		[Column("yakuhin_comment1")]
		public string YakuhinComment1 { get; set; }

		/// <summary>ã­iÏXOòiYJR[h</summary>
		[Column("kohatuhin_henkomae_yakuhin_yj_code")]
		public string KohatuhinHenkomaeYakuhinYjCode { get; set; }

		/// <summary>ã­iÏXOòiZdZR[h</summary>
		[Column("kohatuhin_henkomae_yakuhin_resedensan_code")]
		public string KohatuhinHenkomaeYakuhinResedensanCode { get; set; }

		/// <summary>ã­iÏXOòiHOTR[h</summary>
		[Column("kohatuhin_henkomae_yakuhin_hot_code")]
		public string KohatuhinHenkomaeYakuhinHotCode { get; set; }

		/// <summary>ã­iÏXOòi¼</summary>
		[Column("kohatuhin_henkomae_yakuhin_mei")]
		public string KohatuhinHenkomaeYakuhinMei { get; set; }

		/// <summary>¬æª</summary>
		[Column("kongo_kubun")]
		public string KongoKubun { get; set; }

		/// <summary>ã­iÏXOòipÊ</summary>
		[Column("kohatuhin_henkomae_yakuhin_fukuyo_ryo")]
		public decimal? KohatuhinHenkomaeYakuhinFukuyoRyo { get; set; }

		/// <summary>ã­iÏXOòipPÊ</summary>
		[Column("kohatuhin_henkomae_yakuhin_fukuyo_tani")]
		public string KohatuhinHenkomaeYakuhinFukuyoTani { get; set; }

		/// <summary>PñpÊ</summary>
		[Column("ikkai_fukuyo_ryo")]
		public decimal? IkkaiFukuyoRyo { get; set; }

		/// <summary>òiRg2</summary>
		[Column("yakuhin_comment2")]
		public string YakuhinComment2 { get; set; }

		/// <summary>òiRg3</summary>
		[Column("yakuhin_comment3")]
		public string YakuhinComment3 { get; set; }

		/// <summary>òiRg4</summary>
		[Column("yakuhin_comment4")]
		public string YakuhinComment4 { get; set; }

		/// <summary>òiRg5</summary>
		[Column("yakuhin_comment5")]
		public string YakuhinComment5 { get; set; }

		/// <summary>êÊ¼ûtO</summary>
		[Column("ippannmei_shoho_flag")]
		public string IppannmeiShohoFlag { get; set; }

		/// <summary>Ê</summary>
		[Column("souryo")]
		public decimal? Souryo { get; set; }

		/// <summary>t@CXVæª</summary>
		[Column("fupdkbn")]
		public string Fupdkbn { get; set; }

		/// <summary>Løæª</summary>
		[Column("yuko_flag")]
		public int? YukoFlag { get; set; }

		/// <summary> RXgN^</summary>
		public Nsips4Yakuhin()
		{

			Nsips4YakuhinId = 0;
			Nsips0HeaderId = 0;
			Nsips2ShohosenId = 0;
			Nsips3YohoId = 0;
			Stype = 0;
			YakuhinBango = 0;
			RpBango = 0;
			JyohoKubun = "";
			YjCode = "";
			ResedensanCode = "";
			HotCode = "";
			MeisaiCode = "";
			YakuhinMei = "";
			YakuhinIppanmei = "";
			FukintobunkatsuFukuyoRyoKisho = 0;
			FukintobunkatsuFukuyoRyoAsa = 0;
			FukintobunkatsuFukuyoRyoHiru = 0;
			FukintobunkatsuFukuyoRyoYu = 0;
			FukintobunkatsuFukuyoRyoNerumae = 0;
			FukintobunkatsuFukuyoRyoYobi = 0;
			FukuyoRyo = 0;
			RikikaFlag = "";
			FukuyoTani = "";
			IppokaKubun = "";
			FunsaiKubun = "";
			GazoKubun = "";
			BetsuhoKubun = "";
			HyojiKubun = "";
			Yakka = 0;
			TanaBango = "";
			LotBango = "";
			YakuhinComment1 = "";
			KohatuhinHenkomaeYakuhinYjCode = "";
			KohatuhinHenkomaeYakuhinResedensanCode = "";
			KohatuhinHenkomaeYakuhinHotCode = "";
			KohatuhinHenkomaeYakuhinMei = "";
			KongoKubun = "";
			KohatuhinHenkomaeYakuhinFukuyoRyo = 0;
			KohatuhinHenkomaeYakuhinFukuyoTani = "";
			IkkaiFukuyoRyo = 0;
			YakuhinComment2 = "";
			YakuhinComment3 = "";
			YakuhinComment4 = "";
			YakuhinComment5 = "";
			IppannmeiShohoFlag = "";
			Souryo = 0;
			Fupdkbn = "";
			YukoFlag = 0;

		}
	} 
} 
