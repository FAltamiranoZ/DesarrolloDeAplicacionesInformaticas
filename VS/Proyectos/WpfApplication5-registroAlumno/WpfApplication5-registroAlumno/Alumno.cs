using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication5_registroAlumno
{
    class Alumno
    {
        public int claveUnica { get; set; }//Método que autogenera el get y el set

        public String nombre { get; set; }

        public String sexo { get; set; }

        public String correo { get; set; }

        public int semestre { get; set; }

        public int programa { get; set; }

        public Alumno()
        {

        }
        public Alumno(int cu, String nombre, String sexo, String correo, int semestre, int programa)
        {
            claveUnica = cu;
            this.nombre = nombre;
            this.sexo = sexo;
            this.correo = correo;
            this.semestre = semestre;
            this.programa = programa;
        }

        public Alumno(int cu, String nombre, String sexo, String correo, int semestre)
        {
            claveUnica = cu;
            this.nombre = nombre;
            this.sexo = sexo;
            this.correo = correo;
            this.semestre = semestre;
        }

        public Alumno(int cu, String correoa)
        {
            claveUnica = cu;
            this.correo = correo;
        }

        public static int agregarAlumno(Alumno a)
        {
            SqlConnection con;
            con = Conexion.agregarConexion();
            SqlCommand cmm = new SqlCommand(String.Format("insert into alumno (claveUnica, nombre, sexo, correo, semestre, idPrograma) values ('{0}','{1}','{2}','{3}','{4}','{5}')", a.claveUnica, a.nombre, a.sexo, a.correo, a.semestre, a.programa), con);
            //El insert agrega los nombres de las columnas y luego pongo values para que los traiga del sql?
            int res = cmm.ExecuteNonQuery();//Me regresa si se ejecuto o no.
            con.Close();
            return res;
        }

        public static int eliminarAlumno(int claveUnica)
        {
            int res = 0;
            SqlConnection con;
            con = Conexion.agregarConexion();
            SqlCommand cmm = new SqlCommand(String.Format("delete from alumno where claveUnica={0}", claveUnica), con);
            res = cmm.ExecuteNonQuery();
            con.Close();
            return res;
        }

        public static int modificarAlumno(int claveUnica, String correo)
        {
            int res = 0;
            SqlConnection con;
            con = Conexion.agregarConexion();
            SqlCommand cmm = new SqlCommand(String.Format("update alumno set correo='{0}' where claveUnica={1}", correo, claveUnica), con);
            res = cmm.ExecuteNonQuery();
            con.Close();
            return res;
        }

        public static List<Alumno> buscarAlumno(String nombre)
        {
            Alumno a;
            List<Alumno> lis = new List<Alumno>();
            SqlConnection con = Conexion.agregarConexion();
            SqlCommand cmm = new SqlCommand(String.Format("select claveUnica, nombre, sexo, correo, semestre, idPrograma from alumno where nombre like '%{0}%'", nombre), con);
            //%{x}% Es cualquier cosa que tenga tanto para la izquierda como para la derecha x
            SqlDataReader res = cmm.ExecuteReader();
            while (res.Read())
            {
                a = new Alumno();
                a.claveUnica = res.GetInt32(0); //El numero es el dato que viene, int32 siempre es asi.
                a.nombre = res.GetString(1); 
                a.sexo = res.GetString(2);
                a.correo = res.GetString(3);
                a.semestre = res.GetInt32(4);
                a.programa = res.GetInt32(5);
                lis.Add(a);
            }
            con.Close();
            return lis;
        }

    }
}
