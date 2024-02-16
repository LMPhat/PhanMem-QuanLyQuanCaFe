using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class NhomNgDBLL
    {
        QLQuanCaPheDataContext da = new QLQuanCaPheDataContext();
        public List<QLNhomNguoiDung> GetNGD()
        {
            List<QLNhomNguoiDung> ds = da.QLNhomNguoiDungs.ToList();
            return ds;
        }

        public bool ThemNGD(string tenngd)
        {
            string tenlLowerCase = tenngd.Trim().ToLower();
            QLNhomNguoiDung ktr = da.QLNhomNguoiDungs.FirstOrDefault(t => t.TENNHOM.ToLower() == tenlLowerCase);
            if (ktr != null)
            {
                return false;
            }
            else
            {
                QLNhomNguoiDung l = new QLNhomNguoiDung();
                l.TENNHOM = tenngd;

                da.QLNhomNguoiDungs.InsertOnSubmit(l);
                da.SubmitChanges();
                return true;
            }
        }

        public bool SuaNGD(QLNhomNguoiDung l)
        {
            string tenlLowerCase = l.TENNHOM.Trim().ToLower();
            QLNhomNguoiDung ktr = da.QLNhomNguoiDungs.FirstOrDefault(t => t.MANHOM != l.MANHOM && t.TENNHOM.ToLower() == tenlLowerCase);
            if (ktr != null)
            {
                return false;
            }
            else
            {
                QLNhomNguoiDung loai = da.QLNhomNguoiDungs.FirstOrDefault(t => t.MANHOM == l.MANHOM);
                loai.TENNHOM = l.TENNHOM;

                da.SubmitChanges();
                return true;
            }
        }

        public int XoaNGD(int id)
        {
            try
            {
                QLNhomNguoiDung ktr = da.QLNhomNguoiDungs.FirstOrDefault(t => t.MANHOM == id);
                QLNguoiDungNhonNguoiDung ktr1 = da.QLNguoiDungNhonNguoiDungs.FirstOrDefault(t => t.MANHOM == ktr.MANHOM);
                QLPhanQuyen ktr2 = da.QLPhanQuyens.FirstOrDefault(t => t.MANHOM == ktr.MANHOM);
                if (ktr1 != null || ktr2 != null)
                    return 0;
                else
                {
                    if (ktr == null)
                    {
                        return -1;
                    }
                    else
                    {
                        da.QLNhomNguoiDungs.DeleteOnSubmit(ktr);
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
