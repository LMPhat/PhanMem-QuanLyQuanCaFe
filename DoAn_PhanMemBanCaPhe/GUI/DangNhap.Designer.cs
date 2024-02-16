namespace GUI
{
    partial class DangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DangNhap));
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txt_TenDN = new DevExpress.XtraEditors.TextEdit();
            this.txt_MatKhau = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btn_DN = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Huy = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TenDN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MatKhau.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl2.Location = new System.Drawing.Point(34, 65);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(93, 17);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Tên đăng nhập";
            // 
            // txt_TenDN
            // 
            this.txt_TenDN.Location = new System.Drawing.Point(142, 62);
            this.txt_TenDN.Name = "txt_TenDN";
            this.txt_TenDN.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txt_TenDN.Properties.Appearance.Options.UseFont = true;
            this.txt_TenDN.Size = new System.Drawing.Size(159, 22);
            this.txt_TenDN.TabIndex = 2;
            // 
            // txt_MatKhau
            // 
            this.txt_MatKhau.Location = new System.Drawing.Point(142, 104);
            this.txt_MatKhau.Name = "txt_MatKhau";
            this.txt_MatKhau.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txt_MatKhau.Properties.Appearance.Options.UseFont = true;
            this.txt_MatKhau.Properties.PasswordChar = '*';
            this.txt_MatKhau.Size = new System.Drawing.Size(159, 22);
            this.txt_MatKhau.TabIndex = 4;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl3.Location = new System.Drawing.Point(34, 107);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(56, 17);
            this.labelControl3.TabIndex = 3;
            this.labelControl3.Text = "Mật khẩu";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.labelControl1.Location = new System.Drawing.Point(117, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(108, 24);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "ĐĂNG NHẬP";
            // 
            // btn_DN
            // 
            this.btn_DN.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DN.Appearance.Options.UseFont = true;
            this.btn_DN.Image = ((System.Drawing.Image)(resources.GetObject("btn_DN.Image")));
            this.btn_DN.Location = new System.Drawing.Point(34, 151);
            this.btn_DN.Name = "btn_DN";
            this.btn_DN.Size = new System.Drawing.Size(118, 33);
            this.btn_DN.TabIndex = 63;
            this.btn_DN.Text = "Đăng nhập";
            this.btn_DN.Click += new System.EventHandler(this.btn_DN_Click);
            // 
            // btn_Huy
            // 
            this.btn_Huy.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Huy.Appearance.Options.UseFont = true;
            this.btn_Huy.Image = ((System.Drawing.Image)(resources.GetObject("btn_Huy.Image")));
            this.btn_Huy.Location = new System.Drawing.Point(228, 151);
            this.btn_Huy.Name = "btn_Huy";
            this.btn_Huy.Size = new System.Drawing.Size(73, 33);
            this.btn_Huy.TabIndex = 64;
            this.btn_Huy.Text = "Hủy";
            this.btn_Huy.Click += new System.EventHandler(this.btn_Huy_Click);
            // 
            // DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 207);
            this.Controls.Add(this.btn_Huy);
            this.Controls.Add(this.btn_DN);
            this.Controls.Add(this.txt_MatKhau);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txt_TenDN);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Name = "DangNhap";
            this.Text = "DangNhap";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DangNhap_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.txt_TenDN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MatKhau.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txt_TenDN;
        private DevExpress.XtraEditors.TextEdit txt_MatKhau;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btn_DN;
        private DevExpress.XtraEditors.SimpleButton btn_Huy;
    }
}