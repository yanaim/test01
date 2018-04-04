namespace B2.BestFunction.Entities
{ 
	using System; 
	using System.Collections.Generic; 
	using System.ComponentModel.DataAnnotations; 
	using System.ComponentModel.DataAnnotations.Schema; 

	/// <summary>���O�C�����</summary>
	[Table("login_info")]
	public partial class LoginInfo
	{ 
		/// <summary>���O�C��ID</summary>
		[Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
		[Column("login_id")]
		public int LoginId { get; set; }

		/// <summary>���[�U�[ID</summary>
		[Column("user_id")]
		public int? UserId { get; set; }

		/// <summary>���O�C������</summary>
		[Column("login_nitiji")]
		public DateTime? LoginNitiji { get; set; }

		/// <summary>���O�A�E�g����</summary>
		[Column("logout_nitiji")]
		public DateTime? LogoutNitiji { get; set; }

		/// <summary>�Z�b�V����ID</summary>
		[Column("session_id")]
		public string SessionId { get; set; }

		/// <summary>�Z�b�V��������</summary>
		[Column("session_nitiji")]
		public DateTime? SessionNitiji { get; set; }

		/// <summary>�Z�b�V����IP</summary>
		[Column("session_ip")]
		public string SessionIp { get; set; }

		/// <summary>�Z�b�V�����h���C����</summary>
		[Column("session_dns")]
		public string SessionDns { get; set; }

		/// <summary>���[�U�[�G�[�W�F���g</summary>
		[Column("user_agent")]
		public string UserAgent { get; set; }

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
		public LoginInfo()
		{

			LoginId = 0;
			UserId = 0;
			LoginNitiji = null;
			LogoutNitiji = null;
			SessionId = "";
			SessionNitiji = null;
			SessionIp = "";
			SessionDns = "";
			UserAgent = "";
			InsertUserId = 0;
			InsertNitiji = null;
			UpdateUserId = 0;
			UpdateNitiji = null;
			UpdateProgramId = "";
			KanriZokusei = 0;

		}
	} 
} 
