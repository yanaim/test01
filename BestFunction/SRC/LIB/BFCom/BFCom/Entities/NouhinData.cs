namespace B2.BestFunction.Entities
{ 
	using System; 
	using System.Collections.Generic; 
	using System.ComponentModel.DataAnnotations; 
	using System.ComponentModel.DataAnnotations.Schema; 

	/// <summary>�[�i�f�[�^</summary>
	[Table("nouhin_data")]
	public partial class NouhinData
	{ 
		/// <summary>��ǃR�[�h</summary>
		[Column("yakkyoku_code")]
		public string YakkyokuCode { get; set; }

		/// <summary>���R�[�h�敪</summary>
		[Column("record_kubun")]
		public string RecordKubun { get; set; }

		/// <summary>�f�[�^����</summary>
		[Column("data_class")]
		public string DataClass { get; set; }

		/// <summary>���M�����R�[�h</summary>
		[Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
		[Column("oroshi_code", Order = 0)]
		public string OroshiCode { get; set; }

		/// <summary>���M���Ë@�փR�[�h</summary>
		[Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
		[Column("iryokikan_code", Order = 1)]
		public string IryokikanCode { get; set; }

		/// <summary>�����M���Ë@�փR�[�h</summary>
		[Column("sub_iryokikan_code")]
		public string SubIryokikanCode { get; set; }

		/// <summary>�`�[�敪</summary>
		[Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
		[Column("slip_kubun", Order = 2)]
		public int? SlipKubun { get; set; }

		/// <summary>�`�[���t</summary>
		[Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
		[Column("slip_date", Order = 3)]
		public DateTime? SlipDate { get; set; }

		/// <summary>�`�[�ԍ�</summary>
		[Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
		[Column("slip_number", Order = 4)]
		public string SlipNumber { get; set; }

		/// <summary>�`�[�s�ԍ�</summary>
		[Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
		[Column("slip_line_number", Order = 5)]
		public int? SlipLineNumber { get; set; }

		/// <summary>���i�R�[�h�敪</summary>
		[Column("medicine_code_kubun")]
		public int? MedicineCodeKubun { get; set; }

		/// <summary>���i�R�[�h</summary>
		[Column("jan_code")]
		public string JanCode { get; set; }

		/// <summary>GTIN���i�R�[�h</summary>
		[Column("gtin_code")]
		public string GtinCode { get; set; }

		/// <summary>���i��</summary>
		[Column("name_alpha")]
		public string NameAlpha { get; set; }

		/// <summary>����</summary>
		[Column("suryo")]
		public decimal? Suryo { get; set; }

		/// <summary>�P��</summary>
		[Column("tanka")]
		public decimal? Tanka { get; set; }

		/// <summary>���z</summary>
		[Column("kingaku")]
		public decimal? Kingaku { get; set; }

		/// <summary>��</summary>
		[Column("yakka")]
		public decimal? Yakka { get; set; }

		/// <summary>�L������</summary>
		[Column("shiyo_kigen")]
		public DateTime? ShiyoKigen { get; set; }

		/// <summary>�����ԍ�</summary>
		[Column("lot_bango")]
		public string LotBango { get; set; }

		/// <summary>�Œ荀��</summary>
		[Column("filler1")]
		public string Filler1 { get; set; }

		/// <summary>�o�^����</summary>
		[Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
		[Column("insert_date", Order = 6)]
		public DateTime? InsertDate { get; set; }

		/// <summary>�t�@�C����</summary>
		[Column("file_name")]
		public string FileName { get; set; }

		/// <summary>���Ƀt���O</summary>
		[Column("nyuuko_flg")]
		public int? NyuukoFlg { get; set; }

		/// <summary> �R���X�g���N�^</summary>
		public NouhinData()
		{

			YakkyokuCode = "";
			RecordKubun = "";
			DataClass = "";
			OroshiCode = "";
			IryokikanCode = "";
			SubIryokikanCode = "";
			SlipKubun = 0;
			SlipDate = null;
			SlipNumber = "";
			SlipLineNumber = 0;
			MedicineCodeKubun = 0;
			JanCode = "";
			GtinCode = "";
			NameAlpha = "";
			Suryo = 0;
			Tanka = 0;
			Kingaku = 0;
			Yakka = 0;
			ShiyoKigen = null;
			LotBango = "";
			Filler1 = "";
			InsertDate = null;
			FileName = "";
			NyuukoFlg = 0;

		}
	} 
} 
