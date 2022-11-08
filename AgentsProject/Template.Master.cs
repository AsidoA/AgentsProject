using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace AgentsProject
{
    public partial class Template : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int aid = int.Parse(Application["Aid"]+"");
                Agents Ag = Agents.getAgentById(aid);
               

                AgentLtl.Text = Ag.Apname + " " + Ag.Alname;


                DbCon Db = new DbCon();
                string Sql = "select AL.Alert,P.Pname,AL.AlertID" +
                    ",A.Apname + ' ' + A.Alname AS fullName from Properties AS P" +
                    " inner join Alerts AS AL On AL.Pid = P.Pid " +
                    "inner join Agents AS A On A.Aid = AL.Aid " +
                    $"Where A.Aid = {aid}"+
                    "Order By AlertID DESC  OFFSET 0 ROWS FETCH FIRST 5 ROWS ONLY";
                DataTable Dt;
                Dt = Db.Execute(Sql);
                Db.Close();

                AltRpt.DataSource = Dt;
                AltRpt.DataBind();

                int _cntAlt = 0;
                string alt = "";
                for (int i = 0; i < Dt.Rows.Count; i++)
                {
                 _cntAlt++;
                    if (_cntAlt > 4)
                    {
                        alt = "+";
                        _cntAlt = 4;
                        break;
                    }
                }

                cntAlert.Text = _cntAlt + alt;
                




            }



        }
        public string GetRowProperties()
        {
            return Application["Aid"] + "";
        }

        protected void LgOt_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/LoginPage.aspx");
        }
    }
}