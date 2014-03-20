<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Album1.aspx.cs" Inherits="P3P.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
    <style>
    body {
        background-image: url("images/wild_flowers.png");
        background-attachment: fixed;
    }
</style>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Pinkpop</h1>
        <asp:TextBox runat="server" ID="textbox" ></asp:TextBox>
        <h2><img src="images/miniaturen/D7K_0047_Rome.jpg"/> </h2>
        <asp:Button ID="Button1" runat="server" Text="Button" onclick="Button1_Click" />
    </div>
    </form>

</body>
</html>
