using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BusinessLogicLayer;

namespace PresentationLayer.Dialogs
{
    public partial class FormEditLoaiVe : DevExpress.XtraEditors.XtraForm
    {
        private LoaiVe loaiVe = null;
        private LoaiVeBUS loaiVeBUS = null;
        private DoiTacBUS doiTacBUS = null;
        private CoCauGiaiThuongBUS coCauGiaiThuongBUS = null;

        /// <summary>
        /// Khởi tạo để thêm loại vé
        /// </summary>
        public FormEditLoaiVe()
        {
            InitializeComponent();

            this.loaiVeBUS = new LoaiVeBUS();
            this.doiTacBUS = new DoiTacBUS();
            this.coCauGiaiThuongBUS = new CoCauGiaiThuongBUS();
        }

        /// <summary>
        /// Khởi tạo để cập nhật loại vé
        /// </summary>
        public FormEditLoaiVe(string maLoaiVe)
        {
            InitializeComponent();

            this.loaiVeBUS = new LoaiVeBUS();
            this.doiTacBUS = new DoiTacBUS();
            this.coCauGiaiThuongBUS = new CoCauGiaiThuongBUS();

            try
            {
                this.loaiVe = this.loaiVeBUS.GetLoaiVeByMaLoaiVe(maLoaiVe);
            }
            catch (Exception ex)
            {
                this.DialogResult = DialogResult.Abort;

                XtraMessageBox.Show(ex.Message, @"Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormEditLoaiVe_Load(object sender, EventArgs e)
        {
            if (this.loaiVe == null)
                this.InsertLoad();
            else
                this.EditLoad();

            this.FillCTPhatHanh();
            this.FillMaCCGT();
        }

        /// <summary>
        /// Hàm load để thêm loại vé
        /// </summary>
        public void InsertLoad()
        {
            this.dateEdit_NgayLap.EditValue = DateTime.Now;
        }

        /// <summary>
        /// Hàm load để cập nhật loại vé
        /// </summary>
        public void EditLoad()
        {
            this.textEdit_TenLoaiVe.Text = this.loaiVe.TenLoaiVe;
            this.dateEdit_NgayLap.EditValue = this.loaiVe.NgayLap;
            this.textEdit_MenhGia.Text = ((int)this.loaiVe.MenhGia).ToString();
        }

        private void FillCTPhatHanh()
        {
            DataTable dataTable = this.doiTacBUS.GetAll_CT();

            DoiTac ct = new DoiTac(null, "Công ty");
            this.comboBoxEdit_CTPhatHanh.Properties.Items.Add(ct);

            foreach (DataRow row in dataTable.Rows)
            {
                DoiTac doiTac = new DoiTac(row);

                this.comboBoxEdit_CTPhatHanh.Properties.Items.Add(doiTac);
            }

            if (this.loaiVe == null ||
                this.loaiVe.MaDoiTac == string.Empty)
                this.comboBoxEdit_CTPhatHanh.SelectedIndex = 0;
            else
            {
                for (int i = 0; i < this.comboBoxEdit_CTPhatHanh.Properties.Items.Count; i++)
                    if (((DoiTac)this.comboBoxEdit_CTPhatHanh.Properties.Items[i]).MaDoiTac == this.loaiVe.MaDoiTac)
                    {
                        this.comboBoxEdit_CTPhatHanh.SelectedIndex = i;
                        break;
                    }
            }
        }

        private void FillMaCCGT()
        {
            DataTable dataTable = this.coCauGiaiThuongBUS.GetAll();

            foreach (DataRow row in dataTable.Rows)
            {
                CoCauGiaiThuong coCauGiaiThuong = new CoCauGiaiThuong(row);

                this.comboBoxEdit_MaCCGT.Properties.Items.Add(coCauGiaiThuong);
            }

            if (this.loaiVe == null)
                this.comboBoxEdit_MaCCGT.SelectedIndex = 0;
            else
            {
                for (int i = 0; i < this.comboBoxEdit_MaCCGT.Properties.Items.Count; i++)
                    if (((CoCauGiaiThuong)this.comboBoxEdit_MaCCGT.Properties.Items[i]).MaCoCauGiaiThuong == this.loaiVe.MaCoCauGiaiThuong)
                    {
                        this.comboBoxEdit_MaCCGT.SelectedIndex = i;
                        break;
                    }
            }

        }

        private void simpleButton_OK_Click(object sender, EventArgs e)
        {
            if (this.loaiVe == null)
                this.InsertGiaiThuong();
            else
                this.UpdateGiaiThuong();
        }

        private void simpleButton_Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        /// <summary>
        /// Thêm loại vé
        /// </summary>
        public void InsertGiaiThuong()
        {
            try
            {
                this.loaiVe = new LoaiVe(
                    string.Empty,
                    this.textEdit_TenLoaiVe.Text,
                    this.dateEdit_NgayLap.Text,
                    decimal.Parse(this.textEdit_MenhGia.EditValue.ToString()),
                    ((DoiTac)this.comboBoxEdit_CTPhatHanh.SelectedItem).MaDoiTac,
                    this.comboBoxEdit_MaCCGT.Text);

                this.loaiVe.MaLoaiVe = this.loaiVeBUS.Insert(this.loaiVe);

                this.DialogResult = DialogResult.OK;

                XtraMessageBox.Show("Thêm Thành Công", @"Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                this.loaiVe = null;

                XtraMessageBox.Show(ex.Message, @"Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Cập nhật loại vé
        /// </summary>
        public void UpdateGiaiThuong()
        {
            try
            {
                this.loaiVe = new LoaiVe(
                       this.loaiVe.MaLoaiVe,
                       this.textEdit_TenLoaiVe.Text,
                       this.dateEdit_NgayLap.Text,
                       decimal.Parse(this.textEdit_MenhGia.EditValue.ToString()),
                       ((DoiTac)this.comboBoxEdit_CTPhatHanh.SelectedItem).MaDoiTac,
                       this.comboBoxEdit_MaCCGT.Text);

                this.loaiVeBUS.Update(this.loaiVe);

                this.DialogResult = DialogResult.OK;

                XtraMessageBox.Show("Cập Nhật Thành Công", @"Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, @"Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}