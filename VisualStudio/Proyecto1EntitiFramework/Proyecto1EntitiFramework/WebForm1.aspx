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
           <!-- <asp:DropDownList id="combobox1" AutoPostBack="True" runat="server"></asp:DropDownList>
            <asp:DropDownList id="combobox2" AutoPostBack="True" runat="server"></asp:DropDownList>
            <asp:GridView ID="gridView1" runat="server"></asp:GridView>--> <!--Creamos el DatagridView-->
            <!--<asp:GridView ID="gridView2" runat="server"></asp:GridView>-->
            
            <asp:label>Curso</asp:label>
            <asp:TextBox ID="campocurso" runat="server"></asp:TextBox>
            <asp:Label runat="server">Descripción</asp:Label>
            <asp:TextBox ID="campodescripcion" runat="server"></asp:TextBox>
            <asp:Label  runat="server">Horas</asp:Label>
            <asp:TextBox ID="campohoras" runat="server"></asp:TextBox>
            <asp:Label  runat="server">Tutor</asp:Label>
            <asp:TextBox ID="campotutor" runat="server"></asp:TextBox>
             <!--Botones-->
            <asp:Button ID="open" runat="server" Text="Abrir DBB"  />
            <asp:Button ID="closeBDD" runat="server" Text="Cerrar BDD"  />
            <asp:Button ID="new" runat="server" Text="Nuevo"  />
            <asp:Button ID="rec" runat="server" Text="Graba"  />
            <asp:Button ID="Delete" runat="server" Text="Borrar"  />
            
            <asp:Button ID="primero" runat="server" Text="|<<"  />
            <asp:Button ID="anterior" runat="server" Text="<<"  />
            <asp:Button ID="siguiente" runat="server" Text=">>"  />
            <asp:Button ID="ultimo" runat="server" Text=">>|"  />



        </div>
    </form>
</body>
</html>
