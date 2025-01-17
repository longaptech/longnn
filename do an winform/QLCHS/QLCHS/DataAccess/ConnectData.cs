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
            //string strconn = System.Configuration.ConfigurationManager.AppSettings.Get("str");
            string strconn = utilities.getConnect();
            try 
            {

                conn = new SqlConnection(strconn);
                conn.Open();
                //conn.Close();

            }
            catch
            {

                MessageBox.Show("Lỗi:không kết nối được database.nhấn OK để thiết lập kết nối!");
                utilities.OpenConnDialog();
                strconn = utilities.getConnect();
                conn = new SqlConnection(strconn);
                conn.Open();
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
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                numRecord = cmd.ExecuteNonQuery();
                if (conn.State == ConnectionState.Open)
                    conn.Close();
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

        //hàm lấy mã cuối cùng
        public string getLastID(string tableName, string fieldName) 
        {
            string sql = "SELECT TOP 1 "+fieldName+" FROM "+tableName+" ORDER BY "+fieldName+" DESC";
            getDataTable(sql);
            return dataTable.Rows[0][fieldName].ToString();
        }

        //Hàm kiểm tra dữ liệu đã tồn tại trong bảng
        public bool checkExistValue(string tableName, string filedName, string value) 
        {
            string sql = "SELECT * FROM "+tableName+" WHERE "+filedName+" = '"+value+"'";
            getDataTable(sql);
            //đếm số dòng trả về nếu lớn hơn 0 thì tồn tại giá trị
            if (dataTable.Rows.Count > 0)
                return true;
            return false;
        }

    }
}
