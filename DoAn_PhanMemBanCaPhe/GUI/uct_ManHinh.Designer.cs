namespace GUI
{
    partial class uct_ManHinh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uct_ManHinh));
            this.mv_MH = new DevExpress.XtraGrid.GridControl();
            this.gv_MH = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.btn_LuuMH = new DevExpress.XtraEditors.SimpleButton();
            this.btn_RefreshMH = new DevExpress.XtraEditors.SimpleButton();
            this.btn_SuaMH = new DevExpress.XtraEditors.SimpleButton();
            this.btn_XoaMH = new DevExpress.XtraEditors.SimpleButton();
            this.btn_ThemMH = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txt_TenMH = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.mv_MH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_MH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TenMH.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // mv_MH
            // 
            this.mv_MH.Location = new System.Drawing.Point(261, 121);
            this.mv_MH.MainView = this.gv_MH;
            this.mv_MH.Name = "mv_MH";
            this.mv_MH.Size = new System.Drawing.Size(742, 328);
            this.mv_MH.TabIndex = 76;
            this.mv_MH.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_MH});
            // 
            // gv_MH
            // 
            this.gv_MH.GridControl = this.mv_MH;
            this.gv_MH.Name = "gv_MH";
            this.gv_MH.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gv_MH_FocusedRowChanged);
            // 
            // textEdit1
            // 
            this.textEdit1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textEdit1.EditValue = "QUẢN LÝ MÀN HÌNH";
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
            // btn_LuuMH
            // 
            this.btn_LuuMH.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LuuMH.Appearance.Options.UseFont = true;
            this.btn_LuuMH.Image = ((System.Drawing.Image)(resources.GetObject("btn_LuuMH.Image")));
            this.btn_LuuMH.Location = new System.Drawing.Point(804, 75);
            this.btn_LuuMH.Name = "btn_LuuMH";
            this.btn_LuuMH.Size = new System.Drawing.Size(79, 33);
            this.btn_LuuMH.TabIndex = 81;
            this.btn_LuuMH.Text = "Lưu";
            this.btn_LuuMH.Click += new System.EventHandler(this.btn_LuuMH_Click);
            // 
            // btn_RefreshMH
            // 
            this.btn_RefreshMH.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RefreshMH.Appearance.Options.UseFont = true;
            this.btn_RefreshMH.Image = ((System.Drawing.Image)(resources.GetObject("btn_RefreshMH.Image")));
            this.btn_RefreshMH.Location = new System.Drawing.Point(901, 75);
            this.btn_RefreshMH.Name = "btn_RefreshMH";
            this.btn_RefreshMH.Size = new System.Drawing.Size(102, 33);
            this.btn_RefreshMH.TabIndex = 80;
            this.btn_RefreshMH.Text = "Refresh";
            this.btn_RefreshMH.Click += new System.EventHandler(this.btn_RefreshMH_Click);
            // 
            // btn_SuaMH
            // 
            this.btn_SuaMH.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SuaMH.Appearance.Options.UseFont = true;
            this.btn_SuaMH.Image = ((System.Drawing.Image)(resources.GetObject("btn_SuaMH.Image")));
            this.btn_SuaMH.Location = new System.Drawing.Point(593, 75);
            this.btn_SuaMH.Name = "btn_SuaMH";
            this.btn_SuaMH.Size = new System.Drawing.Size(83, 33);
            this.btn_SuaMH.TabIndex = 79;
            this.btn_SuaMH.Text = "Sửa";
            this.btn_SuaMH.Click += new System.EventHandler(this.btn_SuaMH_Click);
            // 
            // btn_XoaMH
            // 
            this.btn_XoaMH.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XoaMH.Appearance.Options.UseFont = true;
            this.btn_XoaMH.Image = ((System.Drawing.Image)(resources.GetObject("btn_XoaMH.Image")));
            this.btn_XoaMH.Location = new System.Drawing.Point(695, 75);
            this.btn_XoaMH.Name = "btn_XoaMH";
            this.btn_XoaMH.Size = new System.Drawing.Size(85, 33);
            this.btn_XoaMH.TabIndex = 78;
            this.btn_XoaMH.Text = "Xóa";
            this.btn_XoaMH.Click += new System.EventHandler(this.btn_XoaMH_Click);
            // 
            // btn_ThemMH
            // 
            this.btn_ThemMH.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThemMH.Appearance.Options.UseFont = true;
            this.btn_ThemMH.Image = ((System.Drawing.Image)(resources.GetObject("btn_ThemMH.Image")));
            this.btn_ThemMH.Location = new System.Drawing.Point(481, 75);
            this.btn_ThemMH.Name = "btn_ThemMH";
            this.btn_ThemMH.Size = new System.Drawing.Size(85, 33);
            this.btn_ThemMH.TabIndex = 77;
            this.btn_ThemMH.Text = "Thêm";
            this.btn_ThemMH.Click += new System.EventHandler(this.btn_ThemMH_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(261, 56);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(99, 19);
            this.labelControl1.TabIndex = 75;
            this.labelControl1.Text = "Tên màn hình";
            // 
            // txt_TenMH
            // 
            this.txt_TenMH.Location = new System.Drawing.Point(261, 81);
            this.txt_TenMH.Name = "txt_TenMH";
            this.txt_TenMH.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenMH.Properties.Appearance.Options.UseFont = true;
            this.txt_TenMH.Size = new System.Drawing.Size(170, 26);
            this.txt_TenMH.TabIndex = 74;
            // 
            // uct_ManHinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mv_MH);
            this.Controls.Add(this.textEdit1);
            this.Controls.Add(this.btn_LuuMH);
            this.Controls.Add(this.btn_RefreshMH);
            this.Controls.Add(this.btn_SuaMH);
            this.Controls.Add(this.btn_XoaMH);
            this.Controls.Add(this.btn_ThemMH);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txt_TenMH);
            this.Name = "uct_ManHinh";
            this.Size = new System.Drawing.Size(2518, 1044);
            this.Load += new System.EventHandler(this.uct_ManHinh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mv_MH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_MH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TenMH.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl mv_MH;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_MH;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.SimpleButton btn_LuuMH;
        private DevExpress.XtraEditors.SimpleButton btn_RefreshMH;
        private DevExpress.XtraEditors.SimpleButton btn_SuaMH;
        private DevExpress.XtraEditors.SimpleButton btn_XoaMH;
        private DevExpress.XtraEditors.SimpleButton btn_ThemMH;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txt_TenMH;
    }
}
