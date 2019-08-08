<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormAula1.aspx.cs" Inherits="WebForms_Aula01.WebFormAula1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style2 {
            width: 134px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td>Nome:
                    </td>
                    <td>
                        <asp:TextBox ID="txtNome" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Sobrenome:
                    </td>
                    <td>
                        <asp:TextBox ID="txtSobreNome" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" OnClick="btnCancelar_Click" />
                    </td>
                     <td class="auto-style2">
                        <asp:Button ID="btnOK" runat="server" Text="OK" OnClick="btnOK_Click" />
                    </td>
                </tr>
                <tr>
                    <td colspan ="2">

                        <asp:Label ID="lblNomeCompleto" runat="server" Text=""></asp:Label>

                    </td>
                </tr>

            </table>
        </div>
    </form>
</body>
</html>
