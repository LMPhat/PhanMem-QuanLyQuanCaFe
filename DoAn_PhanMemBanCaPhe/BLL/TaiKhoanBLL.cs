using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class TaiKhoanBLL
    {
        QLQuanCaPheDataContext da = new QLQuanCaPheDataContext();
        private static string _tenDangNhap;

        public static string TenDangNhap
        {
            get { return _tenDangNhap; }
            set { _tenDangNhap = value; }
        }
        public int KTra_DN(string tenDN, string mk)
        {
            //-1: tài khoản không tồn tại; 0: sai mật khẩu; 1: đặng nhập thành công
            ACCOUNT acc_TT = da.ACCOUNTs.Where(f => f.TENDANGNHAP == tenDN && f.TRANGTHAI == true).FirstOrDefault();
            NHANVIEN nv = da.NHANVIENs.Where(f => f.TENDANGNHAP == tenDN).FirstOrDefault();
            if (acc_TT != null && nv != null)
            {
                ACCOUNT acc_MK = da.ACCOUNTs.Where(f => f.TENDANGNHAP == tenDN && f.MATKHAU == mk).FirstOrDefault();
                if (acc_MK != null)
                {
                    return 1;
                }
                else
                    return 0;
            }
            else
                return -1;
        }
        public NHANVIEN GetNV(string tendn)
        {
            NHANVIEN nv = da.NHANVIENs.Where(f => f.TENDANGNHAP == tendn).FirstOrDefault();
            return nv;
        }
    }
}
