using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace P3P
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Button1.Click += new EventHandler(Button1_Click);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           //DatabaseConnector.getInstance().setalbum("x");
            
           //List<string> namen = DatabaseConnector.getInstance().getalbumnames(0);
           //for (int i = 0; i < namen.Count;i++)
           //{
            //   textbox.Text += namen[i];
          // }
            DatabaseConnector.getInstance().Leeg("er");
        }

    }
}