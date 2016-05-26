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


        public string Insert(LoaiVe loaiVe)
        {
            string[] parameter = new string[5];

            parameter[0] = loaiVe.TenLoaiVe;
            parameter[1] = loaiVe.NgayLap;
            parameter[2] = loaiVe.MenhGia.ToString();
            parameter[3] = loaiVe.MaDoiTac;
            parameter[4] = loaiVe.MaCoCauGiaiThuong;

            return this.loaiVeDAL.Insert(parameter);
        }

        public void Update(LoaiVe loaiVe)
        {
            string[] parameter = new string[6];

            parameter[0] = loaiVe.MaLoaiVe;
            parameter[1] = loaiVe.TenLoaiVe;
            parameter[2] = loaiVe.NgayLap;
            parameter[3] = loaiVe.MenhGia.ToString();
            parameter[4] = loaiVe.MaDoiTac;
            parameter[5] = loaiVe.MaCoCauGiaiThuong;

            this.loaiVeDAL.Update(parameter);
        }

        public void Delete(string maLoaiVe)
        {
            this.loaiVeDAL.Delete(maLoaiVe);
        }

        public LoaiVe GetLoaiVeByMaLoaiVe(string maLoaiVe)
        {
            DataRow dataRow = this.loaiVeDAL.GetLoaiVeByMaLoaiVe(maLoaiVe);

            return new LoaiVe(dataRow);
        }
    }
}
