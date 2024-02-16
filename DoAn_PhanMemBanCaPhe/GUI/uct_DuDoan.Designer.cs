namespace GUI
{
    partial class uct_DuDoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uct_DuDoan));
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.gv_DD = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.mv_DD = new DevExpress.XtraGrid.GridControl();
            this.btn_RefreshHD = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Submit = new DevExpress.XtraEditors.SimpleButton();
            this.txt_SLN = new DevExpress.XtraEditors.TextEdit();
            this.lku_TU = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txt_SLB = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.te_TuNgay = new DevExpress.XtraEditors.TimeEdit();
            this.lbl = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_DD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mv_DD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_SLN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lku_TU.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_SLB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_TuNgay.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // textEdit1
            // 
            this.textEdit1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textEdit1.EditValue = "DỰ ĐOÁN DOANH SỐ";
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
            this.textEdit1.TabIndex = 67;
            // 
            // gv_DD
            // 
            this.gv_DD.GridControl = this.mv_DD;
            this.gv_DD.Name = "gv_DD";
            // 
            // mv_DD
            // 
            this.mv_DD.Location = new System.Drawing.Point(296, 209);
            this.mv_DD.MainView = this.gv_DD;
            this.mv_DD.Name = "mv_DD";
            this.mv_DD.Size = new System.Drawing.Size(822, 386);
            this.mv_DD.TabIndex = 69;
            this.mv_DD.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_DD});
            // 
            // btn_RefreshHD
            // 
            this.btn_RefreshHD.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RefreshHD.Appearance.Options.UseFont = true;
            this.btn_RefreshHD.Image = ((System.Drawing.Image)(resources.GetObject("btn_RefreshHD.Image")));
            this.btn_RefreshHD.Location = new System.Drawing.Point(1016, 166);
            this.btn_RefreshHD.Name = "btn_RefreshHD";
            this.btn_RefreshHD.Size = new System.Drawing.Size(102, 33);
            this.btn_RefreshHD.TabIndex = 72;
            this.btn_RefreshHD.Text = "Refresh";
            this.btn_RefreshHD.Click += new System.EventHandler(this.btn_RefreshHD_Click);
            // 
            // btn_Submit
            // 
            this.btn_Submit.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Submit.Appearance.Options.UseFont = true;
            this.btn_Submit.Image = ((System.Drawing.Image)(resources.GetObject("btn_Submit.Image")));
            this.btn_Submit.Location = new System.Drawing.Point(862, 166);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(125, 33);
            this.btn_Submit.TabIndex = 70;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // txt_SLN
            // 
            this.txt_SLN.Location = new System.Drawing.Point(886, 66);
            this.txt_SLN.Name = "txt_SLN";
            this.txt_SLN.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SLN.Properties.Appearance.Options.UseFont = true;
            this.txt_SLN.Size = new System.Drawing.Size(232, 26);
            this.txt_SLN.TabIndex = 68;
            // 
            // lku_TU
            // 
            this.lku_TU.Location = new System.Drawing.Point(433, 66);
            this.lku_TU.Margin = new System.Windows.Forms.Padding(4);
            this.lku_TU.Name = "lku_TU";
            this.lku_TU.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lku_TU.Properties.Appearance.Options.UseFont = true;
            this.lku_TU.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lku_TU.Size = new System.Drawing.Size(281, 26);
            this.lku_TU.TabIndex = 73;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(296, 69);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(104, 19);
            this.labelControl2.TabIndex = 74;
            this.labelControl2.Text = "Tên thức uống";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(765, 69);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(104, 19);
            this.labelControl1.TabIndex = 75;
            this.labelControl1.Text = "Số lượng nhập";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Location = new System.Drawing.Point(774, 120);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(95, 19);
            this.labelControl3.TabIndex = 77;
            this.labelControl3.Text = "Số lượng bán";
            // 
            // txt_SLB
            // 
            this.txt_SLB.Location = new System.Drawing.Point(886, 117);
            this.txt_SLB.Name = "txt_SLB";
            this.txt_SLB.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SLB.Properties.Appearance.Options.UseFont = true;
            this.txt_SLB.Size = new System.Drawing.Size(232, 26);
            this.txt_SLB.TabIndex = 76;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Location = new System.Drawing.Point(333, 120);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(67, 19);
            this.labelControl4.TabIndex = 78;
            this.labelControl4.Text = "Thời gian";
            // 
            // te_TuNgay
            // 
            this.te_TuNgay.EditValue = new System.DateTime(2023, 11, 29, 0, 0, 0, 0);
            this.te_TuNgay.Location = new System.Drawing.Point(433, 117);
            this.te_TuNgay.Name = "te_TuNgay";
            this.te_TuNgay.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.te_TuNgay.Properties.Appearance.Options.UseFont = true;
            this.te_TuNgay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.te_TuNgay.Properties.Mask.EditMask = "d";
            this.te_TuNgay.Size = new System.Drawing.Size(128, 26);
            this.te_TuNgay.TabIndex = 85;
            // 
            // lbl
            // 
            this.lbl.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lbl.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lbl.Location = new System.Drawing.Point(296, 178);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(78, 19);
            this.lbl.TabIndex = 86;
            this.lbl.Text = "Doanh số: ";
            // 
            // uct_DuDoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.te_TuNgay);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txt_SLB);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.lku_TU);
            this.Controls.Add(this.textEdit1);
            this.Controls.Add(this.btn_RefreshHD);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.mv_DD);
            this.Controls.Add(this.txt_SLN);
            this.Name = "uct_DuDoan";
            this.Size = new System.Drawing.Size(2518, 1044);
            this.Load += new System.EventHandler(this.uct_DuDoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_DD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mv_DD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_SLN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lku_TU.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_SLB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_TuNgay.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_DD;
        private DevExpress.XtraGrid.GridControl mv_DD;
        private DevExpress.XtraEditors.SimpleButton btn_RefreshHD;
        private DevExpress.XtraEditors.SimpleButton btn_Submit;
        private DevExpress.XtraEditors.TextEdit txt_SLN;
        private DevExpress.XtraEditors.LookUpEdit lku_TU;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txt_SLB;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TimeEdit te_TuNgay;
        private DevExpress.XtraEditors.LabelControl lbl;
    }
}
