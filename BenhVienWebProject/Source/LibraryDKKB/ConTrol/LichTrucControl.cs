using System;
using System.Collections.Generic;
using System.Text;
using LibraryDKKB.Access;
using LibraryDKKB.Info;
namespace LibraryDKKB.ConTrol
{
    public class LichTrucControl
    {
        private LichTrucAccess accLichtruc = new LichTrucAccess();
        public List<LichTrucInfo> DanhSachBacSiTrucTrongNgay(DateTime Ngay)
        {
            return accLichtruc.sp_DanhSachBacSiTrucTrongNgay(Ngay);
        }
        public LichTrucInfo LichTrucBacSi(int MaBS, DateTime Ngay)
        {
            return accLichtruc.sp_LichTrucBacSi(MaBS, Ngay);
        }

    }
}
