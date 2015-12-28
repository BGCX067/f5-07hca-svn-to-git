using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryDKKB.Info
{
    public class PhieuDangKyInfo
    {
        private int _Ma;
        private DateTime _Ngay;
        private string _TrieuChung;
        private int _MaBenhNhan;
        private int _SoLuong;

        public int SoLuong
        {
            get { return _SoLuong; }
            set { _SoLuong = value; }
        }

        public int Ma
        {
            get { return _Ma; }
            set { _Ma = value; }
        }


        public DateTime Ngay
        {
            get { return _Ngay; }
            set { _Ngay = value; }
        }
        

        public string TrieuChung
        {
            get { return _TrieuChung; }
            set { _TrieuChung = value; }
        }
        

        public int MaBenhNhan
        {
            get { return _MaBenhNhan; }
            set { _MaBenhNhan = value; }
        }
    }
}
