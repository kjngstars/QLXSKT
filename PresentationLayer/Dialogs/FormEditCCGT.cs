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
        private GiaiThuongBUS giaiThuongBUS = null;
        List<string> listMaGiaiThuongToDelete = null;

        /// <summary>
        /// Khởi tạo để thêm CCGT
        /// </summary>
        public FormEditCCGT()
        {
            InitializeComponent();

            this.coCauGiaiThuongBUS = new CoCauGiaiThuongBUS();
            this.giaiThuongBUS = new GiaiThuongBUS();
            this.listMaGiaiThuongToDelete = new List<string>();
        }

        /// <summary>
        /// Khởi tạo để cập nhật CCGT
        /// </summary>
        public FormEditCCGT(string maCoCauGiaiThuong)
        {
            InitializeComponent();

            this.coCauGiaiThuongBUS = new CoCauGiaiThuongBUS();
            this.giaiThuongBUS = new GiaiThuongBUS();
            this.listMaGiaiThuongToDelete = new List<string>();

            try
            {
                this.coCauGiaiThuong = this.coCauGiaiThuongBUS.GetCoCauGiaiThuongByMaCoCauGiaiThuong(maCoCauGiaiThuong);
            }
            catch (Exception ex)
            {
                this.DialogResult = DialogResult.Abort;

                XtraMessageBox.Show(ex.Message, @"Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormEditCCGT_Load(object sender, EventArgs e)
        {
            if (this.coCauGiaiThuong == null)
                this.InsertLoad();
            else
                this.EditLoad();
        }

        /// <summary>
        /// Hàm load để thêm CCGT
        /// </summary>
        public void InsertLoad()
        {
            this.barEditItem_NgayLap.EditValue = DateTime.Now;

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("MAGIAITHUONG");
            dataTable.Columns.Add("TENGIAITHUONG");
            dataTable.Columns.Add("MACOCAUGIAITHUONG");
            dataTable.Columns.Add("TRIGIA");
            dataTable.Columns.Add("SOLUONG");
            dataTable.Columns.Add("SOCHUSOTRUNG");
            dataTable.Columns.Add("SOLANQUAY");

            this.gridControl.DataSource = dataTable;
        }

        /// <summary>
        /// Hàm load để cập nhật CCGT
        /// </summary>
        public void EditLoad()
        {
            this.barEditItem_NgayLap.EditValue = this.coCauGiaiThuong.NgayLap;

            this.gridControl.DataSource = this.giaiThuongBUS.GetGiaiThuongByMaCoCauGiaiThuong(this.coCauGiaiThuong.MaCoCauGiaiThuong);
        }

        /// <summary>
        /// Thêm giải thưởng
        /// </summary>
        private void barButtonItem_Them_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.gridView.AddNewRow();
        }

        /// <summary>
        /// Xóa giải thưởng
        /// </summary>
        private void barButtonItem_Xoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (this.gridView.FocusedRowHandle != -1)
            {
                string maGiaiThuong = this.gridView.GetDataRow(this.gridView.FocusedRowHandle)["MaGiaiThuong"].ToString();

                if (maGiaiThuong != string.Empty)
                    this.listMaGiaiThuongToDelete.Add(maGiaiThuong);
            }

            this.gridView.DeleteSelectedRows();
        }

        private void simpleButton_OK_Click(object sender, EventArgs e)
        {
            if (this.coCauGiaiThuong == null)
                this.InsertCCGT();
            else
                this.UpdateCCGT();
        }

        private void simpleButton_Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        /// <summary>
        /// Thêm CCGT
        /// </summary>
        public void InsertCCGT()
        {
            try
            {
                this.coCauGiaiThuong = new CoCauGiaiThuong(string.Empty, this.barEditItem_NgayLap.EditValue.ToString());

                this.coCauGiaiThuong.MaCoCauGiaiThuong = this.coCauGiaiThuongBUS.Insert(this.coCauGiaiThuong);

                for (int i = 0; i < this.gridView.RowCount; i++)
                    this.InsertGiaiThuong(this.gridView.GetDataRow(i));

                this.DialogResult = DialogResult.OK;

                XtraMessageBox.Show("Thêm Thành Công", @"Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                this.coCauGiaiThuong = null;

                XtraMessageBox.Show(ex.Message, @"Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Thêm giải thưởng
        /// </summary>
        public void InsertGiaiThuong(DataRow row)
        {
            GiaiThuong giaiThuong = new GiaiThuong(row);
            giaiThuong.MaCoCauGiaiThuong = this.coCauGiaiThuong.MaCoCauGiaiThuong;

            this.giaiThuongBUS.Insert(giaiThuong);
        }

        /// <summary>
        /// Cập nhật CCGT
        /// </summary>
        public void UpdateCCGT()
        {
            try
            {
                this.coCauGiaiThuong.NgayLap = this.barEditItem_NgayLap.EditValue.ToString();

                this.coCauGiaiThuongBUS.Update(this.coCauGiaiThuong);

                foreach (string maGiaiThuong in this.listMaGiaiThuongToDelete)
                    try
                    {
                        this.giaiThuongBUS.Delete(maGiaiThuong);
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show(ex.Message, @"Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                for (int i = 0; i < this.gridView.RowCount; i++)
                {
                    DataRow row = this.gridView.GetDataRow(i);

                    try
                    {
                        if (row["MAGIAITHUONG"].ToString() == string.Empty)
                            this.InsertGiaiThuong(row);
                        else
                            this.UpdateGiaiThuong(row);
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show(ex.Message, @"Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                this.DialogResult = DialogResult.OK;

                XtraMessageBox.Show("Cập Nhật Thành Công", @"Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, @"Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Cập nhật giải thưởng
        /// </summary>
        public void UpdateGiaiThuong(DataRow row)
        {
            GiaiThuong giaiThuong = new GiaiThuong(row);

            this.giaiThuongBUS.Update(giaiThuong);
        }
    }
}