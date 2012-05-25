using System;
using System.Collections.Generic;
using System.Text;

namespace QLCHS.BussinessObject
{
    class TaikhoanObj
    {
        private string m_userID;

        public string userID 
        {
            get { return m_userID; }
            set { m_userID = value; }
        }

        private string m_roleID;

        public string roleID 
        {
            get { return m_roleID; }
            set { m_roleID = value; }
        }

        private string m_employeeID;

        public string employeeID 
        {
            get { return m_employeeID; }
            set { m_employeeID = value; }
        }

        private string m_username;

        public string username 
        {
            get { return m_username; }
            set { m_username = value; }
        }

        private string m_password;

        public string password 
        {
            get { return m_password; }
            set { m_password = value; }
        }

        private string m_status;

        public string status 
        {
            get { return m_status; }
            set { m_status = value; }
        }
    }
}
