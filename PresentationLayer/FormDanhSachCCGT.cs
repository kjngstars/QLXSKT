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
using PresentationLayer.Dialogs;

namespace PresentationLayer
{
    public partial class FormDanhSachCCGT : DevExpress.XtraEditors.XtraForm
    {
        private CoCauGiaiThuongBUS coCauGiaiThuongBUS = null;

        public FormDanhSachCCGT()
        {
            InitializeComponent();
        }

        private void FormDanhSachCCGT_Load(object sender, EventArgs e)
        {
            this.coCauGiaiThuongBUS=new CoCauGiaiThuongBUS();
        }

        private void FormDanhSachCCGT_Shown(object sender, EventArgs e)
        {
            this.gridControl.DataSource = this.coCauGiaiThuongBUS.GetAll();
        }

        private void toolStripMenuItem_Them_Click(object sender, EventArgs e)
        {
            FormEditCCGT form = new FormEditCCGT();
            form.ShowDialog();
        }

        private void toolStripMenuItem_CapNhat_Click(object sender, EventArgs e)
        {
            int[] selectedRows = this.gridView.GetSelectedRows();

            if (selectedRows.Length > 0)
            {
                string maCoCauGiaiThuong = this.gridView.GetDataRow(selectedRows[0])[0].ToString();

                FormEditCCGT form = new FormEditCCGT(maCoCauGiaiThuong);
                if (form.DialogResult != DialogResult.Abort)
                {
                    form.ShowDialog();
                    this.gridControl.DataSource = this.coCauGiaiThuongBUS.GetAll();
                }
            }
        }

        private void gridControl_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int[] selectedRows = this.gridView.GetSelectedRows();

            if (selectedRows.Length > 0)
            {
                string maCoCauGiaiThuong = this.gridView.GetDataRow(selectedRows[0])[0].ToString();

                FormEditCCGT form = new FormEditCCGT(maCoCauGiaiThuong);
                if (form.DialogResult != DialogResult.Abort)
                {
                    form.ShowDialog();
                    this.gridControl.DataSource = this.coCauGiaiThuongBUS.GetAll();
                }
            }
        }
    }
}