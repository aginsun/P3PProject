<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="P3P.Index" %>

<!DOCTYPE html>
<html>
<head>
    <link href="stylesheet1.css" rel="stylesheet" type="text/css" />
    <title>Foto Website</title>
</head>
<body ALIGN="CENTER">
    <form id="form1" runat="server">
    <div>
    <asp:Label ID="label1" Text="Username" runat="server"></asp:Label>
    <asp:TextBox ID="text1" runat="server" ></asp:TextBox>
        <br />
    <asp:Label ID="label2" Text="Wachtwoord" runat="server"></asp:Label>
    <asp:TextBox ID="text2" TextMode="Password" runat="server"></asp:TextBox>
        <br />
    <asp:Button ID="login" runat="server" Text="Login" OnClick="login_Click" />
    <asp:Button ID="creeër" runat="server" Text="Registreren" OnClick="creeër_Click" />

    </div>
    </form>
</body>
</html>
