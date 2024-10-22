using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using QLCHS.BusinessLogic;
using QLCHS.BussinessObject;

namespace QLCHS
{
    public partial class frmMain : Form
    {
        private TaikhoanBUS tkBUS = new TaikhoanBUS();

        //properties
        frmTaikhoan ftk = null;
        frmDangnhap fdn = null;
        frmDoimatkhau fdmk = null;

        public frmMain()
        {
            InitializeComponent();
        }

        //Các hàm xử lý login và phân quyền
        private void disableMenuLogin(bool logged, string roleID) 
        {
            //nếu đăng nhập thành công => tắt menu đăng nhập
            MNItemDangnhap.Enabled = !logged;
            //nếu đăng nhập thành công => bật menu đăng xuất
            MNItemDangxuat.Enabled = logged;
            //mặc định nếu đăng nhập thành công bật hết menu còn lại
            MNItemDoimatkhau.Enabled = logged;
            MNItemBackup.Visible = logged;
            MNItemRestore.Visible = logged;
            MNItemThoat.Enabled = !logged;
            //menu quản lý
            MNItemQuanly.Enabled = logged;
            MNItemQlyTaikhoan.Visible = logged;
            MNItemQlyNhanvien.Visible = logged;
            MNItemQlySach.Enabled = logged;
            MNItemQlyNhacc.Enabled = logged;
            MNItemQlyNhaxb.Enabled = logged;
            MNItemQlyTacgia.Enabled = logged;
            //hóa đơn
            MNItemHoadon.Enabled = logged;
            //tìm kiếm
            MNItemTimkiem.Enabled = logged;
            //thống kê báo cáo
            MNItemThongkebaocao.Enabled = logged;
            //trợ giúp
            MNItemTrogiup.Enabled = logged;

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
            //ItemBackup.Enabled = false;
            //ItemRestore.Enabled = false;
            //ItemQlyTaikhoan.Enabled = false;
            //ItemQlyNhanvien.Enabled = false;
            MNItemBackup.Visible = false;
            MNItemRestore.Visible = false;
            MNItemQlyTaikhoan.Visible = false;
            MNItemQlyNhanvien.Visible = false;
        }

        //E: Các hàm xử lý login và phân quyền

        private void ItemQlyTaikhoan_Click(object sender, EventArgs e)
        {
            if (ftk == null || ftk.IsDisposed) 
            {
                ftk = new frmTaikhoan();
                ftk.MdiParent = this;
                ftk.Show();
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            disableMenuLogin(false,"");
        }

        private void ItemDangnhap_Click(object sender, EventArgs e)
        {
            tslblUsername.Text = "Hiện tại: chưa đăng nhập";
            int num = 0;
            //continue
            Cont:
            //Khởi tạo form đăng nhập
            if (fdn == null || fdn.IsDisposed) 
            {
                fdn = new frmDangnhap();
            }
            if (fdn.ShowDialog() == DialogResult.OK) 
            {
                string username = fdn.txtUsername.Text;
                string pass = fdn.txtPass.Text;
                //Kiểm tra dữ liệu hợp lệ
                if(username.Equals(""))
                {
                    fdn.lblStatus.Text = "Tên đăng nhập không hợp lệ!";
                    goto Cont;
                }
                if (pass.Equals(""))
                {
                    fdn.lblStatus.Text = "Mật khẩu không hợp lệ!";
                    goto Cont;
                }

                //Lấy thông tin tài khoản
                utilities.tk = tkBUS.getAccountInfo(username);
                //Kiểm tra tên đăng nhập và mật khẩu 
                if (utilities.tk.username.Equals("")) 
                {
                    fdn.lblStatus.Text = "Tên đăng nhập không tồn tại!";
                    goto Cont;
                }
                if (utilities.tk.password != pass)
                {
                    fdn.lblStatus.Text = "Sai mật khẩu!";
                    num++;
                    if (num == 3)
                        this.Close();
                    goto Cont;
                }
                //Đăng nhập thành công 
                disableMenuLogin(true,utilities.tk.roleID);
                tslblUsername.Text = "Hiện tại: " + utilities.tk.username;
            }
        }

        private void ItemDangxuat_Click(object sender, EventArgs e)
        {
            //kiểm tra có form con nào đang mở đóng hết
            foreach (Form frm in Application.OpenForms["frmMain"].MdiChildren) 
            {
                frm.Close();
            }
            //Khởi tạo lại biến tk dùng chung trong utilities
            TaikhoanObj tk = new TaikhoanObj();
            utilities.tk = tk;
            disableMenuLogin(false,"");
            ItemDangnhap_Click(sender, e);
        }

        private void MNItemDoimatkhau_Click(object sender, EventArgs e)
        {
            cont:

            if (fdmk == null || fdmk.IsDisposed)
                fdmk = new frmDoimatkhau();
            if (fdmk.ShowDialog() == DialogResult.OK) 
            {
                string oldPass = fdmk.txtOldPass.Text;
                string newPass1 = fdmk.txtNewPass1.Text;
                string newPass2 = fdmk.txtNewPass2.Text;
                if (oldPass.Equals("") || newPass1.Equals("") || newPass2.Equals("")) 
                {
                    fdmk.lblError.Text = "Chưa điền đủ thông tin!";
                    goto cont;
                }
                if (newPass1 != newPass2) 
                {
                    fdmk.lblError.Text = "mật khẩu mới không trùng nhau!";
                    goto cont;
                }
                if (oldPass != utilities.tk.password) 
                {
                    fdmk.lblError.Text = "mật khẩu cũ không đúng!";
                    goto cont;
                }
                //tiến hành đổi mật khẩu
                if (tkBUS.changePassword(newPass1))
                    MessageBox.Show("Đổi mật khẩu thành công!");
                ItemDangxuat_Click(sender, e);
            }

        }

        private void MNItemThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}