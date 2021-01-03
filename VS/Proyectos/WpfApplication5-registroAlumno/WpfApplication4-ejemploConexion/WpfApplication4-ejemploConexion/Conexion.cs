using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace WpfApplication4_ejemploConexion
{
    class Conexion
    {
        SqlConnection cnn; //Conecta la base
        SqlCommand cmd; //Establece la consulta
        SqlDataReader dr; //Recupera datos
        public Conexion()
        {
            try
            {
                cnn = new SqlConnection("Data Source=CC102-18;Initial Catalog=registro;User ID=sa;Password=sqladmin");
                cnn.Open();
                MessageBox.Show("Se conecto");
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se conecto" + ex);
            }
        }

        public void llenarComboProgramas(ComboBox cb)
        {
            try
            {
                cmd = new SqlCommand("select nombre from programa", cnn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cb.Items.Add(dr["nombre"].ToString()); //Es el nombre de la columna lo que va en ""
                }
                dr.Close();
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se conecto" + ex);
            }
        }

    }
}