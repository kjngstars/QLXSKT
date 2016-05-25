using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseAcessLayer;
using System.Data;

namespace BusinessLogicLayer
{
    public class CoCauGiaiThuongBUS
    {
        private CoCauGiaiThuongDAL coCauGiaiThuongDAL = null;

        public CoCauGiaiThuongBUS()
        {
            this.coCauGiaiThuongDAL = new CoCauGiaiThuongDAL();
        }

        public DataTable GetAll()
        {
            return this.coCauGiaiThuongDAL.GetAll();
        }
    }
}
