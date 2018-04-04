namespace B2.BestFunction.Entities
{ 
	using System; 
	using System.Collections.Generic; 
	using System.ComponentModel.DataAnnotations; 
	using System.ComponentModel.DataAnnotations.Schema; 

	/// <summary>手配管理マスタ</summary>
	[Table("tehai_master")]
	public partial class TehaiMaster
	{ 
		/// <summary>薬局コード</summary>
		[Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
		[Column("yakkyoku_code", Order = 0)]
		public string YakkyokuCode { get; set; }

		/// <summary>YJコード</summary>
		[Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
		[Column("yj_code", Order = 1)]
		public string YjCode { get; set; }

		/// <summary>GTINコード</summary>
		[Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
		[Column("gtin_code", Order = 2)]
		public string GtinCode { get; set; }

		/// <summary>JANコード</summary>
		[Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
		[Column("jan_code", Order = 3)]
		public string JanCode { get; set; }

		/// <summary>明細コード</summary>
		[Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
		[Column("meisai_code", Order = 4)]
		public string MeisaiCode { get; set; }

		/// <summary>仕入先コード</summary>
		[Column("shiiresaki_code")]
		public string ShiiresakiCode { get; set; }

		/// <summary>購入価</summary>
		[Column("price")]
		public decimal? Price { get; set; }

		/// <summary>登録日</summary>
		[Column("insert_date")]
		public DateTime? InsertDate { get; set; }

		/// <summary>更新日</summary>
		[Column("update_date")]
		public DateTime? UpdateDate { get; set; }

		/// <summary>使用開始</summary>
		[Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
		[Column("start_use_date", Order = 5)]
		public int? StartUseDate { get; set; }

		/// <summary>使用終了</summary>
		[Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
		[Column("end_use_date", Order = 6)]
		public int? EndUseDate { get; set; }

		/// <summary>通知識別</summary>
		[Column("tsuchi_sikibetsu")]
		public int? TsuchiSikibetsu { get; set; }

		/// <summary>通知日時</summary>
		[Column("tsuchi_date")]
		public DateTime? TsuchiDate { get; set; }

		/// <summary>管理属性</summary>
		[Column("kanri_zokusei")]
		public int? KanriZokusei { get; set; }

		/// <summary> コンストラクタ</summary>
		public TehaiMaster()
		{

			YakkyokuCode = "";
			YjCode = "";
			GtinCode = "";
			JanCode = "";
			MeisaiCode = "";
			ShiiresakiCode = "";
			Price = 0;
			InsertDate = null;
			UpdateDate = null;
			StartUseDate = 0;
			EndUseDate = 0;
			TsuchiSikibetsu = 0;
			TsuchiDate = null;
			KanriZokusei = 0;

		}
	} 
} 
