using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace LibraryDKKB
{
    public class DataService
    {
        public static string _ConnectionString;
        private SqlConnection _Cnn;
        private SqlCommand _Cmd;
        public SqlCommand Cmd
        {
            get { return _Cmd; }
            set { _Cmd = value; }
        }
        public SqlConnection Cnn
        {
            get { return _Cnn; }
            set { _Cnn = value; }
        }

        public string ConnectionString
        {
            set
            {
                _ConnectionString = value;
            }
            get
            {
                return _ConnectionString;
            }

        }
        public void Conect()
        {
            _Cnn = new SqlConnection(ConnectionString);
            _Cnn.Open();

        }
        public DataService()
        {

            // ConnectionString = "Data Source=(local);Initial Catalog=TrungTamTinHoc;Integrated Security=SSPI";
            // Conect();

        }
        public void DisConect()
        {
            Cnn.Close();
        }
        public int excuteNonQuery()
        {
            try
            {
                Cmd.ExecuteNonQuery();
                return 1;
            }
            catch
            {
                return 0;
            }
        }
        /*
        public DataTable excuteDataTable(string sql)
        {
            Conect();
            DataSet ds = new DataSet();
            SqlDataAdapter rd = new SqlDataAdapter(sql, cnn);
            rd.Fill(ds);
            return ds.Tables[0];
        }
        */
        public SqlDataReader excuteReader(string sql)
        {

            SqlDataReader r;
            Cmd = new SqlCommand(sql, Cnn);
            r = Cmd.ExecuteReader();
            return r;
        }

        public object ThucThiExecuteScalar(string sql)
        {
            object t = new object();
            Cmd = new SqlCommand(sql, Cnn);
            return Cmd.ExecuteScalar();
        }

    }
}
