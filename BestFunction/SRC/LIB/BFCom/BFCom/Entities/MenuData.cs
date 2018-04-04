namespace B2.BestFunction.Entities
{ 
	using System; 
	using System.Collections.Generic; 
	using System.ComponentModel.DataAnnotations; 
	using System.ComponentModel.DataAnnotations.Schema; 

	/// <summary>���j���[�e�[�u��</summary>
	[Table("menu_data")]
	public partial class MenuData
	{ 
		/// <summary>���ޏo�͏�</summary>
		[Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
		[Column("bunrui_seq", Order = 0)]
		public int? BunruiSeq { get; set; }

		/// <summary>���ޖ�</summary>
		[Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
		[Column("bunrui_name", Order = 1)]
		public string BunruiName { get; set; }

		/// <summary>EXE�o�͏�</summary>
		[Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
		[Column("file_seq", Order = 2)]
		public int? FileSeq { get; set; }

		/// <summary>EXE�t�@�C����</summary>
		[Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
		[Column("filename", Order = 3)]
		public string Filename { get; set; }

		/// <summary>���{�ꖼ��</summary>
		[Column("program_name")]
		public string ProgramName { get; set; }

		/// <summary>���s������</summary>
		[Column("parameta")]
		public string Parameta { get; set; }

		/// <summary>�\�����@</summary>
		[Column("hyoujihouhou")]
		public int? Hyoujihouhou { get; set; }

		/// <summary>��������</summary>
		[Column("doukizokusei")]
		public int? Doukizokusei { get; set; }

		/// <summary>�t�H�[����</summary>
		[Column("formname")]
		public string Formname { get; set; }

		/// <summary>�@�\�ڍ�</summary>
		[Column("setumei")]
		public string Setumei { get; set; }

		/// <summary> �R���X�g���N�^</summary>
		public MenuData()
		{

			BunruiSeq = 0;
			BunruiName = "";
			FileSeq = 0;
			Filename = "";
			ProgramName = "";
			Parameta = "";
			Hyoujihouhou = 0;
			Doukizokusei = 0;
			Formname = "";
			Setumei = "";

		}
	} 
} 
