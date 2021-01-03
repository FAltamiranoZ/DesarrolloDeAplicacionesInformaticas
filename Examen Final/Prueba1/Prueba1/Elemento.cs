using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba1
{
    class Elemento
    {
        public int idProf { get; set; }
        public String NomProf { get; set; }
        public String Categoría { get; set; }

        public Elemento (int cu, String carrera, String adeudo)
        {
            this.idProf = cu;
            this.NomProf = carrera;
            this.Categoría = adeudo;
        }

        public int agregarElemento(Elemento a)
        {
            SqlConnection con = Conexion.agregarConexion();
            SqlCommand cmd = new SqlCommand(String.Format("insert into Prof(IdProf, NomProf, Categoría) values ('{0}','{1}','{2}')", a.idProf, a.NomProf,a.Categoría), con);
            int res = cmd.ExecuteNonQuery();
            con.Close();
            return res;
        }

        public int quitarElemento(Elemento a)
        {
            SqlConnection con = Conexion.agregarConexion();
            SqlCommand cmd = new SqlCommand(String.Format("delete from Orof where IdProf='{0}'", a.idProf), con);
            int res = cmd.ExecuteNonQuery();
            con.Close();
            return res;
        }

    }
}
