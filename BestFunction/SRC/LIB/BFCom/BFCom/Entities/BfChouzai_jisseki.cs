namespace B2.BestFunction.Entities
{ 
	using System; 
	using System.Collections.Generic; 
	using System.ComponentModel.DataAnnotations; 
	using System.ComponentModel.DataAnnotations.Schema; 

	/// <summary>BF���܎��ѐ��e�[�u��</summary>
	[Table("bf_chouzai_jisseki")]
	public partial class BfChouzai_jisseki
	{ 
		/// <summary>��ǃR�[�h</summary>
		[Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
		[Column("yakkyoku_code", Order = 0)]
		public string YakkyokuCode { get; set; }

		/// <summary>���i�R�[�h</summary>
		[Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
		[Column("gtin_code", Order = 1)]
		public string GtinCode { get; set; }

		/// <summary>���ܓ�</summary>
		[Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
		[Column("cymd", Order = 2)]
		public DateTime? Cymd { get; set; }

		/// <summary>���܉�</summary>
		[Column("cnt")]
		public int? Cnt { get; set; }

		/// <summary>�����</summary>
		[Column("used_su")]
		public decimal? UsedSu { get; set; }

		/// <summary> �R���X�g���N�^</summary>
		public BfChouzai_jisseki()
		{

			YakkyokuCode = "";
			GtinCode = "";
			Cymd = null;
			Cnt = 0;
			UsedSu = 0;

		}
	} 
} 
