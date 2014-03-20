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
        
        protected void Button1_Click (object sender, System.EventArgs e)
        {
            // Is anything selected? The index is -1 if nothing is selected.
                if (DropDownList1.SelectedIndex > -1)
                {
                    string gekozenalbum = DropDownList1.SelectedItem.Text;

                } // deze werkt niet, dit is de code die een nieuw album moet maken, zoals ik nu zal laten zien en dan moet nog het Id nummer van het gekozen album meegegeven worden aan de geuploade pic dat vindik tricky zaken
        }

        protected void Button2_Click (object sender, System.EventArgs e)
        {
            string s = TextBox1.Text;
            string textboxinput = "1234567890qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM";
            char[] cst = s.ToCharArray();
            for (int i = 0; i < s.Length; i++)
            {
                if (!textboxinput.ToCharArray().Contains(cst[i]))
                {
                break;
                }
                else
                {
                    DatabaseConnector.getInstance().setalbum(TextBox1.Text);
                }
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
    }
}