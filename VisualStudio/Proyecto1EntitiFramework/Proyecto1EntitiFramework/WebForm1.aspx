<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Proyecto1EntitiFramework.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>BDD Cursos</title>
<link href="StyleSheet1.css" type="text/css" rel="stylesheet" />
</head>
<body>

    
    <form id="form1" runat="server">
        <div class="Contenedor">
           <h1>Formulario Cursos</h1>
        <aps:panel>
            <asp:label runat="server">Curso</asp:label>
            <asp:TextBox ID="campocurso" runat="server"></asp:TextBox>
            <br/>
            <asp:Label runat="server">Descripción</asp:Label>
            <asp:TextBox ID="campodescripcion" runat="server"></asp:TextBox>
            <br/>
            <asp:Label  runat="server">Horas</asp:Label>
            <asp:TextBox ID="campohoras" runat="server"></asp:TextBox>
            <br/>
            <asp:Label  runat="server">Tutor</asp:Label>
            <asp:TextBox ID="campotutor" runat="server"></asp:TextBox>
            <br />
         

             <!--Botones-->
            
            <asp:Button ID="new" runat="server" Text="Nuevo" OnClick="new_OnClick" />
            <asp:Button ID="rec" runat="server" Text="Graba" OnClick="rec_OnClick"  />
            <asp:Button ID="Delete" runat="server" Text="Borrar" OnClick="Delete_OnClick"  />

            <!--Botones Para Movernos Por los Registros-->
            <asp:Button ID="primero" runat="server" Text="|<<"  OnClick="primero_OnClick"/>
            <asp:Button ID="anterior" runat="server" Text="<<" OnClick="anterior_OnClick"  />
            <asp:Button ID="siguiente" runat="server" Text=">>" OnClick="siguiente_OnClick"  />
            <asp:Button ID="ultimo" runat="server" Text=">>|" OnClick="ultimo_OnClick" />
    </aps:panel> 
            
            <asp:HyperLink runat="server" ID="enlaceinicio" Text="volver" NavigateUrl="~/WebForminicio.aspx" ToolTip="Volver a Inicio" ></asp:HyperLink>

        </div>
    </form>
</body>
</html>
