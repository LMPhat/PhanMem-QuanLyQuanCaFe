namespace GUI
{
    partial class uct_ThongKe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uct_ThongKe));
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.btn_RefreshHD = new DevExpress.XtraEditors.SimpleButton();
            this.lbl_TongTien = new DevExpress.XtraEditors.LabelControl();
            this.lbl = new DevExpress.XtraEditors.LabelControl();
            this.mv_HD = new DevExpress.XtraGrid.GridControl();
            this.gv_HD = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.te_DenNgay = new DevExpress.XtraEditors.TimeEdit();
            this.te_TuNgay = new DevExpress.XtraEditors.TimeEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btn_TK = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mv_HD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_HD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_DenNgay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_TuNgay.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // textEdit1
            // 
            this.textEdit1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textEdit1.EditValue = "THỐNG KÊ";
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
            // btn_RefreshHD
            // 
            this.btn_RefreshHD.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RefreshHD.Appearance.Options.UseFont = true;
            this.btn_RefreshHD.Image = ((System.Drawing.Image)(resources.GetObject("btn_RefreshHD.Image")));
            this.btn_RefreshHD.Location = new System.Drawing.Point(954, 82);
            this.btn_RefreshHD.Name = "btn_RefreshHD";
            this.btn_RefreshHD.Size = new System.Drawing.Size(102, 33);
            this.btn_RefreshHD.TabIndex = 80;
            this.btn_RefreshHD.Text = "Refresh";
            this.btn_RefreshHD.Click += new System.EventHandler(this.btn_RefreshHD_Click);
            // 
            // lbl_TongTien
            // 
            this.lbl_TongTien.Appearance.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.lbl_TongTien.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lbl_TongTien.Location = new System.Drawing.Point(348, 439);
            this.lbl_TongTien.Name = "lbl_TongTien";
            this.lbl_TongTien.Size = new System.Drawing.Size(60, 23);
            this.lbl_TongTien.TabIndex = 79;
            this.lbl_TongTien.Text = "0 VND";
            // 
            // lbl
            // 
            this.lbl.Appearance.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.lbl.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lbl.Location = new System.Drawing.Point(234, 439);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(108, 23);
            this.lbl.TabIndex = 78;
            this.lbl.Text = "Tổng Tiền: ";
            // 
            // mv_HD
            // 
            this.mv_HD.Location = new System.Drawing.Point(234, 125);
            this.mv_HD.MainView = this.gv_HD;
            this.mv_HD.Name = "mv_HD";
            this.mv_HD.Size = new System.Drawing.Size(822, 292);
            this.mv_HD.TabIndex = 75;
            this.mv_HD.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_HD});
            // 
            // gv_HD
            // 
            this.gv_HD.GridControl = this.mv_HD;
            this.gv_HD.Name = "gv_HD";
            // 
            // te_DenNgay
            // 
            this.te_DenNgay.EditValue = new System.DateTime(2023, 11, 29, 0, 0, 0, 0);
            this.te_DenNgay.Location = new System.Drawing.Point(321, 86);
            this.te_DenNgay.Name = "te_DenNgay";
            this.te_DenNgay.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.te_DenNgay.Properties.Appearance.Options.UseFont = true;
            this.te_DenNgay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.te_DenNgay.Properties.Mask.EditMask = "d";
            this.te_DenNgay.Size = new System.Drawing.Size(128, 26);
            this.te_DenNgay.TabIndex = 85;
            // 
            // te_TuNgay
            // 
            this.te_TuNgay.EditValue = new System.DateTime(2023, 11, 29, 0, 0, 0, 0);
            this.te_TuNgay.Location = new System.Drawing.Point(321, 47);
            this.te_TuNgay.Name = "te_TuNgay";
            this.te_TuNgay.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.te_TuNgay.Properties.Appearance.Options.UseFont = true;
            this.te_TuNgay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.te_TuNgay.Properties.Mask.EditMask = "d";
            this.te_TuNgay.Size = new System.Drawing.Size(128, 26);
            this.te_TuNgay.TabIndex = 84;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl2.Location = new System.Drawing.Point(233, 89);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(67, 19);
            this.labelControl2.TabIndex = 83;
            this.labelControl2.Text = "Đến ngày";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl1.Location = new System.Drawing.Point(233, 50);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(59, 19);
            this.labelControl1.TabIndex = 82;
            this.labelControl1.Text = "Từ ngày";
            // 
            // btn_TK
            // 
            this.btn_TK.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TK.Appearance.Options.UseFont = true;
            this.btn_TK.Image = ((System.Drawing.Image)(resources.GetObject("btn_TK.Image")));
            this.btn_TK.Location = new System.Drawing.Point(473, 79);
            this.btn_TK.Name = "btn_TK";
            this.btn_TK.Size = new System.Drawing.Size(125, 33);
            this.btn_TK.TabIndex = 81;
            this.btn_TK.Text = "Thống Kê";
            this.btn_TK.Click += new System.EventHandler(this.btn_TK_Click);
            // 
            // uct_ThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.te_DenNgay);
            this.Controls.Add(this.te_TuNgay);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btn_TK);
            this.Controls.Add(this.btn_RefreshHD);
            this.Controls.Add(this.lbl_TongTien);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.mv_HD);
            this.Controls.Add(this.textEdit1);
            this.Name = "uct_ThongKe";
            this.Size = new System.Drawing.Size(2518, 1044);
            this.Load += new System.EventHandler(this.uct_ThongKe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mv_HD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_HD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_DenNgay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_TuNgay.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.SimpleButton btn_RefreshHD;
        private DevExpress.XtraEditors.LabelControl lbl_TongTien;
        private DevExpress.XtraEditors.LabelControl lbl;
        private DevExpress.XtraGrid.GridControl mv_HD;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_HD;
        private DevExpress.XtraEditors.TimeEdit te_DenNgay;
        private DevExpress.XtraEditors.TimeEdit te_TuNgay;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btn_TK;
    }
}
