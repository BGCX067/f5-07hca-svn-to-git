using System;
using System.Collections.Generic;
using System.Text;
using LibraryDKKB.Access;
using LibraryDKKB.Info;
namespace LibraryDKKB.ConTrol
{
    public class TreEmControl
    {
        private TreEmAccess accTreem = new TreEmAccess();
        public void ThemTreEm(TreEmInfo info)
        {
            accTreem.sp_ThemTreEm(info);
        }
    }
}
