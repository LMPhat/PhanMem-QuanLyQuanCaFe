namespace GUI
{
    partial class uct_KhachHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uct_KhachHang));
            this.cke_TrangThai = new DevExpress.XtraEditors.CheckEdit();
            this.rdo_GT = new DevExpress.XtraEditors.RadioGroup();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txt_MK = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txt_TenDN = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.gv_KH = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.mv_KH = new DevExpress.XtraGrid.GridControl();
            this.txt_SDT = new DevExpress.XtraEditors.TextEdit();
            this.btn_RefreshKH = new DevExpress.XtraEditors.SimpleButton();
            this.btn_SuaKH = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txt_TenKH = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txt_DiaChi = new DevExpress.XtraEditors.TextEdit();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.cke_TrangThai.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdo_GT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MK.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TenDN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_KH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mv_KH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_SDT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TenKH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_DiaChi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // cke_TrangThai
            // 
            this.cke_TrangThai.Location = new System.Drawing.Point(240, 185);
            this.cke_TrangThai.Name = "cke_TrangThai";
            this.cke_TrangThai.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.cke_TrangThai.Properties.Appearance.Options.UseFont = true;
            this.cke_TrangThai.Properties.Caption = "Trạng thái hoạt động";
            this.cke_TrangThai.Size = new System.Drawing.Size(180, 23);
            this.cke_TrangThai.TabIndex = 60;
            // 
            // rdo_GT
            // 
            this.rdo_GT.Location = new System.Drawing.Point(565, 103);
            this.rdo_GT.Name = "rdo_GT";
            this.rdo_GT.Properties.Appearance.BackColor = System.Drawing.SystemColors.ControlLight;
            this.rdo_GT.Properties.Appearance.Options.UseBackColor = true;
            this.rdo_GT.Properties.Columns = 2;
            this.rdo_GT.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem("NAM", "Nam"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("NỮ", "Nữ")});
            this.rdo_GT.Size = new System.Drawing.Size(133, 33);
            this.rdo_GT.TabIndex = 59;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Location = new System.Drawing.Point(565, 78);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(60, 19);
            this.labelControl5.TabIndex = 58;
            this.labelControl5.Text = "Giới tính";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Location = new System.Drawing.Point(755, 117);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(64, 19);
            this.labelControl3.TabIndex = 57;
            this.labelControl3.Text = "Mật khẩu";
            // 
            // txt_MK
            // 
            this.txt_MK.Location = new System.Drawing.Point(876, 110);
            this.txt_MK.Name = "txt_MK";
            this.txt_MK.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MK.Properties.Appearance.Options.UseFont = true;
            this.txt_MK.Size = new System.Drawing.Size(170, 26);
            this.txt_MK.TabIndex = 56;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Location = new System.Drawing.Point(754, 78);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(107, 19);
            this.labelControl4.TabIndex = 55;
            this.labelControl4.Text = "Tên đăng nhập";
            // 
            // txt_TenDN
            // 
            this.txt_TenDN.Location = new System.Drawing.Point(876, 75);
            this.txt_TenDN.Name = "txt_TenDN";
            this.txt_TenDN.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenDN.Properties.Appearance.Options.UseFont = true;
            this.txt_TenDN.Size = new System.Drawing.Size(170, 26);
            this.txt_TenDN.TabIndex = 54;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(240, 117);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(93, 19);
            this.labelControl2.TabIndex = 53;
            this.labelControl2.Text = "Số điện thoại";
            // 
            // gv_KH
            // 
            this.gv_KH.GridControl = this.mv_KH;
            this.gv_KH.Name = "gv_KH";
            this.gv_KH.ShownEditor += new System.EventHandler(this.gv_KH_ShownEditor);
            this.gv_KH.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gv_KH_FocusedRowChanged);
            this.gv_KH.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gv_KH_CellValueChanged);
            // 
            // mv_KH
            // 
            this.mv_KH.Location = new System.Drawing.Point(240, 214);
            this.mv_KH.MainView = this.gv_KH;
            this.mv_KH.Name = "mv_KH";
            this.mv_KH.Size = new System.Drawing.Size(806, 300);
            this.mv_KH.TabIndex = 47;
            this.mv_KH.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_KH});
            // 
            // txt_SDT
            // 
            this.txt_SDT.Location = new System.Drawing.Point(359, 114);
            this.txt_SDT.Name = "txt_SDT";
            this.txt_SDT.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SDT.Properties.Appearance.Options.UseFont = true;
            this.txt_SDT.Size = new System.Drawing.Size(170, 26);
            this.txt_SDT.TabIndex = 52;
            // 
            // btn_RefreshKH
            // 
            this.btn_RefreshKH.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RefreshKH.Appearance.Options.UseFont = true;
            this.btn_RefreshKH.Image = ((System.Drawing.Image)(resources.GetObject("btn_RefreshKH.Image")));
            this.btn_RefreshKH.Location = new System.Drawing.Point(941, 160);
            this.btn_RefreshKH.Name = "btn_RefreshKH";
            this.btn_RefreshKH.Size = new System.Drawing.Size(102, 33);
            this.btn_RefreshKH.TabIndex = 50;
            this.btn_RefreshKH.Text = "Refresh";
            this.btn_RefreshKH.Click += new System.EventHandler(this.btn_RefreshKH_Click);
            // 
            // btn_SuaKH
            // 
            this.btn_SuaKH.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SuaKH.Appearance.Options.UseFont = true;
            this.btn_SuaKH.Image = ((System.Drawing.Image)(resources.GetObject("btn_SuaKH.Image")));
            this.btn_SuaKH.Location = new System.Drawing.Point(833, 160);
            this.btn_SuaKH.Name = "btn_SuaKH";
            this.btn_SuaKH.Size = new System.Drawing.Size(83, 33);
            this.btn_SuaKH.TabIndex = 49;
            this.btn_SuaKH.Text = "Sửa";
            this.btn_SuaKH.Click += new System.EventHandler(this.btn_SuaKH_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(239, 78);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(113, 19);
            this.labelControl1.TabIndex = 46;
            this.labelControl1.Text = "Tên khách hàng";
            // 
            // txt_TenKH
            // 
            this.txt_TenKH.Location = new System.Drawing.Point(358, 75);
            this.txt_TenKH.Name = "txt_TenKH";
            this.txt_TenKH.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenKH.Properties.Appearance.Options.UseFont = true;
            this.txt_TenKH.Size = new System.Drawing.Size(170, 26);
            this.txt_TenKH.TabIndex = 45;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Location = new System.Drawing.Point(240, 156);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(48, 19);
            this.labelControl6.TabIndex = 62;
            this.labelControl6.Text = "Địa chỉ";
            // 
            // txt_DiaChi
            // 
            this.txt_DiaChi.Location = new System.Drawing.Point(359, 153);
            this.txt_DiaChi.Name = "txt_DiaChi";
            this.txt_DiaChi.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DiaChi.Properties.Appearance.Options.UseFont = true;
            this.txt_DiaChi.Size = new System.Drawing.Size(170, 26);
            this.txt_DiaChi.TabIndex = 61;
            // 
            // textEdit1
            // 
            this.textEdit1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textEdit1.EditValue = "QUẢN LÝ KHÁCH HÀNG";
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
            this.textEdit1.TabIndex = 63;
            // 
            // uct_KhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textEdit1);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.txt_DiaChi);
            this.Controls.Add(this.cke_TrangThai);
            this.Controls.Add(this.rdo_GT);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txt_MK);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.txt_TenDN);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txt_SDT);
            this.Controls.Add(this.btn_RefreshKH);
            this.Controls.Add(this.btn_SuaKH);
            this.Controls.Add(this.mv_KH);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txt_TenKH);
            this.Name = "uct_KhachHang";
            this.Size = new System.Drawing.Size(2518, 1044);
            this.Load += new System.EventHandler(this.uct_KhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cke_TrangThai.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdo_GT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MK.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TenDN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_KH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mv_KH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_SDT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TenKH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_DiaChi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.CheckEdit cke_TrangThai;
        private DevExpress.XtraEditors.RadioGroup rdo_GT;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txt_MK;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txt_TenDN;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_KH;
        private DevExpress.XtraGrid.GridControl mv_KH;
        private DevExpress.XtraEditors.TextEdit txt_SDT;
        private DevExpress.XtraEditors.SimpleButton btn_RefreshKH;
        private DevExpress.XtraEditors.SimpleButton btn_SuaKH;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txt_TenKH;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txt_DiaChi;
        private DevExpress.XtraEditors.TextEdit textEdit1;
    }
}
