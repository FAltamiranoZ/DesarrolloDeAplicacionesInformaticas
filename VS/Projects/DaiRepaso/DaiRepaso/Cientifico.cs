using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaiRepaso
{
    class Cientifico
    {
        public int idCientifico { get; set; }

        public int idProyecto { get; set; }

        public String nombre { get; set; }

        public String especialidad { get; set; }

        public Cientifico(int idCient, String nombre, String especialidad, int idProy)
        {
            idCientifico = idCient;
            this.nombre = nombre;
            this.especialidad = especialidad;
            idProyecto = idProy;
        }

        public static int agregarCientifico(Cientifico a)
        {
            SqlConnection con;
            con = daiRepaso.Conexion.agregarConexion();
            SqlCommand cmm = new SqlCommand(String.Format("insert into cientifico (idCientifico, nomCientifico, especialidad) values ('{0}','{1}','{2}')", a.idCientifico, a.nombre, a.especialidad), con);
            SqlCommand cmm2 = new SqlCommand(String.Format("insert into cientificoProyecto (idCientifico, idProyecto) values ('{0}','{1}')", a.idCientifico, a.idProyecto), con);
            int res = cmm.ExecuteNonQuery();
            con.Close();
            return res;
        }


    }
}
