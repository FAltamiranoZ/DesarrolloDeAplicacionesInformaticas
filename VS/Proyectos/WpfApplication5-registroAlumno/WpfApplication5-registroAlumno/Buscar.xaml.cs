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

namespace WpfApplication5_registroAlumno
{
    /// <summary>
    /// Lógica de interacción para Buscar.xaml
    /// </summary>
    public partial class Buscar : Window
    {
        public Buscar()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            dgDatos.ItemsSource = Alumno.buscarAlumno(tbNombre.Text);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow w = new MainWindow();
            w.Show();
            this.Hide();
        }
    }
}
