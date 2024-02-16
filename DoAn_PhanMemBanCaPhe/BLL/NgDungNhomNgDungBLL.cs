using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class NgDungNhomNgDungBLL
    {
        QLQuanCaPheDataContext da = new QLQuanCaPheDataContext();
        public List<QLNguoiDungNhonNguoiDung> GetNDNhomND(int manhom)
        {
            List<QLNguoiDungNhonNguoiDung> ds = da.QLNguoiDungNhonNguoiDungs.Where(f => f.MANHOM == manhom).ToList();
            return ds;
        }

        public List<QLNguoiDungNhonNguoiDung> GetNhomND()
        {
            List<QLNguoiDungNhonNguoiDung> ds = da.QLNguoiDungNhonNguoiDungs.ToList();
            return ds;
        }

        public List<QLNguoiDungNhonNguoiDung> GetMaNhomNguoiDung(string TenDangNhap)
        {
            List<QLNguoiDungNhonNguoiDung> ds = da.QLNguoiDungNhonNguoiDungs.Where(f=>f.TENDANGNHAP == TenDangNhap).ToList();
            return ds;
        }

        public int ThemNDVaoNhom(QLNguoiDungNhonNguoiDung ng)
        {
            try
            {
                QLNguoiDungNhonNguoiDung ktr = da.QLNguoiDungNhonNguoiDungs.FirstOrDefault(t => t.TENDANGNHAP == ng.TENDANGNHAP);
                if (ktr != null)
                {
                    return -1;
                }
                else
                {
                    QLNguoiDungNhonNguoiDung l = new QLNguoiDungNhonNguoiDung();
                    l.TENDANGNHAP = ng.TENDANGNHAP;
                    l.MANHOM = ng.MANHOM;

                    da.QLNguoiDungNhonNguoiDungs.InsertOnSubmit(l);
                    da.SubmitChanges();
                    return 1;
                }
            }
            catch
            {
                return 0;
            }
        }

        public int XoaNDKhoiNhom(QLNguoiDungNhonNguoiDung ng)
        {
            try
            {
                QLNguoiDungNhonNguoiDung ktr1 = da.QLNguoiDungNhonNguoiDungs.FirstOrDefault(t => t.TENDANGNHAP == ng.TENDANGNHAP && t.MANHOM == ng.MANHOM);
                if (ktr1 == null)
                    return 0;
                else
                {
                    da.QLNguoiDungNhonNguoiDungs.DeleteOnSubmit(ktr1);
                    da.SubmitChanges();
                    return 1;
                }
            }
            catch
            {
                return 0;
            }

        }
    }
}
