namespace B2.BestFunction.Entities
{ 
	using System; 
	using System.Collections.Generic; 
	using System.ComponentModel.DataAnnotations; 
	using System.ComponentModel.DataAnnotations.Schema; 

	/// <summary>�J�X�^�}�C�Y���e�[�u��</summary>
	[Table("ini_master")]
	public partial class IniMaster
	{ 
		/// <summary>��ǃR�[�h</summary>
		[Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
		[Column("yakkyoku_code", Order = 0)]
		public string YakkyokuCode { get; set; }

		/// <summary>�v���O������</summary>
		[Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
		[Column("program", Order = 1)]
		public string Program { get; set; }

		/// <summary>�Z�N�V����</summary>
		[Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
		[Column("section", Order = 2)]
		public string Section { get; set; }

		/// <summary>�L�[</summary>
		[Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
		[Column("keycode", Order = 3)]
		public string Keycode { get; set; }

		/// <summary>�l</summary>
		[Column("data")]
		public string Data { get; set; }

		/// <summary>���l</summary>
		[Column("biko")]
		public string Biko { get; set; }

		/// <summary>�g�p�J�n</summary>
		[Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
		[Column("start_use_date", Order = 4)]
		public int? StartUseDate { get; set; }

		/// <summary>�g�p�I��</summary>
		[Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
		[Column("end_use_date", Order = 5)]
		public int? EndUseDate { get; set; }

		/// <summary> �R���X�g���N�^</summary>
		public IniMaster()
		{

			YakkyokuCode = "";
			Program = "";
			Section = "";
			Keycode = "";
			Data = "";
			Biko = "";
			StartUseDate = 0;
			EndUseDate = 0;

		}
	} 
} 
