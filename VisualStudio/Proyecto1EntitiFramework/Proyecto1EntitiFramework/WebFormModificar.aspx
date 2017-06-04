<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormModificar.aspx.cs" Inherits="Proyecto1EntitiFramework.WebFormModificar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="StyleSheet1.css" type="text/css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            
            <asp:label runat="server">Codigo de curso</asp:label>
            <asp:TextBox ID="alumno_codcur" runat="server"></asp:TextBox>
            <br />
            <asp:Label runat="server">Codigo de alumno</asp:Label>
            <asp:TextBox ID="alumno_codalu" runat="server"></asp:TextBox>
            <br />
            <asp:Label  runat="server">Nombre</asp:Label>
            <asp:TextBox ID="alumno_nombre" runat="server"></asp:TextBox>
            <br />
            <asp:Label  runat="server">Apellido</asp:Label>
            <asp:TextBox ID="alumno_apellido" runat="server"></asp:TextBox>
            <br />
            <asp:Label  runat="server">DNI</asp:Label>
            <asp:TextBox ID="alumno_dni" runat="server"></asp:TextBox>

             <asp:Button runat="server" ID="acceptbutton" Text="Aceptar" OnClick="acceptbutton_OnClick" />
             <asp:Button runat="server" ID="cancelbutton" Text="Cancelar" OnClick="cancelbutton_OnClick"/>
             <asp:Button runat="server" ID="deletebutton" Text="Borrar" OnClick="deletebutton_OnClick" />
        </div>
        
        <asp:HyperLink runat="server" ID="enlaceinicio" Text="volver" NavigateUrl="~/WebForminicio.aspx" ToolTip="Volver a Inicio" ></asp:HyperLink>
    </form>
</body>
</html>
