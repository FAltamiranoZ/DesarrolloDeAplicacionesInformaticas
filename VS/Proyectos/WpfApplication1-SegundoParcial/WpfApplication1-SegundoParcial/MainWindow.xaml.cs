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

namespace WpfApplication1_SegundoParcial
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

        private void Window_Loaded_1(object sender, RoutedEventArgs e)
        {
            Conexion c = new Conexion();
            c.llenarComboCarrera(cbCarrera);
            c.llenarComboUniversidad(cbUni);
        }

        private void btRegistrar_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection con = Conexion.agregarConexion();
            
            Alta a = new Alta(int.Parse(tbClave.Text), tbNombre.Text, tbApellido.Text, tbSexo.Text, tbCorreo.Text);
            int res = Alta.agregarSalida(a);
            if (res > 0)
            {
                MessageBox.Show("Salida Exitosa");
                if (cbCarrera.Text=="otro"||cbCarrera.Text=="externo")
                {
                    MessageBox.Show("Tu código de entrada es: 567890, se te solicita un pago de $150.00");
                }
                else
                {
                    MessageBox.Show("Tu código para recoger tu playera es: 12345, y para entrar a la fiesta es: 56789");
                }
            }
            else
            {
                MessageBox.Show("Error fatalísimo");
            }
        }

        private void btReporte_Click(object sender, RoutedEventArgs e)
        {
            Conexion c = new Conexion();
            c.llenarComboAsistente(comboBox);
        }
    }
}
