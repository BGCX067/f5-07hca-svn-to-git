using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Collections;
using System.Data.SqlClient;
using LibraryDKKB.Info;
namespace LibraryDKKB.Access
{
    public class KhoaAccess
    {
        private DataService dataService = new DataService();
        //DS cac khoa trong benh vien
        //create proc sp_DanhSachKhoa
        public List<KhoaInfo> sp_DanhSachKhoa()
        {
            List<KhoaInfo> arr = new List<KhoaInfo>();
            SqlDataReader r;
            dataService.Conect();
            dataService.Cmd = new SqlCommand("sp_DanhSachKhoa", dataService.Cnn);
            dataService.Cmd.CommandType = CommandType.StoredProcedure;

            r = dataService.Cmd.ExecuteReader();
            KhoaInfo info;
            while (r.Read())
            {
                info = new KhoaInfo();
                info.Ma = int.Parse(r.GetValue(0).ToString());
                info.Ten = r.GetValue(1).ToString();


                arr.Add(info);
            }
            dataService.DisConect();
            return arr;

        }
        //create proc sp_ThongTinKhoaCoMa @MaKhoa
        //lay thong tin 1 khoa
        public KhoaInfo sp_ThongTinKhoaCoMa(int MaKhoa)
        {
            KhoaInfo info = new KhoaInfo();
            dataService.Conect();
            dataService.Cmd = new SqlCommand("sp_ThongTinKhoaCoMa", dataService.Cnn);
            dataService.Cmd.CommandType = CommandType.StoredProcedure;
            dataService.Cmd.Parameters.Add("@MaKhoa", SqlDbType.Int);
            dataService.Cmd.Parameters["@MaKhoa"].Value = MaKhoa;
            info = (KhoaInfo)dataService.Cmd.ExecuteScalar();
            dataService.DisConect();
            return info;

        }
    }
}
