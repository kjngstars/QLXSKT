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
using PresentationLayer.Dialog;

namespace PresentationLayer
{
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public bool CheckExist(XtraForm form)
        {
            foreach(XtraForm child in this.xtraTabbedMdiManager.FloatForms)
            {
                if (form.Name == child.Name)
                {
                    child.Activate();
                    return true;
                }
            }

            return false;
        }

        //Danh Sach Loai Ve
        private void barButtonItem_DanhSachLoaiVe_ItemClick(object sender, ItemClickEventArgs e)
        {
            XtraForm form = new FormDanhSachLoaiVe();

            if (!this.CheckExist(form))
            {
                form.MdiParent = this;
                form.Show();
            }
        }

        private void barButtonItem_ThemLoaiVe_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormEditLoaiVe form = new FormEditLoaiVe();
            form.ShowDialog(this);
        }
    }
}