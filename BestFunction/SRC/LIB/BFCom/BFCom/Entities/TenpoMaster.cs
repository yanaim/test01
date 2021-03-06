namespace B2.BestFunction.Entities
{ 
	using System; 
	using System.Collections.Generic; 
	using System.ComponentModel.DataAnnotations; 
	using System.ComponentModel.DataAnnotations.Schema; 

	/// <summary>XÜ}X^</summary>
	[Table("tenpo_master")]
	public partial class TenpoMaster
	{ 
		/// <summary>òÇR[h</summary>
		[Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
		[Column("yakkyoku_code", Order = 0)]
		public string YakkyokuCode { get; set; }

		/// <summary>XXÖÔ</summary>
		[Column("mise_yuubin")]
		public string MiseYuubin { get; set; }

		/// <summary>XÜZiPj</summary>
		[Column("mise_jyu1")]
		public string MiseJyu1 { get; set; }

		/// <summary>XÜZiQj</summary>
		[Column("mise_jyu2")]
		public string MiseJyu2 { get; set; }

		/// <summary>XÜ¼</summary>
		[Column("mise_tenmei")]
		public string MiseTenmei { get; set; }

		/// <summary>XÜ¼(ªÌ)</summary>
		[Column("mise_tenpomei")]
		public string MiseTenpomei { get; set; }

		/// <summary>XÜdbÔ</summary>
		[Column("mise_tel")]
		public string MiseTel { get; set; }

		/// <summary>XÜe`wÔ</summary>
		[Column("mise_fax")]
		public string MiseFax { get; set; }

		/// <summary>ÏXú</summary>
		[Column("henkou_ymd")]
		public DateTime? HenkouYmd { get; set; }

		/// <summary>T[o[Æ§æª</summary>
		[Column("server_kubun")]
		public int? ServerKubun { get; set; }

		/// <summary>MEDZÚ±¶ñ</summary>
		[Column("medz_easyconfig")]
		public string MedzEasyconfig { get; set; }

		/// <summary>PHARÚ±¶ñ</summary>
		[Column("phar_easyconfig")]
		public string PharEasyconfig { get; set; }

		/// <summary>Ç®«</summary>
		[Column("kanri_zokusei")]
		public int? KanriZokusei { get; set; }

		/// <summary>ÁïÅ¦P</summary>
		[Column("syouhi_zeiritu1")]
		public int? SyouhiZeiritu1 { get; set; }

		/// <summary>ÁïÅ¦Q</summary>
		[Column("syouhi_zeiritu2")]
		public int? SyouhiZeiritu2 { get; set; }

		/// <summary>ÁïÅ[æª</summary>
		[Column("syouhizei_hasuu_kubun")]
		public int? SyouhizeiHasuuKubun { get; set; }

		/// <summary>àz[æª</summary>
		[Column("kingaku_hasuu_kubun")]
		public int? KingakuHasuuKubun { get; set; }

		/// <summary>ãÃ@ÖR[h</summary>
		[Column("iryoukikan_code")]
		public string IryoukikanCode { get; set; }

		/// <summary>düæ}X^Êmú</summary>
		[Column("shiire_tuuchi")]
		public DateTime? ShiireTuuchi { get; set; }

		/// <summary>nsb¤i}X^Êmú</summary>
		[Column("otc_tuuchi")]
		public DateTime? OtcTuuchi { get; set; }

		/// <summary>gpJn</summary>
		[Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
		[Column("start_use_date", Order = 1)]
		public int? StartUseDate { get; set; }

		/// <summary>gpI¹</summary>
		[Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
		[Column("end_use_date", Order = 2)]
		public int? EndUseDate { get; set; }

		/// <summary> RXgN^</summary>
		public TenpoMaster()
		{

			YakkyokuCode = "";
			MiseYuubin = "";
			MiseJyu1 = "";
			MiseJyu2 = "";
			MiseTenmei = "";
			MiseTenpomei = "";
			MiseTel = "";
			MiseFax = "";
			HenkouYmd = null;
			ServerKubun = 0;
			MedzEasyconfig = "";
			PharEasyconfig = "";
			KanriZokusei = 0;
			SyouhiZeiritu1 = 0;
			SyouhiZeiritu2 = 0;
			SyouhizeiHasuuKubun = 0;
			KingakuHasuuKubun = 0;
			IryoukikanCode = "";
			ShiireTuuchi = null;
			OtcTuuchi = null;
			StartUseDate = 0;
			EndUseDate = 0;

		}
	} 
} 
