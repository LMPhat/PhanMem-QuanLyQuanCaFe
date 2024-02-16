namespace GUI
{
    partial class uct_DatMon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uct_DatMon));
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.mv_ThucUong = new DevExpress.XtraGrid.GridControl();
            this.gv_ThucUong = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txt_TenTU = new DevExpress.XtraEditors.TextEdit();
            this.btn_GhiMon = new DevExpress.XtraEditors.SimpleButton();
            this.mv_ChiTietHD = new DevExpress.XtraGrid.GridControl();
            this.gv_ChiTietHD = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btn_XoaTU = new DevExpress.XtraEditors.SimpleButton();
            this.btn_RefreshDM = new DevExpress.XtraEditors.SimpleButton();
            this.lbl = new DevExpress.XtraEditors.LabelControl();
            this.btn_ThanhToan = new DevExpress.XtraEditors.SimpleButton();
            this.btn_TimKiem = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txt_TenTU_TK = new DevExpress.XtraEditors.TextEdit();
            this.lbl_TongTien = new DevExpress.XtraEditors.LabelControl();
            this.lku_Loai = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txt_SoLuong = new ThietKeControl.txt_SoLuong();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mv_ThucUong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_ThucUong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TenTU.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mv_ChiTietHD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_ChiTietHD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TenTU_TK.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lku_Loai.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // textEdit1
            // 
            this.textEdit1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textEdit1.EditValue = "ĐẶT MÓN";
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
            this.textEdit1.TabIndex = 47;
            // 
            // mv_ThucUong
            // 
            this.mv_ThucUong.Location = new System.Drawing.Point(160, 213);
            this.mv_ThucUong.MainView = this.gv_ThucUong;
            this.mv_ThucUong.Name = "mv_ThucUong";
            this.mv_ThucUong.Size = new System.Drawing.Size(519, 331);
            this.mv_ThucUong.TabIndex = 48;
            this.mv_ThucUong.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_ThucUong});
            // 
            // gv_ThucUong
            // 
            this.gv_ThucUong.GridControl = this.mv_ThucUong;
            this.gv_ThucUong.Name = "gv_ThucUong";
            this.gv_ThucUong.OptionsSelection.EnableAppearanceFocusedRow = false;
            this.gv_ThucUong.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gv_ThucUong_FocusedRowChanged);
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Location = new System.Drawing.Point(160, 46);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit1.Size = new System.Drawing.Size(207, 119);
            this.pictureEdit1.TabIndex = 49;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Location = new System.Drawing.Point(384, 175);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(64, 19);
            this.labelControl3.TabIndex = 51;
            this.labelControl3.Text = "Số lượng";
            // 
            // txt_TenTU
            // 
            this.txt_TenTU.Enabled = false;
            this.txt_TenTU.Location = new System.Drawing.Point(160, 172);
            this.txt_TenTU.Margin = new System.Windows.Forms.Padding(4);
            this.txt_TenTU.Name = "txt_TenTU";
            this.txt_TenTU.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenTU.Properties.Appearance.ForeColor = System.Drawing.Color.Green;
            this.txt_TenTU.Properties.Appearance.Options.UseFont = true;
            this.txt_TenTU.Properties.Appearance.Options.UseForeColor = true;
            this.txt_TenTU.Size = new System.Drawing.Size(207, 26);
            this.txt_TenTU.TabIndex = 52;
            // 
            // btn_GhiMon
            // 
            this.btn_GhiMon.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GhiMon.Appearance.Options.UseFont = true;
            this.btn_GhiMon.Image = ((System.Drawing.Image)(resources.GetObject("btn_GhiMon.Image")));
            this.btn_GhiMon.Location = new System.Drawing.Point(554, 168);
            this.btn_GhiMon.Name = "btn_GhiMon";
            this.btn_GhiMon.Size = new System.Drawing.Size(125, 33);
            this.btn_GhiMon.TabIndex = 53;
            this.btn_GhiMon.Text = "Ghi Món";
            this.btn_GhiMon.Click += new System.EventHandler(this.btn_GhiMon_Click);
            // 
            // mv_ChiTietHD
            // 
            this.mv_ChiTietHD.Location = new System.Drawing.Point(702, 213);
            this.mv_ChiTietHD.MainView = this.gv_ChiTietHD;
            this.mv_ChiTietHD.Name = "mv_ChiTietHD";
            this.mv_ChiTietHD.Size = new System.Drawing.Size(519, 219);
            this.mv_ChiTietHD.TabIndex = 54;
            this.mv_ChiTietHD.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_ChiTietHD});
            // 
            // gv_ChiTietHD
            // 
            this.gv_ChiTietHD.GridControl = this.mv_ChiTietHD;
            this.gv_ChiTietHD.Name = "gv_ChiTietHD";
            this.gv_ChiTietHD.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gv_ChiTietHD.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
            this.gv_ChiTietHD.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            // 
            // btn_XoaTU
            // 
            this.btn_XoaTU.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XoaTU.Appearance.Options.UseFont = true;
            this.btn_XoaTU.Image = ((System.Drawing.Image)(resources.GetObject("btn_XoaTU.Image")));
            this.btn_XoaTU.Location = new System.Drawing.Point(1009, 168);
            this.btn_XoaTU.Name = "btn_XoaTU";
            this.btn_XoaTU.Size = new System.Drawing.Size(85, 33);
            this.btn_XoaTU.TabIndex = 55;
            this.btn_XoaTU.Text = "Xóa";
            this.btn_XoaTU.Click += new System.EventHandler(this.btn_XoaTU_Click);
            // 
            // btn_RefreshDM
            // 
            this.btn_RefreshDM.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RefreshDM.Appearance.Options.UseFont = true;
            this.btn_RefreshDM.Image = ((System.Drawing.Image)(resources.GetObject("btn_RefreshDM.Image")));
            this.btn_RefreshDM.Location = new System.Drawing.Point(1119, 168);
            this.btn_RefreshDM.Name = "btn_RefreshDM";
            this.btn_RefreshDM.Size = new System.Drawing.Size(102, 33);
            this.btn_RefreshDM.TabIndex = 56;
            this.btn_RefreshDM.Text = "Refresh";
            this.btn_RefreshDM.Click += new System.EventHandler(this.btn_RefreshDM_Click);
            // 
            // lbl
            // 
            this.lbl.Appearance.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.lbl.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lbl.Location = new System.Drawing.Point(986, 450);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(108, 23);
            this.lbl.TabIndex = 57;
            this.lbl.Text = "Tổng Tiền: ";
            // 
            // btn_ThanhToan
            // 
            this.btn_ThanhToan.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThanhToan.Appearance.Options.UseFont = true;
            this.btn_ThanhToan.Image = ((System.Drawing.Image)(resources.GetObject("btn_ThanhToan.Image")));
            this.btn_ThanhToan.Location = new System.Drawing.Point(986, 492);
            this.btn_ThanhToan.Name = "btn_ThanhToan";
            this.btn_ThanhToan.Size = new System.Drawing.Size(142, 33);
            this.btn_ThanhToan.TabIndex = 58;
            this.btn_ThanhToan.Text = "Thanh Toán";
            this.btn_ThanhToan.Click += new System.EventHandler(this.btn_ThanhToan_Click);
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TimKiem.Appearance.Options.UseFont = true;
            this.btn_TimKiem.Image = ((System.Drawing.Image)(resources.GetObject("btn_TimKiem.Image")));
            this.btn_TimKiem.Location = new System.Drawing.Point(702, 53);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(125, 33);
            this.btn_TimKiem.TabIndex = 61;
            this.btn_TimKiem.Text = "Tìm Kiếm";
            this.btn_TimKiem.Click += new System.EventHandler(this.btn_TimKiem_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(384, 64);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(104, 19);
            this.labelControl2.TabIndex = 60;
            this.labelControl2.Text = "Tên thức uống";
            // 
            // txt_TenTU_TK
            // 
            this.txt_TenTU_TK.Location = new System.Drawing.Point(496, 57);
            this.txt_TenTU_TK.Margin = new System.Windows.Forms.Padding(4);
            this.txt_TenTU_TK.Name = "txt_TenTU_TK";
            this.txt_TenTU_TK.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenTU_TK.Properties.Appearance.Options.UseFont = true;
            this.txt_TenTU_TK.Size = new System.Drawing.Size(183, 26);
            this.txt_TenTU_TK.TabIndex = 59;
            // 
            // lbl_TongTien
            // 
            this.lbl_TongTien.Appearance.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.lbl_TongTien.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lbl_TongTien.Location = new System.Drawing.Point(1100, 450);
            this.lbl_TongTien.Name = "lbl_TongTien";
            this.lbl_TongTien.Size = new System.Drawing.Size(60, 23);
            this.lbl_TongTien.TabIndex = 62;
            this.lbl_TongTien.Text = "0 VND";
            // 
            // lku_Loai
            // 
            this.lku_Loai.Location = new System.Drawing.Point(496, 100);
            this.lku_Loai.Margin = new System.Windows.Forms.Padding(4);
            this.lku_Loai.Name = "lku_Loai";
            this.lku_Loai.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lku_Loai.Properties.Appearance.Options.UseFont = true;
            this.lku_Loai.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lku_Loai.Size = new System.Drawing.Size(183, 26);
            this.lku_Loai.TabIndex = 63;
            this.lku_Loai.EditValueChanged += new System.EventHandler(this.lku_Loai_EditValueChanged);
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Location = new System.Drawing.Point(384, 103);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(106, 19);
            this.labelControl5.TabIndex = 64;
            this.labelControl5.Text = "Loại thức uống";
            // 
            // txt_SoLuong
            // 
            this.txt_SoLuong.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txt_SoLuong.Location = new System.Drawing.Point(455, 172);
            this.txt_SoLuong.Name = "txt_SoLuong";
            this.txt_SoLuong.Size = new System.Drawing.Size(71, 27);
            this.txt_SoLuong.TabIndex = 65;
            // 
            // uct_DatMon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txt_SoLuong);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.lku_Loai);
            this.Controls.Add(this.lbl_TongTien);
            this.Controls.Add(this.btn_TimKiem);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txt_TenTU_TK);
            this.Controls.Add(this.btn_ThanhToan);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.btn_RefreshDM);
            this.Controls.Add(this.btn_XoaTU);
            this.Controls.Add(this.mv_ChiTietHD);
            this.Controls.Add(this.btn_GhiMon);
            this.Controls.Add(this.txt_TenTU);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.mv_ThucUong);
            this.Controls.Add(this.textEdit1);
            this.Name = "uct_DatMon";
            this.Size = new System.Drawing.Size(2518, 1044);
            this.Load += new System.EventHandler(this.uct_DatMon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mv_ThucUong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_ThucUong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TenTU.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mv_ChiTietHD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_ChiTietHD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TenTU_TK.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lku_Loai.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraGrid.GridControl mv_ThucUong;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_ThucUong;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txt_TenTU;
        private DevExpress.XtraEditors.SimpleButton btn_GhiMon;
        private DevExpress.XtraGrid.GridControl mv_ChiTietHD;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_ChiTietHD;
        private DevExpress.XtraEditors.SimpleButton btn_XoaTU;
        private DevExpress.XtraEditors.SimpleButton btn_RefreshDM;
        private DevExpress.XtraEditors.LabelControl lbl;
        private DevExpress.XtraEditors.SimpleButton btn_ThanhToan;
        private DevExpress.XtraEditors.SimpleButton btn_TimKiem;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txt_TenTU_TK;
        private DevExpress.XtraEditors.LabelControl lbl_TongTien;
        private DevExpress.XtraEditors.LookUpEdit lku_Loai;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private ThietKeControl.txt_SoLuong txt_SoLuong;
    }
}
