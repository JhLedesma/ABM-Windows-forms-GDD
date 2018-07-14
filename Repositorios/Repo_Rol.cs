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

        public int agregarRol(string nombre, List<Model.Funcionalidad> funcionalidades, bool activo)
        {

            int estado;
            if (activo) { estado = 1; } else { estado = 0; };
            int cantidadDeFuncionalidades = funcionalidades.Count;

            DBhelper.crearConexion();

            SqlCommand cmd = DBhelper.crearCommand("TRAEME_LA_COPA_MESSI.agregarNuevoRol");
            cmd.Parameters.Add("@nombreRol", SqlDbType.NVarChar).Value = nombre;
            cmd.Parameters.Add("@estado", SqlDbType.Int).Value = estado;

            var retorno = cmd.Parameters.Add("@ReturnVal", SqlDbType.Int);
            retorno.Direction = ParameterDirection.ReturnValue;
            DBhelper.abrirConexion();

            DBhelper.ejecutarProcedure(cmd);

            DBhelper.cerrarConexion();
            int id = (int)retorno.Value;
            return id;
        }


        public void actualizarFuncPorRol(List<Model.Funcionalidad> funcionalidades, int id)
        {
            foreach (Model.Funcionalidad funcionalidad in funcionalidades)
            {
                DBhelper.crearConexion();
                SqlCommand cmd = DBhelper.crearCommand("TRAEME_LA_COPA_MESSI.actualizarFuncionalidadporRol");
                cmd.Parameters.Add("@idRol", SqlDbType.Int).Value = id;
                cmd.Parameters.Add("@funcionalidad", SqlDbType.NVarChar).Value = funcionalidad.getDescripcion;

                DBhelper.abrirConexion();
                DBhelper.ejecutarProcedure(cmd);
                DBhelper.cerrarConexion();
            }
        }

        public List<Model.Rol> getRoles()
        {
            List<Model.Rol> listaDeRoles = new List<Model.Rol>();
            DataTable roles;
            SqlCommand cm2;
            DBhelper.crearConexion();
            DBhelper.abrirConexion();
            SqlCommand cmd = DBhelper.crearCommand("TRAEME_LA_COPA_MESSI.getRoles");


            roles = DBhelper.obtenerTabla(cmd);
            DBhelper.cerrarConexion();
            foreach (DataRow row in roles.Rows)
            {
                Model.Rol rol = new Model.Rol();

                rol.nombreRol = ((String)row["Nombre"]);
                rol.estado = Convert.ToInt16(row["Estado"]);
                rol.idRol = ((Int32)row["IdRol"]);
                listaDeRoles.Add(rol);
            }

            foreach (Model.Rol rol in listaDeRoles)
            {
                DBhelper.crearConexion();
                DBhelper.abrirConexion();

                cm2 = DBhelper.crearCommand("TRAEME_LA_COPA_MESSI.getFuncionalidadPorRol");
                cm2.Parameters.Add("@idRol", SqlDbType.Int).Value = rol.idRol;
                DataTable funcionalidadesDelRol = DBhelper.obtenerTabla(cm2);
                DBhelper.cerrarConexion();
                foreach (DataRow funcion in funcionalidadesDelRol.Rows)
                {


                    Model.Funcionalidad funcionali = new Model.Funcionalidad();

                    funcionali.descripcion = ((String)funcion["Descripcion"]);
                    rol.agregarFuncionalidad(funcionali);

                }

            } return listaDeRoles;

        }


        public void actualizarRol(Model.Rol rolElegido)
        {
            DBhelper.crearConexion();
            DBhelper.abrirConexion();
            SqlCommand actualizar = DBhelper.crearCommand("TRAEME_LA_COPA_MESSI.modificarRol");
            actualizar.Parameters.Add("@nombreRol", SqlDbType.NVarChar).Value = rolElegido.nombreRol;
            actualizar.Parameters.Add("@estado", SqlDbType.Int).Value = rolElegido.estado;
            DBhelper.ejecutarProcedure(actualizar);
            DBhelper.crearConexion();

            DBhelper.crearConexion();
            DBhelper.abrirConexion();
            SqlCommand actualizar2 = DBhelper.crearCommand("TRAEME_LA_COPA_MESSI.eliminarFuncionalidadesDelRol");
            actualizar2.Parameters.Add("@idRol", SqlDbType.Int).Value = rolElegido.idRol;
            DBhelper.ejecutarProcedure(actualizar2);
            DBhelper.crearConexion();

            foreach (Model.Funcionalidad func in rolElegido.funcionalidades)
            {


                DBhelper.crearConexion();
                DBhelper.abrirConexion();
                SqlCommand cmd = DBhelper.crearCommand("TRAEME_LA_COPA_MESSI.actualizarFuncionalidadporRol");
                cmd.Parameters.Add("@idRol", SqlDbType.Int).Value = rolElegido.idRol;
                cmd.Parameters.Add("@funcionalidad", SqlDbType.NVarChar).Value = func.getDescripcion;
                DBhelper.ejecutarProcedure(cmd);
                DBhelper.crearConexion();

            }


        }
        public void eliminarRol(Model.Rol rolElegido)
        {
            DBhelper.crearConexion();
            DBhelper.abrirConexion();
            SqlCommand eliminar2 = DBhelper.crearCommand("TRAEME_LA_COPA_MESSI.eliminarRol");
            eliminar2.Parameters.Add("@idRol", SqlDbType.Int).Value = rolElegido.idRol;
            DBhelper.ejecutarProcedure(eliminar2);
            DBhelper.crearConexion();
        }
    }
}