using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class LoaiVe
    {
        public string MaLoaiVe { get; set; }
        public string TenLoaiVe { get; set; }
        public string NgayLap { get; set; }
        public decimal MenhGia { get; set; }
        public string MaDoiTac { get; set; }
        public string MaCoCauGiaiThuong { get; set; }

        public LoaiVe(string MaLoaiVe,
            string TenLoaiVe,
            string NgayLap,
            decimal MenhGia,
            string MaDoiTac,
            string MaCoCauGiaiThuong)
        {
            this.MaLoaiVe = MaLoaiVe;
            this.TenLoaiVe = TenLoaiVe;
            this.NgayLap = NgayLap;
            this.MenhGia = MenhGia;
            this.MaDoiTac = MaDoiTac;
            this.MaCoCauGiaiThuong = MaCoCauGiaiThuong;
        }

        public LoaiVe(DataRow row)
        {
            this.MaLoaiVe = row["MALOAIVE"].ToString();
            this.TenLoaiVe = row["TENLOAIVE"].ToString();
            this.NgayLap = row["NGAYLAP"].ToString();
            try
            {
                this.MenhGia = decimal.Parse(row["MENHGIA"].ToString());
            }
            catch (Exception ex)
            {
                this.MenhGia = 0;
            }
            this.MaDoiTac = row["MADOITAC"].ToString();
            this.MaCoCauGiaiThuong = row["MACOCAUGIAITHUONG"].ToString();
        }
    }
}
