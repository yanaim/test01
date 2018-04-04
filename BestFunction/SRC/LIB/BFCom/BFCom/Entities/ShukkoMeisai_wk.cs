namespace B2.BestFunction.Entities
{ 
	using System; 
	using System.Collections.Generic; 
	using System.ComponentModel.DataAnnotations; 
	using System.ComponentModel.DataAnnotations.Schema; 

	/// <summary>�o�ɖ��׃��[�N</summary>
	[Table("shukko_meisai_wk")]
	public partial class ShukkoMeisai_wk
	{ 
		/// <summary>��ǃR�[�h</summary>
		[Column("yakkyoku_code")]
		public string YakkyokuCode { get; set; }

		/// <summary>��ӃL�[</summary>
		[Key]
		[Column("ichi_bango")]
		public int? IchiBango { get; set; }

		/// <summary>�`�[�敪</summary>
		[Column("denpyo_kubun")]
		public int? DenpyoKubun { get; set; }

		/// <summary>����敪</summary>
		[Column("torihiki_kubun")]
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
		public ShukkoMeisai_wk()
		{

			YakkyokuCode = "";
			IchiBango = 0;
			DenpyoKubun = 0;
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
