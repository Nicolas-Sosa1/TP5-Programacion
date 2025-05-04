<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AgregarSucursal.aspx.cs" Inherits="TP5_Grupo18_Programacion.AgregarSucursal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style7 {
            width: 10%;
            height: 41px;
        }
        .auto-style8 {
            width: 16%;
            height: 41px;
        }
        .auto-style10 {
            height: 48px;
        }
        .auto-style12 {
            height: 48px;
        }
        .auto-style13 {
            height: 41px;
            width: 2%;
        }
        .auto-style14 {
            height: 41px;
            width: 12%;
        }
        .auto-style15 {
            height: 41px;
            width: 8%;
        }
        .auto-style16 {
            height: 41px;
            width: 7%;
        }
        .auto-style17 {
            width: 10%;
        }
        .auto-style18 {
            width: 16%;
        }
        .auto-style19 {
            width: 2%;
        }
        .auto-style20 {
            width: 12%;
        }
        .auto-style21 {
            width: 8%;
        }
        .auto-style22 {
            width: 7%;
        }
        .auto-style23 {
            width: 10%;
            height: 23px;
        }
        .auto-style24 {
            width: 16%;
            height: 23px;
        }
        .auto-style25 {
            height: 23px;
            width: 2%;
        }
        .auto-style26 {
            height: 23px;
            width: 12%;
        }
        .auto-style27 {
            height: 23px;
            width: 8%;
        }
        .auto-style28 {
            height: 23px;
            width: 7%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style10" colspan="3">
                        <asp:HyperLink ID="HLagregar" runat="server" NavigateUrl="~/AgregarSucursal.aspx">Agregar Sucursal</asp:HyperLink>
                    </td>
                    <td class="auto-style12" colspan="3">
                        <asp:HyperLink ID="HLlistado" runat="server" NavigateUrl="~/ListadoSucursales.aspx">Listado de Sucursales</asp:HyperLink>
                    </td>
                    <td class="auto-style12" colspan="4">
                        <asp:HyperLink ID="HLeliminar" runat="server" NavigateUrl="~/EliminarSucursales.aspx">Eliminar Sucursal</asp:HyperLink>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style7"></td>
                    <td class="auto-style8"></td>
                    <td class="auto-style13"></td>
                    <td class="auto-style14"></td>
                    <td class="auto-style14"></td>
                    <td class="auto-style14"></td>
                    <td class="auto-style15"></td>
                    <td class="auto-style16"></td>
                    <td class="auto-style16"></td>
                    <td class="auto-style16"></td>
                </tr>
                <tr>
                    <td class="auto-style17"><strong>Grupo N° 18</strong></td>
                    <td class="auto-style18">&nbsp;</td>
                    <td class="auto-style19">&nbsp;</td>
                    <td class="auto-style20">&nbsp;</td>
                    <td class="auto-style20">&nbsp;</td>
                    <td class="auto-style20">&nbsp;</td>
                    <td class="auto-style21">&nbsp;</td>
                    <td class="auto-style22">&nbsp;</td>
                    <td class="auto-style22">&nbsp;</td>
                    <td class="auto-style22">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style17">&nbsp;</td>
                    <td class="auto-style18">&nbsp;</td>
                    <td class="auto-style19">&nbsp;</td>
                    <td class="auto-style20">&nbsp;</td>
                    <td class="auto-style20">&nbsp;</td>
                    <td class="auto-style20">&nbsp;</td>
                    <td class="auto-style21">&nbsp;</td>
                    <td class="auto-style22">&nbsp;</td>
                    <td class="auto-style22">&nbsp;</td>
                    <td class="auto-style22">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style17"><strong>Agregar Sucursal</strong></td>
                    <td class="auto-style18">&nbsp;</td>
                    <td class="auto-style19">&nbsp;</td>
                    <td class="auto-style20">&nbsp;</td>
                    <td class="auto-style20">&nbsp;</td>
                    <td class="auto-style20">&nbsp;</td>
                    <td class="auto-style21">&nbsp;</td>
                    <td class="auto-style22">&nbsp;</td>
                    <td class="auto-style22">&nbsp;</td>
                    <td class="auto-style22">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style23"></td>
                    <td class="auto-style24"></td>
                    <td class="auto-style25"></td>
                    <td class="auto-style26">&nbsp;</td>
                    <td class="auto-style26"></td>
                    <td class="auto-style26"></td>
                    <td class="auto-style27"></td>
                    <td class="auto-style28"></td>
                    <td class="auto-style28"></td>
                    <td class="auto-style28"></td>
                </tr>
                <tr>
                    <td class="auto-style17">Nombre Sucursal:</td>
                    <td class="auto-style18">
                        <asp:TextBox ID="txtNombreSucursal" runat="server" Width="189px"></asp:TextBox>
                    </td>
                    <td class="auto-style19">
                        <asp:RequiredFieldValidator ID="rfvNombreSucursal" runat="server" ControlToValidate="txtNombreSucursal" ErrorMessage="Debe ingresar un nombre de sucursal" ValidationGroup="1">*</asp:RequiredFieldValidator>
                    </td>
                    <td class="auto-style20">&nbsp;</td>
                    <td class="auto-style20">&nbsp;</td>
                    <td class="auto-style20">&nbsp;</td>
                    <td class="auto-style21">&nbsp;</td>
                    <td class="auto-style22">&nbsp;</td>
                    <td class="auto-style22">&nbsp;</td>
                    <td class="auto-style22">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style17">Descripcion:</td>
                    <td class="auto-style18">
                        <asp:TextBox ID="txtDescripcion" runat="server" TextMode="MultiLine" Width="189px"></asp:TextBox>
                    </td>
                    <td class="auto-style19">
                        <asp:RequiredFieldValidator ID="rfvDescripcion" runat="server" ControlToValidate="txtDescripcion" ErrorMessage="Debe ingresar una descripcion" ValidationGroup="1">*</asp:RequiredFieldValidator>
                    </td>
                    <td class="auto-style20">&nbsp;</td>
                    <td class="auto-style20">&nbsp;</td>
                    <td class="auto-style20">&nbsp;</td>
                    <td class="auto-style21">&nbsp;</td>
                    <td class="auto-style22">&nbsp;</td>
                    <td class="auto-style22">&nbsp;</td>
                    <td class="auto-style22">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style23">Provincia:</td>
                    <td class="auto-style24">
                        <asp:DropDownList ID="ddlProvincia" runat="server" Height="23px" ValidationGroup="1" Width="224px">
                        </asp:DropDownList>
                    </td>
                    <td class="auto-style25">
                        <asp:RequiredFieldValidator ID="rfvProvincia" runat="server" ControlToValidate="ddlProvincia" ErrorMessage="Debe seleccionar una provincia" InitialValue="0" ValidationGroup="1">*</asp:RequiredFieldValidator>
                    </td>
                    <td class="auto-style26"></td>
                    <td class="auto-style26"></td>
                    <td class="auto-style26"></td>
                    <td class="auto-style27"></td>
                    <td class="auto-style28"></td>
                    <td class="auto-style28"></td>
                    <td class="auto-style28"></td>
                </tr>
                <tr>
                    <td class="auto-style17">Dirección:</td>
                    <td class="auto-style18">
                        <asp:TextBox ID="txtDireccion" runat="server" ValidationGroup="1" Width="215px"></asp:TextBox>
                    </td>
                    <td class="auto-style19">
                        <asp:RequiredFieldValidator ID="rfvDireccion" runat="server" ControlToValidate="txtDescripcion" ErrorMessage="Debe ingresar una direccion" ValidationGroup="1">*</asp:RequiredFieldValidator>
                    </td>
                    <td class="auto-style20">&nbsp;</td>
                    <td class="auto-style20">&nbsp;</td>
                    <td class="auto-style20">&nbsp;</td>
                    <td class="auto-style21">&nbsp;</td>
                    <td class="auto-style22">&nbsp;</td>
                    <td class="auto-style22">&nbsp;</td>
                    <td class="auto-style22">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style17">&nbsp;</td>
                    <td class="auto-style18">&nbsp;</td>
                    <td class="auto-style19">&nbsp;</td>
                    <td class="auto-style20">&nbsp;</td>
                    <td class="auto-style20">&nbsp;</td>
                    <td class="auto-style20">&nbsp;</td>
                    <td class="auto-style21">&nbsp;</td>
                    <td class="auto-style22">&nbsp;</td>
                    <td class="auto-style22">&nbsp;</td>
                    <td class="auto-style22">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style17">&nbsp;</td>
                    <td class="auto-style18">
                        <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" />
                    </td>
                    <td class="auto-style19">&nbsp;</td>
                    <td class="auto-style20">&nbsp;</td>
                    <td class="auto-style20">&nbsp;</td>
                    <td class="auto-style20">&nbsp;</td>
                    <td class="auto-style21">&nbsp;</td>
                    <td class="auto-style22">&nbsp;</td>
                    <td class="auto-style22">&nbsp;</td>
                    <td class="auto-style22">&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
