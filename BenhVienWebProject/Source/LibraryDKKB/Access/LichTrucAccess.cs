using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Collections;
using System.Data.SqlClient;
using LibraryDKKB.Info;

namespace LibraryDKKB.Access
{
    public class LichTrucAccess
    {
        private DataService dataService = new DataService();
        //Ds BS truc trong ngay
        //create proc sp_DanhSachBacSiTrucTrongNgay @ngay datetime
        public List<LichTrucInfo> sp_DanhSachBacSiTrucTrongNgay(DateTime Ngay)
        {
            List<LichTrucInfo> arr = new List<LichTrucInfo>();
            LichTrucInfo info;
            SqlDataReader read;
            dataService.Conect();
            dataService.Cmd = new SqlCommand("sp_DanhSachBacSiTrucTrongNgay", dataService.Cnn);
            dataService.Cmd.CommandType = CommandType.StoredProcedure;
            dataService.Cmd.Parameters.Add("@ngay", SqlDbType.DateTime);
            dataService.Cmd.Parameters["@ngay"].Value = Ngay;
            read = dataService.Cmd.ExecuteReader();
            string chuoingay;
            DateTime ngay;
            while (read.Read())
            {
                info = new LichTrucInfo();
                info.MaBacSi = int.Parse(read.GetValue(0).ToString());   
                
               ngay = DateTime.Parse(read.GetValue(1).ToString());
               chuoingay = ngay.Day + "/" + ngay.Month + "/" + ngay.Year;
               info.Ngay = chuoingay;
                info.GioBatDau = read.GetValue(2).ToString();
                info.GioKetThuc = read.GetValue(3).ToString();
                info.Phong = read.GetValue(4).ToString();
                info.TenBSi = read.GetValue(5).ToString();
                arr.Add(info);
            }
            dataService.DisConect();
            return arr;

        }
        //----8--xem lich truc 1 BS trong ngay 
        //create proc sp_LichTrucBacSi @maBS int, @ngay datetime
        public LichTrucInfo sp_LichTrucBacSi(int MaBS, DateTime Ngay)
        {
            LichTrucInfo info = new LichTrucInfo();
            dataService.Conect();
            dataService.Cmd = new SqlCommand("sp_LichTrucBacSi", dataService.Cnn);
            dataService.Cmd.CommandType = CommandType.StoredProcedure;
            dataService.Cmd.Parameters.Add("@maBS", SqlDbType.Int);
            dataService.Cmd.Parameters["@maBS"].Value = MaBS;
            dataService.Cmd.Parameters.Add("@ngay", SqlDbType.DateTime);
            dataService.Cmd.Parameters["@ngay"].Value = Ngay;
            info = (LichTrucInfo)dataService.Cmd.ExecuteScalar();
            dataService.DisConect();
            return info;

        }
    }
}
