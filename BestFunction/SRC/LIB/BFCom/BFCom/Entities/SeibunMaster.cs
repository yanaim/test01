namespace B2.BestFunction.Entities
{ 
	using System; 
	using System.Collections.Generic; 
	using System.ComponentModel.DataAnnotations; 
	using System.ComponentModel.DataAnnotations.Schema; 

	/// <summary>�����}�X�^</summary>
	[Table("seibun_master")]
	public partial class SeibunMaster
	{ 
		/// <summary>�����R�[�h</summary>
		[Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
		[Column("seibun_code", Order = 0)]
		public string SeibunCode { get; set; }

		/// <summary>������</summary>
		[Column("seibun_mei")]
		public string SeibunMei { get; set; }

		/// <summary>�������t���K�i</summary>
		[Column("seibun_kana")]
		public string SeibunKana { get; set; }

		/// <summary>�K�p�J�n�N����</summary>
		[Column("apply_start_ymd")]
		public string ApplyStartYmd { get; set; }

		/// <summary>�K�p�I���N����</summary>
		[Column("apply_end_ymd")]
		public string ApplyEndYmd { get; set; }

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

		/// <summary>�Ǘ�����</summary>
		[Column("kanri_zokusei")]
		public int? KanriZokusei { get; set; }

		/// <summary> �R���X�g���N�^</summary>
		public SeibunMaster()
		{

			SeibunCode = "";
			SeibunMei = "";
			SeibunKana = "";
			ApplyStartYmd = "";
			ApplyEndYmd = "";
			InsertUserId = 0;
			InsertNitiji = null;
			UpdateUserId = 0;
			UpdateNitiji = null;
			UpdateProgramId = "";
			KanriZokusei = 0;

		}
	} 
} 
