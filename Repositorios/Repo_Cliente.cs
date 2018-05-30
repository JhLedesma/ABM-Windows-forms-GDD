using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaHotel.Repositorios
{
    public class Repo_Cliente
    {
        private static Repo_Cliente instancia;
        public Utils.DBhelper DBhelper = Utils.DBhelper.getInstancia();


        public static Repo_Cliente getInstancia()
        {
            if (instancia != null)
            {
                return instancia;
            }
            else
            {
                instancia = new Repo_Cliente();
                return instancia;
            }
        }

        public DataTable getTablaClientesFiltrados(String nombre, String apellido, String mail, String tipoIdentificacion, decimal NumeroIdentificacion)
        {

            DataTable tablaClientesFiltrados;

            DBhelper.crearConexion();

            DBhelper.abrirConexion();

            SqlCommand cmd = DBhelper.crearCommand("TRAEME_LA_COPA_MESSI.getClientesFiltrados");
            cmd.Parameters.Add("@Nombre", SqlDbType.NVarChar).Value = nombre;
            cmd.Parameters.Add("@Apellido", SqlDbType.NVarChar).Value = apellido;
            cmd.Parameters.Add("@Mail", SqlDbType.NVarChar).Value = mail;
            cmd.Parameters.Add("@Tipo_Identificacion", SqlDbType.NVarChar).Value = tipoIdentificacion;
            cmd.Parameters.Add("@Numero_Identificacion", SqlDbType.Decimal).Value = NumeroIdentificacion;

            tablaClientesFiltrados = DBhelper.obtenerTabla(cmd);

            DBhelper.cerrarConexion();

            return tablaClientesFiltrados;

        }

    }
}
