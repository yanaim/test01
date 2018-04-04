namespace B2.BestFunction.Entities
{ 
	using System; 
	using System.Collections.Generic; 
	using System.ComponentModel.DataAnnotations; 
	using System.ComponentModel.DataAnnotations.Schema; 

	/// <summary>���ГX�܏��}�X�^</summary>
	[Table("store_master")]
	public partial class StoreMaster
	{ 
		/// <summary>��ǃR�[�h</summary>
		[Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
		[Column("yakkyoku_code", Order = 0)]
		public string YakkyokuCode { get; set; }

		/// <summary>��Ж�</summary>
		[Column("kaisha_mei")]
		public string KaishaMei { get; set; }

		/// <summary>��Ж��t���K�i</summary>
		[Column("kaisha_kana")]
		public string KaishaKana { get; set; }

		/// <summary>��ǖ�</summary>
		[Column("yakkyoku_mei")]
		public string YakkyokuMei { get; set; }

		/// <summary>��ǃt���K�i</summary>
		[Column("yakkyoku_kana")]
		public string YakkyokuKana { get; set; }

		/// <summary>��Ǘ���</summary>
		[Column("yakkyoku_ryaku_mei")]
		public string YakkyokuRyakuMei { get; set; }

		/// <summary>��\�Ґ�</summary>
		[Column("daihyousha_sei")]
		public string DaihyoushaSei { get; set; }

		/// <summary>��\�Җ�</summary>
		[Column("daihyousha_mei")]
		public string DaihyoushaMei { get; set; }

		/// <summary>��\�Ґ��t���K�i</summary>
		[Column("daihyousha_sei_kana")]
		public string DaihyoushaSeiKana { get; set; }

		/// <summary>��\�Җ��t���K�i</summary>
		[Column("daihyousha_mei_kana")]
		public string DaihyoushaMeiKana { get; set; }

		/// <summary>�S���Ґ�</summary>
		[Column("tantousha_sei")]
		public string TantoushaSei { get; set; }

		/// <summary>�S���Җ�</summary>
		[Column("tantousha_mei")]
		public string TantoushaMei { get; set; }

		/// <summary>�S���Ґ��t���K�i</summary>
		[Column("tantousha_sei_kana")]
		public string TantoushaSeiKana { get; set; }

		/// <summary>�S���Җ��t���K�i</summary>
		[Column("tantouusha_mei_kana")]
		public string TantouushaMeiKana { get; set; }

		/// <summary>��ǎ��</summary>
		[Column("yakkyoku_type")]
		public string YakkyokuType { get; set; }

		/// <summary>�X�܌`��</summary>
		[Column("tempo_keitai")]
		public string TempoKeitai { get; set; }

		/// <summary>���ƌ`��</summary>
		[Column("bungyou_keitai")]
		public string BungyouKeitai { get; set; }

		/// <summary>��ǃ����N</summary>
		[Column("yakkyoku_rank")]
		public string YakkyokuRank { get; set; }

		/// <summary>�X�֔ԍ�</summary>
		[Column("zip_code")]
		public string ZipCode { get; set; }

		/// <summary>�s���{��</summary>
		[Column("state")]
		public string State { get; set; }

		/// <summary>�s����</summary>
		[Column("city")]
		public string City { get; set; }

		/// <summary>�Ԓn</summary>
		[Column("street")]
		public string Street { get; set; }

		/// <summary>�������P</summary>
		[Column("tatemono_mei_1")]
		public string TatemonoMei1 { get; set; }

		/// <summary>�������Q</summary>
		[Column("tatemono_mei_2")]
		public string TatemonoMei2 { get; set; }

		/// <summary>�d�b�ԍ�</summary>
		[Column("tel_no")]
		public string TelNo { get; set; }

		/// <summary>FAX�ԍ�</summary>
		[Column("fax_no")]
		public string FaxNo { get; set; }

		/// <summary>E���[���A�h���X</summary>
		[Column("mail_address")]
		public string MailAddress { get; set; }

		/// <summary>�z�[���y�[�WURL</summary>
		[Column("homepage_url")]
		public string HomepageUrl { get; set; }

		/// <summary>��s����-��s�R�[�h</summary>
		[Column("bank_code")]
		public string BankCode { get; set; }

		/// <summary>��s����-�x�X�R�[�h</summary>
		[Column("shiten_code")]
		public string ShitenCode { get; set; }

		/// <summary>��s����-�a�����</summary>
		[Column("bank_yokin_type")]
		public string BankYokinType { get; set; }

		/// <summary>��s����-�����ԍ�</summary>
		[Column("bank_account_no")]
		public string BankAccountNo { get; set; }

		/// <summary>��s����-�������`</summary>
		[Column("bank_account_mei")]
		public string BankAccountMei { get; set; }

		/// <summary>�摜�t�@�C���p�X�P</summary>
		[Column("image_path_1")]
		public string ImagePath1 { get; set; }

		/// <summary>�摜�t�@�C���p�X�Q</summary>
		[Column("image_path_2")]
		public string ImagePath2 { get; set; }

		/// <summary>�摜�t�@�C���p�X�R</summary>
		[Column("image_path_3")]
		public string ImagePath3 { get; set; }

		/// <summary>�摜�t�@�C���p�X�S</summary>
		[Column("image_path_4")]
		public string ImagePath4 { get; set; }

		/// <summary>�摜�t�@�C���p�X�T</summary>
		[Column("image_path_5")]
		public string ImagePath5 { get; set; }

		/// <summary>API�{���t���O</summary>
		[Column("api_teikyou_flag")]
		public string ApiTeikyouFlag { get; set; }

		/// <summary>�J�Ǐؖ����ۑ��p�X</summary>
		[Column("kaikyoku_shoumeisho_hozon_path")]
		public string KaikyokuShoumeishoHozonPath { get; set; }

		/// <summary>���ԍ�</summary>
		[Column("kyoka_no")]
		public string KyokaNo { get; set; }

		/// <summary>�L������(FROM)</summary>
		[Column("yuko_kigen_from")]
		public string YukoKigenFrom { get; set; }

		/// <summary>�L������(TO)</summary>
		[Column("yuko_kigen_to")]
		public string YukoKigenTo { get; set; }

		/// <summary>�񋟃T�[�r�X�P</summary>
		[Column("teikyou_service_1")]
		public string TeikyouService1 { get; set; }

		/// <summary>�_��N����</summary>
		[Column("keiyaku_ymd")]
		public string KeiyakuYmd { get; set; }

		/// <summary>�����N����</summary>
		[Column("kaijo_ymd")]
		public string KaijoYmd { get; set; }

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

		/// <summary>��Ë@�փR�[�h</summary>
		[Column("iryoukikan_code")]
		public string IryoukikanCode { get; set; }

		/// <summary>�g�p�J�n</summary>
		[Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
		[Column("start_use_date", Order = 1)]
		public int? StartUseDate { get; set; }

		/// <summary>�g�p�I��</summary>
		[Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
		[Column("end_use_date", Order = 2)]
		public int? EndUseDate { get; set; }

		/// <summary> �R���X�g���N�^</summary>
		public StoreMaster()
		{

			YakkyokuCode = "";
			KaishaMei = "";
			KaishaKana = "";
			YakkyokuMei = "";
			YakkyokuKana = "";
			YakkyokuRyakuMei = "";
			DaihyoushaSei = "";
			DaihyoushaMei = "";
			DaihyoushaSeiKana = "";
			DaihyoushaMeiKana = "";
			TantoushaSei = "";
			TantoushaMei = "";
			TantoushaSeiKana = "";
			TantouushaMeiKana = "";
			YakkyokuType = "";
			TempoKeitai = "";
			BungyouKeitai = "";
			YakkyokuRank = "";
			ZipCode = "";
			State = "";
			City = "";
			Street = "";
			TatemonoMei1 = "";
			TatemonoMei2 = "";
			TelNo = "";
			FaxNo = "";
			MailAddress = "";
			HomepageUrl = "";
			BankCode = "";
			ShitenCode = "";
			BankYokinType = "";
			BankAccountNo = "";
			BankAccountMei = "";
			ImagePath1 = "";
			ImagePath2 = "";
			ImagePath3 = "";
			ImagePath4 = "";
			ImagePath5 = "";
			ApiTeikyouFlag = "";
			KaikyokuShoumeishoHozonPath = "";
			KyokaNo = "";
			YukoKigenFrom = "";
			YukoKigenTo = "";
			TeikyouService1 = "";
			KeiyakuYmd = "";
			KaijoYmd = "";
			InsertUserId = 0;
			InsertNitiji = null;
			UpdateUserId = 0;
			UpdateNitiji = null;
			UpdateProgramId = "";
			IryoukikanCode = "";
			StartUseDate = 0;
			EndUseDate = 0;

		}
	} 
} 
