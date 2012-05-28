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

        //Các hàm xử lý login và phân quyền
        private void disableMenuLogin(bool logged, string roleID) 
        {
            roleID = "R0001";
            //nếu đăng nhập thành công => tắt menu đăng nhập
            ItemDangnhap.Enabled = !logged;
            //nếu đăng nhập thành công => bật menu đăng xuất
            ItemDangxuat.Enabled = logged;
            //mặc định nếu đăng nhập thành công bật hết menu còn lại
            ItemDoimatkhau.Enabled = logged;
            ItemBackup.Enabled = logged;
            ItemRestore.Enabled = logged;
            ItemThoat.Enabled = logged;
            //menu quản lý
            ItemQuanly.Enabled = logged;
            ItemQlyTaikhoan.Enabled = logged;
            ItemQlyNhanvien.Enabled = logged;
            ItemQlySach.Enabled = logged;
            ItemQlyNhacc.Enabled = logged;
            ItemQlyNhaxb.Enabled = logged;
            ItemQlyTacgia.Enabled = logged;
            //hóa đơn
            ItemHoadon.Enabled = logged;
            //tìm kiếm
            ItemTimkiem.Enabled = logged;
            //thống kê báo cáo
            ItemThongkebaocao.Enabled = logged;
            //trợ giúp
            ItemTrogiup.Enabled = logged;

            switch(roleID)
            {
                //Nhóm admin
                case "R0001": break;
                //Nhóm nhân viên
                case "R0002": menuNhanvien(); break;
            }
        }

        //Phương thức hiển thị menu tùy theo nhóm người dùng 
        private void menuNhanvien()
        {
            ItemBackup.Enabled = false;
            ItemRestore.Enabled = false;
            ItemQlyTaikhoan.Enabled = false;
            ItemQlyNhanvien.Enabled = false;
        }

        //E: Các hàm xử lý login và phân quyền

        private void ItemQlyTaikhoan_Click(object sender, EventArgs e)
        {
            frmTaikhoan ftk = new frmTaikhoan();
            ftk.MdiParent = this;
            ftk.Show();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            //tslblUsername.Text = "Hiện tại: [" + "longnn" + "]";
        }
    }
}