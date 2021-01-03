<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Contacto.aspx.cs" Inherits="Contacto" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style>
        h1, h2 {
            color: black;
            font-family: 'Lucida Bright';
        }
    </style>
</head>
<body style="background-image: url('fondocontacto.jpg');">
    <form id="form1" runat="server">
    <div id="header">
        <p style=" text-align: center"><a href="Inicio.aspx">Menú</a></p>
    </div>
    <div>
        <h1>Contáctanos:</h1>
        <h3>Puedes encontranos en persona en:</h3>
        <p>01080 de, Morelos 36, Progreso, Ciudad de México, CDMX</p>
        <h3>Contactarnos por teléfono en: </h3>
        <p>01 55 4799 0078</p>
        <h3>Mandarnos un correo </h3>
        <p><a href=mailto:jaltamirz@itam.mx> A esta dirección</a></p>
        <h3>O puedes dejarnos tus datos y nosotros nos encargaremos de contactarte</h3>
        <asp:Label ID="lbNombre" runat="server" Text="Nombre"></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="tbNombre" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lbCorreo" runat="server" Text="Correo"></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="tbCorreo" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lbComentarios" runat="server" Text="Comentarios"></asp:Label>&nbsp;&nbsp;&nbsp; <asp:TextBox ID="tbComentarios" runat="server" Height="69px" Width="458px"></asp:TextBox>
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" Text="Enviar" OnClick="Button1_Click" />
        <br />
        <br />
        <asp:Label ID="res" runat="server" Font-Bold="True" Font-Size="Large" ForeColor="#CC0000"></asp:Label>
        <br />
        <h2>¡Esperamos tu visita!</h2>

    </div>
    </form>
</body>
</html>
