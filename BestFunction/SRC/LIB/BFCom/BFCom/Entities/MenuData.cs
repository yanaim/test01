namespace B2.BestFunction.Entities
{ 
	using System; 
	using System.Collections.Generic; 
	using System.ComponentModel.DataAnnotations; 
	using System.ComponentModel.DataAnnotations.Schema; 

	/// <summary>メニューテーブル</summary>
	[Table("menu_data")]
	public partial class MenuData
	{ 
		/// <summary>分類出力順</summary>
		[Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
		[Column("bunrui_seq", Order = 0)]
		public int? BunruiSeq { get; set; }

		/// <summary>分類名</summary>
		[Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
		[Column("bunrui_name", Order = 1)]
		public string BunruiName { get; set; }

		/// <summary>EXE出力順</summary>
		[Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
		[Column("file_seq", Order = 2)]
		public int? FileSeq { get; set; }

		/// <summary>EXEファイル名</summary>
		[Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
		[Column("filename", Order = 3)]
		public string Filename { get; set; }

		/// <summary>日本語名称</summary>
		[Column("program_name")]
		public string ProgramName { get; set; }

		/// <summary>実行時引数</summary>
		[Column("parameta")]
		public string Parameta { get; set; }

		/// <summary>表示方法</summary>
		[Column("hyoujihouhou")]
		public int? Hyoujihouhou { get; set; }

		/// <summary>同期属性</summary>
		[Column("doukizokusei")]
		public int? Doukizokusei { get; set; }

		/// <summary>フォーム名</summary>
		[Column("formname")]
		public string Formname { get; set; }

		/// <summary>機能詳細</summary>
		[Column("setumei")]
		public string Setumei { get; set; }

		/// <summary> コンストラクタ</summary>
		public MenuData()
		{

			BunruiSeq = 0;
			BunruiName = "";
			FileSeq = 0;
			Filename = "";
			ProgramName = "";
			Parameta = "";
			Hyoujihouhou = 0;
			Doukizokusei = 0;
			Formname = "";
			Setumei = "";

		}
	} 
} 
