using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreManagementApp
{
    internal class function
    {
        // Connect to database
        protected SqlConnection getConnection()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString= "data source = KABELOLAPTOP\\SQLEXPRESS;" +
                "database = items; " +
                "integrated security = True;";

            return conn;
        }

        // Fetch data
        public DataSet getData(String query)
        {
            SqlConnection conn = getConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = query;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }

        // set data or process data

        public void setData(String query)
        {
            SqlConnection conn = getConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection= conn;
            conn.Open();
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Data Processed Successfully.", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
