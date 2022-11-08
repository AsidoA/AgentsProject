using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
namespace AgentsProject.manage
{
    public partial class AddEdit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                string pid = Request["Pid"] + "";
                if(pid != "")
                {
                    Hiden.Value = pid;
                    Properties prop = Properties.GetPropertieById(int.Parse(pid));
                    Pname.Text = prop.Pname;
                    Pdltype.Text = prop.Pdeal_type;
                    Pflor.Text = prop.Pfloor + "";
                    Proms.Text = prop.Prooms + "";
                    Pcity.Text = prop.Pcity;
                    Paddress.Text = prop.Padress;
                    Psz.Text = prop.Psize + "";
                    Ppric.Text = prop.Pprice + "";
                }
                else
                {
                    Hiden.Value = "-1";
                }
            }
        }

        protected void AddBtn_Click(object sender, EventArgs e)
        {
            if (Pname == null || Pdltype == null || Proms== null
                || Paddress == null || Pflor == null || Pcity == null || Psz == null || Ppric == null)
                commentLtl.Text = "Please fill all fields";
            else if(int.Parse(Proms.Text) < 0 || int.Parse(Pflor.Text) < 0 || int.Parse(Psz.Text) < 0 || int.Parse(Ppric.Text) < 0 )
            {
                commentLtl.Text = "You cant insert minus in number field"; 
            }
            else
            {
                string fileName;
                string extesion;
                if (Flup.HasFile)
                {
                    fileName = GlobalFunc.GetRandomStr(7);
                    extesion = Path.GetExtension(Flup.FileName);
                    fileName += extesion;
                    Flup.SaveAs(Server.MapPath("../Uploads/Images/") + fileName);
                }
                else
                {
                    fileName = "";
                    extesion = "";
                }
                int aid = int.Parse(Application["Aid"] + "");
                int Pid;
                if (Request["Pid"] != null)
                {
                    Pid = int.Parse(Request["Pid"] + "");
                }
                else
                    Pid = 0;
                Properties prop = new Properties()
                {
                    Pid = Pid,
                    Pname = Pname.Text,
                    Padress = Paddress.Text,
                    Pagent_id = aid,
                    Pcity = Pcity.Text,
                    Pdeal_type = Pdltype.Text,
                    Pfloor = int.Parse(Pflor.Text),
                    Pprice = int.Parse(Ppric.Text),
                    Prooms = int.Parse(Proms.Text),
                    Psize = int.Parse(Psz.Text),
                    Pimage = fileName
                };

                 prop.SavePropertie();
                
                Response.Redirect("PropertiesList.aspx");
            }
        }
    }
}