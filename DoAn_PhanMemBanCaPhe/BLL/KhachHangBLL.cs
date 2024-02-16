using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace BLL
{
    public class KhachHangBLL
    {
        QLQuanCaPheDataContext da = new QLQuanCaPheDataContext();
        public List<KhachHang> GetKH()
        {
            var query = from kh in da.KHACHHANGs
                        join tk in da.ACCOUNTs on kh.TENDANGNHAP equals tk.TENDANGNHAP
                        select new KhachHang
                        {
                            MaKH  = kh.MAKH,
                            TenKH = kh.TENKH,
                            GioTinh = kh.GIOITINH,
                            Sdt = kh.SDT,
                            DiaChi = kh.DIACHI,
                            TenDN = kh.TENDANGNHAP,
                            MatKhau = tk.MATKHAU,
                            TrangThai = tk.TRANGTHAI
                        };

            return query.ToList();
        }

        public List<KHACHHANG> GetKH_HD()
        {
            List<KHACHHANG> ds = da.KHACHHANGs.ToList();
            return ds;
        }

        public bool SuaKH(KhachHang n)
        {
            try
            {
                KHACHHANG kh = da.KHACHHANGs.FirstOrDefault(f => f.MAKH == n.MaKH);

                ACCOUNT acc = da.ACCOUNTs.FirstOrDefault(f => f.TENDANGNHAP == kh.TENDANGNHAP);

                acc.TRANGTHAI = n.TrangThai;

                da.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        
    }
}
