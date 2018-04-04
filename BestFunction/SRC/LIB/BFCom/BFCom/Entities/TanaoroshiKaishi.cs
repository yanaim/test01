namespace B2.BestFunction.Entities
{ 
	using System; 
	using System.Collections.Generic; 
	using System.ComponentModel.DataAnnotations; 
	using System.ComponentModel.DataAnnotations.Schema; 

	/// <summary>�I���J�n�f�[�^</summary>
	[Table("tanaoroshi_kaishi")]
	public partial class TanaoroshiKaishi
	{ 
		/// <summary>��ǃR�[�h</summary>
		[Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
		[Column("yakkyoku_code", Order = 0)]
		public string YakkyokuCode { get; set; }

		/// <summary>YJ�R�[�h</summary>
		[Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
		[Column("yj_code", Order = 1)]
		public string YjCode { get; set; }

		/// <summary>GTIN�R�[�h</summary>
		[Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
		[Column("gtin_code", Order = 2)]
		public string GtinCode { get; set; }

		/// <summary>JAN�R�[�h</summary>
		[Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
		[Column("jan_code", Order = 3)]
		public string JanCode { get; set; }

		/// <summary>���׃R�[�h</summary>
		[Column("meisai_code")]
		public string MeisaiCode { get; set; }

		/// <summary>�݌ɐ�</summary>
		[Column("zaiko_total")]
		public decimal? ZaikoTotal { get; set; }

		/// <summary>�����P��</summary>
		[Column("genka")]
		public decimal? Genka { get; set; }

		/// <summary>�I����</summary>
		[Column("suryo")]
		public decimal? Suryo { get; set; }

		/// <summary>���ِ�</summary>
		[Column("sai_suryo")]
		public decimal? SaiSuryo { get; set; }

		/// <summary>�I���J�n��</summary>
		[Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
		[Column("start_use_date", Order = 4)]
		public DateTime? StartUseDate { get; set; }

		/// <summary>�I���I����</summary>
		[Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
		[Column("end_use_date", Order = 5)]
		public DateTime? EndUseDate { get; set; }

		/// <summary> �R���X�g���N�^</summary>
		public TanaoroshiKaishi()
		{

			YakkyokuCode = "";
			YjCode = "";
			GtinCode = "";
			JanCode = "";
			MeisaiCode = "";
			ZaikoTotal = 0;
			Genka = 0;
			Suryo = 0;
			SaiSuryo = 0;
			StartUseDate = null;
			EndUseDate = null;

		}
	} 
} 
