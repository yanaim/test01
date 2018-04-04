namespace B2.BestFunction.Entities
{ 
	using System; 
	using System.Collections.Generic; 
	using System.ComponentModel.DataAnnotations; 
	using System.ComponentModel.DataAnnotations.Schema; 

	/// <summary>NSIPS���ܘ^���e�[�u��</summary>
	[Table("nsips5_chozairoku")]
	public partial class Nsips5Chozairoku
	{ 
		/// <summary>Nsips5���ܘ^ID</summary>
		[Key]
		[Column("nsips5_chozairoku_id")]
		public int? Nsips5ChozairokuId { get; set; }

		/// <summary>Nsips0�w�b�_ID</summary>
		[Column("nsips0_header_id")]
		public int? Nsips0HeaderId { get; set; }

		/// <summary>���ʎq</summary>
		[Column("stype")]
		public int? Stype { get; set; }

		/// <summary>��ܗ��̍��v</summary>
		[Column("yakuzairyo_no_goke")]
		public decimal? YakuzairyoNoGoke { get; set; }

		/// <summary>���ܗ��̍��v</summary>
		[Column("chozairyo_no_goke")]
		public decimal? ChozairyoNoGoke { get; set; }

		/// <summary>�w���Ǘ����̍��v</summary>
		[Column("shidokanriryo_no_goke")]
		public decimal? ShidokanriryoNoGoke { get; set; }

		/// <summary>����ی���Íޗ���</summary>
		[Column("tokutei_hokeniryo_zairyo_ryo")]
		public decimal? TokuteiHokeniryoZairyoRyo { get; set; }

		/// <summary>�ی������_��</summary>
		[Column("hokenseikyu_tensu")]
		public decimal? HokenseikyuTensu { get; set; }

		/// <summary>��{���Z</summary>
		[Column("kihon_kazan")]
		public decimal? KihonKazan { get; set; }

		/// <summary>���܊�{��</summary>
		[Column("chozai_kihonryo")]
		public decimal? ChozaiKihonryo { get; set; }

		/// <summary>���Z�̍��v</summary>
		[Column("kazan_no_goke")]
		public decimal? KazanNoGoke { get; set; }

		/// <summary>���</summary>
		[Column("yakureki")]
		public decimal? Yakureki { get; set; }

		/// <summary>���̑��̎w����</summary>
		[Column("sonota_no_shidoryo")]
		public decimal? SonotaNoShidoryo { get; set; }

		/// <summary>���Z��</summary>
		[Column("kazanto")]
		public decimal? Kazanto { get; set; }

		/// <summary>���v�_��</summary>
		[Column("goke_tensu")]
		public decimal? GokeTensu { get; set; }

		/// <summary>�ꕔ���S��</summary>
		[Column("itibu_futankin")]
		public decimal? ItibuFutankin { get; set; }

		/// <summary>�e����z</summary>
		[Column("yoki_kingaku")]
		public decimal? YokiKingaku { get; set; }

		/// <summary>���̑��̋��z</summary>
		[Column("sonota_no_kingaku")]
		public decimal? SonotaNoKingaku { get; set; }

		/// <summary>�O�񖘖�����</summary>
		[Column("zenkaimade_mishukin")]
		public decimal? ZenkaimadeMishukin { get; set; }

		/// <summary>���񐿋��z</summary>
		[Column("konkai_seikyugaku")]
		public decimal? KonkaiSeikyugaku { get; set; }

		/// <summary>���v�����z</summary>
		[Column("goke_seikyugaku")]
		public decimal? GokeSeikyugaku { get; set; }

		/// <summary>��������z</summary>
		[Column("konkai_nyukingaku")]
		public decimal? KonkaiNyukingaku { get; set; }

		/// <summary>������</summary>
		[Column("mishukin")]
		public decimal? Mishukin { get; set; }

		/// <summary>�t�@�C���X�V�敪</summary>
		[Column("fupdkbn")]
		public string Fupdkbn { get; set; }

		/// <summary>�L���敪</summary>
		[Column("yuko_flag")]
		public int? YukoFlag { get; set; }

		/// <summary> �R���X�g���N�^</summary>
		public Nsips5Chozairoku()
		{

			Nsips5ChozairokuId = 0;
			Nsips0HeaderId = 0;
			Stype = 0;
			YakuzairyoNoGoke = 0;
			ChozairyoNoGoke = 0;
			ShidokanriryoNoGoke = 0;
			TokuteiHokeniryoZairyoRyo = 0;
			HokenseikyuTensu = 0;
			KihonKazan = 0;
			ChozaiKihonryo = 0;
			KazanNoGoke = 0;
			Yakureki = 0;
			SonotaNoShidoryo = 0;
			Kazanto = 0;
			GokeTensu = 0;
			ItibuFutankin = 0;
			YokiKingaku = 0;
			SonotaNoKingaku = 0;
			ZenkaimadeMishukin = 0;
			KonkaiSeikyugaku = 0;
			GokeSeikyugaku = 0;
			KonkaiNyukingaku = 0;
			Mishukin = 0;
			Fupdkbn = "";
			YukoFlag = 0;

		}
	} 
} 
