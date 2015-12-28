using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Collections;
using System.Data.SqlClient;
using LibraryDKKB.Info;

namespace LibraryDKKB.Access
{
    public class BacSiAccess
    {
        private DataService dataService = new DataService();
        //----1--xem thong tin BS trong 1 khoa
        //create proc sp_ThongTinBacSiTrongKhoa @MaKhoa int
        public List<BacSiInfo> sp_ThongTinBacSiTrongKhoa(int MaKhoa)
        {
            List<BacSiInfo> arr = new List<BacSiInfo>();
            SqlDataReader read;            
            dataService.Conect();
            dataService.Cmd = new SqlCommand("sp_ThongTinBacSiTrongKhoa", dataService.Cnn);
            dataService.Cmd.CommandType = CommandType.StoredProcedure;
            dataService.Cmd.Parameters.Add("@MaKhoa", SqlDbType.Int);
            dataService.Cmd.Parameters["@MaKhoa"].Value = MaKhoa;
            read = dataService.Cmd.ExecuteReader();
            BacSiInfo info;
            DateTime ngay;
            string chuoingay;
            while (read.Read())
            {
                info = new BacSiInfo();
                info.Ma = int.Parse(read.GetValue(0).ToString());
                info.Ten = read.GetValue(1).ToString();    

                ngay= DateTime.Parse(read.GetValue(2).ToString());
                chuoingay = ngay.Day + "/" + ngay.Month + "/" + ngay.Year;
                info.NgaySinh = chuoingay;
                info.DiaChi = read.GetValue(3).ToString();
                info.MaKhoa = int.Parse(read.GetValue(4).ToString());
                info.MaTaiKhoan = int.Parse(read.GetValue(5).ToString());
                arr.Add(info);
            }
            

            dataService.DisConect();
            return arr;

        }
        //----2--xem chi tiet thong tin ca nhan BS co ma
       //create proc sp_ThongTinBacSiCoMa @maBS int
        public BacSiInfo sp_ThongTinBacSiCoMa(int MaBS)
        {
            BacSiInfo info = new BacSiInfo();
            dataService.Conect();
            dataService.Cmd = new SqlCommand("sp_ThongTinBacSiCoMa", dataService.Cnn);
            dataService.Cmd.CommandType = CommandType.StoredProcedure;
            dataService.Cmd.Parameters.Add("@maBS", SqlDbType.Int);
            dataService.Cmd.Parameters["@maBS"].Value = MaBS;
            info = (BacSiInfo)dataService.Cmd.ExecuteScalar();
            dataService.DisConect();
            return info;

        }
        

    }
}
