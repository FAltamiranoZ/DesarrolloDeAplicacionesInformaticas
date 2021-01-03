using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class reporte : System.Web.UI.Page
{
    String stringCon = "Driver={SQL Server Native Client 11.0};Server=PC;Uid=sa;Pwd=sqladmin;Database=datosIngenieria";

    protected OdbcConnection conectarBD()
    {
        try
        {
            OdbcConnection con = new OdbcConnection(stringCon);
            con.Open();
            Label2.Text = "Conexión exitosa";
            return con;
        }
        catch (Exception ex)
        {
            Label2.Text = "No se pudo conectar " + ex.StackTrace.ToString();
            return null;
        }
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            OdbcConnection miConexion = conectarBD();
            if (miConexion != null)
            {
                OdbcCommand cmm = new OdbcCommand("select asistente.nombre from asistente, carrera where carrera.nombre='" + Session["nombre"].ToString() +"' and asistente.claveU=carrera.claveU", miConexion);
                OdbcDataReader dr = cmm.ExecuteReader();
                GridView1.DataSource = dr;
                GridView1.DataBind();
                dr.Close();
            }
        }
    }
}