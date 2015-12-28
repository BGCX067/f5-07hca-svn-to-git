using System;
using System.Collections.Generic;
using System.Text;
using LibraryDKKB.Access;
using LibraryDKKB.Info;

namespace LibraryDKKB.ConTrol
{
    public class BacSiControl
    {
        private BacSiAccess accBacsi = new BacSiAccess();
        public List<BacSiInfo> ThongTinBacSiTrongKhoa(int MaKhoa)
        {
            return accBacsi.sp_ThongTinBacSiTrongKhoa(MaKhoa);
        }
        public BacSiInfo ThongTinBacSiCoMa(int MaBS)
        {
            return accBacsi.sp_ThongTinBacSiCoMa(MaBS);
        }
    }
}
