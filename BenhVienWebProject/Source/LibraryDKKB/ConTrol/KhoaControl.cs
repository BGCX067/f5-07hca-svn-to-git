using System;
using System.Collections.Generic;
using System.Text;
using LibraryDKKB.Access;
using LibraryDKKB.Info;
namespace LibraryDKKB.ConTrol
{
    public class KhoaControl
    {
        private KhoaAccess accKhoa = new KhoaAccess();
        public List<KhoaInfo> DanhSachKhoa()
        {
            return accKhoa.sp_DanhSachKhoa();
        }
        public KhoaInfo sp_ThongTinKhoaCoMa(int MaKhoa)
        {
            return accKhoa.sp_ThongTinKhoaCoMa(MaKhoa);
        }
    }
}
