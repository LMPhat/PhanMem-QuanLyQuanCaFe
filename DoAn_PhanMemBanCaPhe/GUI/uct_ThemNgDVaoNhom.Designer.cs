namespace GUI
{
    partial class uct_ThemNgDVaoNhom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uct_ThemNgDVaoNhom));
            this.mv_ND = new DevExpress.XtraGrid.GridControl();
            this.gv_ND = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.mv_NgDTrongNhom = new DevExpress.XtraGrid.GridControl();
            this.gv_NgDTrongNhom = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.lku_NhomNgD = new DevExpress.XtraEditors.LookUpEdit();
            this.pte_ThemVaoNhom = new DevExpress.XtraEditors.PictureEdit();
            this.pte_XoaKhoiNhom = new DevExpress.XtraEditors.PictureEdit();
            this.btn_RefreshNDNhomND = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.mv_ND)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_ND)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mv_NgDTrongNhom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_NgDTrongNhom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lku_NhomNgD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pte_ThemVaoNhom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pte_XoaKhoiNhom.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // mv_ND
            // 
            this.mv_ND.Location = new System.Drawing.Point(186, 103);
            this.mv_ND.MainView = this.gv_ND;
            this.mv_ND.Name = "mv_ND";
            this.mv_ND.Size = new System.Drawing.Size(441, 352);
            this.mv_ND.TabIndex = 76;
            this.mv_ND.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_ND});
            // 
            // gv_ND
            // 
            this.gv_ND.GridControl = this.mv_ND;
            this.gv_ND.Name = "gv_ND";
            // 
            // textEdit1
            // 
            this.textEdit1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textEdit1.EditValue = "THÊM NGƯỜI DÙNG VÀO NHÓM NGƯỜI DÙNG";
            this.textEdit1.Enabled = false;
            this.textEdit1.Location = new System.Drawing.Point(0, 0);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Olive;
            this.textEdit1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 16F);
            this.textEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.textEdit1.Properties.Appearance.Options.UseFont = true;
            this.textEdit1.Properties.Appearance.Options.UseForeColor = true;
            this.textEdit1.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textEdit1.Size = new System.Drawing.Size(2518, 32);
            this.textEdit1.TabIndex = 82;
            // 
            // mv_NgDTrongNhom
            // 
            this.mv_NgDTrongNhom.Location = new System.Drawing.Point(730, 103);
            this.mv_NgDTrongNhom.MainView = this.gv_NgDTrongNhom;
            this.mv_NgDTrongNhom.Name = "mv_NgDTrongNhom";
            this.mv_NgDTrongNhom.Size = new System.Drawing.Size(441, 352);
            this.mv_NgDTrongNhom.TabIndex = 83;
            this.mv_NgDTrongNhom.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_NgDTrongNhom});
            // 
            // gv_NgDTrongNhom
            // 
            this.gv_NgDTrongNhom.GridControl = this.mv_NgDTrongNhom;
            this.gv_NgDTrongNhom.Name = "gv_NgDTrongNhom";
            // 
            // lku_NhomNgD
            // 
            this.lku_NhomNgD.Location = new System.Drawing.Point(730, 51);
            this.lku_NhomNgD.Margin = new System.Windows.Forms.Padding(4);
            this.lku_NhomNgD.Name = "lku_NhomNgD";
            this.lku_NhomNgD.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lku_NhomNgD.Properties.Appearance.Options.UseFont = true;
            this.lku_NhomNgD.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lku_NhomNgD.Size = new System.Drawing.Size(217, 26);
            this.lku_NhomNgD.TabIndex = 84;
            this.lku_NhomNgD.EditValueChanged += new System.EventHandler(this.lku_NhomNgD_EditValueChanged);
            // 
            // pte_ThemVaoNhom
            // 
            this.pte_ThemVaoNhom.EditValue = ((object)(resources.GetObject("pte_ThemVaoNhom.EditValue")));
            this.pte_ThemVaoNhom.Location = new System.Drawing.Point(634, 205);
            this.pte_ThemVaoNhom.Name = "pte_ThemVaoNhom";
            this.pte_ThemVaoNhom.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pte_ThemVaoNhom.Properties.Appearance.Options.UseBackColor = true;
            this.pte_ThemVaoNhom.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pte_ThemVaoNhom.Size = new System.Drawing.Size(90, 44);
            this.pte_ThemVaoNhom.TabIndex = 85;
            this.pte_ThemVaoNhom.Click += new System.EventHandler(this.pte_ThemVaoNhom_Click);
            // 
            // pte_XoaKhoiNhom
            // 
            this.pte_XoaKhoiNhom.EditValue = ((object)(resources.GetObject("pte_XoaKhoiNhom.EditValue")));
            this.pte_XoaKhoiNhom.Location = new System.Drawing.Point(634, 288);
            this.pte_XoaKhoiNhom.Name = "pte_XoaKhoiNhom";
            this.pte_XoaKhoiNhom.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pte_XoaKhoiNhom.Properties.Appearance.Options.UseBackColor = true;
            this.pte_XoaKhoiNhom.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pte_XoaKhoiNhom.Size = new System.Drawing.Size(90, 44);
            this.pte_XoaKhoiNhom.TabIndex = 86;
            this.pte_XoaKhoiNhom.Click += new System.EventHandler(this.pte_XoaKhoiNhom_Click);
            // 
            // btn_RefreshNDNhomND
            // 
            this.btn_RefreshNDNhomND.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RefreshNDNhomND.Appearance.Options.UseFont = true;
            this.btn_RefreshNDNhomND.Image = ((System.Drawing.Image)(resources.GetObject("btn_RefreshNDNhomND.Image")));
            this.btn_RefreshNDNhomND.Location = new System.Drawing.Point(1069, 47);
            this.btn_RefreshNDNhomND.Name = "btn_RefreshNDNhomND";
            this.btn_RefreshNDNhomND.Size = new System.Drawing.Size(102, 33);
            this.btn_RefreshNDNhomND.TabIndex = 87;
            this.btn_RefreshNDNhomND.Text = "Refresh";
            this.btn_RefreshNDNhomND.Click += new System.EventHandler(this.btn_RefreshNDNhomND_Click);
            // 
            // uct_ThemNgDVaoNhom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_RefreshNDNhomND);
            this.Controls.Add(this.pte_XoaKhoiNhom);
            this.Controls.Add(this.pte_ThemVaoNhom);
            this.Controls.Add(this.lku_NhomNgD);
            this.Controls.Add(this.mv_NgDTrongNhom);
            this.Controls.Add(this.mv_ND);
            this.Controls.Add(this.textEdit1);
            this.Name = "uct_ThemNgDVaoNhom";
            this.Size = new System.Drawing.Size(2518, 1044);
            this.Load += new System.EventHandler(this.uct_ThemNgDVaoNhom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mv_ND)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_ND)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mv_NgDTrongNhom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_NgDTrongNhom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lku_NhomNgD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pte_ThemVaoNhom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pte_XoaKhoiNhom.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl mv_ND;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_ND;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraGrid.GridControl mv_NgDTrongNhom;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_NgDTrongNhom;
        private DevExpress.XtraEditors.LookUpEdit lku_NhomNgD;
        private DevExpress.XtraEditors.PictureEdit pte_ThemVaoNhom;
        private DevExpress.XtraEditors.PictureEdit pte_XoaKhoiNhom;
        private DevExpress.XtraEditors.SimpleButton btn_RefreshNDNhomND;
    }
}
