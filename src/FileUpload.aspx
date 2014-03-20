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
        <asp:Label runat="server" id="StatusLabel" Text="Upload status: " />
    </div>
    </form>
</body>
</html>
