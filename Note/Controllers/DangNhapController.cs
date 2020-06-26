using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Note.Models;
namespace Note.Controllers
{
    public class DangNhapController
    {
        public static bool KiemTraTenDangNhapVaMatKhau(string tenDangNhap, string matKhau)
        {
            using (var _context = new DBDangNhapEntities())
            {
                var taiKhoan = (from d in _context.BangDangNhaps
                                where d.TenDangNhap == tenDangNhap && d.MatKhau == matKhau
                                select d).SingleOrDefault();
                if (taiKhoan == null)
                    return false;
                if (string.Compare(taiKhoan.TenDangNhap.Trim(), tenDangNhap, false) == 0)
                    return true;
                return false;
            }    
        }
        public static void ThemTaiKhoan(BangDangNhap taiKhoan)
        {
            using(var _context = new DBDangNhapEntities())
            {
                _context.BangDangNhaps.Add(taiKhoan);
                _context.SaveChanges();
            }    
        }
        public static bool kiemTraTenDangNhapDaTonTai(string tenDangNhap)
        {
            using(var _context = new DBDangNhapEntities())
            {
                var taikhoan = (from d in _context.BangDangNhaps
                                where d.TenDangNhap == tenDangNhap
                                select d).SingleOrDefault();
                if (taikhoan == null)
                    return false;
                if (string.Compare(taikhoan.TenDangNhap.Trim(), tenDangNhap, false) == 0)
                    return true;
                return false;
            }    
        }
        public static bool kiemTraMatKhau(string tendangnhap,string matKhau)
        {
            using(var _context = new DBDangNhapEntities())
            {
                var taikhoan = (from d in _context.BangDangNhaps
                                where d.TenDangNhap == tendangnhap && d.MatKhau == matKhau
                                select d).SingleOrDefault();
                if (taikhoan == null)
                    return false;
                if (string.Compare(taikhoan.TenDangNhap.Trim(), tendangnhap, false) == 0)
                    return true;
                return false;
            }    
        }
    }
}
