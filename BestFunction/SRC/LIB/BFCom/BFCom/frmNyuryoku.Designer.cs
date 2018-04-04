namespace B2.BestFunction
{
    public partial class frmNyuryoku
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
            this.終了ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.split_1)).BeginInit();
            this.split_1.Panel1.SuspendLayout();
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
            // split_1.Panel1
            // 
            this.split_1.Panel1.Controls.Add(this.menuStrip_ms);
            // 
            // split_1.Panel2
            // 
            this.split_1.Panel2.Controls.Add(this.split_2);
            this.split_1.Size = new System.Drawing.Size(1206, 692);
            this.split_1.SplitterDistance = 244;
            this.split_1.SplitterWidth = 1;
            this.split_1.TabIndex = 1;
            // 
            // split_2
            // 
            this.split_2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.split_2.Location = new System.Drawing.Point(0, 0);
            this.split_2.Name = "split_2";
            this.split_2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // split_2.Panel1
            // 
            this.split_2.Panel1.Controls.Add(this.spd1);
            this.split_2.Size = new System.Drawing.Size(1206, 447);
            this.split_2.SplitterDistance = 308;
            this.split_2.TabIndex = 0;
            // 
            // spd1
            // 
            this.spd1.AccessibleDescription = "";
            this.spd1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spd1.Location = new System.Drawing.Point(0, 0);
            this.spd1.Name = "spd1";
            this.spd1.Sheets.AddRange(new FarPoint.Win.Spread.SheetView[] {
            this.spd1_Sheet1});
            this.spd1.Size = new System.Drawing.Size(1206, 308);
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
            this.終了ToolStripMenuItem});
            this.menuStrip_ms.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_ms.Name = "menuStrip_ms";
            this.menuStrip_ms.Size = new System.Drawing.Size(1206, 26);
            this.menuStrip_ms.TabIndex = 0;
            this.menuStrip_ms.Text = "menuStrip1";
            // 
            // 終了ToolStripMenuItem
            // 
            this.終了ToolStripMenuItem.Name = "終了ToolStripMenuItem";
            this.終了ToolStripMenuItem.Size = new System.Drawing.Size(44, 22);
            this.終了ToolStripMenuItem.Text = "終了";
            // 
            // frmNyuryoku
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1206, 692);
            this.Controls.Add(this.split_1);
            this.MaximizeBox = false;
            this.Name = "frmNyuryoku";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmNyuryoku";
            this.split_1.Panel1.ResumeLayout(false);
            this.split_1.Panel1.PerformLayout();
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

        }

        #endregion

        public System.Windows.Forms.SplitContainer split_1;
        private System.Windows.Forms.SplitContainer split_2;
        private FarPoint.Win.Spread.FpSpread spd1;
        private FarPoint.Win.Spread.SheetView spd1_Sheet1;
        private System.Windows.Forms.MenuStrip menuStrip_ms;
        private System.Windows.Forms.ToolStripMenuItem 終了ToolStripMenuItem;
    }
}