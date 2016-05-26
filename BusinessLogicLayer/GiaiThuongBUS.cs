using DatabaseAcessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class GiaiThuongBUS
    {
        private GiaiThuongDAL giaiThuongDAL = null;

        public GiaiThuongBUS()
        {
            this.giaiThuongDAL = new GiaiThuongDAL();
        }

        public string Insert(GiaiThuong giaiThuong)
        {
            string[] parameter = new string[6];

            parameter[0] = giaiThuong.TenGiaiThuong;
            parameter[1] = giaiThuong.MaCoCauGiaiThuong;
            parameter[2] = giaiThuong.TriGia.ToString();
            parameter[3] = giaiThuong.SoLuong.ToString();
            parameter[4] = giaiThuong.SoChuSoTrung.ToString();
            if (giaiThuong.SoLanQuay != 0)
                parameter[5] = giaiThuong.SoLanQuay.ToString();

            return this.giaiThuongDAL.Insert(parameter);
        }

        public void Update(GiaiThuong giaiThuong)
        {
            string[] parameter = new string[7];

            parameter[0] = giaiThuong.MaGiaiThuong;
            parameter[1] = giaiThuong.TenGiaiThuong;
            parameter[2] = giaiThuong.MaCoCauGiaiThuong;
            parameter[3] = giaiThuong.TriGia.ToString();
            parameter[4] = giaiThuong.SoLuong.ToString();
            parameter[5] = giaiThuong.SoChuSoTrung.ToString();
            if (giaiThuong.SoLanQuay != 0)
                parameter[6] = giaiThuong.SoLanQuay.ToString();

            this.giaiThuongDAL.Update(parameter);
        }

        public void Delete(string maGiaiThuong)
        {
            this.giaiThuongDAL.Delete(maGiaiThuong);
        }

        public DataTable GetGiaiThuongByMaCoCauGiaiThuong(string maCoCauGiaiThuong)
        {
            return this.giaiThuongDAL.GetByMaCoCauGiaiThuong(maCoCauGiaiThuong);
        }
    }
}
