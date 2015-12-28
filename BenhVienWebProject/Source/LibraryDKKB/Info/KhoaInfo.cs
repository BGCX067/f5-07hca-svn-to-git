using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryDKKB.Info
{
    public class KhoaInfo
    {
        private int _Ma;
        private string _Ten;
        
        public int Ma
        {
            get { return _Ma; }
            set { _Ma = value; }
        }


        public string Ten
        {
            get { return _Ten; }
            set { _Ten = value; }
        }
    }
}
