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
                //List<Order> list = DatabaseConnector.getInstance().getOrder(name);
                //foreach (Order Username in list)
                //{
                //    if (Username.getUsername() == name)
                //    {
                //        order.Add(Username.getBestellingen());
                //     }
                // }

                for (int i = 0; i < order.Count; i++)
                {
                    Tbox.Text += order[i];
                }
            }
        }

        protected void terug_Click(object sender, EventArgs e)
        {
            Server.Transfer("Home.aspx");
        }

        protected void Afrekenen_Click(object sender, EventArgs e)
        {
            string name = (string)Session["Username"];
            //DatabaseConnector.getInstance().DelALLShopping(name);
        }
    }
}