using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Collections;
using System.Data.SqlClient;
using LibraryDKKB.Info;
namespace LibraryDKKB.Access
{
    public class TreEmAccess
    {
        private DataService dataService = new DataService();
        //them tre em
        //create proc sp_ThemTreEm @maBN int, @maNL int
        public void sp_ThemTreEm(TreEmInfo info)
        {
            dataService.Conect();
            dataService.Cmd = new SqlCommand("sp_ThemTreEm", dataService.Cnn);
            dataService.Cmd.CommandType = CommandType.StoredProcedure;

            dataService.Cmd.Parameters.Add("@maBN", SqlDbType.Int);
            dataService.Cmd.Parameters["@maBN"].Value = info.MaBenhNhan;

            dataService.Cmd.Parameters.Add("@maNL", SqlDbType.Int);
            dataService.Cmd.Parameters["@maNL"].Value = info.MaNguoiLon;

            
            dataService.Cmd.ExecuteNonQuery();
            dataService.DisConect();
        }
    }
}
