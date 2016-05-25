using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseAcessLayer
{
    public class DoiTacDAL : DBConnection
    {
        public DoiTacDAL() : base() { }

        public DataTable GetAll_CT()
        {
            string query = @"SELECT * FROM DOITAC
                            WHERE MADOITAC LIKE 'CT%'";

            return this.getTable(query, string.Empty);
        }
    }
}
