using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QLCHS
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void menuItemQlyTaikhoan_Click(object sender, EventArgs e)
        {
            frmTaikhoan ftk = new frmTaikhoan();
            ftk.MdiParent = this;
            ftk.Show();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            tslblUsername.Text = "Hiện tại: [" + "longnn" + "]";
        }
    }
}