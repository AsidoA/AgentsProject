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
    public class PropertiesController : ApiController
    {
        // GET: api/v1/Properties
        public string Get()
        {
            List<Properties> Tmp = Properties.GetAllProperties();
            return JsonConvert.SerializeObject(Tmp);
        }

        // GET: api/v1/Properties/5
        public string Get(int id)
        {
            Properties Tmp = Properties.GetPropertieById(id);
            return JsonConvert.SerializeObject(Tmp);
        }

        // POST: api/Properties
        public string Post([FromBody]Properties value)
        {
            value.SavePropertie();
            return JsonConvert.SerializeObject(value);
        }

        // PUT: api/Properties/5
        public string Put(int id, [FromBody]Properties value)
        {
            value.Pid = id;
            value.SavePropertie();
            return JsonConvert.SerializeObject(value);

        }

        // DELETE: api/Properties/5
        public string Delete(int id)
        {
            if (Properties.RemovePropertie(id))
                return "Removed";
            else
                return "NotFound";

        }
    }
}
