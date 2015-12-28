using System;
using System.Collections.Generic;
using System.Text;
using LibraryDKKB.Access;
using LibraryDKKB.Info;
namespace LibraryDKKB.ConTrol
{
    public class PhieuDangKyControl
    {
        private PhieuDangKyAccess accPDK = new PhieuDangKyAccess();
        public void sp_ThemPhieuDangKy(PhieuDangKyInfo info)
        {
            accPDK.sp_ThemPhieuDangKy(info);
        }
        public int DemSLBenhNhanDKTrongNgay(DateTime ngay)
        {
            return accPDK.sp_DemSLBenhNhanDKTrongNgay(ngay);
        }
        public int LayMaPhieuDangKyTuMaBenhNhan(int MaBN, DateTime ngay)
        {
            return accPDK.sp_LayMaPhieuDangKyTuMaBenhNhan(MaBN, ngay);
        }
    }
}
