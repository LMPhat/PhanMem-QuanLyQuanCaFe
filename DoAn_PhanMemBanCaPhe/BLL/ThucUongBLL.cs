using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ThucUongBLL
    {
        QLQuanCaPheDataContext da = new QLQuanCaPheDataContext();
        public List<THUCUONG> GetThucUong()
        {
            List<THUCUONG> ds = da.THUCUONGs.ToList();
            return ds;
        }

        public List<THUCUONG> TimThucUong(string ten)
        {
            List<THUCUONG> ds = da.THUCUONGs.Where(t => t.TENTU.Contains(ten)).ToList();
            return ds;
        }

        public THUCUONG TimTU(int matu)
        {
            THUCUONG tu = da.THUCUONGs.FirstOrDefault(t => t.MATU == matu);
            return tu;
        }

        public bool ThemTU(THUCUONG t)
        {
            string tenlLowerCase = t.TENTU.ToLower();
            THUCUONG ktr = da.THUCUONGs.FirstOrDefault(f => f.TENTU.ToLower() == tenlLowerCase);
            if (ktr != null)
            {
                return false;
            }
            else
            {
                THUCUONG tu = new THUCUONG();
                tu = t;

                da.THUCUONGs.InsertOnSubmit(tu);
                da.SubmitChanges();
                return true;
            }
        }

        public bool SuaTU(THUCUONG t)
        {
            string tenlLowerCase = t.TENTU.ToLower();
            THUCUONG ktr = da.THUCUONGs.FirstOrDefault(f => f.MATU != t.MATU && f.TENTU.ToLower() == tenlLowerCase);
            if (ktr != null)
            {
                return false;
            }
            else
            {
                
                THUCUONG tu = da.THUCUONGs.FirstOrDefault(f => f.MATU == t.MATU);
                tu.TENTU = t.TENTU;
                tu.SL = t.SL;
                tu.DONGIA = t.DONGIA;
                //tu.MALOAI = t.MALOAI;
                tu.TRANGTHAI = t.TRANGTHAI;

                da.SubmitChanges();
                return true;
            }
        }

        public int XoaTU(int id)
        {
            try
            {
                THUCUONG tu = da.THUCUONGs.FirstOrDefault(t => t.MATU == id);
                CHITIET_THUCUONG cttu = da.CHITIET_THUCUONGs.FirstOrDefault(t => t.MATU == tu.MATU);
                if (cttu != null)
                    return 0;
                else
                {
                    if (tu == null)
                    {
                        return -1;
                    }
                    else
                    {
                        da.THUCUONGs.DeleteOnSubmit(tu);
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
