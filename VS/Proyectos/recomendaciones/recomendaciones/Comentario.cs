using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recomendaciones
{
    class Comentario
    {

        public int idComentario { get; set; }
        public String recomendacion { get; set; }
        public String titulo { get; set; }
        public String contenido { get; set; }
        public int idDisfraz { get; set; }

        public Comentario(int idComentarioo, String recomendacion, String titulo, String contenido, int idDisfrazz)
        {
            idComentario = idComentarioo;
            this.recomendacion = recomendacion;
            this.titulo = titulo;
            this.contenido = contenido;
            idDisfraz = idDisfrazz;
        }

        public static int agregarComentario(Comentario a)
        {
            SqlConnection con = Conexion.agregarConexion();
            SqlCommand cmd = new SqlCommand(String.Format("insert into comentarios(idComentario, recomendacion, titulo, contenido, idDisfraz) values ('{0}', '{1}', '{2}', '{3}','{4}')", a.idComentario, a.recomendacion, a.titulo, a.contenido, a.idDisfraz), con);
            int res = cmd.ExecuteNonQuery();
            return res;
        }

    }
}
