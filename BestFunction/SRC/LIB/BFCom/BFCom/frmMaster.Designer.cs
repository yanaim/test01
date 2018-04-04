namespace B2.BestFunction
{
    public partial class frmMaster
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.split_1 = new System.Windows.Forms.SplitContainer();
            this.split_2 = new System.Windows.Forms.SplitContainer();
            this.spd1 = new FarPoint.Win.Spread.FpSpread();
            this.spd1_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.menuStrip_ms = new System.Windows.Forms.MenuStrip();
            this.File_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Cancel_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Exit_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Edit_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.New_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Modify_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Delete_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Update_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Show_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Select_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Refresh_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Sort_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Output_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Print_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Csv_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Renkei_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Download_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Detail_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.split_1)).BeginInit();
            this.split_1.Panel2.SuspendLayout();
            this.split_1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.split_2)).BeginInit();
            this.split_2.Panel1.SuspendLayout();
            this.split_2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spd1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spd1_Sheet1)).BeginInit();
            this.menuStrip_ms.SuspendLayout();
            this.SuspendLayout();
            // 
            // split_1
            // 
            this.split_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.split_1.Location = new System.Drawing.Point(0, 0);
            this.split_1.Name = "split_1";
            this.split_1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // split_1.Panel2
            // 
            this.split_1.Panel2.Controls.Add(this.split_2);
            this.split_1.Size = new System.Drawing.Size(1206, 692);
            this.split_1.SplitterDistance = 85;
            this.split_1.SplitterWidth = 1;
            this.split_1.TabIndex = 1;
            // 
            // split_2
            // 
            this.split_2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.split_2.Location = new System.Drawing.Point(0, 0);
            this.split_2.Name = "split_2";
            // 
            // split_2.Panel1
            // 
            this.split_2.Panel1.Controls.Add(this.spd1);
            this.split_2.Size = new System.Drawing.Size(1206, 606);
            this.split_2.SplitterDistance = 700;
            this.split_2.SplitterWidth = 1;
            this.split_2.TabIndex = 0;
            // 
            // spd1
            // 
            this.spd1.AccessibleDescription = "spd1, Sheet1, Row 0, Column 0, ";
            this.spd1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spd1.Location = new System.Drawing.Point(0, 0);
            this.spd1.Name = "spd1";
            this.spd1.Sheets.AddRange(new FarPoint.Win.Spread.SheetView[] {
            this.spd1_Sheet1});
            this.spd1.Size = new System.Drawing.Size(700, 606);
            this.spd1.TabIndex = 0;
            // 
            // spd1_Sheet1
            // 
            this.spd1_Sheet1.Reset();
            this.spd1_Sheet1.SheetName = "Sheet1";
            // Formulas and custom names must be loaded with R1C1 reference style
            this.spd1_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.R1C1;
            this.spd1_Sheet1.ActiveSkin = FarPoint.Win.Spread.DefaultSkins.Professional1;
            this.spd1_Sheet1.ColumnFooter.Columns.Default.VisualStyles = FarPoint.Win.VisualStyles.Off;
            this.spd1_Sheet1.ColumnFooter.DefaultStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(132)))));
            this.spd1_Sheet1.ColumnFooter.DefaultStyle.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.spd1_Sheet1.ColumnFooter.DefaultStyle.ForeColor = System.Drawing.Color.White;
            this.spd1_Sheet1.ColumnFooter.DefaultStyle.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.General;
            this.spd1_Sheet1.ColumnFooter.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red;
            this.spd1_Sheet1.ColumnFooter.DefaultStyle.Parent = "HeaderDefault";
            this.spd1_Sheet1.ColumnFooter.DefaultStyle.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.General;
            this.spd1_Sheet1.ColumnFooter.DefaultStyle.VisualStyles = FarPoint.Win.VisualStyles.Off;
            this.spd1_Sheet1.ColumnFooter.Rows.Default.VisualStyles = FarPoint.Win.VisualStyles.Off;
            this.spd1_Sheet1.ColumnFooterSheetCornerStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(132)))));
            this.spd1_Sheet1.ColumnFooterSheetCornerStyle.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.spd1_Sheet1.ColumnFooterSheetCornerStyle.ForeColor = System.Drawing.Color.White;
            this.spd1_Sheet1.ColumnFooterSheetCornerStyle.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.General;
            this.spd1_Sheet1.ColumnFooterSheetCornerStyle.NoteIndicatorColor = System.Drawing.Color.Red;
            this.spd1_Sheet1.ColumnFooterSheetCornerStyle.Parent = "HeaderDefault";
            this.spd1_Sheet1.ColumnFooterSheetCornerStyle.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.General;
            this.spd1_Sheet1.ColumnFooterSheetCornerStyle.VisualStyles = FarPoint.Win.VisualStyles.Off;
            this.spd1_Sheet1.ColumnHeader.Columns.Default.VisualStyles = FarPoint.Win.VisualStyles.Off;
            this.spd1_Sheet1.ColumnHeader.DefaultStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(132)))));
            this.spd1_Sheet1.ColumnHeader.DefaultStyle.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.spd1_Sheet1.ColumnHeader.DefaultStyle.ForeColor = System.Drawing.Color.White;
            this.spd1_Sheet1.ColumnHeader.DefaultStyle.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.General;
            this.spd1_Sheet1.ColumnHeader.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red;
            this.spd1_Sheet1.ColumnHeader.DefaultStyle.Parent = "HeaderDefault";
            this.spd1_Sheet1.ColumnHeader.DefaultStyle.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.General;
            this.spd1_Sheet1.ColumnHeader.DefaultStyle.VisualStyles = FarPoint.Win.VisualStyles.Off;
            this.spd1_Sheet1.ColumnHeader.Rows.Default.VisualStyles = FarPoint.Win.VisualStyles.Off;
            this.spd1_Sheet1.DefaultStyle.BackColor = System.Drawing.Color.White;
            this.spd1_Sheet1.DefaultStyle.ForeColor = System.Drawing.Color.Black;
            this.spd1_Sheet1.DefaultStyle.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.General;
            this.spd1_Sheet1.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red;
            this.spd1_Sheet1.DefaultStyle.Parent = "DataAreaDefault";
            this.spd1_Sheet1.DefaultStyle.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.General;
            this.spd1_Sheet1.FilterBar.DefaultStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(132)))));
            this.spd1_Sheet1.FilterBar.DefaultStyle.ForeColor = System.Drawing.Color.White;
            this.spd1_Sheet1.FilterBar.DefaultStyle.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.General;
            this.spd1_Sheet1.FilterBar.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red;
            this.spd1_Sheet1.FilterBar.DefaultStyle.Parent = "FilterBarDefault";
            this.spd1_Sheet1.FilterBar.DefaultStyle.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.General;
            this.spd1_Sheet1.FilterBar.DefaultStyle.VisualStyles = FarPoint.Win.VisualStyles.Off;
            this.spd1_Sheet1.FilterBarHeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(132)))));
            this.spd1_Sheet1.FilterBarHeaderStyle.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.General;
            this.spd1_Sheet1.FilterBarHeaderStyle.NoteIndicatorColor = System.Drawing.Color.Red;
            this.spd1_Sheet1.FilterBarHeaderStyle.Parent = "RowHeaderDefault";
            this.spd1_Sheet1.FilterBarHeaderStyle.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.General;
            this.spd1_Sheet1.FilterBarHeaderStyle.VisualStyles = FarPoint.Win.VisualStyles.Off;
            this.spd1_Sheet1.RowHeader.Columns.Default.Resizable = false;
            this.spd1_Sheet1.RowHeader.Columns.Default.VisualStyles = FarPoint.Win.VisualStyles.Off;
            this.spd1_Sheet1.RowHeader.DefaultStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(132)))));
            this.spd1_Sheet1.RowHeader.DefaultStyle.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.spd1_Sheet1.RowHeader.DefaultStyle.ForeColor = System.Drawing.Color.White;
            this.spd1_Sheet1.RowHeader.DefaultStyle.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.General;
            this.spd1_Sheet1.RowHeader.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red;
            this.spd1_Sheet1.RowHeader.DefaultStyle.Parent = "HeaderDefault";
            this.spd1_Sheet1.RowHeader.DefaultStyle.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.General;
            this.spd1_Sheet1.RowHeader.DefaultStyle.VisualStyles = FarPoint.Win.VisualStyles.Off;
            this.spd1_Sheet1.RowHeader.Rows.Default.VisualStyles = FarPoint.Win.VisualStyles.Off;
            this.spd1_Sheet1.SheetCornerStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(132)))));
            this.spd1_Sheet1.SheetCornerStyle.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.spd1_Sheet1.SheetCornerStyle.ForeColor = System.Drawing.Color.White;
            this.spd1_Sheet1.SheetCornerStyle.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.General;
            this.spd1_Sheet1.SheetCornerStyle.NoteIndicatorColor = System.Drawing.Color.Red;
            this.spd1_Sheet1.SheetCornerStyle.Parent = "HeaderDefault";
            this.spd1_Sheet1.SheetCornerStyle.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.General;
            this.spd1_Sheet1.SheetCornerStyle.VisualStyles = FarPoint.Win.VisualStyles.Off;
            this.spd1_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.A1;
            // 
            // menuStrip_ms
            // 
            this.menuStrip_ms.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.File_ToolStripMenuItem,
            this.Edit_ToolStripMenuItem,
            this.Show_ToolStripMenuItem,
            this.Output_ToolStripMenuItem,
            this.Renkei_ToolStripMenuItem});
            this.menuStrip_ms.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_ms.Name = "menuStrip_ms";
            this.menuStrip_ms.Size = new System.Drawing.Size(1206, 26);
            this.menuStrip_ms.TabIndex = 2;
            this.menuStrip_ms.Text = "menuStrip1";
            // 
            // File_ToolStripMenuItem
            // 
            this.File_ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Cancel_ToolStripMenuItem,
            this.Exit_ToolStripMenuItem});
            this.File_ToolStripMenuItem.Name = "File_ToolStripMenuItem";
            this.File_ToolStripMenuItem.Size = new System.Drawing.Size(68, 22);
            this.File_ToolStripMenuItem.Text = "ファイル";
            // 
            // Cancel_ToolStripMenuItem
            // 
            this.Cancel_ToolStripMenuItem.Name = "Cancel_ToolStripMenuItem";
            this.Cancel_ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.Cancel_ToolStripMenuItem.Text = "取消終了";
            this.Cancel_ToolStripMenuItem.Click += new System.EventHandler(this.Cancel_ToolStripMenuItem_Click);
            // 
            // Exit_ToolStripMenuItem
            // 
            this.Exit_ToolStripMenuItem.Name = "Exit_ToolStripMenuItem";
            this.Exit_ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.Exit_ToolStripMenuItem.Text = "終了";
            this.Exit_ToolStripMenuItem.Click += new System.EventHandler(this.Exit_ToolStripMenuItem_Click);
            // 
            // Edit_ToolStripMenuItem
            // 
            this.Edit_ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.New_ToolStripMenuItem,
            this.Modify_ToolStripMenuItem,
            this.Delete_ToolStripMenuItem,
            this.Update_ToolStripMenuItem});
            this.Edit_ToolStripMenuItem.Name = "Edit_ToolStripMenuItem";
            this.Edit_ToolStripMenuItem.Size = new System.Drawing.Size(44, 22);
            this.Edit_ToolStripMenuItem.Text = "編集";
            // 
            // New_ToolStripMenuItem
            // 
            this.New_ToolStripMenuItem.Name = "New_ToolStripMenuItem";
            this.New_ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.New_ToolStripMenuItem.Text = "新規";
            this.New_ToolStripMenuItem.Click += new System.EventHandler(this.New_ToolStripMenuItem_Click);
            // 
            // Modify_ToolStripMenuItem
            // 
            this.Modify_ToolStripMenuItem.Name = "Modify_ToolStripMenuItem";
            this.Modify_ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.Modify_ToolStripMenuItem.Text = "訂正";
            this.Modify_ToolStripMenuItem.Click += new System.EventHandler(this.Modify_ToolStripMenuItem_Click);
            // 
            // Delete_ToolStripMenuItem
            // 
            this.Delete_ToolStripMenuItem.Name = "Delete_ToolStripMenuItem";
            this.Delete_ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.Delete_ToolStripMenuItem.Text = "削除";
            this.Delete_ToolStripMenuItem.Click += new System.EventHandler(this.Delete_ToolStripMenuItem_Click);
            // 
            // Update_ToolStripMenuItem
            // 
            this.Update_ToolStripMenuItem.Name = "Update_ToolStripMenuItem";
            this.Update_ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.Update_ToolStripMenuItem.Text = "更新";
            this.Update_ToolStripMenuItem.Click += new System.EventHandler(this.Update_ToolStripMenuItem_Click);
            // 
            // Show_ToolStripMenuItem
            // 
            this.Show_ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Select_ToolStripMenuItem,
            this.Refresh_ToolStripMenuItem,
            this.Sort_ToolStripMenuItem});
            this.Show_ToolStripMenuItem.Name = "Show_ToolStripMenuItem";
            this.Show_ToolStripMenuItem.Size = new System.Drawing.Size(44, 22);
            this.Show_ToolStripMenuItem.Text = "表示";
            // 
            // Select_ToolStripMenuItem
            // 
            this.Select_ToolStripMenuItem.Name = "Select_ToolStripMenuItem";
            this.Select_ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.Select_ToolStripMenuItem.Text = "検索";
            this.Select_ToolStripMenuItem.Click += new System.EventHandler(this.Select_ToolStripMenuItem_Click);
            // 
            // Refresh_ToolStripMenuItem
            // 
            this.Refresh_ToolStripMenuItem.Name = "Refresh_ToolStripMenuItem";
            this.Refresh_ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.Refresh_ToolStripMenuItem.Text = "リフレッシュ";
            this.Refresh_ToolStripMenuItem.Click += new System.EventHandler(this.Refresh_ToolStripMenuItem_Click);
            // 
            // Sort_ToolStripMenuItem
            // 
            this.Sort_ToolStripMenuItem.Name = "Sort_ToolStripMenuItem";
            this.Sort_ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.Sort_ToolStripMenuItem.Text = "ソート";
            this.Sort_ToolStripMenuItem.Click += new System.EventHandler(this.Sort_ToolStripMenuItem_Click);
            // 
            // Output_ToolStripMenuItem
            // 
            this.Output_ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Print_ToolStripMenuItem,
            this.Csv_ToolStripMenuItem,
            this.Detail_ToolStripMenuItem});
            this.Output_ToolStripMenuItem.Name = "Output_ToolStripMenuItem";
            this.Output_ToolStripMenuItem.Size = new System.Drawing.Size(44, 22);
            this.Output_ToolStripMenuItem.Text = "出力";
            // 
            // Print_ToolStripMenuItem
            // 
            this.Print_ToolStripMenuItem.Name = "Print_ToolStripMenuItem";
            this.Print_ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.Print_ToolStripMenuItem.Text = "印刷";
            this.Print_ToolStripMenuItem.Click += new System.EventHandler(this.Print_ToolStripMenuItem_Click);
            // 
            // Csv_ToolStripMenuItem
            // 
            this.Csv_ToolStripMenuItem.Name = "Csv_ToolStripMenuItem";
            this.Csv_ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.Csv_ToolStripMenuItem.Text = "CSV出力";
            this.Csv_ToolStripMenuItem.Click += new System.EventHandler(this.Csv_ToolStripMenuItem_Click);
            // 
            // Renkei_ToolStripMenuItem
            // 
            this.Renkei_ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Download_ToolStripMenuItem});
            this.Renkei_ToolStripMenuItem.Name = "Renkei_ToolStripMenuItem";
            this.Renkei_ToolStripMenuItem.Size = new System.Drawing.Size(44, 22);
            this.Renkei_ToolStripMenuItem.Text = "連携";
            // 
            // Download_ToolStripMenuItem
            // 
            this.Download_ToolStripMenuItem.Name = "Download_ToolStripMenuItem";
            this.Download_ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.Download_ToolStripMenuItem.Text = "ダウンロード";
            this.Download_ToolStripMenuItem.Click += new System.EventHandler(this.Download_ToolStripMenuItem_Click);
            // 
            // Detail_ToolStripMenuItem
            // 
            this.Detail_ToolStripMenuItem.Name = "Detail_ToolStripMenuItem";
            this.Detail_ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.Detail_ToolStripMenuItem.Text = "一覧印刷";
            this.Detail_ToolStripMenuItem.Click += new System.EventHandler(this.Detail_ToolStripMenuItem_Click);
            // 
            // frmMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1206, 692);
            this.Controls.Add(this.menuStrip_ms);
            this.Controls.Add(this.split_1);
            this.MaximizeBox = false;
            this.Name = "frmMaster";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMaster";
            this.split_1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.split_1)).EndInit();
            this.split_1.ResumeLayout(false);
            this.split_2.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.split_2)).EndInit();
            this.split_2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spd1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spd1_Sheet1)).EndInit();
            this.menuStrip_ms.ResumeLayout(false);
            this.menuStrip_ms.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.SplitContainer split_1;
        public System.Windows.Forms.SplitContainer split_2;
        public FarPoint.Win.Spread.FpSpread spd1;
        public FarPoint.Win.Spread.SheetView spd1_Sheet1;
        public  System.Windows.Forms.MenuStrip menuStrip_ms;
        public  System.Windows.Forms.ToolStripMenuItem File_ToolStripMenuItem;
        public  System.Windows.Forms.ToolStripMenuItem Cancel_ToolStripMenuItem;
        public  System.Windows.Forms.ToolStripMenuItem Exit_ToolStripMenuItem;
        public  System.Windows.Forms.ToolStripMenuItem Edit_ToolStripMenuItem;
        public  System.Windows.Forms.ToolStripMenuItem New_ToolStripMenuItem;
        public  System.Windows.Forms.ToolStripMenuItem Modify_ToolStripMenuItem;
        public  System.Windows.Forms.ToolStripMenuItem Delete_ToolStripMenuItem;
        public  System.Windows.Forms.ToolStripMenuItem Update_ToolStripMenuItem;
        public  System.Windows.Forms.ToolStripMenuItem Show_ToolStripMenuItem;
        public  System.Windows.Forms.ToolStripMenuItem Select_ToolStripMenuItem;
        public  System.Windows.Forms.ToolStripMenuItem Refresh_ToolStripMenuItem;
        public  System.Windows.Forms.ToolStripMenuItem Sort_ToolStripMenuItem;
        public  System.Windows.Forms.ToolStripMenuItem Output_ToolStripMenuItem;
        public  System.Windows.Forms.ToolStripMenuItem Print_ToolStripMenuItem;
        public  System.Windows.Forms.ToolStripMenuItem Csv_ToolStripMenuItem;
        public  System.Windows.Forms.ToolStripMenuItem Renkei_ToolStripMenuItem;
        public  System.Windows.Forms.ToolStripMenuItem Download_ToolStripMenuItem;
        public  System.Windows.Forms.ToolStripMenuItem Detail_ToolStripMenuItem;
    }
}