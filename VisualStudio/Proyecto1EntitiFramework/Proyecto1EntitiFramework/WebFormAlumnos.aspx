<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormAlumnos.aspx.cs" Inherits="Proyecto1EntitiFramework.WebFormAlumnos" %>
<%@ PreviousPageType VirtualPath="~/WebFormModificar.aspx" %> 
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link rel="stylesheet" type="text/css" href="StyleSheet1.css">
</head>
<body>
    <form id="form1" runat="server">
        <div class="form1">
            <h1>Formulario de Alumnos</h1>
            <asp:GridView  ID="gridview1" runat="server" OnRowCommand="gridview1_OnRowCommand" AutoGenerateColumns="false" BackColor="white" >
           
            <columns>
                <asp:BoundField DataField="COD_CUR" HeaderText="CURSO" />
                <asp:BoundField DataField="COD_ALU" HeaderText="CODIGO ALUMNO" />
                <asp:BoundField DataField="DNI" HeaderText="DNI" />
                <asp:BoundField DataField="APELLIDOS" HeaderText="APELLIDOS" />
                <asp:BoundField DataField="NOMBRE" HeaderText="NOMBRE" />
                <asp:ButtonField ButtonType="Button" CommandName="Modifica" Text="Modificar"  />
                <asp:ButtonField ButtonType="Button" CommandName="Borra" Text="Borrar" />
            </columns> 
            </asp:GridView>
           <asp:Button runat="server" ID="newalu" Text="Nuevo Alumno" OnClick="newalu_OnClick" ToolTip="Crear un nuevo alumno" />
        </div>
         <asp:HyperLink runat="server" ID="enlaceinicio" Text="volver" NavigateUrl="~/WebForminicio.aspx" ToolTip="Volver a Inicio" CssClass="botones" ></asp:HyperLink>
    </form>
    
</body>
</html>
