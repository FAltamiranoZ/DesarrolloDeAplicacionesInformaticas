using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication6_Sistema
{
    class SalidaArt
    {

        public int idSalidaArt { get; set; }

        public int idSalida { get; set; }

        public int idArticulo { get; set; }

        public int cantidad { get; set; }

        public SalidaArt()
        {

        }
        public SalidaArt(int idSalArt, int idSal, int idArt, int cantidad)
        {
            idSalidaArt = idSalArt;
            idSalida = idSal;
            idArticulo = idArt;
            this.cantidad = cantidad;
        }

        public static int agregarSalidaArt(SalidaArt a)
        {
            SqlConnection con;
            con = Conexion.agregarConexion();
            SqlCommand cmm = new SqlCommand(String.Format("insert into salArticulo (idSalArticulo, idSalida, idArticulo, cant) values ('{0}','{1}','{2}','{3}')", a.idSalidaArt, a.idSalida, a.idArticulo, a.cantidad), con);
            int res = cmm.ExecuteNonQuery();
            con.Close();
            return res;
        }

    }
}
