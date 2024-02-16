using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BLL;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;

namespace GUI
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        NgDungNhomNgDungBLL da_NDNhomND = new NgDungNhomNgDungBLL();
        PhanQuyenBLL da_PQ = new PhanQuyenBLL();
        public frmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string tendn = TaiKhoanBLL.TenDangNhap;
            List<QLNguoiDungNhonNguoiDung> nhomND = da_NDNhomND.GetMaNhomNguoiDung(tendn);

            foreach (QLNguoiDungNhonNguoiDung item in nhomND)
            {
                List<QLPhanQuyen> dsQuyen = da_PQ.GetMaManHinh(item.MANHOM);
                foreach (QLPhanQuyen mh in dsQuyen)
                {
                    FindMenuPhanQuyen(ribbonControl1.Pages, mh.MAMANHINH, (bool)mh.QUYEN);
                }
            }
        }

        private void FindMenuPhanQuyen(RibbonPageCollection pages, int pScreenName, bool pEnable)
        {
            foreach (RibbonPage page in pages)
            {
                FindMenuPhanQuyen(page.Groups, pScreenName, pEnable);
            }
        }

        private void FindMenuPhanQuyen(RibbonPageGroupCollection groups, int pScreenName, bool pEnable)
        {
            foreach (RibbonPageGroup group in groups)
            {
                FindMenuPhanQuyen(group.ItemLinks, pScreenName, pEnable);
            }
        }

        private void FindMenuPhanQuyen(BarItemLinkCollection barItemLinks, int pScreenName, bool pEnable)
        {
            foreach (BarItemLink barItemLink in barItemLinks)
            {
                BarItem barItem = barItemLink.Item;
                if (barItem is BarButtonItem)
                {
                    // Nếu là BarButtonItem và có Tag giống với pScreenName, thì thiết lập Enabled và Visible
                    if ((int)barItem.Tag == pScreenName)
                    {
                        barItem.Enabled = pEnable;
                        //barItem.Visibility = pEnable ? BarItemVisibility.Always : BarItemVisibility.Never;
                    }
                }
            }
        }

        private void btn_ThucUong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panelControl1.Controls.Clear();
            uct_ThuUong tu = new uct_ThuUong();
            tu.Dock = DockStyle.Fill;

            panelControl1.Controls.Add(tu);
        }

        private void btn_Loai_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panelControl1.Controls.Clear();
            uct_LoaiTU tu = new uct_LoaiTU();
            tu.Dock = DockStyle.Fill;

            panelControl1.Controls.Add(tu);
        }

        private void btn_NhanVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panelControl1.Controls.Clear();
            uct_NhanVien tu = new uct_NhanVien();
            tu.Dock = DockStyle.Fill;

            panelControl1.Controls.Add(tu);
        }

        private void btn_KhachHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panelControl1.Controls.Clear();
            uct_KhachHang tu = new uct_KhachHang();
            tu.Dock = DockStyle.Fill;

            panelControl1.Controls.Add(tu);
        }

        private void btn_DatMon_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panelControl1.Controls.Clear();
            uct_DatMon tu = new uct_DatMon();
            tu.Dock = DockStyle.Fill;

            panelControl1.Controls.Add(tu);
        }

        private void btn_HoaDon_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panelControl1.Controls.Clear();
            uct_HoaDon tu = new uct_HoaDon();
            tu.Dock = DockStyle.Fill;

            panelControl1.Controls.Add(tu);
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát chương trình không?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btn_NhomND_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panelControl1.Controls.Clear();
            uct_NhomNgD tu = new uct_NhomNgD();
            tu.Dock = DockStyle.Fill;

            panelControl1.Controls.Add(tu);
        }

        private void btn_MH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panelControl1.Controls.Clear();
            uct_ManHinh tu = new uct_ManHinh();
            tu.Dock = DockStyle.Fill;

            panelControl1.Controls.Add(tu);
        }

        private void btn_NguoiDungVaoNhom_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panelControl1.Controls.Clear();
            uct_ThemNgDVaoNhom tu = new uct_ThemNgDVaoNhom();
            tu.Dock = DockStyle.Fill;

            panelControl1.Controls.Add(tu);
        }

        private void btn_PQ_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panelControl1.Controls.Clear();
            uct_PhanQuyen tu = new uct_PhanQuyen();
            tu.Dock = DockStyle.Fill;

            panelControl1.Controls.Add(tu);
        }

        private void btn_DangXuat_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn Có Muốn Đăng Xuất?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                TaiKhoanBLL.TenDangNhap = "";
                Program.frmDanNhap = new DangNhap();
                this.Visible = false;
                Program.frmDanNhap.Show();
            }
        }

        private void btn_ThongKe_ItemClick(object sender, ItemClickEventArgs e)
        {
            panelControl1.Controls.Clear();
            uct_ThongKe tu = new uct_ThongKe();
            tu.Dock = DockStyle.Fill;

            panelControl1.Controls.Add(tu);
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            panelControl1.Controls.Clear();
            uct_DuDoan tu = new uct_DuDoan();
            tu.Dock = DockStyle.Fill;

            panelControl1.Controls.Add(tu);
        }


    }
}
