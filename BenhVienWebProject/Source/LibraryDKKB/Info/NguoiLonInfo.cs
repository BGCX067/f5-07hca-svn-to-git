using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryDKKB.Info
{
    public class NguoiLonInfo
    {
        private int _MaBenhNhan;        
      
        private string _Email;
        private int _DienThoai;
        private int _MaTaiKhoan;


        public int MaBenhNhan
        {
            get { return _MaBenhNhan; }
            set { _MaBenhNhan = value; }
        }
        public int MaTaiKhoan
        {
            get { return _MaTaiKhoan; }
            set { _MaTaiKhoan = value; }
        }

              

        public string Email
        {
            get { return _Email; }
            set { _Email = value; }
        }
        

        public int DienThoai
        {
            get { return _DienThoai; }
            set { _DienThoai = value; }
        }
    }
}
