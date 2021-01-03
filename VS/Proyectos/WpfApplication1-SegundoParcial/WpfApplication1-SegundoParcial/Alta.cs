using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1_SegundoParcial
{
    class Alta
    {
        public int claveU { get; set; }

        public String nombre { get; set; }

        public String apellido { get; set; }

        public String sexo { get; set; }

        public String correo { get; set; }

        public Alta()
        {

        }
        public Alta(int claveUnica, String nombre, String apellido, String sexo, String correo)
        {
            claveU = claveUnica;
            this.nombre = nombre;
            this.apellido = apellido;
            this.sexo = sexo;
            this.correo = correo;
        }

        public static int agregarSalida(Alta a)
        {
            SqlConnection con;
            con = Conexion.agregarConexion();
            SqlCommand cmm = new SqlCommand(String.Format("insert into asistente (claveU, nombre, apellido, sexo, correo) values ('{0}','{1}','{2}','{3}','{4}')", a.claveU, a.nombre, a.apellido, a.sexo, a.correo), con);
            int res = cmm.ExecuteNonQuery();
            con.Close();
            return res;
        }
    }
}
