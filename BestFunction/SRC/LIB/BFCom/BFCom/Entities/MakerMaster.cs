namespace B2.BestFunction.Entities
{ 
	using System; 
	using System.Collections.Generic; 
	using System.ComponentModel.DataAnnotations; 
	using System.ComponentModel.DataAnnotations.Schema; 

	/// <summary>���[�J�[�}�X�^</summary>
	[Table("maker_master")]
	public partial class MakerMaster
	{ 
		/// <summary>���[�J�[�R�[�h</summary>
		[Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
		[Column("maker_code", Order = 0)]
		public string MakerCode { get; set; }

		/// <summary>���[�J�[��</summary>
		[Column("maker_name")]
		public string MakerName { get; set; }

		/// <summary>���[�J�[���i�J�i�j</summary>
		[Column("maker_kana")]
		public string MakerKana { get; set; }

		/// <summary>�����R�[�h</summary>
		[Column("tougou_code")]
		public string TougouCode { get; set; }

		/// <summary> �R���X�g���N�^</summary>
		public MakerMaster()
		{

			MakerCode = "";
			MakerName = "";
			MakerKana = "";
			TougouCode = "";

		}
	} 
} 
