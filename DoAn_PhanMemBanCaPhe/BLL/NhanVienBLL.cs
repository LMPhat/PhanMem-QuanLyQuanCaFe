using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace BLL
{
    public class NhanVienBLL
    {
        QLQuanCaPheDataContext da = new QLQuanCaPheDataContext();
        public List<NhanVien> GetNV()
        {
            //List<NHANVIEN> ds = da.NHANVIENs.ToList();
            //return ds;

            var query = from nv in da.NHANVIENs
                        join tk in da.ACCOUNTs on nv.TENDANGNHAP equals tk.TENDANGNHAP
                        select new NhanVien
                        {
                            MaNV = nv.MANV,
                            TenNV = nv.TENNV,
                            GioTinh = nv.GIOITINH,
                            Sdt = nv.SDT,
                            TenDN = nv.TENDANGNHAP,
                            MatKhau = tk.MATKHAU,
                            TrangThai = tk.TRANGTHAI
                        };

            return query.ToList();
        }

        public List<NHANVIEN> GetNV_HD()
        {
            List<NHANVIEN> ds = da.NHANVIENs.ToList();
            return ds;
        }

        public bool ThemNV(NhanVien n)
        {
            
            try
            {
                ACCOUNT acc = new ACCOUNT();
                acc.TENDANGNHAP = n.TenDN;
                acc.MATKHAU = n.MatKhau;
                acc.TRANGTHAI = true;

                da.ACCOUNTs.InsertOnSubmit(acc);
                da.SubmitChanges();

                NHANVIEN nv = new NHANVIEN();
                nv.TENNV = n.TenNV;
                nv.SDT = n.Sdt;
                nv.GIOITINH = n.GioTinh;
                nv.TENDANGNHAP = n.TenDN;

                da.NHANVIENs.InsertOnSubmit(nv);
                da.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool SuaNV(NhanVien n)
        {
            try
            {
                NHANVIEN nv = da.NHANVIENs.FirstOrDefault(f => f.MANV == n.MaNV);

                nv.TENNV = n.TenNV;
                nv.SDT = n.Sdt;
                nv.GIOITINH = n.GioTinh;

                ACCOUNT acc = da.ACCOUNTs.FirstOrDefault(f => f.TENDANGNHAP == nv.TENDANGNHAP);

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
