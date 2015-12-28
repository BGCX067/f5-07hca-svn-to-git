using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryDKKB.Info
{
    public class LichTrucInfo
    {
        private int _MaBacSi;
        private string _Ngay;
        private string _GioBatDau;
        private string _GioKetThuc;
        private string _Phong;
        private string _TenBSi;

        public string TenBSi
        {
            get { return _TenBSi; }
            set { _TenBSi = value; }
        }
        public int MaBacSi
        {
            get { return _MaBacSi; }
            set { _MaBacSi = value; }
        }


        public string Ngay
        {
            get { return _Ngay; }
            set { _Ngay = value; }
        }
        

        public string GioBatDau
        {
            get { return _GioBatDau; }
            set { _GioBatDau = value; }
        }
        

        public string GioKetThuc
        {
            get { return _GioKetThuc; }
            set { _GioKetThuc = value; }
        }
        

        public string Phong
        {
            get { return _Phong; }
            set { _Phong = value; }
        }


    }
}
