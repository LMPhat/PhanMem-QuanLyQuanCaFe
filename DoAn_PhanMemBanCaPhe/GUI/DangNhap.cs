using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BLL;

namespace GUI
{
    public partial class DangNhap : DevExpress.XtraEditors.XtraForm
    {
        TaiKhoanBLL da = new TaiKhoanBLL();
        
        public DangNhap()
        {
            InitializeComponent();
        }

        private void btn_DN_Click(object sender, EventArgs e)
        {
            if (txt_TenDN.Text == "" || txt_MatKhau.Text == "")
                MessageBox.Show("Nhập đầy đủ Tên đăng nhập và Mật khẩu !");
            else
            {
                int dn = da.KTra_DN(txt_TenDN.Text, txt_MatKhau.Text);
                if (dn == -1)
                    MessageBox.Show("Tài khoản không tồn tại !");
                else
                {
                    if(dn == 0)
                        MessageBox.Show("Sai tên đăng nhập hoặc tài khoản !");
                    else
                    {
                        TaiKhoanBLL.TenDangNhap = txt_TenDN.Text;
                        Program.mainFrom = new frmMain();
                        this.Visible = false;
                        Program.mainFrom.Show();
                    }
                }
            }
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            txt_TenDN.Text = "";
            txt_MatKhau.Text = "";
        }

        private void DangNhap_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }


    }
}