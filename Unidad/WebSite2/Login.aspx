<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebSite2.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 23px;
        }
        .auto-style2 {
            height: 26px;
        }
        .auto-style7 {
            height: 26px;
            width: 127px;
        }
        .auto-style8 {
            height: 23px;
            width: 127px;
        }
        .auto-style9 {
            width: 127px;
        }
        .auto-style10 {
            width: 137px;
        }
        .auto-style11 {
            height: 26px;
            width: 137px;
        }
        .auto-style12 {
            height: 23px;
            width: 137px;
        }
    </style>
</head>
<body style="height: 362px">
    <form id="formLogin" runat="server">
       
        <table style="width:100%;">
            <tr>
                <td class="auto-style9">
                    &nbsp;</td>
                <td class="auto-style10">&nbsp;</td>
                <td>
        <asp:Label ID="lblBienvenido" runat="server" Text="Bienvenidos al sistema"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style9">
                    &nbsp;</td>
                <td class="auto-style10" style="margin-left: 40px">
        <asp:Label ID="lblUsuario" runat="server" Text="Usuario"></asp:Label>
                </td>
                <td>
         <asp:TextBox ID="txtUsuario" runat="server" style="margin-left: 0px; margin-bottom: 0px" OnTextChanged="txtUsuario_TextChanged"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style7">
                </td>
                <td class="auto-style11">
        <asp:Label ID="lblClave" runat="server" Text="Clave"></asp:Label>
                </td>
                <td class="auto-style2">
         <asp:TextBox ID="txtClave" runat="server" style="margin-left: 0px; margin-bottom: 0px" OnTextChanged="txtUsuario_TextChanged"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style8">

        <asp:LinkButton ID="lnkRecordarClave" runat="server" OnClick="LinkButton1_Click">Olvide mi contraseña</asp:LinkButton>


                </td>
                <td class="auto-style12">

                    &nbsp;</td>
                <td class="auto-style1">

            <asp:Button ID="btnIngresar" runat="server" OnClick="Button1_Click" Text="Ingresar" />


                </td>
            </tr>
        </table>


    </form>
</body>
</html>
