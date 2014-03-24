using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace P3P
{
    public partial class Winkelwagen : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if ((string)Session["Logged"] != "Yes")
            {
                Server.Transfer("Home.aspx");
            }
            else
            {
                Button1.Click += new EventHandler(terug_Click);
                Afrekenen.Click += new EventHandler(Afrekenen_Click);

                List<string> order = new List<string>();
                string name = (string)Session["Username"];
                order = DatabaseConnector.getInstance().getOrders(name);
                if (!IsPostBack)
                {
                    ding1.DataSource = order;
                    ding1.DataBind();

                }



                foreach (RepeaterItem ritem in ding1.Items)
                {
                    Button btn = ritem.FindControl("button1") as Button;
                    btn.Click += new EventHandler(Unnamed_Click);
                }
                
            }
        }

        protected void terug_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }

        protected void Afrekenen_Click(object sender, EventArgs e)
        {
            string name = (string)Session["Username"];
            
            DatabaseConnector.getInstance().DellALL(name);
        }

        protected void Unnamed_Click(object sender, EventArgs e)
        {

            Button btn = (Button)sender;
            RepeaterItem ritem = (RepeaterItem)btn.NamingContainer;
            Label label1 = (Label)ritem.FindControl("label1");
            DatabaseConnector.getInstance().DellSome(label1.Text);
            Response.Redirect("Winkelwagen.aspx");
            
        }
    }
}