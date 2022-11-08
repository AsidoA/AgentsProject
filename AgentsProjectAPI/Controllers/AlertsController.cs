using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Newtonsoft.Json;
using BLL;

namespace AgentsProjectAPI.Controllers
{
    public class AlertsController : ApiController
    {
        // GET: api/Alerts
        public string Get()
        {
            List<Alerts> Tmp = Alerts.GetAllAlerts();
            return JsonConvert.SerializeObject(Tmp);
        }

        // GET: api/Alerts/5
        public string Get(int id)
        {
            Alerts Tmp = Alerts.GetAlertsById(id);
            return JsonConvert.SerializeObject(Tmp);
        }

        // POST: api/Alerts
        public string Post([FromBody]Alerts value)
        {
            value.SaveAlert();
            return JsonConvert.SerializeObject(value);
        }

        // PUT: api/Alerts/5
        public string Put(int id, [FromBody]Alerts value)
        {
            value.AlertID = id;
            value.SaveAlert();
            return JsonConvert.SerializeObject(value);
        }

        // DELETE: api/Alerts/5
        public string Delete(int id)
        {
            if (Alerts.RemoveAlert(id))
                return "Removed";
            else
                return "NotFound";
        }
    }
}
