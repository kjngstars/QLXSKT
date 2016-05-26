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
    public partial class FormEditCCGT : DevExpress.XtraEditors.XtraForm
    {
        private CoCauGiaiThuong coCauGiaiThuong = null;
        private CoCauGiaiThuongBUS coCauGiaiThuongBUS = null;

        public FormEditCCGT()
        {
            InitializeComponent();

            this.coCauGiaiThuongBUS = new CoCauGiaiThuongBUS();
        }

        private void FormEditCCGT_Load(object sender, EventArgs e)
        {
            if (this.coCauGiaiThuong == null)
                this.InsertLoad();
        }

        public void InsertLoad()
        {
            this.barEditItem_NgayLap.EditValue = DateTime.Now;

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("TENGIAITHUONG");
            dataTable.Columns.Add("TRIGIA");
            dataTable.Columns.Add("SOLUONG");
            dataTable.Columns.Add("SOCHUSOTRUNG");
            dataTable.Columns.Add("SOLANQUAY");

            this.gridControl.DataSource = dataTable;
        }

        private void barButtonItem_Them_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.gridView.AddNewRow();
        }

        private void barButtonItem_Xoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.gridView.DeleteSelectedRows();
        }

        private void simpleButton_OK_Click(object sender, EventArgs e)
        {
            if (this.coCauGiaiThuong == null)
                this.InsertCCGT();
        }

        private void simpleButton_Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        public void InsertCCGT()
        {
            try
            {
                this.coCauGiaiThuong = new CoCauGiaiThuong(
                    string.Empty, this.barEditItem_NgayLap.EditValue.ToString());

                this.coCauGiaiThuong.MaCoCauGiaiThuong = this.coCauGiaiThuongBUS.Insert(this.coCauGiaiThuong);

                for (int i = 0; i < this.gridView.RowCount; i++)
                {
                    GiaiThuong giaiThuong = new GiaiThuong(this.gridView.GetDataRow(i));
                    giaiThuong.MaCoCauGiaiThuong = this.coCauGiaiThuong.MaCoCauGiaiThuong;
                }

                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                this.coCauGiaiThuong = null;

                XtraMessageBox.Show(ex.Message);
            }
        }
    }
}