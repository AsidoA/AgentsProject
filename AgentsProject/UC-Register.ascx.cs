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
    public partial class UC_Register : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           if(IsPostBack)
            {
                

            }
        }

        protected void chkBtn_Click(object sender, EventArgs e)
        {
            if (Fname.Text == "" || Lname.Text == "")
            {
                Ltl.Text = "Please enter youre full name ";
            }
            else if (Email.Text == "" || !Email.Text.Contains("@"))
            {
                Ltl.Text = "Please check youre email";
            }
            else
            {
                string newPass = GlobalFunc.passConvert(Password.Text);

                Agents Ag = new Agents()
                {
                    Aid = 0,
                    Apname = Fname.Text,
                    Alname = Lname.Text,
                    Aadress = Adress.Text,
                    Aemail = Email.Text,
                    Apass = newPass
                };

                if (Ag.CheckUser() != null)
                    Ltl.Text = "This email is alredy exist";
                else
                {
                    Ag.SaveNewAgent();
                    Response.Redirect("LoginPage.aspx");
                }
            }
        }
    }
}