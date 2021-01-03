using System;
using System.Data.Odbc;
using System.Data.SqlClient;

public partial class Contacto : System.Web.UI.Page
{
    String stringQuery = "";
    protected static OdbcConnection conectarBD()
    {
        OdbcConnection con = new OdbcConnection("stringQuery");
        con.Open();
        return con;
    }

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        if (tbNombre.Text=="" || tbCorreo.Text=="" || tbComentarios.Text=="")
        {
            res.Text = "Por favor rellena todos los campos";
        }
        else
        {
            OdbcConnection con = conectarBD();
            OdbcCommand cmd = new OdbcCommand("select nombre, correo from contacto where nombre='"+tbNombre.Text+"' and correo = '"+tbCorreo.Text+"'", con);
            Object o = cmd.ExecuteScalar();
            int res2 = int.Parse(o.ToString());
            if (res2!=0)
            {
                OdbcCommand cmd2 = new OdbcCommand(String.Format("insert into contacto (nombre, correo, comentario) values '{0}','{1}','{2}')", tbNombre.Text, tbCorreo.Text, tbComentarios.Text), con);
                res.Text = "Éxito, te contactaremos lo antes posible "+tbNombre.Text;
            }
        }
    }
}