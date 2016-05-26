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
            try
            {
                this.TriGia = decimal.Parse(row["TRIGIA"].ToString());
            }
            catch (Exception ex)
            {
                this.TriGia = 0;
            }
            try
            {
                this.SoLuong = int.Parse(row["SOLUONG"].ToString());
            }
            catch (Exception ex)
            {
                this.SoLuong = 0;
            }
            try
            {
                this.SoChuSoTrung = int.Parse(row["SOCHUSOTRUNG"].ToString());
            }
            catch (Exception ex)
            {
                this.SoChuSoTrung = 0;
            }
            try
            {
                this.SoLanQuay = int.Parse(row["SOLANQUAY"].ToString());
            }
            catch (Exception ex)
            {
                this.SoLanQuay = 0;
            }
        }
    }
}
