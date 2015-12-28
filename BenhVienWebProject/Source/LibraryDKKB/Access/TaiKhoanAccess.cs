using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Collections;
using System.Data.SqlClient;
using LibraryDKKB.Info;

namespace LibraryDKKB.Access
{
    public class TaiKhoanAccess
    {
        private DataService dataService = new DataService();
        //create proc sp_ThemTaiKhoan @ten nvarchar(20), @matkhau nvarchar(20), @loai nvarchar(20)

        public void sp_ThemTaiKhoan(TaiKhoanInfo info)
        {
            dataService.Conect();
            dataService.Cmd = new SqlCommand("sp_ThemTaiKhoan", dataService.Cnn);
            dataService.Cmd.CommandType = CommandType.StoredProcedure;

            dataService.Cmd.Parameters.Add("@ten", SqlDbType.NVarChar);
            dataService.Cmd.Parameters["@ten"].Value = info.Ten;

            dataService.Cmd.Parameters.Add("@matkhau", SqlDbType.NVarChar);
            dataService.Cmd.Parameters["@matkhau"].Value = info.MatKhau;

            dataService.Cmd.Parameters.Add("@loai", SqlDbType.NVarChar);
            dataService.Cmd.Parameters["@loai"].Value = info.Loai;

            
            dataService.Cmd.ExecuteNonQuery();
            dataService.DisConect();
        }
        //---lay Ma Tai Khoan
        //sp_LayThongTinTKMoiThem
        public TaiKhoanInfo sp_LayThongTinTKMoiThem()
        {
            dataService.Conect();
            dataService.Cmd = new SqlCommand("sp_LayThongTinTKMoiThem", dataService.Cnn);
            dataService.Cmd.CommandType = CommandType.StoredProcedure;

            SqlDataReader r;
            TaiKhoanInfo tk = new TaiKhoanInfo();

            r = dataService.Cmd.ExecuteReader();
            while (r.Read())
            {
                tk.Ma = int.Parse(r.GetValue(0).ToString());
                tk.Ten = r.GetValue(1).ToString();
                tk.MatKhau = r.GetValue(2).ToString();
                tk.Loai = r.GetValue(3).ToString();
                break;
            }
            dataService.DisConect();
            return tk;
        }
        //create proc sp_ThongTinTaiKhoan @Ten nvarchar(20),@MatKhau nvarchar(20)
        public TaiKhoanInfo ThongTinTaiKhoan(string Ten, string MatKhau)
        {
            dataService.Conect();
            dataService.Cmd = new SqlCommand("sp_ThongTinTK", dataService.Cnn);
            dataService.Cmd.CommandType = CommandType.StoredProcedure;
            dataService.Cmd.Parameters.Add("@Ten", SqlDbType.NVarChar);
            dataService.Cmd.Parameters["@Ten"].Value = Ten;

            dataService.Cmd.Parameters.Add("@MatKhau", SqlDbType.NVarChar);
            dataService.Cmd.Parameters["@MatKhau"].Value = MatKhau;
            SqlDataReader r;
            TaiKhoanInfo tk = new TaiKhoanInfo();

            r = dataService.Cmd.ExecuteReader();
            while (r.Read())
            {
                tk.Ma = int.Parse(r.GetValue(0).ToString());
                tk.Ten = r.GetValue(1).ToString();
                tk.MatKhau = r.GetValue(2).ToString();
                tk.Loai = r.GetValue(3).ToString();
               
                break;
            }
            dataService.DisConect();
            return tk;

        }
    }
}
