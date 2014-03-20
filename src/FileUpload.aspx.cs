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
            if(FileUploadControl.HasFile)
            {
                try{
                    string filename = FileUploadControl.FileName;
                    FileUploadControl.SaveAs(Server.MapPath("~/Fotos/") + filename);
                    StatusLabel.Text = "Upload status: File uploaded!";
                    DatabaseConnector.getInstance().SetFile(Text1.Text, filename);
                }
                catch(Exception ex)
                {
                    StatusLabel.Text ="Error";
                }
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
    }
}