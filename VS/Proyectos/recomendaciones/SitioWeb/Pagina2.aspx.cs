using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pagina2 : System.Web.UI.Page
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
        if (!IsPostBack)
        {
            GridView1.DataSource = Session["contenido"];
            GridView1.DataBind();

        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        OdbcConnection con = conectarBD();
        OdbcCommand cmd = new OdbcCommand("UPDATE comentarios set contenido = '"+TextBox1.Text+"' where contenido = '"+Session["contenido"].ToString()+"'", con);
        Label1.Text = Session["contenido"].ToString();
    }
}