using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace FrbaHotel.Repositorios
{
    class Repo_Rol
    {
        public static Repo_Rol instancia;
        public Utils.DBhelper DBhelper = Utils.DBhelper.getInstancia();

        public static Repo_Rol getInstancia()
        {

            if (instancia != null)
            {
                return instancia;
            }
            else
            {
                instancia = new Repo_Rol();
                return instancia;
            }
        }

        public int validarRol(string nombre)
        {
            
            DBhelper.crearConexion();

            SqlCommand cmd = DBhelper.crearCommand("TRAEME_LA_COPA_MESSI.ValidarNombreDeRol");
            cmd.Parameters.Add("@nombreRol", SqlDbType.NVarChar).Value = nombre;

            var retorno = cmd.Parameters.Add("@ReturnVal", SqlDbType.Int);
            retorno.Direction = ParameterDirection.ReturnValue;


            DBhelper.abrirConexion();

            DBhelper.ejecutarProcedure(cmd);

            DBhelper.cerrarConexion();

            return (int)retorno.Value;

        }

        public void agregarRol(string nombre, List<Model.Funcionalidad> funcionalidades, bool activo)
        {

            int estado;
            if (activo) { estado = 1; } else { estado = 0; };
            int cantidadDeFuncionalidades = funcionalidades.Count;
            //falta modificar funcionalidades por rol

            DBhelper.crearConexion();

            SqlCommand cmd = DBhelper.crearCommand("TRAEME_LA_COPA_MESSI.agregarNuevoRol");
            cmd.Parameters.Add("@nombreRol", SqlDbType.NVarChar).Value = nombre;
            cmd.Parameters.Add("@estado", SqlDbType.Int).Value = estado;
            DBhelper.abrirConexion();

            DBhelper.ejecutarProcedure(cmd);

            DBhelper.cerrarConexion();
        }
    }
}
