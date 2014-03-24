using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace P3P
{
    public partial class Index : System.Web.UI.Page
    {
        protected void session_start(Object sender,EventArgs e)
        {
            Session["Logged"] = "No";
            Session["Username"] = "";

        }


        protected void Page_Load(object sender, EventArgs e)
        {
            if ((string)Session["Logged"] == "Yes")
            {
                Session["Username"] = "";
                Session["Logged"] = "No";
                Server.Transfer("Home.aspx");
            }
            login.Click += new EventHandler(login_Click);
            creeër.Click += new EventHandler(creeër_Click);
        }
    
        protected void login_Click(object sender, EventArgs e)
        {
            List<User> list = DatabaseConnector.getInstance().getUsers();
            foreach (User user in list)
            {
                if ((user.getUsername() == text1.Text )&& (user.getPassword()==text2.Text))
                {
                    string b = text1.Text;
                    Session["Username"] = b;
                    Session["Logged"] = "Yes";
                    Server.Transfer("Home.aspx");
                    
                }
            }     
        }

        protected void creeër_Click(object sender, EventArgs e)
        {
            Server.Transfer("Registratie.aspx");
            
        }
    }
}