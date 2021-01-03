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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace recomendaciones
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btClienteNuevo_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection con = Conexion.agregarConexion();
            SqlCommand cmd = new SqlCommand(String.Format("SELECT passwd FROM cliente WHERE correo = '{0}'", txCorreo.Text), con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read() && (dr.GetString(0).Equals(txPassword.Text)))
            {
                MessageBox.Show("Este cliente si esta registrado");
            }
            else
            {
                Alta a = new Alta();
                a.Show();
                this.Hide();
            }

        }

        private void btRecomendacion_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection con = Conexion.agregarConexion();
            SqlCommand cmd = new SqlCommand(String.Format("SELECT passwd FROM cliente WHERE correo = '{0}'", txCorreo.Text), con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read() && (dr.GetString(0).Equals(txPassword.Text)))
            {
                AltaComentario a = new AltaComentario();
                a.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Este cliente no esta registrado");
            }
        }

        private void btVerRecomendacion_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection con = Conexion.agregarConexion();
            SqlCommand cmd = new SqlCommand(String.Format("SELECT passwd FROM cliente WHERE correo = '{0}'", txCorreo.Text), con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read() && (dr.GetString(0).Equals(txPassword.Text)))
            {
                Disfraces a = new Disfraces();
                a.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Este usuario no esta registrado");
            }
        }
    }
}
