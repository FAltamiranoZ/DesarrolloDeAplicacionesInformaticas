using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class inicio : System.Web.UI.Page
{
    String stringCon = "Driver={SQL Server Native Client 11.0};Server=PC;Uid=sa;Pwd=sqladmin;Database=datosIngenieria";

    protected OdbcConnection conectarBD()
    {
        OdbcConnection con = new OdbcConnection(stringCon);
        con.Open();
        Label2.Text = "Conexión exitosa";
        return con;
    }

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        OdbcConnection miConexion = conectarBD();
        if (miConexion != null)
        {
            String query = "select nombre from carrera where nombre ='" + TextBox1.Text + "'";
            OdbcCommand cmm = new OdbcCommand(query, miConexion);
            OdbcDataReader dr = cmm.ExecuteReader();
            if (dr.HasRows)
            {
                dr.Read();
                Session["nombre"] = dr.GetInt32(0).ToString();
                Response.Redirect("reporte.aspx");
            }
            dr.Close();
        }
    }
}