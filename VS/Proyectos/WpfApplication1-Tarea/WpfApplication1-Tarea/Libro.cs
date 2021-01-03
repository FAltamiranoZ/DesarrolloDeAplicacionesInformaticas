using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1_Tarea
{
    class Libro
    {

        public int idAutor { get; set; }

        public String autor { get; set; }

        public String titulo { get; set; }

        public String editorial { get; set; }

        public Libro(int idAutor, String autor, String titulo, String editorial)
        {
            this.idAutor = idAutor;
            this.autor = autor;
            this.titulo = titulo;
            this.editorial = editorial;
        }

        public static int agregarLibro(Libro a)
        {
            SqlConnection con;
            con = Conexion.agregarConexion();
            SqlCommand cmm = new SqlCommand(String.Format("insert into libros (idAutor, autor, titulo, editorial) values ('{0}','{1}','{2}','{3}')", a.idAutor, a.autor, a.titulo, a.editorial), con);
            int res = cmm.ExecuteNonQuery();
            con.Close();
            return res;
        }

        public static int eliminarLibro(int idAutor)
        {
            int res = 0;
            SqlConnection con;
            con = Conexion.agregarConexion();
            SqlCommand cmm = new SqlCommand(String.Format("delete from libros where idAutor={0}", idAutor), con);
            res = cmm.ExecuteNonQuery();
            con.Close();
            return res;
        }

        public static int modificarLibro(int idAutor, String titulo)
        {
            int res = 0;
            SqlConnection con;
            con = Conexion.agregarConexion();
            SqlCommand cmm = new SqlCommand(String.Format("update libros set titulo='{0}' where idAutor={1}", titulo, idAutor), con);
            res = cmm.ExecuteNonQuery();
            con.Close();
            return res;
        }

    }
}
