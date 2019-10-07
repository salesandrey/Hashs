<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TelaCadastro.aspx.cs" Inherits="Cadastro.TelaCadastro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <h1>Cadastro de Usuario</h1>
        <asp:TextBox ID="txtNome" runat="server"></asp:TextBox> <p> </p>
        <asp:TextBox ID="txtSenha" runat="server"></asp:TextBox> <p> </p>

        <asp:Button ID="btCadastra" runat="server" OnClick="btCadastra_Click" Text="Cadastrar" />

    </form>
</body>
</html>
