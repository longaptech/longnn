using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;
using QLCHS.DataAccess;

namespace QLCHS.BusinessLogic
{
    class EmployeeBUS
    {
        ConnectData connData = new ConnectData();

        //lay danh sach nhan vien
        public DataTable getEmployeeList() 
        {
            string sql = "SELECT * FROM employee";
            return connData.getDataTable(sql);
        }
    }
}
