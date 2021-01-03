using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pagina1 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (DropDownList1.Items.Count==0)
        {
            DropDownList1.Items.Add("Azul");
            DropDownList1.Items.Add("Rojo");
            DropDownList1.Items.Add("Verde");
            DropDownList1.Items.Add("Amarillo");
            DropDownList1.Items.Add("Morado");
        }
        if (RadioButtonList1.Items.Count == 0)
        {
            RadioButtonList1.Items.Add("Vainilla");
            RadioButtonList1.Items.Add("Fresa");
            RadioButtonList1.Items.Add("Limón");
            RadioButtonList1.Items.Add("Chocolate");
        }
        if (CheckBoxList1.Items.Count == 0)
        {
            CheckBoxList1.Items.Add("Americano");
            CheckBoxList1.Items.Add("Capuccino");
            CheckBoxList1.Items.Add("Latte");
            CheckBoxList1.Items.Add("Moka");
        }
        Session["Hola"] = "inicio";
        Label6.Text = "Esta es la sesión: " + Session["Hola"].ToString();
        if (!Page.IsPostBack)
        {
            Label8.Text = "Esta es la primera vez";
        }
        else
        {
            Label8.Text = DateTime.Now.ToString();
        }
        }

    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        int seleccion = 0;
        seleccion = DropDownList1.SelectedIndex;
        Label2.Text = "El indice seleccionado es: " + seleccion.ToString();
        Session["hola"] = "Cambio del DropDownList";
        Label6.Text = Session["Hola"].ToString();
    }

    protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        Label3.Text = RadioButtonList1.SelectedIndex.ToString();
        Label4.Text = RadioButtonList1.SelectedValue.ToString();
        Session["hola"] = "Cambio del RadioButtonList";
        Label6.Text = Session["Hola"].ToString();
    }

    protected void CheckBoxList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        int i = 0;
        ListBox1.Items.Clear();
        ListBox2.Items.Clear();
        for (i = 0; i < CheckBoxList1.Items.Count; i++)
        {
            if (CheckBoxList1.Items[i].Selected == true)
            {
                ListBox1.Items.Add(i.ToString());
                ListBox2.Items.Add(CheckBoxList1.Items[i].Value.ToString());
            }
        }
        Session["hola"] = "Cambio del CheckBoxList";
        Label6.Text = Session["Hola"].ToString();
    }
}