<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="albumoverzicht.aspx.cs" Inherits="P3P.albumoverzicht" %>

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
        <li runat="server" id="loginbutton"><a runat="server" id="login" href="/index.aspx">Log in</a></li>
    </ul>
    <form id="form1" runat="server">
        <br />
          <br />
          <br />


      <asp:SqlDataSource
          id="SqlDataSource1"
          runat="server"
          DataSourceMode="DataSet"
          ConnectionString="<%$ ConnectionStrings:P3P%>"
          SelectCommand="

;WITH CTE AS (
    SELECT    [Link]
            , [AlbumId]
            , [Id]
            , [rnum] =  ROW_NUMBER() OVER(PARTITION BY [AlbumId] ORDER BY [Id] DESC)
    FROM    Pictures
)
SELECT [Link], [AlbumId], [Id]
FROM CTE
WHERE rnum < 2

">
      </asp:SqlDataSource>

      <asp:GridView
          id="GridView1"
          runat="server"
          Columns="2"
          Rows="3"
          DataSourceID="SqlDataSource1" AutoGenerateColumns="False" AllowPaging="True" PageSize="3" AllowCustomPaging="True">
          <Columns>
            <asp:ImageField DataImageUrlField = "Link"
                DataImageUrlFormatString = "Fotos/{0}"
                ControlStyle-Width = "300" ControlStyle-Height = "300"
               HeaderText="Albums"/>
          </Columns>

      </asp:GridView>

    </form>
  </body>
</html>