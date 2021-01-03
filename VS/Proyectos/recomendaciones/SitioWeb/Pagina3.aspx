<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Pagina3.aspx.cs" Inherits="Pagina3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Button ID="Button1" runat="server" Text="Si" OnClick="Button1_Click" />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" Text="No" OnClick="Button2_Click" />
    
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
    
    </div>
    </form>
</body>
</html>
