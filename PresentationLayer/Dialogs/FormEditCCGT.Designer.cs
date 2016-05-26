namespace PresentationLayer.Dialogs
{
    partial class FormEditCCGT
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
            this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barEditItem_NgayLap = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemDateEdit = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.barButtonItem_Them = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem_Xoa = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup_CCGT = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup_GiaiThuong = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.simpleButton_Cancel = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton_OK = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MAGIAITHUONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TENGIAITHUONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit_TenGiaiThuong = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.MACOCAUGIAITHUONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TRIGIA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit_TriGia = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.SOLUONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit_SoLuong = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.SOCHUSOTRUNG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit_SoChuSoTrung = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.SOLANQUAY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit_SoLanQuay = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit_TenGiaiThuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit_TriGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit_SoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit_SoChuSoTrung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit_SoLanQuay)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl
            // 
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl.ExpandCollapseItem,
            this.barEditItem_NgayLap,
            this.barButtonItem_Them,
            this.barButtonItem_Xoa});
            this.ribbonControl.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl.MaxItemId = 6;
            this.ribbonControl.Name = "ribbonControl";
            this.ribbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage});
            this.ribbonControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemDateEdit});
            this.ribbonControl.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbonControl.ShowToolbarCustomizeItem = false;
            this.ribbonControl.Size = new System.Drawing.Size(784, 120);
            this.ribbonControl.Toolbar.ShowCustomizeItem = false;
            // 
            // barEditItem_NgayLap
            // 
            this.barEditItem_NgayLap.Caption = "Ngày Lập";
            this.barEditItem_NgayLap.Edit = this.repositoryItemDateEdit;
            this.barEditItem_NgayLap.Id = 3;
            this.barEditItem_NgayLap.Name = "barEditItem_NgayLap";
            this.barEditItem_NgayLap.Width = 200;
            // 
            // repositoryItemDateEdit
            // 
            this.repositoryItemDateEdit.AutoHeight = false;
            this.repositoryItemDateEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit.Name = "repositoryItemDateEdit";
            // 
            // barButtonItem_Them
            // 
            this.barButtonItem_Them.Caption = "Thêm";
            this.barButtonItem_Them.Id = 4;
            this.barButtonItem_Them.LargeGlyph = global::PresentationLayer.Properties.Resources.Add;
            this.barButtonItem_Them.Name = "barButtonItem_Them";
            this.barButtonItem_Them.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem_Them_ItemClick);
            // 
            // barButtonItem_Xoa
            // 
            this.barButtonItem_Xoa.Caption = "Xóa";
            this.barButtonItem_Xoa.Id = 5;
            this.barButtonItem_Xoa.LargeGlyph = global::PresentationLayer.Properties.Resources.Delete;
            this.barButtonItem_Xoa.Name = "barButtonItem_Xoa";
            this.barButtonItem_Xoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem_Xoa_ItemClick);
            // 
            // ribbonPage
            // 
            this.ribbonPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup_CCGT,
            this.ribbonPageGroup_GiaiThuong});
            this.ribbonPage.Name = "ribbonPage";
            this.ribbonPage.Text = "Cơ Cấu Giải Thưởng";
            // 
            // ribbonPageGroup_CCGT
            // 
            this.ribbonPageGroup_CCGT.ItemLinks.Add(this.barEditItem_NgayLap);
            this.ribbonPageGroup_CCGT.Name = "ribbonPageGroup_CCGT";
            this.ribbonPageGroup_CCGT.ShowCaptionButton = false;
            this.ribbonPageGroup_CCGT.Text = "Cơ Cấu Giải Thưởng";
            // 
            // ribbonPageGroup_GiaiThuong
            // 
            this.ribbonPageGroup_GiaiThuong.ItemLinks.Add(this.barButtonItem_Them);
            this.ribbonPageGroup_GiaiThuong.ItemLinks.Add(this.barButtonItem_Xoa);
            this.ribbonPageGroup_GiaiThuong.Name = "ribbonPageGroup_GiaiThuong";
            this.ribbonPageGroup_GiaiThuong.ShowCaptionButton = false;
            this.ribbonPageGroup_GiaiThuong.Text = "Giải Thưởng";
            // 
            // simpleButton_Cancel
            // 
            this.simpleButton_Cancel.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.simpleButton_Cancel.Image = global::PresentationLayer.Properties.Resources.Cancel;
            this.simpleButton_Cancel.Location = new System.Drawing.Point(442, 489);
            this.simpleButton_Cancel.Name = "simpleButton_Cancel";
            this.simpleButton_Cancel.Size = new System.Drawing.Size(80, 60);
            this.simpleButton_Cancel.TabIndex = 14;
            this.simpleButton_Cancel.Text = "Cancel";
            this.simpleButton_Cancel.Click += new System.EventHandler(this.simpleButton_Cancel_Click);
            // 
            // simpleButton_OK
            // 
            this.simpleButton_OK.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.simpleButton_OK.Image = global::PresentationLayer.Properties.Resources.Apply;
            this.simpleButton_OK.Location = new System.Drawing.Point(262, 489);
            this.simpleButton_OK.Name = "simpleButton_OK";
            this.simpleButton_OK.Size = new System.Drawing.Size(80, 60);
            this.simpleButton_OK.TabIndex = 13;
            this.simpleButton_OK.Text = "OK";
            this.simpleButton_OK.Click += new System.EventHandler(this.simpleButton_OK_Click);
            // 
            // gridControl
            // 
            this.gridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.gridControl.Location = new System.Drawing.Point(0, 120);
            this.gridControl.MainView = this.gridView;
            this.gridControl.MenuManager = this.ribbonControl;
            this.gridControl.Name = "gridControl";
            this.gridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit_TenGiaiThuong,
            this.repositoryItemTextEdit_TriGia,
            this.repositoryItemTextEdit_SoLuong,
            this.repositoryItemTextEdit_SoChuSoTrung,
            this.repositoryItemTextEdit_SoLanQuay});
            this.gridControl.Size = new System.Drawing.Size(784, 363);
            this.gridControl.TabIndex = 16;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // gridView
            // 
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MAGIAITHUONG,
            this.TENGIAITHUONG,
            this.MACOCAUGIAITHUONG,
            this.TRIGIA,
            this.SOLUONG,
            this.SOCHUSOTRUNG,
            this.SOLANQUAY});
            this.gridView.GridControl = this.gridControl;
            this.gridView.Name = "gridView";
            this.gridView.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridView.OptionsView.ShowGroupPanel = false;
            // 
            // MAGIAITHUONG
            // 
            this.MAGIAITHUONG.Caption = "Mã Giải Thưởng";
            this.MAGIAITHUONG.FieldName = "MAGIAITHUONG";
            this.MAGIAITHUONG.Name = "MAGIAITHUONG";
            // 
            // TENGIAITHUONG
            // 
            this.TENGIAITHUONG.Caption = "Tên Giải Thưởng";
            this.TENGIAITHUONG.ColumnEdit = this.repositoryItemTextEdit_TenGiaiThuong;
            this.TENGIAITHUONG.FieldName = "TENGIAITHUONG";
            this.TENGIAITHUONG.Name = "TENGIAITHUONG";
            this.TENGIAITHUONG.Visible = true;
            this.TENGIAITHUONG.VisibleIndex = 0;
            // 
            // repositoryItemTextEdit_TenGiaiThuong
            // 
            this.repositoryItemTextEdit_TenGiaiThuong.AutoHeight = false;
            this.repositoryItemTextEdit_TenGiaiThuong.Mask.UseMaskAsDisplayFormat = true;
            this.repositoryItemTextEdit_TenGiaiThuong.MaxLength = 500;
            this.repositoryItemTextEdit_TenGiaiThuong.Name = "repositoryItemTextEdit_TenGiaiThuong";
            // 
            // MACOCAUGIAITHUONG
            // 
            this.MACOCAUGIAITHUONG.Caption = "Mã Cơ Cấu Giải Thưởng";
            this.MACOCAUGIAITHUONG.FieldName = "MACOCAUGIAITHUONG";
            this.MACOCAUGIAITHUONG.Name = "MACOCAUGIAITHUONG";
            // 
            // TRIGIA
            // 
            this.TRIGIA.Caption = "Trị Giá";
            this.TRIGIA.ColumnEdit = this.repositoryItemTextEdit_TriGia;
            this.TRIGIA.DisplayFormat.FormatString = "c0";
            this.TRIGIA.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.TRIGIA.FieldName = "TRIGIA";
            this.TRIGIA.Name = "TRIGIA";
            this.TRIGIA.Visible = true;
            this.TRIGIA.VisibleIndex = 1;
            // 
            // repositoryItemTextEdit_TriGia
            // 
            this.repositoryItemTextEdit_TriGia.AutoHeight = false;
            this.repositoryItemTextEdit_TriGia.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemTextEdit_TriGia.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemTextEdit_TriGia.Mask.EditMask = "c0";
            this.repositoryItemTextEdit_TriGia.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.repositoryItemTextEdit_TriGia.Mask.UseMaskAsDisplayFormat = true;
            this.repositoryItemTextEdit_TriGia.Name = "repositoryItemTextEdit_TriGia";
            this.repositoryItemTextEdit_TriGia.NullText = "0";
            // 
            // SOLUONG
            // 
            this.SOLUONG.Caption = "Số Lượng";
            this.SOLUONG.ColumnEdit = this.repositoryItemTextEdit_SoLuong;
            this.SOLUONG.FieldName = "SOLUONG";
            this.SOLUONG.Name = "SOLUONG";
            this.SOLUONG.Visible = true;
            this.SOLUONG.VisibleIndex = 2;
            // 
            // repositoryItemTextEdit_SoLuong
            // 
            this.repositoryItemTextEdit_SoLuong.AutoHeight = false;
            this.repositoryItemTextEdit_SoLuong.Mask.EditMask = "\\d+";
            this.repositoryItemTextEdit_SoLuong.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.repositoryItemTextEdit_SoLuong.Mask.UseMaskAsDisplayFormat = true;
            this.repositoryItemTextEdit_SoLuong.MaxLength = 10;
            this.repositoryItemTextEdit_SoLuong.Name = "repositoryItemTextEdit_SoLuong";
            this.repositoryItemTextEdit_SoLuong.NullText = "0";
            // 
            // SOCHUSOTRUNG
            // 
            this.SOCHUSOTRUNG.Caption = "Số Chữ Số Trúng";
            this.SOCHUSOTRUNG.ColumnEdit = this.repositoryItemTextEdit_SoChuSoTrung;
            this.SOCHUSOTRUNG.FieldName = "SOCHUSOTRUNG";
            this.SOCHUSOTRUNG.Name = "SOCHUSOTRUNG";
            this.SOCHUSOTRUNG.Visible = true;
            this.SOCHUSOTRUNG.VisibleIndex = 3;
            // 
            // repositoryItemTextEdit_SoChuSoTrung
            // 
            this.repositoryItemTextEdit_SoChuSoTrung.AutoHeight = false;
            this.repositoryItemTextEdit_SoChuSoTrung.Mask.EditMask = "\\d+";
            this.repositoryItemTextEdit_SoChuSoTrung.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.repositoryItemTextEdit_SoChuSoTrung.Mask.UseMaskAsDisplayFormat = true;
            this.repositoryItemTextEdit_SoChuSoTrung.MaxLength = 10;
            this.repositoryItemTextEdit_SoChuSoTrung.Name = "repositoryItemTextEdit_SoChuSoTrung";
            this.repositoryItemTextEdit_SoChuSoTrung.NullText = "0";
            // 
            // SOLANQUAY
            // 
            this.SOLANQUAY.Caption = "Số Lần Quay";
            this.SOLANQUAY.ColumnEdit = this.repositoryItemTextEdit_SoLanQuay;
            this.SOLANQUAY.FieldName = "SOLANQUAY";
            this.SOLANQUAY.Name = "SOLANQUAY";
            this.SOLANQUAY.Visible = true;
            this.SOLANQUAY.VisibleIndex = 4;
            // 
            // repositoryItemTextEdit_SoLanQuay
            // 
            this.repositoryItemTextEdit_SoLanQuay.AutoHeight = false;
            this.repositoryItemTextEdit_SoLanQuay.Mask.EditMask = "\\d+";
            this.repositoryItemTextEdit_SoLanQuay.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.repositoryItemTextEdit_SoLanQuay.Mask.UseMaskAsDisplayFormat = true;
            this.repositoryItemTextEdit_SoLanQuay.Name = "repositoryItemTextEdit_SoLanQuay";
            this.repositoryItemTextEdit_SoLanQuay.NullText = "0";
            // 
            // FormEditCCGT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.gridControl);
            this.Controls.Add(this.simpleButton_Cancel);
            this.Controls.Add(this.simpleButton_OK);
            this.Controls.Add(this.ribbonControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormEditCCGT";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cơ Cấu Giải Thưởng";
            this.Load += new System.EventHandler(this.FormEditCCGT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit_TenGiaiThuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit_TriGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit_SoLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit_SoChuSoTrung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit_SoLanQuay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup_CCGT;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup_GiaiThuong;
        private DevExpress.XtraBars.BarEditItem barEditItem_NgayLap;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_Them;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_Xoa;
        private DevExpress.XtraEditors.SimpleButton simpleButton_Cancel;
        private DevExpress.XtraEditors.SimpleButton simpleButton_OK;
        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraGrid.Columns.GridColumn TENGIAITHUONG;
        private DevExpress.XtraGrid.Columns.GridColumn TRIGIA;
        private DevExpress.XtraGrid.Columns.GridColumn SOLUONG;
        private DevExpress.XtraGrid.Columns.GridColumn SOCHUSOTRUNG;
        private DevExpress.XtraGrid.Columns.GridColumn SOLANQUAY;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit_TenGiaiThuong;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit_TriGia;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit_SoLuong;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit_SoChuSoTrung;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit_SoLanQuay;
        private DevExpress.XtraGrid.Columns.GridColumn MAGIAITHUONG;
        private DevExpress.XtraGrid.Columns.GridColumn MACOCAUGIAITHUONG;
    }
}