namespace B2.BestFunction.Entities
{ 
	using System; 
	using System.Collections.Generic; 
	using System.ComponentModel.DataAnnotations; 
	using System.ComponentModel.DataAnnotations.Schema; 

	/// <summary>όΙf[^wb_[</summary>
	[Table("nyuuko_header")]
	public partial class NyuukoHeader
	{ 
		/// <summary>ςΗR[h</summary>
		[Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
		[Column("yakkyoku_code", Order = 0)]
		public string YakkyokuCode { get; set; }

		/// <summary>`[Τ</summary>
		[Key]
		[Column("order_no")]
		public int? OrderNo { get; set; }

		/// <summary>ΎΧ</summary>
		[Column("details_count")]
		public int? DetailsCount { get; set; }

		/// <summary>`[ζͺ</summary>
		[Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
		[Column("order_kubun", Order = 1)]
		public int? OrderKubun { get; set; }

		/// <summary>ϊ</summary>
		[Column("action_date")]
		public DateTime? ActionDate { get; set; }

		/// <summary>dόζΊ°Δή</summary>
		[Column("torihikisaki_cd")]
		public string TorihikisakiCd { get; set; }

		/// <summary>΅R[h</summary>
		[Column("oroshi_cd")]
		public string OroshiCd { get; set; }

		/// <summary>ΑοΕzZoζͺ</summary>
		[Column("tax_sanshutu_kubun")]
		public int? TaxSanshutuKubun { get; set; }

		/// <summary>ΑοΕζͺ</summary>
		[Column("zei_kubun")]
		public int? ZeiKubun { get; set; }

		/// <summary>ΰz</summary>
		[Column("amount")]
		public decimal? Amount { get; set; }

		/// <summary>ΑοΕz</summary>
		[Column("tax_amount")]
		public decimal? TaxAmount { get; set; }

		/// <summary>vΰz</summary>
		[Column("total_amount")]
		public decimal? TotalAmount { get; set; }

		/// <summary>σόζͺ</summary>
		[Column("print_kubun")]
		public int? PrintKubun { get; set; }

		/// <summary>σόϊ</summary>
		[Column("print_nitiji")]
		public DateTime? PrintNitiji { get; set; }

		/// <summary>Mζͺ</summary>
		[Column("sousin_kubun")]
		public int? SousinKubun { get; set; }

		/// <summary>Mϊ</summary>
		[Column("sousin_nitiji")]
		public DateTime? SousinNitiji { get; set; }

		/// <summary>υl</summary>
		[Column("biko")]
		public string Biko { get; set; }

		/// <summary>­`[Τ</summary>
		[Column("h_order_no")]
		public int? HOrderNo { get; set; }

		/// <summary>o^ϊ</summary>
		[Column("insert_nitiji")]
		public DateTime? InsertNitiji { get; set; }

		/// <summary>Κm―Κ</summary>
		[Column("tsuuchi_sikibetu")]
		public int? TsuuchiSikibetu { get; set; }

		/// <summary>Κmϊ</summary>
		[Column("tsuuchi_date")]
		public DateTime? TsuuchiDate { get; set; }

		/// <summary> RXgN^</summary>
		public NyuukoHeader()
		{

			YakkyokuCode = "";
			OrderNo = 0;
			DetailsCount = 0;
			OrderKubun = 0;
			ActionDate = null;
			TorihikisakiCd = "";
			OroshiCd = "";
			TaxSanshutuKubun = 0;
			ZeiKubun = 0;
			Amount = 0;
			TaxAmount = 0;
			TotalAmount = 0;
			PrintKubun = 0;
			PrintNitiji = null;
			SousinKubun = 0;
			SousinNitiji = null;
			Biko = "";
			HOrderNo = 0;
			InsertNitiji = null;
			TsuuchiSikibetu = 0;
			TsuuchiDate = null;

		}
	} 
} 
