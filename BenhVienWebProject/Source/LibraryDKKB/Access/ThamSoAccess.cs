using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Collections;
using System.Data.SqlClient;
using LibraryDKKB.Info;

namespace LibraryDKKB.Access
{
    public class ThamSoAccess
    {
        private DataService dataService = new DataService();
      //  create proc sp_LayThongTinBangThamSoCoMa @MaTS int
        public ThamSoInfo spLayThongTinBangThamSoCoMa(int MaTS)
        {
           
            ThamSoInfo info = new ThamSoInfo();
            dataService.Conect();
           
            dataService.Cmd = new SqlCommand("sp_LayThongTinBangThamSoCoMa", dataService.Cnn);
            dataService.Cmd.CommandType = CommandType.StoredProcedure;
            dataService.Cmd.Parameters.Add("@MaTS", SqlDbType.Int);
            dataService.Cmd.Parameters["@MaTS"].Value = MaTS;
            SqlDataReader r = dataService.Cmd.ExecuteReader();
            while (r.Read())
            {
                info.GiaTri= int.Parse(r.GetValue(2).ToString());
            }

           
                    

            dataService.DisConect();
            return info;
        }
        
    }
}
