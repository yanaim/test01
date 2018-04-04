namespace B2.BestFunction.Entities
{ 
	using System; 
	using System.Collections.Generic; 
	using System.ComponentModel.DataAnnotations; 
	using System.ComponentModel.DataAnnotations.Schema; 

	/// <summary>�I���w�b�_</summary>
	[Table("tanaoroshi_header")]
	public partial class TanaoroshiHeader
	{ 
		/// <summary>�I��ID</summary>
		[Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
		[Column("tanaoroshi_header_id", Order = 0)]
		public int? TanaoroshiHeaderId { get; set; }

		/// <summary>��ǃR�[�h</summary>
		[Column("yakkyoku_code")]
		public string YakkyokuCode { get; set; }

		/// <summary>�I���N����</summary>
		[Column("tanaoroshi_ymd")]
		public string TanaoroshiYmd { get; set; }

		/// <summary>�I����</summary>
		[Column("tanaoroshi_mei")]
		public string TanaoroshiMei { get; set; }

		/// <summary>�I���敪</summary>
		[Column("tanaoroshi_kubun")]
		public string TanaoroshiKubun { get; set; }

		/// <summary>�I�������t���O</summary>
		[Column("tanaoroshi_kanryou_flag")]
		public string TanaoroshiKanryouFlag { get; set; }

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

		/// <summary>�X�V�v���O����ID</summary>
		[Column("update_program_id")]
		public string UpdateProgramId { get; set; }

		/// <summary>�ʒm����</summary>
		[Column("tsuchi_sikibetsu")]
		public int? TsuchiSikibetsu { get; set; }

		/// <summary>�ʒm����</summary>
		[Column("tsuchi_date")]
		public DateTime? TsuchiDate { get; set; }

		/// <summary> �R���X�g���N�^</summary>
		public TanaoroshiHeader()
		{

			TanaoroshiHeaderId = 0;
			YakkyokuCode = "";
			TanaoroshiYmd = "";
			TanaoroshiMei = "";
			TanaoroshiKubun = "";
			TanaoroshiKanryouFlag = "";
			InsertUserId = 0;
			InsertNitiji = null;
			UpdateUserId = 0;
			UpdateNitiji = null;
			UpdateProgramId = "";
			TsuchiSikibetsu = 0;
			TsuchiDate = null;

		}
	} 
} 
