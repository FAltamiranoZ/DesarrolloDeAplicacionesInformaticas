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

namespace WpfApplication6_Sistema
{
    /// <summary>
    /// Lógica de interacción para Baja.xaml
    /// </summary>
    public partial class Baja : Window
    {
        public Baja()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection con = Conexion.agregarConexion();
            SqlCommand cmm = new SqlCommand(String.Format("select max(idSalida) from salida"), con);
            Object o = cmm.ExecuteScalar();
            int idSalida = int.Parse(o.ToString()) + 1;
            Salida a = new Salida(idSalida, int.Parse(comboBox.Text), textBox.Text, FechaReg.Text, FechaSal.Text);
            int res = Salida.agregarSalida(a);
            if (res > 0)
            {
                MessageBox.Show("Salida Exitosa");
            }
            else
            {
                MessageBox.Show("Error fatalísimo");
            }
            SqlCommand cmm2 = new SqlCommand(String.Format("select max(idSalida) from salida"), con);
            Object p = cmm.ExecuteScalar();
            int idSalidaArt = int.Parse(o.ToString()) + 1;
            SalidaArt b = new SalidaArt(idSalidaArt, idSalida, int.Parse(textBox2.Text), int.Parse(textBox1.Text));
            int res2 = SalidaArt.agregarSalidaArt(b);
            if (res2 > 0)
            {
                MessageBox.Show("Salida Exitosa");
            }
            else
            {
                MessageBox.Show("Error fatalísimo");
            }
        }

        private void Window_Loaded_1(object sender, RoutedEventArgs e)
        {
            Conexion c = new Conexion();
            c.llenarCombo(comboBox);
            comboBox.SelectedIndex = 0;
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Almacen w = new Almacen();
            w.Show();
            this.Close();

        }
    }
}
