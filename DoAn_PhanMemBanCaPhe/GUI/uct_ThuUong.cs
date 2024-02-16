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
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;

namespace GUI
{
    public partial class uct_ThuUong : DevExpress.XtraEditors.XtraUserControl
    {
        ThucUongBLL da_tu = new ThucUongBLL();
        LoaiThucUongBLL da_Loai = new LoaiThucUongBLL();
        private RepositoryItemLookUpEdit ril;
        public uct_ThuUong()
        {
            InitializeComponent();

            lku_Loai.Properties.DataSource = da_Loai.GetLoai();
            lku_Loai.Properties.DisplayMember = "TENLOAI";
            lku_Loai.Properties.ValueMember = "MALOAI";
            lku_Loai.EditValue = 3;
        }

        private void InitializeLookUpEdit()
        {
            ril = new RepositoryItemLookUpEdit();

            // Thiết lập các thuộc tính của RepositoryItemLookUpEdit
            ril.DataSource = da_Loai.GetLoai(); // Đặt nguồn dữ liệu
            ril.DisplayMember = "TENLOAI"; // Chọn trường hiển thị
            ril.ValueMember = "MALOAI"; // Chọn trường giá trị
            ril.AutoHeight = false; // Tắt chế độ tự động điều chỉnh chiều cao
            // Các thiết lập khác nếu cần thiết

            // Áp dụng RepositoryItemLookUpEdit cho cột GridControl (hoặc một control khác)
            GridColumn colMALoai = gv_ThucUong.Columns["MALOAI"];
            colMALoai.ColumnEdit = ril;

            
        }

        private void uct_ThuUong_Load(object sender, EventArgs e)
        {
            textEdit1.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;

            LoadTU();
        }

        void LoadTU()
        {
            mv_ThucUong.DataSource = da_tu.GetThucUong();
            gv_ThucUong.OptionsSelection.EnableAppearanceFocusedRow = false;

            InitializeLookUpEdit();

            btn_ThemTU.Enabled = true;

            btn_LuuTU.Enabled = false;
            btn_SuaTU.Enabled = false;

            txt_TenTU.Enabled = false;
            lku_Loai.Enabled = false;
            txt_SoLuong.Enabled = false;
            txt_DonGia.Enabled = false;
            cke_TrangThai.Enabled = false;

            //pictureEdit1.Enabled = false;

            txt_TenTU.Text = "";
            txt_SoLuong.Text = "";
            txt_DonGia.Text = "";
            cke_TrangThai.Checked = false;

            pictureEdit1.Image = null;
        }

        private void btn_RefreshTU_Click(object sender, EventArgs e)
        {
            LoadTU();
        }

        private string GetTenHinhAnhFromDataSource(int rowIndex)
        {
            // Giả sử bạn lưu trữ tên hình ảnh trong cột có tên "TenHinhAnh" của GridControl
            return gv_ThucUong.GetRowCellValue(rowIndex, "HINHANH").ToString();
        }

        private void gv_ThucUong_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (gv_ThucUong.FocusedRowHandle >= 0)
            {
                txt_TenTU.Text = gv_ThucUong.GetRowCellValue(gv_ThucUong.FocusedRowHandle, "TENTU").ToString();
                txt_SoLuong.Text = gv_ThucUong.GetRowCellValue(gv_ThucUong.FocusedRowHandle, "SL").ToString();
                txt_DonGia.Text = gv_ThucUong.GetRowCellValue(gv_ThucUong.FocusedRowHandle, "DONGIA").ToString();
                lku_Loai.EditValue = int.Parse(gv_ThucUong.GetRowCellValue(gv_ThucUong.FocusedRowHandle, "MALOAI").ToString());

                string image = gv_ThucUong.GetRowCellValue(gv_ThucUong.FocusedRowHandle, "HINHANH").ToString();
                string projectFolder = Path.GetFullPath(Path.Combine(Application.StartupPath, @"..\..\"));

                // Đường dẫn đầy đủ của tệp hình ảnh trong thư mục HinhAnh
                string imagePath = Path.Combine(projectFolder, "HinhAnh", image);

                pictureEdit1.Image = Image.FromFile(imagePath);

                string temp = gv_ThucUong.GetRowCellDisplayText(gv_ThucUong.FocusedRowHandle, "TRANGTHAI");
                if (temp == "Checked")
                    cke_TrangThai.Checked = true;
                else
                    cke_TrangThai.Checked = false;
            }
        }

        string sourcePath = "";
        string imageName = "";
        private void pictureEdit1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if(open.ShowDialog() == DialogResult.OK)
            {
                pictureEdit1.Image = Image.FromFile(open.FileName);

                // Lưu tên của hình ảnh
                sourcePath = open.FileName;
                imageName = Path.GetFileName(open.FileName);
            }
        }

        private void btn_ThemTU_Click(object sender, EventArgs e)
        {
            btn_LuuTU.Enabled = true;
            btn_SuaTU.Enabled = true;

            txt_TenTU.Enabled = true;
            lku_Loai.Enabled = true;
            txt_SoLuong.Enabled = true;
            txt_DonGia.Enabled = true;
            cke_TrangThai.Enabled = true;

            btn_ThemTU.Enabled = false;
        }

        private void btn_LuuTU_Click(object sender, EventArgs e)
        {
            if (txt_TenTU.Text == "" || txt_SoLuong.Text == "" || txt_DonGia.Text == "" || string.IsNullOrEmpty(imageName))
                MessageBox.Show("Thông tin không được để trống !");
            else
            {
                THUCUONG tu = new THUCUONG();
                tu.TENTU = txt_TenTU.Text;
                tu.SL = int.Parse(txt_SoLuong.Text);
                tu.DONGIA = int.Parse(txt_DonGia.Text);
                tu.MALOAI = int.Parse(lku_Loai.EditValue.ToString());
                tu.HINHANH = imageName;
                if (cke_TrangThai.Checked)
                    tu.TRANGTHAI = true;
                else
                    tu.TRANGTHAI = false;
                
                bool t = da_tu.ThemTU(tu);
                if (!t)
                {
                    MessageBox.Show("Tên loại đã tồn tại !");
                }
                else
                {
                    // Lưu hình ảnh vào thư mục
                    if (!string.IsNullOrEmpty(imageName))
                    {
                        //Lưu vào winform
                        string projectFolder = Path.GetFullPath(Path.Combine(Application.StartupPath, @"..\..\"));

                        // Đường dẫn đầy đủ của tệp hình ảnh trong thư mục HinhAnh
                        string imagePath = Path.Combine(projectFolder, "HinhAnh", imageName);
                        File.Copy(sourcePath, imagePath, true);

                        //Lưu vào web
                        string projectFolder_Web = Path.GetFullPath(Path.Combine(Application.StartupPath, @"..\..\..\..\"));

                        // Đường dẫn đầy đủ của tệp hình ảnh trong thư mục HinhAnh
                        string imagePath_Web = Path.Combine(projectFolder_Web, @"DoAn_WebBanCaPhe\DoAn_WebBanCaPhe\HinhAnh", imageName);
                        File.Copy(sourcePath, imagePath_Web, true);
                    }

                    LoadTU();
                }
            }
        }

        private void btn_SuaTU_Click(object sender, EventArgs e)
        {
            if (gv_ThucUong.FocusedRowHandle < 0 || txt_TenTU.Text == "" || txt_SoLuong.Text == "" || txt_DonGia.Text == "")
                MessageBox.Show("Phải chọn một thức uống !");
            else
            {
                THUCUONG tu = new THUCUONG();
                tu.MATU = int.Parse(gv_ThucUong.GetRowCellDisplayText(gv_ThucUong.FocusedRowHandle, "MATU"));
                tu.TENTU = txt_TenTU.Text;
                tu.SL = int.Parse(txt_SoLuong.Text);
                tu.DONGIA = int.Parse(txt_DonGia.Text);
                tu.MALOAI = int.Parse(lku_Loai.EditValue.ToString());
                tu.TRANGTHAI = cke_TrangThai.Checked;

                //tu.HINHANH = imageName;

                ////lấy tên image cũ 
                //THUCUONG tu_old = da_tu.TimTU(tu.MATU);
                //string imageName_old = tu_old.HINHANH;

                bool t = da_tu.SuaTU(tu);
                if (!t)
                {
                    MessageBox.Show("Tên thức uống đã tồn tại !");
                }
                else
                {
                    //// Lưu hình ảnh vào thư mục
                    //if (!string.IsNullOrEmpty(imageName))
                    //{
                    //    //Lưu vào winform
                    //    string projectFolder = Path.GetFullPath(Path.Combine(Application.StartupPath, @"..\..\"));
                    //    //Xóa hình ảnh cũ
                    //    string oldImagePath = Path.Combine(projectFolder, "HinhAnh", imageName_old);
                    //    File.Delete(oldImagePath);

                    //    //thêm hình ảnh mới
                    //    string imagePath = Path.Combine(projectFolder, "HinhAnh", imageName);
                    //    File.Copy(sourcePath, imagePath, true);

                    //    //Lưu vào web
                    //    string projectFolder_Web = Path.GetFullPath(Path.Combine(Application.StartupPath, @"..\..\..\..\"));
                    //    //Xóa hình ảnh cũ
                    //    string oldImagePath_Web = Path.Combine(projectFolder, @"DoAn_WebBanCaPhe\DoAn_WebBanCaPhe\HinhAnh", imageName_old);
                    //    File.Delete(oldImagePath);

                    //    //Thêm hình ảnh mới
                    //    string imagePath_Web = Path.Combine(projectFolder_Web, @"DoAn_WebBanCaPhe\DoAn_WebBanCaPhe\HinhAnh", imageName);
                    //    File.Copy(sourcePath, imagePath_Web, true);
                    //}

                    LoadTU();
                }
            }
        }

        private void gv_ThucUong_ShownEditor(object sender, EventArgs e)
        {
            GridView view = sender as GridView;
            if (view.FocusedColumn.FieldName == "TRANGTHAI")
            {
                DialogResult result = MessageBox.Show("Bạn có muốn chỉnh sửa trạng thái hoạt động?", "Xác nhận chỉnh sửa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    string temp = gv_ThucUong.GetRowCellDisplayText(gv_ThucUong.FocusedRowHandle, "TRANGTHAI");

                    THUCUONG tu = new THUCUONG();
                    tu.MATU = int.Parse(gv_ThucUong.GetRowCellDisplayText(gv_ThucUong.FocusedRowHandle, "MATU"));
                    tu.TENTU = txt_TenTU.Text;
                    tu.SL = int.Parse(txt_SoLuong.Text);
                    tu.DONGIA = int.Parse(txt_DonGia.Text);
                    tu.MALOAI = int.Parse(lku_Loai.EditValue.ToString());
                    if (temp == "Checked")
                        tu.TRANGTHAI = false;
                    else
                        tu.TRANGTHAI = true;

                    bool t = da_tu.SuaTU(tu);
                    if (!t)
                    {
                        MessageBox.Show("Tên thức uống đã tồn tại !");
                    }
                    else
                    {
                        LoadTU();
                    }
                }
                else
                {
                    LoadTU();
                }
            }
        }

        private void btn_XoaTU_Click(object sender, EventArgs e)
        {
            if (gv_ThucUong.FocusedRowHandle < 0 || txt_TenTU.Text.Trim() == "")
                MessageBox.Show("Phải chọn một dòng !");
            else
            {
                DialogResult result = MessageBox.Show("Bạn có muốn xóa dòng đã chọn?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    THUCUONG l = new THUCUONG();
                    l.MATU = int.Parse(gv_ThucUong.GetRowCellDisplayText(gv_ThucUong.FocusedRowHandle, "MATU"));
                    int t = da_tu.XoaTU(l.MATU);
                    if (t == -1)
                    {
                        MessageBox.Show("Thức uống không tồn tại !");
                    }
                    else
                    {
                        if (t == 0)
                            MessageBox.Show("Xóa không thành công !");
                        else
                        {
                            MessageBox.Show("Xóa thức uống thành công !");
                            LoadTU();
                        }
                    }
                }
            }
        }



        
        
    }
}
