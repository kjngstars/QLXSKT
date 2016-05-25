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

namespace PresentationLayer.Dialog
{
    public partial class FormEditLoaiVe : DevExpress.XtraEditors.XtraForm
    {
        private bool isEdit = false;
        private LoaiVeBUS loaiVeBUS = null;
        private DoiTacBUS doiTacBUS = null;
        private CoCauGiaiThuongBUS coCauGiaiThuongBUS = null;

        public FormEditLoaiVe()
        {
            InitializeComponent();
        }

        private void FormEditLoaiVe_Load(object sender, EventArgs e)
        {
            if (!this.isEdit)
                this.dateEdit_NgayLap.EditValue = DateTime.Now;

            this.loaiVeBUS = new LoaiVeBUS();
            this.doiTacBUS = new DoiTacBUS();
            this.coCauGiaiThuongBUS = new CoCauGiaiThuongBUS();

            this.Fill_CTPhatHanh();
            this.Fill_MaCCGT();
        }

        private void Fill_CTPhatHanh()
        {
            DataTable dataTable = this.doiTacBUS.GetAll_CT();

            DoiTac ct = new DoiTac(null, "Công Ty");
            this.comboBoxEdit_CTPhatHanh.Properties.Items.Add(ct);

            foreach (DataRow row in dataTable.Rows)
            {
                DoiTac doiTac = new DoiTac(row);

                this.comboBoxEdit_CTPhatHanh.Properties.Items.Add(doiTac);
            }

            this.comboBoxEdit_CTPhatHanh.SelectedIndex = 0;
        }

        private void Fill_MaCCGT()
        {
            DataTable dataTable = this.coCauGiaiThuongBUS.GetAll();

            foreach (DataRow row in dataTable.Rows)
            {
                CoCauGiaiThuong coCauGiaiThuong = new CoCauGiaiThuong(row);

                this.comboBoxEdit_MaCCGT.Properties.Items.Add(coCauGiaiThuong);
            }

            if (!this.isEdit && dataTable.Rows.Count > 0)
                this.comboBoxEdit_MaCCGT.SelectedIndex = 0;
        }

        private void simpleButton_OK_Click(object sender, EventArgs e)
        {
            if (!this.isEdit)
            {
                try
                {
                    LoaiVe loaiVe = new LoaiVe(
                        string.Empty,
                        this.textEdit_TenLoaiVe.Text,
                        this.dateEdit_NgayLap.Text,
                        decimal.Parse(this.textEdit_MenhGia.Text),
                        ((DoiTac)this.comboBoxEdit_CTPhatHanh.SelectedItem).MaDoiTac,
                        this.comboBoxEdit_MaCCGT.Text);

                    this.loaiVeBUS.Insert(loaiVe);

                    this.DialogResult = DialogResult.OK;
                    this.Owner = null;

                    XtraMessageBox.Show("Thêm Thành Công");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message);
                }
            }
        }

        private void simpleButton_Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Owner = null;
        }
    }
}