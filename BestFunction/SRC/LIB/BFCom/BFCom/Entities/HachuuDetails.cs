namespace B2.BestFunction.Entities
{ 
	using System; 
	using System.Collections.Generic; 
	using System.ComponentModel.DataAnnotations; 
	using System.ComponentModel.DataAnnotations.Schema; 

	/// <summary>�����f�[�^����</summary>
	[Table("hachuu_details")]
	public partial class HachuuDetails
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

		/// <summary>������</summary>
		[Column("suryo")]
		public int? Suryo { get; set; }

		/// <summary>�[�i�w���</summary>
		[Column("delivery_date")]
		public DateTime? DeliveryDate { get; set; }

		/// <summary>�[�i�w��ꏊ</summary>
		[Column("delivery_location")]
		public int? DeliveryLocation { get; set; }

		/// <summary>���l</summary>
		[Column("biko")]
		public string Biko { get; set; }

		/// <summary>���ɐ�</summary>
		[Column("nyuuko_su")]
		public int? NyuukoSu { get; set; }

		/// <summary>�c�敪</summary>
		[Column("zan_kubun")]
		public int? ZanKubun { get; set; }

		/// <summary>�o�^����</summary>
		[Column("insert_nitiji")]
		public DateTime? InsertNitiji { get; set; }

		/// <summary> �R���X�g���N�^</summary>
		public HachuuDetails()
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
			DeliveryDate = null;
			DeliveryLocation = 0;
			Biko = "";
			NyuukoSu = 0;
			ZanKubun = 0;
			InsertNitiji = null;

		}
	} 
} 
