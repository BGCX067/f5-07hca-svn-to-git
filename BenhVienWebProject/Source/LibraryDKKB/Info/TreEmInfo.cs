using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryDKKB.Info
{
    public class TreEmInfo
    {
        private int _MaBenhNhan;
        private int _MaNguoiLon;


        public int MaBenhNhan
        {
            get { return _MaBenhNhan; }
            set { _MaBenhNhan = value; }
        }
        
        public int MaNguoiLon
        {
            get { return _MaNguoiLon; }
            set { _MaNguoiLon = value; }
        }
    }
}
