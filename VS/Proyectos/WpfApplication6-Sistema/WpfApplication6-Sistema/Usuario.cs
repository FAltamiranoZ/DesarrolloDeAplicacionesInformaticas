using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication6_Sistema
{
    class Usuario
    {

        String userPwd;
        int idUser;
        public Usuario(int idUser, String userPwd)
        {
            this.idUser = idUser;
            this.userPwd = userPwd;
        }

        public static int busqueda(Usuario a)
        {
            int num=0;
            SqlConnection con;
            con = Conexion.agregarConexion();
            SqlCommand cmm = new SqlCommand(String.Format("select idUser, userPwd from usuario where (idUser = {0} and userPwd = '{1}')", a.idUser, a.userPwd), con);
            SqlDataReader res = cmm.ExecuteReader();
            if (res.Read())
                num = 1;
            con.Close();
            return num;
        }

    }
}
