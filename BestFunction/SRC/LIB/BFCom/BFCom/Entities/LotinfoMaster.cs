namespace B2.BestFunction.Entities
{ 
	using System; 
	using System.Collections.Generic; 
	using System.ComponentModel.DataAnnotations; 
	using System.ComponentModel.DataAnnotations.Schema; 

	/// <summary>�k�n�s���Ǘ��}�X�^</summary>
	[Table("lotinfo_master")]
	public partial class LotinfoMaster
	{ 
		/// <summary>��ǃR�[�h</summary>
		[Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
		[Column("yakkyoku_code", Order = 0)]
		public string YakkyokuCode { get; set; }

		/// <summary>YJ�R�[�h</summary>
		[Column("yj_code")]
		public string YjCode { get; set; }

		/// <summary>GTIN�R�[�h</summary>
		[Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
		[Column("gtin_code", Order = 1)]
		public string GtinCode { get; set; }

		/// <summary>JAN�R�[�h</summary>
		[Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
		[Column("jan_code", Order = 2)]
		public string JanCode { get; set; }

		/// <summary>�g�p����</summary>
		[Column("shiyo_kigen")]
		public string ShiyoKigen { get; set; }

		/// <summary>���b�g</summary>
		[Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
		[Column("lot_bango", Order = 3)]
		public string LotBango { get; set; }

		/// <summary>���ɐ�</summary>
		[Column("in_count")]
		public decimal? InCount { get; set; }

		/// <summary>�o�ɐ�</summary>
		[Column("out_count")]
		public decimal? OutCount { get; set; }

		/// <summary>�o�^��</summary>
		[Column("insert_date")]
		public DateTime? InsertDate { get; set; }

		/// <summary>�X�V��</summary>
		[Column("update_date")]
		public DateTime? UpdateDate { get; set; }

		/// <summary>�ʒm����</summary>
		[Column("tsuchi_sikibetsu")]
		public int? TsuchiSikibetsu { get; set; }

		/// <summary>�ʒm����</summary>
		[Column("tsuchi_date")]
		public DateTime? TsuchiDate { get; set; }

		/// <summary> �R���X�g���N�^</summary>
		public LotinfoMaster()
		{

			YakkyokuCode = "";
			YjCode = "";
			GtinCode = "";
			JanCode = "";
			ShiyoKigen = "";
			LotBango = "";
			InCount = 0;
			OutCount = 0;
			InsertDate = null;
			UpdateDate = null;
			TsuchiSikibetsu = 0;
			TsuchiDate = null;

		}
	} 
} 
