namespace B2.BestFunction.Entities
{ 
	using System; 
	using System.Collections.Generic; 
	using System.ComponentModel.DataAnnotations; 
	using System.ComponentModel.DataAnnotations.Schema; 

	/// <summary>�������׃��[�N</summary>
	[Table("hacchu_meisai_wk")]
	public partial class HacchuMeisai_wk
	{ 
		/// <summary>��ǃR�[�h</summary>
		[Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
		[Column("yakkyoku_code", Order = 0)]
		public string YakkyokuCode { get; set; }

		/// <summary>��ӃL�[</summary>
		[Key]
		[Column("ichi_bango")]
		public int? IchiBango { get; set; }

		/// <summary>�`�[�敪</summary>
		[Column("denpyo_kubun")]
		public int? DenpyoKubun { get; set; }

		/// <summary>����敪</summary>
		[Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
		[Column("torihiki_kubun", Order = 1)]
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
		public HacchuMeisai_wk()
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
			DeliveryDate = null;
			DeliveryLocation = 0;
			Biko = "";
			NyuukoSu = 0;
			ZanKubun = 0;
			InsertNitiji = null;

		}
	} 
} 
