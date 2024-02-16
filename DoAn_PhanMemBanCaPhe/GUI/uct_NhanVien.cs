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
using DTO;
using DevExpress.XtraGrid.Views.Grid;

namespace GUI
{
    public partial class uct_NhanVien : DevExpress.XtraEditors.XtraUserControl
    {
        NhanVienBLL da = new NhanVienBLL();
        public uct_NhanVien()
        {
            InitializeComponent();
        }

        private void uct_NhanVien_Load(object sender, EventArgs e)
        {
            textEdit1.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;

            LoadNV();
        }

        void LoadNV()
        {
            mv_NV.DataSource = da.GetNV();
            gv_NV.OptionsSelection.EnableAppearanceFocusedRow = false;

            btn_ThemNV.Enabled = true;

            btn_LuuNV.Enabled = false;
            btn_SuaNV.Enabled = false;
            txt_TenNV.Enabled = false;
            txt_SDT.Enabled = false;
            txt_TenDN.Enabled = false;
            txt_MK.Enabled = false;
            rdo_GT.Enabled = false;
            cke_TrangThai.Enabled = false;

            txt_TenNV.Text = "";
            txt_SDT.Text = "";
            txt_TenDN.Text = "";
            txt_MK.Text = "";
            rdo_GT.SelectedIndex = -1;
            cke_TrangThai.Checked = false;
        }

        private void btn_ThemNV_Click(object sender, EventArgs e)
        {
            btn_LuuNV.Enabled = true;
            btn_SuaNV.Enabled = true;
            txt_TenNV.Enabled = true;
            txt_SDT.Enabled = true;
            txt_TenDN.Enabled = true;
            txt_MK.Enabled = true;
            rdo_GT.Enabled = true;
            cke_TrangThai.Enabled = true;

            btn_ThemNV.Enabled = false;
        }

        private void btn_RefreshNV_Click(object sender, EventArgs e)
        {
            LoadNV();
        }

        private void gv_NV_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (gv_NV.FocusedRowHandle >= 0)
            {
                txt_TenNV.Text = gv_NV.GetRowCellValue(gv_NV.FocusedRowHandle, "TenNV").ToString();
                txt_SDT.Text = gv_NV.GetRowCellValue(gv_NV.FocusedRowHandle, "Sdt").ToString();
                txt_TenDN.Text = gv_NV.GetRowCellValue(gv_NV.FocusedRowHandle, "TenDN").ToString();
                txt_MK.Text = gv_NV.GetRowCellValue(gv_NV.FocusedRowHandle, "MatKhau").ToString();

                rdo_GT.EditValue = gv_NV.GetRowCellValue(gv_NV.FocusedRowHandle, "GioTinh").ToString();

                string temp = gv_NV.GetRowCellDisplayText(gv_NV.FocusedRowHandle, "TrangThai");
                if (temp == "Checked")
                    cke_TrangThai.Checked = true;
                else
                    cke_TrangThai.Checked = false;
            }
        }

        private void btn_LuuNV_Click(object sender, EventArgs e)
        {
            if (txt_TenNV.Text == "" || txt_SDT.Text == "" || txt_TenDN.Text == "" || txt_MK.Text == "" || rdo_GT.SelectedIndex == -1)
                MessageBox.Show("Thông tin không được để trống !");
            else
            {
                NhanVien nv = new NhanVien();
                nv.TenDN = txt_TenDN.Text;
                nv.MatKhau = txt_MK.Text;
                nv.TenNV = txt_TenNV.Text;
                nv.Sdt = txt_SDT.Text;
                nv.GioTinh = rdo_GT.EditValue.ToString();

                bool t = da.ThemNV(nv);
                if (!t)
                {
                    MessageBox.Show("Thêm nhân viên không thành công !");
                }
                LoadNV();
            }
        }

        private void btn_SuaNV_Click(object sender, EventArgs e)
        {
            if (gv_NV.SelectedRowsCount < 0 || txt_TenNV.Text == "" || txt_SDT.Text == "" || txt_TenDN.Text == "" || txt_MK.Text == "" || rdo_GT.SelectedIndex == -1)
                MessageBox.Show("Phải chọn một nhân viên !");
            else
            {

                NhanVien nv = new NhanVien();
                nv.MaNV = int.Parse(gv_NV.GetRowCellDisplayText(gv_NV.FocusedRowHandle, "MaNV"));
                nv.TenNV = txt_TenNV.Text;
                nv.Sdt = txt_SDT.Text;
                nv.GioTinh = rdo_GT.EditValue.ToString();
                nv.TrangThai = cke_TrangThai.Checked;

                bool t = da.SuaNV(nv);
                if (!t)
                {
                    MessageBox.Show("Chỉnh sửa nhân viên không thành công !");
                }
                else
                {
                    LoadNV();
                }
            }
        }

        private void gv_NV_ShownEditor(object sender, EventArgs e)
        {
            GridView view = sender as GridView;
            if (view.FocusedColumn.FieldName == "TrangThai")
            {
                DialogResult result = MessageBox.Show("Bạn có muốn chỉnh sửa trạng thái hoạt động?", "Xác nhận chỉnh sửa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    string temp = gv_NV.GetRowCellDisplayText(gv_NV.FocusedRowHandle, "TrangThai");

                    NhanVien nv = new NhanVien();
                    nv.MaNV = int.Parse(gv_NV.GetRowCellDisplayText(gv_NV.FocusedRowHandle, "MaNV"));
                    nv.TenNV = txt_TenNV.Text;
                    nv.Sdt = txt_SDT.Text;
                    nv.GioTinh = rdo_GT.EditValue.ToString();
                    if (temp == "Checked")
                        nv.TrangThai = false;
                    else
                        nv.TrangThai = true;

                    bool t = da.SuaNV(nv);
                    if (!t)
                    {
                        MessageBox.Show("Chỉnh sửa nhân viên không thành công !");
                    }
                    else
                    {
                        LoadNV();
                    }
                }
                else
                {
                    LoadNV();
                }
            }
        }
        

    }
}
