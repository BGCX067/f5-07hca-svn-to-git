using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryDKKB.Info
{
   public class BacSiInfo
    {
        private int _Ma;
        private string _Ten;
       private string _NgaySinh;
        private string _DiaChi;
        private int _MaKhoa;
        private int _MaTaiKhoan;
        private string _TenKhoa;

        public string TenKhoa
        {
            get { return _TenKhoa; }
            set { _TenKhoa = value; }
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


       public string NgaySinh
        {
            get { return _NgaySinh; }
            set { _NgaySinh = value; }
        }
        

        public string DiaChi
        {
            get { return _DiaChi; }
            set { _DiaChi = value; }
        }

        public int MaKhoa
        {
            get { return _MaKhoa; }
            set { _MaKhoa = value; }
        }
       public int MaTaiKhoan
       {
           get { return _MaTaiKhoan; }
           set { _MaTaiKhoan = value; }
       }

    }
}
