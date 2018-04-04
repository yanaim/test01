namespace B2.BestFunction.Entities
{ 
	using System; 
	using System.Collections.Generic; 
	using System.ComponentModel.DataAnnotations; 
	using System.ComponentModel.DataAnnotations.Schema; 

	/// <summary>NSIPS�p�@���e�[�u��</summary>
	[Table("nsips3_yoho")]
	public partial class Nsips3Yoho
	{ 
		/// <summary>Nsips0�p�@ID</summary>
		[Key]
		[Column("nsips3_yoho_id")]
		public int? Nsips3YohoId { get; set; }

		/// <summary>Nsips0�w�b�_ID</summary>
		[Column("nsips0_header_id")]
		public int? Nsips0HeaderId { get; set; }

		/// <summary>Nsips2�����ID</summary>
		[Column("nsips2_shohosen_id")]
		public int? Nsips2ShohosenId { get; set; }

		/// <summary>���ʎq</summary>
		[Column("stype")]
		public int? Stype { get; set; }

		/// <summary>RP�ԍ�</summary>
		[Column("rp_bango")]
		public int? RpBango { get; set; }

		/// <summary>�p�@�R�[�h1</summary>
		[Column("yoho_code1")]
		public string YohoCode1 { get; set; }

		/// <summary>�p�@��1</summary>
		[Column("yoho_mei1")]
		public string YohoMei1 { get; set; }

		/// <summary>�p�@�R�[�h2</summary>
		[Column("yoho_code2")]
		public string YohoCode2 { get; set; }

		/// <summary>�p�@��2</summary>
		[Column("yoho_mei2")]
		public string YohoMei2 { get; set; }

		/// <summary>�p�@�R�[�h3</summary>
		[Column("yoho_code3")]
		public string YohoCode3 { get; set; }

		/// <summary>�p�@��3</summary>
		[Column("yoho_mei3")]
		public string YohoMei3 { get; set; }

		/// <summary>RP�敪</summary>
		[Column("rp_kubun")]
		public string RpKubun { get; set; }

		/// <summary>����敪</summary>
		[Column("nichikai_kubun")]
		public string NichikaiKubun { get; set; }

		/// <summary>����</summary>
		[Column("nitikai_su")]
		public int? NitikaiSu { get; set; }

		/// <summary>���p��</summary>
		[Column("fukuyo_kaisu")]
		public int? FukuyoKaisu { get; set; }

		/// <summary>���p�J�n��</summary>
		[Column("fukuyo_kaishibi")]
		public DateTime? FukuyoKaishibi { get; set; }

		/// <summary>��i���א�</summary>
		[Column("yakuhin_meisaisu")]
		public int? YakuhinMeisaisu { get; set; }

		/// <summary>�P�RP�敪</summary>
		[Column("ippoka_rp_kubun")]
		public string IppokaRpKubun { get; set; }

		/// <summary>����RP�敪</summary>
		[Column("funsai_rp_kubun")]
		public string FunsaiRpKubun { get; set; }

		/// <summary>�p�@�R�����g1</summary>
		[Column("yoho_comment1")]
		public string YohoComment1 { get; set; }

		/// <summary>�p�@���\��</summary>
		[Column("yohobu_yobi")]
		public string YohobuYobi { get; set; }

		/// <summary>�p�@�R�����g2</summary>
		[Column("yoho_comment2")]
		public string YohoComment2 { get; set; }

		/// <summary>�p�@�R�����g3</summary>
		[Column("yoho_comment3")]
		public string YohoComment3 { get; set; }

		/// <summary>�p�@�R�����g4</summary>
		[Column("yoho_comment4")]
		public string YohoComment4 { get; set; }

		/// <summary>�p�@�R�����g5</summary>
		[Column("yoho_comment5")]
		public string YohoComment5 { get; set; }

		/// <summary>�t�@�C���X�V�敪</summary>
		[Column("fupdkbn")]
		public string Fupdkbn { get; set; }

		/// <summary>�L���敪</summary>
		[Column("yuko_flag")]
		public int? YukoFlag { get; set; }

		/// <summary> �R���X�g���N�^</summary>
		public Nsips3Yoho()
		{

			Nsips3YohoId = 0;
			Nsips0HeaderId = 0;
			Nsips2ShohosenId = 0;
			Stype = 0;
			RpBango = 0;
			YohoCode1 = "";
			YohoMei1 = "";
			YohoCode2 = "";
			YohoMei2 = "";
			YohoCode3 = "";
			YohoMei3 = "";
			RpKubun = "";
			NichikaiKubun = "";
			NitikaiSu = 0;
			FukuyoKaisu = 0;
			FukuyoKaishibi = null;
			YakuhinMeisaisu = 0;
			IppokaRpKubun = "";
			FunsaiRpKubun = "";
			YohoComment1 = "";
			YohobuYobi = "";
			YohoComment2 = "";
			YohoComment3 = "";
			YohoComment4 = "";
			YohoComment5 = "";
			Fupdkbn = "";
			YukoFlag = 0;

		}
	} 
} 
