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
    public partial class uct_ThemNgDVaoNhom : DevExpress.XtraEditors.XtraUserControl
    {
        NhanVienBLL da_nv = new NhanVienBLL();
        NhomNgDBLL da_nhom = new NhomNgDBLL();
        NgDungNhomNgDungBLL da_NDNhomND = new NgDungNhomNgDungBLL();
        private RepositoryItemLookUpEdit ril;
        public uct_ThemNgDVaoNhom()
        {
            InitializeComponent();
            lku_NhomNgD.Properties.DataSource = da_nhom.GetNGD();
            lku_NhomNgD.Properties.DisplayMember = "TENNHOM";
            lku_NhomNgD.Properties.ValueMember = "MANHOM";
            //lku_NhomNgD.EditValue = -1;
        }

        private void InitializeLookUpEdit()
        {
            ril = new RepositoryItemLookUpEdit();

            // Thiết lập các thuộc tính của RepositoryItemLookUpEdit
            ril.DataSource = da_nhom.GetNGD(); // Đặt nguồn dữ liệu
            ril.DisplayMember = "TENNHOM"; // Chọn trường hiển thị
            ril.ValueMember = "MANHOM"; // Chọn trường giá trị
            ril.AutoHeight = false; // Tắt chế độ tự động điều chỉnh chiều cao
            // Các thiết lập khác nếu cần thiết

            // Áp dụng RepositoryItemLookUpEdit cho cột GridControl (hoặc một control khác)
            GridColumn colMALoai = gv_NgDTrongNhom.Columns["MANHOM"];
            colMALoai.ColumnEdit = ril;
        }

        private void uct_ThemNgDVaoNhom_Load(object sender, EventArgs e)
        {
            textEdit1.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            LoadND();
            LoadNDNhomND();
        }

        void LoadND()
        {
            mv_ND.DataSource = da_nv.GetNV();
            gv_ND.OptionsSelection.EnableAppearanceFocusedRow = false;

            gv_ND.Columns["MaNV"].Visible = false;
            gv_ND.Columns["Sdt"].Visible = false;
            gv_ND.Columns["GioTinh"].Visible = false;
        }

        void LoadNDNhomND()
        {
            mv_NgDTrongNhom.DataSource = da_NDNhomND.GetNhomND();
            gv_NgDTrongNhom.OptionsSelection.EnableAppearanceFocusedRow = false;
            InitializeLookUpEdit();
            gv_NgDTrongNhom.Columns[2].Visible = false;
            gv_NgDTrongNhom.Columns[3].Visible = false;
        }

        private void btn_RefreshNDNhomND_Click(object sender, EventArgs e)
        {
            lku_NhomNgD.EditValue = null;
            gv_NgDTrongNhom.GridControl.DataSource = null;
            gv_NgDTrongNhom.RefreshData();
            LoadNDNhomND();
        } 

        private void lku_NhomNgD_EditValueChanged(object sender, EventArgs e)
        {
            if (lku_NhomNgD.EditValue != null)
            {
                mv_NgDTrongNhom.DataSource = da_NDNhomND.GetNDNhomND(int.Parse(lku_NhomNgD.EditValue.ToString()));
                gv_NgDTrongNhom.Columns[2].Visible = false;
                gv_NgDTrongNhom.Columns[3].Visible = false;
            }
        }

        private void pte_ThemVaoNhom_Click(object sender, EventArgs e)
        {
            if (lku_NhomNgD.EditValue == null || gv_ND.SelectedRowsCount < 0)
                MessageBox.Show("Hãy chọn nhóm người dùng !");
            else
            {
                QLNguoiDungNhonNguoiDung n = new QLNguoiDungNhonNguoiDung();
                n.TENDANGNHAP = gv_ND.GetRowCellDisplayText(gv_ND.FocusedRowHandle, "TenDN");
                n.MANHOM = int.Parse(lku_NhomNgD.EditValue.ToString());

                int t = da_NDNhomND.ThemNDVaoNhom(n);
                if (t == 0)
                {
                    MessageBox.Show("Thêm người dùng vào nhóm không thành công !");
                }
                else
                {
                    if (t == -1)
                        MessageBox.Show("Người dùng đã có trong nhóm !");
                    else
                    {
                        if (lku_NhomNgD.EditValue != null)
                        {
                            //MessageBox.Show("Thêm người dùng vào nhóm không thành công !");
                            MessageBox.Show("Thêm người dùng vào nhóm thành công.");
                            mv_NgDTrongNhom.DataSource = da_NDNhomND.GetNDNhomND(int.Parse(lku_NhomNgD.EditValue.ToString()));
                            gv_NgDTrongNhom.Columns[2].Visible = false;
                            gv_NgDTrongNhom.Columns[3].Visible = false;
                        }
                        
                    }
                }
            }
        }

        private void pte_XoaKhoiNhom_Click(object sender, EventArgs e)
        {
            if (gv_NgDTrongNhom.FocusedRowHandle < 0)
                MessageBox.Show("Phải chọn một dòng !");
            else
            {
                DialogResult result = MessageBox.Show("Bạn có muốn xóa dòng đã chọn?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    QLNguoiDungNhonNguoiDung n = new QLNguoiDungNhonNguoiDung();
                    n.TENDANGNHAP = gv_NgDTrongNhom.GetRowCellDisplayText(gv_NgDTrongNhom.FocusedRowHandle, "TENDANGNHAP");
                    //n.MANHOM = int.Parse(gv_NgDTrongNhom.GetRowCellDisplayText(gv_NgDTrongNhom.FocusedRowHandle, "MANHOM").ToString());
                    // Lấy giá trị từ RepositoryItemLookUpEdit
                    n.MANHOM = int.Parse(gv_NgDTrongNhom.GetRowCellValue(gv_NgDTrongNhom.FocusedRowHandle, "MANHOM").ToString());

                    //// Nếu giá trị không phải là null, bạn có thể chuyển đổi nó thành kiểu int
                    //if (manhomValue != null)
                    //{
                    //    int manhom = Convert.ToInt32(manhomValue);
                    //    // Tiếp tục sử dụng giá trị manhom
                    //    n.MANHOM = manhom;
                    //}
                    int t = da_NDNhomND.XoaNDKhoiNhom(n);
                    if (t == 0)
                        MessageBox.Show("Xóa không thành công !");
                    else
                    {
                        MessageBox.Show("Xóa thành công !");
                        LoadNDNhomND();
                    }
                }
            }
        }

        
    }
}
