using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;

namespace QLCHS.DataAccess
{
    class ConnectData
    {
        private SqlConnection conn;
        private SqlDataAdapter da;
        private DataTable dataTable;

        public ConnectData() 
        {
            connect();
        }

        // ket noi csdl
        public void connect() 
        {
            string strconn = System.Configuration.ConfigurationManager.AppSettings.Get("str");
            try 
            {

                conn = new SqlConnection(strconn);
                conn.Open();

            }catch(Exception ex)
            {

                MessageBox.Show("lỗi"+ex.Message);

            }
        }

        //ham lay du lieu DataTable tu cau truy van truyen vao
        public DataTable getDataTable(string sql)
        {
            da = new SqlDataAdapter(sql, conn);
            dataTable = new DataTable();
            da.Fill(dataTable);
            return dataTable;
        }

        //ham thuc hien cau lenh INSERT,UPDATE,DELETE
        public bool ExecuteQuery(string sql) 
        {
            int numRecord = 0;
            try
            {
                SqlCommand cmd = new SqlCommand(sql);
                numRecord = cmd.ExecuteNonQuery();
            }
            catch (Exception ex) 
            {
                MessageBox.Show("lỗi"+ex.Message);
            }
            if (numRecord > 0)
            {
                return true;
            }
            else 
            {
                return false;
            }
        }

    }
}
