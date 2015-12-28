using System;
using System.Collections.Generic;
using System.Text;
using LibraryDKKB.Access;
using LibraryDKKB.Info;
namespace LibraryDKKB.ConTrol
{
    public class ThamSoControl
    {
        private ThamSoAccess accThamso = new ThamSoAccess();
        public ThamSoInfo spLayThongTinBangThamSoCoMa(int MaTS)
        {
             return accThamso.spLayThongTinBangThamSoCoMa(MaTS);
        }
    }
}
