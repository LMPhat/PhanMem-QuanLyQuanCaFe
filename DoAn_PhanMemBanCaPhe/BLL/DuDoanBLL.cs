using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class DuDoanBLL
    {
        QLQuanCaPheDataContext da = new QLQuanCaPheDataContext();

        public List<ThuatToan> GetTT()
        {
            List<ThuatToan> ds = da.ThuatToans.ToList();
            return ds;
        }
    }
}
