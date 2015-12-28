using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Collections;
using System.Data.SqlClient;
using LibraryDKKB.Info;

namespace LibraryDKKB.Access
{
    public class NguoiLonAccess
    {
        private DataService dataService = new DataService();
        //---them thong tin bang Nguoi Lon
        //create proc sp_ThemThongTinNguoiLon @maBN int, 
			//@email nvarchar, @dienthoai int, @maTK int
        public void sp_ThemThongTinNguoiLon(NguoiLonInfo info)
        {
            dataService.Conect();
            dataService.Cmd = new SqlCommand("sp_ThemThongTinNguoiLon", dataService.Cnn);
            dataService.Cmd.CommandType = CommandType.StoredProcedure;

            dataService.Cmd.Parameters.Add("@maBN", SqlDbType.Int);
            dataService.Cmd.Parameters["@maBN"].Value = info.MaBenhNhan;

            

            dataService.Cmd.Parameters.Add("@email", SqlDbType.NVarChar);
            dataService.Cmd.Parameters["@email"].Value = info.Email;

            dataService.Cmd.Parameters.Add("@dienthoai", SqlDbType.Int);
            dataService.Cmd.Parameters["@dienthoai"].Value = info.DienThoai;

            dataService.Cmd.Parameters.Add("@maTK", SqlDbType.Int);
            dataService.Cmd.Parameters["@maTK"].Value = info.MaTaiKhoan;


            dataService.Cmd.ExecuteNonQuery();
            dataService.DisConect();
        }
        //lay thong tin NL co ma moi them
        //create proc sp_MaBenhNhanNguoiLonKhiBietMaTaiKhoan @MaTK int
        public int sp_MaBenhNhanNguoiLonKhiBietMaTaiKhoan(int MaTK)
        {
            dataService.Conect();
            dataService.Cmd = new SqlCommand("sp_MaBenhNhanNguoiLonKhiBietMaTaiKhoan", dataService.Cnn);
            dataService.Cmd.CommandType = CommandType.StoredProcedure;
            dataService.Cmd.Parameters.Add("@MaTK", SqlDbType.Int);
            dataService.Cmd.Parameters["@MaTK"].Value = MaTK;
            int maBN = -1;
            SqlDataReader r;
            r = dataService.Cmd.ExecuteReader();
            while (r.Read())
            {
                maBN = int.Parse(r.GetValue(0).ToString());
                break;
            }
            dataService.DisConect();
            return maBN;

        }
    }
}
