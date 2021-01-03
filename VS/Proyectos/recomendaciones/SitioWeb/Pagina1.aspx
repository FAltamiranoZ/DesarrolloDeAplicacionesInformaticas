<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Pagina1.aspx.cs" Inherits="Pagina1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="Disfraz"></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
        </asp:DropDownList>
        <br />
        <asp:Label ID="lb1" runat="server"></asp:Label>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Cliente"></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="DropDownList2" runat="server" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged">
        </asp:DropDownList>
    
        <br />
        <asp:Label ID="lb2" runat="server"></asp:Label>
    
        <br />
        <asp:Button ID="Button1" runat="server" Text="Ver Recomendación" OnClick="Button1_Click" />
    
    </div>
    </form>
</body>
</html>
