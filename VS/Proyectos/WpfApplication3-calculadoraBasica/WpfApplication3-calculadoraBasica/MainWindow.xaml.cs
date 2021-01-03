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

namespace WpfApplication3_calculadoraBasica
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

        private void btCalcular_Click(object sender, RoutedEventArgs e)
        {
            if ((bool)rbSuma.IsChecked)
            {
                sumaValores();
            }
            else
            {
                restaValores();
            }
        }

        private void sumaValores()
        {
            double n1, n2, res;
            n1 = double.Parse(tbNum1.Text);//Convierte String a Double
            n2 = double.Parse(tbNum2.Text);
            res = n1 + n2;
            tbRes.Text = res.ToString();
        }

        private void restaValores()
        {
            double n1, n2, res;
            n1 = double.Parse(tbNum1.Text);
            n2 = double.Parse(tbNum2.Text);
            res = n1 - n2;
            tbRes.Text = res.ToString();
        }

    }
}
