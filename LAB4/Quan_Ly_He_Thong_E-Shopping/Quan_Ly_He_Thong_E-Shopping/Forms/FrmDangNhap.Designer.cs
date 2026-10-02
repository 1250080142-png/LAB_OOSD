using System.Windows.Forms;



namespace Quan_Ly_He_Thong_E_Shopping.Forms

{

    partial class FrmDangNhap

    {

        private System.ComponentModel.IContainer components = null;



        protected override void Dispose(bool disposing)

        {

            if (disposing && (components != null))

            {

                components.Dispose();

            }

            base.Dispose(disposing);

        }



        #region Windows Form Designer generated code



        private void InitializeComponent()

        {

            this.lblTitle = new System.Windows.Forms.Label();

            this.lblEmail = new System.Windows.Forms.Label();

            this.txtEmail = new System.Windows.Forms.TextBox();

            this.lblMatKhau = new System.Windows.Forms.Label();

            this.txtMatKhau = new System.Windows.Forms.TextBox();

            this.btnDangNhap = new System.Windows.Forms.Button();

            this.btnHuy = new System.Windows.Forms.Button();

            this.SuspendLayout();

            // 

            // lblTitle

            // 

            this.lblTitle.AutoSize = true;

            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);

            this.lblTitle.Location = new System.Drawing.Point(120, 25);

            this.lblTitle.Name = "lblTitle";

            this.lblTitle.Size = new System.Drawing.Size(160, 29);

            this.lblTitle.TabIndex = 0;

            this.lblTitle.Text = "ĐĂNG NHẬP";

            // 

            // lblEmail

            // 

            this.lblEmail.AutoSize = true;

            this.lblEmail.Location = new System.Drawing.Point(45, 80);

            this.lblEmail.Name = "lblEmail";

            this.lblEmail.Size = new System.Drawing.Size(44, 16);

            this.lblEmail.TabIndex = 1;

            this.lblEmail.Text = "Email:";

            // 

            // txtEmail

            // 

            this.txtEmail.Location = new System.Drawing.Point(125, 77);

            this.txtEmail.Name = "txtEmail";

            this.txtEmail.Size = new System.Drawing.Size(220, 22);

            this.txtEmail.TabIndex = 2;

            // 

            // lblMatKhau

            // 

            this.lblMatKhau.AutoSize = true;

            this.lblMatKhau.Location = new System.Drawing.Point(45, 125);

            this.lblMatKhau.Name = "lblMatKhau";

            this.lblMatKhau.Size = new System.Drawing.Size(65, 16);

            this.lblMatKhau.TabIndex = 3;

            this.lblMatKhau.Text = "Mật khẩu:";

            // 

            // txtMatKhau

            // 

            this.txtMatKhau.Location = new System.Drawing.Point(125, 122);

            this.txtMatKhau.Name = "txtMatKhau";

            this.txtMatKhau.PasswordChar = '*';

            this.txtMatKhau.Size = new System.Drawing.Size(220, 22);

            this.txtMatKhau.TabIndex = 4;

            // 

            // btnDangNhap

            // 

            this.btnDangNhap.Location = new System.Drawing.Point(125, 170);

            this.btnDangNhap.Name = "btnDangNhap";

            this.btnDangNhap.Size = new System.Drawing.Size(100, 32);

            this.btnDangNhap.TabIndex = 5;

            this.btnDangNhap.Text = "Đăng Nhập";

            this.btnDangNhap.UseVisualStyleBackColor = true;

            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);

            // 

            // btnHuy

            // 

            this.btnHuy.Location = new System.Drawing.Point(245, 170);

            this.btnHuy.Name = "btnHuy";

            this.btnHuy.Size = new System.Drawing.Size(100, 32);

            this.btnHuy.TabIndex = 6;

            this.btnHuy.Text = "Hủy";

            this.btnHuy.UseVisualStyleBackColor = true;

            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);

            // 

            // FrmDangNhap

            // 

            this.ClientSize = new System.Drawing.Size(400, 240);

            this.Controls.Add(this.btnHuy);

            this.Controls.Add(this.btnDangNhap);

            this.Controls.Add(this.txtMatKhau);

            this.Controls.Add(this.lblMatKhau);

            this.Controls.Add(this.txtEmail);

            this.Controls.Add(this.lblEmail);

            this.Controls.Add(this.lblTitle);

            this.Name = "FrmDangNhap";

            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

            this.Text = "Đăng Nhập Khách Hàng";

            this.ResumeLayout(false);

            this.PerformLayout();

        }



        #endregion



        private System.Windows.Forms.Label lblTitle;

        private System.Windows.Forms.Label lblEmail;

        private System.Windows.Forms.TextBox txtEmail;

        private System.Windows.Forms.Label lblMatKhau;

        private System.Windows.Forms.TextBox txtMatKhau;

        private System.Windows.Forms.Button btnDangNhap;

        private System.Windows.Forms.Button btnHuy;

    }

}

