using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseAcessLayer
{
    public class CoCauGiaiThuongDAL : DBConnection
    {
        public CoCauGiaiThuongDAL() : base() { }

        public DataTable GetAll()
        {
            string query = @"SELECT * FROM COCAUGIAITHUONG";

            return this.getTable(query, string.Empty);
        }
    }
}
