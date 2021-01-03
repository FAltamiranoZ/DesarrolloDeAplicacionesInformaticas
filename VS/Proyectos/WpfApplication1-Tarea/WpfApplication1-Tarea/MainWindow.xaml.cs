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

namespace WpfApplication1_Tarea
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

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Libro a = new Libro(int.Parse(textBox3.Text), textBox.Text, textBox1.Text, textBox2.Text);
            int res = Libro.agregarLibro(a);
            if (res > 0)
            {
                MessageBox.Show("Libro dado de alta");
            }
            else
            {
                MessageBox.Show("No se pudo dar de alta");
            }
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Baja w = new Baja();
            w.Show();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Modificar w = new Modificar();
            w.Show();
        }
    }
}
