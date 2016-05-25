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

        public CoCauGiaiThuong(DataRow row)
        {
            this.MaCoCauGiaiThuong = row[0].ToString();
        }

        public override string ToString()
        {
            return this.MaCoCauGiaiThuong;
        }
    }
}
