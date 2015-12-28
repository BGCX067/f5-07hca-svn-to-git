using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryDKKB.Info
{
    public class ThamSoInfo
    {
        private int _Ma;
        private string _MoTa;
        private int _GiaTri;

        public int Ma
        {
            get { return _Ma; }
            set { _Ma = value; }
        }
        

        public string MoTa
        {
            get { return _MoTa; }
            set { _MoTa = value; }
        }
        

        public int GiaTri
        {
            get { return _GiaTri; }
            set { _GiaTri = value; }
        }
    }
}
