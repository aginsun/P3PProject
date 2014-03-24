using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace P3P
{
    public partial class FileUpload : System.Web.UI.Page
    {
        protected void Uploadbutton_Click(object sender, EventArgs e)
        {
            if (DropDownList1.SelectedValue != "-- pick one --")
            {
                if (FileUploadControl.HasFile)
                {
                    try
                    {
                        string filename = FileUploadControl.FileName;
                        FileUploadControl.SaveAs(Server.MapPath("~/Fotos/") + filename);
                        StatusLabel.Text = "Upload status: File uploaded!";
                        DatabaseConnector.getInstance().SetFile(Text1.Text, filename, Convert.ToInt32(DropDownList1.SelectedValue));
                    }
                    catch (Exception ex)
                    {
                        StatusLabel.Text = "Error";
                    }
                }
            }
        }
       
        protected void Button2_Click (object sender, EventArgs e)
        {
            if (TextBox1!=null)
                {
                    DatabaseConnector.getInstance().setalbum(TextBox1.Text);
                return;
                }
            }


    

        protected void Page_Load(object sender, EventArgs e)
        {
            Button2.Click += new EventHandler(Button2_Click);
            string albumname = DropDownList1.SelectedValue;
            if (albumname != "-- pick one --")
            Label3.Text = albumname;
        }

        protected void DropDownList1_TextChanged(object sender, EventArgs e)
        {
           // string albumname = DropDownList1.SelectedValue;
            //Label3.Text = albumname;
        }
    }
}