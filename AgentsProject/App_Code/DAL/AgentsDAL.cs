using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using BLL;

namespace DAL
{
    public class AgentsDAL
    {
        internal static List<Agents> GetUsers()
        {
            DbCon Db = new DbCon();
            string sql = "select * from Agents";
            DataTable Dt;
            Dt = Db.Execute(sql);
            Db.Close();
            List<Agents> Alist = new List<Agents>();
            for (int i = 0; i < Dt.Rows.Count; i++)
            {
                Agents Ag = new Agents()
                {
                    Aid = int.Parse(Dt.Rows[i]["Aid"] + ""),
                    Apname = Dt.Rows[i]["Apname"] + "",
                    Alname = Dt.Rows[i]["Alname"] + "",
                    Aadress = Dt.Rows[i]["Aadress"] + "",
                    Aemail = Dt.Rows[i]["Aemail"] + "",
                    Apass = Dt.Rows[i]["Apass"] + ""
                };
                Alist.Add(Ag);
            }
            return Alist;
        }
        internal static Agents CheckUser(Agents Ag)
        {
            DbCon Db = new DbCon();
            string sql;
            if (Ag.Aid == 0)
                sql = $"Select * from Agents Where Aemail = '{Ag.Aemail}'";
            else
                sql = $"Select * from Agents Where Aemail = '{Ag.Aemail}' AND Apass= '{Ag.Apass}'";
            DataTable Dt;
            Dt = Db.Execute(sql);
            Db.Close();


            if (Dt.Rows.Count > 0)
            {
                Ag = new Agents()
                {
                    Aid = int.Parse(Dt.Rows[0]["Aid"]+""),
                    Apname = Dt.Rows[0]["Apname"] + "",
                    Alname = Dt.Rows[0]["Alname"] + "",
                    Aadress = Dt.Rows[0]["Aadress"] + "",
                    Aemail = Dt.Rows[0]["Aemail"] + "",
                    Apass = Dt.Rows[0]["Apass"] + ""
                };
                return Ag;
            }
            else return null;
        }
        internal static bool RemoveAgent(int id)
        {
            DbCon Db = new DbCon();
            string sql = $"Delete From Agents Where Pid={id}";
            int Deleted = Db.ExecuteNonQuery(sql);
            Db.Close();
            return Deleted > 0;
        }
        internal static void SaveNewAgent(Agents Ag)
        {
            DbCon Db = new DbCon();
            string sql;
            if (Ag.Aid == 0)
            {
                sql = $"insert into Agents(Apname,Alname,Aadress,Aemail,Apass) " +
                    $"values('{Ag.Apname}','{Ag.Alname}','{Ag.Aadress}'," +
                    $"'{Ag.Aemail}','{Ag.Apass}')";
            }
            else
            {
                sql = $"UPDATE Agents Set" +
                    $" Apname='{Ag.Apname}',Alname = '{Ag.Alname}',Aadress='{Ag.Aadress}'," +
                    $"Aemail = '{Ag.Aemail}',Apass = '{Ag.Apass}' Where Aid = {Ag.Aid}";
            }

            Db.ExecuteNonQuery(sql);
            Db.Close();
        }
        internal static Agents getAgentById(int Id)
        {
            DbCon Db = new DbCon();
            string sql = $"Select * From Agents Where Aid = {Id}";
            DataTable Dt;
            Dt = Db.Execute(sql);
            Db.Close();
            Agents Ag = null;

            if (Dt.Rows.Count > 0)
            {
                Ag = new Agents()
                {
                    Aid = int.Parse(Dt.Rows[0]["Aid"] + ""),
                    Apname = Dt.Rows[0]["Apname"] + "",
                    Alname = Dt.Rows[0]["Alname"] + "",
                    Aadress = Dt.Rows[0]["Aadress"] + "",
                    Aemail = Dt.Rows[0]["Aemail"] + "",
                    Apass = Dt.Rows[0]["Apass"] + ""
                };
            }
            return Ag;
        }
    }
}