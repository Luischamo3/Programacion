<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormNotas.aspx.cs" Inherits="Proyecto1EntitiFramework.WebFormNotas" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
     <link rel="stylesheet" type="text/css" href="StyleSheet1.css">
   
</head>
    
<body>
    <form id="form1" runat="server">
        <div class="">
            
            <asp:DropDownList id="combobox1" AutoPostBack="True" OnSelectedIndexChanged="combobox1_OnSelectedIndexChanged" runat="server"></asp:DropDownList>
           <br/>
            <asp:GridView ID="gridView2"  runat="server" AutoGenerateColumns="False" OnRowCommand="gridView2_OnRowCommand" BackColor="white" >
               <Columns>
                   <asp:ButtonField CommandName="Modificar" ButtonType="Button" Text="Modificar"  />
                   <asp:BoundField DataField="COD_ALU" HeaderText="CODIGO ALUMNO"  />
                   <asp:BoundField DataField="APELLIDOS" HeaderText="APELLIDOS"/>
                   <asp:BoundField DataField="NOMBRE" HeaderText="NOMBRE" />
                   <asp:BoundField DataField="NOTA1" HeaderText="NOTA1"/>
                   <asp:BoundField DataField="NOTA2" HeaderText="NOTA2" />
                   <asp:BoundField DataField="NOTA3" HeaderText="NOTA3" />
                   <asp:BoundField DataField="MEDIA" HeaderText="MEDIA" />
                  
               </Columns>
            </asp:GridView> <!--Creamos el DatagridView-->
            
             
            <asp:Panel ID="Panel1" runat="server">
                <br/>
                <asp:label>CodAlu</asp:label>
                <asp:TextBox runat="server" ID="campocodalu" CssClass="red"></asp:TextBox>
                <br/>
                <asp:label>Nota1</asp:label>
                <asp:TextBox runat="server" ID="note1" CssClass="red"></asp:TextBox>
                <br/>
                 <asp:label>Nota2</asp:label>
                <asp:TextBox runat="server" ID="note2"></asp:TextBox>
                <br/>
                 <asp:label>Nota3</asp:label>
                <asp:TextBox runat="server" ID="note3" ></asp:TextBox>
                <br/>
                 <%--<asp:label>Media</asp:label>
                <asp:TextBox runat="server" ID="avg" ReadOnly="True" ></asp:TextBox>--%>
                <br/>
                <asp:Button runat="server" ID="savebutton" OnClick="savebutton_OnClick" Text="Guardar"/>
                <asp:Button runat="server" ID="cancelbutton" OnClick="cancelbutton_OnClick" Text="Cancelar"/>
                <asp:Button runat="server" ID="deletebutton" OnClick="deletebutton_OnClick" Text="Eliminar"/>
                
           
            </asp:Panel>

        </div>
        
        <asp:HyperLink runat="server" ID="enlaceinicio" Text="volver" NavigateUrl="~/WebForminicio.aspx" ToolTip="Volver a Inicio" ></asp:HyperLink>
    </form>
</body>
</html>
