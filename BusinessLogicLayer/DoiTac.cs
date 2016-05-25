using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class DoiTac
    {
        public string MaDoiTac { get; set; }
        public string TenDoiTac { get; set; }

        public DoiTac(string MaDoiTac, string TenDoiTac)
        {
            this.MaDoiTac = MaDoiTac;
            this.TenDoiTac = TenDoiTac;
        }

        public DoiTac(DataRow row)
        {
            this.MaDoiTac = row[0].ToString();
            this.TenDoiTac = row[1].ToString();
        }

        public override string ToString()
        {
            return this.TenDoiTac;
        }
    }
}
