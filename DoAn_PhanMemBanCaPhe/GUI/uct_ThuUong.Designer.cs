namespace GUI
{
    partial class uct_ThuUong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uct_ThuUong));
            this.txt_TenTU = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.lku_Loai = new DevExpress.XtraEditors.LookUpEdit();
            this.mv_ThucUong = new DevExpress.XtraGrid.GridControl();
            this.gv_ThucUong = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btn_LuuTU = new DevExpress.XtraEditors.SimpleButton();
            this.btn_RefreshTU = new DevExpress.XtraEditors.SimpleButton();
            this.btn_SuaTU = new DevExpress.XtraEditors.SimpleButton();
            this.btn_ThemTU = new DevExpress.XtraEditors.SimpleButton();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.cke_TrangThai = new DevExpress.XtraEditors.CheckEdit();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.txt_SoLuong = new ThietKeControl.txt_SoLuong();
            this.txt_DonGia = new ThietKeControl.txt_DonGia();
            this.btn_XoaTU = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TenTU.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lku_Loai.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mv_ThucUong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_ThucUong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cke_TrangThai.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_TenTU
            // 
            this.txt_TenTU.Location = new System.Drawing.Point(540, 76);
            this.txt_TenTU.Margin = new System.Windows.Forms.Padding(4);
            this.txt_TenTU.Name = "txt_TenTU";
            this.txt_TenTU.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenTU.Properties.Appearance.Options.UseFont = true;
            this.txt_TenTU.Size = new System.Drawing.Size(289, 26);
            this.txt_TenTU.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(417, 80);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(104, 19);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Tên thức uống";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Location = new System.Drawing.Point(886, 80);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(64, 19);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Số lượng";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Location = new System.Drawing.Point(886, 124);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(55, 19);
            this.labelControl4.TabIndex = 6;
            this.labelControl4.Text = "Đơn giá";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Location = new System.Drawing.Point(417, 124);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(106, 19);
            this.labelControl5.TabIndex = 8;
            this.labelControl5.Text = "Loại thức uống";
            // 
            // lku_Loai
            // 
            this.lku_Loai.Location = new System.Drawing.Point(540, 120);
            this.lku_Loai.Margin = new System.Windows.Forms.Padding(4);
            this.lku_Loai.Name = "lku_Loai";
            this.lku_Loai.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lku_Loai.Properties.Appearance.Options.UseFont = true;
            this.lku_Loai.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lku_Loai.Size = new System.Drawing.Size(289, 26);
            this.lku_Loai.TabIndex = 9;
            // 
            // mv_ThucUong
            // 
            this.mv_ThucUong.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.mv_ThucUong.Location = new System.Drawing.Point(59, 269);
            this.mv_ThucUong.MainView = this.gv_ThucUong;
            this.mv_ThucUong.Margin = new System.Windows.Forms.Padding(4);
            this.mv_ThucUong.Name = "mv_ThucUong";
            this.mv_ThucUong.Size = new System.Drawing.Size(1208, 291);
            this.mv_ThucUong.TabIndex = 10;
            this.mv_ThucUong.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_ThucUong});
            // 
            // gv_ThucUong
            // 
            this.gv_ThucUong.GridControl = this.mv_ThucUong;
            this.gv_ThucUong.Name = "gv_ThucUong";
            this.gv_ThucUong.ShownEditor += new System.EventHandler(this.gv_ThucUong_ShownEditor);
            this.gv_ThucUong.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gv_ThucUong_FocusedRowChanged);
            // 
            // btn_LuuTU
            // 
            this.btn_LuuTU.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LuuTU.Appearance.Options.UseFont = true;
            this.btn_LuuTU.Image = ((System.Drawing.Image)(resources.GetObject("btn_LuuTU.Image")));
            this.btn_LuuTU.Location = new System.Drawing.Point(1067, 202);
            this.btn_LuuTU.Name = "btn_LuuTU";
            this.btn_LuuTU.Size = new System.Drawing.Size(79, 33);
            this.btn_LuuTU.TabIndex = 31;
            this.btn_LuuTU.Text = "Lưu";
            this.btn_LuuTU.Click += new System.EventHandler(this.btn_LuuTU_Click);
            // 
            // btn_RefreshTU
            // 
            this.btn_RefreshTU.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RefreshTU.Appearance.Options.UseFont = true;
            this.btn_RefreshTU.Image = ((System.Drawing.Image)(resources.GetObject("btn_RefreshTU.Image")));
            this.btn_RefreshTU.Location = new System.Drawing.Point(1164, 202);
            this.btn_RefreshTU.Name = "btn_RefreshTU";
            this.btn_RefreshTU.Size = new System.Drawing.Size(102, 33);
            this.btn_RefreshTU.TabIndex = 30;
            this.btn_RefreshTU.Text = "Refresh";
            this.btn_RefreshTU.Click += new System.EventHandler(this.btn_RefreshTU_Click);
            // 
            // btn_SuaTU
            // 
            this.btn_SuaTU.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SuaTU.Appearance.Options.UseFont = true;
            this.btn_SuaTU.Image = ((System.Drawing.Image)(resources.GetObject("btn_SuaTU.Image")));
            this.btn_SuaTU.Location = new System.Drawing.Point(856, 202);
            this.btn_SuaTU.Name = "btn_SuaTU";
            this.btn_SuaTU.Size = new System.Drawing.Size(83, 33);
            this.btn_SuaTU.TabIndex = 29;
            this.btn_SuaTU.Text = "Sửa";
            this.btn_SuaTU.Click += new System.EventHandler(this.btn_SuaTU_Click);
            // 
            // btn_ThemTU
            // 
            this.btn_ThemTU.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThemTU.Appearance.Options.UseFont = true;
            this.btn_ThemTU.Image = ((System.Drawing.Image)(resources.GetObject("btn_ThemTU.Image")));
            this.btn_ThemTU.Location = new System.Drawing.Point(744, 202);
            this.btn_ThemTU.Name = "btn_ThemTU";
            this.btn_ThemTU.Size = new System.Drawing.Size(85, 33);
            this.btn_ThemTU.TabIndex = 27;
            this.btn_ThemTU.Text = "Thêm";
            this.btn_ThemTU.Click += new System.EventHandler(this.btn_ThemTU_Click);
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Location = new System.Drawing.Point(59, 75);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit1.Size = new System.Drawing.Size(295, 187);
            this.pictureEdit1.TabIndex = 34;
            this.pictureEdit1.Click += new System.EventHandler(this.pictureEdit1_Click);
            // 
            // cke_TrangThai
            // 
            this.cke_TrangThai.Location = new System.Drawing.Point(417, 167);
            this.cke_TrangThai.Name = "cke_TrangThai";
            this.cke_TrangThai.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.cke_TrangThai.Properties.Appearance.Options.UseFont = true;
            this.cke_TrangThai.Properties.Caption = "Trạng thái hoạt động";
            this.cke_TrangThai.Size = new System.Drawing.Size(180, 23);
            this.cke_TrangThai.TabIndex = 45;
            // 
            // textEdit1
            // 
            this.textEdit1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textEdit1.EditValue = "QUẢN LÝ THỨC UỐNG";
            this.textEdit1.Enabled = false;
            this.textEdit1.Location = new System.Drawing.Point(0, 0);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Olive;
            this.textEdit1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 16F);
            this.textEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.textEdit1.Properties.Appearance.Options.UseFont = true;
            this.textEdit1.Properties.Appearance.Options.UseForeColor = true;
            this.textEdit1.Size = new System.Drawing.Size(4208, 32);
            this.textEdit1.TabIndex = 46;
            // 
            // txt_SoLuong
            // 
            this.txt_SoLuong.Location = new System.Drawing.Point(977, 77);
            this.txt_SoLuong.Name = "txt_SoLuong";
            this.txt_SoLuong.Size = new System.Drawing.Size(289, 27);
            this.txt_SoLuong.TabIndex = 47;
            // 
            // txt_DonGia
            // 
            this.txt_DonGia.Location = new System.Drawing.Point(977, 120);
            this.txt_DonGia.Name = "txt_DonGia";
            this.txt_DonGia.Size = new System.Drawing.Size(289, 27);
            this.txt_DonGia.TabIndex = 48;
            // 
            // btn_XoaTU
            // 
            this.btn_XoaTU.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XoaTU.Appearance.Options.UseFont = true;
            this.btn_XoaTU.Image = ((System.Drawing.Image)(resources.GetObject("btn_XoaTU.Image")));
            this.btn_XoaTU.Location = new System.Drawing.Point(962, 202);
            this.btn_XoaTU.Name = "btn_XoaTU";
            this.btn_XoaTU.Size = new System.Drawing.Size(85, 33);
            this.btn_XoaTU.TabIndex = 49;
            this.btn_XoaTU.Text = "Xóa";
            this.btn_XoaTU.Click += new System.EventHandler(this.btn_XoaTU_Click);
            // 
            // uct_ThuUong
            // 
            this.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_XoaTU);
            this.Controls.Add(this.txt_DonGia);
            this.Controls.Add(this.txt_SoLuong);
            this.Controls.Add(this.textEdit1);
            this.Controls.Add(this.cke_TrangThai);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.btn_LuuTU);
            this.Controls.Add(this.btn_RefreshTU);
            this.Controls.Add(this.btn_SuaTU);
            this.Controls.Add(this.btn_ThemTU);
            this.Controls.Add(this.mv_ThucUong);
            this.Controls.Add(this.lku_Loai);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txt_TenTU);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "uct_ThuUong";
            this.Size = new System.Drawing.Size(4208, 1526);
            this.Load += new System.EventHandler(this.uct_ThuUong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txt_TenTU.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lku_Loai.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mv_ThucUong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_ThucUong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cke_TrangThai.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txt_TenTU;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LookUpEdit lku_Loai;
        private DevExpress.XtraGrid.GridControl mv_ThucUong;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_ThucUong;
        private DevExpress.XtraEditors.SimpleButton btn_LuuTU;
        private DevExpress.XtraEditors.SimpleButton btn_RefreshTU;
        private DevExpress.XtraEditors.SimpleButton btn_SuaTU;
        private DevExpress.XtraEditors.SimpleButton btn_ThemTU;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.CheckEdit cke_TrangThai;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private ThietKeControl.txt_SoLuong txt_SoLuong;
        private ThietKeControl.txt_DonGia txt_DonGia;
        private DevExpress.XtraEditors.SimpleButton btn_XoaTU;

    }
}
