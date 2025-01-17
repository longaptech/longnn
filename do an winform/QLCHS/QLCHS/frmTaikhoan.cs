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
    public partial class frmTaikhoan : Form
    {
        private TaikhoanBUS tkBUS = new TaikhoanBUS();
        private RoleBUS roleBUS = new RoleBUS();
        private EmployeeBUS employeeBUS = new EmployeeBUS();

        public frmTaikhoan()
        {
            InitializeComponent();
        }

        private void frmTaikhoan_Load(object sender, EventArgs e)
        {
            EnabledButton(false);

            //load combobox role
            cbbRole.DataSource = roleBUS.getRoleList();
            cbbRole.DisplayMember = "roleName";
            cbbRole.ValueMember = "roleID";

            //load combobox nhan vien
            cbbEmployee.DataSource = employeeBUS.getEmployeeList();
            cbbEmployee.DisplayMember = "employeeName";
            cbbEmployee.ValueMember = "employeeID";
            

            //load combobox tinh trang tai khoan
            //cbbStatus.DataSource = tkBUS.getAccountList();
            //cbbStatus.DisplayMember = "status";
            //cbbStatus.ValueMember = "status";
            

            //load datagridview danh sach tai khoan
            dg_taikhoan.DataSource = tkBUS.getAccountList();
        }

        private void dg_taikhoan_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //dòng hiện tại 
                int currRow = e.RowIndex;
                txtUsername.Text = dg_taikhoan.Rows[currRow].Cells["username"].Value.ToString();
                txtPass.Text = dg_taikhoan.Rows[currRow].Cells["password"].Value.ToString();
                cbbRole.SelectedValue = dg_taikhoan.Rows[currRow].Cells["roleID"].Value.ToString();
                cbbEmployee.SelectedValue = dg_taikhoan.Rows[currRow].Cells["employeeID"].Value.ToString();
                cbbStatus.Text = dg_taikhoan.Rows[currRow].Cells["status"].Value.ToString();
            }
            catch (Exception ex) 
            {
                MessageBox.Show("dòng trống" + ex.Message);
            }
        }

        private void cbbStatus_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void EnabledButton(bool editing) 
        {
            btnAddnew.Enabled = !editing;
            btnEdit.Enabled = !editing;
            btnDelete.Enabled = !editing;
            btnSave.Enabled = editing;
            btnSaveChange.Enabled = editing;
            btnExit.Enabled = editing;

            txtPass.Enabled = editing;
            txtUsername.Enabled = editing;
            cbbEmployee.Enabled = editing;
            cbbRole.Enabled = editing;
            cbbStatus.Enabled = editing;

            dg_taikhoan.Enabled = !editing;
        }

        private void resetTextbox()
        {
            txtPass.Text = "";
            txtUsername.Text = "";
        }

        private void btnAddnew_Click(object sender, EventArgs e)
        {
            EnabledButton(true);
            txtUsername.ReadOnly = false;
            btnSaveChange.Enabled = false;
            resetTextbox();
            //txtAccID.Text = tkBUS.nextID();
        }

        private TaikhoanObj getAccoutInfo() 
        {
            //int st = 0;
            TaikhoanObj tk = new TaikhoanObj();
            tk.username = txtUsername.Text;
            tk.password = txtPass.Text;
            tk.roleID = cbbRole.SelectedValue.ToString();
            tk.employeeID = cbbEmployee.SelectedValue.ToString();
            if (cbbStatus.Text == "Khóa")
            {
                tk.status = "False";
            }
            else 
            {
                tk.status = "True";
            }
            return tk;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            TaikhoanObj tk = getAccoutInfo();
            
            if (tkBUS.checkExistUserName(tk.username))
            {
                MessageBox.Show("Tên tài khoản đã tồn tại!");
            }
            else 
            {
                //gọi hàm thêm tài khoản
                if (tkBUS.addNewUser(tk))
                    frmTaikhoan_Load(sender, e);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EnabledButton(true);
            txtUsername.ReadOnly = true;
            txtPass.Focus();
            btnSave.Enabled = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            EnabledButton(false);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa tài khoản: " + txtUsername.Text + " không?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) 
            {
                if(tkBUS.deleteUser(txtUsername.Text))
                    frmTaikhoan_Load(sender, e);
            }
        }

        private void btnSaveChange_Click(object sender, EventArgs e)
        {
            TaikhoanObj tk = getAccoutInfo();
            if (tkBUS.editUser(tk))
                frmTaikhoan_Load(sender, e);
        }
    }
}