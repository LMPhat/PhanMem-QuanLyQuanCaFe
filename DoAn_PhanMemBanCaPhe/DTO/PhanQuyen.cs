using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhanQuyen
    {
        int maMH;

        public int MaMH
        {
            get { return maMH; }
            set { maMH = value; }
        }
        string tenMH;

        public string TenMH
        {
            get { return tenMH; }
            set { tenMH = value; }
        }
        bool? coQuyen;

        public bool? CoQuyen
        {
            get { return coQuyen; }
            set { coQuyen = value; }
        }

        public PhanQuyen()
        { }

        public PhanQuyen(int maMH, string tenMH, bool? coQuyen)
        {
            this.MaMH = maMH;
            this.TenMH = tenMH;
            this.CoQuyen = coQuyen;
        }
    }
}
