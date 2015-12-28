using System;
using System.Collections.Generic;
using System.Text;
using LibraryDKKB.Access;
using LibraryDKKB.Info;
namespace LibraryDKKB.ConTrol
{
    public class NguoiLonControl
    {
        private NguoiLonAccess accNguoilon = new NguoiLonAccess();
        public void sp_ThemThongTinNguoiLon(NguoiLonInfo info)
        {
            accNguoilon.sp_ThemThongTinNguoiLon(info);
        }
        public int MaBenhNhanKhiBietMaTK(int MaTK)
        {
            return accNguoilon.sp_MaBenhNhanNguoiLonKhiBietMaTaiKhoan(MaTK);
        }

    }
}
