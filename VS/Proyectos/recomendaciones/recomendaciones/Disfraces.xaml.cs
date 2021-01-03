using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace recomendaciones
{
    /// <summary>
    /// Lógica de interacción para Disfraces.xaml
    /// </summary>
    public partial class Disfraces : Window
    {
        public Disfraces()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Conexion.llenarCBDisfraces(comboBox);
        }

        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            SqlConnection con = Conexion.agregarConexion();
            SqlCommand cmd = new SqlCommand("select comentarios.contenido from comentarios, disfraces where comentarios.idDisfraz=disfraces.idDisfraz and disfraces.nombre = '"+comboBox.SelectedItem.ToString()+"'", con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["contenido"].ToString());
            }
        }
    }
}
