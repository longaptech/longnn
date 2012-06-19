using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;
using QLCHS.DataAccess;

namespace QLCHS.BusinessLogic
{
    class RoleBUS
    {
        ConnectData connData = new ConnectData();

        // ham lay danh sach vai tro
        public DataTable getRoleList() 
        {
            string sql = "SELECT roleID, roleName from role";
            return connData.getDataTable(sql);
        }
    }
}
