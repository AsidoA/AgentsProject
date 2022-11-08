using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using BLL;


namespace AgentsProject
{
    public partial class LoginPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void RegDirect_Click(object sender, EventArgs e)
        {
            UcContainer.Visible = false;
            RegIn.Visible = true;
        }


        protected void LogBtn_Click(object sender, EventArgs e)
        {
            string newPass = GlobalFunc.passConvert(logPass.Text);
            Agents Ag = new Agents() { Aemail = logEmail.Text, Apass = newPass };
            if (Ag.CheckUser() != null)
            {
                Ag = Ag.CheckUser();
                Application["Aid"] = Ag.Aid + "";
                Response.Redirect($"manage/PropertiesList.aspx");
            }
            else
                RspLtl.Text = "Please check youre details / Create New Account";

            
        }

    }
}