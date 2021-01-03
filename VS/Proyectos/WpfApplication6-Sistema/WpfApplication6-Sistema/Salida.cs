using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WpfApplication6_Sistema
{
    class Salida
    {

        public int idSalida { get; set; }

        public int idUser { get; set; }

        public String responsable { get; set; }

        public String fechaReg { get; set; }

        public String fechaSal { get; set; }

        public Salida()
        {

        }
        public Salida(int idSal, int idUs, String responsable, String fechaReg, String fechaSal)
        {
            idSalida = idSal;
            idUser = idUs;
            this.responsable = responsable;
            this.fechaReg = fechaReg;
            this.fechaSal = fechaSal;
        }

        public static int agregarSalida(Salida a)
        {
            SqlConnection con;
            con = Conexion.agregarConexion(); 
            SqlCommand cmm = new SqlCommand(String.Format("insert into salida (idSalida, idUser, responsable, fechaRegistro, fechaSalida) values ('{0}','{1}','{2}','{3}','{4}')", a.idSalida, a.idUser, a.responsable, a.fechaReg, a.fechaSal), con);
            int res = cmm.ExecuteNonQuery();
            con.Close();
            return res;
        }

    }
}
