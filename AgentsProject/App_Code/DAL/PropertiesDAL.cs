using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;


namespace BLL
{
    public class PropertiesDAL
    {

        internal static List<Properties> GetAllProperties()
        {
            DbCon Db = new DbCon();
            string sql = $"select * from Properties";
            DataTable Dt;
            Dt = Db.Execute(sql);
            Db.Close();
            List<Properties> List = new List<Properties>();
            for (int i = 0; i < Dt.Rows.Count; i++)
            {
                Properties tmp = new Properties()
                {
                    Pid = int.Parse(Dt.Rows[i]["Pid"] + ""),
                    Pname = Dt.Rows[i]["Pname"] + "",
                    Prooms = int.Parse(Dt.Rows[i]["Prooms"] + ""),
                    Pfloor = int.Parse(Dt.Rows[i]["Pfloor"] + ""),
                    Padress = Dt.Rows[i]["Padress"] + "",
                    Pcity = Dt.Rows[i]["Psize"] + "",
                    Psize = int.Parse(Dt.Rows[i]["Psize"] + ""),
                    Pdeal_type = Dt.Rows[i]["Pdeal_type"] + "",
                    Pprice = int.Parse(Dt.Rows[i]["Pprice"] + ""),
                    Pimage = Dt.Rows[i]["Pimage"] + "",
                    Deleted = Dt.Rows[i]["Deleted"] + ""
                };
                List.Add(tmp);
            }
            return List;
        }
        internal static List<Properties> GetProperties(int id)
        {
            DbCon Db = new DbCon();
            string sql = $"select * from Properties where Pagent_id = {id}";
            DataTable Dt;
            Dt = Db.Execute(sql);
            Db.Close();
            List<Properties> List = new List<Properties>();
            for (int i = 0; i < Dt.Rows.Count; i++)
            {
                Properties tmp = new Properties()
                {
                    Pid = int.Parse(Dt.Rows[i]["Pid"] + ""),
                    Pname = Dt.Rows[i]["Pname"] + "",
                    Prooms = int.Parse(Dt.Rows[i]["Prooms"] + ""),
                    Pfloor = int.Parse(Dt.Rows[i]["Pfloor"] + ""),
                    Padress = Dt.Rows[i]["Padress"] + "",
                    Pcity = Dt.Rows[i]["Psize"] + "",
                    Psize = int.Parse(Dt.Rows[i]["Psize"] + ""),
                    Pdeal_type = Dt.Rows[i]["Pdeal_type"] + "",
                    Pprice = int.Parse(Dt.Rows[i]["Pprice"] + ""),
                    Pimage = Dt.Rows[i]["Pimage"] + "",
                    Deleted = Dt.Rows[i]["Deleted"]+""
                };
                List.Add(tmp);
            }
            return List;
        }
        internal static bool RemovePropertieById(int id)
        {
            DbCon Db = new DbCon();
            string sql = $"Delete From Properties Where Pid={id}";
            int Deleted = Db.ExecuteNonQuery(sql);
            Db.Close();

            return Deleted > 0;
        }
        internal static bool RemovePropertie(int id)
        {
            DbCon Db = new DbCon();
            string Sql = $"Update Properties set Deleted='Deleted' where Pid = {id}";


            int RowAffect = Db.ExecuteNonQuery(Sql);
            Db.Close();

            return RowAffect > 0;
        }
        internal static void SavePropertie(Properties save)//אפשר לאפשר לקבל מספר
        {
            DbCon Db = new DbCon();
            string sql, sq ;
            if (save.Pid == 0)
            {
                sql = $"insert into Properties(Pname,Prooms,Pfloor,Padress,Pcity,Psize,Pdeal_type,Pprice,Pimage,Pagent_id)" +
                    $" values('{save.Pname}',{save.Prooms},{save.Pfloor}," +
                    $"'{save.Padress}','{save.Pcity}',{save.Psize}," +
                    $"'{save.Pdeal_type}',{save.Pprice},'{save.Pimage}',{save.Pagent_id})";

                
    
            }
            else
            {
                if (save.Pimage != "")
                {
                    sql = $"UPDATE Properties Set" +
                        $" Pname ='{save.Pname}',Prooms={save.Prooms},Pfloor = {save.Pfloor}" +
                        $",Padress = '{save.Padress}',Pcity = '{save.Pcity}',Psize = {save.Psize}," +
                        $"Pprice = {save.Pprice},Pimage = '{save.Pimage}',Pagent_id={save.Pagent_id}" +
                        $" Where Pid = {save.Pid}";
                }
                else
                {
                    sql = $"UPDATE Properties Set" +
                        $" Pname ='{save.Pname}',Prooms={save.Prooms},Pfloor = {save.Pfloor}" +
                        $",Padress = '{save.Padress}',Pcity = '{save.Pcity}',Psize = {save.Psize}," +
                        $"Pprice = {save.Pprice},Pagent_id={save.Pagent_id} ,Deleted = {"''"}" +
                        $" Where Pid = {save.Pid}";
                }

                Alerts Al = new Alerts()
                {
                    Aid = save.Pagent_id,
                    Pid = save.Pid,
                    actionBy = save.Pagent_id,
                    Alert = "Edited"
                };
                sq = $"insert into Alerts (Aid,Pid,actionBy,Alert)" +
                $" values({Al.Aid},{Al.Pid},{Al.actionBy},'{Al.Alert}')";
                Db.ExecuteNonQuery(sq);
            }
            Db.ExecuteNonQuery(sql);

            if(save.Pid == 0)
            {
                string sqlexe = $"select * from Properties where Pagent_id = {save.Pagent_id} Order By Pid DESC  OFFSET 0 ROWS FETCH FIRST 1 ROWS ONLY";
                DataTable Dt;
                Dt = Db.Execute(sqlexe);
                Alerts Ald = new Alerts()
                {
                    Aid = int.Parse(Dt.Rows[0]["Pagent_id"] + ""),
                    Pid = int.Parse(Dt.Rows[0]["Pid"] + ""),
                    actionBy = int.Parse(Dt.Rows[0]["Pagent_id"] + ""),
                    Alert = "Added"
                };
                Ald.SaveAlert();
            }
            Db.Close();

        }
        internal static Properties GetPropertieById(int id)
        {
            DbCon Db = new DbCon();
            string sql = $"Select * From Properties Where Pid = {id}";
            DataTable Dt;
            Dt = Db.Execute(sql);
            Db.Close();
            Properties prop = null;

            if (Dt.Rows.Count > 0)
            {
                prop = new Properties()
                {
                    Pid = int.Parse(Dt.Rows[0]["Pid"] + ""),
                    Pname = Dt.Rows[0]["Pname"] + "",
                    Prooms = int.Parse(Dt.Rows[0]["Prooms"] + ""),
                    Pfloor = int.Parse(Dt.Rows[0]["Pfloor"] + ""),
                    Padress = Dt.Rows[0]["Padress"] + "",
                    Pcity = Dt.Rows[0]["Psize"] + "",
                    Psize = int.Parse(Dt.Rows[0]["Psize"] + ""),
                    Pdeal_type = Dt.Rows[0]["Pdeal_type"] + "",
                    Pprice = int.Parse(Dt.Rows[0]["Pprice"] + ""),
                    Pimage = Dt.Rows[0]["Pimage"] + ""
                };
            }
            return prop;

        }
    }
}