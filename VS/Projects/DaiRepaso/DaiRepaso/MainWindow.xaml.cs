using daiRepaso;
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

namespace DaiRepaso
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
            c.llenarCombo(comboBox);
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection con = Conexion.agregarConexion();
            SqlCommand cmm = new SqlCommand(String.Format("select max(idCientifico) from cientifico"), con);
            SqlCommand cmm2 = new SqlCommand(String.Format("select idProyecto from proyecto where nomProyecto = '"+comboBox.SelectedItem.ToString()+"'"), con);
            SqlDataReader dr = cmm2.ExecuteReader();
            dr.Read();
            int idProyecto = int.Parse(dr["idProyecto"].ToString());
            dr.Close();
            Object o = cmm.ExecuteScalar();
            int idCientifico = int.Parse(o.ToString()) + 1;
            Cientifico a = new Cientifico(idCientifico, textBox.Text, textBox1.Text, idProyecto);
            int res = Cientifico.agregarCientifico(a);
            if (res > 0)
            {
                MessageBox.Show("Cientifico dado de alta");
            }
            else
            {
                MessageBox.Show("No se pudo dar de alta");
            }
        }
    }
}
