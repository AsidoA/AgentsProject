using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;  

namespace BLL
{
    public class DbCon
    {
        public string Sql { get; set; }
        public string ConStr { get; set; }
        public SqlCommand Cmd { get; set; }
        public SqlConnection Conn { get; set; }
        
        public DbCon()
        {
            ConStr = ConfigurationManager.ConnectionStrings["SqlCon"].ConnectionString;
            Conn = new SqlConnection(ConStr);
            Open();
        }
        public DataTable Execute(string Sql)
        {
            Cmd = new SqlCommand(Sql, Conn);
            SqlDataAdapter Adp = new SqlDataAdapter();
            DataTable Dt = new DataTable();
            Adp.SelectCommand = Cmd;
            Adp.Fill(Dt);
            return Dt;
        }
        public int ExecuteNonQuery(string Sql)
        {
            Cmd = new SqlCommand(Sql, Conn);
            return Cmd.ExecuteNonQuery();
        }

        public void Open() { Conn.Open(); }
        public void Close() { Conn.Close(); }
    }
}