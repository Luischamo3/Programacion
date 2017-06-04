<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebformNuevoAlumno.aspx.cs" Inherits="Proyecto1EntitiFramework.WebformNuevoAlumno" %>

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
            <asp:Label runat="server" >Codigo Alumno</asp:Label>
            <asp:TextBox runat="server" ID="campocodalu" ToolTip="Escriba el codigo de la siguiente forma A201200005"  ></asp:TextBox>
            <br/>
            <asp:Label runat="server">Curos</asp:Label>
            <asp:DropDownList id="comboboxcursos" AutoPostBack="True" OnSelectedIndexChanged="comboboxcursos_OnSelectedIndexChanged" runat="server"></asp:DropDownList>
            <br/>
            <asp:Label runat="server">DNI</asp:Label>
            <asp:TextBox runat="server" ID="campodni" ></asp:TextBox>
            <br/>
            <asp:Label runat="server">Nombre</asp:Label>
            <asp:TextBox runat="server" ID="camponombre" ></asp:TextBox>
            <br/>
            
            <asp:Label runat="server">Apellido</asp:Label>
            <asp:TextBox runat="server" ID="campoapellido" ></asp:TextBox>
            <br/>
            <asp:Label runat="server">Nota1</asp:Label>
            <asp:TextBox runat="server" ID="camponota1" ></asp:TextBox>
            <br/>
             <asp:Label runat="server">Nota2</asp:Label>
            <asp:TextBox runat="server" ID="camponota2" ></asp:TextBox>
            <br/>
             <asp:Label runat="server">Nota3</asp:Label>
            <asp:TextBox runat="server" ID="camponota3" ></asp:TextBox>
                <br/>
           <%--  <asp:Label runat="server">Media</asp:Label>
            <br/>
            <asp:TextBox runat="server" ID="campomedia" ReadOnly="True" ></asp:TextBox>--%>

            
            <asp:Button runat="server" ID="savebutton" Text="Guardar" OnClick="savebutton_OnClick" />

              <asp:Button runat="server" ID="deletebutton" Text="Eliminar"/>
            
             
        </div>
        
        <asp:HyperLink runat="server" ID="enlaceinicio" Text="volver" NavigateUrl="~/WebForminicio.aspx" ToolTip="Volver a Inicio" ></asp:HyperLink>
    </form>
</body>
</html>
