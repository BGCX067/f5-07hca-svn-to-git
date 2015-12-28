using System;
using System.Collections.Generic;
using System.Text;
using LibraryDKKB.Access;
using LibraryDKKB.Info;

namespace LibraryDKKB.ConTrol
{
    public class BenhNhanControl
    {
        private BenhNhanAccess accBenhnhan = new BenhNhanAccess();
        public void ThemThongTinBenhNhan(BenhNhanInfo info)
        {
            accBenhnhan.sp_ThemThongTinBenhNhan(info);
        }
        public BenhNhanInfo ThongTinBenhNhanCoMa(int MaBN)
        {
            return accBenhnhan.sp_ThongTinBenhNhanCoMa(MaBN);
        }
        public List<BenhNhanInfo> DanhSachBenhNhanTheoNgay(DateTime Ngay)
        {
            return accBenhnhan.sp_DanhSachBenhNhanTheoNgay(Ngay);
        }
        public BenhNhanInfo ThongTinBenhNhanVuaThem()
        {
            return accBenhnhan.sp_ThongTinBenhNhanVuaThem();
        }
    }
}
