using System;
using System.Collections.Generic;
using System.Text;
using LibraryDKKB.Access;
using LibraryDKKB.Info;
namespace LibraryDKKB.ConTrol
{
    public class TaiKhoanControl
    {
        private TaiKhoanAccess accTaikhoan = new TaiKhoanAccess();
        public void ThemTaiKhoan(TaiKhoanInfo info)
        {
            accTaikhoan.sp_ThemTaiKhoan(info);
        }
        public TaiKhoanInfo spLayThongTinTKMoiThem()
        {
            return accTaikhoan.sp_LayThongTinTKMoiThem();
        }
        public TaiKhoanInfo ThongTinTKhoan(string TenDangNhap, string MatKhau)
        {
            return accTaikhoan.ThongTinTaiKhoan(TenDangNhap, MatKhau);

        }
    }
}
