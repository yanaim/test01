namespace B2.BestFunction.Entities
{ 
	using System; 
	using System.Collections.Generic; 
	using System.ComponentModel.DataAnnotations; 
	using System.ComponentModel.DataAnnotations.Schema; 

	/// <summary>発注管理情報マスタ</summary>
	[Table("hachukanri_master")]
	public partial class HachukanriMaster
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
		[Column("gtin_code")]
		public string GtinCode { get; set; }

		/// <summary>JANコード</summary>
		[Column("jan_code")]
		public string JanCode { get; set; }

		/// <summary>発注候補区分</summary>
		[Column("hachukoho_kubun")]
		public int? HachukohoKubun { get; set; }

		/// <summary>発注点</summary>
		[Column("hachuten_suryo")]
		public decimal? HachutenSuryo { get; set; }

		/// <summary>安全在庫数量</summary>
		[Column("anzenzaiko_suryo")]
		public decimal? AnzenzaikoSuryo { get; set; }

		/// <summary>来局予定分</summary>
		[Column("raikyokubun")]
		public int? Raikyokubun { get; set; }

		/// <summary>リードタイム日数</summary>
		[Column("leadtime")]
		public int? Leadtime { get; set; }

		/// <summary>予測最大調剤数の乗数</summary>
		[Column("yosoku_jyousu")]
		public decimal? YosokuJyousu { get; set; }

		/// <summary>バラとヒートを合算する</summary>
		[Column("barahito_gassan")]
		public int? BarahitoGassan { get; set; }

		/// <summary>使用開始</summary>
		[Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
		[Column("start_use_date", Order = 2)]
		public int? StartUseDate { get; set; }

		/// <summary>使用終了</summary>
		[Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
		[Column("end_use_date", Order = 3)]
		public int? EndUseDate { get; set; }

		/// <summary>通知識別</summary>
		[Column("tsuchi_sikibetsu")]
		public int? TsuchiSikibetsu { get; set; }

		/// <summary>通知日時</summary>
		[Column("tsuchi_date")]
		public DateTime? TsuchiDate { get; set; }

		/// <summary> コンストラクタ</summary>
		public HachukanriMaster()
		{

			YakkyokuCode = "";
			YjCode = "";
			GtinCode = "";
			JanCode = "";
			HachukohoKubun = 0;
			HachutenSuryo = 0;
			AnzenzaikoSuryo = 0;
			Raikyokubun = 0;
			Leadtime = 0;
			YosokuJyousu = 0;
			BarahitoGassan = 0;
			StartUseDate = 0;
			EndUseDate = 0;
			TsuchiSikibetsu = 0;
			TsuchiDate = null;

		}
	} 
} 
