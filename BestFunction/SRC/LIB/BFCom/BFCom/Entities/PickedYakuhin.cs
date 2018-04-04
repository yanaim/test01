namespace B2.BestFunction.Entities
{ 
	using System; 
	using System.Collections.Generic; 
	using System.ComponentModel.DataAnnotations; 
	using System.ComponentModel.DataAnnotations.Schema; 

	/// <summary>Picked��i</summary>
	[Table("picked_yakuhin")]
	public partial class PickedYakuhin
	{ 
		/// <summary>PickedID</summary>
		[Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
		[Column("picked_id", Order = 0)]
		public int? PickedId { get; set; }

		/// <summary>�����ID</summary>
		[Column("shohosen_id")]
		public int? ShohosenId { get; set; }

		/// <summary>��ǃR�[�h</summary>
		[Column("yakkyoku_code")]
		public string YakkyokuCode { get; set; }

		/// <summary>PickedYjID</summary>
		[Column("picked_yj_id")]
		public int? PickedYjId { get; set; }

		/// <summary>GTIN�R�[�h</summary>
		[Column("gtin_code")]
		public string GtinCode { get; set; }

		/// <summary>����</summary>
		[Column("hako_qty")]
		public decimal? HakoQty { get; set; }

		/// <summary>���</summary>
		[Column("housou_qty")]
		public decimal? HousouQty { get; set; }

		/// <summary>�o����</summary>
		[Column("bara_qty")]
		public decimal? BaraQty { get; set; }

		/// <summary>Lot�ԍ�</summary>
		[Column("lot_bango")]
		public string LotBango { get; set; }

		/// <summary>�g�p����</summary>
		[Column("shiyou_kigen")]
		public DateTime? ShiyouKigen { get; set; }

		/// <summary>Picked����</summary>
		[Column("picked_nitiji")]
		public DateTime? PickedNitiji { get; set; }

		/// <summary>����@�t���O</summary>
		[Column("bunpoki_flag")]
		public int? BunpokiFlag { get; set; }

		/// <summary>�o�^����</summary>
		[Column("insert_nitiji")]
		public DateTime? InsertNitiji { get; set; }

		/// <summary>�o�^���[�U�[ID</summary>
		[Column("insert_user_id")]
		public int? InsertUserId { get; set; }

		/// <summary>�o�^�[��ID</summary>
		[Column("insert_tanmatsu_id")]
		public string InsertTanmatsuId { get; set; }

		/// <summary>�o�^�v���O����</summary>
		[Column("insert_program")]
		public string InsertProgram { get; set; }

		/// <summary>�X�V����</summary>
		[Column("update_nitiji")]
		public DateTime? UpdateNitiji { get; set; }

		/// <summary>�X�V���[�U�[ID</summary>
		[Column("update_user_id")]
		public int? UpdateUserId { get; set; }

		/// <summary>�X�V�[��ID</summary>
		[Column("update_tanmatsu_id")]
		public string UpdateTanmatsuId { get; set; }

		/// <summary>�X�V�v���O����</summary>
		[Column("update_program")]
		public string UpdateProgram { get; set; }

		/// <summary>�t�@�C����</summary>
		[Column("file_mei")]
		public string FileMei { get; set; }

		/// <summary>�����t���O</summary>
		[Column("hikiotoshi")]
		public int? Hikiotoshi { get; set; }

		/// <summary> �R���X�g���N�^</summary>
		public PickedYakuhin()
		{

			PickedId = 0;
			ShohosenId = 0;
			YakkyokuCode = "";
			PickedYjId = 0;
			GtinCode = "";
			HakoQty = 0;
			HousouQty = 0;
			BaraQty = 0;
			LotBango = "";
			ShiyouKigen = null;
			PickedNitiji = null;
			BunpokiFlag = 0;
			InsertNitiji = null;
			InsertUserId = 0;
			InsertTanmatsuId = "";
			InsertProgram = "";
			UpdateNitiji = null;
			UpdateUserId = 0;
			UpdateTanmatsuId = "";
			UpdateProgram = "";
			FileMei = "";
			Hikiotoshi = 0;

		}
	} 
} 
