using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfApplication1_Tarea
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

                cnn = new SqlConnection("Data Source=CC102-18;Initial Catalog=Tarea1VS;User ID=sa;Password=sqladmin");
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
    }
}
