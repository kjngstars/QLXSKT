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
                            ON loaive.MADOITAC = doitac.MADOITAC";

            return this.getTable(query, string.Empty);
        }

        public string Insert(string[] parameter)
        {
            if (connection.State != ConnectionState.Open)
                connection.Open();

            SqlCommand cmd = new SqlCommand();

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = this.connection;
            cmd.CommandText = @"LOAIVE_INSERT";

            cmd.Parameters.Add("@p_MALOAIVE", SqlDbType.VarChar, 15);
            cmd.Parameters["@p_MALOAIVE"].Direction= ParameterDirection.Output;
            cmd.Parameters.Add("@p_TENLOAIVE", parameter[0]);
            cmd.Parameters.Add("@p_NGAYLAP", parameter[1]);
            cmd.Parameters.Add("@p_MENHGIA", parameter[2]);
            cmd.Parameters.Add("@p_MADOITAC", parameter[3]);
            cmd.Parameters.Add("@p_MACOCAUGIAITHUONG", parameter[4]);

            cmd.ExecuteNonQuery();

            connection.Close();

            return cmd.Parameters["@p_MALOAIVE"].Value.ToString();
        }

        public void Update(string[] parameter)
        {
            if (connection.State != ConnectionState.Open)
                connection.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = this.connection;
            cmd.CommandText = @"LOAIVE_UPDATE";

            cmd.Parameters.Add("@p_MALOAIVE", parameter[0]);
            cmd.Parameters.Add("@p_TENLOAIVE", parameter[1]);
            cmd.Parameters.Add("@p_NGAYLAP", parameter[2]);
            cmd.Parameters.Add("@p_MENHGIA", parameter[3]);
            cmd.Parameters.Add("@p_MADOITAC", parameter[4]);
            cmd.Parameters.Add("@p_MACOCAUGIAITHUONG", parameter[5]);

            cmd.ExecuteNonQuery();

            connection.Close();
        }

        public void Delete(string maLoaiVe)
        {
            if (connection.State != ConnectionState.Open)
                connection.Open();

            SqlCommand cmd = new SqlCommand();
            DataTable dataTable = new DataTable();

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = this.connection;
            cmd.CommandText = @"LOAIVE_DELETE";

            cmd.Parameters.Add("@p_MALOAIVE", maLoaiVe);

            cmd.ExecuteNonQuery();

            connection.Close();
        }

        public DataRow GetLoaiVeByMaLoaiVe(string maLoaiVe)
        {
            if (connection.State != ConnectionState.Open)
                connection.Open();

            SqlCommand cmd = new SqlCommand();
            DataTable dataTable = new DataTable();

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = this.connection;
            cmd.CommandText = @"LOAIVE_SEARCHBYMALOAIVE";

            cmd.Parameters.Add("@p_MALOAIVE", maLoaiVe);

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
