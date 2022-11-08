using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BLL
{
    public class Properties
    {
        public int Pid { get; set; }
        public string Pname { get; set; }
        public int Prooms { get; set; }
        public int Pfloor { get; set; }
        public string Padress { get; set; }
        public string Pcity { get; set; }
        public double Psize { get; set; }
        public string Pdeal_type { get; set; }
        public int Pprice { get; set; }
        public string Pimage { get; set; }
        public int Pagent_id { get; set; }
        public string Deleted { get; set; }

        public static List<Properties> GetAllProperties()
        { return PropertiesDAL.GetAllProperties(); }
        public List<Properties> GetProperties()
        { return PropertiesDAL.GetProperties(this.Pagent_id); }

        public void SavePropertie()
        { PropertiesDAL.SavePropertie(this); }

        public static Properties GetPropertieById(int id)
        { return PropertiesDAL.GetPropertieById(id); }

        public static bool RemovePropertie(int id)
        { return PropertiesDAL.RemovePropertie(id); }

    }
}