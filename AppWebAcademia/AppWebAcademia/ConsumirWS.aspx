<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ConsumirWS.aspx.cs" Inherits="AppWebAcademia.ConsumirWS" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link rel="stylesheet" type="text/css" href="~/css/style.css" />
</head>
<body style="height: 165px">

    <h1>Servicio Web local</h1>
    <h3>Obtener datos de usuario</h3>
    <form id="formWebServiceLocal" runat="server">  
        
        <asp:Label ID="lblInputID" runat="server" Text="ID Alumno:"></asp:Label>
        <asp:TextBox ID="txtID" runat="server" style="margin-left: 5px"></asp:TextBox>
    
        <asp:Button ID="btnGetUser" runat="server" Text="Consultar datos" OnClick="btnGetUser_Click" style="margin-left: 9px" />
        <br />
        <asp:Label ID="lblMensaje" runat="server" Visible="false"></asp:Label>
    
        <asp:Panel ID="panelResponse" runat="server" Visible="false">
            <asp:Table ID="tableUserData" runat="server">
                <asp:TableHeaderRow ID="HeaderRow" runat="server">
                    <asp:TableHeaderCell>ID</asp:TableHeaderCell>
                    <asp:TableHeaderCell>Nombre</asp:TableHeaderCell>
                    <asp:TableHeaderCell>Apellido</asp:TableHeaderCell>
                    <asp:TableHeaderCell>Nombre de Usuario</asp:TableHeaderCell>
                    <asp:TableHeaderCell>Email</asp:TableHeaderCell>
                    <asp:TableHeaderCell>Habilitado</asp:TableHeaderCell>
                </asp:TableHeaderRow>
                <asp:TableRow>
                    <asp:TableCell ID="cellID"></asp:TableCell>
                     <asp:TableCell ID="cellNombre"></asp:TableCell>
                     <asp:TableCell ID="cellApellido"></asp:TableCell>
                     <asp:TableCell ID="cellNombreUsuario"></asp:TableCell>
                     <asp:TableCell ID="cellEmail"></asp:TableCell>
                     <asp:TableCell ID="cellHabilitado"></asp:TableCell>
                </asp:TableRow>
            </asp:Table>
            
        </asp:Panel>

        <h1>&nbsp;</h1>
        <h1>WS Externo - Clima</h1>
        <p>
            <asp:Label ID="lblCD" runat="server" Text="Codigo Postal:" Width="100px"></asp:Label>
            <asp:TextBox ID="txtCD" runat="server" style="margin-left: 8px"></asp:TextBox>
            <asp:Button ID="btnGetWeather" runat="server" OnClick="btnGetWeather_Click" Text="Consultar pronostico" style="margin-left: 18px" /> <br /><br />
            <asp:Label ID="lblMessage" runat="server" Text="" Visible="false"></asp:Label>
        </p>

        <asp:Panel ID="panelWeather" runat="server" Visible="false">
            <asp:Label ID="lblCity" runat="server" Text="Ciudad" Width="100px"></asp:Label>
            <asp:TextBox ID="txtCity" runat="server" style="margin-left: 8px" ReadOnly="True"></asp:TextBox>
            <br />
            <asp:Label ID="lblTiempo" runat="server" Text="Tiempo" Width="100px"></asp:Label>
            <asp:TextBox ID="txtTiempo" runat="server" style="margin-left: 8px" ReadOnly="True"></asp:TextBox>
            <br />
            <div id="contentImgWheater">
                <asp:Image id="ImgTiempo" runat="server" AlternateText="Imagen del tiempo" ImageAlign="left"/>
            </div>
            
            <br />
            <asp:Label ID="lblTemperature" runat="server" Text="Temperatura" Width="100px"></asp:Label>
            <asp:TextBox ID="txtTemperature" runat="server" style="margin-left: 8px" ReadOnly="True"></asp:TextBox>
            <br />
            <asp:Label ID="lblHumedad" runat="server" Text="Humedad" Width="100px"></asp:Label>
            <asp:TextBox ID="txtHumedad" runat="server" style="margin-left: 8px" ReadOnly="True"></asp:TextBox>
            
            

        </asp:Panel>

        
        

        <h1>&nbsp;</h1>
        <h1>WS Externo - Geo IP</h1>
        <p>
            <asp:Label ID="Label1" runat="server" Text="Dirección IP:" Width="100px"></asp:Label>
            <asp:TextBox ID="txtIP" runat="server" style="margin-left: 8px"></asp:TextBox>
            <asp:Button ID="btnGetGeoIP" runat="server" Text="Consultar Ubicación" OnClick="btnGetGeoIP_Click" /><br /><br />
            <asp:Label ID="lblGeoIP" runat="server"></asp:Label>
        </p>

    </form>
</body>
</html>
