using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace P3P
{
    public partial class Registratie : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            maak.Click += new EventHandler(maak_Click);
            
        }

        protected void maak_Click(object sender, EventArgs e)
        {
            label2.Visible = false;
            label6.Visible = false;
            label4.Visible = false;
            bool a = true;
           
                List<User> list = DatabaseConnector.getInstance().getUsers(); 
                foreach (User user in list)
                {
                    if (user.getUsername() == acname.Text)
                    {
                        label2.Visible = true;
                        a = false;
                    }
                } 
                
                
            
            if(W8W1.Text!=W8W2.Text)
            {
                a = false;
                label6.Visible = true;
            }
            if((W8W1.Text==""||(W8W1.Text==acname.Text)))
            {
                label4.Visible = true;
                a = false;
            }
            if(a== true)
            {
                DatabaseConnector.getInstance().setUser(1, acname.Text, W8W1.Text);
                Server.Transfer("Index.aspx");
            }

        }

        
    }
}