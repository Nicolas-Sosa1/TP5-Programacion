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
        .auto-style3 {
            width: 94px;
        }
        .auto-style4 {
            width: 35px;
        }
        .auto-style5 {
            height: 23px;
            width: 35px;
        }
    </style>
    </head>
<body>
    <form id="form1" runat="server">
        <div>
            
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2" colspan="3">
                        <asp:HyperLink ID="HLagregar" runat="server" NavigateUrl="~/AgregarSucursal.aspx">Agregar Sucursal</asp:HyperLink>
                    </td>
                    <td class="auto-style2" colspan="3">
                        <asp:HyperLink ID="HLlistado" runat="server" NavigateUrl="~/ListadoSucursales.aspx">Listado de Sucursales</asp:HyperLink>
                    </td>
                    <td class="auto-style2" colspan="3">
                        <asp:HyperLink ID="HLeliminar" runat="server" NavigateUrl="~/EliminarSucursales.aspx">Eliminar Sucursal</asp:HyperLink>
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td class="auto-style4">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td colspan="3">Listado de Sucursales:</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2"></td>
                    <td class="auto-style2"></td>
                    <td class="auto-style5"></td>
                    <td class="auto-style2"></td>
                    <td class="auto-style2"></td>
                    <td class="auto-style2"></td>
                    <td class="auto-style2"></td>
                    <td class="auto-style2"></td>
                    <td class="auto-style2"></td>
                </tr>
                <tr>
                    <td colspan="3">Búsqueda ingrese Id Sucursal: </td>
                    <td colspan="2">
                        <asp:TextBox ID="txtIdSucursal" runat="server" ValidationGroup="1" Width="205px"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RegularExpressionValidator ID="revIdSucursal" runat="server" ControlToValidate="txtIdSucursal" ErrorMessage="Debe ingresar un valor numerico" ValidationExpression="^[0-9,$]*$" ValidationGroup="1">*</asp:RegularExpressionValidator>
                        &nbsp;&nbsp;&nbsp;&nbsp;
                        </td>
                    <td>
                        <asp:RequiredFieldValidator ID="rfvSucursal" runat="server" ControlToValidate="txtIdSucursal" ErrorMessage="El campo no puede estar vacio" ValidationGroup="1">*</asp:RequiredFieldValidator>
                    </td>
                    <td>
                        <asp:Button ID="btnFiltrar" runat="server" Text="Filtrar" ValidationGroup="1" OnClick="btnFiltrar_Click" /></td>
                    <td>
                        <asp:Button ID="btnMostrar" runat="server" Text="Mostrar todos" OnClick="btnMostrar_Click" />
                    </td>
                </tr>
                <tr>
                    <asp:GridView ID="gvListado" runat="server"></asp:GridView>
                    <td>&nbsp;</td>
                    <td class="auto-style4">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td class="auto-style4">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td class="auto-style4">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td colspan="9">
                        <asp:ValidationSummary ID="vsValidaciones" runat="server" ValidationGroup="1" />
                    </td>
                </tr>
            </table>
            
        </div>
    </form>
</body>
</html>
