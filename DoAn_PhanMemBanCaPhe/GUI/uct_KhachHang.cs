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
    public partial class uct_KhachHang : DevExpress.XtraEditors.XtraUserControl
    {
        KhachHangBLL da = new KhachHangBLL();
        public uct_KhachHang()
        {
            InitializeComponent();
        }

        private void uct_KhachHang_Load(object sender, EventArgs e)
        {
            textEdit1.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;

            LoadKH();
        }

        void LoadKH()
        {
            mv_KH.DataSource = da.GetKH();
            gv_KH.FocusedRowHandle = DevExpress.XtraGrid.GridControl.InvalidRowHandle;
            gv_KH.OptionsSelection.EnableAppearanceFocusedRow = false;
            
            btn_SuaKH.Enabled = true;
            txt_TenKH.Enabled = false;
            txt_SDT.Enabled = false;
            txt_DiaChi.Enabled = false;
            txt_TenDN.Enabled = false;
            txt_MK.Enabled = false;
            rdo_GT.Enabled = false;
            cke_TrangThai.Enabled = true;

            txt_TenKH.Text = "";
            txt_SDT.Text = "";
            txt_DiaChi.Text = "";
            txt_TenDN.Text = "";
            txt_MK.Text = "";
            rdo_GT.SelectedIndex = -1;
            cke_TrangThai.Checked = false;
        }

        private void btn_RefreshKH_Click(object sender, EventArgs e)
        {
            LoadKH();
        }

        private void gv_KH_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (gv_KH.FocusedRowHandle >= 0)
            {
                txt_TenKH.Text = gv_KH.GetRowCellValue(gv_KH.FocusedRowHandle, "TenKH").ToString();
                txt_SDT.Text = gv_KH.GetRowCellValue(gv_KH.FocusedRowHandle, "Sdt").ToString();
                txt_DiaChi.Text = gv_KH.GetRowCellValue(gv_KH.FocusedRowHandle, "DiaChi").ToString();
                txt_TenDN.Text = gv_KH.GetRowCellValue(gv_KH.FocusedRowHandle, "TenDN").ToString();
                txt_MK.Text = gv_KH.GetRowCellValue(gv_KH.FocusedRowHandle, "MatKhau").ToString();

                rdo_GT.EditValue = gv_KH.GetRowCellValue(gv_KH.FocusedRowHandle, "GioTinh").ToString();

                string temp = gv_KH.GetRowCellDisplayText(gv_KH.FocusedRowHandle, "TrangThai");
                if (temp == "Checked")
                    cke_TrangThai.Checked = true;
                else
                    cke_TrangThai.Checked = false;
            }
        }

        private void gv_KH_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            //if (e.Column.FieldName == "TrangThai") // Thay "TenCotCheckEdit" bằng tên thực của cột kiểu CheckEdit
            //{
            //    bool isChecked = (bool)e.Value;

            //    if (isChecked)
            //    {
            //        // Checkbox được chọn
            //        // Hiển thị thông báo
            //        MessageBox.Show("Checkbox đã được chọn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    }
            //    else
            //    {
            //        // Checkbox không được chọn
            //        // Hiển thị thông báo
            //        MessageBox.Show("Checkbox không được chọn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    }
            //}
        }

        private void btn_SuaKH_Click(object sender, EventArgs e)
        {
            if (gv_KH.SelectedRowsCount < 0 || txt_TenKH.Text == "" || txt_SDT.Text == "" || txt_TenDN.Text == "" || txt_MK.Text == "" || rdo_GT.SelectedIndex == -1)
                MessageBox.Show("Phải chọn một khách hàng !");
            else
            {
                DialogResult result = MessageBox.Show("Bạn có muốn chỉnh sửa trạng thái hoạt động?", "Xác nhận chỉnh sửa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    KhachHang kh = new KhachHang();
                    kh.MaKH = int.Parse(gv_KH.GetRowCellDisplayText(gv_KH.FocusedRowHandle, "MaKH"));
                    kh.TrangThai = cke_TrangThai.Checked;

                    bool t = da.SuaKH(kh);
                    if (!t)
                    {
                        MessageBox.Show("Chỉnh sửa khách hàng không thành công !");
                    }
                    else
                    {
                        LoadKH();
                    }
                }        
            }
        }

        private void gv_KH_ShownEditor(object sender, EventArgs e)
        {
            GridView view = sender as GridView;
            if (view.FocusedColumn.FieldName == "TrangThai") // Thay "TenCotCheckEdit" bằng tên thực của cột kiểu CheckEdit
            {
                DialogResult result = MessageBox.Show("Bạn có muốn chỉnh sửa trạng thái hoạt động?", "Xác nhận chỉnh sửa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    string temp = gv_KH.GetRowCellDisplayText(gv_KH.FocusedRowHandle, "TrangThai");

                    KhachHang kh = new KhachHang();
                    kh.MaKH = int.Parse(gv_KH.GetRowCellDisplayText(gv_KH.FocusedRowHandle, "MaKH"));
                    if (temp == "Checked")
                        kh.TrangThai = false;
                    else
                        kh.TrangThai = true;

                    bool t = da.SuaKH(kh);
                    if (!t)
                    {
                        MessageBox.Show("Chỉnh sửa khách hàng không thành công !");
                    }
                    else
                    {
                        LoadKH();
                    }
                }
                else
                {
                    LoadKH();
                }
                
            }
        }

        

        


    }
}
