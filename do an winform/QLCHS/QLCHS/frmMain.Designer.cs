namespace QLCHS
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MNItemHethong = new System.Windows.Forms.ToolStripMenuItem();
            this.MNItemDangnhap = new System.Windows.Forms.ToolStripMenuItem();
            this.MNItemDangxuat = new System.Windows.Forms.ToolStripMenuItem();
            this.MNItemDoimatkhau = new System.Windows.Forms.ToolStripMenuItem();
            this.MNItemBackup = new System.Windows.Forms.ToolStripMenuItem();
            this.MNItemRestore = new System.Windows.Forms.ToolStripMenuItem();
            this.MNItemThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.MNItemQuanly = new System.Windows.Forms.ToolStripMenuItem();
            this.MNItemQlyTaikhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.MNItemQlyNhanvien = new System.Windows.Forms.ToolStripMenuItem();
            this.MNItemQlySach = new System.Windows.Forms.ToolStripMenuItem();
            this.MNItemQlyNhacc = new System.Windows.Forms.ToolStripMenuItem();
            this.MNItemQlyNhaxb = new System.Windows.Forms.ToolStripMenuItem();
            this.MNItemQlyTacgia = new System.Windows.Forms.ToolStripMenuItem();
            this.MNItemHoadon = new System.Windows.Forms.ToolStripMenuItem();
            this.lậpHóaĐơnNhậpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýHóaĐơnNhậpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lậpHóaĐơnXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýHóaĐơnXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MNItemTimkiem = new System.Windows.Forms.ToolStripMenuItem();
            this.MNItemThongkebaocao = new System.Windows.Forms.ToolStripMenuItem();
            this.MNItemTrogiup = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tslblUsername = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MNItemHethong,
            this.MNItemQuanly,
            this.MNItemHoadon,
            this.MNItemTimkiem,
            this.MNItemThongkebaocao,
            this.MNItemTrogiup});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(766, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MNItemHethong
            // 
            this.MNItemHethong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MNItemDangnhap,
            this.MNItemDangxuat,
            this.MNItemDoimatkhau,
            this.MNItemBackup,
            this.MNItemRestore,
            this.MNItemThoat});
            this.MNItemHethong.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.MNItemHethong.Name = "MNItemHethong";
            this.MNItemHethong.Size = new System.Drawing.Size(70, 20);
            this.MNItemHethong.Text = "&Hệ thống";
            // 
            // MNItemDangnhap
            // 
            this.MNItemDangnhap.Name = "MNItemDangnhap";
            this.MNItemDangnhap.Size = new System.Drawing.Size(161, 22);
            this.MNItemDangnhap.Text = "&Đăng nhập";
            this.MNItemDangnhap.Click += new System.EventHandler(this.ItemDangnhap_Click);
            // 
            // MNItemDangxuat
            // 
            this.MNItemDangxuat.Name = "MNItemDangxuat";
            this.MNItemDangxuat.Size = new System.Drawing.Size(161, 22);
            this.MNItemDangxuat.Text = "Đăng &xuất";
            this.MNItemDangxuat.Click += new System.EventHandler(this.ItemDangxuat_Click);
            // 
            // MNItemDoimatkhau
            // 
            this.MNItemDoimatkhau.Name = "MNItemDoimatkhau";
            this.MNItemDoimatkhau.Size = new System.Drawing.Size(161, 22);
            this.MNItemDoimatkhau.Text = "Đổi &mật khẩu";
            this.MNItemDoimatkhau.Click += new System.EventHandler(this.MNItemDoimatkhau_Click);
            // 
            // MNItemBackup
            // 
            this.MNItemBackup.Name = "MNItemBackup";
            this.MNItemBackup.Size = new System.Drawing.Size(161, 22);
            this.MNItemBackup.Text = "&Backup CSDL";
            // 
            // MNItemRestore
            // 
            this.MNItemRestore.Name = "MNItemRestore";
            this.MNItemRestore.Size = new System.Drawing.Size(161, 22);
            this.MNItemRestore.Text = "&Restore CSDL";
            // 
            // MNItemThoat
            // 
            this.MNItemThoat.Name = "MNItemThoat";
            this.MNItemThoat.Size = new System.Drawing.Size(161, 22);
            this.MNItemThoat.Text = "&Thoát";
            this.MNItemThoat.Click += new System.EventHandler(this.MNItemThoat_Click);
            // 
            // MNItemQuanly
            // 
            this.MNItemQuanly.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MNItemQlyTaikhoan,
            this.MNItemQlyNhanvien,
            this.MNItemQlySach,
            this.MNItemQlyNhacc,
            this.MNItemQlyNhaxb,
            this.MNItemQlyTacgia});
            this.MNItemQuanly.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.MNItemQuanly.Name = "MNItemQuanly";
            this.MNItemQuanly.Size = new System.Drawing.Size(61, 20);
            this.MNItemQuanly.Text = "&Quản lý";
            // 
            // MNItemQlyTaikhoan
            // 
            this.MNItemQlyTaikhoan.Name = "MNItemQlyTaikhoan";
            this.MNItemQlyTaikhoan.Size = new System.Drawing.Size(204, 22);
            this.MNItemQlyTaikhoan.Text = "&Quản lý tài khoản";
            this.MNItemQlyTaikhoan.Click += new System.EventHandler(this.ItemQlyTaikhoan_Click);
            // 
            // MNItemQlyNhanvien
            // 
            this.MNItemQlyNhanvien.Name = "MNItemQlyNhanvien";
            this.MNItemQlyNhanvien.Size = new System.Drawing.Size(204, 22);
            this.MNItemQlyNhanvien.Text = "&Quản lý nhân viên";
            // 
            // MNItemQlySach
            // 
            this.MNItemQlySach.Name = "MNItemQlySach";
            this.MNItemQlySach.Size = new System.Drawing.Size(204, 22);
            this.MNItemQlySach.Text = "&Quản lý sách";
            // 
            // MNItemQlyNhacc
            // 
            this.MNItemQlyNhacc.Name = "MNItemQlyNhacc";
            this.MNItemQlyNhacc.Size = new System.Drawing.Size(204, 22);
            this.MNItemQlyNhacc.Text = "&Quản lý nhà cung cấp";
            // 
            // MNItemQlyNhaxb
            // 
            this.MNItemQlyNhaxb.Name = "MNItemQlyNhaxb";
            this.MNItemQlyNhaxb.Size = new System.Drawing.Size(204, 22);
            this.MNItemQlyNhaxb.Text = "&Quản lý nhà xuất bản";
            // 
            // MNItemQlyTacgia
            // 
            this.MNItemQlyTacgia.Name = "MNItemQlyTacgia";
            this.MNItemQlyTacgia.Size = new System.Drawing.Size(204, 22);
            this.MNItemQlyTacgia.Text = "&Quản lý tác giả";
            // 
            // MNItemHoadon
            // 
            this.MNItemHoadon.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lậpHóaĐơnNhậpToolStripMenuItem,
            this.quảnLýHóaĐơnNhậpToolStripMenuItem,
            this.lậpHóaĐơnXuấtToolStripMenuItem,
            this.quảnLýHóaĐơnXuấtToolStripMenuItem});
            this.MNItemHoadon.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.MNItemHoadon.Name = "MNItemHoadon";
            this.MNItemHoadon.Size = new System.Drawing.Size(65, 20);
            this.MNItemHoadon.Text = "&Hóa đơn";
            // 
            // lậpHóaĐơnNhậpToolStripMenuItem
            // 
            this.lậpHóaĐơnNhậpToolStripMenuItem.Name = "lậpHóaĐơnNhậpToolStripMenuItem";
            this.lậpHóaĐơnNhậpToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.lậpHóaĐơnNhậpToolStripMenuItem.Text = "&Lập hóa đơn nhập";
            // 
            // quảnLýHóaĐơnNhậpToolStripMenuItem
            // 
            this.quảnLýHóaĐơnNhậpToolStripMenuItem.Name = "quảnLýHóaĐơnNhậpToolStripMenuItem";
            this.quảnLýHóaĐơnNhậpToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.quảnLýHóaĐơnNhậpToolStripMenuItem.Text = "&Quản lý hóa đơn nhập";
            // 
            // lậpHóaĐơnXuấtToolStripMenuItem
            // 
            this.lậpHóaĐơnXuấtToolStripMenuItem.Name = "lậpHóaĐơnXuấtToolStripMenuItem";
            this.lậpHóaĐơnXuấtToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.lậpHóaĐơnXuấtToolStripMenuItem.Text = "&Lập hóa đơn xuất";
            // 
            // quảnLýHóaĐơnXuấtToolStripMenuItem
            // 
            this.quảnLýHóaĐơnXuấtToolStripMenuItem.Name = "quảnLýHóaĐơnXuấtToolStripMenuItem";
            this.quảnLýHóaĐơnXuấtToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.quảnLýHóaĐơnXuấtToolStripMenuItem.Text = "&Quản lý hóa đơn xuất";
            // 
            // MNItemTimkiem
            // 
            this.MNItemTimkiem.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.MNItemTimkiem.Name = "MNItemTimkiem";
            this.MNItemTimkiem.Size = new System.Drawing.Size(71, 20);
            this.MNItemTimkiem.Text = "&Tìm kiếm";
            // 
            // MNItemThongkebaocao
            // 
            this.MNItemThongkebaocao.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.MNItemThongkebaocao.Name = "MNItemThongkebaocao";
            this.MNItemThongkebaocao.Size = new System.Drawing.Size(121, 20);
            this.MNItemThongkebaocao.Text = "&Thông kế/Báo cáo";
            // 
            // MNItemTrogiup
            // 
            this.MNItemTrogiup.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.MNItemTrogiup.Name = "MNItemTrogiup";
            this.MNItemTrogiup.Size = new System.Drawing.Size(65, 20);
            this.MNItemTrogiup.Text = "&Trợ giúp";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslblUsername});
            this.statusStrip1.Location = new System.Drawing.Point(0, 375);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(766, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tslblUsername
            // 
            this.tslblUsername.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.tslblUsername.ForeColor = System.Drawing.Color.Blue;
            this.tslblUsername.Name = "tslblUsername";
            this.tslblUsername.Size = new System.Drawing.Size(146, 17);
            this.tslblUsername.Text = "Hiện tại: chưa đăng nhập";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(766, 397);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "He Thong";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MNItemHethong;
        private System.Windows.Forms.ToolStripMenuItem MNItemDangnhap;
        private System.Windows.Forms.ToolStripMenuItem MNItemDangxuat;
        private System.Windows.Forms.ToolStripMenuItem MNItemDoimatkhau;
        private System.Windows.Forms.ToolStripMenuItem MNItemBackup;
        private System.Windows.Forms.ToolStripMenuItem MNItemRestore;
        private System.Windows.Forms.ToolStripMenuItem MNItemThoat;
        private System.Windows.Forms.ToolStripMenuItem MNItemQuanly;
        private System.Windows.Forms.ToolStripMenuItem MNItemHoadon;
        private System.Windows.Forms.ToolStripMenuItem MNItemTimkiem;
        private System.Windows.Forms.ToolStripMenuItem MNItemThongkebaocao;
        private System.Windows.Forms.ToolStripMenuItem MNItemTrogiup;
        private System.Windows.Forms.ToolStripMenuItem MNItemQlyTaikhoan;
        private System.Windows.Forms.ToolStripMenuItem MNItemQlyNhanvien;
        private System.Windows.Forms.ToolStripMenuItem MNItemQlySach;
        private System.Windows.Forms.ToolStripMenuItem MNItemQlyNhacc;
        private System.Windows.Forms.ToolStripMenuItem MNItemQlyNhaxb;
        private System.Windows.Forms.ToolStripMenuItem MNItemQlyTacgia;
        private System.Windows.Forms.ToolStripMenuItem lậpHóaĐơnNhậpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýHóaĐơnNhậpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lậpHóaĐơnXuấtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýHóaĐơnXuấtToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tslblUsername;
    }
}

