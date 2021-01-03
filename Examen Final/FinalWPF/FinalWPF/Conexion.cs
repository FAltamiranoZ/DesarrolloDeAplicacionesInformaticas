using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace FinalWPF
{
    class Conexion
    {

        public static SqlConnection agregarConexion()
        {
            SqlConnection con = new SqlConnection("Data Source = CC102-22; Initial Catalog = tutores; User ID = sa; Password = sqladmin");
            
            con.Open();
            return con;
        }

        public void llenarCombo1(ComboBox cb)
        {
            SqlConnection con = Conexion.agregarConexion();
            SqlCommand cmd = new SqlCommand("select NomTutor from tutor", con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cb.Items.Add(dr["NomTutor"].ToString());
            }
            dr.Close();
            con.Close();
        }

        public void llenarCombo2(ComboBox cb)
        {
            SqlConnection con = Conexion.agregarConexion();
            SqlCommand cmd = new SqlCommand("select NomMateria from materia", con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cb.Items.Add(dr["NomMateria"].ToString());
            }
            dr.Close();
            con.Close();
        }

    }
}
