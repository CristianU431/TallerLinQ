<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Consulta0.aspx.cs" Inherits="TallerLinQ.Consulta0" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body id="txt">
    <form id="form1" runat="server">
        <div style="border-style: inset; font-family: fantasy; font-size: medium; background-color: #FF99CC;">
            TALLER LINQ - METAL FAMILY<br />
            Consultas de proyección:<br />
            <br />
            <asp:Button ID="btnCategorias" runat="server" OnClick="btnCategorias_Click" Text="Categorias" />
            <asp:Button ID="btnProductos" runat="server" OnClick="btnProductos_Click" Text="Productos" />
            <asp:Button ID="btnDetalles" runat="server" OnClick="btnDetalles_Click" Text="Detalles" />
            <br />
            <br />
            Operadores de Restricción<br />
            Numeros mayores que se hallen a:
            <asp:TextBox ID="txtNro" runat="server"></asp:TextBox>
            <asp:Button ID="btnConsulta" runat="server" OnClick="btnConsulta_Click" Text="Consulta" />
            <asp:Button ID="btnConsultar" runat="server" OnClick="btnConsultar_Click" Text="Consulta" />
            <br />
            <br />
            Seleccionar Codigo de Productos: <asp:DropDownList ID="ddlproductos" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlproductos_SelectedIndexChanged">
                <asp:ListItem>Selecciona Codigo de Categorias</asp:ListItem>
                <asp:ListItem>1</asp:ListItem>
                <asp:ListItem>2</asp:ListItem>
                <asp:ListItem>3</asp:ListItem>
                <asp:ListItem>4</asp:ListItem>
                <asp:ListItem>5</asp:ListItem>
                <asp:ListItem>6</asp:ListItem>
                <asp:ListItem>7</asp:ListItem>
                <asp:ListItem>8</asp:ListItem>
                <asp:ListItem>12</asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            Expresiones Lambda:<br />
            <br />
            Productos cuyo Stock sea mayor a:
            <asp:TextBox ID="txtnum" runat="server"></asp:TextBox>
            <asp:Button ID="btnconlambda" runat="server" OnClick="btnconlambda_Click" Text="Consultar" />
            <br />
            <br />
            Productos cuyo Stock sean menores a:
            <asp:TextBox ID="txtnum1" runat="server"></asp:TextBox>
&nbsp;<asp:Button ID="btnConsultaNu" runat="server" OnClick="btnConsultaNu_Click" Text="Consultar" />
            <br />
            <br />
            Cantidad de Promedio bajo y superior de una Categoria:
            <asp:Button ID="btnmax" runat="server" OnClick="btnmax_Click" Text="ConsultarSuperior" />
            <asp:Button ID="btnmin" runat="server" OnClick="btnmin_Click" Text="ConsultarBajo" />
            <br />
            <br />
            Cantidad que busque los primeros productos solicitados:
            <asp:TextBox ID="txtnumber" runat="server"></asp:TextBox>
            <asp:Button ID="btnprimpro" runat="server" OnClick="btnprimpro_Click" Text="Consultar" />
            <br />
            <br />
            Datos de los productos:
            <asp:Button ID="btndatos" runat="server" OnClick="btndatos_Click" Text="Consultar" />
            <br />
            <br />
            Precio de descuento con la cantidad:
            <asp:Button ID="btnprecio" runat="server" OnClick="btnprecio_Click" Text="Consultar" />
            <br />
            <br />
            Descripcion dDescripcion de las categorias:
            <asp:Button ID="btncat" runat="server" OnClick="btncat_Click" Text="Consultar" />
            <br />
            <asp:GridView ID="gvlist" runat="server">
            </asp:GridView>
        </div>
    </form>
</body>
</html>
