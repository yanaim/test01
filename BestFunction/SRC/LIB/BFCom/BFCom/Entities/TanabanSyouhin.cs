namespace B2.BestFunction.Entities
{ 
	using System; 
	using System.Collections.Generic; 
	using System.ComponentModel.DataAnnotations; 
	using System.ComponentModel.DataAnnotations.Schema; 

	/// <summary>�I�ԏ��i�Ǘ��}�X�^</summary>
	[Table("tanaban_syouhin")]
	public partial class TanabanSyouhin
	{ 
		/// <summary>��ǃR�[�h</summary>
		[Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
		[Column("yakkyoku_code", Order = 0)]
		public string YakkyokuCode { get; set; }

		/// <summary>�I�ԃR�[�h</summary>
		[Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
		[Column("tanaban_code", Order = 1)]
		public string TanabanCode { get; set; }

		/// <summary>GTIN�R�[�h</summary>
		[Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
		[Column("gtin_code", Order = 2)]
		public string GtinCode { get; set; }

		/// <summary>�i</summary>
		[Column("dan")]
		public int? Dan { get; set; }

		/// <summary>��</summary>
		[Column("retu")]
		public int? Retu { get; set; }

		/// <summary>���l</summary>
		[Column("bikou")]
		public string Bikou { get; set; }

		/// <summary>�o�^��ID</summary>
		[Column("insert_user_id")]
		public int? InsertUserId { get; set; }

		/// <summary>�o�^����</summary>
		[Column("insert_nitiji")]
		public DateTime? InsertNitiji { get; set; }

		/// <summary>�X�V��ID</summary>
		[Column("update_user_id")]
		public int? UpdateUserId { get; set; }

		/// <summary>�X�V����</summary>
		[Column("update_nitiji")]
		public DateTime? UpdateNitiji { get; set; }

		/// <summary>�ʒm����</summary>
		[Column("tsuchi_sikibetsu")]
		public int? TsuchiSikibetsu { get; set; }

		/// <summary>�ʒm����</summary>
		[Column("tsuchi_date")]
		public DateTime? TsuchiDate { get; set; }

		/// <summary>�Ǘ�����</summary>
		[Column("kanri_zokusei")]
		public int? KanriZokusei { get; set; }

		/// <summary> �R���X�g���N�^</summary>
		public TanabanSyouhin()
		{

			YakkyokuCode = "";
			TanabanCode = "";
			GtinCode = "";
			Dan = 0;
			Retu = 0;
			Bikou = "";
			InsertUserId = 0;
			InsertNitiji = null;
			UpdateUserId = 0;
			UpdateNitiji = null;
			TsuchiSikibetsu = 0;
			TsuchiDate = null;
			KanriZokusei = 0;

		}
	} 
} 
