using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class CoCauGiaiThuong
    {
        public string MaCoCauGiaiThuong { get; set;}
        public string NgayLap { get; set; }

        public CoCauGiaiThuong(string maCoCauGiaiThuong, string ngayLap)
        {
            this.MaCoCauGiaiThuong = maCoCauGiaiThuong;
            this.NgayLap = ngayLap;
        }

        public CoCauGiaiThuong(DataRow row)
        {
            this.MaCoCauGiaiThuong = row["MACOCAUGIAITHUONG"].ToString();
            this.NgayLap = row["NGAYLAP"].ToString();
        }

        public override string ToString()
        {
            return this.MaCoCauGiaiThuong;
        }
    }
}
