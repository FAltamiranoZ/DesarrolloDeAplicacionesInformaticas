using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pagina3 : System.Web.UI.Page
{

    String stringCon = "Driver={SQL Server Native Client 11.0}; Server=CC102-09;Uid=sa;Pwd=sqladmin;Database=TiendaDisfraces";
    protected OdbcConnection conectarBD()
    {
        OdbcConnection con = new OdbcConnection(stringCon);
        con.Open();
        return con;
    }

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        OdbcConnection con = conectarBD();
        OdbcCommand cmd = new OdbcCommand("select contenido from comentarios where recomendacion='si'", con);
        OdbcDataReader dr = cmd.ExecuteReader();
        GridView1.DataSource = dr;
        GridView1.DataBind();
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        OdbcConnection con = conectarBD();
        OdbcCommand cmd = new OdbcCommand("select contenido from comentarios where recomendacion='no'", con);
        OdbcDataReader dr = cmd.ExecuteReader();
        GridView1.DataSource = dr;
        GridView1.DataBind();
    }
}