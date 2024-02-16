using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace BLL
{
    public class PhanQuyenBLL
    {
        QLQuanCaPheDataContext da = new QLQuanCaPheDataContext();
        
        public List<PhanQuyen> GetPQ(int maNhom)
        {
            var query = from manHinh in da.DMManHinhs
                        join phanQuyen in da.QLPhanQuyens
                            on new { MAMANHINH = manHinh.MAMANHINH, MANHOM = maNhom } equals new { MAMANHINH = phanQuyen.MAMANHINH, MANHOM = phanQuyen.MANHOM } into gj
                        from subPhanQuyen in gj.DefaultIfEmpty()
                        select new PhanQuyen
                        {
                            MaMH = manHinh.MAMANHINH,
                            TenMH = manHinh.TENMANHINH,
                            CoQuyen = subPhanQuyen != null ? subPhanQuyen.QUYEN : false
                        };

            return query.ToList();
        }

        public List<QLPhanQuyen> GetMaManHinh(int maNhom)
        {
            List<QLPhanQuyen> ds = da.QLPhanQuyens.Where(f => f.MANHOM == maNhom).ToList();
            return ds;
        }

        public QLPhanQuyen KiemTraKhoaChinhPhanQuyen(int maNhom, int maMH)
        {
            QLPhanQuyen pq = da.QLPhanQuyens.Where(f => f.MANHOM == maNhom && f.MAMANHINH == maMH).FirstOrDefault();
            return pq;
        }

        public bool ThemPQ(QLPhanQuyen pq)
        {
            try
            {
                QLPhanQuyen l = new QLPhanQuyen();
                l.MANHOM = pq.MANHOM;
                l.MAMANHINH = pq.MAMANHINH;
                l.QUYEN = pq.QUYEN;

                da.QLPhanQuyens.InsertOnSubmit(l);
                da.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool SuaPQ(QLPhanQuyen pq)
        {
            try
            {
                QLPhanQuyen l = da.QLPhanQuyens.Where(f => f.MANHOM == pq.MANHOM && f.MAMANHINH == pq.MAMANHINH).FirstOrDefault();
                l.QUYEN = pq.QUYEN;

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
