using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using BLL;

namespace AgentsProject.manage
{
    public partial class PropertiesList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int agentID = int.Parse(Application["Aid"]+"");
                Properties prop = new Properties() { Pagent_id = agentID };


                List<Properties> props = prop.GetProperties();
                AssLtl.Text = props.Count() + "";
                int cnt = 0;
                foreach (Properties propi in props)
                {
                    if (propi.Deleted != "Deleted")
                    {
                        cnt += propi.Pprice;
                    }
                }


              
                 string ern =  GlobalFunc.IntToCurrencyString(cnt, ",");
                ErnLtl.Text = ern;

            
                AssestRpt.DataSource = props;
                AssestRpt.DataBind();
                foreach (RepeaterItem item in AssestRpt.Items)
                {
                    HtmlGenericControl control = item.FindControl("aBtn") as HtmlGenericControl;
                    HtmlGenericControl control2 = item.FindControl("pereDel") as HtmlGenericControl;
                    if (control2.InnerText != "")
                    {
                        control.Visible = false;
                    }
                }


            }
        }

        protected void DltBtn_Click(object sender, EventArgs e)
        {
            Button Btn = (Button)(sender);
            int val = int.Parse(Btn.CommandArgument);

           bool happend =  Properties.RemovePropertie(val);
            if (happend)
            {
                DbCon Db = new DbCon();
                string sq;
                Alerts Al = new Alerts()
                {
                    Aid = int.Parse(Application["Aid"]+""),
                    Pid = val,
                    actionBy = int.Parse(Application["Aid"] + ""),
                    Alert = "Deleted"
                };
                sq = $"insert into Alerts (Aid,Pid,actionBy,Alert)" +
                $" values({Al.Aid},{Al.Pid},{Al.actionBy},'{Al.Alert}')";
                Db.ExecuteNonQuery(sq);
                Response.Redirect("PropertiesList.Aspx");
            }

        }
    }
}