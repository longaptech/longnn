using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;
using QLCHS.DataAccess;
using QLCHS.BussinessObject;

namespace QLCHS.BusinessLogic
{
    class EmployeeBUS
    {
        ConnectData connData = new ConnectData();

        //lấy DS nhân viên
        public DataTable getEmployeeList() 
        {
            string sql = "SELECT employeeID, employeeName, DOB, CASE WHEN gender = 0 THEN 'Nam' ELSE N'Nữ' END AS 'gender', address, phone, email, IDcard FROM employee";
            return connData.getDataTable(sql);
        }

        //Thêm mới nhân viên
        public bool addNewEmployee(EmployeeObj nv) 
        {

        }
    }
}
