using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryDKKB.Info
{
    public class BenhNhanInfo
    {
        private int _Ma;
        private string _Ten;
        private DateTime _NgaySinh;
        private string _DiaChi;
        private string _Phai;

        
             
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


        public DateTime NgaySinh
        {
            get { return _NgaySinh; }
            set { _NgaySinh = value; }
        }


        public string DiaChi
        {
            get { return _DiaChi; }
            set { _DiaChi = value; }
        }
        public string Phai
        {
            get { return _Phai; }
            set { _Phai = value; }
        }
    }
}
