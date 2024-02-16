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

namespace GUI
{
    public partial class uct_NhomNgD : DevExpress.XtraEditors.XtraUserControl
    {
        NhomNgDBLL da = new NhomNgDBLL();
        public uct_NhomNgD()
        {
            InitializeComponent();
        }

        private void uct_NhomNgD_Load(object sender, EventArgs e)
        {
            textEdit1.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;

            LoadNGD();
        }

        void LoadNGD()
        {
            mv_NGD.DataSource = da.GetNGD();
            gv_NGD.OptionsSelection.EnableAppearanceFocusedRow = false;

            btn_ThemNGD.Enabled = true;

            btn_LuuNGD.Enabled = false;
            txt_TenNGD.Enabled = false;
            btn_SuaNGD.Enabled = false;

            txt_TenNGD.Text = "";
        }

        private void btn_ThemNGD_Click(object sender, EventArgs e)
        {
            btn_LuuNGD.Enabled = true;
            txt_TenNGD.Enabled = true;
            btn_SuaNGD.Enabled = true;

            btn_ThemNGD.Enabled = false;
        }

        private void btn_RefreshNGD_Click(object sender, EventArgs e)
        {
            LoadNGD();
        }

        private void gv_NGD_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (gv_NGD.FocusedRowHandle >= 0)
            {
                txt_TenNGD.Text = gv_NGD.GetRowCellValue(gv_NGD.FocusedRowHandle, "TENNHOM").ToString();
            }
        }

        private void btn_LuuNGD_Click(object sender, EventArgs e)
        {
            if (txt_TenNGD.Text.Trim() == "")
                MessageBox.Show("Tên nhóm không được để trống !");
            else
            {
                bool t = da.ThemNGD(txt_TenNGD.Text);
                if (!t)
                {
                    MessageBox.Show("Tên nhóm đã tồn tại !");
                }
                LoadNGD();
            }
        }

        private void btn_SuaNGD_Click(object sender, EventArgs e)
        {
            if (gv_NGD.FocusedRowHandle < 0 || txt_TenNGD.Text.Trim() == "")
                MessageBox.Show("Phải chọn một dòng !");
            else
            {
                QLNhomNguoiDung l = new QLNhomNguoiDung();
                l.MANHOM = int.Parse(gv_NGD.GetRowCellDisplayText(gv_NGD.FocusedRowHandle, "MANHOM"));
                l.TENNHOM = txt_TenNGD.Text;
                bool t = da.SuaNGD(l);
                if (!t)
                {
                    MessageBox.Show("Tên nhóm đã tồn tại !");
                }
                LoadNGD();
            }
        }

        private void btn_XoaNGD_Click(object sender, EventArgs e)
        {
            if (gv_NGD.FocusedRowHandle < 0 || txt_TenNGD.Text.Trim() == "")
                MessageBox.Show("Phải chọn một dòng !");
            else
            {
                DialogResult result = MessageBox.Show("Bạn có muốn xóa dòng đã chọn?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    QLNhomNguoiDung l = new QLNhomNguoiDung();
                    l.MANHOM = int.Parse(gv_NGD.GetRowCellDisplayText(gv_NGD.FocusedRowHandle, "MANHOM"));
                    int t = da.XoaNGD(l.MANHOM);
                    if (t == -1)
                    {
                        MessageBox.Show("Nhóm không tồn tại !");
                    }
                    else
                    {
                        if (t == 0)
                            MessageBox.Show("Xóa không thành công !");
                        else
                            LoadNGD();
                    }
                }
            }
        }


    }
}
