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

        public string Insert(CoCauGiaiThuong coCauGiaiThuong)
        {
            return this.coCauGiaiThuongDAL.Insert(coCauGiaiThuong.NgayLap);
        }

        public void Update(CoCauGiaiThuong coCauGiaiThuong)
        {
            string[] parameter = new string[2];

            parameter[0] = coCauGiaiThuong.MaCoCauGiaiThuong;
            parameter[1] = coCauGiaiThuong.NgayLap;

            this.coCauGiaiThuongDAL.Update(parameter);
        }

        public void Delete(string maCoCauGiaiThuong)
        {
            this.coCauGiaiThuongDAL.Delete(maCoCauGiaiThuong);
        }

        public CoCauGiaiThuong GetCoCauGiaiThuongByMaCoCauGiaiThuong(string maCoCauGiaiThuong)
        {
            DataRow dataRow = this.coCauGiaiThuongDAL.GetByMaCoCauGiaiThuong(maCoCauGiaiThuong);

            return new CoCauGiaiThuong(dataRow);
        }
    }
}
