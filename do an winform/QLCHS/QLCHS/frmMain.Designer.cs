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
            this.ItemHethong = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemDangnhap = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemDangxuat = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemDoimatkhau = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemBackup = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemRestore = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemQuanly = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemQlyTaikhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemQlyNhanvien = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemQlySach = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemQlyNhacc = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemQlyNhaxb = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemQlyTacgia = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemHoadon = new System.Windows.Forms.ToolStripMenuItem();
            this.lậpHóaĐơnNhậpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýHóaĐơnNhậpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lậpHóaĐơnXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýHóaĐơnXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemTimkiem = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemThongkebaocao = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemTrogiup = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tslblUsername = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ItemHethong,
            this.ItemQuanly,
            this.ItemHoadon,
            this.ItemTimkiem,
            this.ItemThongkebaocao,
            this.ItemTrogiup});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(766, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ItemHethong
            // 
            this.ItemHethong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ItemDangnhap,
            this.ItemDangxuat,
            this.ItemDoimatkhau,
            this.ItemBackup,
            this.ItemRestore,
            this.ItemThoat});
            this.ItemHethong.Name = "ItemHethong";
            this.ItemHethong.Size = new System.Drawing.Size(63, 20);
            this.ItemHethong.Text = "&Hệ thống";
            // 
            // ItemDangnhap
            // 
            this.ItemDangnhap.Name = "ItemDangnhap";
            this.ItemDangnhap.Size = new System.Drawing.Size(152, 22);
            this.ItemDangnhap.Text = "&Đăng nhập";
            // 
            // ItemDangxuat
            // 
            this.ItemDangxuat.Name = "ItemDangxuat";
            this.ItemDangxuat.Size = new System.Drawing.Size(152, 22);
            this.ItemDangxuat.Text = "&Đăng xuất";
            // 
            // ItemDoimatkhau
            // 
            this.ItemDoimatkhau.Name = "ItemDoimatkhau";
            this.ItemDoimatkhau.Size = new System.Drawing.Size(152, 22);
            this.ItemDoimatkhau.Text = "&Đổi mật khẩu";
            // 
            // ItemBackup
            // 
            this.ItemBackup.Name = "ItemBackup";
            this.ItemBackup.Size = new System.Drawing.Size(152, 22);
            this.ItemBackup.Text = "&Backup CSDL";
            // 
            // ItemRestore
            // 
            this.ItemRestore.Name = "ItemRestore";
            this.ItemRestore.Size = new System.Drawing.Size(152, 22);
            this.ItemRestore.Text = "&Restore CSDL";
            // 
            // ItemThoat
            // 
            this.ItemThoat.Name = "ItemThoat";
            this.ItemThoat.Size = new System.Drawing.Size(152, 22);
            this.ItemThoat.Text = "&Thoát";
            // 
            // ItemQuanly
            // 
            this.ItemQuanly.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ItemQlyTaikhoan,
            this.ItemQlyNhanvien,
            this.ItemQlySach,
            this.ItemQlyNhacc,
            this.ItemQlyNhaxb,
            this.ItemQlyTacgia});
            this.ItemQuanly.Name = "ItemQuanly";
            this.ItemQuanly.Size = new System.Drawing.Size(56, 20);
            this.ItemQuanly.Text = "&Quản lý";
            // 
            // ItemQlyTaikhoan
            // 
            this.ItemQlyTaikhoan.Name = "ItemQlyTaikhoan";
            this.ItemQlyTaikhoan.Size = new System.Drawing.Size(189, 22);
            this.ItemQlyTaikhoan.Text = "&Quản lý tài khoản";
            this.ItemQlyTaikhoan.Click += new System.EventHandler(this.ItemQlyTaikhoan_Click);
            // 
            // ItemQlyNhanvien
            // 
            this.ItemQlyNhanvien.Name = "ItemQlyNhanvien";
            this.ItemQlyNhanvien.Size = new System.Drawing.Size(189, 22);
            this.ItemQlyNhanvien.Text = "&Quản lý nhân viên";
            // 
            // ItemQlySach
            // 
            this.ItemQlySach.Name = "ItemQlySach";
            this.ItemQlySach.Size = new System.Drawing.Size(189, 22);
            this.ItemQlySach.Text = "&Quản lý sách";
            // 
            // ItemQlyNhacc
            // 
            this.ItemQlyNhacc.Name = "ItemQlyNhacc";
            this.ItemQlyNhacc.Size = new System.Drawing.Size(189, 22);
            this.ItemQlyNhacc.Text = "&Quản lý nhà cung cấp";
            // 
            // ItemQlyNhaxb
            // 
            this.ItemQlyNhaxb.Name = "ItemQlyNhaxb";
            this.ItemQlyNhaxb.Size = new System.Drawing.Size(189, 22);
            this.ItemQlyNhaxb.Text = "&Quản lý nhà xuất bản";
            // 
            // ItemQlyTacgia
            // 
            this.ItemQlyTacgia.Name = "ItemQlyTacgia";
            this.ItemQlyTacgia.Size = new System.Drawing.Size(189, 22);
            this.ItemQlyTacgia.Text = "&Quản lý tác giả";
            // 
            // ItemHoadon
            // 
            this.ItemHoadon.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lậpHóaĐơnNhậpToolStripMenuItem,
            this.quảnLýHóaĐơnNhậpToolStripMenuItem,
            this.lậpHóaĐơnXuấtToolStripMenuItem,
            this.quảnLýHóaĐơnXuấtToolStripMenuItem});
            this.ItemHoadon.Name = "ItemHoadon";
            this.ItemHoadon.Size = new System.Drawing.Size(59, 20);
            this.ItemHoadon.Text = "&Hóa đơn";
            // 
            // lậpHóaĐơnNhậpToolStripMenuItem
            // 
            this.lậpHóaĐơnNhậpToolStripMenuItem.Name = "lậpHóaĐơnNhậpToolStripMenuItem";
            this.lậpHóaĐơnNhậpToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.lậpHóaĐơnNhậpToolStripMenuItem.Text = "&Lập hóa đơn nhập";
            // 
            // quảnLýHóaĐơnNhậpToolStripMenuItem
            // 
            this.quảnLýHóaĐơnNhậpToolStripMenuItem.Name = "quảnLýHóaĐơnNhậpToolStripMenuItem";
            this.quảnLýHóaĐơnNhậpToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.quảnLýHóaĐơnNhậpToolStripMenuItem.Text = "&Quản lý hóa đơn nhập";
            // 
            // lậpHóaĐơnXuấtToolStripMenuItem
            // 
            this.lậpHóaĐơnXuấtToolStripMenuItem.Name = "lậpHóaĐơnXuấtToolStripMenuItem";
            this.lậpHóaĐơnXuấtToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.lậpHóaĐơnXuấtToolStripMenuItem.Text = "&Lập hóa đơn xuất";
            // 
            // quảnLýHóaĐơnXuấtToolStripMenuItem
            // 
            this.quảnLýHóaĐơnXuấtToolStripMenuItem.Name = "quảnLýHóaĐơnXuấtToolStripMenuItem";
            this.quảnLýHóaĐơnXuấtToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.quảnLýHóaĐơnXuấtToolStripMenuItem.Text = "&Quản lý hóa đơn xuất";
            // 
            // ItemTimkiem
            // 
            this.ItemTimkiem.Name = "ItemTimkiem";
            this.ItemTimkiem.Size = new System.Drawing.Size(59, 20);
            this.ItemTimkiem.Text = "&Tìm kiếm";
            // 
            // ItemThongkebaocao
            // 
            this.ItemThongkebaocao.Name = "ItemThongkebaocao";
            this.ItemThongkebaocao.Size = new System.Drawing.Size(105, 20);
            this.ItemThongkebaocao.Text = "&Thông kế/Báo cáo";
            // 
            // ItemTrogiup
            // 
            this.ItemTrogiup.Name = "ItemTrogiup";
            this.ItemTrogiup.Size = new System.Drawing.Size(58, 20);
            this.ItemTrogiup.Text = "&Trợ giúp";
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
            this.tslblUsername.ForeColor = System.Drawing.Color.Blue;
            this.tslblUsername.Name = "tslblUsername";
            this.tslblUsername.Size = new System.Drawing.Size(50, 17);
            this.tslblUsername.Text = "Hiện tại :";
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
        private System.Windows.Forms.ToolStripMenuItem ItemHethong;
        private System.Windows.Forms.ToolStripMenuItem ItemDangnhap;
        private System.Windows.Forms.ToolStripMenuItem ItemDangxuat;
        private System.Windows.Forms.ToolStripMenuItem ItemDoimatkhau;
        private System.Windows.Forms.ToolStripMenuItem ItemBackup;
        private System.Windows.Forms.ToolStripMenuItem ItemRestore;
        private System.Windows.Forms.ToolStripMenuItem ItemThoat;
        private System.Windows.Forms.ToolStripMenuItem ItemQuanly;
        private System.Windows.Forms.ToolStripMenuItem ItemHoadon;
        private System.Windows.Forms.ToolStripMenuItem ItemTimkiem;
        private System.Windows.Forms.ToolStripMenuItem ItemThongkebaocao;
        private System.Windows.Forms.ToolStripMenuItem ItemTrogiup;
        private System.Windows.Forms.ToolStripMenuItem ItemQlyTaikhoan;
        private System.Windows.Forms.ToolStripMenuItem ItemQlyNhanvien;
        private System.Windows.Forms.ToolStripMenuItem ItemQlySach;
        private System.Windows.Forms.ToolStripMenuItem ItemQlyNhacc;
        private System.Windows.Forms.ToolStripMenuItem ItemQlyNhaxb;
        private System.Windows.Forms.ToolStripMenuItem ItemQlyTacgia;
        private System.Windows.Forms.ToolStripMenuItem lậpHóaĐơnNhậpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýHóaĐơnNhậpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lậpHóaĐơnXuấtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýHóaĐơnXuấtToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tslblUsername;
    }
}

