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
    /// Lógica de interacción para Baja.xaml
    /// </summary>
    public partial class Baja : Window
    {
        public Baja()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            MainWindow w = new MainWindow();
            w.Show();
            this.Hide();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            int res = Alumno.eliminarAlumno(int.Parse(tbFolio.Text));
            if (res > 0)
            {
                MessageBox.Show("Alumno dado de baja");
            }
            else
            {
                MessageBox.Show("No se pudo dar de baja");
            }
        }
    }
}
