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

namespace Prueba1
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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Conexion w = new Conexion();
            w.llenarCombo(comboBox);
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection con = Conexion.agregarConexion();
            SqlCommand cmd = new SqlCommand("select max(IdProf) from Prof", con);
            Object o = cmd.ExecuteScalar();
            int id = int.Parse(o.ToString()) + 1;
            Elemento a = new Elemento(id, textBox.Text, comboBox.SelectedItem.ToString());
            a.agregarElemento(a);
            Ventana2 w = new Ventana2();
            this.Hide();
            w.Show();
        }
    }
}
