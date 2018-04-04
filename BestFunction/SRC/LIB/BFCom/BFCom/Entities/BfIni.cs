namespace B2.BestFunction.Entities
{ 
	using System; 
	using System.Collections.Generic; 
	using System.ComponentModel.DataAnnotations; 
	using System.ComponentModel.DataAnnotations.Schema; 

	/// <summary>BF�h�m�h�e�[�u��</summary>
	[Table("bf_ini")]
	public partial class BfIni
	{ 
		/// <summary>��ǃR�[�h</summary>
		[Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
		[Column("yakkyoku_code", Order = 0)]
		public string YakkyokuCode { get; set; }

		/// <summary>�I�y���[�^�R�[�h</summary>
		[Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
		[Column("opecd", Order = 1)]
		public string Opecd { get; set; }

		/// <summary>�v���O������</summary>
		[Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
		[Column("prognm", Order = 2)]
		public string Prognm { get; set; }

		/// <summary>�Z�N�V����</summary>
		[Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
		[Column("section", Order = 3)]
		public string Section { get; set; }

		/// <summary>�L�[</summary>
		[Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
		[Column("key1", Order = 4)]
		public string Key1 { get; set; }

		/// <summary>�l</summary>
		[Column("data")]
		public string Data { get; set; }

		/// <summary>���l</summary>
		[Column("biko")]
		public string Biko { get; set; }

		/// <summary> �R���X�g���N�^</summary>
		public BfIni()
		{

			YakkyokuCode = "";
			Opecd = "";
			Prognm = "";
			Section = "";
			Key1 = "";
			Data = "";
			Biko = "";

		}
	} 
} 
