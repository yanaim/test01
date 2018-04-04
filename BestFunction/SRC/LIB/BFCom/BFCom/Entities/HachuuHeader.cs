namespace B2.BestFunction.Entities
{ 
	using System; 
	using System.Collections.Generic; 
	using System.ComponentModel.DataAnnotations; 
	using System.ComponentModel.DataAnnotations.Schema; 

	/// <summary>�����f�[�^�w�b�_�[</summary>
	[Table("hachuu_header")]
	public partial class HachuuHeader
	{ 
		/// <summary>��ǃR�[�h</summary>
		[Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
		[Column("yakkyoku_code", Order = 0)]
		public string YakkyokuCode { get; set; }

		/// <summary>�`�[�ԍ�</summary>
		[Key]
		[Column("order_no")]
		public int? OrderNo { get; set; }

		/// <summary>���א�</summary>
		[Column("details_count")]
		public int? DetailsCount { get; set; }

		/// <summary>�`�[�敪</summary>
		[Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
		[Column("order_kubun", Order = 1)]
		public int? OrderKubun { get; set; }

		/// <summary>������</summary>
		[Column("action_date")]
		public DateTime? ActionDate { get; set; }

		/// <summary>�d���溰��</summary>
		[Column("torihikisaki_cd")]
		public string TorihikisakiCd { get; set; }

		/// <summary>���R�[�h</summary>
		[Column("oroshi_cd")]
		public string OroshiCd { get; set; }

		/// <summary>����Ŋz�Z�o�敪</summary>
		[Column("tax_sanshutu_kubun")]
		public int? TaxSanshutuKubun { get; set; }

		/// <summary>����ŋ敪</summary>
		[Column("zei_kubun")]
		public int? ZeiKubun { get; set; }

		/// <summary>���z</summary>
		[Column("amount")]
		public decimal? Amount { get; set; }

		/// <summary>����Ŋz</summary>
		[Column("tax_amount")]
		public decimal? TaxAmount { get; set; }

		/// <summary>���v���z</summary>
		[Column("total_amount")]
		public decimal? TotalAmount { get; set; }

		/// <summary>����敪</summary>
		[Column("print_kubun")]
		public int? PrintKubun { get; set; }

		/// <summary>�������</summary>
		[Column("print_nitiji")]
		public DateTime? PrintNitiji { get; set; }

		/// <summary>���M�敪</summary>
		[Column("sousin_kubun")]
		public int? SousinKubun { get; set; }

		/// <summary>���M����</summary>
		[Column("sousin_nitiji")]
		public DateTime? SousinNitiji { get; set; }

		/// <summary>���l</summary>
		[Column("biko")]
		public string Biko { get; set; }

		/// <summary>�o�^����</summary>
		[Column("insert_nitiji")]
		public DateTime? InsertNitiji { get; set; }

		/// <summary>�ʒm����</summary>
		[Column("tsuuchi_sikibetu")]
		public int? TsuuchiSikibetu { get; set; }

		/// <summary>�ʒm����</summary>
		[Column("tsuuchi_date")]
		public DateTime? TsuuchiDate { get; set; }

		/// <summary> �R���X�g���N�^</summary>
		public HachuuHeader()
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
			InsertNitiji = null;
			TsuuchiSikibetu = 0;
			TsuuchiDate = null;

		}
	} 
} 
