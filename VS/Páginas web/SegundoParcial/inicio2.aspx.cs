using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class inicio2 : System.Web.UI.Page
{

    String stringCon = "Driver={SQL Server Native Client 11.0};Server=PC;Uid=sa;Pwd=sqladmin;Database=datosIngenieria";

    protected OdbcConnection conectarBD()
    {
        OdbcConnection con = new OdbcConnection(stringCon);
        con.Open();
        return con;
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)//Mientras que no sea el primero
        {
            OdbcConnection miConexion = conectarBD();
            if (miConexion != null)
            {
                OdbcCommand cmm = new OdbcCommand("select nombre from universidad", miConexion);
                OdbcDataReader dr = cmm.ExecuteReader();
                DropDownList1.Items.Clear();
                while (dr.Read())
                {
                    DropDownList1.Items.Add(dr.GetString(0));
                }
                dr.Close();
                miConexion.Close();
            }
        }
    }


    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        OdbcConnection miConexion = conectarBD();
        if (miConexion != null)
        {
            OdbcCommand cmm = new OdbcCommand("select asistente.nombre from asistente, universidad_asistente, universidad where asistente.claveU=universidad_asistente.claveU and universidad_asistente.claveUni=universidad.claveUni and universidad.nombre='"+DropDownList1.SelectedValue+"'", miConexion);
            OdbcDataReader dr = cmm.ExecuteReader();
            dr.Read();
            Label3.Text = dr.GetString(0);
            dr.Close();
            miConexion.Close();
        }
    }
}