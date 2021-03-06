namespace B2.BestFunction.Entities
{ 
	using System; 
	using System.Collections.Generic; 
	using System.ComponentModel.DataAnnotations; 
	using System.ComponentModel.DataAnnotations.Schema; 

	/// <summary>üÉwb_</summary>
	[Table("nyuko_header")]
	public partial class NyukoHeader
	{ 
		/// <summary>òÇR[h</summary>
		[Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
		[Column("yakkyoku_code", Order = 0)]
		public string YakkyokuCode { get; set; }

		/// <summary>`[Ô</summary>
		[Key]
		[Column("denpyo_bango")]
		public int? DenpyoBango { get; set; }

		/// <summary>¾×</summary>
		[Column("meisaisu")]
		public int? Meisaisu { get; set; }

		/// <summary>`[æª</summary>
		[Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
		[Column("denpyo_kubun", Order = 1)]
		public int? DenpyoKubun { get; set; }

		/// <summary>ú</summary>
		[Column("shori_date")]
		public DateTime? ShoriDate { get; set; }

		/// <summary>æøæR[h</summary>
		[Column("torihikisaki_code")]
		public string TorihikisakiCode { get; set; }

		/// <summary>µR[h</summary>
		[Column("oroshi_code")]
		public string OroshiCode { get; set; }

		/// <summary>ÁïÅZoæª</summary>
		[Column("shohizei_sanshutsu_kubun")]
		public int? ShohizeiSanshutsuKubun { get; set; }

		/// <summary>ÁïÅæª</summary>
		[Column("shohizai_kubun")]
		public int? ShohizaiKubun { get; set; }

		/// <summary>àz</summary>
		[Column("kingaku")]
		public decimal? Kingaku { get; set; }

		/// <summary>ÁïÅàz</summary>
		[Column("shohizei_kingaku")]
		public decimal? ShohizeiKingaku { get; set; }

		/// <summary>vàz</summary>
		[Column("goke_kingaku")]
		public decimal? GokeKingaku { get; set; }

		/// <summary>vgæª</summary>
		[Column("print_kubun")]
		public int? PrintKubun { get; set; }

		/// <summary>vgú</summary>
		[Column("print_nitiji")]
		public DateTime? PrintNitiji { get; set; }

		/// <summary>Mæª</summary>
		[Column("soshin_kubun")]
		public int? SoshinKubun { get; set; }

		/// <summary>Mú</summary>
		[Column("soshin_nitiji")]
		public DateTime? SoshinNitiji { get; set; }

		/// <summary>­`[Ô</summary>
		[Column("hacchu_denpyo_bango")]
		public int? HacchuDenpyoBango { get; set; }

		/// <summary>õl</summary>
		[Column("biko")]
		public string Biko { get; set; }

		/// <summary>`[ÔPDS</summary>
		[Column("denpyo_bango_pds")]
		public int? DenpyoBangoPds { get; set; }

		/// <summary>o^ú</summary>
		[Column("insert_nitiji")]
		public DateTime? InsertNitiji { get; set; }

		/// <summary>Êm¯Ê</summary>
		[Column("tsuchi_shikibetsu")]
		public int? TsuchiShikibetsu { get; set; }

		/// <summary>Êmú</summary>
		[Column("tsuchi_nitiji")]
		public DateTime? TsuchiNitiji { get; set; }

		/// <summary> RXgN^</summary>
		public NyukoHeader()
		{

			YakkyokuCode = "";
			DenpyoBango = 0;
			Meisaisu = 0;
			DenpyoKubun = 0;
			ShoriDate = null;
			TorihikisakiCode = "";
			OroshiCode = "";
			ShohizeiSanshutsuKubun = 0;
			ShohizaiKubun = 0;
			Kingaku = 0;
			ShohizeiKingaku = 0;
			GokeKingaku = 0;
			PrintKubun = 0;
			PrintNitiji = null;
			SoshinKubun = 0;
			SoshinNitiji = null;
			HacchuDenpyoBango = 0;
			Biko = "";
			DenpyoBangoPds = 0;
			InsertNitiji = null;
			TsuchiShikibetsu = 0;
			TsuchiNitiji = null;

		}
	} 
} 
