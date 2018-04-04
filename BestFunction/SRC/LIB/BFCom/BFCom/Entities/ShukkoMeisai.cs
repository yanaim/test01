namespace B2.BestFunction.Entities
{ 
	using System; 
	using System.Collections.Generic; 
	using System.ComponentModel.DataAnnotations; 
	using System.ComponentModel.DataAnnotations.Schema; 

	/// <summary>�o�ɖ���</summary>
	[Table("shukko_meisai")]
	public partial class ShukkoMeisai
	{ 
		/// <summary>��ǃR�[�h</summary>
		[Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
		[Column("yakkyoku_code", Order = 0)]
		public string YakkyokuCode { get; set; }

		/// <summary>�`�[�ԍ�</summary>
		[Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
		[Column("denpyo_bango", Order = 1)]
		public int? DenpyoBango { get; set; }

		/// <summary>���הԍ�</summary>
		[Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
		[Column("meisai_bango", Order = 2)]
		public int? MeisaiBango { get; set; }

		/// <summary>����敪</summary>
		[Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
		[Column("torihiki_kubun", Order = 3)]
		public int? TorihikiKubun { get; set; }

		/// <summary>������</summary>
		[Column("shori_date")]
		public DateTime? ShoriDate { get; set; }

		/// <summary>���i�R�[�h�敪</summary>
		[Column("shohin_code_kubun")]
		public int? ShohinCodeKubun { get; set; }

		/// <summary>���i�R�[�h</summary>
		[Column("shohin_code")]
		public string ShohinCode { get; set; }

		/// <summary>���i���A�K�i�A�e��</summary>
		[Column("shohin_name_kikaku_yoryo")]
		public string ShohinNameKikakuYoryo { get; set; }

		/// <summary>����</summary>
		[Column("hako_suryo")]
		public decimal? HakoSuryo { get; set; }

		/// <summary>���</summary>
		[Column("hoso_suryo")]
		public decimal? HosoSuryo { get; set; }

		/// <summary>�o����</summary>
		[Column("bara_suryo")]
		public decimal? BaraSuryo { get; set; }

		/// <summary>�P��</summary>
		[Column("tanka")]
		public decimal? Tanka { get; set; }

		/// <summary>���z</summary>
		[Column("kingaku")]
		public decimal? Kingaku { get; set; }

		/// <summary>��</summary>
		[Column("yakka")]
		public decimal? Yakka { get; set; }

		/// <summary>����ŋ��z</summary>
		[Column("shohizei_kingaku")]
		public decimal? ShohizeiKingaku { get; set; }

		/// <summary>���v���z</summary>
		[Column("shoke_kingaku")]
		public decimal? ShokeKingaku { get; set; }

		/// <summary>�g�p����</summary>
		[Column("shiyo_kigen")]
		public string ShiyoKigen { get; set; }

		/// <summary>���b�g�ԍ�</summary>
		[Column("lot_bango")]
		public string LotBango { get; set; }

		/// <summary>�o�ɓ�</summary>
		[Column("shukko_date")]
		public DateTime? ShukkoDate { get; set; }

		/// <summary>���l</summary>
		[Column("biko")]
		public string Biko { get; set; }

		/// <summary>�o�^����</summary>
		[Column("insert_nitiji")]
		public DateTime? InsertNitiji { get; set; }

		/// <summary> �R���X�g���N�^</summary>
		public ShukkoMeisai()
		{

			YakkyokuCode = "";
			DenpyoBango = 0;
			MeisaiBango = 0;
			TorihikiKubun = 0;
			ShoriDate = null;
			ShohinCodeKubun = 0;
			ShohinCode = "";
			ShohinNameKikakuYoryo = "";
			HakoSuryo = 0;
			HosoSuryo = 0;
			BaraSuryo = 0;
			Tanka = 0;
			Kingaku = 0;
			Yakka = 0;
			ShohizeiKingaku = 0;
			ShokeKingaku = 0;
			ShiyoKigen = "";
			LotBango = "";
			ShukkoDate = null;
			Biko = "";
			InsertNitiji = null;

		}
	} 
} 
