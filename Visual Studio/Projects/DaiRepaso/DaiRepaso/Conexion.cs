using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace daiRepaso
{
    class Conexion
    {
        SqlCommand cmd;
        SqlDataReader dr;

        public static SqlConnection agregarConexion()
        {
            SqlConnection cnn;
            try
            {

                cnn = new SqlConnection("Data Source=PC;Initial Catalog=cientificos;User ID=sa;Password=sqladmin");
                cnn.Open();
                MessageBox.Show("conectado");
            }
            catch (Exception ex)
            {
                cnn = null;
                MessageBox.Show("no se pudo conectar  " + ex);
            }
            return cnn;
        }
        public void llenarCombo(ComboBox cb)
        {
            try
            {
                SqlConnection con;
                con = Conexion.agregarConexion();
                cmd = new SqlCommand("select nomProyecto from proyecto", con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cb.Items.Add(dr["nomProyecto"].ToString());
                }
                cb.SelectedIndex = 0;
                dr.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo llenar el combo" + ex);
            }
        }
    }
}
