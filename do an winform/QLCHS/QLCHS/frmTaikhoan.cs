using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using QLCHS.BusinessLogic;

namespace QLCHS
{
    public partial class frmTaikhoan : Form
    {
        private TaikhoanBUS tkBUS = new TaikhoanBUS();
        public frmTaikhoan()
        {
            InitializeComponent();
        }

        private void frmTaikhoan_Load(object sender, EventArgs e)
        {
            dg_taikhoan.DataSource = tkBUS.getAccountList();
        }
    }
}