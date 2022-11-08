using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DAL;

namespace BLL
{
    public class Alerts
    {
        public int AlertID { get; set; }
        public int Aid { get; set; }
        public int Pid { get; set; }
        public int actionBy { get; set; }
        public string Alert { get; set; }

        public static List<Alerts> GetAllAlerts()
        { return AlertsDAL.GetAllAlerts(); }

        public static Alerts GetAlertsById(int id)
        { return AlertsDAL.GetAlertById(id); }
        public void SaveAlert()
        { AlertsDAL.SaveAlert(this); }

        public static Alerts GetLastAlert(int aid)
        { return AlertsDAL.GetLastAlert(aid); }

      public static  bool RemoveAlert(int id)
        { return AlertsDAL.RemoveAlert(id); }


    }
}