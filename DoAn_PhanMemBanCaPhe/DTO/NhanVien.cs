using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhanVien
    {
        int maNV;

        public int MaNV
        {
            get { return maNV; }
            set { maNV = value; }
        }
        string tenNV, gioTinh, sdt, tenDN, matKhau;

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

        public string TenNV
        {
            get { return tenNV; }
            set { tenNV = value; }
        }
        bool trangThai;

        public bool TrangThai
        {
            get { return trangThai; }
            set { trangThai = value; }
        }

        public NhanVien() { }

        public NhanVien(int maNV, string tenNV, string sdt, string gioiTinh, string tenDN, string matKhau, bool trangThai)
        {
            this.MaNV = maNV;
            this.TenNV = tenNV;
            this.GioTinh = gioiTinh;
            this.Sdt = sdt;
            this.TenDN = tenDN;
            this.MatKhau = matKhau;
            this.TrangThai = trangThai;
        }
    }
}
