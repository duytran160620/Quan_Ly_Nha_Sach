using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class DataProvider
    {
        private SqlConnection connection = new SqlConnection(@"Data Source=Q6HWDZHRGD2LJGV\SQLEXPRESS;Initial Catalog=TESTINGDB;Integrated Security=True");
        // singleton
        private static DataProvider instance;
        private DataProvider()
        {

        }
        public static DataProvider Instance
        {
            get
            {
                if (instance == null)
                    instance = new DataProvider();
                return DataProvider.instance;
            }
            private set
            {
                DataProvider.instance = value;
            }
        }

        public bool setFormatDate()
        {
            string query = "SET DATEFORMAT dmy";
            return ExecuteNonQuery(query);
        }
        private void openConnection()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
        }
        private void closeConnection()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }
        public DataTable ExecuteQuery(string query, object[] parameters = null)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter adapter = new SqlDataAdapter();
            cmd.Connection = connection;
            cmd.CommandText = query;
            cmd.CommandType = CommandType.Text;
            if (parameters != null)
            {
                string[] listParam = query.Replace(",", "").Replace("(", "").Replace(")", "").Split(' ');
                int i = 0;
                foreach (var item in listParam)
                {
                    if (item.Contains('@'))
                    {
                        cmd.Parameters.AddWithValue(item, parameters[i]);
                        i++;
                    }
                }
            }
            openConnection();
            adapter.SelectCommand = cmd;
            adapter.Fill(dt);
            closeConnection();
            return dt;
        }
        public bool ExecuteNonQuery(string query, object[] parameters = null)
        {
            bool statusCode;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = query;
                cmd.CommandType = CommandType.Text;
                if (parameters != null)
                {
                    string[] listParam = query.Replace(",", "").Replace("(", "").Replace(")", "").Split(' ');
                    
                    int i = 0;
                    foreach (var item in listParam)
                    {
                        if (item.Contains('@') == true)
                        {
                            cmd.Parameters.Add(new SqlParameter(item, parameters[i]));
                            i++;
                        }
                    }
                }
                openConnection();
                cmd.ExecuteNonQuery();
                statusCode = true;
            }
            catch
            {
                statusCode = false;
            }
            finally
            {
                closeConnection();
            }
            return statusCode;
        }
        public int ExecuteScalar(string query, object[] parameters = null)
        {
            int result;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandText = query;
            cmd.CommandType = CommandType.Text;
            if (parameters != null)
            {
                string[] listParam = query.Replace(",", "").Replace("(", "").Replace(")", "").Split(' ');
                int i = 0;
                foreach (var item in listParam)
                {
                    if (item.Contains('@') == true)
                    {
                        cmd.Parameters.Add(new SqlParameter(item, parameters[i]));
                        i++;
                    }
                }
            }
            openConnection();
            string resultString = cmd.ExecuteScalar().ToString();
            result = ((resultString != string.Empty) ? int.Parse(resultString) : 0);
            closeConnection();
            return result;
        }

        
        
    }

}
