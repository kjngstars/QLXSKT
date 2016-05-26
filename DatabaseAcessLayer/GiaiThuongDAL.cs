using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseAcessLayer
{
    public class GiaiThuongDAL : DBConnection
    {
        public GiaiThuongDAL() : base() { }

        public string Insert(string[] parameter)
        {
            if (connection.State != ConnectionState.Open)
                connection.Open();

            SqlCommand cmd = new SqlCommand();

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = this.connection;
            cmd.CommandText = @"GIAITHUONG_INSERT";

            cmd.Parameters.Add("@p_MAGIAITHUONG", SqlDbType.VarChar, 15);
            cmd.Parameters["@p_MAGIAITHUONG"].Direction = ParameterDirection.Output;
            cmd.Parameters.Add("@p_TENGIAITHUONG", parameter[0]);
            cmd.Parameters.Add("@p_MACOCAUGIAITHUONG", parameter[1]);
            cmd.Parameters.Add("@p_TRIGIA", parameter[2]);
            cmd.Parameters.Add("@p_SOLUONG", parameter[3]);
            cmd.Parameters.Add("@p_SOCHUSOTRUNG", parameter[4]);
            cmd.Parameters.Add("@p_SOLANQUAY", parameter[5]);

            cmd.ExecuteNonQuery();

            connection.Close();

            return cmd.Parameters["@p_MAGIAITHUONG"].Value.ToString();
        }

        public void Update(string[] parameter)
        {
            if (connection.State != ConnectionState.Open)
                connection.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = this.connection;
            cmd.CommandText = @"GIAITHUONG_UPDATE";

            cmd.Parameters.Add("@p_MAGIAITHUONG", parameter[0]);
            cmd.Parameters.Add("@p_TENGIAITHUONG", parameter[1]);
            cmd.Parameters.Add("@p_MACOCAUGIAITHUONG", parameter[2]);
            cmd.Parameters.Add("@p_TRIGIA", parameter[3]);
            cmd.Parameters.Add("@p_SOLUONG", parameter[4]);
            cmd.Parameters.Add("@p_SOCHUSOTRUNG", parameter[5]);
            cmd.Parameters.Add("@p_SOLANQUAY", parameter[6]);

            cmd.ExecuteNonQuery();

            connection.Close();
        }

        public void Delete(string maGiaiThuong)
        {
            if (connection.State != ConnectionState.Open)
                connection.Open();

            SqlCommand cmd = new SqlCommand();
            DataTable dataTable = new DataTable();

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = this.connection;
            cmd.CommandText = @"GIAITHUONG_DELETE";

            cmd.Parameters.Add("@p_MAGIAITHUONG", maGiaiThuong);

            cmd.ExecuteNonQuery();

            connection.Close();
        }

        public DataTable GetByMaCoCauGiaiThuong(string maCoCauGiaiThuong)
        {
            if (connection.State != ConnectionState.Open)
                connection.Open();

            SqlCommand cmd = new SqlCommand();
            DataTable dataTable = new DataTable();

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = this.connection;
            cmd.CommandText = @"GIAITHUONG_SEARCHBYMACOCAUGIAITHUONG";

            cmd.Parameters.Add("@p_MACOCAUGIAITHUONG", maCoCauGiaiThuong);

            cmd.ExecuteNonQuery();

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;

            adapter.Fill(dataTable);

            connection.Close();

            return dataTable;
        }
    }
}
