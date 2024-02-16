namespace GUI
{
    partial class uct_HoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uct_HoaDon));
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.gv_HD = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.mv_HD = new DevExpress.XtraGrid.GridControl();
            this.btn_RefreshHD = new DevExpress.XtraEditors.SimpleButton();
            this.btn_TimKiem = new DevExpress.XtraEditors.SimpleButton();
            this.txt_TK = new DevExpress.XtraEditors.TextEdit();
            this.rdo_LuaChonTK = new DevExpress.XtraEditors.RadioGroup();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_HD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mv_HD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TK.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdo_LuaChonTK.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // textEdit1
            // 
            this.textEdit1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textEdit1.EditValue = "HÓA ĐƠN";
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
            this.textEdit1.TabIndex = 48;
            // 
            // gv_HD
            // 
            this.gv_HD.GridControl = this.mv_HD;
            this.gv_HD.Name = "gv_HD";
            this.gv_HD.ShownEditor += new System.EventHandler(this.gv_HD_ShownEditor);
            // 
            // mv_HD
            // 
            this.mv_HD.Location = new System.Drawing.Point(313, 152);
            this.mv_HD.MainView = this.gv_HD;
            this.mv_HD.Name = "mv_HD";
            this.mv_HD.Size = new System.Drawing.Size(822, 292);
            this.mv_HD.TabIndex = 51;
            this.mv_HD.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_HD});
            // 
            // btn_RefreshHD
            // 
            this.btn_RefreshHD.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RefreshHD.Appearance.Options.UseFont = true;
            this.btn_RefreshHD.Image = ((System.Drawing.Image)(resources.GetObject("btn_RefreshHD.Image")));
            this.btn_RefreshHD.Location = new System.Drawing.Point(1033, 109);
            this.btn_RefreshHD.Name = "btn_RefreshHD";
            this.btn_RefreshHD.Size = new System.Drawing.Size(102, 33);
            this.btn_RefreshHD.TabIndex = 66;
            this.btn_RefreshHD.Text = "Refresh";
            this.btn_RefreshHD.Click += new System.EventHandler(this.btn_RefreshHD_Click);
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TimKiem.Appearance.Options.UseFont = true;
            this.btn_TimKiem.Image = ((System.Drawing.Image)(resources.GetObject("btn_TimKiem.Image")));
            this.btn_TimKiem.Location = new System.Drawing.Point(561, 111);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(125, 33);
            this.btn_TimKiem.TabIndex = 62;
            this.btn_TimKiem.Text = "Tìm Kiếm";
            this.btn_TimKiem.Click += new System.EventHandler(this.btn_TimKiem_Click);
            // 
            // txt_TK
            // 
            this.txt_TK.Location = new System.Drawing.Point(313, 113);
            this.txt_TK.Name = "txt_TK";
            this.txt_TK.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TK.Properties.Appearance.Options.UseFont = true;
            this.txt_TK.Size = new System.Drawing.Size(232, 26);
            this.txt_TK.TabIndex = 49;
            // 
            // rdo_LuaChonTK
            // 
            this.rdo_LuaChonTK.Location = new System.Drawing.Point(313, 76);
            this.rdo_LuaChonTK.Name = "rdo_LuaChonTK";
            this.rdo_LuaChonTK.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.rdo_LuaChonTK.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.rdo_LuaChonTK.Properties.Appearance.Options.UseBackColor = true;
            this.rdo_LuaChonTK.Properties.Appearance.Options.UseFont = true;
            this.rdo_LuaChonTK.Properties.Columns = 2;
            this.rdo_LuaChonTK.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem("KhachHang", "Khách Hàng"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("NhanVien", "Nhân Viên")});
            this.rdo_LuaChonTK.Size = new System.Drawing.Size(232, 30);
            this.rdo_LuaChonTK.TabIndex = 63;
            this.rdo_LuaChonTK.SelectedIndexChanged += new System.EventHandler(this.rdo_LuaChonTK_SelectedIndexChanged);
            // 
            // uct_HoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_RefreshHD);
            this.Controls.Add(this.rdo_LuaChonTK);
            this.Controls.Add(this.btn_TimKiem);
            this.Controls.Add(this.mv_HD);
            this.Controls.Add(this.txt_TK);
            this.Controls.Add(this.textEdit1);
            this.Name = "uct_HoaDon";
            this.Size = new System.Drawing.Size(2518, 1044);
            this.Load += new System.EventHandler(this.uct_HoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_HD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mv_HD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TK.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdo_LuaChonTK.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_HD;
        private DevExpress.XtraGrid.GridControl mv_HD;
        private DevExpress.XtraEditors.SimpleButton btn_RefreshHD;
        private DevExpress.XtraEditors.SimpleButton btn_TimKiem;
        private DevExpress.XtraEditors.TextEdit txt_TK;
        private DevExpress.XtraEditors.RadioGroup rdo_LuaChonTK;
    }
}
