namespace GUI
{
    partial class uct_NhanVien
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uct_NhanVien));
            this.btn_LuuNV = new DevExpress.XtraEditors.SimpleButton();
            this.btn_RefreshNV = new DevExpress.XtraEditors.SimpleButton();
            this.btn_SuaNV = new DevExpress.XtraEditors.SimpleButton();
            this.btn_ThemNV = new DevExpress.XtraEditors.SimpleButton();
            this.mv_NV = new DevExpress.XtraGrid.GridControl();
            this.gv_NV = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txt_TenNV = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txt_MK = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txt_TenDN = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.rdo_GT = new DevExpress.XtraEditors.RadioGroup();
            this.cke_TrangThai = new DevExpress.XtraEditors.CheckEdit();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.txt_SDT = new ThietKeControl.txt_SDT();
            ((System.ComponentModel.ISupportInitialize)(this.mv_NV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_NV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TenNV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MK.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TenDN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdo_GT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cke_TrangThai.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_LuuNV
            // 
            this.btn_LuuNV.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LuuNV.Appearance.Options.UseFont = true;
            this.btn_LuuNV.Image = ((System.Drawing.Image)(resources.GetObject("btn_LuuNV.Image")));
            this.btn_LuuNV.Location = new System.Drawing.Point(844, 152);
            this.btn_LuuNV.Name = "btn_LuuNV";
            this.btn_LuuNV.Size = new System.Drawing.Size(79, 33);
            this.btn_LuuNV.TabIndex = 34;
            this.btn_LuuNV.Text = "Lưu";
            this.btn_LuuNV.Click += new System.EventHandler(this.btn_LuuNV_Click);
            // 
            // btn_RefreshNV
            // 
            this.btn_RefreshNV.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RefreshNV.Appearance.Options.UseFont = true;
            this.btn_RefreshNV.Image = ((System.Drawing.Image)(resources.GetObject("btn_RefreshNV.Image")));
            this.btn_RefreshNV.Location = new System.Drawing.Point(941, 152);
            this.btn_RefreshNV.Name = "btn_RefreshNV";
            this.btn_RefreshNV.Size = new System.Drawing.Size(102, 33);
            this.btn_RefreshNV.TabIndex = 33;
            this.btn_RefreshNV.Text = "Refresh";
            this.btn_RefreshNV.Click += new System.EventHandler(this.btn_RefreshNV_Click);
            // 
            // btn_SuaNV
            // 
            this.btn_SuaNV.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SuaNV.Appearance.Options.UseFont = true;
            this.btn_SuaNV.Image = ((System.Drawing.Image)(resources.GetObject("btn_SuaNV.Image")));
            this.btn_SuaNV.Location = new System.Drawing.Point(736, 152);
            this.btn_SuaNV.Name = "btn_SuaNV";
            this.btn_SuaNV.Size = new System.Drawing.Size(83, 33);
            this.btn_SuaNV.TabIndex = 32;
            this.btn_SuaNV.Text = "Sửa";
            this.btn_SuaNV.Click += new System.EventHandler(this.btn_SuaNV_Click);
            // 
            // btn_ThemNV
            // 
            this.btn_ThemNV.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThemNV.Appearance.Options.UseFont = true;
            this.btn_ThemNV.Image = ((System.Drawing.Image)(resources.GetObject("btn_ThemNV.Image")));
            this.btn_ThemNV.Location = new System.Drawing.Point(624, 152);
            this.btn_ThemNV.Name = "btn_ThemNV";
            this.btn_ThemNV.Size = new System.Drawing.Size(85, 33);
            this.btn_ThemNV.TabIndex = 30;
            this.btn_ThemNV.Text = "Thêm";
            this.btn_ThemNV.Click += new System.EventHandler(this.btn_ThemNV_Click);
            // 
            // mv_NV
            // 
            this.mv_NV.Location = new System.Drawing.Point(240, 206);
            this.mv_NV.MainView = this.gv_NV;
            this.mv_NV.Name = "mv_NV";
            this.mv_NV.Size = new System.Drawing.Size(806, 300);
            this.mv_NV.TabIndex = 29;
            this.mv_NV.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_NV});
            // 
            // gv_NV
            // 
            this.gv_NV.GridControl = this.mv_NV;
            this.gv_NV.Name = "gv_NV";
            this.gv_NV.ShownEditor += new System.EventHandler(this.gv_NV_ShownEditor);
            this.gv_NV.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gv_NV_FocusedRowChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(239, 70);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(101, 19);
            this.labelControl1.TabIndex = 28;
            this.labelControl1.Text = "Tên nhân viên";
            // 
            // txt_TenNV
            // 
            this.txt_TenNV.Location = new System.Drawing.Point(346, 67);
            this.txt_TenNV.Name = "txt_TenNV";
            this.txt_TenNV.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenNV.Properties.Appearance.Options.UseFont = true;
            this.txt_TenNV.Size = new System.Drawing.Size(170, 26);
            this.txt_TenNV.TabIndex = 27;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(240, 109);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(93, 19);
            this.labelControl2.TabIndex = 36;
            this.labelControl2.Text = "Số điện thoại";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Location = new System.Drawing.Point(755, 109);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(64, 19);
            this.labelControl3.TabIndex = 40;
            this.labelControl3.Text = "Mật khẩu";
            // 
            // txt_MK
            // 
            this.txt_MK.Location = new System.Drawing.Point(876, 102);
            this.txt_MK.Name = "txt_MK";
            this.txt_MK.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MK.Properties.Appearance.Options.UseFont = true;
            this.txt_MK.Size = new System.Drawing.Size(170, 26);
            this.txt_MK.TabIndex = 39;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Location = new System.Drawing.Point(754, 70);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(107, 19);
            this.labelControl4.TabIndex = 38;
            this.labelControl4.Text = "Tên đăng nhập";
            // 
            // txt_TenDN
            // 
            this.txt_TenDN.Location = new System.Drawing.Point(876, 67);
            this.txt_TenDN.Name = "txt_TenDN";
            this.txt_TenDN.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenDN.Properties.Appearance.Options.UseFont = true;
            this.txt_TenDN.Size = new System.Drawing.Size(170, 26);
            this.txt_TenDN.TabIndex = 37;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Location = new System.Drawing.Point(565, 70);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(60, 19);
            this.labelControl5.TabIndex = 41;
            this.labelControl5.Text = "Giới tính";
            // 
            // rdo_GT
            // 
            this.rdo_GT.Location = new System.Drawing.Point(565, 95);
            this.rdo_GT.Name = "rdo_GT";
            this.rdo_GT.Properties.Appearance.BackColor = System.Drawing.SystemColors.ControlLight;
            this.rdo_GT.Properties.Appearance.Options.UseBackColor = true;
            this.rdo_GT.Properties.Columns = 2;
            this.rdo_GT.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem("NAM", "Nam"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("NỮ", "Nữ")});
            this.rdo_GT.Size = new System.Drawing.Size(133, 33);
            this.rdo_GT.TabIndex = 42;
            // 
            // cke_TrangThai
            // 
            this.cke_TrangThai.Location = new System.Drawing.Point(240, 149);
            this.cke_TrangThai.Name = "cke_TrangThai";
            this.cke_TrangThai.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.cke_TrangThai.Properties.Appearance.Options.UseFont = true;
            this.cke_TrangThai.Properties.Caption = "Trạng thái hoạt động";
            this.cke_TrangThai.Size = new System.Drawing.Size(180, 23);
            this.cke_TrangThai.TabIndex = 44;
            // 
            // textEdit1
            // 
            this.textEdit1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textEdit1.EditValue = "QUẢN LÝ NHÂN VIÊN";
            this.textEdit1.Enabled = false;
            this.textEdit1.Location = new System.Drawing.Point(0, 0);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Olive;
            this.textEdit1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 16F);
            this.textEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.textEdit1.Properties.Appearance.Options.UseFont = true;
            this.textEdit1.Properties.Appearance.Options.UseForeColor = true;
            this.textEdit1.Size = new System.Drawing.Size(2518, 32);
            this.textEdit1.TabIndex = 45;
            // 
            // txt_SDT
            // 
            this.txt_SDT.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txt_SDT.Location = new System.Drawing.Point(346, 106);
            this.txt_SDT.Name = "txt_SDT";
            this.txt_SDT.Size = new System.Drawing.Size(170, 27);
            this.txt_SDT.TabIndex = 46;
            // 
            // uct_NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txt_SDT);
            this.Controls.Add(this.textEdit1);
            this.Controls.Add(this.cke_TrangThai);
            this.Controls.Add(this.rdo_GT);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txt_MK);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.txt_TenDN);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.btn_LuuNV);
            this.Controls.Add(this.btn_RefreshNV);
            this.Controls.Add(this.btn_SuaNV);
            this.Controls.Add(this.btn_ThemNV);
            this.Controls.Add(this.mv_NV);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txt_TenNV);
            this.Name = "uct_NhanVien";
            this.Size = new System.Drawing.Size(2518, 1044);
            this.Load += new System.EventHandler(this.uct_NhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mv_NV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_NV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TenNV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MK.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TenDN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdo_GT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cke_TrangThai.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btn_LuuNV;
        private DevExpress.XtraEditors.SimpleButton btn_RefreshNV;
        private DevExpress.XtraEditors.SimpleButton btn_SuaNV;
        private DevExpress.XtraEditors.SimpleButton btn_ThemNV;
        private DevExpress.XtraGrid.GridControl mv_NV;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_NV;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txt_TenNV;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txt_MK;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txt_TenDN;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.RadioGroup rdo_GT;
        private DevExpress.XtraEditors.CheckEdit cke_TrangThai;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private ThietKeControl.txt_SDT txt_SDT;

    }
}
