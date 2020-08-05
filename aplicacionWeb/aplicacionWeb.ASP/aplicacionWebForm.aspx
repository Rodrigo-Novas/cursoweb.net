<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="aplicacionWebForm.aspx.cs" Inherits="aplicacionWeb.ASP.aplicacionWebForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

          <%  Response.Write("Hola mundo <br> Como va?"); %>
            <label>Hola Mundo</label>
            <asp:Label Text="Un texto" runat="server"  ID="MiLabel"/>
            <asp:Label Text="Hora" runat="server" ID="FechaHora" />
        </div>
    </form>
</body>
</html>
