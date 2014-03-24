using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace P3P
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if ((string)Session["logged"] == "No")
            {
                Server.Transfer("Index.aspx");
            }
            else if((string)Session["logged"] == "Yes")
            {
                login.InnerText = "Logout";
            }
            string naam = (string)Session["Username"];
        }
    }
}