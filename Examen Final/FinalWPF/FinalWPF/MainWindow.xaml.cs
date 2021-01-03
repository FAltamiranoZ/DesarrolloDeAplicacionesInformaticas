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

namespace FinalWPF
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
            c.llenarCombo1(comboBox);
            c.llenarCombo2(comboBox1);
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection con = Conexion.agregarConexion();
            SqlCommand cmd1 = new SqlCommand(String.Format("select idTutor from tutor where nomtutor ='{0}'", comboBox.Text), con);
            Object o1 = cmd1.ExecuteScalar();
            int idTutor = int.Parse(o1.ToString());
            SqlCommand cmd2 = new SqlCommand(String.Format("select idMateria from materia where NomMateria ='{0}'", comboBox1.Text), con);
            Object o2 = cmd2.ExecuteScalar();
            int idMateria = int.Parse(o2.ToString());
            SqlCommand cmd3 = new SqlCommand(String.Format("insert into clases(idTutor, idMateria) values ('{0}','{1}')", idTutor, idMateria), con);
            cmd3.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Alta exitosa");
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Window1 w = new Window1();
            w.Show();
        }
    }
}
