namespace GUI
{
    partial class uct_NhomNgD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uct_NhomNgD));
            this.mv_NGD = new DevExpress.XtraGrid.GridControl();
            this.gv_NGD = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.btn_LuuNGD = new DevExpress.XtraEditors.SimpleButton();
            this.btn_RefreshNGD = new DevExpress.XtraEditors.SimpleButton();
            this.btn_SuaNGD = new DevExpress.XtraEditors.SimpleButton();
            this.btn_XoaNGD = new DevExpress.XtraEditors.SimpleButton();
            this.btn_ThemNGD = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txt_TenNGD = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.mv_NGD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_NGD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TenNGD.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // mv_NGD
            // 
            this.mv_NGD.Location = new System.Drawing.Point(262, 115);
            this.mv_NGD.MainView = this.gv_NGD;
            this.mv_NGD.Name = "mv_NGD";
            this.mv_NGD.Size = new System.Drawing.Size(742, 328);
            this.mv_NGD.TabIndex = 67;
            this.mv_NGD.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_NGD});
            // 
            // gv_NGD
            // 
            this.gv_NGD.GridControl = this.mv_NGD;
            this.gv_NGD.Name = "gv_NGD";
            this.gv_NGD.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gv_NGD_FocusedRowChanged);
            // 
            // textEdit1
            // 
            this.textEdit1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textEdit1.EditValue = "QUẢN LÝ NHÓM NGƯỜI DÙNG";
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
            this.textEdit1.TabIndex = 73;
            // 
            // btn_LuuNGD
            // 
            this.btn_LuuNGD.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LuuNGD.Appearance.Options.UseFont = true;
            this.btn_LuuNGD.Image = ((System.Drawing.Image)(resources.GetObject("btn_LuuNGD.Image")));
            this.btn_LuuNGD.Location = new System.Drawing.Point(805, 69);
            this.btn_LuuNGD.Name = "btn_LuuNGD";
            this.btn_LuuNGD.Size = new System.Drawing.Size(79, 33);
            this.btn_LuuNGD.TabIndex = 72;
            this.btn_LuuNGD.Text = "Lưu";
            this.btn_LuuNGD.Click += new System.EventHandler(this.btn_LuuNGD_Click);
            // 
            // btn_RefreshNGD
            // 
            this.btn_RefreshNGD.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RefreshNGD.Appearance.Options.UseFont = true;
            this.btn_RefreshNGD.Image = ((System.Drawing.Image)(resources.GetObject("btn_RefreshNGD.Image")));
            this.btn_RefreshNGD.Location = new System.Drawing.Point(902, 69);
            this.btn_RefreshNGD.Name = "btn_RefreshNGD";
            this.btn_RefreshNGD.Size = new System.Drawing.Size(102, 33);
            this.btn_RefreshNGD.TabIndex = 71;
            this.btn_RefreshNGD.Text = "Refresh";
            this.btn_RefreshNGD.Click += new System.EventHandler(this.btn_RefreshNGD_Click);
            // 
            // btn_SuaNGD
            // 
            this.btn_SuaNGD.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SuaNGD.Appearance.Options.UseFont = true;
            this.btn_SuaNGD.Image = ((System.Drawing.Image)(resources.GetObject("btn_SuaNGD.Image")));
            this.btn_SuaNGD.Location = new System.Drawing.Point(594, 69);
            this.btn_SuaNGD.Name = "btn_SuaNGD";
            this.btn_SuaNGD.Size = new System.Drawing.Size(83, 33);
            this.btn_SuaNGD.TabIndex = 70;
            this.btn_SuaNGD.Text = "Sửa";
            this.btn_SuaNGD.Click += new System.EventHandler(this.btn_SuaNGD_Click);
            // 
            // btn_XoaNGD
            // 
            this.btn_XoaNGD.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XoaNGD.Appearance.Options.UseFont = true;
            this.btn_XoaNGD.Image = ((System.Drawing.Image)(resources.GetObject("btn_XoaNGD.Image")));
            this.btn_XoaNGD.Location = new System.Drawing.Point(696, 69);
            this.btn_XoaNGD.Name = "btn_XoaNGD";
            this.btn_XoaNGD.Size = new System.Drawing.Size(85, 33);
            this.btn_XoaNGD.TabIndex = 69;
            this.btn_XoaNGD.Text = "Xóa";
            this.btn_XoaNGD.Click += new System.EventHandler(this.btn_XoaNGD_Click);
            // 
            // btn_ThemNGD
            // 
            this.btn_ThemNGD.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThemNGD.Appearance.Options.UseFont = true;
            this.btn_ThemNGD.Image = ((System.Drawing.Image)(resources.GetObject("btn_ThemNGD.Image")));
            this.btn_ThemNGD.Location = new System.Drawing.Point(482, 69);
            this.btn_ThemNGD.Name = "btn_ThemNGD";
            this.btn_ThemNGD.Size = new System.Drawing.Size(85, 33);
            this.btn_ThemNGD.TabIndex = 68;
            this.btn_ThemNGD.Text = "Thêm";
            this.btn_ThemNGD.Click += new System.EventHandler(this.btn_ThemNGD_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(262, 50);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(160, 19);
            this.labelControl1.TabIndex = 66;
            this.labelControl1.Text = "Tên nhóm người dùng";
            // 
            // txt_TenNGD
            // 
            this.txt_TenNGD.Location = new System.Drawing.Point(262, 75);
            this.txt_TenNGD.Name = "txt_TenNGD";
            this.txt_TenNGD.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenNGD.Properties.Appearance.Options.UseFont = true;
            this.txt_TenNGD.Size = new System.Drawing.Size(170, 26);
            this.txt_TenNGD.TabIndex = 65;
            // 
            // uct_NhomNgD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mv_NGD);
            this.Controls.Add(this.textEdit1);
            this.Controls.Add(this.btn_LuuNGD);
            this.Controls.Add(this.btn_RefreshNGD);
            this.Controls.Add(this.btn_SuaNGD);
            this.Controls.Add(this.btn_XoaNGD);
            this.Controls.Add(this.btn_ThemNGD);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txt_TenNGD);
            this.Name = "uct_NhomNgD";
            this.Size = new System.Drawing.Size(2518, 1044);
            this.Load += new System.EventHandler(this.uct_NhomNgD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mv_NGD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_NGD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TenNGD.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl mv_NGD;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_NGD;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.SimpleButton btn_LuuNGD;
        private DevExpress.XtraEditors.SimpleButton btn_RefreshNGD;
        private DevExpress.XtraEditors.SimpleButton btn_SuaNGD;
        private DevExpress.XtraEditors.SimpleButton btn_XoaNGD;
        private DevExpress.XtraEditors.SimpleButton btn_ThemNGD;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txt_TenNGD;
    }
}
