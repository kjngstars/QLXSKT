namespace PresentationLayer
{
    partial class FormDanhSachLoaiVe
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
            this.components = new System.ComponentModel.Container();
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem_Them = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_Sua = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_Xoa = new System.Windows.Forms.ToolStripMenuItem();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl
            // 
            this.gridControl.ContextMenuStrip = this.contextMenuStrip;
            this.gridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl.Location = new System.Drawing.Point(0, 0);
            this.gridControl.MainView = this.gridView;
            this.gridControl.Name = "gridControl";
            this.gridControl.Size = new System.Drawing.Size(784, 561);
            this.gridControl.TabIndex = 0;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_Them,
            this.toolStripMenuItem_Sua,
            this.toolStripMenuItem_Xoa});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(106, 70);
            // 
            // toolStripMenuItem_Them
            // 
            this.toolStripMenuItem_Them.Name = "toolStripMenuItem_Them";
            this.toolStripMenuItem_Them.Size = new System.Drawing.Size(105, 22);
            this.toolStripMenuItem_Them.Text = "Thêm";
            this.toolStripMenuItem_Them.Click += new System.EventHandler(this.toolStripMenuItem_Them_Click);
            // 
            // toolStripMenuItem_Sua
            // 
            this.toolStripMenuItem_Sua.Name = "toolStripMenuItem_Sua";
            this.toolStripMenuItem_Sua.Size = new System.Drawing.Size(105, 22);
            this.toolStripMenuItem_Sua.Text = "Sửa";
            // 
            // toolStripMenuItem_Xoa
            // 
            this.toolStripMenuItem_Xoa.Name = "toolStripMenuItem_Xoa";
            this.toolStripMenuItem_Xoa.Size = new System.Drawing.Size(105, 22);
            this.toolStripMenuItem_Xoa.Text = "Xóa";
            // 
            // gridView
            // 
            this.gridView.GridControl = this.gridControl;
            this.gridView.Name = "gridView";
            this.gridView.OptionsBehavior.Editable = false;
            this.gridView.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView_RowClick);
            // 
            // FormDanhSachLoaiVe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.gridControl);
            this.Name = "FormDanhSachLoaiVe";
            this.Text = "Danh Sách Loại Vé";
            this.Load += new System.EventHandler(this.FormDanhSachLoaiVe_Load);
            this.Shown += new System.EventHandler(this.FormDanhSachLoaiVe_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Them;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Sua;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Xoa;
    }
}