using System;
using System.Collections.Generic;
using System.Text;

namespace QLCHS.BussinessObject
{
    class RoleObj
    {
        private string m_roleID;

        public string roleID
        {
            get { return m_roleID; }
            set { m_roleID = value; }
        }

        private string m_roleName;

        public string roleName
        {
            get { return m_roleName; }
            set { m_roleName = value; }
        }

        private string m_description;

        public string description 
        {
            get { return m_description; }
            set { m_description = value; }
        }
    }
}
