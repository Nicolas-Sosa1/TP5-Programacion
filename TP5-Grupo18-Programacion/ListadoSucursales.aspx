<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListadoSucursales.aspx.cs" Inherits="TP5_Grupo18_Programacion.ListadoSucursales" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">

        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            height: 23px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2">
                        <asp:HyperLink ID="HLagregar" runat="server" NavigateUrl="~/AgregarSucursal.aspx">Agregar Sucursal</asp:HyperLink>
                    </td>
                    <td class="auto-style2">
                        <asp:HyperLink ID="HLlistado" runat="server" NavigateUrl="~/ListadoSucursales.aspx">Listado de Sucursales</asp:HyperLink>
                    </td>
                    <td class="auto-style2">
                        <asp:HyperLink ID="HLeliminar" runat="server" NavigateUrl="~/EliminarSucursales.aspx">Eliminar Sucursal</asp:HyperLink>
                    </td>
                </tr>
            </table>
            <br />
            <br />
        </div>
    </form>
</body>
</html>
