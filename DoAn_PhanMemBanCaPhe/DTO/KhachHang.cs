using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KhachHang
    {
        int maKH;

        public int MaKH
        {
            get { return maKH; }
            set { maKH = value; }
        }
        string tenKH, gioTinh, sdt, tenDN, matKhau, diaChi;

        public string DiaChi
        {
            get { return diaChi; }
            set { diaChi = value; }
        }

        public string MatKhau
        {
            get { return matKhau; }
            set { matKhau = value; }
        }

        public string TenDN
        {
            get { return tenDN; }
            set { tenDN = value; }
        }

        public string Sdt
        {
            get { return sdt; }
            set { sdt = value; }
        }

        public string GioTinh
        {
            get { return gioTinh; }
            set { gioTinh = value; }
        }

        public string TenKH
        {
            get { return tenKH; }
            set { tenKH = value; }
        }

        bool trangThai;

        public bool TrangThai
        {
            get { return trangThai; }
            set { trangThai = value; }
        }

        public KhachHang() { }

        public KhachHang(int maKH, string tenKH, string sdt, string gioiTinh, string tenDN, string matKhau, bool trangThai, string diaChi)
        {
            this.MaKH = maKH;
            this.TenKH = tenKH;
            this.GioTinh = gioiTinh;
            this.Sdt = sdt;
            this.TenDN = tenDN;
            this.MatKhau = matKhau;
            this.TrangThai = trangThai;
            this.DiaChi = diaChi;
        }
    }
}
