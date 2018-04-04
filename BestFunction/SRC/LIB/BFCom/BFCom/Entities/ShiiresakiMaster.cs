namespace B2.BestFunction.Entities
{ 
	using System; 
	using System.Collections.Generic; 
	using System.ComponentModel.DataAnnotations; 
	using System.ComponentModel.DataAnnotations.Schema; 

	/// <summary>�d����}�X�^</summary>
	[Table("shiiresaki_master")]
	public partial class ShiiresakiMaster
	{ 
		/// <summary>�d����R�[�h</summary>
		[Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
		[Column("shiiresaki_code", Order = 0)]
		public string ShiiresakiCode { get; set; }

		/// <summary>�X�֔ԍ�</summary>
		[Column("yuubin")]
		public string Yuubin { get; set; }

		/// <summary>�Z���i�P�j</summary>
		[Column("jyu1")]
		public string Jyu1 { get; set; }

		/// <summary>�Z���i�Q�j</summary>
		[Column("jyu2")]
		public string Jyu2 { get; set; }

		/// <summary>�d���於</summary>
		[Column("name")]
		public string Name { get; set; }

		/// <summary>�d���於(����)</summary>
		[Column("name_ryakusyo")]
		public string NameRyakusyo { get; set; }

		/// <summary>�d�b�ԍ�</summary>
		[Column("tel")]
		public string Tel { get; set; }

		/// <summary>�e�`�w�ԍ�</summary>
		[Column("fax")]
		public string Fax { get; set; }

		/// <summary>�ύX��</summary>
		[Column("henkou_ymd")]
		public DateTime? HenkouYmd { get; set; }

		/// <summary>�p���敪</summary>
		[Column("keizoku_kubun")]
		public int? KeizokuKubun { get; set; }

		/// <summary>�d���`�[�s��</summary>
		[Column("shiire_line")]
		public int? ShiireLine { get; set; }

		/// <summary>���R�[�h</summary>
		[Column("oroshi_code")]
		public string OroshiCode { get; set; }

		/// <summary>�T�C�g�敪</summary>
		[Column("site_kubun")]
		public int? SiteKubun { get; set; }

		/// <summary>����ŎZ�o�敪</summary>
		[Column("tax_san_kubun")]
		public int? TaxSanKubun { get; set; }

		/// <summary>����Œ[�������敪</summary>
		[Column("tax_hasu_kubun")]
		public int? TaxHasuKubun { get; set; }

		/// <summary>�d���於(�W�v�p)</summary>
		[Column("name_syukei")]
		public string NameSyukei { get; set; }

		/// <summary>�g�p�J�n</summary>
		[Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
		[Column("start_use_date", Order = 1)]
		public int? StartUseDate { get; set; }

		/// <summary>�g�p�I��</summary>
		[Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
		[Column("end_use_date", Order = 2)]
		public int? EndUseDate { get; set; }

		/// <summary>�ʒm����</summary>
		[Column("tsuchi_sikibetsu")]
		public int? TsuchiSikibetsu { get; set; }

		/// <summary>�ʒm����</summary>
		[Column("tsuchi_date")]
		public DateTime? TsuchiDate { get; set; }

		/// <summary>�Ǘ�����</summary>
		[Column("kanri_zokusei")]
		public int? KanriZokusei { get; set; }

		/// <summary> �R���X�g���N�^</summary>
		public ShiiresakiMaster()
		{

			ShiiresakiCode = "";
			Yuubin = "";
			Jyu1 = "";
			Jyu2 = "";
			Name = "";
			NameRyakusyo = "";
			Tel = "";
			Fax = "";
			HenkouYmd = null;
			KeizokuKubun = 0;
			ShiireLine = 0;
			OroshiCode = "";
			SiteKubun = 0;
			TaxSanKubun = 0;
			TaxHasuKubun = 0;
			NameSyukei = "";
			StartUseDate = 0;
			EndUseDate = 0;
			TsuchiSikibetsu = 0;
			TsuchiDate = null;
			KanriZokusei = 0;

		}
	} 
} 
