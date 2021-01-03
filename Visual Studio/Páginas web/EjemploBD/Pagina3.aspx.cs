﻿using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pagina3 : System.Web.UI.Page
{

    String stringCon = "Driver={SQL Server Native Client 11.0};Server=CC102-18;Uid=sa;Pwd=sqladmin;Database=Juegos";

    protected OdbcConnection conectarBD()
    {
        try
        {
            OdbcConnection con = new OdbcConnection(stringCon);
            con.Open();
            lbError.Text = "Conexión exitosa";
            return con;
        }
        catch(Exception ex)
        {
            lbError.Text = "No se pudo conectar " + ex.StackTrace.ToString();
            return null;
        }
        
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)//Mientras que no sea el primero
        {
            OdbcConnection miConexion = conectarBD();
            if (miConexion != null)
            {
                OdbcCommand cmm = new OdbcCommand("select juegos.nombre from juegos, escriben.claveU="+Session["claveU"].ToString()+"and where juegos.claveJ=escriben.claveJ", miConexion);
                OdbcDataReader dr = cmm.ExecuteReader();
                ddJuegos.Items.Clear();
                while (dr.Read())
                {
                    ddJuegos.Items.Add(dr.GetString(0));//el 0 simboliza que columna leo, el read baja solo
                }
                dr.Close();
                miConexion.Close();
            }
        }
    }

    protected void ddJuegos_SelectedIndexChanged(object sender, EventArgs e)
    {
        OdbcConnection miConexion = conectarBD();
        if (miConexion!=null)
        {
            int var1 = ddJuegos.SelectedIndex;
            String var2 = ddJuegos.SelectedValue;
            string query1 = "select claveJ from juegos where nombre = '" + var2 + "'";
            OdbcCommand sql1 = new OdbcCommand(query1, miConexion);
            OdbcDataReader lector1 = sql1.ExecuteReader();
            lector1.Read();
            int var3 = lector1.GetInt16(0);
            string query2 = "select critica.contenido from critica where critica.claveC=(select  claveC from escriben where escriben.claveU=" + Session["CU"].ToString() + " and escriben.claveJ=" + var3 + ")";
            OdbcCommand sql = new OdbcCommand(query2, miConexion);
            OdbcDataReader lector = sql.ExecuteReader();
            lector.Read();
            lbCritica.Text = lector.GetString(0);
            lector.Close();
            lector1.Close();
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("Pagina4.aspx");
    }
}