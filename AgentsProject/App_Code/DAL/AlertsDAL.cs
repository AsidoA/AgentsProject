using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using BLL;

namespace DAL
{
    public class AlertsDAL
    {
        internal static Alerts GetLastAlert(int aid)
        {
            DbCon Db = new DbCon();
            string sql = $"select * from Alerts Where Aid = {aid} " +
                $"Order By AlertID DESC  OFFSET 0 ROWS FETCH FIRST 1 ROWS ONLY";
            DataTable Dt;
            Dt = Db.Execute(sql);
            Db.Close();
            Alerts Al = null;

            if (Dt.Rows.Count > 0)
            {
                Al = new Alerts()
                {
                    AlertID = int.Parse(Dt.Rows[0]["AlertID"] + ""),
                    Aid = int.Parse(Dt.Rows[0]["Aid"] + ""),
                    Pid = int.Parse(Dt.Rows[0]["Pid"] + ""),
                    actionBy = int.Parse(Dt.Rows[0]["actionBy"] + ""),
                    Alert = Dt.Rows[0]["Alert"] + ""
                };
            }
          
            return Al;
        }
        internal static List<Alerts> GetAlerts(int aid)
        {
            DbCon Db = new DbCon();
            string sql = $"select * from Alerts Where Aid = {aid}";
            DataTable Dt;
            Dt = Db.Execute(sql);
            Db.Close();
            List<Alerts> List = new List<Alerts>();
            for (int i = 0; i < Dt.Rows.Count; i++)
            {
                Alerts tmp = new Alerts()
                {
                    AlertID = int.Parse(Dt.Rows[i]["AlertID"] + ""),
                    Aid = int.Parse(Dt.Rows[i]["Aid"] + ""),
                    Pid = int.Parse(Dt.Rows[i]["Pid"] + ""),
                    actionBy = int.Parse(Dt.Rows[i]["actionBy"] + ""),
                    Alert = Dt.Rows[i]["Alert"] + ""
                };
                List.Add(tmp);
            }
            return List;
        }
        internal static List<Alerts> GetAllAlerts()
        {
            DbCon Db = new DbCon();
            string sql = $"select * from Alerts";
            DataTable Dt;
            Dt = Db.Execute(sql);
            Db.Close();
            List<Alerts> List = new List<Alerts>();
            for (int i = 0; i < Dt.Rows.Count; i++)
            {
                Alerts tmp = new Alerts()
                {
                    AlertID = int.Parse(Dt.Rows[i]["AlertID"] + ""),
                    Aid = int.Parse(Dt.Rows[i]["Aid"] + ""),
                    Pid = int.Parse(Dt.Rows[i]["Pid"] + ""),
                    actionBy = int.Parse(Dt.Rows[i]["actionBy"] + ""),
                    Alert = Dt.Rows[i]["Alert"] + ""
                };
                List.Add(tmp);
            }
            return List;
        }
        internal static void SaveAlert(Alerts save)
        {
            //לבדוק את השאילתה 
            //לבדוק למה לא נשמרים הודעות ובעיות בעמוד  
            DbCon Db = new DbCon();
            string sql;
            if (save.AlertID != 0)
                sql = $"Update Alerts Set Aid={save.Aid} , Pid = {save.Pid} ," +
                    $"actionBy ={save.actionBy},Alert={save.Alert}";
                 else
            sql = $"insert into Alerts (Aid,Pid,actionBy,Alert)" +
                    $" values({save.Aid},{save.Pid},{save.actionBy},'{save.Alert}')";
            
            Db.ExecuteNonQuery(sql);
            Db.Close();

        }
        internal static bool RemoveAlert (int id)
        {
            DbCon Db = new DbCon();
            string Sql = $"Delete from Alerts Where AlertID={id}";

            int RowAffect = Db.ExecuteNonQuery(Sql);
            Db.Close();

            return RowAffect > 0;
        }
        internal static Alerts GetAlertById(int id)
        {
            DbCon Db = new DbCon();
            string sql = $"Select * From Alerts Where AlertID = {id}";
            DataTable Dt;
            Dt = Db.Execute(sql);
            Db.Close();
            Alerts Al = null;

            if (Dt.Rows.Count > 0)
            {
                Al = new Alerts()
                {
                    AlertID = id,
                    Aid = int.Parse(Dt.Rows[0]["Aid"] + ""),
                    Pid = int.Parse(Dt.Rows[0]["Pid"] + ""),
                    actionBy = int.Parse(Dt.Rows[0]["actionBy"] + ""),
                    Alert = Dt.Rows[0]["Alert"] + ""
                };
            }
            return Al;

        }

      

    }
}