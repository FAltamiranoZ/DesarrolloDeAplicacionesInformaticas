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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApplication6_Sistema
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Usuario a = new Usuario(int.Parse(txUsuario.Text), txPassword.Text);
            int res = Usuario.busqueda(a);
            if (res > 0)
            {
                MessageBox.Show("Inicio de sesión satisfactorio ");
                this.Hide();
                Almacen w = new Almacen();
                w.Show();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña estan incorrectos ");
            }
        }
    }
}
