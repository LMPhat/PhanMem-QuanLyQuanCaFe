using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class HoaDonBLL
    {
        QLQuanCaPheDataContext da = new QLQuanCaPheDataContext();

        public List<HOADON> GetHD()
        {
            List<HOADON> ds = da.HOADONs.ToList();
            return ds;
        }

        public List<CHITIET_THUCUONG> GetCTHD(int mahd)
        {
            List<CHITIET_THUCUONG> ds = da.CHITIET_THUCUONGs.Where(f=>f.MAHD == mahd).ToList();
            return ds;
        }

        public int? TongTienHD()
        {
            int? tt = da.HOADONs.Sum(f => f.TONGTIEN);
            return tt;
        }

        public int? TongTienHD_TK(List<HOADON> hd)
        {
            int? tt = hd.Sum(f => f.TONGTIEN);
            return tt;
        }
 
        public bool ThemHD(HOADON t)
        {
            try
            {
                HOADON hd = new HOADON();
                hd = t;

                da.HOADONs.InsertOnSubmit(hd);
                da.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool ThemCTHD(CHITIET_THUCUONG t)
        {
            try
            {
                CHITIET_THUCUONG ct = new CHITIET_THUCUONG();
                ct = t;

                da.CHITIET_THUCUONGs.InsertOnSubmit(ct);
                da.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public void ChinhSuaSL_KhiThanhToan(int maTU, int sl)
        {
            THUCUONG tu = da.THUCUONGs.FirstOrDefault(f => f.MATU == maTU);
            tu.SL -= sl;
            da.SubmitChanges();
        }

        public void ChinhSuaTrangThai(int mahd)
        {
            HOADON hd = da.HOADONs.FirstOrDefault(f => f.MAHD == mahd);
            hd.TRANGTHAI = true;
            da.SubmitChanges();
        }

        public int LayMaHD_MoiThem()
        {
            HOADON hd = da.HOADONs.OrderByDescending(h => h.MAHD).FirstOrDefault();

            return hd.MAHD;
        }

        public List<HOADON> TimKiem_KH(string ten)
        {
            List<HOADON> ds = da.HOADONs.Where(t=> t.KHACHHANG.TENKH.ToLower().Contains(ten.Trim().ToLower())).ToList();
            return ds;
        }

        public List<HOADON> TimKiem_NV(string ten)
        {
            List<HOADON> ds = da.HOADONs.Where(t => t.NHANVIEN.TENNV.ToLower().Contains(ten.Trim().ToLower())).ToList();
            return ds;
        }

        public List<HOADON> ThongKe(DateTime tuNgay, DateTime denNgay)
        {
            List<HOADON> ds = (from tkdt in da.HOADONs
                        where tkdt.NGAYLAP >= tuNgay && tkdt.NGAYLAP <= denNgay
                        select tkdt).ToList();
            return ds;
        }
    }
}
