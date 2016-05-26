namespace PresentationLayer.Dialogs
{
    partial class FormEditLoaiVe
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
            this.labelControl_TenLoaiVe = new DevExpress.XtraEditors.LabelControl();
            this.textEdit_TenLoaiVe = new DevExpress.XtraEditors.TextEdit();
            this.labelControl_NgayLap = new DevExpress.XtraEditors.LabelControl();
            this.dateEdit_NgayLap = new DevExpress.XtraEditors.DateEdit();
            this.labelControl_LoaiVe = new DevExpress.XtraEditors.LabelControl();
            this.textEdit_MenhGia = new DevExpress.XtraEditors.TextEdit();
            this.labelControl_MenhGia = new DevExpress.XtraEditors.LabelControl();
            this.labelControl_CTPhatHanh = new DevExpress.XtraEditors.LabelControl();
            this.comboBoxEdit_CTPhatHanh = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl_MaCCGT = new DevExpress.XtraEditors.LabelControl();
            this.comboBoxEdit_MaCCGT = new DevExpress.XtraEditors.ComboBoxEdit();
            this.simpleButton_OK = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton_Cancel = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_TenLoaiVe.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_NgayLap.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_NgayLap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_MenhGia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit_CTPhatHanh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit_MaCCGT.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl_TenLoaiVe
            // 
            this.labelControl_TenLoaiVe.Appearance.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.labelControl_TenLoaiVe.Location = new System.Drawing.Point(12, 80);
            this.labelControl_TenLoaiVe.Name = "labelControl_TenLoaiVe";
            this.labelControl_TenLoaiVe.Size = new System.Drawing.Size(75, 20);
            this.labelControl_TenLoaiVe.TabIndex = 0;
            this.labelControl_TenLoaiVe.Text = "Tên Loại Vé";
            // 
            // textEdit_TenLoaiVe
            // 
            this.textEdit_TenLoaiVe.Location = new System.Drawing.Point(122, 77);
            this.textEdit_TenLoaiVe.Name = "textEdit_TenLoaiVe";
            this.textEdit_TenLoaiVe.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.textEdit_TenLoaiVe.Properties.Appearance.Options.UseFont = true;
            this.textEdit_TenLoaiVe.Properties.MaxLength = 500;
            this.textEdit_TenLoaiVe.Size = new System.Drawing.Size(250, 26);
            this.textEdit_TenLoaiVe.TabIndex = 1;
            // 
            // labelControl_NgayLap
            // 
            this.labelControl_NgayLap.Appearance.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.labelControl_NgayLap.Location = new System.Drawing.Point(12, 120);
            this.labelControl_NgayLap.Name = "labelControl_NgayLap";
            this.labelControl_NgayLap.Size = new System.Drawing.Size(63, 20);
            this.labelControl_NgayLap.TabIndex = 2;
            this.labelControl_NgayLap.Text = "Ngày Lập";
            // 
            // dateEdit_NgayLap
            // 
            this.dateEdit_NgayLap.EditValue = null;
            this.dateEdit_NgayLap.Location = new System.Drawing.Point(122, 117);
            this.dateEdit_NgayLap.Name = "dateEdit_NgayLap";
            this.dateEdit_NgayLap.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.dateEdit_NgayLap.Properties.Appearance.Options.UseFont = true;
            this.dateEdit_NgayLap.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit_NgayLap.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit_NgayLap.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.dateEdit_NgayLap.Size = new System.Drawing.Size(250, 26);
            this.dateEdit_NgayLap.TabIndex = 3;
            // 
            // labelControl_LoaiVe
            // 
            this.labelControl_LoaiVe.Appearance.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.labelControl_LoaiVe.Location = new System.Drawing.Point(12, 20);
            this.labelControl_LoaiVe.Name = "labelControl_LoaiVe";
            this.labelControl_LoaiVe.Size = new System.Drawing.Size(81, 32);
            this.labelControl_LoaiVe.TabIndex = 4;
            this.labelControl_LoaiVe.Text = "Loại Vé";
            // 
            // textEdit_MenhGia
            // 
            this.textEdit_MenhGia.EditValue = "";
            this.textEdit_MenhGia.Location = new System.Drawing.Point(122, 157);
            this.textEdit_MenhGia.Name = "textEdit_MenhGia";
            this.textEdit_MenhGia.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.textEdit_MenhGia.Properties.Appearance.Options.UseFont = true;
            this.textEdit_MenhGia.Properties.DisplayFormat.FormatString = "c0";
            this.textEdit_MenhGia.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.textEdit_MenhGia.Properties.EditFormat.FormatString = "c0";
            this.textEdit_MenhGia.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.textEdit_MenhGia.Properties.Mask.EditMask = "c0";
            this.textEdit_MenhGia.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.textEdit_MenhGia.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.textEdit_MenhGia.Properties.MaxLength = 10;
            this.textEdit_MenhGia.Properties.NullText = "0";
            this.textEdit_MenhGia.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textEdit_MenhGia.Size = new System.Drawing.Size(250, 26);
            this.textEdit_MenhGia.TabIndex = 6;
            // 
            // labelControl_MenhGia
            // 
            this.labelControl_MenhGia.Appearance.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.labelControl_MenhGia.Location = new System.Drawing.Point(12, 160);
            this.labelControl_MenhGia.Name = "labelControl_MenhGia";
            this.labelControl_MenhGia.Size = new System.Drawing.Size(63, 20);
            this.labelControl_MenhGia.TabIndex = 5;
            this.labelControl_MenhGia.Text = "Mệnh Giá";
            // 
            // labelControl_CTPhatHanh
            // 
            this.labelControl_CTPhatHanh.Appearance.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.labelControl_CTPhatHanh.Location = new System.Drawing.Point(12, 200);
            this.labelControl_CTPhatHanh.Name = "labelControl_CTPhatHanh";
            this.labelControl_CTPhatHanh.Size = new System.Drawing.Size(89, 20);
            this.labelControl_CTPhatHanh.TabIndex = 7;
            this.labelControl_CTPhatHanh.Text = "CT Phát Hành";
            // 
            // comboBoxEdit_CTPhatHanh
            // 
            this.comboBoxEdit_CTPhatHanh.Location = new System.Drawing.Point(122, 197);
            this.comboBoxEdit_CTPhatHanh.Name = "comboBoxEdit_CTPhatHanh";
            this.comboBoxEdit_CTPhatHanh.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.comboBoxEdit_CTPhatHanh.Properties.Appearance.Options.UseFont = true;
            this.comboBoxEdit_CTPhatHanh.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEdit_CTPhatHanh.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.comboBoxEdit_CTPhatHanh.Size = new System.Drawing.Size(250, 26);
            this.comboBoxEdit_CTPhatHanh.TabIndex = 8;
            // 
            // labelControl_MaCCGT
            // 
            this.labelControl_MaCCGT.Appearance.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.labelControl_MaCCGT.Location = new System.Drawing.Point(12, 240);
            this.labelControl_MaCCGT.Name = "labelControl_MaCCGT";
            this.labelControl_MaCCGT.Size = new System.Drawing.Size(61, 20);
            this.labelControl_MaCCGT.TabIndex = 9;
            this.labelControl_MaCCGT.Text = "Mã CCGT";
            // 
            // comboBoxEdit_MaCCGT
            // 
            this.comboBoxEdit_MaCCGT.Location = new System.Drawing.Point(122, 237);
            this.comboBoxEdit_MaCCGT.Name = "comboBoxEdit_MaCCGT";
            this.comboBoxEdit_MaCCGT.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.comboBoxEdit_MaCCGT.Properties.Appearance.Options.UseFont = true;
            this.comboBoxEdit_MaCCGT.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEdit_MaCCGT.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.comboBoxEdit_MaCCGT.Size = new System.Drawing.Size(250, 26);
            this.comboBoxEdit_MaCCGT.TabIndex = 10;
            // 
            // simpleButton_OK
            // 
            this.simpleButton_OK.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.simpleButton_OK.Image = global::PresentationLayer.Properties.Resources.Apply;
            this.simpleButton_OK.Location = new System.Drawing.Point(62, 289);
            this.simpleButton_OK.Name = "simpleButton_OK";
            this.simpleButton_OK.Size = new System.Drawing.Size(80, 60);
            this.simpleButton_OK.TabIndex = 11;
            this.simpleButton_OK.Text = "OK";
            this.simpleButton_OK.Click += new System.EventHandler(this.simpleButton_OK_Click);
            // 
            // simpleButton_Cancel
            // 
            this.simpleButton_Cancel.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.simpleButton_Cancel.Image = global::PresentationLayer.Properties.Resources.Cancel;
            this.simpleButton_Cancel.Location = new System.Drawing.Point(242, 289);
            this.simpleButton_Cancel.Name = "simpleButton_Cancel";
            this.simpleButton_Cancel.Size = new System.Drawing.Size(80, 60);
            this.simpleButton_Cancel.TabIndex = 12;
            this.simpleButton_Cancel.Text = "Cancel";
            this.simpleButton_Cancel.Click += new System.EventHandler(this.simpleButton_Cancel_Click);
            // 
            // FormEditLoaiVe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.simpleButton_Cancel);
            this.Controls.Add(this.simpleButton_OK);
            this.Controls.Add(this.comboBoxEdit_MaCCGT);
            this.Controls.Add(this.labelControl_MaCCGT);
            this.Controls.Add(this.comboBoxEdit_CTPhatHanh);
            this.Controls.Add(this.labelControl_CTPhatHanh);
            this.Controls.Add(this.textEdit_MenhGia);
            this.Controls.Add(this.labelControl_MenhGia);
            this.Controls.Add(this.labelControl_LoaiVe);
            this.Controls.Add(this.dateEdit_NgayLap);
            this.Controls.Add(this.labelControl_NgayLap);
            this.Controls.Add(this.textEdit_TenLoaiVe);
            this.Controls.Add(this.labelControl_TenLoaiVe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "FormEditLoaiVe";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Loại Vé";
            this.Load += new System.EventHandler(this.FormEditLoaiVe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_TenLoaiVe.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_NgayLap.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_NgayLap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_MenhGia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit_CTPhatHanh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit_MaCCGT.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl_TenLoaiVe;
        private DevExpress.XtraEditors.TextEdit textEdit_TenLoaiVe;
        private DevExpress.XtraEditors.LabelControl labelControl_NgayLap;
        private DevExpress.XtraEditors.DateEdit dateEdit_NgayLap;
        private DevExpress.XtraEditors.LabelControl labelControl_LoaiVe;
        private DevExpress.XtraEditors.TextEdit textEdit_MenhGia;
        private DevExpress.XtraEditors.LabelControl labelControl_MenhGia;
        private DevExpress.XtraEditors.LabelControl labelControl_CTPhatHanh;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit_CTPhatHanh;
        private DevExpress.XtraEditors.LabelControl labelControl_MaCCGT;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit_MaCCGT;
        private DevExpress.XtraEditors.SimpleButton simpleButton_OK;
        private DevExpress.XtraEditors.SimpleButton simpleButton_Cancel;
    }
}