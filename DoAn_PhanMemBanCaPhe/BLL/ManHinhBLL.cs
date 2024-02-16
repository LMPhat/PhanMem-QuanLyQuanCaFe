using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ManHinhBLL
    {
        QLQuanCaPheDataContext da = new QLQuanCaPheDataContext();
        public List<DMManHinh> GetMH()
        {
            List<DMManHinh> ds = da.DMManHinhs.ToList();
            return ds;
        }

        public bool ThemMH(string tenmh)
        {
            string tenlLowerCase = tenmh.Trim().ToLower();
            DMManHinh ktr = da.DMManHinhs.FirstOrDefault(t => t.TENMANHINH.ToLower() == tenlLowerCase);
            if (ktr != null)
            {
                return false;
            }
            else
            {
                DMManHinh l = new DMManHinh();
                l.TENMANHINH = tenmh;

                da.DMManHinhs.InsertOnSubmit(l);
                da.SubmitChanges();
                return true;
            }
        }

        public bool SuaMH(DMManHinh l)
        {
            string tenlLowerCase = l.TENMANHINH.Trim().ToLower();
            DMManHinh ktr = da.DMManHinhs.FirstOrDefault(t => t.MAMANHINH != l.MAMANHINH && t.TENMANHINH.ToLower() == tenlLowerCase);
            if (ktr != null)
            {
                return false;
            }
            else
            {
                DMManHinh loai = da.DMManHinhs.FirstOrDefault(t => t.MAMANHINH == l.MAMANHINH);
                loai.TENMANHINH = l.TENMANHINH;

                da.SubmitChanges();
                return true;
            }
        }

        public int XoaMH(int id)
        {
            try
            {
                DMManHinh ktr = da.DMManHinhs.FirstOrDefault(t => t.MAMANHINH == id);
                QLPhanQuyen ktr2 = da.QLPhanQuyens.FirstOrDefault(t => t.MAMANHINH == ktr.MAMANHINH);
                if (ktr2 != null)
                    return 0;
                else
                {
                    if (ktr == null)
                    {
                        return -1;
                    }
                    else
                    {
                        da.DMManHinhs.DeleteOnSubmit(ktr);
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
