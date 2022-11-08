using BLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AgentsProject.manage
{
    public partial class Notification : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                int aid = int.Parse(Application["Aid"] + "");

                DbCon Db = new DbCon();
                string Sql = "select AL.Alert,P.Pname,AL.AlertID" +
                    ",A.Apname + ' ' + A.Alname AS fullName from Properties AS P" +
                    " inner join Alerts AS AL On AL.Pid = P.Pid " +
                    "inner join Agents AS A On A.Aid = AL.Aid " +
                    $"Where A.Aid = {aid}";
                    
                DataTable Dt;
                Dt = Db.Execute(Sql);
                Db.Close();

                NotRpt.DataSource = Dt;
                NotRpt.DataBind();
            }
        }

        protected void DelBtn_Click(object sender, EventArgs e)
        {

            Button Btn = (Button)(sender);
            int val = int.Parse(Btn.CommandArgument);

            bool happend = Alerts.RemoveAlert(val);
            if (happend)
            {
                Response.Redirect("Notification.Aspx");
            }
        }
    }
}