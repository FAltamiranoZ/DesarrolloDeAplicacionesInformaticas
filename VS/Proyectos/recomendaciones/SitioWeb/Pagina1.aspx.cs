using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pagina1 : System.Web.UI.Page
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
        OdbcConnection con = conectarBD();
        OdbcCommand cmd = new OdbcCommand("select nombre from disfraces", con);
        OdbcDataReader dr = cmd.ExecuteReader();
        DropDownList1.Items.Clear();
        while (dr.Read())
        {
            DropDownList1.Items.Add(dr.GetString(0));
        }
        dr.Close();

        OdbcCommand cmd2 = new OdbcCommand("select nombre from cliente", con);
        OdbcDataReader dr2 = cmd2.ExecuteReader();
        DropDownList2.Items.Clear();
        while (dr2.Read())
        {
            DropDownList2.Items.Add(dr2.GetString(0));
        }
        dr2.Close();

        con.Close();

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        OdbcConnection con = conectarBD();
        OdbcCommand cmd = new OdbcCommand("select contenido from comentarios, disfraces, cliente where disfraces.nombre = '" + DropDownList1.SelectedItem.ToString() + "' and cliente.nombre = '" + DropDownList2.SelectedItem.ToString() + "'", con);
        OdbcDataReader dr = cmd.ExecuteReader();
        if (dr.HasRows)
        {
            dr.Read();
            Session["contenido"] = dr.GetString(0).ToString();
        }
        Response.Redirect("Pagina2.aspx");
    }

    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        
    }

    protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
    {
        
    }
}