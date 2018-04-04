namespace B2.BestFunction.Entities
{ 
	using System; 
	using System.Collections.Generic; 
	using System.ComponentModel.DataAnnotations; 
	using System.ComponentModel.DataAnnotations.Schema; 

	/// <summary>�R���{�{�b�N�X�e�[�u��</summary>
	[Table("combodata")]
	public partial class Combodata
	{ 
		/// <summary>��۸���ID</summary>
		[Column("program_id")]
		public string ProgramId { get; set; }

		/// <summary>��L�[</summary>
		[Key]
		[Column("seq_no")]
		public int? SeqNo { get; set; }

		/// <summary>���ږ���</summary>
		[Column("field_data")]
		public string FieldData { get; set; }

		/// <summary>���l</summary>
		[Column("biko")]
		public string Biko { get; set; }

		/// <summary> �R���X�g���N�^</summary>
		public Combodata()
		{

			ProgramId = "";
			SeqNo = 0;
			FieldData = "";
			Biko = "";

		}
	} 
} 
