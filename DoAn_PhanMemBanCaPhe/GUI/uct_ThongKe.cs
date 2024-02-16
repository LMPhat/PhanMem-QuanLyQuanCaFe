using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BLL;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;

namespace GUI
{
    public partial class uct_ThongKe : DevExpress.XtraEditors.XtraUserControl
    {
        HoaDonBLL da = new HoaDonBLL();
        KhachHangBLL da_KH = new KhachHangBLL();
        NhanVienBLL da_NV = new NhanVienBLL();
        private RepositoryItemLookUpEdit ril_KH;
        private RepositoryItemLookUpEdit ril_NV;
        public uct_ThongKe()
        {
            InitializeComponent();
        }

        private void InitializeLookUpEdit()
        {
            //Khách hàng
            ril_KH = new RepositoryItemLookUpEdit();

            // Thiết lập các thuộc tính của RepositoryItemLookUpEdit
            ril_KH.DataSource = da_KH.GetKH_HD(); // Đặt nguồn dữ liệu
            ril_KH.DisplayMember = "TENKH"; // Chọn trường hiển thị
            ril_KH.ValueMember = "MAKH"; // Chọn trường giá trị
            ril_KH.AutoHeight = false; // Tắt chế độ tự động điều chỉnh chiều cao
            // Các thiết lập khác nếu cần thiết

            // Áp dụng RepositoryItemLookUpEdit cho cột GridControl (hoặc một control khác)
            GridColumn colMAKH = gv_HD.Columns["MAKH"];
            colMAKH.ColumnEdit = ril_KH;

            //Nhân viên
            ril_NV = new RepositoryItemLookUpEdit();

            // Thiết lập các thuộc tính của RepositoryItemLookUpEdit
            ril_NV.DataSource = da_NV.GetNV_HD(); // Đặt nguồn dữ liệu
            ril_NV.DisplayMember = "TENNV"; // Chọn trường hiển thị
            ril_NV.ValueMember = "MANV"; // Chọn trường giá trị
            ril_NV.AutoHeight = false; // Tắt chế độ tự động điều chỉnh chiều cao
            // Các thiết lập khác nếu cần thiết

            // Áp dụng RepositoryItemLookUpEdit cho cột GridControl (hoặc một control khác)
            GridColumn colMANV = gv_HD.Columns["MANV"];
            colMANV.ColumnEdit = ril_NV;
        }

        private void uct_ThongKe_Load(object sender, EventArgs e)
        {
            textEdit1.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            LoadHD();
        }

        void LoadHD()
        {
            mv_HD.DataSource = da.GetHD();
            gv_HD.OptionsSelection.EnableAppearanceFocusedRow = false;
            gv_HD.OptionsBehavior.Editable = false;

            InitializeLookUpEdit();

            gv_HD.Columns["NHANVIEN"].Visible = false;
            gv_HD.Columns["KHACHHANG"].Visible = false;

            te_TuNgay.EditValue = DateTime.Now;
            te_DenNgay.EditValue = DateTime.Now;

            lbl_TongTien.Text = 0.ToString() + " VND";
        }

        private void btn_TK_Click(object sender, EventArgs e)
        {
            mv_HD.DataSource = da.ThongKe((DateTime)te_TuNgay.EditValue, (DateTime)te_DenNgay.EditValue);
            gv_HD.OptionsSelection.EnableAppearanceFocusedRow = false;
            gv_HD.OptionsBehavior.Editable = false;

            InitializeLookUpEdit();

            gv_HD.Columns["NHANVIEN"].Visible = false;
            gv_HD.Columns["KHACHHANG"].Visible = false;

            lbl_TongTien.Text = da.TongTienHD_TK(da.ThongKe((DateTime)te_TuNgay.EditValue, (DateTime)te_DenNgay.EditValue)).ToString() + " VND";
        }

        private void btn_RefreshHD_Click(object sender, EventArgs e)
        {
            LoadHD();
        }
    }
}
