using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApplication6_Sistema;

namespace WpfApplication6_Sistema
{
    class Articulo
    {

        String nP;
        int art;
        int foF, idUser;
        String feR, feE, fechaF;
        int cant;
        decimal precio;

        public Articulo(String nP1, int articulo1, int foF1, int idUser1, String feR1, String feE1, String fechaF1, int cant1, decimal precio1)
        {
            nP = nP1;
            art = articulo1;
            foF = foF1;
            idUser = idUser1;
            feR = feR1;
            feE = feE1;
            fechaF = fechaF1;
            cant = cant1;
            precio = precio1;
        }

        public static int agregar(Articulo a)
        {
            int res = 0;
            SqlConnection con = Conexion.agregarConexion();
            SqlCommand cmd;
            cmd = new SqlCommand(String.Format("select MAX(idEntrada) from entrada"), con);
            object b = cmd.ExecuteScalar();
            int idE = 0;
            if (b != null)
                idE = int.Parse(b.ToString()) + 1;
            cmd = new SqlCommand(String.Format("insert into entrada (idEntrada, fechaRegistro, fechaEntrada, proveedor, folioFactura, fechaFactura, idUser) values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}')", idE, a.feR, a.feE, a.nP, a.foF, a.fechaF, a.idUser), con);
            res = cmd.ExecuteNonQuery();
            if (res > 0)
            {
                cmd = new SqlCommand(String.Format("select MAX(idEntArticulo) from entArticulo"));
                Object c = cmd.ExecuteScalar();
                if (c != null)
                {
                    int idEnA = int.Parse(c.ToString());
                    cmd = new SqlCommand(String.Format("insert into entArticulo (idEntArticulo, idEntrada, idArticulo, cant, precioCompra) values ('{0}','{1}','{2}','{3}','{4}')", idEnA, idE, a.art, a.cant, a.precio), con);
                    cmd.ExecuteNonQuery();
                    cmd = new SqlCommand(String.Format("select existencia from articulo where idArticulo={0}", a.art), con);
                    Object d = cmd.ExecuteScalar();
                    int tot = int.Parse(d.ToString());
                    int tot2 = tot + a.cant;
                    cmd = new SqlCommand(String.Format("select costoProm from articulo where idArticulo={0}", a.art), con);
                    Object e = cmd.ExecuteScalar();
                    decimal ptot = a.cant * a.precio;
                    decimal totp = (decimal.Parse(e.ToString()) * tot * ptot) / tot2;
                    cmd = new SqlCommand(String.Format("Update articulo set costoProm='{0}' where idArticulo={1}", totp, a.art), con);
                    res = cmd.ExecuteNonQuery();
                    cmd = new SqlCommand(String.Format("Update articulo set existencia='{0}' where idArticulo={1}", tot2, a.art), con);
                    res = cmd.ExecuteNonQuery();
                }
                else
                {
                    int idEnA = 0;
                    cmd = new SqlCommand(String.Format("insert into entArticulo (idEntArticulo, idEntrada, idArticulo, cant, precioCompra) values ('{0}','{1}','{2}','{3}','{4}')", idEnA, idE, a.art, a.cant, a.precio), con);
                    cmd.ExecuteNonQuery();
                    cmd = new SqlCommand(String.Format("select existencia from articulo where idArticulo={0}", a.art), con);
                    Object d = cmd.ExecuteScalar();
                    int tot = int.Parse(d.ToString());
                    int tot2 = tot + a.cant;
                    cmd = new SqlCommand(String.Format("select costoProm from articulo where idArticulo={0}", a.art), con);
                    Object e = cmd.ExecuteScalar();
                    decimal ptot = a.cant * a.precio;
                    decimal totp = (decimal.Parse(e.ToString()) * tot * ptot) / tot2;
                    cmd = new SqlCommand(String.Format("Update articulo set costoProm='{0}' where idArticulo={1}", totp, a.art), con);
                    res = cmd.ExecuteNonQuery();
                    cmd = new SqlCommand(String.Format("Update articulo set existencia='{0}' where idArticulo={1}", tot2, a.art), con);
                    res = cmd.ExecuteNonQuery();
                }
            }
            con.Close();
            return res;
        }
    }
}
