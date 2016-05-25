using DatabaseAcessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class LoaiVeBUS
    {
        private LoaiVeDAL loaiVeDAL = null;

        public LoaiVeBUS()
        {
            this.loaiVeDAL = new LoaiVeDAL();
        }

        public DataTable GetAll()
        {
            return this.loaiVeDAL.GetAll();
        }


        public void Insert(LoaiVe loaiVe)
        {
            string[] parameter = new string[5];

            parameter[0] = loaiVe.TenLoaiVe;
            parameter[1] = loaiVe.NgayLap;
            parameter[2] = loaiVe.MenhGia.ToString();
            parameter[3] = loaiVe.MaDoiTac;
            parameter[4] = loaiVe.MaCoCauGiaiThuong;

            this.loaiVeDAL.Insert(parameter);
        }

        public LoaiVe GetLoaiVe_ByMaLoaiVe(string maLoaiVe)
        {
            DataRow dataRow = this.loaiVeDAL.GetLoaiVe_ByMaLoaiVe(maLoaiVe);

            return new LoaiVe(
                dataRow["MALOAIVE"].ToString(),
                dataRow["TENLOAIVE"].ToString(),
                dataRow["NGAYLAP"].ToString(),
                decimal.Parse(dataRow["MENHGIA"].ToString()),
                dataRow["MADOITAC"].ToString(),
                dataRow["MACOCAUGIAITHUONG"].ToString());
        }
    }
}
