namespace B2.BestFunction.Entities
{ 
	using System; 
	using System.Collections.Generic; 
	using System.ComponentModel.DataAnnotations; 
	using System.ComponentModel.DataAnnotations.Schema; 

	/// <summary>���Ƀw�b�_</summary>
	[Table("nyuko_header")]
	public partial class NyukoHeader
	{ 
		/// <summary>��ǃR�[�h</summary>
		[Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
		[Column("yakkyoku_code", Order = 0)]
		public string YakkyokuCode { get; set; }

		/// <summary>�`�[�ԍ�</summary>
		[Key]
		[Column("denpyo_bango")]
		public int? DenpyoBango { get; set; }

		/// <summary>���א�</summary>
		[Column("meisaisu")]
		public int? Meisaisu { get; set; }

		/// <summary>�`�[�敪</summary>
		[Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
		[Column("denpyo_kubun", Order = 1)]
		public int? DenpyoKubun { get; set; }

		/// <summary>������</summary>
		[Column("shori_date")]
		public DateTime? ShoriDate { get; set; }

		/// <summary>�����R�[�h</summary>
		[Column("torihikisaki_code")]
		public string TorihikisakiCode { get; set; }

		/// <summary>���R�[�h</summary>
		[Column("oroshi_code")]
		public string OroshiCode { get; set; }

		/// <summary>����ŎZ�o�敪</summary>
		[Column("shohizei_sanshutsu_kubun")]
		public int? ShohizeiSanshutsuKubun { get; set; }

		/// <summary>����ŋ敪</summary>
		[Column("shohizai_kubun")]
		public int? ShohizaiKubun { get; set; }

		/// <summary>���z</summary>
		[Column("kingaku")]
		public decimal? Kingaku { get; set; }

		/// <summary>����ŋ��z</summary>
		[Column("shohizei_kingaku")]
		public decimal? ShohizeiKingaku { get; set; }

		/// <summary>���v���z</summary>
		[Column("goke_kingaku")]
		public decimal? GokeKingaku { get; set; }

		/// <summary>�v�����g�敪</summary>
		[Column("print_kubun")]
		public int? PrintKubun { get; set; }

		/// <summary>�v�����g����</summary>
		[Column("print_nitiji")]
		public DateTime? PrintNitiji { get; set; }

		/// <summary>���M�敪</summary>
		[Column("soshin_kubun")]
		public int? SoshinKubun { get; set; }

		/// <summary>���M����</summary>
		[Column("soshin_nitiji")]
		public DateTime? SoshinNitiji { get; set; }

		/// <summary>�����`�[�ԍ�</summary>
		[Column("hacchu_denpyo_bango")]
		public int? HacchuDenpyoBango { get; set; }

		/// <summary>���l</summary>
		[Column("biko")]
		public string Biko { get; set; }

		/// <summary>�`�[�ԍ�PDS</summary>
		[Column("denpyo_bango_pds")]
		public int? DenpyoBangoPds { get; set; }

		/// <summary>�o�^����</summary>
		[Column("insert_nitiji")]
		public DateTime? InsertNitiji { get; set; }

		/// <summary>�ʒm����</summary>
		[Column("tsuchi_shikibetsu")]
		public int? TsuchiShikibetsu { get; set; }

		/// <summary>�ʒm����</summary>
		[Column("tsuchi_nitiji")]
		public DateTime? TsuchiNitiji { get; set; }

		/// <summary> �R���X�g���N�^</summary>
		public NyukoHeader()
		{

			YakkyokuCode = "";
			DenpyoBango = 0;
			Meisaisu = 0;
			DenpyoKubun = 0;
			ShoriDate = null;
			TorihikisakiCode = "";
			OroshiCode = "";
			ShohizeiSanshutsuKubun = 0;
			ShohizaiKubun = 0;
			Kingaku = 0;
			ShohizeiKingaku = 0;
			GokeKingaku = 0;
			PrintKubun = 0;
			PrintNitiji = null;
			SoshinKubun = 0;
			SoshinNitiji = null;
			HacchuDenpyoBango = 0;
			Biko = "";
			DenpyoBangoPds = 0;
			InsertNitiji = null;
			TsuchiShikibetsu = 0;
			TsuchiNitiji = null;

		}
	} 
} 
