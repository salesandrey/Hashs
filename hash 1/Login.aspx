<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebApplication6.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        <h1>Login de Usuario</h1>
        <asp:TextBox ID="txtNome" runat="server"></asp:TextBox> <p> </p>
        <asp:TextBox ID="txtSenha" runat="server"></asp:TextBox> <p> </p>

        <asp:Button ID="btLogin" runat="server" OnClick="btCadastra_Click" Text="Login" />
        </div>
    </form>
</body>
</html>
