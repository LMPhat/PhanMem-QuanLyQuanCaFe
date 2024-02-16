using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class LoaiThucUongBLL
    {
        QLQuanCaPheDataContext da = new QLQuanCaPheDataContext();
        public List<LOAIMONNUOC> GetLoai()
        {
            List<LOAIMONNUOC> ds = da.LOAIMONNUOCs.ToList();
            return ds;
        }

        public LOAIMONNUOC TimLoai(int? ma)
        {
            LOAIMONNUOC ds = da.LOAIMONNUOCs.Where(t => t.MALOAI == ma).FirstOrDefault();
            return ds;
        }

        public List<THUCUONG> TimThucUong(int ma)
        {
            List<THUCUONG> ds = da.THUCUONGs.Where(t => t.MALOAI == ma).ToList();
            return ds;
        }

        public bool ThemLoai(string tenl)
        {
            string tenlLowerCase = tenl.Trim().ToLower();
            LOAIMONNUOC ktr = da.LOAIMONNUOCs.FirstOrDefault(t => t.TENLOAI.ToLower() == tenlLowerCase);
            if (ktr != null)
            {
                return false;
            }
            else
            {
                LOAIMONNUOC l = new LOAIMONNUOC();
                l.TENLOAI = tenl;

                da.LOAIMONNUOCs.InsertOnSubmit(l);
                da.SubmitChanges();
                return true;
            }
        }

        public bool SuaLoai(LOAIMONNUOC l)
        {
            string tenlLowerCase = l.TENLOAI.Trim().ToLower();
            LOAIMONNUOC ktr = da.LOAIMONNUOCs.FirstOrDefault(t => t.MALOAI != l.MALOAI && t.TENLOAI.ToLower() == tenlLowerCase);
            if (ktr != null)
            {
                return false;
            }
            else
            {
                LOAIMONNUOC loai = da.LOAIMONNUOCs.FirstOrDefault(t => t.MALOAI == l.MALOAI);
                loai.TENLOAI = l.TENLOAI;

                da.SubmitChanges();
                return true;
            }
        }

        public int XoaLoai(int id)
        {
            try
            {
                LOAIMONNUOC ktr = da.LOAIMONNUOCs.FirstOrDefault(t => t.MALOAI == id);
                THUCUONG tu = da.THUCUONGs.FirstOrDefault(t => t.MALOAI == ktr.MALOAI);
                if (tu != null)
                    return 0;
                else
                {
                    if (ktr == null)
                    {
                        return -1;
                    }
                    else
                    {
                        da.LOAIMONNUOCs.DeleteOnSubmit(ktr);
                        da.SubmitChanges();
                        return 1;
                    }
                }
            }
            catch
            {
                return 0;
            }
            
        }
    }
}
