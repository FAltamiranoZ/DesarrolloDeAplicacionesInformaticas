using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace recomendaciones
{
    class Conexion
    {
        public static SqlConnection agregarConexion()
        {
            SqlConnection con = new SqlConnection("Data Source=CC102-09;Initial Catalog=TiendaDisfraces;User ID=sa;Password=sqladmin");
            con.Open();
            return con;
        }
        
        public static void llenarCBDisfraces(ComboBox cb)
        {
            SqlConnection con = agregarConexion();
            SqlCommand cmd = new SqlCommand("select nombre from disfraces",con);
            SqlDataReader dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                cb.Items.Add(dr["nombre"].ToString());
            }
        }

        public static void llenarCBId(ComboBox cb)
        {
            SqlConnection con = agregarConexion();
            SqlCommand cmd = new SqlCommand("select idDisfraz from disfraces", con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cb.Items.Add(dr["nombre"].ToString());
            }
        }

    }
}
