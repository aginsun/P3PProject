<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Winkelwagen.aspx.cs" Inherits="P3P.Winkelwagen" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
         <asp:TextBox ID="Tbox" runat="server" ></asp:TextBox>
         <asp:Button ID="Afrekenen" runat="server" Text="Afrekenen" OnClick="Afrekenen_Click" />
         <br />
         <asp:Button ID="Button1" runat="server" Text="Terug" OnClick="terug_Click" />
        <br />
        <asp:Repeater id="ding1" runat="server" >
   <ItemTemplate>
       <asp:Image runat="server" ImageUrl="~/Fotos/"+'<%# Container.DataItem.ToString() %>' /> 
      <asp:Label runat="server" Text='<%# Container.DataItem.ToString() %>'  ID="label1"  ></asp:Label>
       <asp:Button runat="server" Text="Verwijder" ID="button1"/>
       <br />
   </ItemTemplate>
</asp:Repeater>


    </div>
    </form>
</body>
</html>
