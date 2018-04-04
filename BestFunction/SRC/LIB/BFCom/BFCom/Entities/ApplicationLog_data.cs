namespace B2.BestFunction.Entities
{ 
	using System; 
	using System.Collections.Generic; 
	using System.ComponentModel.DataAnnotations; 
	using System.ComponentModel.DataAnnotations.Schema; 

	/// <summary>�A�v���P�[�V�������O�e�[�u��</summary>
	[Table("application_log_data")]
	public partial class ApplicationLog_data
	{ 
		/// <summary>���OID</summary>
		[Key]
		[Column("log_id")]
		public int? LogId { get; set; }

		/// <summary>��ǃR�[�h</summary>
		[Column("yakkyoku_code")]
		public string YakkyokuCode { get; set; }

		/// <summary>�v���O������</summary>
		[Column("program_filename")]
		public string ProgramFilename { get; set; }

		/// <summary>���O�^�C�v</summary>
		[Column("log_type")]
		public string LogType { get; set; }

		/// <summary>���O���e</summary>
		[Column("log_data")]
		public string LogData { get; set; }

		/// <summary>���l</summary>
		[Column("bikou")]
		public string Bikou { get; set; }

		/// <summary>�o�^����</summary>
		[Column("insert_nitiji")]
		public DateTime? InsertNitiji { get; set; }

		/// <summary> �R���X�g���N�^</summary>
		public ApplicationLog_data()
		{

			LogId = 0;
			YakkyokuCode = "";
			ProgramFilename = "";
			LogType = "";
			LogData = "";
			Bikou = "";
			InsertNitiji = null;

		}
	} 
} 
