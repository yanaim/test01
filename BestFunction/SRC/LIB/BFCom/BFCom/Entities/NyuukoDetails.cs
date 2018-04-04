namespace B2.BestFunction.Entities
{ 
	using System; 
	using System.Collections.Generic; 
	using System.ComponentModel.DataAnnotations; 
	using System.ComponentModel.DataAnnotations.Schema; 

	/// <summary>���Ƀf�[�^����</summary>
	[Table("nyuuko_details")]
	public partial class NyuukoDetails
	{ 
		/// <summary>��ǃR�[�h</summary>
		[Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
		[Column("yakkyoku_code", Order = 0)]
		public string YakkyokuCode { get; set; }

		/// <summary>�`�[�ԍ�</summary>
		[Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
		[Column("order_no", Order = 1)]
		public int? OrderNo { get; set; }

		/// <summary>���הԍ�</summary>
		[Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
		[Column("detail_no", Order = 2)]
		public int? DetailNo { get; set; }

		/// <summary>����敪</summary>
		[Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
		[Column("torihiki_kubun", Order = 3)]
		public int? TorihikiKubun { get; set; }

		/// <summary>������</summary>
		[Column("action_date")]
		public DateTime? ActionDate { get; set; }

		/// <summary>�d���溰��</summary>
		[Column("torihikisaki_cd")]
		public string TorihikisakiCd { get; set; }

		/// <summary>���R�[�h</summary>
		[Column("oroshi_cd")]
		public string OroshiCd { get; set; }

		/// <summary>���i�R�[�h�敪</summary>
		[Column("syouhin_code_kubun")]
		public int? SyouhinCodeKubun { get; set; }

		/// <summary>���i�R�[�h</summary>
		[Column("syouhin_code")]
		public string SyouhinCode { get; set; }

		/// <summary>�i���E�K�i�E�e��</summary>
		[Column("syouhin_name")]
		public string SyouhinName { get; set; }

		/// <summary>�P�ʋ敪</summary>
		[Column("tani_kubun")]
		public int? TaniKubun { get; set; }

		/// <summary>���ɐ�</summary>
		[Column("suryo")]
		public decimal? Suryo { get; set; }

		/// <summary>�P��</summary>
		[Column("tanka")]
		public decimal? Tanka { get; set; }

		/// <summary>���z</summary>
		[Column("kingaku")]
		public decimal? Kingaku { get; set; }

		/// <summary>��</summary>
		[Column("yakka")]
		public decimal? Yakka { get; set; }

		/// <summary>����Ŋz</summary>
		[Column("tax_amount")]
		public decimal? TaxAmount { get; set; }

		/// <summary>���v���z</summary>
		[Column("total_amount")]
		public decimal? TotalAmount { get; set; }

		/// <summary>�g�p����</summary>
		[Column("siyou_ymd")]
		public string SiyouYmd { get; set; }

		/// <summary>�����ԍ�</summary>
		[Column("lot")]
		public string Lot { get; set; }

		/// <summary>���ɓ�</summary>
		[Column("delivery_date")]
		public DateTime? DeliveryDate { get; set; }

		/// <summary>���ɏꏊ</summary>
		[Column("delivery_location")]
		public int? DeliveryLocation { get; set; }

		/// <summary>���l</summary>
		[Column("biko")]
		public string Biko { get; set; }

		/// <summary>�������הԍ�</summary>
		[Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
		[Column("h_detail_no", Order = 4)]
		public int? HDetailNo { get; set; }

		/// <summary>�o�^����</summary>
		[Column("insert_nitiji")]
		public DateTime? InsertNitiji { get; set; }

		/// <summary> �R���X�g���N�^</summary>
		public NyuukoDetails()
		{

			YakkyokuCode = "";
			OrderNo = 0;
			DetailNo = 0;
			TorihikiKubun = 0;
			ActionDate = null;
			TorihikisakiCd = "";
			OroshiCd = "";
			SyouhinCodeKubun = 0;
			SyouhinCode = "";
			SyouhinName = "";
			TaniKubun = 0;
			Suryo = 0;
			Tanka = 0;
			Kingaku = 0;
			Yakka = 0;
			TaxAmount = 0;
			TotalAmount = 0;
			SiyouYmd = "";
			Lot = "";
			DeliveryDate = null;
			DeliveryLocation = 0;
			Biko = "";
			HDetailNo = 0;
			InsertNitiji = null;

		}
	} 
} 
