﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace P3P
{
    public partial class SoloFoto : System.Web.UI.Page
    {
        public static int fotoID = 0;

        protected void Page_Load(object sender, EventArgs e)
        {
            onthoud.Click += new EventHandler(onthoud_Click);
            Session["Button"] = "True";
            label1.Visible = false;
        }

        protected void onthoud_Click(object sender, EventArgs e)
        {
            if ((string)Session["Logged"] == "Yes")
            {
                if ((string)Session["Button"] == "True")
                {
                    string name = (string)Session["Username"];
                    //DatabaseConnector.getInstance().SendShopping(fotoID, "Hier moet de link van foto", name);
                    Session["Button"] = "False";
                }
            }
            else
            {
                label1.Visible = true;
            }
            
        }
        protected void Next_Click(object sender, EventArgs e)
        {
            fotoID++;
            //DatabaseConnector.getInstance().getFoto(fotoID);
            Server.Transfer("SoloFoto.aspx");
        }

        protected void Vorige_Click(object sender, EventArgs e)
        {

            Server.Transfer("SoloFoto.aspx");
        }

        protected void Terug_Click(object sender, EventArgs e)
        {
            Server.Transfer("Home.aspx");
        }
    }
}