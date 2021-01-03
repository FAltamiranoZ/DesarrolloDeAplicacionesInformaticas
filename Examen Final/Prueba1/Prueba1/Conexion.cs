using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Prueba1
{
    class Conexion
    {
        public static SqlConnection agregarConexion()
        {
            SqlConnection con = new SqlConnection("Data Source = PC; Initial Catalog = Prueba1; User ID = sa; Password = sqladmin");
            con.Open();
            return con;
        }
        public void llenarCombo(ComboBox cb)
        {
            SqlConnection con = Conexion.agregarConexion();
            SqlCommand cmd = new SqlCommand("select distinct Categoría from Prof", con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cb.Items.Add(dr["Categoría"].ToString());
            }
            dr.Close();
        }
    }
}
