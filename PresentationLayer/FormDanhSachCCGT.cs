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
    }
}