<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="P3P.Index" %>

<!DOCTYPE html>
<html>
<head>
    <link href="stylesheet1.css" rel="stylesheet" type="text/css" />
    <title>Gerlof Hoekstra Foto's</title>
</head>
<body>
    
    <ul>
        <li><a href="#">Albums</a></li>
        <li><a href="/Winkelwagen.aspx">Winkelwagentje</a></li>
        <li><a href="/SoloFoto.aspx">Foto's Kopen</a></li>
        <li runat="server" id="loginbutton"><a runat="server" id="A1" href="/index.aspx">Log in</a></li>
    </ul>

    <br />
    <br />
    <br />
    <br />

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
