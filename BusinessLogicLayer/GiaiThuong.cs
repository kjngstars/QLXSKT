using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class GiaiThuong
    {
        public string MaGiaiThuong { get; set; }
        public string TenGiaiThuong { get; set; }
        public string MaCoCauGiaiThuong { get; set; }
        public decimal TriGia { get; set; }
        public int SoLuong { get; set; }
        public int SoChuSoTrung { get; set; }
        public int SoLanQuay { get; set; }

        public GiaiThuong(string maGiaiThuong,
            string tenGiaiThuong,
            string maCoCauGiaiThuong,
            decimal triGia,
            int soLuong,
            int soChuSoTrung,
            int soLanQuay)
        {
            this.MaGiaiThuong = maGiaiThuong;
            this.TenGiaiThuong = tenGiaiThuong;
            this.MaCoCauGiaiThuong = maCoCauGiaiThuong;
            this.TriGia = triGia;
            this.SoLuong = soLuong;
            this.SoChuSoTrung = soChuSoTrung;
            this.SoLanQuay = soLanQuay;
        }

        public GiaiThuong(DataRow row)
        {
            this.MaGiaiThuong = row["MAGIAITHUONG"].ToString();
            this.TenGiaiThuong = row["TENGIAITHUONG"].ToString();
            this.MaCoCauGiaiThuong = row["MACOCAUGIAITHUONG"].ToString();
            this.TriGia = decimal.Parse(row["TRIGIA"].ToString());
            this.SoLuong = int.Parse(row["SOLUONG"].ToString());
            this.SoChuSoTrung = int.Parse(row["SOCHUSOTRUNG"].ToString());
            this.SoLanQuay = int.Parse(row["SOLANQUAY"].ToString());
        }
    }
}
