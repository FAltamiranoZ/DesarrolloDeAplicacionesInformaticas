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
using System.Windows.Shapes;

namespace FinalWPF
{
    /// <summary>
    /// Lógica de interacción para Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Conexion c = new Conexion();
            c.llenarCombo1(cbTutor);
        }

        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            SqlConnection con = Conexion.agregarConexion();
            SqlCommand cmd = new SqlCommand(String.Format("select nomMateria from materia, clases, tutor where materia.idMateria = clases.idMateria and clases.idTutor = tutor.IdTutor and NomTutor = '{0}'", cbTutor.SelectedItem.ToString()), con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cbMateria.Items.Add(dr["NomMateria"].ToString());
            }
            dr.Close();
            con.Close();
        }

        private void cbMateria_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            SqlConnection con = Conexion.agregarConexion();
            SqlCommand cmd = new SqlCommand(String.Format("select nomNivel from nivel, materia where nivel.idNivel = materia.idNivel and NomMateria = '{0}'", cbMateria.SelectedItem.ToString()), con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cbNivel.Items.Add(dr["NomNivel"].ToString());
            }
            dr.Close();
            con.Close();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection con = Conexion.agregarConexion();
            SqlCommand cmd = new SqlCommand(String.Format("select costoHr from nivel where NomNivel = '{0}'", cbNivel.SelectedItem.ToString()), con);
            Object o = cmd.ExecuteScalar();
            int costo = int.Parse(o.ToString());
            int horas = int.Parse(textBox.Text);
            double total = costo * horas;
            MessageBox.Show("El costo total es de: "+total);
        }
    }
}
