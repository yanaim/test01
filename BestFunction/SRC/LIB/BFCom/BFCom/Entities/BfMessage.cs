namespace B2.BestFunction.Entities
{ 
	using System; 
	using System.Collections.Generic; 
	using System.ComponentModel.DataAnnotations; 
	using System.ComponentModel.DataAnnotations.Schema; 

	/// <summary>���b�Z�[�W�e�|�u��</summary>
	[Table("bf_message")]
	public partial class BfMessage
	{ 
		/// <summary>�A��</summary>
		[Key]
		[Column("denpyo_bango")]
		public int? DenpyoBango { get; set; }

		/// <summary>�o�^��</summary>
		[Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
		[Column("insert_date", Order = 0)]
		public DateTime? InsertDate { get; set; }

		/// <summary>���s������</summary>
		[Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
		[Column("hakkoumoto_shikibetu", Order = 1)]
		public int? HakkoumotoShikibetu { get; set; }

		/// <summary>���s����ǃR�[�h</summary>
		[Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
		[Column("yakkyoku_code_from", Order = 2)]
		public string YakkyokuCodeFrom { get; set; }

		/// <summary>���s����</summary>
		[Column("hakkoumoto_name")]
		public string HakkoumotoName { get; set; }

		/// <summary>��M���ǃR�[�h</summary>
		[Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
		[Column("yakkyoku_code_to", Order = 3)]
		public string YakkyokuCodeTo { get; set; }

		/// <summary>���Ǔ�</summary>
		[Column("kidoku_date")]
		public DateTime? KidokuDate { get; set; }

		/// <summary>���b�Z�[�W</summary>
		[Column("message")]
		public string Message { get; set; }

		/// <summary> �R���X�g���N�^</summary>
		public BfMessage()
		{

			DenpyoBango = 0;
			InsertDate = null;
			HakkoumotoShikibetu = 0;
			YakkyokuCodeFrom = "";
			HakkoumotoName = "";
			YakkyokuCodeTo = "";
			KidokuDate = null;
			Message = "";

		}
	} 
} 
