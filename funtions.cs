using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coffe_Shop_Management
{
    internal class funtions
    {
        
        protected SqlConnection getConnection()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;database=coffeshop;Integrated Security=True;Connect Timeout=30");
            return conn;
        }

        public DataSet getData(string query) //Get data from database
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
        public void setData(string query,string message)
        {
            try
            {
                SqlConnection conn = getConnection();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                conn.Open();
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("' "+message+" '","Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
