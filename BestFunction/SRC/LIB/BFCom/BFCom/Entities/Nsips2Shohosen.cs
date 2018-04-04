namespace B2.BestFunction.Entities
{ 
	using System; 
	using System.Collections.Generic; 
	using System.ComponentModel.DataAnnotations; 
	using System.ComponentModel.DataAnnotations.Schema; 

	/// <summary>NSIPS����ⳕ��e�[�u��</summary>
	[Table("nsips2_shohosen")]
	public partial class Nsips2Shohosen
	{ 
		/// <summary>Nsips2�����ID</summary>
		[Key]
		[Column("nsips2_shohosen_id")]
		public int? Nsips2ShohosenId { get; set; }

		/// <summary>Nsips0�w�b�_ID</summary>
		[Column("nsips0_header_id")]
		public int? Nsips0HeaderId { get; set; }

		/// <summary>���ʎq</summary>
		[Column("stype")]
		public int? Stype { get; set; }

		/// <summary>����Ⳕԍ�</summary>
		[Column("shohosen_bango")]
		public decimal? ShohosenBango { get; set; }

		/// <summary>��t�ԍ�</summary>
		[Column("uketsuke_bango")]
		public int? UketsukeBango { get; set; }

		/// <summary>�X�V�敪</summary>
		[Column("koshin_kubun")]
		public string KoshinKubun { get; set; }

		/// <summary>����Ⳍ�t�N����</summary>
		[Column("shohosen_kofu_nengappi")]
		public DateTime? ShohosenKofuNengappi { get; set; }

		/// <summary>�g�p�����N����</summary>
		[Column("shiyokigen_nengappi")]
		public DateTime? ShiyokigenNengappi { get; set; }

		/// <summary>��t�N����</summary>
		[Column("uketsuke_nengappi")]
		public DateTime? UketsukeNengappi { get; set; }

		/// <summary>���ܔN����</summary>
		[Column("chozai_nengappi")]
		public DateTime? ChozaiNengappi { get; set; }

		/// <summary>�D�w�����敪</summary>
		[Column("ninpujyunu_kubun")]
		public string NinpujyunuKubun { get; set; }

		/// <summary>�����č��w���t���O</summary>
		[Column("kyoseikansashiji_flag")]
		public string KyoseikansashijiFlag { get; set; }

		/// <summary>��Ë@�փR�[�h���</summary>
		[Column("iryokikan_code_shubetsu")]
		public string IryokikanCodeShubetsu { get; set; }

		/// <summary>��Ë@�փR�[�h</summary>
		[Column("iryokikan_code")]
		public string IryokikanCode { get; set; }

		/// <summary>��Ë@�փ��Z�v�g�R�[�h</summary>
		[Column("iryokikan_reseputo_code")]
		public string IryokikanReseputoCode { get; set; }

		/// <summary>��Ë@�֓s���{���R�[�h</summary>
		[Column("iryokikan_todofuken_code")]
		public string IryokikanTodofukenCode { get; set; }

		/// <summary>��Ë@�֖�</summary>
		[Column("iryokikan_mei")]
		public string IryokikanMei { get; set; }

		/// <summary>��Ë@�֗X�֋�</summary>
		[Column("iryokikan_yubinbango")]
		public string IryokikanYubinbango { get; set; }

		/// <summary>��Ë@�֏��ݒn</summary>
		[Column("iryokikan_shozaiti")]
		public string IryokikanShozaiti { get; set; }

		/// <summary>��Ë@�֓d�b�ԍ�</summary>
		[Column("iryokikan_denwabango")]
		public string IryokikanDenwabango { get; set; }

		/// <summary>�f�ÉȃR�[�h</summary>
		[Column("shinryoka_code")]
		public string ShinryokaCode { get; set; }

		/// <summary>�f�ÉȖ�</summary>
		[Column("shinryoka_mei")]
		public string ShinryokaMei { get; set; }

		/// <summary>�a���R�[�h</summary>
		[Column("byoto_code")]
		public string ByotoCode { get; set; }

		/// <summary>�a����</summary>
		[Column("byoto_mei")]
		public string ByotoMei { get; set; }

		/// <summary>��t�R�[�h</summary>
		[Column("ishi_code")]
		public string IshiCode { get; set; }

		/// <summary>��t�J�i����</summary>
		[Column("ishi_kana_shimei")]
		public string IshiKanaShimei { get; set; }

		/// <summary>��t��������</summary>
		[Column("ishi_kanji_shimei")]
		public string IshiKanjiShimei { get; set; }

		/// <summary>��܎t�R�[�h</summary>
		[Column("yakuzaishi_code")]
		public string YakuzaishiCode { get; set; }

		/// <summary>��܎t��</summary>
		[Column("yakuzaishi_mei")]
		public string YakuzaishiMei { get; set; }

		/// <summary>��t���ӕύX���e</summary>
		[Column("ishi_doihenko_naiyo")]
		public string IshiDoihenkoNaiyo { get; set; }

		/// <summary>��t�^�`�񓚓��e</summary>
		[Column("ishi_gigikaito_naiyo")]
		public string IshiGigikaitoNaiyo { get; set; }

		/// <summary>����{�p�ҖƋ��ԍ�</summary>
		[Column("mayakushiyosha_menkyobango")]
		public string MayakushiyoshaMenkyobango { get; set; }

		/// <summary>����{�p���ҏZ��</summary>
		[Column("mayakushiyo_kanjya_jyusho")]
		public string MayakushiyoKanjyaJyusho { get; set; }

		/// <summary>����{�p���ғd�b�ԍ�</summary>
		[Column("mayakushiyo_kanjya_denwabango")]
		public string MayakushiyoKanjyaDenwabango { get; set; }

		/// <summary>����ⳃR�����g</summary>
		[Column("shohosen_comment")]
		public string ShohosenComment { get; set; }

		/// <summary>����ⳏ�񕔗\��</summary>
		[Column("shohosen_jyohobu_yobi")]
		public string ShohosenJyohobuYobi { get; set; }

		/// <summary>��ܔ��s�t���O</summary>
		[Column("yakutai_hakko_flag")]
		public string YakutaiHakkoFlag { get; set; }

		/// <summary>���s�t���O</summary>
		[Column("yakujyo_hakko_flag")]
		public string YakujyoHakkoFlag { get; set; }

		/// <summary>����蒠���s�t���O</summary>
		[Column("fukuyakutecho_hakko_flag")]
		public string FukuyakutechoHakkoFlag { get; set; }

		/// <summary>�̎������s�t���O</summary>
		[Column("ryoshusho_hakko_flag")]
		public string RyoshushoHakkoFlag { get; set; }

		/// <summary>���[A���s�t���O</summary>
		[Column("kicho_a_hakko_flag")]
		public string KichoAHakkoFlag { get; set; }

		/// <summary>���[B���s�t���O</summary>
		[Column("kicho_b_hakko_flag")]
		public string KichoBHakkoFlag { get; set; }

		/// <summary>���[C���s�t���O</summary>
		[Column("kicho_c_hakko_flag")]
		public string KichoCHakkoFlag { get; set; }

		/// <summary>���׏����s�t���O</summary>
		[Column("meisaisho_hakko_flag")]
		public string MeisaishoHakkoFlag { get; set; }

		/// <summary>�t�@�C���X�V�敪</summary>
		[Column("fupdkbn")]
		public string Fupdkbn { get; set; }

		/// <summary>�L���敪</summary>
		[Column("yuko_flag")]
		public int? YukoFlag { get; set; }

		/// <summary> �R���X�g���N�^</summary>
		public Nsips2Shohosen()
		{

			Nsips2ShohosenId = 0;
			Nsips0HeaderId = 0;
			Stype = 0;
			ShohosenBango = 0;
			UketsukeBango = 0;
			KoshinKubun = "";
			ShohosenKofuNengappi = null;
			ShiyokigenNengappi = null;
			UketsukeNengappi = null;
			ChozaiNengappi = null;
			NinpujyunuKubun = "";
			KyoseikansashijiFlag = "";
			IryokikanCodeShubetsu = "";
			IryokikanCode = "";
			IryokikanReseputoCode = "";
			IryokikanTodofukenCode = "";
			IryokikanMei = "";
			IryokikanYubinbango = "";
			IryokikanShozaiti = "";
			IryokikanDenwabango = "";
			ShinryokaCode = "";
			ShinryokaMei = "";
			ByotoCode = "";
			ByotoMei = "";
			IshiCode = "";
			IshiKanaShimei = "";
			IshiKanjiShimei = "";
			YakuzaishiCode = "";
			YakuzaishiMei = "";
			IshiDoihenkoNaiyo = "";
			IshiGigikaitoNaiyo = "";
			MayakushiyoshaMenkyobango = "";
			MayakushiyoKanjyaJyusho = "";
			MayakushiyoKanjyaDenwabango = "";
			ShohosenComment = "";
			ShohosenJyohobuYobi = "";
			YakutaiHakkoFlag = "";
			YakujyoHakkoFlag = "";
			FukuyakutechoHakkoFlag = "";
			RyoshushoHakkoFlag = "";
			KichoAHakkoFlag = "";
			KichoBHakkoFlag = "";
			KichoCHakkoFlag = "";
			MeisaishoHakkoFlag = "";
			Fupdkbn = "";
			YukoFlag = 0;

		}
	} 
} 
