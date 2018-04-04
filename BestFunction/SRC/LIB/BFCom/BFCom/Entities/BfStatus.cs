namespace B2.BestFunction.Entities
{ 
	using System; 
	using System.Collections.Generic; 
	using System.ComponentModel.DataAnnotations; 
	using System.ComponentModel.DataAnnotations.Schema; 

	/// <summary>BF��ԊǗ��e�[�u��</summary>
	[Table("bf_status")]
	public partial class BfStatus
	{ 
		/// <summary>��ǃR�[�h</summary>
		[Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
		[Column("yakkyoku_code", Order = 0)]
		public string YakkyokuCode { get; set; }

		/// <summary>�R���s���[�^��</summary>
		[Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
		[Column("comp_name", Order = 1)]
		public string CompName { get; set; }

		/// <summary>�L�[</summary>
		[Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
		[Column("key1", Order = 2)]
		public string Key1 { get; set; }

		/// <summary>�l</summary>
		[Column("data")]
		public string Data { get; set; }

		/// <summary> �R���X�g���N�^</summary>
		public BfStatus()
		{

			YakkyokuCode = "";
			CompName = "";
			Key1 = "";
			Data = "";

		}
	} 
} 
