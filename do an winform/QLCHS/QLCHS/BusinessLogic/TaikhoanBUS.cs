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
        
        //Lấy danh sách tài khoản
        public DataTable getAccountList() 
        {
            string sql = "select userID,roleID,employeeID,username,password, case when status = 0 then N'Khóa' else N'Không khóa' end as 'status' from tbl_user";
            //string sql = "select userID,roleID,employeeID,username,password,status from tbl_user";
            return connData.getDataTable(sql);
        }

        //Thêm mới một tài khoản
        public bool addNewUser(TaikhoanObj tk) 
        {
            if (checkBeforeSave(tk))
            {
                string sql = string.Format("INSERT INTO tbl_user (userID ,roleID, employeeID, username, password, status)"
                            + "VALUES('{0}','{1}','{2}','{3}','{4}','{5}')",tk.userID ,tk.roleID, tk.employeeID, tk.username, tk.password, tk.status);
                if (connData.ExecuteQuery(sql))
                {
                    MessageBox.Show("Thêm tài khoản thành công", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
            }
            return false;
        }

        //hàm kiểm tra tồn tại mã tài khoản
        public bool checkExistUserID(string userid) 
        {
            if (connData.checkExistValue("tbl_user", "userID", userid))
                return true;
            return false;
        }

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
                string sql = string.Format("UPDATE tbl_user SET roleID = '{0}',employeeID = '{1}',username= '{2}',"
                            + "password = '{3}',status = '{4}' WHERE userID = '{5}'", tk.roleID, tk.employeeID, tk.username, tk.password, tk.status, tk.userID);
                if (connData.ExecuteQuery(sql))
                {
                    MessageBox.Show("Cập nhật tài khoản thành công", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
            }
            return false;
        }

        //Xóa một tài khoản
        public bool deleteUser(string userid)
        {
            string sql = "DELETE FROM tbl_user WHERE userID = '"+userid+"'";
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
        public string nextID() 
        {
            return utilities.nextID(connData.getLastID("tbl_user", "userID"), "U");
        }

    }
}
