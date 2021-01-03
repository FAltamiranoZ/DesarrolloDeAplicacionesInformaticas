using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba1
{
    class Elemento2
    {
        public int id { get; set; }
        public double suma { get; set; }
        public String fecha { get; set; }

        public Elemento2 (int id, double suma, String fecha)
        {
            this.id = id;
            this.suma = suma;
            this.fecha = fecha;
        }

        public int agregarElemento2(Elemento2 a)
        {
            SqlConnection con = Conexion.agregarConexion();
            SqlCommand cmd = new SqlCommand(String.Format("insert into pagos(id, suma, fecha) values ('{0}','{1}','{2}')",a.id,a.suma,a.fecha),con);
            int res = cmd.ExecuteNonQuery();
            con.Close();
            return res;
        }

    }
}
