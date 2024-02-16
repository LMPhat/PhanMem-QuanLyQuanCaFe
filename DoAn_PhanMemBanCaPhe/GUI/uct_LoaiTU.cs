using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace GUI
{
    public partial class uct_LoaiTU : UserControl
    {
        LoaiThucUongBLL da = new LoaiThucUongBLL();
        public uct_LoaiTU()
        {
            InitializeComponent();
        }

        private void uct_LoaiTU_Load(object sender, EventArgs e)
        {
            textEdit1.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;

            LoadLoai();
        }

        void LoadLoai()
        {
            mv_Loai.DataSource = da.GetLoai();
            gv_Loai.OptionsSelection.EnableAppearanceFocusedRow = false;

            btn_ThemLoai.Enabled = true;

            btn_LuuLoai.Enabled = false;
            txt_TenLoai.Enabled = false;
            btn_SuaLoai.Enabled = false;

            txt_TenLoai.Text = "";
        }

        private void btn_ThemLoai_Click(object sender, EventArgs e)
        {
            btn_LuuLoai.Enabled = true;
            txt_TenLoai.Enabled = true;
            btn_SuaLoai.Enabled = true;

            btn_ThemLoai.Enabled = false;
        }

        private void gv_Loai_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (gv_Loai.FocusedRowHandle >= 0)
            {
                txt_TenLoai.Text = gv_Loai.GetRowCellValue(gv_Loai.FocusedRowHandle, "TENLOAI").ToString();
            }
        }

        private void btn_RefreshLoai_Click(object sender, EventArgs e)
        {
            LoadLoai();
        }

        private void btn_LuuLoai_Click(object sender, EventArgs e)
        {
            if (txt_TenLoai.Text.Trim() == "")
                MessageBox.Show("Tên loại không được để trống !");
            else
            {
                bool t = da.ThemLoai(txt_TenLoai.Text);
                if (!t)
                {
                    MessageBox.Show("Tên loại đã tồn tại !");
                }
                LoadLoai();
            }
        }

        private void btn_SuaLoai_Click(object sender, EventArgs e)
        {
            if (gv_Loai.FocusedRowHandle < 0 || txt_TenLoai.Text.Trim() == "")
                MessageBox.Show("Phải chọn một dòng !");
            else
            {
                LOAIMONNUOC l = new LOAIMONNUOC();
                l.MALOAI = int.Parse(gv_Loai.GetRowCellDisplayText(gv_Loai.FocusedRowHandle, "MALOAI"));
                l.TENLOAI = txt_TenLoai.Text;
                bool t = da.SuaLoai(l);
                if (!t)
                {
                    MessageBox.Show("Tên loại đã tồn tại !");
                }
                LoadLoai();
            }
        }

        private void btn_XoaLoai_Click(object sender, EventArgs e)
        {
            if (gv_Loai.FocusedRowHandle < 0 || txt_TenLoai.Text.Trim() == "")
                MessageBox.Show("Phải chọn một dòng !");
            else
            {
                DialogResult result = MessageBox.Show("Bạn có muốn xóa dòng đã chọn?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    LOAIMONNUOC l = new LOAIMONNUOC();
                    l.MALOAI = int.Parse(gv_Loai.GetRowCellDisplayText(gv_Loai.FocusedRowHandle, "MALOAI"));
                    int t = da.XoaLoai(l.MALOAI);
                    if (t == -1)
                    {
                        MessageBox.Show("Loại không tồn tại !");
                    }
                    else
                    {
                        if(t == 0)
                            MessageBox.Show("Xóa không thành công !");
                        else
                            LoadLoai();
                    }
                }                
            }
        }

        

        
    }
}
