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
    /// Lógica de interacción para AltaComentario.xaml
    /// </summary>
    public partial class AltaComentario : Window
    {
        public AltaComentario()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow a = new MainWindow();
            a.Show();
            this.Hide();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection con = Conexion.agregarConexion();
            SqlCommand cmm = new SqlCommand(String.Format("select max(idComentario) from comentarios"), con);
            Object o = cmm.ExecuteScalar();
            int idComentario = int.Parse(o.ToString()) + 1;
            Comentario a = new Comentario(idComentario, textBox.Text, textBox1.Text, textBox2.Text, int.Parse(comboBox.SelectedItem.ToString()));
            int res = Comentario.agregarComentario(a);
            if (res > 0)
                MessageBox.Show("Comentario registrado");
            else
                MessageBox.Show("Error: No se pudo registrar el comentario");
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Conexion.llenarCBId(comboBox);
        }
    }
}
