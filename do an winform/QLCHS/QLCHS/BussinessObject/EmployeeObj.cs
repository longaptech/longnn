using System;
using System.Collections.Generic;
using System.Text;

namespace QLCHS.BussinessObject
{
    class EmployeeObj
    {
        private string m_employeeID;

        public string employeeID 
        {
            get { return m_employeeID; }
            set { m_employeeID = value; }
        }

        private string m_employeeName;

        public string employeeName 
        {
            get { return m_employeeName; }
            set { m_employeeName = value; }
        }

        private DateTime m_DOB;

        public DateTime DOB 
        {
            get { return m_DOB; }
            set { m_DOB = value; }
        }

        private string m_gender;

        public string gender 
        {
            get { return m_gender; }
            set { m_gender = value; }
        }

        private string m_address;

        public string address 
        {
            get { return m_address; }
            set { m_address = value; }
        }

        private string m_phone;

        public string phone 
        {
            get { return m_phone; }
            set { m_phone = value; }
        }

        private string m_email;

        public string email 
        {
            get { return m_email; }
            set { m_email = value; }
        }

        private int m_IDcard;

        public int IDcard 
        {
            get { return m_IDcard; }
            set { m_IDcard = value; }
        }
    }
}
