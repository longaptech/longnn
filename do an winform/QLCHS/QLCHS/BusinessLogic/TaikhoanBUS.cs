using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;
using QLCHS.DataAccess;
using QLCHS.BussinessObject;

namespace QLCHS.BusinessLogic
{
    class TaikhoanBUS
    {
        ConnectData connData = new ConnectData();

        //Xử lý đăng nhập lấy thông tin tài khoản qua username
        public TaikhoanObj getAccountInfo(string username) 
        {
            string sql = "SELECT * FROM tbl_user WHERE username = '"+username+"'";
            DataTable tbAcc = connData.getDataTable(sql);
            TaikhoanObj tk = new TaikhoanObj();
            if (tbAcc.Rows.Count > 0)
            {
                DataRow rowUser = tbAcc.Rows[0];
                tk.username = rowUser["username"].ToString();
                tk.password = rowUser["password"].ToString();
                tk.roleID = rowUser["roleID"].ToString();
                tk.employeeID = rowUser["employeeID"].ToString();
                tk.status = rowUser["status"].ToString();
            }
            else
            {
                tk.username = "";
                tk.password = "";
                tk.roleID = "";
                tk.employeeID = "";
                tk.status = "";
            }
            return tk;
        }

        //Đổi mật khẩu
        public bool changePassword(string pass) 
        {
            string sql = "UPDATE tbl_user SET password = '"+pass+"' WHERE username = '"+utilities.tk.username+"'";
            if (connData.ExecuteQuery(sql)) 
            {
                return true;
            }
            return false;
        }
        
        //Lấy danh sách tài khoản
        public DataTable getAccountList() 
        {
            string sql = "SELECT username,password,roleID,employeeID, CASE WHEN status = 0 THEN N'Khóa' ELSE N'Không khóa' END AS 'status' FROM tbl_user";
            return connData.getDataTable(sql);
        }

        //Thêm mới một tài khoản
        public bool addNewUser(TaikhoanObj tk) 
        {
            if (checkBeforeSave(tk))
            {
                string sql = string.Format("INSERT INTO tbl_user (username, password, roleID, employeeID, status)"
                            + "VALUES('{0}','{1}','{2}','{3}','{4}')", tk.username, tk.password, tk.roleID, tk.employeeID, tk.status);
                if (connData.ExecuteQuery(sql))
                {
                    MessageBox.Show("Thêm tài khoản thành công", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
            }
            return false;
        }

        //hàm kiểm tra tồn tại mã tài khoản
        //public bool checkExistUserID(string userid) 
        //{
        //    if (connData.checkExistValue("tbl_user", "userID", userid))
        //        return true;
        //    return false;
        //}

        //Hàm kiểm tra tồn tại username
        public bool checkExistUserName(string username) 
        {
            if (connData.checkExistValue("tbl_user", "username", username))
                return true;
            return false;
        }

        //cập nhật một tài khoản
        public bool editUser(TaikhoanObj tk) 
        {
            if (checkBeforeSave(tk))
            {
                string sql = string.Format("UPDATE tbl_user SET password = '{0}', roleID = '{1}',employeeID = '{2}',status = '{3}' WHERE username= '{4}'", tk.password, tk.roleID, tk.employeeID, tk.status, tk.username);
                if (connData.ExecuteQuery(sql))
                {
                    MessageBox.Show("Cập nhật tài khoản thành công", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
            }
            return false;
        }

        //Xóa một tài khoản
        public bool deleteUser(string username)
        {
            string sql = "DELETE FROM tbl_user WHERE username = '" + username + "'";
            if (connData.ExecuteQuery(sql))
            {
                MessageBox.Show("Xóa tài khoản thành công", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            return false;
        }

        //Kiểm tra trước khi lưu
        public bool checkBeforeSave(TaikhoanObj tk) 
        {
            if (tk.username.Equals("")) 
            {
                MessageBox.Show("Tên đăng nhập không hợp lệ!");
                return false;
            }
            if (tk.password.Equals(""))
            {
                MessageBox.Show("Mật khẩu không hợp lệ!");
                return false;
            }
            return true;
        }

        //hàm nextID
        //public string nextID() 
        //{
        //    return utilities.nextID(connData.getLastID("tbl_user", "userID"), "U");
        //}

    }
}
