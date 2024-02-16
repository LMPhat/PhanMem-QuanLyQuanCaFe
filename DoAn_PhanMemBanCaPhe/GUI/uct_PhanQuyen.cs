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
    public partial class uct_PhanQuyen : DevExpress.XtraEditors.XtraUserControl
    {
        NhomNgDBLL da_nhom = new NhomNgDBLL();
        ManHinhBLL da_MH = new ManHinhBLL();
        PhanQuyenBLL da_PQ = new PhanQuyenBLL();
        List<PhanQuyen> lst_PQ = new List<PhanQuyen>();
        public uct_PhanQuyen()
        {
            InitializeComponent();
        }

        private void uct_PhanQuyen_Load(object sender, EventArgs e)
        {
            textEdit1.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;

            LoadNGD();
            LoadMH();
        }

        void LoadNGD()
        {
            mv_NhomND.DataSource = da_nhom.GetNGD();
            gv_NhomND.OptionsSelection.EnableAppearanceFocusedRow = false;
            gv_NhomND.OptionsBehavior.Editable = false;
        }

        void LoadMH()
        {
            int maNhom = int.Parse(gv_NhomND.GetRowCellDisplayText(gv_NhomND.FocusedRowHandle, "MANHOM"));
            lst_PQ = da_PQ.GetPQ(maNhom);
            mv_QuyenCN.DataSource = lst_PQ;
            gv_QuyenCN.OptionsSelection.EnableAppearanceFocusedRow = false;
        }

        private void btn_LuuTU_Click(object sender, EventArgs e)
        {
            int maNhom = int.Parse(gv_NhomND.GetRowCellDisplayText(gv_NhomND.FocusedRowHandle, "MANHOM"));
            var listQuyen = gv_QuyenCN.DataSource as List<PhanQuyen>;
            bool flag = false;

            // Kiểm tra nếu listQuyen không null
            if (listQuyen != null)
            {
                foreach (PhanQuyen quyen in listQuyen)
                {
                    QLPhanQuyen ktr = da_PQ.KiemTraKhoaChinhPhanQuyen(maNhom, quyen.MaMH);

                    QLPhanQuyen pq = new QLPhanQuyen();
                    pq.MANHOM = maNhom;
                    pq.MAMANHINH = quyen.MaMH;
                    pq.QUYEN = quyen.CoQuyen;

                    if(ktr == null)
                    {
                        bool t = da_PQ.ThemPQ(pq);
                        if(!t)
                        {
                            flag = false;
                            break;
                        }
                        else
                        {
                            flag = true;
                        }
                    }
                    else
                    {
                        bool t = da_PQ.SuaPQ(pq);
                        if (!t)
                        {
                            flag = false;
                            break;
                        }
                        else
                        {
                            flag = true;
                        }
                    }
                }
                if(flag)
                    MessageBox.Show("Phân quyền thành công !");
                else
                    MessageBox.Show("Lỗi khi phân quyền !");
            }
        }

        private void gv_QuyenCN_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            
        }

        private void gv_NhomND_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            LoadMH();
        }
    }
}
