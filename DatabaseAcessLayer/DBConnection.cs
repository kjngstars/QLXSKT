using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseAcessLayer
{
    public class DBConnection
    {
        protected SqlConnection connection;

        public DBConnection()
        {
            try
            {
                connection = new SqlConnection();
                connection.ConnectionString = //@"Data Source=.\;Initial Catalog=QLSTK;Integrated Security=True";
                @"Data Source=.\;Initial Catalog=QUANLYXOSO;Integrated Security=True";
                //@"Data Source=KIUKIU;Initial Catalog=QLSTK;Integrated Security=True"
            }
            catch (Exception)
            { 
            }
        }

        public object getSingleValueFromColumn(string command, params string[] str)
        {

            //dung ham nay de lay 1 gia tri bat ki tu mot cot cua mot bang
            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.Connection = this.connection;

            cmd.CommandText = string.Format(command, str);

            object returnValue = cmd.ExecuteScalar();
            connection.Close();

            return returnValue;
        }

        public SqlDataReader getRowsFromTable(string command, params string[] str)
        {

            //dung ham nay de lay ve mot reader de doc tung row cua mot table truy van duoc
            if (connection.State != ConnectionState.Open)
            {
            }

            SqlCommand cmd = new SqlCommand();

            SqlDataReader reader;

            cmd.CommandText = string.Format(command, str);
            cmd.CommandType = CommandType.Text;
            cmd.Connection = this.connection;

            reader = cmd.ExecuteReader();

            connection.Close();

            return reader;
        }

        public bool ExcuteNonQueryCommand(string command, params string[] str)
        {
            //dung ham nay de thuc hien cau lenh sql ko co dang truy van nhu update,insert,delete...
            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.Connection = this.connection;
            cmd.CommandText = string.Format(command, str);

            int n = cmd.ExecuteNonQuery();

            connection.Close();

            if (n == 1)
            {
                return true;
            }

            return false;
        }

        public DataTable getTable(string command, params string[] str)
        {
            //dung ham nay de lay ve 1 bang sau khi thuc hien cau truy van
            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }

            DataTable dt = new DataTable();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.Connection = this.connection;

            cmd.CommandText = string.Format(command, str);

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;

            adapter.Fill(dt);

            connection.Close();

            return dt;
        }
    }
}
