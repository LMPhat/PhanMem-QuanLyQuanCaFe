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
    public partial class uct_DuDoan : DevExpress.XtraEditors.XtraUserControl
    {
        DuDoanBLL da = new DuDoanBLL();
        ThucUongBLL da_tu = new ThucUongBLL();
        ThuatToanBLL da_tt = new ThuatToanBLL();
        private RepositoryItemLookUpEdit ril_TU;
        public uct_DuDoan()
        {
            InitializeComponent();
        }

        private void uct_DuDoan_Load(object sender, EventArgs e)
        {
            textEdit1.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;

            LoadTT();

            lku_TU.Properties.DataSource = da_tu.GetThucUong();
            lku_TU.Properties.DisplayMember = "TENTU";
            lku_TU.Properties.ValueMember = "MATU";
        }

        private void InitializeLookUpEdit_TU()
        {
            ril_TU = new RepositoryItemLookUpEdit();

            // Thiết lập các thuộc tính của RepositoryItemLookUpEdit
            ril_TU.DataSource = da_tu.GetThucUong(); // Đặt nguồn dữ liệu
            ril_TU.DisplayMember = "TENTU"; // Chọn trường hiển thị
            ril_TU.ValueMember = "MATU"; // Chọn trường giá trị
            ril_TU.AutoHeight = false; // Tắt chế độ tự động điều chỉnh chiều cao
            // Các thiết lập khác nếu cần thiết

            // Áp dụng RepositoryItemLookUpEdit cho cột GridControl (hoặc một control khác)
            GridColumn colMALoai = gv_DD.Columns["MaTU"];
            colMALoai.ColumnEdit = ril_TU;
        }

        void LoadTT()
        {
            mv_DD.DataSource = da.GetTT();
            gv_DD.OptionsSelection.EnableAppearanceFocusedRow = false;
            gv_DD.OptionsBehavior.Editable = false;

            InitializeLookUpEdit_TU();

            //gv_HD.Columns["NHANVIEN"].Visible = false;
            //gv_HD.Columns["KHACHHANG"].Visible = false;
            te_TuNgay.Enabled = false;

            txt_SLB.Text = "";
            txt_SLN.Text = "";

            te_TuNgay.EditValue = DateTime.Now;
            
        }

        private void btn_RefreshHD_Click(object sender, EventArgs e)
        {
            LoadTT();
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            List<ThuatToan> bookDataList = da.GetTT();
            // Gọi phương thức PredictionService để huấn luyện mô hình
            da_tt.TrainAndPredict(bookDataList);

            // Dự đoán doanh số cho một cuốn sách cụ thể
            int maSach = int.Parse(lku_TU.EditValue.ToString());
            int slNhap = Int16.Parse(txt_SLN.Text);
            int slBan = Int16.Parse(txt_SLB.Text);
            DateTime thoiGian = DateTime.Now; // Bạn có thể cung cấp giá trị thời gian thích hợp từ nguồn dữ liệu

            // Gọi phương thức PredictSalesForBook và hiển thị kết quả
            double predictedSales = da_tt.PredictSalesForBook(maSach, slNhap, slBan, thoiGian);
            int predictedSalesInt = Convert.ToInt32(predictedSales); // hoặc int predictedSalesInt = int.Parse(predictedSales.ToString());
            lbl.Text += predictedSalesInt.ToString();
        }
    }
}
