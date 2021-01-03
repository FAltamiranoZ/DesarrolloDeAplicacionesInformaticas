using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace WpfApplication6_Sistema
{
    class Conexion
    {
        SqlCommand cmd;
        SqlDataReader dr;

        public static SqlConnection agregarConexion()
        {
            SqlConnection cnn;
            try
            {

                cnn = new SqlConnection("Data Source=PC;Initial Catalog=sistema;User ID=sa;Password=sqladmin");
                cnn.Open();
                MessageBox.Show("conectado");
            }
            catch (Exception ex)
            {
                cnn = null;
                MessageBox.Show("no se pudo conectar  " + ex);
            }
            return cnn;
        }

        public void llenarCombo(ComboBox cb)
        {
            try
            {
                SqlConnection con;
                con = Conexion.agregarConexion();
                cmd = new SqlCommand("select idUser from usuario", con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cb.Items.Add(dr["idUser"].ToString());
                }
                cb.SelectedIndex = 0;
                dr.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("no se pudo llenar el combo" + ex);
            }
        }
        public void llenarComboA(ComboBox cb)
        {
            try
            {
                SqlConnection con = Conexion.agregarConexion();
                cmd = new SqlCommand("select idArticulo from articulo", con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cb.Items.Add(dr["idArticulo"].ToString());
                }
                cb.SelectedIndex = 0;
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo llenar el combo" + ex);
            }
        }

        public void llenarComboI(ComboBox cb)
        {
            try
            {
                SqlConnection con = Conexion.agregarConexion();
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter("select idUser from Usuario", con);
                da.Fill(ds, "Usuario");
                cb.ItemsSource = ds.Tables["Usuario"].DefaultView;
                cb.DisplayMemberPath = ds.Tables["usuario"].Columns["idUser"].ToString();
                cb.SelectedIndex = 0;

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo llenar el combo" + ex);
            }
        }
    }

}
