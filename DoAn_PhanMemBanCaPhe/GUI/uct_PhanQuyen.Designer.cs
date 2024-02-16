namespace GUI
{
    partial class uct_PhanQuyen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uct_PhanQuyen));
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.mv_NhomND = new DevExpress.XtraGrid.GridControl();
            this.gv_NhomND = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.mv_QuyenCN = new DevExpress.XtraGrid.GridControl();
            this.gv_QuyenCN = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.btn_LuuTU = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mv_NhomND)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_NhomND)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mv_QuyenCN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_QuyenCN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textEdit1
            // 
            this.textEdit1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textEdit1.EditValue = "PHÂN QUYỀN";
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
            this.textEdit1.TabIndex = 46;
            // 
            // mv_NhomND
            // 
            this.mv_NhomND.Location = new System.Drawing.Point(5, 23);
            this.mv_NhomND.MainView = this.gv_NhomND;
            this.mv_NhomND.Name = "mv_NhomND";
            this.mv_NhomND.Size = new System.Drawing.Size(315, 203);
            this.mv_NhomND.TabIndex = 47;
            this.mv_NhomND.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_NhomND});
            // 
            // gv_NhomND
            // 
            this.gv_NhomND.GridControl = this.mv_NhomND;
            this.gv_NhomND.Name = "gv_NhomND";
            this.gv_NhomND.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gv_NhomND_FocusedRowChanged);
            // 
            // mv_QuyenCN
            // 
            this.mv_QuyenCN.Location = new System.Drawing.Point(5, 23);
            this.mv_QuyenCN.MainView = this.gv_QuyenCN;
            this.mv_QuyenCN.Name = "mv_QuyenCN";
            this.mv_QuyenCN.Size = new System.Drawing.Size(400, 314);
            this.mv_QuyenCN.TabIndex = 48;
            this.mv_QuyenCN.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_QuyenCN});
            // 
            // gv_QuyenCN
            // 
            this.gv_QuyenCN.GridControl = this.mv_QuyenCN;
            this.gv_QuyenCN.Name = "gv_QuyenCN";
            this.gv_QuyenCN.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gv_QuyenCN_FocusedRowChanged);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.mv_NhomND);
            this.groupControl1.Location = new System.Drawing.Point(283, 106);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(325, 231);
            this.groupControl1.TabIndex = 49;
            this.groupControl1.Text = "Danh sách nhóm người dùng";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.mv_QuyenCN);
            this.groupControl2.Location = new System.Drawing.Point(633, 106);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(411, 341);
            this.groupControl2.TabIndex = 50;
            this.groupControl2.Text = "Danh sách quyền chức năng";
            // 
            // btn_LuuTU
            // 
            this.btn_LuuTU.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LuuTU.Appearance.Options.UseFont = true;
            this.btn_LuuTU.Image = ((System.Drawing.Image)(resources.GetObject("btn_LuuTU.Image")));
            this.btn_LuuTU.Location = new System.Drawing.Point(283, 58);
            this.btn_LuuTU.Name = "btn_LuuTU";
            this.btn_LuuTU.Size = new System.Drawing.Size(79, 33);
            this.btn_LuuTU.TabIndex = 51;
            this.btn_LuuTU.Text = "Lưu";
            this.btn_LuuTU.Click += new System.EventHandler(this.btn_LuuTU_Click);
            // 
            // uct_PhanQuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_LuuTU);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.textEdit1);
            this.Name = "uct_PhanQuyen";
            this.Size = new System.Drawing.Size(2518, 1044);
            this.Load += new System.EventHandler(this.uct_PhanQuyen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mv_NhomND)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_NhomND)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mv_QuyenCN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_QuyenCN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraGrid.GridControl mv_NhomND;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_NhomND;
        private DevExpress.XtraGrid.GridControl mv_QuyenCN;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_QuyenCN;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton btn_LuuTU;
    }
}
