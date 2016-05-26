using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using PresentationLayer.Dialogs;

namespace PresentationLayer
{
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public MainForm()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Kiểm tra tab tồn tại chưa
        /// </summary>
        public bool CheckExist(XtraForm form)
        {
            foreach(XtraForm child in this.MdiChildren)
            {
                if (form.Name == child.Name)
                {
                    child.Activate();
                    return true;
                }
            }

            return false;
        }

        
        /// <summary>
        /// Thêm tab Danh sách loại vé
        /// </summary>
        private void barButtonItem_DanhSachLoaiVe_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormDanhSachLoaiVe form = new FormDanhSachLoaiVe();

            if (!this.CheckExist(form))
            {
                form.MdiParent = this;
                form.Show();
            }
        }

        /// <summary>
        /// Mở form thêm loại vé
        /// </summary>
        private void barButtonItem_ThemLoaiVe_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormEditLoaiVe form = new FormEditLoaiVe();
            form.ShowDialog();
        }

        /// <summary>
        /// Thêm tab Danh sách cơ cấu giải thưởng
        /// </summary>
        private void barButtonItem_DanhSachCCGT_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormDanhSachCCGT form = new FormDanhSachCCGT();

            if (!this.CheckExist(form))
            {
                form.MdiParent = this;
                form.Show();
            }
        }

        /// <summary>
        /// Mở form thêm CCGT
        /// </summary>
        private void barButtonItem_ThemCCGT_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormEditCCGT form = new FormEditCCGT();
            form.ShowDialog();
        }
    }
}