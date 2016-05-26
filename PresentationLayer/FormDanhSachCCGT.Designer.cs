namespace PresentationLayer
{
    partial class FormDanhSachCCGT
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
            this.toolStripMenuItem_CapNhat = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_Xoa = new System.Windows.Forms.ToolStripMenuItem();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MACOCAUGIAITHUONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NGAYLAP = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.gridControl.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.gridControl_MouseDoubleClick);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_Them,
            this.toolStripMenuItem_CapNhat,
            this.toolStripMenuItem_Xoa});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(153, 92);
            // 
            // toolStripMenuItem_Them
            // 
            this.toolStripMenuItem_Them.Name = "toolStripMenuItem_Them";
            this.toolStripMenuItem_Them.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem_Them.Text = "Thêm";
            this.toolStripMenuItem_Them.Click += new System.EventHandler(this.toolStripMenuItem_Them_Click);
            // 
            // toolStripMenuItem_CapNhat
            // 
            this.toolStripMenuItem_CapNhat.Name = "toolStripMenuItem_CapNhat";
            this.toolStripMenuItem_CapNhat.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem_CapNhat.Text = "Cập Nhật";
            this.toolStripMenuItem_CapNhat.Click += new System.EventHandler(this.toolStripMenuItem_CapNhat_Click);
            // 
            // toolStripMenuItem_Xoa
            // 
            this.toolStripMenuItem_Xoa.Name = "toolStripMenuItem_Xoa";
            this.toolStripMenuItem_Xoa.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem_Xoa.Text = "Xóa";
            this.toolStripMenuItem_Xoa.Click += new System.EventHandler(this.toolStripMenuItem_Xoa_Click);
            // 
            // gridView
            // 
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MACOCAUGIAITHUONG,
            this.NGAYLAP});
            this.gridView.GridControl = this.gridControl;
            this.gridView.Name = "gridView";
            this.gridView.OptionsBehavior.AutoPopulateColumns = false;
            this.gridView.OptionsBehavior.Editable = false;
            this.gridView.OptionsView.ShowGroupPanel = false;
            // 
            // MACOCAUGIAITHUONG
            // 
            this.MACOCAUGIAITHUONG.Caption = "Mã Cơ Cấu Giải Thưởng";
            this.MACOCAUGIAITHUONG.FieldName = "MACOCAUGIAITHUONG";
            this.MACOCAUGIAITHUONG.Name = "MACOCAUGIAITHUONG";
            this.MACOCAUGIAITHUONG.Visible = true;
            this.MACOCAUGIAITHUONG.VisibleIndex = 0;
            // 
            // NGAYLAP
            // 
            this.NGAYLAP.Caption = "Ngày Lập";
            this.NGAYLAP.FieldName = "NGAYLAP";
            this.NGAYLAP.Name = "NGAYLAP";
            this.NGAYLAP.Visible = true;
            this.NGAYLAP.VisibleIndex = 1;
            // 
            // FormDanhSachCCGT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.gridControl);
            this.Name = "FormDanhSachCCGT";
            this.Text = "Danh Sách Cơ Cấu Giải Thưởng";
            this.Load += new System.EventHandler(this.FormDanhSachCCGT_Load);
            this.Shown += new System.EventHandler(this.FormDanhSachCCGT_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraGrid.Columns.GridColumn MACOCAUGIAITHUONG;
        private DevExpress.XtraGrid.Columns.GridColumn NGAYLAP;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Them;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_CapNhat;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Xoa;
    }
}