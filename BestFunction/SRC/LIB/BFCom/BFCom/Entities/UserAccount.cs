namespace B2.BestFunction.Entities
{ 
	using System; 
	using System.Collections.Generic; 
	using System.ComponentModel.DataAnnotations; 
	using System.ComponentModel.DataAnnotations.Schema; 

	/// <summary>���[�U�A�J�E���g</summary>
	[Table("user_account")]
	public partial class UserAccount
	{ 
		/// <summary>���[�UID</summary>
		[Key]
		[Column("user_id")]
		public int UserId { get; set; }

		/// <summary>�p�X���[�h</summary>
		[Column("password")]
		public string Password { get; set; }

		/// <summary>PDS_ID</summary>
		[Column("pds_id")]
		public string PdsId { get; set; }

		/// <summary>E���[���A�h���X</summary>
		[Column("mail_address")]
		public string MailAddress { get; set; }

		/// <summary>��ǃR�[�h</summary>
		[Column("yakkyoku_code")]
		public string YakkyokuCode { get; set; }

		/// <summary>����</summary>
		[Column("kengen")]
		public string Kengen { get; set; }

		/// <summary>�A�J�E���g�����N</summary>
		[Column("account_rank")]
		public string AccountRank { get; set; }

		/// <summary>�A�J�E���g�敪</summary>
		[Column("account_kubun")]
		public string AccountKubun { get; set; }

		/// <summary>�A�J�E���g�폜�t���O</summary>
		[Column("account_sakujo_flag")]
		public string AccountSakujoFlag { get; set; }

		/// <summary>�A�J�E���g��~�t���O</summary>
		[Column("account_teishi_flag")]
		public string AccountTeishiFlag { get; set; }

		/// <summary>�^�c�R�����g</summary>
		[Column("unei_comment")]
		public string UneiComment { get; set; }

		/// <summary>�_��N����</summary>
		[Column("keiyaku_ymd")]
		public string KeiyakuYmd { get; set; }

		/// <summary>�����N����</summary>
		[Column("kaijo_ymd")]
		public string KaijoYmd { get; set; }

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

		/// <summary> �R���X�g���N�^</summary>
		public UserAccount()
		{

			UserId = 0;
			Password = "";
			PdsId = "";
			MailAddress = "";
			YakkyokuCode = "";
			Kengen = "";
			AccountRank = "";
			AccountKubun = "";
			AccountSakujoFlag = "";
			AccountTeishiFlag = "";
			UneiComment = "";
			KeiyakuYmd = "";
			KaijoYmd = "";
			InsertUserId = 0;
			InsertNitiji = null;
			UpdateUserId = 0;
			UpdateNitiji = null;
			UpdateProgramId = "";

		}
	} 
} 
