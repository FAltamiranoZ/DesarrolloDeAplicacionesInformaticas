<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Pagina2.aspx.cs" Inherits="Pagina2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="Label1" runat="server" Text="Los datos del usuario son:"></asp:Label>
        <br />
        <asp:Label ID="lbNombre" runat="server" Text="Nombre"></asp:Label>
        &nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txNombre" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lbEdad" runat="server" Text="Edad"></asp:Label>
        &nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txEdad" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lbSexo" runat="server" Text="Sexo"></asp:Label>
        &nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txSexo" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="Button1" runat="server" Text="Ir a la página 3" OnClick="Button1_Click" />
        <br />
        <asp:Label ID="lbSession" runat="server" Text="Label"></asp:Label>
    </form>
</body>
</html>
