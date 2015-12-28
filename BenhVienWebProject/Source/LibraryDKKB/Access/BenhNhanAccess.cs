using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Collections;
using System.Data.SqlClient;
using LibraryDKKB.Info;

namespace LibraryDKKB.Access
{
    public class BenhNhanAccess
    {
        private DataService dataService = new DataService();
        //----them thong tin bang Benh Nhan
        //create proc sp_ThemThongTinBenhNhan @ten nvarchar(20), @ngaysinh datetime,
		//			 @diachi nvarchar(20), @phai nvarchar(20)
        public void sp_ThemThongTinBenhNhan(BenhNhanInfo info)
        {
            dataService.Conect();
            dataService.Cmd = new SqlCommand("sp_ThemThongTinBenhNhan", dataService.Cnn);
            dataService.Cmd.CommandType = CommandType.StoredProcedure;


            dataService.Cmd.Parameters.Add("@ten", SqlDbType.NVarChar);
            dataService.Cmd.Parameters["@ten"].Value = info.Ten;

            dataService.Cmd.Parameters.Add("@ngaysinh", SqlDbType.DateTime);
            dataService.Cmd.Parameters["@ngaysinh"].Value = info.NgaySinh;

            dataService.Cmd.Parameters.Add("@diachi", SqlDbType.NVarChar);
            dataService.Cmd.Parameters["@diachi"].Value = info.DiaChi;

            dataService.Cmd.Parameters.Add("@phai", SqlDbType.NVarChar);
            dataService.Cmd.Parameters["@phai"].Value = info.Phai;


            dataService.Cmd.ExecuteNonQuery();
            dataService.DisConect();
        }
        //---lay thong tin Benh nhan
        //create proc sp_ThongTinBenhNhan


        //---lay thong tin BN co Ma
        //create proc sp_ThongTinBenhNhanCoMa @maBN int
        public BenhNhanInfo sp_ThongTinBenhNhanCoMa(int MaBN)
        {
            BenhNhanInfo info = new BenhNhanInfo();
            dataService.Conect();
            dataService.Cmd = new SqlCommand("sp_ThongTinBenhNhanCoMa", dataService.Cnn);
            dataService.Cmd.CommandType = CommandType.StoredProcedure;
            dataService.Cmd.Parameters.Add("@maBN", SqlDbType.Int);
            dataService.Cmd.Parameters["@maBN"].Value = MaBN;

            //info = (BenhNhanInfo)dataService.Cmd.ExecuteScalar();
            SqlDataReader r;
            r = dataService.Cmd.ExecuteReader();
            while (r.Read())
            {
                info.Ma = int.Parse(r.GetValue(0).ToString());
                info.Ten = r.GetValue(1).ToString();
                info.NgaySinh = DateTime.Parse(r.GetValue(2).ToString());
                info.DiaChi = r.GetValue(3).ToString();
                info.Phai = r.GetValue(4).ToString();
                break;
            }
            dataService.DisConect();
            return info;

        }
        //lay DS benh nhan theo ngay
        //create proc sp_DanhSachBenhNhanTheoNgay @ngay datetime
        public List<BenhNhanInfo> sp_DanhSachBenhNhanTheoNgay(DateTime Ngay)
        {
            List<BenhNhanInfo> arr = new List<BenhNhanInfo>();
            BenhNhanInfo info;
            SqlDataReader read;
            dataService.Conect();
            dataService.Cmd = new SqlCommand("sp_DanhSachBenhNhanTheoNgay", dataService.Cnn);
            dataService.Cmd.CommandType = CommandType.StoredProcedure;
            dataService.Cmd.Parameters.Add("@ngay", SqlDbType.DateTime);
            dataService.Cmd.Parameters["@ngay"].Value = Ngay;
            read = dataService.Cmd.ExecuteReader();
            //string chuoingay;
            //DateTime ngay;
            while (read.Read())
            {
                info = new BenhNhanInfo();
                info.Ma = int.Parse(read.GetValue(0).ToString());
                info.Ten = read.GetValue(1).ToString();

                info.NgaySinh = DateTime.Parse(read.GetValue(2).ToString());
                //chuoingay = ngay.Day + "/" + ngay.Month + "/" + ngay.Year;
                //info.NgaySinh = chuoingay;
                info.DiaChi = read.GetValue(3).ToString();
                
                arr.Add(info);
            }
            dataService.DisConect();
            return arr;

        }
        //create proc sp_ThongTinBenhNhanVuaThem  @Ten nvarchar(50)
        public BenhNhanInfo sp_ThongTinBenhNhanVuaThem()
        {

            dataService.Conect();

            dataService.Cmd = new SqlCommand("sp_ThongTinBenhNhanVuaThem", dataService.Cnn);
            dataService.Cmd.CommandType = CommandType.StoredProcedure;
           
            SqlDataReader r;          

            r = dataService.Cmd.ExecuteReader();
           
            BenhNhanInfo info = new BenhNhanInfo();
            while (r.Read())
            {

                info.Ma = int.Parse(r.GetValue(0).ToString());
                info.Ten= r.GetValue(1).ToString();
                info.NgaySinh = DateTime .Parse(r.GetValue(2).ToString());
                info.DiaChi = r.GetValue(3).ToString();
                info.Phai= r.GetValue(4).ToString();
               

                break;
            }
            dataService.DisConect();
            return info;
        }
    }
}
