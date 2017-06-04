<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForminicio.aspx.cs" Inherits="Proyecto1EntitiFramework.WebForminicio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="StyleSheet1.css" type="text/css" rel="stylesheet" />
</head>
<body >
    <form id="form1" runat="server" CssClass="form1" >
        
         <h1>Formulario de Inicio</h1>

        <div >
           <asp:HyperLink Id="MantenimientodeCursos"  runat="server" NavigateUrl="~/WebForm1.aspx" text="Cursos" ToolTip="Acceder a los Cursos" CssClass="inicio" ></asp:HyperLink>
            <asp:HyperLink Id="MantenimientodeAlumnos" runat="server" NavigateUrl="~/WebFormAlumnos.aspx" text="Alumnos"></asp:HyperLink>
            <asp:HyperLink Id="MantenimientodeNotas" runat="server" NavigateUrl="~/WebFormNotas.aspx" text="Notas"></asp:HyperLink>
        </div>
    </form>
</body>
</html>
