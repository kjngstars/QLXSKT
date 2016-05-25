﻿using System;
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
using PresentationLayer.Dialog;

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

            this.gridView.Columns[0].Caption = "Mã Loại Vé";
            this.gridView.Columns[1].Caption = "Tên Loại Vé";
            this.gridView.Columns[2].Caption = "Ngày Lập";
            this.gridView.Columns[3].Caption = "Mệnh Giá";
            this.gridView.Columns[4].Caption = "Công Ty Phát Hành";
            this.gridView.Columns[5].Caption = "Mã Cơ Cấu Giải Thưởng";
        }

        private void FormDanhSachLoaiVe_Shown(object sender, EventArgs e)
        {
            this.gridControl.DataSource = this.loaiVeBUS.GetAll();
        }

        private void toolStripMenuItem_Them_Click(object sender, EventArgs e)
        {
            FormEditLoaiVe form = new FormEditLoaiVe();
            form.ShowDialog(this);
            this.gridControl.DataSource = this.loaiVeBUS.GetAll();
        }

        private void gridView_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            FormEditLoaiVe form = new FormEditLoaiVe();
            form.ShowDialog(this);
            this.gridControl.DataSource = this.loaiVeBUS.GetAll();
        }
    }
}