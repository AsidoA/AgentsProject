using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
namespace BLL
{
    public class Agents
    {
        public int Aid { get; set; }
        public string Apname { get; set; }
        public string Alname { get; set; }
        public string Aadress { get; set; }
        public string Aemail { get; set; }
        public string Apass { get; set; }


        public static Agents getAgentById(int id)
        { return AgentsDAL.getAgentById(id); }
        public Agents CheckUser()
        { return AgentsDAL.CheckUser(this); }

        public void SaveNewAgent()
        { AgentsDAL.SaveNewAgent(this); }

    }
}