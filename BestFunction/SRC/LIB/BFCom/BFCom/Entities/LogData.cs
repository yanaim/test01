namespace B2.BestFunction.Entities
{ 
	using System; 
	using System.Collections.Generic; 
	using System.ComponentModel.DataAnnotations; 
	using System.ComponentModel.DataAnnotations.Schema; 

	/// <summary>���b�Z�[�W���O�e�[�u��</summary>
	[Table("log_data")]
	public partial class LogData
	{ 
		/// <summary>��ǃR�[�h</summary>
		[Column("yakkyoku_code")]
		public string YakkyokuCode { get; set; }

		/// <summary>���ONo@���O�t�@�C����SEQ</summary>
		[Key]
		[Column("logno")]
		public int? Logno { get; set; }

		/// <summary>���t</summary>
		[Column("logdate")]
		public DateTime? Logdate { get; set; }

		/// <summary>��۸���ID</summary>
		[Column("program_code")]
		public string ProgramCode { get; set; }

		/// <summary>���ރR�[�h</summary>
		[Column("bunrui")]
		public string Bunrui { get; set; }

		/// <summary>�R���s���[�^��</summary>
		[Column("client")]
		public string Client { get; set; }

		/// <summary>���O�C��ID</summary>
		[Column("login_code")]
		public string LoginCode { get; set; }

		/// <summary>�L�[�R�[�h</summary>
		[Column("key_code")]
		public string KeyCode { get; set; }

		/// <summary>���l</summary>
		[Column("bikou")]
		public string Bikou { get; set; }

		/// <summary>EXE�t�@�C����</summary>
		[Column("filename")]
		public string Filename { get; set; }

		/// <summary>���s������</summary>
		[Column("param")]
		public string Param { get; set; }

		/// <summary>�L���t���O</summary>
		[Column("enable")]
		public int? Enable { get; set; }

		/// <summary> �R���X�g���N�^</summary>
		public LogData()
		{

			YakkyokuCode = "";
			Logno = 0;
			Logdate = null;
			ProgramCode = "";
			Bunrui = "";
			Client = "";
			LoginCode = "";
			KeyCode = "";
			Bikou = "";
			Filename = "";
			Param = "";
			Enable = 0;

		}
	} 
} 
