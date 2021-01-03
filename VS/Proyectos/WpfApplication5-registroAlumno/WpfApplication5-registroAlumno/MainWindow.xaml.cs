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

namespace WpfApplication5_registroAlumno
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
            Conexion c = new Conexion();
            c.llenarCombo(cbProgramas);
        }

        private void btAgregar_Click(object sender, RoutedEventArgs e)
        {
            Alumno a = new Alumno(int.Parse(tbFolio.Text), tbNombre.Text, tbSexo.Text, tbCorreo.Text, int.Parse(tbSemestre.Text), cbProgramas.SelectedIndex+1);
            int res = Alumno.agregarAlumno(a);
            if (res > 0)
            {
                MessageBox.Show("Alumno dado de alta");
            }
            else
            {
                MessageBox.Show("No se pudo dar de alta");
            }
        }

        private void btEliminar_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Baja w = new Baja();
            w.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Buscar w = new Buscar();
            w.Show();
        }

        private void btSalir_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btModificar_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Modificar w = new Modificar();
            w.Show();
        }
    }
}
