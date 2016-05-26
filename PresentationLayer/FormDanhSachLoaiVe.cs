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
    public partial class FormDanhSachLoaiVe : DevExpress.XtraEditors.XtraForm
    {
        private LoaiVeBUS loaiVeBUS = null;

        public FormDanhSachLoaiVe()
        {
            InitializeComponent();
        }

        private void FormDanhSachLoaiVe_Load(object sender, EventArgs e)
        {
            this.loaiVeBUS = new LoaiVeBUS();
        }

        private void FormDanhSachLoaiVe_Shown(object sender, EventArgs e)
        {
            this.gridControl.DataSource = this.loaiVeBUS.GetAll();
        }

        private void toolStripMenuItem_Them_Click(object sender, EventArgs e)
        {
            FormEditLoaiVe form = new FormEditLoaiVe();
            form.ShowDialog();
            this.gridControl.DataSource = this.loaiVeBUS.GetAll();
        }


        private void toolStripMenuItem_CapNhat_Click(object sender, EventArgs e)
        {
            if (this.gridView.FocusedRowHandle >= 0)
            {
                string maLoaiVe = this.gridView.GetDataRow(this.gridView.FocusedRowHandle)["MALOAIVE"].ToString();

                FormEditLoaiVe form = new FormEditLoaiVe(maLoaiVe);
                if (form.DialogResult != DialogResult.Abort)
                {
                    form.ShowDialog();
                    this.gridControl.DataSource = this.loaiVeBUS.GetAll();
                }
            }
        }

        private void gridView_DoubleClick(object sender, EventArgs e)
        {
            if (this.gridView.FocusedRowHandle >=0)
            {
                string maLoaiVe = this.gridView.GetDataRow(this.gridView.FocusedRowHandle)["MALOAIVE"].ToString();

                FormEditLoaiVe form = new FormEditLoaiVe(maLoaiVe);
                if (form.DialogResult != DialogResult.Abort)
                {
                    form.ShowDialog();
                    this.gridControl.DataSource = this.loaiVeBUS.GetAll();
                }
            }
        }

        private void toolStripMenuItem_Xoa_Click(object sender, EventArgs e)
        {
            if (this.gridView.FocusedRowHandle >= 0)
            {
                string maLoaiVe = this.gridView.GetDataRow(this.gridView.FocusedRowHandle)["MALOAIVE"].ToString();

                try
                {
                    this.loaiVeBUS.Delete(maLoaiVe);

                    this.gridControl.DataSource = this.loaiVeBUS.GetAll();

                    XtraMessageBox.Show(@"Xóa Thành Công", @"Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch(Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, @"Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}