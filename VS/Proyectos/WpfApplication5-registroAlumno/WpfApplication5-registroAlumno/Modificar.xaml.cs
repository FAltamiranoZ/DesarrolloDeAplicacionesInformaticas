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
    /// Lógica de interacción para Modificar.xaml
    /// </summary>
    public partial class Modificar : Window
    {
        public Modificar()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            int res = Alumno.modificarAlumno(int.Parse(tbFolio.Text), textBox1.Text);
            if (res > 0)
            {
                MessageBox.Show("Título modificado");
            }
            else
            {
                MessageBox.Show("No se pudo modificar");
            }
            //Crear metodo modificar
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            MainWindow w = new MainWindow();
            w.Show();
            this.Hide();
        }
    }
}
