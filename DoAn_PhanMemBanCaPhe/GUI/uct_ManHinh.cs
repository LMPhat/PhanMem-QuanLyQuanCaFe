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
    public partial class uct_ManHinh : DevExpress.XtraEditors.XtraUserControl
    {
        ManHinhBLL da = new ManHinhBLL();
        public uct_ManHinh()
        {
            InitializeComponent();
        }

        private void uct_ManHinh_Load(object sender, EventArgs e)
        {
            textEdit1.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;

            LoadMH();
        }

        void LoadMH()
        {
            mv_MH.DataSource = da.GetMH();
            gv_MH.OptionsSelection.EnableAppearanceFocusedRow = false;

            btn_ThemMH.Enabled = true;

            btn_LuuMH.Enabled = false;
            txt_TenMH.Enabled = false;
            btn_SuaMH.Enabled = false;

            txt_TenMH.Text = "";
        }

        private void btn_ThemMH_Click(object sender, EventArgs e)
        {
            btn_LuuMH.Enabled = true;
            txt_TenMH.Enabled = true;
            btn_SuaMH.Enabled = true;

            btn_ThemMH.Enabled = false;
        }

        private void btn_RefreshMH_Click(object sender, EventArgs e)
        {
            LoadMH();
        }

        private void gv_MH_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (gv_MH.FocusedRowHandle >= 0)
            {
                txt_TenMH.Text = gv_MH.GetRowCellValue(gv_MH.FocusedRowHandle, "TENMANHINH").ToString();
            }
        }

        private void btn_LuuMH_Click(object sender, EventArgs e)
        {
            if (txt_TenMH.Text.Trim() == "")
                MessageBox.Show("Tên màn hình không được để trống !");
            else
            {
                bool t = da.ThemMH(txt_TenMH.Text);
                if (!t)
                {
                    MessageBox.Show("Tên màn hình đã tồn tại !");
                }
                LoadMH();
            }
        }

        private void btn_SuaMH_Click(object sender, EventArgs e)
        {
            if (gv_MH.FocusedRowHandle < 0 || txt_TenMH.Text.Trim() == "")
                MessageBox.Show("Phải chọn một dòng !");
            else
            {
                DMManHinh l = new DMManHinh();
                l.MAMANHINH = int.Parse(gv_MH.GetRowCellDisplayText(gv_MH.FocusedRowHandle, "MAMANHINH"));
                l.TENMANHINH = txt_TenMH.Text;
                bool t = da.SuaMH(l);
                if (!t)
                {
                    MessageBox.Show("Tên màn hình đã tồn tại !");
                }
                LoadMH();
            }
        }

        private void btn_XoaMH_Click(object sender, EventArgs e)
        {
            if (gv_MH.FocusedRowHandle < 0 || txt_TenMH.Text.Trim() == "")
                MessageBox.Show("Phải chọn một dòng !");
            else
            {
                DialogResult result = MessageBox.Show("Bạn có muốn xóa dòng đã chọn?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    DMManHinh l = new DMManHinh();
                    l.MAMANHINH = int.Parse(gv_MH.GetRowCellDisplayText(gv_MH.FocusedRowHandle, "MAMANHINH"));
                    int t = da.XoaMH(l.MAMANHINH);
                    if (t == -1)
                    {
                        MessageBox.Show("Màn hình không tồn tại !");
                    }
                    else
                    {
                        if (t == 0)
                            MessageBox.Show("Xóa không thành công !");
                        else
                            LoadMH();
                    }
                }
            }
        }
    }
}
