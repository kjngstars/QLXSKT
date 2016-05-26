using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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

        public string Insert(string parameter)
        {
            if (connection.State != ConnectionState.Open)
                connection.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = this.connection;
            cmd.CommandText = @"COCAUGIAITHUONG_INSERT";

            cmd.Parameters.Add("@p_MACOCAUGIAITHUONG", SqlDbType.VarChar, 15);
            cmd.Parameters["@p_MACOCAUGIAITHUONG"].Direction = ParameterDirection.Output;
            cmd.Parameters.Add("@p_NGAYLAP", parameter);

            cmd.ExecuteNonQuery();

            connection.Close();

            return cmd.Parameters["@p_MACOCAUGIAITHUONG"].Value.ToString();
        }

        public void Update(string[] parameter)
        {
            if (connection.State != ConnectionState.Open)
                connection.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = this.connection;
            cmd.CommandText = @"COCAUGIAITHUONG_UPDATE";

            cmd.Parameters.Add("@p_MACOCAUGIAITHUONG", parameter[0]);
            cmd.Parameters.Add("@p_NGAYLAP", parameter[1]);

            cmd.ExecuteNonQuery();

            connection.Close();
        }

        public void Delete(string maCoCauGiaiThuong)
        {
            if (connection.State != ConnectionState.Open)
                connection.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = this.connection;
            cmd.CommandText = @"COCAUGIAITHUONG_DELETE";

            cmd.Parameters.Add("@p_MACOCAUGIAITHUONG", maCoCauGiaiThuong);

            cmd.ExecuteNonQuery();

            connection.Close();
        }

        public DataRow GetByMaCoCauGiaiThuong(string maCoCauGiaiThuong)
        {
            if (connection.State != ConnectionState.Open)
                connection.Open();

            SqlCommand cmd = new SqlCommand();
            DataTable dataTable = new DataTable();

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = this.connection;
            cmd.CommandText = @"COCAUGIAITHUONG_SEARCHBYMACOCAUGIAITHUONG";

            cmd.Parameters.Add("@p_MACOCAUGIAITHUONG", maCoCauGiaiThuong);

            cmd.ExecuteNonQuery();

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;

            adapter.Fill(dataTable);

            connection.Close();

            if (dataTable.Rows.Count > 0)
                return dataTable.Rows[0];
            else
                return null;
        }
    }
}
