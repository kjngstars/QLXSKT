using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseAcessLayer
{
    public class LoaiVeDAL : DBConnection
    {
        public LoaiVeDAL() : base() { }

        public DataTable GetAll()
        {
            string query = @"SELECT MALOAIVE, TENLOAIVE, NGAYLAP, MENHGIA, TENDOITAC, MACOCAUGIAITHUONG
                            FROM LOAIVE AS loaive
                            LEFT JOIN DOITAC AS doitac
                            ON loaive.MADOITAC=doitac.MADOITAC";

            return this.getTable(query, string.Empty);
        }

        public void Insert(string[] parameter)
        {
            if (connection.State != ConnectionState.Open)
                connection.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = this.connection;
            cmd.CommandText = "LOAIVE_INSERT";

            cmd.Parameters.Add("@p_TENLOAIVE", parameter[0]);
            cmd.Parameters.Add("@p_NGAYLAP", parameter[1]);
            cmd.Parameters.Add("@p_MENHGIA", parameter[2]);
            cmd.Parameters.Add("@p_MADOITAC", parameter[3]);
            cmd.Parameters.Add("@p_MACOCAUGIAITHUONG", parameter[4]);

            cmd.ExecuteNonQuery();

            connection.Close();
        }
    }
}
