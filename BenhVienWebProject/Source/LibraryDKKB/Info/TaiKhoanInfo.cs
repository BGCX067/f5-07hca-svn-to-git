using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryDKKB.Info
{
    public class TaiKhoanInfo
    {
        private int _Ma;
        private string _Ten;
        private string _MatKhau;
        private string _Loai;
        private int _MaBN;

        public int MaBN
        {
            get { return _MaBN; }
            set { _MaBN = value; }
        }
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
        

        public string MatKhau
        {
            get { return _MatKhau; }
            set { _MatKhau = value; }
        }
        

        public string Loai
        {
            get { return _Loai; }
            set { _Loai = value; }
        }
    }
}
