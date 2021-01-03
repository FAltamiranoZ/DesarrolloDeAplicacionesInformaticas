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

namespace WpfApplication1_convertidor
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private TextBox objTextBox = null;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            txtCentigrados.Focus();
        }

        private void btCalcular_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double grados;
                if (objTextBox == txtCentigrados)
                {
                    MessageBox.Show("Estas en centígrados");
                    grados = Convert.ToDouble(txtCentigrados.Text) * 9.0 / 5.0 + 32.0;
                    txtFarenheit.Text = string.Format("{0:F2}", grados);
                }
                if (objTextBox == txtFarenheit)
                {
                    MessageBox.Show("Estas en Farenheit");
                    grados = (Convert.ToDouble(txtFarenheit.Text) - 32.0) * 5.0 / 9.0;
                    txtCentigrados.Text = string.Format("{0:F2}", grados);
                }
            }
            catch (FormatException)
            {
                txtCentigrados.Text = "0.00";
                txtFarenheit.Text = "0.00";
            }
        }

        private void txtCentigrados_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            objTextBox = sender as TextBox;
        }

        private void txtFarenheit_PreviewTextInput_1(object sender, TextCompositionEventArgs e)
        {
            objTextBox = sender as TextBox;
        }
    }
}
