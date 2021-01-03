using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recomendaciones
{
    class Cliente
    {

        public String correo { get; set; }
        public String password { get; set; }
        public String nombre { get; set; }

        public Cliente(String correo, String password, String nombre)
        {
            this.correo = correo;
            this.password = password;
            this.nombre = nombre;
        }

        public static int agregarCliente(Cliente a)
        {
            SqlConnection con = Conexion.agregarConexion();
            SqlCommand cmd = new SqlCommand(String.Format("INSERT INTO cliente (correo, passwd, nombre) values ('{0}','{1}','{2}')", a.correo, a.password, a.nombre), con);
            int res = cmd.ExecuteNonQuery();
            con.Close();
            return res;
        }
        
        

    }
}
