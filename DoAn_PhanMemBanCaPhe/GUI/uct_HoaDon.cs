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
using DevExpress.XtraGrid.Views.Grid;

namespace GUI
{
    public partial class uct_HoaDon : DevExpress.XtraEditors.XtraUserControl
    {
        HoaDonBLL da = new HoaDonBLL();
        KhachHangBLL da_KH = new KhachHangBLL();
        NhanVienBLL da_NV = new NhanVienBLL();
        private RepositoryItemLookUpEdit ril_KH;
        private RepositoryItemLookUpEdit ril_NV;
        public uct_HoaDon()
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

        private void uct_HoaDon_Load(object sender, EventArgs e)
        {
            textEdit1.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;

            LoadHD();
        }

        void LoadHD()
        {
            mv_HD.DataSource = da.GetHD();
            gv_HD.OptionsSelection.EnableAppearanceFocusedRow = false;
            //gv_HD.OptionsBehavior.Editable = false;

            InitializeLookUpEdit();

            gv_HD.Columns["NHANVIEN"].Visible = false;
            gv_HD.Columns["KHACHHANG"].Visible = false;
            txt_TK.Enabled = false;

            txt_TK.Text = "";
            rdo_LuaChonTK.SelectedIndex = -1;

        }

        private void btn_RefreshHD_Click(object sender, EventArgs e)
        {
            LoadHD();
        }

        private void rdo_LuaChonTK_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(rdo_LuaChonTK.SelectedIndex >= 0)
            {
                txt_TK.Enabled = true;
            }
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            if (rdo_LuaChonTK.SelectedIndex < 0 || txt_TK.Text == "")
                MessageBox.Show("Bạn chưa nhập tên để tìm kiếm !");
            else
            {
                if(rdo_LuaChonTK.EditValue.ToString() == "KhachHang")
                {
                    mv_HD.DataSource = da.TimKiem_KH(txt_TK.Text);
                }
                else
                {
                    mv_HD.DataSource = da.TimKiem_NV(txt_TK.Text);
                }
            }
        }

        private void gv_HD_ShownEditor(object sender, EventArgs e)
        {
            GridView view = sender as GridView;
            if (view.FocusedColumn.FieldName == "TRANGTHAI") // Thay "TenCotCheckEdit" bằng tên thực của cột kiểu CheckEdit
            {
                DialogResult result = MessageBox.Show("Bạn có muốn chỉnh sửa trạng thái giao hàng?", "Xác nhận chỉnh sửa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    string temp = gv_HD.GetRowCellDisplayText(gv_HD.FocusedRowHandle, "TRANGTHAI");

                    HOADON hd = new HOADON();
                    hd.MAHD = int.Parse(gv_HD.GetRowCellDisplayText(gv_HD.FocusedRowHandle, "MAHD"));
                    if (temp != "Checked")
                        hd.TRANGTHAI = true;
                    else
                        return;

                    da.ChinhSuaTrangThai(hd.MAHD);

                    List<CHITIET_THUCUONG> ct = da.GetCTHD(hd.MAHD);
                    foreach (CHITIET_THUCUONG item in ct)
                    {
                        da.ChinhSuaSL_KhiThanhToan(item.MATU, (int)item.SL);
                    }

                    LoadHD();
                }
                else
                {
                    LoadHD();
                }

            }
        }


    }
}
