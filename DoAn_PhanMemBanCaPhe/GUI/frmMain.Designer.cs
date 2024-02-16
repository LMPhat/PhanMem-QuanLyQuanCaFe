namespace GUI
{
    partial class frmMain
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btn_ThucUong = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Loai = new DevExpress.XtraBars.BarButtonItem();
            this.btn_DatMon = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.btn_HoaDon = new DevExpress.XtraBars.BarButtonItem();
            this.btn_NhanVien = new DevExpress.XtraBars.BarButtonItem();
            this.btn_KhachHang = new DevExpress.XtraBars.BarButtonItem();
            this.btn_NhomNgD = new DevExpress.XtraBars.BarButtonItem();
            this.btn_ManHinh = new DevExpress.XtraBars.BarButtonItem();
            this.btn_ThemNgDVaoNhom = new DevExpress.XtraBars.BarButtonItem();
            this.btn_PhanQuyen = new DevExpress.XtraBars.BarButtonItem();
            this.btn_NhomND = new DevExpress.XtraBars.BarButtonItem();
            this.btn_MH = new DevExpress.XtraBars.BarButtonItem();
            this.btn_NguoiDungVaoNhom = new DevExpress.XtraBars.BarButtonItem();
            this.btn_PQ = new DevExpress.XtraBars.BarButtonItem();
            this.btn_DangXuat = new DevExpress.XtraBars.BarButtonItem();
            this.btn_ThongKe = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.btn_ThucUong,
            this.btn_Loai,
            this.btn_DatMon,
            this.barButtonItem2,
            this.btn_HoaDon,
            this.btn_NhanVien,
            this.btn_KhachHang,
            this.btn_NhomNgD,
            this.btn_ManHinh,
            this.btn_ThemNgDVaoNhom,
            this.btn_PhanQuyen,
            this.btn_NhomND,
            this.btn_MH,
            this.btn_NguoiDungVaoNhom,
            this.btn_PQ,
            this.btn_DangXuat,
            this.btn_ThongKe,
            this.barButtonItem1});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 19;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2,
            this.ribbonPage3});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010;
            this.ribbonControl1.Size = new System.Drawing.Size(858, 143);
            // 
            // btn_ThucUong
            // 
            this.btn_ThucUong.Caption = "Thức uống";
            this.btn_ThucUong.Glyph = ((System.Drawing.Image)(resources.GetObject("btn_ThucUong.Glyph")));
            this.btn_ThucUong.Id = 1;
            this.btn_ThucUong.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btn_ThucUong.LargeGlyph")));
            this.btn_ThucUong.Name = "btn_ThucUong";
            this.btn_ThucUong.Tag = 1;
            this.btn_ThucUong.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_ThucUong_ItemClick);
            // 
            // btn_Loai
            // 
            this.btn_Loai.Caption = "Loại";
            this.btn_Loai.Glyph = ((System.Drawing.Image)(resources.GetObject("btn_Loai.Glyph")));
            this.btn_Loai.Id = 2;
            this.btn_Loai.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btn_Loai.LargeGlyph")));
            this.btn_Loai.Name = "btn_Loai";
            this.btn_Loai.Tag = 2;
            this.btn_Loai.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Loai_ItemClick);
            // 
            // btn_DatMon
            // 
            this.btn_DatMon.Caption = "Đặt món";
            this.btn_DatMon.Glyph = ((System.Drawing.Image)(resources.GetObject("btn_DatMon.Glyph")));
            this.btn_DatMon.Id = 3;
            this.btn_DatMon.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btn_DatMon.LargeGlyph")));
            this.btn_DatMon.Name = "btn_DatMon";
            this.btn_DatMon.Tag = 9;
            this.btn_DatMon.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_DatMon_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "barButtonItem2";
            this.barButtonItem2.Id = 4;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // btn_HoaDon
            // 
            this.btn_HoaDon.Caption = "Hóa đơn";
            this.btn_HoaDon.Glyph = ((System.Drawing.Image)(resources.GetObject("btn_HoaDon.Glyph")));
            this.btn_HoaDon.Id = 5;
            this.btn_HoaDon.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btn_HoaDon.LargeGlyph")));
            this.btn_HoaDon.Name = "btn_HoaDon";
            this.btn_HoaDon.Tag = 10;
            this.btn_HoaDon.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_HoaDon_ItemClick);
            // 
            // btn_NhanVien
            // 
            this.btn_NhanVien.Caption = "Nhân viên";
            this.btn_NhanVien.Glyph = ((System.Drawing.Image)(resources.GetObject("btn_NhanVien.Glyph")));
            this.btn_NhanVien.Id = 6;
            this.btn_NhanVien.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btn_NhanVien.LargeGlyph")));
            this.btn_NhanVien.Name = "btn_NhanVien";
            this.btn_NhanVien.Tag = 3;
            this.btn_NhanVien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_NhanVien_ItemClick);
            // 
            // btn_KhachHang
            // 
            this.btn_KhachHang.Caption = "Khách hàng";
            this.btn_KhachHang.Glyph = ((System.Drawing.Image)(resources.GetObject("btn_KhachHang.Glyph")));
            this.btn_KhachHang.Id = 7;
            this.btn_KhachHang.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btn_KhachHang.LargeGlyph")));
            this.btn_KhachHang.Name = "btn_KhachHang";
            this.btn_KhachHang.Tag = 4;
            this.btn_KhachHang.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_KhachHang_ItemClick);
            // 
            // btn_NhomNgD
            // 
            this.btn_NhomNgD.Caption = "Nhóm người dùng";
            this.btn_NhomNgD.Glyph = ((System.Drawing.Image)(resources.GetObject("btn_NhomNgD.Glyph")));
            this.btn_NhomNgD.Id = 8;
            this.btn_NhomNgD.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btn_NhomNgD.LargeGlyph")));
            this.btn_NhomNgD.Name = "btn_NhomNgD";
            // 
            // btn_ManHinh
            // 
            this.btn_ManHinh.Caption = "Màn hình";
            this.btn_ManHinh.Glyph = ((System.Drawing.Image)(resources.GetObject("btn_ManHinh.Glyph")));
            this.btn_ManHinh.Id = 9;
            this.btn_ManHinh.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btn_ManHinh.LargeGlyph")));
            this.btn_ManHinh.Name = "btn_ManHinh";
            // 
            // btn_ThemNgDVaoNhom
            // 
            this.btn_ThemNgDVaoNhom.Caption = "Thêm người dùng vào nhóm";
            this.btn_ThemNgDVaoNhom.Glyph = ((System.Drawing.Image)(resources.GetObject("btn_ThemNgDVaoNhom.Glyph")));
            this.btn_ThemNgDVaoNhom.Id = 10;
            this.btn_ThemNgDVaoNhom.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btn_ThemNgDVaoNhom.LargeGlyph")));
            this.btn_ThemNgDVaoNhom.Name = "btn_ThemNgDVaoNhom";
            // 
            // btn_PhanQuyen
            // 
            this.btn_PhanQuyen.ActAsDropDown = true;
            this.btn_PhanQuyen.Caption = "Phần quyền";
            this.btn_PhanQuyen.Glyph = ((System.Drawing.Image)(resources.GetObject("btn_PhanQuyen.Glyph")));
            this.btn_PhanQuyen.Id = 11;
            this.btn_PhanQuyen.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btn_PhanQuyen.LargeGlyph")));
            this.btn_PhanQuyen.Name = "btn_PhanQuyen";
            // 
            // btn_NhomND
            // 
            this.btn_NhomND.Caption = "Nhóm người dùng";
            this.btn_NhomND.Glyph = ((System.Drawing.Image)(resources.GetObject("btn_NhomND.Glyph")));
            this.btn_NhomND.Id = 12;
            this.btn_NhomND.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btn_NhomND.LargeGlyph")));
            this.btn_NhomND.Name = "btn_NhomND";
            this.btn_NhomND.Tag = 5;
            this.btn_NhomND.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_NhomND_ItemClick);
            // 
            // btn_MH
            // 
            this.btn_MH.Caption = "Màn hình";
            this.btn_MH.Glyph = ((System.Drawing.Image)(resources.GetObject("btn_MH.Glyph")));
            this.btn_MH.Id = 13;
            this.btn_MH.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btn_MH.LargeGlyph")));
            this.btn_MH.Name = "btn_MH";
            this.btn_MH.Tag = 6;
            this.btn_MH.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_MH_ItemClick);
            // 
            // btn_NguoiDungVaoNhom
            // 
            this.btn_NguoiDungVaoNhom.Caption = "Thêm người dùng vào nhóm";
            this.btn_NguoiDungVaoNhom.Glyph = ((System.Drawing.Image)(resources.GetObject("btn_NguoiDungVaoNhom.Glyph")));
            this.btn_NguoiDungVaoNhom.Id = 14;
            this.btn_NguoiDungVaoNhom.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btn_NguoiDungVaoNhom.LargeGlyph")));
            this.btn_NguoiDungVaoNhom.Name = "btn_NguoiDungVaoNhom";
            this.btn_NguoiDungVaoNhom.Tag = 7;
            this.btn_NguoiDungVaoNhom.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_NguoiDungVaoNhom_ItemClick);
            // 
            // btn_PQ
            // 
            this.btn_PQ.Caption = "Phân quyền";
            this.btn_PQ.Glyph = ((System.Drawing.Image)(resources.GetObject("btn_PQ.Glyph")));
            this.btn_PQ.Id = 15;
            this.btn_PQ.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btn_PQ.LargeGlyph")));
            this.btn_PQ.Name = "btn_PQ";
            this.btn_PQ.Tag = 8;
            this.btn_PQ.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_PQ_ItemClick);
            // 
            // btn_DangXuat
            // 
            this.btn_DangXuat.Caption = "Đăng xuất";
            this.btn_DangXuat.Glyph = ((System.Drawing.Image)(resources.GetObject("btn_DangXuat.Glyph")));
            this.btn_DangXuat.Id = 16;
            this.btn_DangXuat.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btn_DangXuat.LargeGlyph")));
            this.btn_DangXuat.Name = "btn_DangXuat";
            this.btn_DangXuat.Tag = 0;
            this.btn_DangXuat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_DangXuat_ItemClick);
            // 
            // btn_ThongKe
            // 
            this.btn_ThongKe.Caption = "Thống kê";
            this.btn_ThongKe.Glyph = ((System.Drawing.Image)(resources.GetObject("btn_ThongKe.Glyph")));
            this.btn_ThongKe.Id = 17;
            this.btn_ThongKe.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btn_ThongKe.LargeGlyph")));
            this.btn_ThongKe.Name = "btn_ThongKe";
            this.btn_ThongKe.Tag = 12;
            this.btn_ThongKe.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_ThongKe_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Dự đoán doanh số";
            this.barButtonItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.Glyph")));
            this.barButtonItem1.Id = 18;
            this.barButtonItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.LargeGlyph")));
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.Tag = 0;
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup3,
            this.ribbonPageGroup4});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Quản lý";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btn_ThucUong);
            this.ribbonPageGroup1.ItemLinks.Add(this.btn_Loai);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Danh mục";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btn_NhanVien);
            this.ribbonPageGroup3.ItemLinks.Add(this.btn_KhachHang);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Tài khoản";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.btn_NhomND);
            this.ribbonPageGroup4.ItemLinks.Add(this.btn_MH);
            this.ribbonPageGroup4.ItemLinks.Add(this.btn_NguoiDungVaoNhom);
            this.ribbonPageGroup4.ItemLinks.Add(this.btn_PQ);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "Phân quyền";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2,
            this.ribbonPageGroup6});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Nghiệp vụ";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btn_DatMon);
            this.ribbonPageGroup2.ItemLinks.Add(this.btn_HoaDon);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Đặt món";
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.ItemLinks.Add(this.btn_ThongKe);
            this.ribbonPageGroup6.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup5});
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Text = "Hệ thống";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.btn_DangXuat);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.Text = "ribbonPageGroup5";
            // 
            // panelControl1
            // 
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 143);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(858, 317);
            this.panelControl1.TabIndex = 1;
            // 
            // popupMenu1
            // 
            this.popupMenu1.Name = "popupMenu1";
            this.popupMenu1.Ribbon = this.ribbonControl1;
            // 
            // frmMain
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.False;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 460);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "frmMain";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem btn_ThucUong;
        private DevExpress.XtraBars.BarButtonItem btn_Loai;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraBars.BarButtonItem btn_DatMon;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem btn_HoaDon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem btn_NhanVien;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem btn_KhachHang;
        private DevExpress.XtraBars.BarButtonItem btn_NhomNgD;
        private DevExpress.XtraBars.BarButtonItem btn_ManHinh;
        private DevExpress.XtraBars.BarButtonItem btn_ThemNgDVaoNhom;
        private DevExpress.XtraBars.BarButtonItem btn_PhanQuyen;
        private DevExpress.XtraBars.PopupMenu popupMenu1;
        private DevExpress.XtraBars.BarButtonItem btn_NhomND;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.BarButtonItem btn_MH;
        private DevExpress.XtraBars.BarButtonItem btn_NguoiDungVaoNhom;
        private DevExpress.XtraBars.BarButtonItem btn_PQ;
        private DevExpress.XtraBars.BarButtonItem btn_DangXuat;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.BarButtonItem btn_ThongKe;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
    }
}

