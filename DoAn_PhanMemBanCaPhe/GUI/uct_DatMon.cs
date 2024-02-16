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
using System.IO;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraEditors.Repository;

namespace GUI
{
    public partial class uct_DatMon : DevExpress.XtraEditors.XtraUserControl
    {
        LoaiThucUongBLL da_Loai = new LoaiThucUongBLL();
        ThucUongBLL da_TU = new ThucUongBLL();
        HoaDonBLL da_HD = new HoaDonBLL();
        TaiKhoanBLL tk = new TaiKhoanBLL();
        List<CHITIET_THUCUONG> ds_CT = new List<CHITIET_THUCUONG>();
        private RepositoryItemLookUpEdit ril_Loai;
        private RepositoryItemLookUpEdit ril_TU;
        public uct_DatMon()
        {
            InitializeComponent();
        }

        private void InitializeLookUpEdit_TU()
        {
            ril_Loai = new RepositoryItemLookUpEdit();

            // Thiết lập các thuộc tính của RepositoryItemLookUpEdit
            ril_Loai.DataSource = da_Loai.GetLoai(); // Đặt nguồn dữ liệu
            ril_Loai.DisplayMember = "TENLOAI"; // Chọn trường hiển thị
            ril_Loai.ValueMember = "MALOAI"; // Chọn trường giá trị
            ril_Loai.AutoHeight = false; // Tắt chế độ tự động điều chỉnh chiều cao
            // Các thiết lập khác nếu cần thiết

            // Áp dụng RepositoryItemLookUpEdit cho cột GridControl (hoặc một control khác)
            GridColumn colMALoai = gv_ThucUong.Columns["MALOAI"];
            colMALoai.ColumnEdit = ril_Loai;
        }

        private void InitializeLookUpEdit_CT()
        {
            ril_TU = new RepositoryItemLookUpEdit();

            // Thiết lập các thuộc tính của RepositoryItemLookUpEdit
            ril_TU.DataSource = da_TU.GetThucUong(); // Đặt nguồn dữ liệu
            ril_TU.DisplayMember = "TENTU"; // Chọn trường hiển thị
            ril_TU.ValueMember = "MATU"; // Chọn trường giá trị
            ril_TU.AutoHeight = false; // Tắt chế độ tự động điều chỉnh chiều cao
            // Các thiết lập khác nếu cần thiết

            // Áp dụng RepositoryItemLookUpEdit cho cột GridControl (hoặc một control khác)
            GridColumn colMATU = gv_ChiTietHD.Columns["MATU"];
            colMATU.ColumnEdit = ril_TU;
        }

        private void uct_DatMon_Load(object sender, EventArgs e)
        {
            // Khi form đang load, đặt cờ là true

            // Load dữ liệu và thực hiện các công việc khác
            textEdit1.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;

            LoadDM();

            // Khi form load xong, đặt cờ là false
            
        }
        
        void LoadDM()
        {
            mv_ThucUong.DataSource = da_TU.GetThucUong();
            gv_ThucUong.OptionsSelection.EnableAppearanceFocusedRow = false;
            gv_ThucUong.OptionsBehavior.Editable = false;

            InitializeLookUpEdit_TU();

            lku_Loai.Properties.DataSource = da_Loai.GetLoai();
            lku_Loai.Properties.DisplayMember = "TENLOAI";
            lku_Loai.Properties.ValueMember = "MALOAI";
            //lku_Loai.EditValue = null;

            gv_ThucUong.Columns["HINHANH"].Visible = false;
            gv_ThucUong.Columns["LOAIMONNUOC"].Visible = false;

            txt_TenTU_TK.Text = "";
            txt_TenTU.Text = "";
            txt_SoLuong.Text = "";
            pictureEdit1.Image = null;
        }

        void LoadCTHD()
        {
            mv_ChiTietHD.DataSource = ds_CT;
            gv_ChiTietHD.RefreshData();
            InitializeLookUpEdit_CT();
            gv_ChiTietHD.Columns[0].Visible = false;
            gv_ChiTietHD.Columns[5].Visible = false;
            gv_ChiTietHD.Columns[6].Visible = false;
        }

        private void btn_RefreshDM_Click(object sender, EventArgs e)
        {
            gv_ChiTietHD.GridControl.DataSource = null;
            ds_CT.Clear();
            gv_ChiTietHD.RefreshData();

            LoadDM();

            lbl_TongTien.Text = "0 VND";
        }

        private void gv_ThucUong_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (gv_ThucUong.SelectedRowsCount >= 0)
            {
                txt_TenTU.Text = gv_ThucUong.GetRowCellValue(gv_ThucUong.FocusedRowHandle, "TENTU").ToString();
                string image = gv_ThucUong.GetRowCellValue(gv_ThucUong.FocusedRowHandle, "HINHANH").ToString();
                string projectFolder = Path.GetFullPath(Path.Combine(Application.StartupPath, @"..\..\"));
                //lku_Loai.EditValue = int.Parse(gv_ThucUong.GetRowCellValue(gv_ThucUong.FocusedRowHandle, "MALOAI").ToString());

                // Đường dẫn đầy đủ của tệp hình ảnh trong thư mục HinhAnh
                string imagePath = Path.Combine(projectFolder, "HinhAnh", image);

                pictureEdit1.Image = Image.FromFile(imagePath);
            }
        }

        void kTraThucUongTonTai(CHITIET_THUCUONG ct)
        {
            // Kiểm tra xem có CHITIET_THUCUONG có MATU giống với ct không
            bool ktr = ds_CT.Any(item => item.MATU == ct.MATU);

            if (ktr)
            {
                // Nếu đã tồn tại, tăng số lượng lên
                CHITIET_THUCUONG cttu = ds_CT.First(item => item.MATU == ct.MATU);
                cttu.SL += ct.SL;
                cttu.THANHTIEN = cttu.SL * cttu.GIABAN;
            }
            else
            {
                // Nếu chưa tồn tại, thêm vào danh sách
                ds_CT.Add(ct);
            }

        }
        int? tongtien = 0;
        private void btn_GhiMon_Click(object sender, EventArgs e)
        {
            if(txt_SoLuong.Text.Trim().Length > 0)
            {
                try
                {
                    CHITIET_THUCUONG ct = new CHITIET_THUCUONG();
                    ct.MAHD = 1;
                    ct.MATU = int.Parse(gv_ThucUong.GetRowCellDisplayText(gv_ThucUong.FocusedRowHandle, "MATU"));
                    ct.SL = int.Parse(txt_SoLuong.Text);
                    ct.GIABAN = int.Parse(gv_ThucUong.GetRowCellDisplayText(gv_ThucUong.FocusedRowHandle, "DONGIA"));
                    int tt = int.Parse(txt_SoLuong.Text) * int.Parse(gv_ThucUong.GetRowCellDisplayText(gv_ThucUong.FocusedRowHandle, "DONGIA"));
                    ct.THANHTIEN = tt;

                    kTraThucUongTonTai(ct);

                    tongtien = 0;
                    foreach (var item in ds_CT)
                    {
                        tongtien += item.THANHTIEN;
                    }
                    lbl_TongTien.Text = tongtien.ToString() + " VND";

                    LoadCTHD();

                    MessageBox.Show("Ghi món thành công !");
                    LoadDM();
                }
                catch
                {
                    MessageBox.Show("Ghi món không thành công");
                    btn_RefreshDM_Click(sender, e);
                }
            }
            else
            {
                MessageBox.Show("Phải nhập số lượng món !");
                btn_RefreshDM_Click(sender, e);
            }
        }

        private void btn_XoaTU_Click(object sender, EventArgs e)
        {
            if (gv_ChiTietHD.FocusedRowHandle < 0)
                MessageBox.Show("Phải chọn một dòng !");
            else
            {
                DialogResult result = MessageBox.Show("Bạn có muốn xóa dòng đã chọn?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    gv_ChiTietHD.DeleteRow(gv_ChiTietHD.FocusedRowHandle);
                    MessageBox.Show("Xóa thành công chi tiết hóa đơn !");
                    tongtien = 0;
                    foreach (var item in ds_CT)
                    {
                        tongtien += item.THANHTIEN;
                    }
                    lbl_TongTien.Text = tongtien.ToString() + " VND";
                }
                else
                {
                    LoadCTHD();
                }
            }
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            if(txt_TenTU_TK.Text.Trim().Length <= 0)
                MessageBox.Show("Phải nhập tên thức uống !");
            else
            {
                mv_ThucUong.DataSource = da_TU.TimThucUong(txt_TenTU_TK.Text);
            }
        }

        private void lku_Loai_EditValueChanged(object sender, EventArgs e)
        {
            mv_ThucUong.DataSource = da_Loai.TimThucUong(int.Parse(lku_Loai.EditValue.ToString()));
        }
        
        private void btn_ThanhToan_Click(object sender, EventArgs e)
        {
            if(gv_ChiTietHD.DataRowCount <= 0)
                MessageBox.Show("Hóa đơn rỗng !");
            else
            {
                string tendn = TaiKhoanBLL.TenDangNhap;
                NHANVIEN nv = tk.GetNV(tendn);
                HOADON hd = new HOADON();
                hd.NGAYLAP = DateTime.Now;
                hd.TONGTIEN = int.Parse(lbl_TongTien.Text.Replace(" VND", ""));
                hd.MAKH = 11;
                hd.MANV = nv.MANV;
                hd.TRANGTHAI = true;
                
                bool t = da_HD.ThemHD(hd);
                if(!t)
                {
                    MessageBox.Show("Thanh toán thất bại !");
                }
                else
                {
                    bool flag = true;
                    foreach(CHITIET_THUCUONG item in gv_ChiTietHD.DataController.ListSource)
                    {
                        CHITIET_THUCUONG ct = new CHITIET_THUCUONG();
                        ct.MAHD = da_HD.LayMaHD_MoiThem();
                        ct.MATU = item.MATU;
                        ct.SL = item.SL;
                        ct.GIABAN = item.GIABAN;
                        ct.THANHTIEN = item.THANHTIEN;

                        bool b = da_HD.ThemCTHD(ct);
                        if (!b)
                        {
                            flag = false;
                            break;
                        }
                        else
                        {
                            da_HD.ChinhSuaSL_KhiThanhToan(ct.MATU, (int)ct.SL);
                        }
                    }
                    if(flag)
                    {
                        MessageBox.Show("Thanh toán thành công !");

                        uct_DatMon_Load(sender, e);

                        gv_ChiTietHD.GridControl.DataSource = null;
                        ds_CT.Clear();
                        gv_ChiTietHD.RefreshData();
                        LoadCTHD();
                        lbl_TongTien.Text = "0 VND";
                    }
                    else
                        MessageBox.Show("Thanh toán thất bại !");
                }
            }
        }




        
    }
}
