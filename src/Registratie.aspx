<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registratie.aspx.cs" Inherits="P3P.Registratie" %>

<!DOCTYPE html>
<html>
<head>
    <link href="stylesheet1.css" rel="stylesheet" type="text/css" />
    <title>Foto Website</title>
</head>
<body ALIGN="CENTER">
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="label1" runat="server" Text="Username"></asp:Label>
        <asp:TextBox ID="acname" runat="server"></asp:TextBox>
        <asp:Label ID="label2" runat="server" Text="Username bestaat al" Visible="false"></asp:Label>
        <br />
        <asp:Label ID="label3" runat="server" Text="Wachtwoord" ></asp:Label>
        <asp:TextBox ID="W8W1" runat="server" TextMode="Password"></asp:TextBox>
        <asp:Label ID="label4" runat="server" Text="Ongeldig Wachtwoord" Visible="false"></asp:Label>
        <br />
        <asp:Label ID="label5" runat="server" Text="Herhaal Wachtwoord" ></asp:Label>
        <asp:TextBox ID="W8W2" runat="server" TextMode="Password"></asp:TextBox>
        <asp:Label ID="label6" runat="server" Text="Wachtwoorden komen niet overeen" Visible="false"></asp:Label>
        <br />
        <asp:Button ID="maak" runat="server" Text="Registreer" OnClick="maak_Click" />
    
    </div>
    </form>
</body>
</html>
