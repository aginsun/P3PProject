<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SoloFoto.aspx.cs" Inherits="P3P.SoloFoto" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Button ID="Terug" runat="server" Text="Terug naar home" OnClick="Terug_Click" />
        <br />
        <asp:Button ID="onthoud" runat="server" Text="Voeg toe aan Winkelwagen" OnClick="onthoud_Click" />
        <asp:Label ID="label1" runat="server" Text="Log in om afbeeldingen toe te voegen aan het winkelwagentje" Visible="false"></asp:Label>
        <br />
        <asp:Image runat="server" ID="image" ImageUrl="/miniaturen/D7K_0047_Rome.jpg" />
        <br />
        <asp:Button ID="Vorige" runat="server" Text="Vorige" OnClick="Vorige_Click" />
        <asp:Button ID="Next" runat="server" Text="Volgende" OnClick="Next_Click" />
        
    
    </div>
    </form>
</body>
</html>
