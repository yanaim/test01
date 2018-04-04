namespace B2.BestFunction
{
    partial class frmUserAccount
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label accountKubunLabel;
            System.Windows.Forms.Label accountRankLabel;
            System.Windows.Forms.Label accountSakujoFlagLabel;
            System.Windows.Forms.Label accountTeishiFlagLabel;
            System.Windows.Forms.Label kaijoYmdLabel;
            System.Windows.Forms.Label keiyakuYmdLabel;
            System.Windows.Forms.Label kengenLabel;
            System.Windows.Forms.Label mailAddressLabel;
            System.Windows.Forms.Label passwordLabel;
            System.Windows.Forms.Label pdsIdLabel;
            System.Windows.Forms.Label uneiCommentLabel;
            System.Windows.Forms.Label yakkyokuCodeLabel;
            FarPoint.Win.Spread.CellType.NumberCellType numberCellType1 = new FarPoint.Win.Spread.CellType.NumberCellType();
            FarPoint.Win.Spread.CellType.TextCellType textCellType1 = new FarPoint.Win.Spread.CellType.TextCellType();
            FarPoint.Win.Spread.CellType.TextCellType textCellType2 = new FarPoint.Win.Spread.CellType.TextCellType();
            FarPoint.Win.Spread.CellType.TextCellType textCellType3 = new FarPoint.Win.Spread.CellType.TextCellType();
            FarPoint.Win.Spread.CellType.TextCellType textCellType4 = new FarPoint.Win.Spread.CellType.TextCellType();
            FarPoint.Win.Spread.CellType.TextCellType textCellType5 = new FarPoint.Win.Spread.CellType.TextCellType();
            FarPoint.Win.Spread.CellType.TextCellType textCellType6 = new FarPoint.Win.Spread.CellType.TextCellType();
            FarPoint.Win.Spread.CellType.TextCellType textCellType7 = new FarPoint.Win.Spread.CellType.TextCellType();
            FarPoint.Win.Spread.CellType.TextCellType textCellType8 = new FarPoint.Win.Spread.CellType.TextCellType();
            FarPoint.Win.Spread.CellType.TextCellType textCellType9 = new FarPoint.Win.Spread.CellType.TextCellType();
            FarPoint.Win.Spread.CellType.TextCellType textCellType10 = new FarPoint.Win.Spread.CellType.TextCellType();
            FarPoint.Win.Spread.CellType.TextCellType textCellType11 = new FarPoint.Win.Spread.CellType.TextCellType();
            FarPoint.Win.Spread.CellType.TextCellType textCellType12 = new FarPoint.Win.Spread.CellType.TextCellType();
            FarPoint.Win.Spread.CellType.TextCellType textCellType13 = new FarPoint.Win.Spread.CellType.TextCellType();
            this.split1 = new System.Windows.Forms.SplitContainer();
            this.gcTxtModify = new GrapeCity.Win.Editors.GcTextBox(this.components);
            this.gcTxtDownload = new GrapeCity.Win.Editors.GcTextBox(this.components);
            this.gcTxtCsv = new GrapeCity.Win.Editors.GcTextBox(this.components);
            this.gcTxtPdf = new GrapeCity.Win.Editors.GcTextBox(this.components);
            this.gcTxtTitle = new GrapeCity.Win.Editors.GcTextBox(this.components);
            this.gcTxtNew = new GrapeCity.Win.Editors.GcTextBox(this.components);
            this.gcTxtExit = new GrapeCity.Win.Editors.GcTextBox(this.components);
            this.gcTxtClear = new GrapeCity.Win.Editors.GcTextBox(this.components);
            this.gcTxtUpdate = new GrapeCity.Win.Editors.GcTextBox(this.components);
            this.gcTxtDelete = new GrapeCity.Win.Editors.GcTextBox(this.components);
            this.split2 = new System.Windows.Forms.SplitContainer();
            this.fpS1 = new FarPoint.Win.Spread.FpSpread();
            this.fpS1_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.userAccountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yakkyokuCodeTextBox = new System.Windows.Forms.TextBox();
            this.uneiCommentTextBox = new System.Windows.Forms.TextBox();
            this.pdsIdTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.mailAddressTextBox = new System.Windows.Forms.TextBox();
            this.kengenTextBox = new System.Windows.Forms.TextBox();
            this.keiyakuYmdTextBox = new System.Windows.Forms.TextBox();
            this.kaijoYmdTextBox = new System.Windows.Forms.TextBox();
            this.accountTeishiFlagTextBox = new System.Windows.Forms.TextBox();
            this.accountSakujoFlagTextBox = new System.Windows.Forms.TextBox();
            this.accountRankTextBox = new System.Windows.Forms.TextBox();
            this.accountKubunTextBox = new System.Windows.Forms.TextBox();
            this.gcShortcut1 = new GrapeCity.Win.Editors.GcShortcut(this.components);
            accountKubunLabel = new System.Windows.Forms.Label();
            accountRankLabel = new System.Windows.Forms.Label();
            accountSakujoFlagLabel = new System.Windows.Forms.Label();
            accountTeishiFlagLabel = new System.Windows.Forms.Label();
            kaijoYmdLabel = new System.Windows.Forms.Label();
            keiyakuYmdLabel = new System.Windows.Forms.Label();
            kengenLabel = new System.Windows.Forms.Label();
            mailAddressLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            pdsIdLabel = new System.Windows.Forms.Label();
            uneiCommentLabel = new System.Windows.Forms.Label();
            yakkyokuCodeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.split1)).BeginInit();
            this.split1.Panel1.SuspendLayout();
            this.split1.Panel2.SuspendLayout();
            this.split1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcTxtModify)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTxtDownload)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTxtCsv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTxtPdf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTxtTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTxtNew)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTxtExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTxtClear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTxtUpdate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTxtDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.split2)).BeginInit();
            this.split2.Panel1.SuspendLayout();
            this.split2.Panel2.SuspendLayout();
            this.split2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fpS1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpS1_Sheet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userAccountBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // accountKubunLabel
            // 
            accountKubunLabel.AutoSize = true;
            accountKubunLabel.Location = new System.Drawing.Point(8, 206);
            accountKubunLabel.Name = "accountKubunLabel";
            accountKubunLabel.Size = new System.Drawing.Size(111, 17);
            accountKubunLabel.TabIndex = 0;
            accountKubunLabel.Text = "Account Kubun:";
            // 
            // accountRankLabel
            // 
            accountRankLabel.AutoSize = true;
            accountRankLabel.Location = new System.Drawing.Point(8, 175);
            accountRankLabel.Name = "accountRankLabel";
            accountRankLabel.Size = new System.Drawing.Size(102, 17);
            accountRankLabel.TabIndex = 2;
            accountRankLabel.Text = "Account Rank:";
            // 
            // accountSakujoFlagLabel
            // 
            accountSakujoFlagLabel.AutoSize = true;
            accountSakujoFlagLabel.Location = new System.Drawing.Point(8, 237);
            accountSakujoFlagLabel.Name = "accountSakujoFlagLabel";
            accountSakujoFlagLabel.Size = new System.Drawing.Size(143, 17);
            accountSakujoFlagLabel.TabIndex = 4;
            accountSakujoFlagLabel.Text = "Account Sakujo Flag:";
            // 
            // accountTeishiFlagLabel
            // 
            accountTeishiFlagLabel.AutoSize = true;
            accountTeishiFlagLabel.Location = new System.Drawing.Point(8, 268);
            accountTeishiFlagLabel.Name = "accountTeishiFlagLabel";
            accountTeishiFlagLabel.Size = new System.Drawing.Size(135, 17);
            accountTeishiFlagLabel.TabIndex = 6;
            accountTeishiFlagLabel.Text = "Account Teishi Flag:";
            // 
            // kaijoYmdLabel
            // 
            kaijoYmdLabel.AutoSize = true;
            kaijoYmdLabel.Location = new System.Drawing.Point(8, 448);
            kaijoYmdLabel.Name = "kaijoYmdLabel";
            kaijoYmdLabel.Size = new System.Drawing.Size(77, 17);
            kaijoYmdLabel.TabIndex = 12;
            kaijoYmdLabel.Text = "Kaijo Ymd:";
            // 
            // keiyakuYmdLabel
            // 
            keiyakuYmdLabel.AutoSize = true;
            keiyakuYmdLabel.Location = new System.Drawing.Point(8, 417);
            keiyakuYmdLabel.Name = "keiyakuYmdLabel";
            keiyakuYmdLabel.Size = new System.Drawing.Size(95, 17);
            keiyakuYmdLabel.TabIndex = 14;
            keiyakuYmdLabel.Text = "Keiyaku Ymd:";
            // 
            // kengenLabel
            // 
            kengenLabel.AutoSize = true;
            kengenLabel.Location = new System.Drawing.Point(8, 144);
            kengenLabel.Name = "kengenLabel";
            kengenLabel.Size = new System.Drawing.Size(63, 17);
            kengenLabel.TabIndex = 16;
            kengenLabel.Text = "Kengen:";
            // 
            // mailAddressLabel
            // 
            mailAddressLabel.AutoSize = true;
            mailAddressLabel.Location = new System.Drawing.Point(8, 82);
            mailAddressLabel.Name = "mailAddressLabel";
            mailAddressLabel.Size = new System.Drawing.Size(93, 17);
            mailAddressLabel.TabIndex = 18;
            mailAddressLabel.Text = "Mail Address:";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new System.Drawing.Point(8, 20);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(74, 17);
            passwordLabel.TabIndex = 20;
            passwordLabel.Text = "Password:";
            // 
            // pdsIdLabel
            // 
            pdsIdLabel.AutoSize = true;
            pdsIdLabel.Location = new System.Drawing.Point(8, 51);
            pdsIdLabel.Name = "pdsIdLabel";
            pdsIdLabel.Size = new System.Drawing.Size(53, 17);
            pdsIdLabel.TabIndex = 22;
            pdsIdLabel.Text = "Pds Id:";
            // 
            // uneiCommentLabel
            // 
            uneiCommentLabel.AutoSize = true;
            uneiCommentLabel.Location = new System.Drawing.Point(8, 299);
            uneiCommentLabel.Name = "uneiCommentLabel";
            uneiCommentLabel.Size = new System.Drawing.Size(108, 17);
            uneiCommentLabel.TabIndex = 24;
            uneiCommentLabel.Text = "Unei Comment:";
            // 
            // yakkyokuCodeLabel
            // 
            yakkyokuCodeLabel.AutoSize = true;
            yakkyokuCodeLabel.Location = new System.Drawing.Point(8, 113);
            yakkyokuCodeLabel.Name = "yakkyokuCodeLabel";
            yakkyokuCodeLabel.Size = new System.Drawing.Size(110, 17);
            yakkyokuCodeLabel.TabIndex = 34;
            yakkyokuCodeLabel.Text = "Yakkyoku Code:";
            // 
            // split1
            // 
            this.split1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.split1.IsSplitterFixed = true;
            this.split1.Location = new System.Drawing.Point(0, 0);
            this.split1.Name = "split1";
            this.split1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // split1.Panel1
            // 
            this.split1.Panel1.BackColor = System.Drawing.Color.White;
            this.split1.Panel1.Controls.Add(this.gcTxtModify);
            this.split1.Panel1.Controls.Add(this.gcTxtDownload);
            this.split1.Panel1.Controls.Add(this.gcTxtCsv);
            this.split1.Panel1.Controls.Add(this.gcTxtPdf);
            this.split1.Panel1.Controls.Add(this.gcTxtTitle);
            this.split1.Panel1.Controls.Add(this.gcTxtNew);
            this.split1.Panel1.Controls.Add(this.gcTxtExit);
            this.split1.Panel1.Controls.Add(this.gcTxtClear);
            this.split1.Panel1.Controls.Add(this.gcTxtUpdate);
            this.split1.Panel1.Controls.Add(this.gcTxtDelete);
            // 
            // split1.Panel2
            // 
            this.split1.Panel2.Controls.Add(this.split2);
            this.split1.Size = new System.Drawing.Size(1060, 620);
            this.split1.SplitterDistance = 122;
            this.split1.TabIndex = 0;
            // 
            // gcTxtModify
            // 
            this.gcTxtModify.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gcTxtModify.ContentAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.gcTxtModify.ForeColor = System.Drawing.Color.Green;
            this.gcTxtModify.GridLine = new GrapeCity.Win.Editors.Line(GrapeCity.Win.Editors.LineStyle.Single, System.Drawing.Color.White);
            this.gcTxtModify.Location = new System.Drawing.Point(116, 48);
            this.gcTxtModify.Name = "gcTxtModify";
            this.gcTxtModify.ReadOnly = true;
            this.gcTxtModify.SingleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gcTxtModify.Size = new System.Drawing.Size(70, 25);
            this.gcTxtModify.TabIndex = 2;
            this.gcTxtModify.Text = "訂正";
            this.gcTxtModify.Click += new System.EventHandler(this.gcTxtModify_Click);
            this.gcTxtModify.DoubleClick += new System.EventHandler(this.gcTxtModify_DoubleClick);
            // 
            // gcTxtDownload
            // 
            this.gcTxtDownload.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gcTxtDownload.ContentAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.gcTxtDownload.ForeColor = System.Drawing.Color.Green;
            this.gcTxtDownload.GridLine = new GrapeCity.Win.Editors.Line(GrapeCity.Win.Editors.LineStyle.Single, System.Drawing.Color.White);
            this.gcTxtDownload.Location = new System.Drawing.Point(204, 79);
            this.gcTxtDownload.Name = "gcTxtDownload";
            this.gcTxtDownload.ReadOnly = true;
            this.gcTxtDownload.SingleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gcTxtDownload.Size = new System.Drawing.Size(70, 25);
            this.gcTxtDownload.TabIndex = 2;
            this.gcTxtDownload.Text = "ダウンロード";
            this.gcTxtDownload.Click += new System.EventHandler(this.gcTxtDownload_Click);
            this.gcTxtDownload.DoubleClick += new System.EventHandler(this.gcTxtDownload_DoubleClick);
            // 
            // gcTxtCsv
            // 
            this.gcTxtCsv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gcTxtCsv.ContentAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.gcTxtCsv.ForeColor = System.Drawing.Color.Green;
            this.gcTxtCsv.GridLine = new GrapeCity.Win.Editors.Line(GrapeCity.Win.Editors.LineStyle.Single, System.Drawing.Color.White);
            this.gcTxtCsv.Location = new System.Drawing.Point(116, 79);
            this.gcTxtCsv.Name = "gcTxtCsv";
            this.gcTxtCsv.ReadOnly = true;
            this.gcTxtCsv.SingleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gcTxtCsv.Size = new System.Drawing.Size(70, 25);
            this.gcTxtCsv.TabIndex = 2;
            this.gcTxtCsv.Text = "CSV出力";
            this.gcTxtCsv.Click += new System.EventHandler(this.gcTxtCsv_Click);
            this.gcTxtCsv.DoubleClick += new System.EventHandler(this.gcTxtCsv_DoubleClick);
            // 
            // gcTxtPdf
            // 
            this.gcTxtPdf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gcTxtPdf.ContentAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.gcTxtPdf.ForeColor = System.Drawing.Color.Green;
            this.gcTxtPdf.GridLine = new GrapeCity.Win.Editors.Line(GrapeCity.Win.Editors.LineStyle.Single, System.Drawing.Color.White);
            this.gcTxtPdf.Location = new System.Drawing.Point(28, 79);
            this.gcTxtPdf.Name = "gcTxtPdf";
            this.gcTxtPdf.ReadOnly = true;
            this.gcTxtPdf.SingleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gcTxtPdf.Size = new System.Drawing.Size(70, 25);
            this.gcTxtPdf.TabIndex = 2;
            this.gcTxtPdf.Text = "PDF出力";
            this.gcTxtPdf.Click += new System.EventHandler(this.gcTxtPdf_Click);
            this.gcTxtPdf.DoubleClick += new System.EventHandler(this.gcTxtPdf_DoubleClick);
            // 
            // gcTxtTitle
            // 
            this.gcTxtTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gcTxtTitle.ContentAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.gcTxtTitle.ForeColor = System.Drawing.Color.Green;
            this.gcTxtTitle.GridLine = new GrapeCity.Win.Editors.Line(GrapeCity.Win.Editors.LineStyle.Single, System.Drawing.Color.White);
            this.gcTxtTitle.Location = new System.Drawing.Point(12, 12);
            this.gcTxtTitle.Name = "gcTxtTitle";
            this.gcTxtTitle.ReadOnly = true;
            this.gcTxtTitle.SingleBorderColor = System.Drawing.Color.White;
            this.gcTxtTitle.Size = new System.Drawing.Size(700, 25);
            this.gcTxtTitle.TabIndex = 2;
            this.gcTxtTitle.Text = "マスタ　＞　ユーザアカウント";
            this.gcTxtTitle.Click += new System.EventHandler(this.gcTxtNew_Click);
            this.gcTxtTitle.DoubleClick += new System.EventHandler(this.gcTxtNew_DoubleClick);
            // 
            // gcTxtNew
            // 
            this.gcTxtNew.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gcTxtNew.ContentAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.gcTxtNew.ForeColor = System.Drawing.Color.Green;
            this.gcTxtNew.GridLine = new GrapeCity.Win.Editors.Line(GrapeCity.Win.Editors.LineStyle.Single, System.Drawing.Color.White);
            this.gcTxtNew.Location = new System.Drawing.Point(28, 48);
            this.gcTxtNew.Name = "gcTxtNew";
            this.gcTxtNew.ReadOnly = true;
            this.gcTxtNew.SingleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gcTxtNew.Size = new System.Drawing.Size(70, 25);
            this.gcTxtNew.TabIndex = 2;
            this.gcTxtNew.Text = "新規";
            this.gcTxtNew.Click += new System.EventHandler(this.gcTxtNew_Click);
            this.gcTxtNew.DoubleClick += new System.EventHandler(this.gcTxtNew_DoubleClick);
            // 
            // gcTxtExit
            // 
            this.gcTxtExit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gcTxtExit.ContentAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.gcTxtExit.ForeColor = System.Drawing.Color.Green;
            this.gcTxtExit.GridLine = new GrapeCity.Win.Editors.Line(GrapeCity.Win.Editors.LineStyle.Single, System.Drawing.Color.White);
            this.gcTxtExit.Location = new System.Drawing.Point(962, 22);
            this.gcTxtExit.Name = "gcTxtExit";
            this.gcTxtExit.ReadOnly = true;
            this.gcTxtExit.SingleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gcTxtExit.Size = new System.Drawing.Size(70, 25);
            this.gcTxtExit.TabIndex = 2;
            this.gcTxtExit.Text = "閉じる";
            this.gcTxtExit.Click += new System.EventHandler(this.gcTxtExit_Click);
            this.gcTxtExit.DoubleClick += new System.EventHandler(this.gcTxtExit_DoubleClick);
            // 
            // gcTxtClear
            // 
            this.gcTxtClear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gcTxtClear.ContentAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.gcTxtClear.ForeColor = System.Drawing.Color.Green;
            this.gcTxtClear.GridLine = new GrapeCity.Win.Editors.Line(GrapeCity.Win.Editors.LineStyle.Single, System.Drawing.Color.White);
            this.gcTxtClear.Location = new System.Drawing.Point(794, 22);
            this.gcTxtClear.Name = "gcTxtClear";
            this.gcTxtClear.ReadOnly = true;
            this.gcTxtClear.SingleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gcTxtClear.Size = new System.Drawing.Size(70, 25);
            this.gcTxtClear.TabIndex = 2;
            this.gcTxtClear.Text = "クリア";
            this.gcTxtClear.Click += new System.EventHandler(this.gcTxtClear_Click);
            this.gcTxtClear.DoubleClick += new System.EventHandler(this.gcTxtClear_DoubleClick);
            // 
            // gcTxtUpdate
            // 
            this.gcTxtUpdate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gcTxtUpdate.ContentAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.gcTxtUpdate.ForeColor = System.Drawing.Color.Green;
            this.gcTxtUpdate.GridLine = new GrapeCity.Win.Editors.Line(GrapeCity.Win.Editors.LineStyle.Single, System.Drawing.Color.White);
            this.gcTxtUpdate.Location = new System.Drawing.Point(879, 22);
            this.gcTxtUpdate.Name = "gcTxtUpdate";
            this.gcTxtUpdate.ReadOnly = true;
            this.gcTxtUpdate.SingleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gcTxtUpdate.Size = new System.Drawing.Size(70, 25);
            this.gcTxtUpdate.TabIndex = 2;
            this.gcTxtUpdate.Text = "更新";
            this.gcTxtUpdate.Click += new System.EventHandler(this.gcTxtUpdate_Click);
            this.gcTxtUpdate.DoubleClick += new System.EventHandler(this.gcTxtUpdate_DoubleClick);
            // 
            // gcTxtDelete
            // 
            this.gcTxtDelete.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gcTxtDelete.ContentAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.gcTxtDelete.ForeColor = System.Drawing.Color.Green;
            this.gcTxtDelete.GridLine = new GrapeCity.Win.Editors.Line(GrapeCity.Win.Editors.LineStyle.Single, System.Drawing.Color.White);
            this.gcTxtDelete.Location = new System.Drawing.Point(204, 48);
            this.gcTxtDelete.Name = "gcTxtDelete";
            this.gcTxtDelete.ReadOnly = true;
            this.gcShortcut1.SetShortcuts(this.gcTxtDelete, new GrapeCity.Win.Editors.ShortcutCollection(new System.Windows.Forms.Keys[] {
                System.Windows.Forms.Keys.F2}, new object[] {
                ((object)(this.gcTxtDelete))}, new string[] {
                "ShortcutClear"}));
            this.gcTxtDelete.SingleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gcTxtDelete.Size = new System.Drawing.Size(70, 25);
            this.gcTxtDelete.TabIndex = 2;
            this.gcTxtDelete.Text = "削除";
            this.gcTxtDelete.Click += new System.EventHandler(this.gcTxtDelete_Click);
            this.gcTxtDelete.DoubleClick += new System.EventHandler(this.gcTxtDelete_DoubleClick);
            // 
            // split2
            // 
            this.split2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.split2.IsSplitterFixed = true;
            this.split2.Location = new System.Drawing.Point(0, 0);
            this.split2.Name = "split2";
            // 
            // split2.Panel1
            // 
            this.split2.Panel1.Controls.Add(this.fpS1);
            // 
            // split2.Panel2
            // 
            this.split2.Panel2.Controls.Add(yakkyokuCodeLabel);
            this.split2.Panel2.Controls.Add(this.yakkyokuCodeTextBox);
            this.split2.Panel2.Controls.Add(uneiCommentLabel);
            this.split2.Panel2.Controls.Add(this.uneiCommentTextBox);
            this.split2.Panel2.Controls.Add(pdsIdLabel);
            this.split2.Panel2.Controls.Add(this.pdsIdTextBox);
            this.split2.Panel2.Controls.Add(passwordLabel);
            this.split2.Panel2.Controls.Add(this.passwordTextBox);
            this.split2.Panel2.Controls.Add(mailAddressLabel);
            this.split2.Panel2.Controls.Add(this.mailAddressTextBox);
            this.split2.Panel2.Controls.Add(kengenLabel);
            this.split2.Panel2.Controls.Add(this.kengenTextBox);
            this.split2.Panel2.Controls.Add(keiyakuYmdLabel);
            this.split2.Panel2.Controls.Add(this.keiyakuYmdTextBox);
            this.split2.Panel2.Controls.Add(kaijoYmdLabel);
            this.split2.Panel2.Controls.Add(this.kaijoYmdTextBox);
            this.split2.Panel2.Controls.Add(accountTeishiFlagLabel);
            this.split2.Panel2.Controls.Add(this.accountTeishiFlagTextBox);
            this.split2.Panel2.Controls.Add(accountSakujoFlagLabel);
            this.split2.Panel2.Controls.Add(this.accountSakujoFlagTextBox);
            this.split2.Panel2.Controls.Add(accountRankLabel);
            this.split2.Panel2.Controls.Add(this.accountRankTextBox);
            this.split2.Panel2.Controls.Add(accountKubunLabel);
            this.split2.Panel2.Controls.Add(this.accountKubunTextBox);
            this.split2.Size = new System.Drawing.Size(1060, 494);
            this.split2.SplitterDistance = 600;
            this.split2.TabIndex = 0;
            // 
            // fpS1
            // 
            this.fpS1.AccessibleDescription = "";
            this.fpS1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fpS1.Location = new System.Drawing.Point(0, 0);
            this.fpS1.Name = "fpS1";
            this.fpS1.Sheets.AddRange(new FarPoint.Win.Spread.SheetView[] {
            this.fpS1_Sheet1});
            this.fpS1.Size = new System.Drawing.Size(600, 494);
            this.fpS1.TabIndex = 0;
            // 
            // fpS1_Sheet1
            // 
            this.fpS1_Sheet1.Reset();
            this.fpS1_Sheet1.SheetName = "Sheet1";
            // Formulas and custom names must be loaded with R1C1 reference style
            this.fpS1_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.R1C1;
            this.fpS1_Sheet1.ColumnCount = 18;
            this.fpS1_Sheet1.ActiveColumnIndex = -1;
            this.fpS1_Sheet1.ActiveRowIndex = -1;
            numberCellType1.DecimalPlaces = 0;
            numberCellType1.LeadingZero = FarPoint.Win.Spread.CellType.LeadingZero.Yes;
            numberCellType1.MaximumValue = 2147483647D;
            numberCellType1.MinimumValue = -2147483648D;
            this.fpS1_Sheet1.Columns.Get(0).CellType = numberCellType1;
            this.fpS1_Sheet1.Columns.Get(0).DataField = "UserId";
            this.fpS1_Sheet1.Columns.Get(1).CellType = textCellType1;
            this.fpS1_Sheet1.Columns.Get(1).DataField = "Password";
            this.fpS1_Sheet1.Columns.Get(2).CellType = textCellType2;
            this.fpS1_Sheet1.Columns.Get(2).DataField = "PdsId";
            this.fpS1_Sheet1.Columns.Get(3).CellType = textCellType3;
            this.fpS1_Sheet1.Columns.Get(3).DataField = "MailAddress";
            this.fpS1_Sheet1.Columns.Get(4).CellType = textCellType4;
            this.fpS1_Sheet1.Columns.Get(4).DataField = "YakkyokuCode";
            this.fpS1_Sheet1.Columns.Get(5).CellType = textCellType5;
            this.fpS1_Sheet1.Columns.Get(5).DataField = "Kengen";
            this.fpS1_Sheet1.Columns.Get(6).CellType = textCellType6;
            this.fpS1_Sheet1.Columns.Get(6).DataField = "AccountRank";
            this.fpS1_Sheet1.Columns.Get(7).CellType = textCellType7;
            this.fpS1_Sheet1.Columns.Get(7).DataField = "AccountKubun";
            this.fpS1_Sheet1.Columns.Get(8).CellType = textCellType8;
            this.fpS1_Sheet1.Columns.Get(8).DataField = "AccountSakujoFlag";
            this.fpS1_Sheet1.Columns.Get(9).CellType = textCellType9;
            this.fpS1_Sheet1.Columns.Get(9).DataField = "AccountTeishiFlag";
            this.fpS1_Sheet1.Columns.Get(10).CellType = textCellType10;
            this.fpS1_Sheet1.Columns.Get(10).DataField = "UneiComment";
            this.fpS1_Sheet1.Columns.Get(11).CellType = textCellType11;
            this.fpS1_Sheet1.Columns.Get(11).DataField = "KeiyakuYmd";
            this.fpS1_Sheet1.Columns.Get(12).CellType = textCellType12;
            this.fpS1_Sheet1.Columns.Get(12).DataField = "KaijoYmd";
            this.fpS1_Sheet1.Columns.Get(13).DataField = "InsertUserId";
            this.fpS1_Sheet1.Columns.Get(14).DataField = "InsertNitiji";
            this.fpS1_Sheet1.Columns.Get(15).DataField = "UpdateUserId";
            this.fpS1_Sheet1.Columns.Get(16).DataField = "UpdateNitiji";
            this.fpS1_Sheet1.Columns.Get(17).CellType = textCellType13;
            this.fpS1_Sheet1.Columns.Get(17).DataField = "UpdateProgramId";
            this.fpS1_Sheet1.DataMember = "";
            this.fpS1_Sheet1.DataSource = this.userAccountBindingSource;
            this.fpS1_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.A1;
            // 
            // userAccountBindingSource
            // 
            this.userAccountBindingSource.DataSource = typeof(B2.BestFunction.Entities.UserAccount);
            // 
            // yakkyokuCodeTextBox
            // 
            this.yakkyokuCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userAccountBindingSource, "YakkyokuCode", true));
            this.yakkyokuCodeTextBox.Location = new System.Drawing.Point(160, 106);
            this.yakkyokuCodeTextBox.Name = "yakkyokuCodeTextBox";
            this.yakkyokuCodeTextBox.Size = new System.Drawing.Size(148, 24);
            this.yakkyokuCodeTextBox.TabIndex = 35;
            // 
            // uneiCommentTextBox
            // 
            this.uneiCommentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userAccountBindingSource, "UneiComment", true));
            this.uneiCommentTextBox.Location = new System.Drawing.Point(160, 299);
            this.uneiCommentTextBox.Multiline = true;
            this.uneiCommentTextBox.Name = "uneiCommentTextBox";
            this.uneiCommentTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.uneiCommentTextBox.Size = new System.Drawing.Size(283, 105);
            this.uneiCommentTextBox.TabIndex = 25;
            // 
            // pdsIdTextBox
            // 
            this.pdsIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userAccountBindingSource, "PdsId", true));
            this.pdsIdTextBox.Location = new System.Drawing.Point(160, 44);
            this.pdsIdTextBox.Name = "pdsIdTextBox";
            this.pdsIdTextBox.Size = new System.Drawing.Size(283, 24);
            this.pdsIdTextBox.TabIndex = 23;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userAccountBindingSource, "Password", true));
            this.passwordTextBox.Location = new System.Drawing.Point(160, 13);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(283, 24);
            this.passwordTextBox.TabIndex = 21;
            // 
            // mailAddressTextBox
            // 
            this.mailAddressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userAccountBindingSource, "MailAddress", true));
            this.mailAddressTextBox.Location = new System.Drawing.Point(160, 75);
            this.mailAddressTextBox.Name = "mailAddressTextBox";
            this.mailAddressTextBox.Size = new System.Drawing.Size(283, 24);
            this.mailAddressTextBox.TabIndex = 19;
            // 
            // kengenTextBox
            // 
            this.kengenTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userAccountBindingSource, "Kengen", true));
            this.kengenTextBox.Location = new System.Drawing.Point(160, 137);
            this.kengenTextBox.Name = "kengenTextBox";
            this.kengenTextBox.Size = new System.Drawing.Size(34, 24);
            this.kengenTextBox.TabIndex = 17;
            // 
            // keiyakuYmdTextBox
            // 
            this.keiyakuYmdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userAccountBindingSource, "KeiyakuYmd", true));
            this.keiyakuYmdTextBox.Location = new System.Drawing.Point(160, 410);
            this.keiyakuYmdTextBox.Name = "keiyakuYmdTextBox";
            this.keiyakuYmdTextBox.Size = new System.Drawing.Size(100, 24);
            this.keiyakuYmdTextBox.TabIndex = 15;
            // 
            // kaijoYmdTextBox
            // 
            this.kaijoYmdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userAccountBindingSource, "KaijoYmd", true));
            this.kaijoYmdTextBox.Location = new System.Drawing.Point(160, 441);
            this.kaijoYmdTextBox.Name = "kaijoYmdTextBox";
            this.kaijoYmdTextBox.Size = new System.Drawing.Size(100, 24);
            this.kaijoYmdTextBox.TabIndex = 13;
            // 
            // accountTeishiFlagTextBox
            // 
            this.accountTeishiFlagTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userAccountBindingSource, "AccountTeishiFlag", true));
            this.accountTeishiFlagTextBox.Location = new System.Drawing.Point(160, 261);
            this.accountTeishiFlagTextBox.Name = "accountTeishiFlagTextBox";
            this.accountTeishiFlagTextBox.Size = new System.Drawing.Size(34, 24);
            this.accountTeishiFlagTextBox.TabIndex = 7;
            // 
            // accountSakujoFlagTextBox
            // 
            this.accountSakujoFlagTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userAccountBindingSource, "AccountSakujoFlag", true));
            this.accountSakujoFlagTextBox.Location = new System.Drawing.Point(160, 230);
            this.accountSakujoFlagTextBox.Name = "accountSakujoFlagTextBox";
            this.accountSakujoFlagTextBox.Size = new System.Drawing.Size(34, 24);
            this.accountSakujoFlagTextBox.TabIndex = 5;
            // 
            // accountRankTextBox
            // 
            this.accountRankTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userAccountBindingSource, "AccountRank", true));
            this.accountRankTextBox.Location = new System.Drawing.Point(160, 168);
            this.accountRankTextBox.Name = "accountRankTextBox";
            this.accountRankTextBox.Size = new System.Drawing.Size(34, 24);
            this.accountRankTextBox.TabIndex = 3;
            // 
            // accountKubunTextBox
            // 
            this.accountKubunTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userAccountBindingSource, "AccountKubun", true));
            this.accountKubunTextBox.Location = new System.Drawing.Point(160, 199);
            this.accountKubunTextBox.Name = "accountKubunTextBox";
            this.accountKubunTextBox.Size = new System.Drawing.Size(34, 24);
            this.accountKubunTextBox.TabIndex = 1;
            // 
            // frmUserAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 620);
            this.Controls.Add(this.split1);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "frmUserAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ユーザーアカウント情報保守";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Shown += new System.EventHandler(this.frmMain_Shown);
            this.split1.Panel1.ResumeLayout(false);
            this.split1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.split1)).EndInit();
            this.split1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcTxtModify)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTxtDownload)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTxtCsv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTxtPdf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTxtTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTxtNew)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTxtExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTxtClear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTxtUpdate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTxtDelete)).EndInit();
            this.split2.Panel1.ResumeLayout(false);
            this.split2.Panel2.ResumeLayout(false);
            this.split2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.split2)).EndInit();
            this.split2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fpS1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpS1_Sheet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userAccountBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer split1;
        private System.Windows.Forms.SplitContainer split2;
        private FarPoint.Win.Spread.FpSpread fpS1;
        private FarPoint.Win.Spread.SheetView fpS1_Sheet1;
        private System.Windows.Forms.BindingSource userAccountBindingSource;
        private System.Windows.Forms.TextBox yakkyokuCodeTextBox;
        private System.Windows.Forms.TextBox uneiCommentTextBox;
        private System.Windows.Forms.TextBox pdsIdTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox mailAddressTextBox;
        private System.Windows.Forms.TextBox kengenTextBox;
        private System.Windows.Forms.TextBox keiyakuYmdTextBox;
        private System.Windows.Forms.TextBox kaijoYmdTextBox;
        private System.Windows.Forms.TextBox accountTeishiFlagTextBox;
        private System.Windows.Forms.TextBox accountSakujoFlagTextBox;
        private System.Windows.Forms.TextBox accountRankTextBox;
        private System.Windows.Forms.TextBox accountKubunTextBox;
        private GrapeCity.Win.Editors.GcTextBox gcTxtModify;
        private GrapeCity.Win.Editors.GcTextBox gcTxtDownload;
        private GrapeCity.Win.Editors.GcTextBox gcTxtCsv;
        private GrapeCity.Win.Editors.GcTextBox gcTxtPdf;
        private GrapeCity.Win.Editors.GcTextBox gcTxtNew;
        private GrapeCity.Win.Editors.GcTextBox gcTxtClear;
        private GrapeCity.Win.Editors.GcTextBox gcTxtUpdate;
        private GrapeCity.Win.Editors.GcTextBox gcTxtDelete;
        private GrapeCity.Win.Editors.GcShortcut gcShortcut1;
        private GrapeCity.Win.Editors.GcTextBox gcTxtExit;
        private GrapeCity.Win.Editors.GcTextBox gcTxtTitle;

    }
}

