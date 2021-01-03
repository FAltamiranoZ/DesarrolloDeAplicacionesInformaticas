using System;
using System.Collections.Generic;
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
    /// Lógica de interacción para Almacen.xaml
    /// </summary>
    public partial class Almacen : Window
    {
        public Almacen()
        {
            InitializeComponent();
        }


        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Conexion con = new Conexion();
            con.llenarComboA(cbArticulo);
            con.llenarComboI(cbIdUser);
        }

    private void btnAbrirV_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Baja w = new Baja();
            w.Show();
        }

        private void btnAgregar_Click(object sender, RoutedEventArgs e)
        {
            Articulo a = new Articulo(txtNombreProv.Text, int.Parse(cbArticulo.Text), int.Parse(txtFolioFac.Text), int.Parse(cbIdUser.Text), dtEntrada.Text, dtEntrada.Text, txtFechaFactura.Text, int.Parse(txtCant.Text), decimal.Parse(txtPrecio.Text));
            Articulo.agregar(a);
        }
    }
}
