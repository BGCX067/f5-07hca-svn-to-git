using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Collections;
using System.Data.SqlClient;
using LibraryDKKB.Info;

namespace LibraryDKKB.Access
{
    public class PhieuDangKyAccess
    {
        private DataService dataService = new DataService();
        //----9--them thong tin Phieu dang ky
        //create proc sp_ThemPhieuDangKy @ngay datetime, @trieuchung nvarchar(100), @maBN int
        public void sp_ThemPhieuDangKy(PhieuDangKyInfo info)
        {
            dataService.Conect();
            dataService.Cmd = new SqlCommand("sp_ThemPhieuDangKy", dataService.Cnn);
            dataService.Cmd.CommandType = CommandType.StoredProcedure;

            dataService.Cmd.Parameters.Add("@ngay", SqlDbType.DateTime);
            dataService.Cmd.Parameters["@ngay"].Value = info.Ngay;

            dataService.Cmd.Parameters.Add("@trieuchung", SqlDbType.NVarChar);
            dataService.Cmd.Parameters["@trieuchung"].Value = info.TrieuChung;

            dataService.Cmd.Parameters.Add("@maBN", SqlDbType.Int);
            dataService.Cmd.Parameters["@maBN"].Value = info.MaBenhNhan;

            dataService.Cmd.ExecuteNonQuery();
            dataService.DisConect();
        }
        //create proc sp_DemSLBenhNhanDKTrongNgay @ngay datetime
        public int sp_DemSLBenhNhanDKTrongNgay(DateTime ngay)
        {
            int dem = 0;
            PhieuDangKyInfo info = new PhieuDangKyInfo();
            dataService.Conect();
           
            dataService.Cmd = new SqlCommand("sp_DemSLBenhNhanDKTrongNgay", dataService.Cnn);
            dataService.Cmd.CommandType = CommandType.StoredProcedure;
            dataService.Cmd.Parameters.Add("@ngay", SqlDbType.DateTime);
            dataService.Cmd.Parameters["@ngay"].Value = ngay;
            SqlDataReader r = dataService.Cmd.ExecuteReader();
            while (r.Read())
            {
                info.SoLuong = int.Parse(r.GetValue(0).ToString());
            }

           
            dem = info.SoLuong;           

            dataService.DisConect();
            return dem;
        }
        //create proc sp_LayMaPhieuDangKyTuMaBenhNhan @MaBN int, @Ngay datetime
        public int sp_LayMaPhieuDangKyTuMaBenhNhan(int MaBN, DateTime ngay)
        {
            dataService.Conect();
            dataService.Cmd = new SqlCommand("sp_LayMaPhieuDangKyTuMaBenhNhan", dataService.Cnn);
            dataService.Cmd.CommandType = CommandType.StoredProcedure;

            dataService.Cmd.Parameters.Add("@ngay", SqlDbType.DateTime);
            dataService.Cmd.Parameters["@ngay"].Value = ngay;

            dataService.Cmd.Parameters.Add("@MaBN", SqlDbType.Int);
            dataService.Cmd.Parameters["@MaBN"].Value = MaBN;
            SqlDataReader r;
            int ma=0;
            r=dataService.Cmd.ExecuteReader();
            while (r.Read())
            {
                ma = int.Parse(r.GetValue(0).ToString());
                break;

            }
            return ma;

        }
    }
}
