<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs"  Inherits="Portal_MVC._Default"  ClientIDMode="AutoID" %>


<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="UTF-8" />
    <title>Teste</title>
    <style type="text/css">
        .auto-style1 {
            width: 51%;
            height: 229px;
        }
        .auto-style4 {
            height: 26px;
            width: 115px;
        }
        .auto-style5 {
            width: 115px;
            height: 24px;
        }
        .auto-style7 {
            width: 255px;
        }
        .auto-style8 {
            height: 26px;
            width: 255px;
        }
        .auto-style9 {
            height: 24px;
            width: 255px;
        }
        .auto-style10 {
            width: 115px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table cellpadding="0" cellspacing="1" class="auto-style1">
           
            <tr>
                <td class="auto-style10">Código:</td>
                <td>
                    <asp:TextBox ID="txtCodigo" runat="server"></asp:TextBox>
                </td>

            </tr>
            
             <tr>
                <td class="auto-style10">Nome:</td>
                <td class="auto-style7">
                    <asp:TextBox ID="txtNome"  runat="server" Width="199px" Enabled="False"></asp:TextBox>
                </td>
               
            </tr>
            <tr>
                <td class="auto-style10" aria-checked="false">Idade:</td>
                <td class="auto-style7">
                    <asp:TextBox ID="txtIdade" runat="server" Enabled="False"></asp:TextBox>
                </td>
               
            </tr>
            <tr>
                <td class="auto-style10">Matrícula:</td>
                <td class="auto-style7">
                    <asp:TextBox ID="txtMatricula" runat="server" Enabled="False"></asp:TextBox>
                </td>

            </tr>
            <tr>
                <td class="auto-style10">Cargo:</td>
                <td class="auto-style7">
                    <asp:TextBox ID="txtCargo" runat="server" Width="193px" Enabled="False"></asp:TextBox>
                </td>
          
            </tr>
            <tr>
                <td class="auto-style10">Salario</td>
                <td class="auto-style7">
                    <asp:TextBox ID="txtSalario" runat="server" Enabled="False"></asp:TextBox>
                </td>
            
            </tr>
            <tr>
                <td class="auto-style4">Data de Nascimento:</td>
                <td class="auto-style8">
                    <asp:TextBox ID="txtDataNascimento" runat="server" Enabled="False"></asp:TextBox>
                </td>
          
            </tr>
            <tr>
                <td class="auto-style5">
                    <asp:Button ID="btnLimpar" runat="server" Text="Limpar" Enabled="False" />
                    <asp:Button ID="btnBuscar" runat="server" Text="Buscar" OnClick="btnBuscar_Click" />
                </td>
                <td class="auto-style9">
                    
                    <asp:Button ID="btnAlterar" runat="server" Text="Alterar" Enabled="False" />
                    <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" />
                    <asp:Button ID="btnSalvar" runat="server" Text="Salvar" Enabled="False" />
                </td>
               
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
