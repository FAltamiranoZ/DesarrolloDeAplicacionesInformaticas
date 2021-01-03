using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pagina1 : System.Web.UI.Page
{

    String stringCon = "Driver={SQL Server Native Client 11.0};Server=CC102-18;Uid=sa;Pwd=sqladmin;Database=Juegos";

    protected OdbcConnection conectarBD()
    {
        OdbcConnection con = new OdbcConnection(stringCon);
        con.Open();
        lbContador.Text = "Conexión exitosa";
        return con;
    }

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btPagina2_Click(object sender, EventArgs e)
    {
        OdbcConnection miConexion = conectarBD();
        if (miConexion != null)
        {
            String query = "select claveU from usuario where email ='"+txUsuario.Text+"' and password = '"+txContraseña.Text+"'";
            OdbcCommand cmm = new OdbcCommand(query, miConexion);
            OdbcDataReader dr = cmm.ExecuteReader();
            if (dr.HasRows)
            {
                dr.Read();
                Session["claveU"] = dr.GetInt32(0).ToString();
                lbContador.Text = "Contraseña correcta";
                Response.Redirect("Pagina2.aspx");
            }
            else
            {
                lbContador.Text = "Contraseña incorrecta";
            }
            dr.Close();
        }
    }
}