namespace B2.BestFunction.Entities
{ 
	using System; 
	using System.Collections.Generic; 
	using System.ComponentModel.DataAnnotations; 
	using System.ComponentModel.DataAnnotations.Schema; 

	/// <summary>��i�}�X�^</summary>
	[Table("yakuhin_master")]
	public partial class YakuhinMaster
	{ 
		/// <summary>PDS�R�[�h</summary>
		[Column("pds_code")]
		public string PdsCode { get; set; }

		/// <summary>HOT�R�[�h</summary>
		[Column("hot_code")]
		public string HotCode { get; set; }

		/// <summary>HOT7�R�[�h</summary>
		[Column("hot7_code")]
		public string Hot7Code { get; set; }

		/// <summary>YJ�R�[�h</summary>
		[Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
		[Column("yj_code", Order = 0)]
		public string YjCode { get; set; }

		/// <summary>�ʈ��i�R�[�h</summary>
		[Column("kobetsu_iyakuhin_code")]
		public string KobetsuIyakuhinCode { get; set; }

		/// <summary>JAN�R�[�h</summary>
		[Column("jan_code")]
		public string JanCode { get; set; }

		/// <summary>GTIN�R�[�h</summary>
		[Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
		[Column("gtin_code", Order = 1)]
		public string GtinCode { get; set; }

		/// <summary>GTIN�R�[�h���ܕ�P��</summary>
		[Column("gtin_code_chozaihosotani")]
		public string GtinCodeChozaihosotani { get; set; }

		/// <summary>��i��</summary>
		[Column("yakuhin_mei")]
		public string YakuhinMei { get; set; }

		/// <summary>��i�t���K�i</summary>
		[Column("yakuhin_kana")]
		public string YakuhinKana { get; set; }

		/// <summary>�K�i�P��</summary>
		[Column("kikaku_tanni")]
		public string KikakuTanni { get; set; }

		/// <summary>��`��</summary>
		[Column("housou_keitai")]
		public string HousouKeitai { get; set; }

		/// <summary>��P�ʐ�</summary>
		[Column("housou_tanni_qty")]
		public decimal? HousouTanniQty { get; set; }

		/// <summary>��P�ʒP��</summary>
		[Column("housou_tanni_tanni")]
		public string HousouTanniTanni { get; set; }

		/// <summary>����ʐ�</summary>
		[Column("housou_souryou_qty")]
		public decimal? HousouSouryouQty { get; set; }

		/// <summary>����ʒP��</summary>
		[Column("housou_suryou_tanni")]
		public string HousouSuryouTanni { get; set; }

		/// <summary>�敪</summary>
		[Column("kubun")]
		public string Kubun { get; set; }

		/// <summary>������ޖ�</summary>
		[Column("yakkou_bunrui_mei")]
		public string YakkouBunruiMei { get; set; }

		/// <summary>�܌`�敪��</summary>
		[Column("zaikei_kubun_mei")]
		public string ZaikeiKubunMei { get; set; }

		/// <summary>������</summary>
		[Column("seibun_mei")]
		public string SeibunMei { get; set; }

		/// <summary>��</summary>
		[Column("yakka")]
		public decimal? Yakka { get; set; }

		/// <summary>�Ŗ�t���O</summary>
		[Column("dokuyaku_flag")]
		public string DokuyakuFlag { get; set; }

		/// <summary>����t���O</summary>
		[Column("gekiyaku_flag")]
		public string GekiyakuFlag { get; set; }

		/// <summary>����t���O</summary>
		[Column("mayaku_flag")]
		public string MayakuFlag { get; set; }

		/// <summary>�o���܃t���O</summary>
		[Column("kakuseizai_flag")]
		public string KakuseizaiFlag { get; set; }

		/// <summary>�����w�I���܃t���O</summary>
		[Column("seibutsugakuteki_seizai_flag")]
		public string SeibutsugakutekiSeizaiFlag { get; set; }

		/// <summary>���e�܃t���O</summary>
		[Column("zoueizai_flag")]
		public string ZoueizaiFlag { get; set; }

		/// <summary>�����_��t���O</summary>
		[Column("kouseishinyaku_flag")]
		public string KouseishinyakuFlag { get; set; }

		/// <summary>������Ж�</summary>
		[Column("seizou_kaisha_mei")]
		public string SeizouKaishaMei { get; set; }

		/// <summary>�̔���Ж�</summary>
		[Column("hanbai_kaisha_mei")]
		public string HanbaiKaishaMei { get; set; }

		/// <summary>������</summary>
		[Column("kokuji_ymd")]
		public string KokujiYmd { get; set; }

		/// <summary>�o�ߑ[�u��</summary>
		[Column("keika_sochi_ymd")]
		public string KeikaSochiYmd { get; set; }

		/// <summary>�̔����~��</summary>
		[Column("hanbai_chushi_ymd")]
		public string HanbaiChushiYmd { get; set; }

		/// <summary>�K�p�J�n�N����</summary>
		[Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
		[Column("apply_start_ymd", Order = 2)]
		public string ApplyStartYmd { get; set; }

		/// <summary>�K�p�I���N����</summary>
		[Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
		[Column("apply_end_ymd", Order = 3)]
		public string ApplyEndYmd { get; set; }

		/// <summary>�o�^��ID</summary>
		[Column("insert_user_id")]
		public int? InsertUserId { get; set; }

		/// <summary>�o�^����</summary>
		[Column("insert_nitiji")]
		public DateTime? InsertNitiji { get; set; }

		/// <summary>�X�V��ID</summary>
		[Column("update_user_id")]
		public int? UpdateUserId { get; set; }

		/// <summary>�X�V����</summary>
		[Column("update_nitiji")]
		public DateTime? UpdateNitiji { get; set; }

		/// <summary>�X�V�v���O����ID</summary>
		[Column("update_program_id")]
		public string UpdateProgramId { get; set; }

		/// <summary>�Ǘ�����</summary>
		[Column("kanri_zokusei")]
		public int? KanriZokusei { get; set; }

		/// <summary> �R���X�g���N�^</summary>
		public YakuhinMaster()
		{

			PdsCode = "";
			HotCode = "";
			Hot7Code = "";
			YjCode = "";
			KobetsuIyakuhinCode = "";
			JanCode = "";
			GtinCode = "";
			GtinCodeChozaihosotani = "";
			YakuhinMei = "";
			YakuhinKana = "";
			KikakuTanni = "";
			HousouKeitai = "";
			HousouTanniQty = 0;
			HousouTanniTanni = "";
			HousouSouryouQty = 0;
			HousouSuryouTanni = "";
			Kubun = "";
			YakkouBunruiMei = "";
			ZaikeiKubunMei = "";
			SeibunMei = "";
			Yakka = 0;
			DokuyakuFlag = "";
			GekiyakuFlag = "";
			MayakuFlag = "";
			KakuseizaiFlag = "";
			SeibutsugakutekiSeizaiFlag = "";
			ZoueizaiFlag = "";
			KouseishinyakuFlag = "";
			SeizouKaishaMei = "";
			HanbaiKaishaMei = "";
			KokujiYmd = "";
			KeikaSochiYmd = "";
			HanbaiChushiYmd = "";
			ApplyStartYmd = "";
			ApplyEndYmd = "";
			InsertUserId = 0;
			InsertNitiji = null;
			UpdateUserId = 0;
			UpdateNitiji = null;
			UpdateProgramId = "";
			KanriZokusei = 0;

		}
	} 
} 
