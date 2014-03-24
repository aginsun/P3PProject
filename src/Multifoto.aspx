<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Multifoto.aspx.cs" Inherits="P3P.Multifoto" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" >
  <head runat="server">
    <title>ASP.NET Example</title>
</head>
<body>
    <form id="form1" runat="server">

      <asp:SqlDataSource
          id="SqlDataSource1"
          runat="server"
          DataSourceMode="DataReader"
          ConnectionString="<%$ ConnectionStrings:P3P%>"
          SelectCommand="SELECT Link FROM Pictures">
      </asp:SqlDataSource>

      <asp:GridView
          id="GridView1"
          runat="server"
          DataSourceID="SqlDataSource1" AutoGenerateColumns="False">
          <Columns>
            <asp:ImageField DataImageUrlField = "Link"
                DataImageUrlFormatString = "Fotos/{0}"
                ControlStyle-Width = "300" ControlStyle-Height = "300"
             HeaderStyle-BorderStyle="None" />
          </Columns>
      </asp:GridView>

    </form>
  </body>
</html>