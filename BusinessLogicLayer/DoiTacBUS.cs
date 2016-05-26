using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseAcessLayer;
using System.Data;

namespace BusinessLogicLayer
{
    public class DoiTacBUS
    {
        private DoiTacDAL doiTacDAL = null;

        public DoiTacBUS()
        {
            this.doiTacDAL = new DoiTacDAL();
        }

        public DataTable GetAll_CT()
        {
            return this.doiTacDAL.GetAllCT();
        }
    }
}
