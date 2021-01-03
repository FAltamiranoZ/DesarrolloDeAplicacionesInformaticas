using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pagina2 : System.Web.UI.Page
{

    String stringCon = "Driver={SQL Server Native Client 11.0};Server=CC102-18;Uid=sa;Pwd=sqladmin;Database=Juegos";

    protected OdbcConnection conectarBD()
    {
        OdbcConnection con = new OdbcConnection(stringCon);
        con.Open();
        lbSession.Text = "Conexión exitosa";
        return con;
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        OdbcConnection con = new OdbcConnection(stringCon);
        if (con != null)
        {
            String query = "select nombre, edad, sexo from usuario where claveU=" + Session["claveU"].ToString();
            OdbcCommand cmm = new OdbcCommand(query, con);
            OdbcDataReader dr = cmm.ExecuteReader();
            dr.Read();
            txNombre.Text = dr.GetString(0);
            txEdad.Text = dr.GetString(1);
            txSexo.Text = dr.GetString(2);
        }
        lbSession.Text = Session["claveU"].ToString();
    }


    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("Pagina3.aspx");
    }
}