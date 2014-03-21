<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FileUpload.aspx.cs" Inherits="P3P.FileUpload" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:FileUpload ID="FileUploadControl" runat="server" />
        <asp:TextBox ID="Text1" runat="server"></asp:TextBox>
        <asp:Button runat="server" ID="UploadButton" Text="Upload" OnClick="Uploadbutton_Click" />
        <br /> <br />
        <asp:Label ID="Label1" runat="server" Text="Select album for photo"></asp:Label>
 <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SQLDatasource1"  
     DataTextField='Name' AppendDataBoundItems="True" AutoPostBack="True" DataValueField="Id">
             <asp:ListItem>-- pick one --</asp:ListItem>
 </asp:DropDownList> 
 
        <br /><br />
        <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>

        <asp:Label runat="server" id="StatusLabel" Text="Upload status: " />
        <br /><br />
        <asp:Label ID="Label2" runat="server" Text="Or create a new album first"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:Button ID="Button2" runat="server" Text="Create new album" />

              <asp:SqlDataSource
          id="SqlDataSource1"
          runat="server"
          DataSourceMode="DataReader"
          ConnectionString="<%$ ConnectionStrings:P3P%>"
          SelectCommand="SELECT Name, Id FROM Albums">
      </asp:SqlDataSource>

    </div>
    </form>
</body>
</html>
