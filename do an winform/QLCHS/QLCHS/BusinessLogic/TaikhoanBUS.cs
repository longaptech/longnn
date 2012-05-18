using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;
using QLCHS.DataAccess;

namespace QLCHS.BusinessLogic
{
    class TaikhoanBUS
    {
        ConnectData connData = new ConnectData();
        
        //ham lay danh sach tai khoan
        public DataTable getAccountList() 
        {
            string sql = "select * from tbl_user";
            return connData.getDataTable(sql);
        }
    }
}
