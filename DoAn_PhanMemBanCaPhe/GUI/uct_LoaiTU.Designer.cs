namespace GUI
{
    partial class uct_LoaiTU
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uct_LoaiTU));
            this.mv_Loai = new DevExpress.XtraGrid.GridControl();
            this.gv_Loai = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txt_TenLoai = new DevExpress.XtraEditors.TextEdit();
            this.btn_RefreshLoai = new DevExpress.XtraEditors.SimpleButton();
            this.btn_SuaLoai = new DevExpress.XtraEditors.SimpleButton();
            this.btn_XoaLoai = new DevExpress.XtraEditors.SimpleButton();
            this.btn_ThemLoai = new DevExpress.XtraEditors.SimpleButton();
            this.btn_LuuLoai = new DevExpress.XtraEditors.SimpleButton();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.mv_Loai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Loai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TenLoai.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // mv_Loai
            // 
            this.mv_Loai.Location = new System.Drawing.Point(278, 96);
            this.mv_Loai.MainView = this.gv_Loai;
            this.mv_Loai.Name = "mv_Loai";
            this.mv_Loai.Size = new System.Drawing.Size(822, 328);
            this.mv_Loai.TabIndex = 20;
            this.mv_Loai.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_Loai});
            // 
            // gv_Loai
            // 
            this.gv_Loai.GridControl = this.mv_Loai;
            this.gv_Loai.Name = "gv_Loai";
            this.gv_Loai.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gv_Loai_FocusedRowChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(277, 60);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(57, 19);
            this.labelControl1.TabIndex = 13;
            this.labelControl1.Text = "Tên loại";
            // 
            // txt_TenLoai
            // 
            this.txt_TenLoai.Location = new System.Drawing.Point(365, 57);
            this.txt_TenLoai.Name = "txt_TenLoai";
            this.txt_TenLoai.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenLoai.Properties.Appearance.Options.UseFont = true;
            this.txt_TenLoai.Size = new System.Drawing.Size(170, 26);
            this.txt_TenLoai.TabIndex = 12;
            // 
            // btn_RefreshLoai
            // 
            this.btn_RefreshLoai.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RefreshLoai.Appearance.Options.UseFont = true;
            this.btn_RefreshLoai.Image = ((System.Drawing.Image)(resources.GetObject("btn_RefreshLoai.Image")));
            this.btn_RefreshLoai.Location = new System.Drawing.Point(998, 50);
            this.btn_RefreshLoai.Name = "btn_RefreshLoai";
            this.btn_RefreshLoai.Size = new System.Drawing.Size(102, 33);
            this.btn_RefreshLoai.TabIndex = 25;
            this.btn_RefreshLoai.Text = "Refresh";
            this.btn_RefreshLoai.Click += new System.EventHandler(this.btn_RefreshLoai_Click);
            // 
            // btn_SuaLoai
            // 
            this.btn_SuaLoai.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SuaLoai.Appearance.Options.UseFont = true;
            this.btn_SuaLoai.Image = ((System.Drawing.Image)(resources.GetObject("btn_SuaLoai.Image")));
            this.btn_SuaLoai.Location = new System.Drawing.Point(690, 50);
            this.btn_SuaLoai.Name = "btn_SuaLoai";
            this.btn_SuaLoai.Size = new System.Drawing.Size(83, 33);
            this.btn_SuaLoai.TabIndex = 24;
            this.btn_SuaLoai.Text = "Sửa";
            this.btn_SuaLoai.Click += new System.EventHandler(this.btn_SuaLoai_Click);
            // 
            // btn_XoaLoai
            // 
            this.btn_XoaLoai.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XoaLoai.Appearance.Options.UseFont = true;
            this.btn_XoaLoai.Image = ((System.Drawing.Image)(resources.GetObject("btn_XoaLoai.Image")));
            this.btn_XoaLoai.Location = new System.Drawing.Point(792, 50);
            this.btn_XoaLoai.Name = "btn_XoaLoai";
            this.btn_XoaLoai.Size = new System.Drawing.Size(85, 33);
            this.btn_XoaLoai.TabIndex = 23;
            this.btn_XoaLoai.Text = "Xóa";
            this.btn_XoaLoai.Click += new System.EventHandler(this.btn_XoaLoai_Click);
            // 
            // btn_ThemLoai
            // 
            this.btn_ThemLoai.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThemLoai.Appearance.Options.UseFont = true;
            this.btn_ThemLoai.Image = ((System.Drawing.Image)(resources.GetObject("btn_ThemLoai.Image")));
            this.btn_ThemLoai.Location = new System.Drawing.Point(578, 50);
            this.btn_ThemLoai.Name = "btn_ThemLoai";
            this.btn_ThemLoai.Size = new System.Drawing.Size(85, 33);
            this.btn_ThemLoai.TabIndex = 22;
            this.btn_ThemLoai.Text = "Thêm";
            this.btn_ThemLoai.Click += new System.EventHandler(this.btn_ThemLoai_Click);
            // 
            // btn_LuuLoai
            // 
            this.btn_LuuLoai.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LuuLoai.Appearance.Options.UseFont = true;
            this.btn_LuuLoai.Image = ((System.Drawing.Image)(resources.GetObject("btn_LuuLoai.Image")));
            this.btn_LuuLoai.Location = new System.Drawing.Point(901, 50);
            this.btn_LuuLoai.Name = "btn_LuuLoai";
            this.btn_LuuLoai.Size = new System.Drawing.Size(79, 33);
            this.btn_LuuLoai.TabIndex = 26;
            this.btn_LuuLoai.Text = "Lưu";
            this.btn_LuuLoai.Click += new System.EventHandler(this.btn_LuuLoai_Click);
            // 
            // textEdit1
            // 
            this.textEdit1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textEdit1.EditValue = "QUẢN LÝ LOẠI";
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
            this.textEdit1.TabIndex = 64;
            // 
            // uct_LoaiTU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textEdit1);
            this.Controls.Add(this.btn_LuuLoai);
            this.Controls.Add(this.btn_RefreshLoai);
            this.Controls.Add(this.btn_SuaLoai);
            this.Controls.Add(this.btn_XoaLoai);
            this.Controls.Add(this.btn_ThemLoai);
            this.Controls.Add(this.mv_Loai);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txt_TenLoai);
            this.Name = "uct_LoaiTU";
            this.Size = new System.Drawing.Size(2518, 1044);
            this.Load += new System.EventHandler(this.uct_LoaiTU_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mv_Loai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Loai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TenLoai.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl mv_Loai;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_Loai;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txt_TenLoai;
        private DevExpress.XtraEditors.SimpleButton btn_RefreshLoai;
        private DevExpress.XtraEditors.SimpleButton btn_SuaLoai;
        private DevExpress.XtraEditors.SimpleButton btn_XoaLoai;
        private DevExpress.XtraEditors.SimpleButton btn_ThemLoai;
        private DevExpress.XtraEditors.SimpleButton btn_LuuLoai;
        private DevExpress.XtraEditors.TextEdit textEdit1;
    }
}
