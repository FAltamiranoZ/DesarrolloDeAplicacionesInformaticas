using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace WpfApplication1_SegundoParcial
{
    class Conexion
    {
        SqlCommand cmd;
        SqlDataReader dr;

        public static SqlConnection agregarConexion()
        {
            SqlConnection con;
            try
            {

                con = new SqlConnection("Data Source=PC;Initial Catalog=datosIngenieria;User ID=sa;Password=sqladmin");
                con.Open();
                MessageBox.Show("conectado");
            }
            catch (Exception ex)
            {
                con = null;
                MessageBox.Show("no se pudo conectar  " + ex);
            }
            return con;
        }

        public void llenarComboUniversidad(ComboBox cb)
        {
            try
            {
                SqlConnection con;
                con = Conexion.agregarConexion();
                cmd = new SqlCommand("select nombre from universidad", con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cb.Items.Add(dr["nombre"].ToString());
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("no se pudo llenar el combo" + ex);
            }
        }
        public void llenarComboCarrera(ComboBox cb)
        {
            try
            {
                SqlConnection con = Conexion.agregarConexion();
                cmd = new SqlCommand("select nombre from carrera", con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cb.Items.Add(dr["nombre"].ToString());
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo llenar el combo" + ex);
            }
        }

        public void llenarComboAsistente(ComboBox cb)
        {
            try
            {
                SqlConnection con = Conexion.agregarConexion();
                cmd = new SqlCommand("select nombre from asistente", con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cb.Items.Add(dr["nombre"].ToString());
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo llenar el combo" + ex);
            }
        }
    }
}
