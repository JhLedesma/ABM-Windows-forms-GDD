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
    public class Repo_usuario
    {
    
        public static Repo_usuario instancia;
        public Model.Usuario usuarioIngresado = new Model.Usuario();
        public Utils.DBhelper DBhelper = Utils.DBhelper.getInstancia();

        public static Repo_usuario getInstancia() {

            if (instancia != null)
            {
                return instancia;
            }
            else {
                instancia = new Repo_usuario();
                return instancia;
            }
        }

        public int validarUsuario(String usuario, String contraseña) {

            
            DBhelper.crearConexion();

            SqlCommand cmd = DBhelper.crearCommand("QEPD.validarUsuario");
            cmd.Parameters.Add("@usuarioNombre", SqlDbType.NVarChar).Value = usuario;
            cmd.Parameters.Add("@pass", SqlDbType.NVarChar).Value = Model.Encriptador.getInstancia().encriptar(contraseña);

            var valorDeRetorno = cmd.Parameters.Add("@ReturnVal", SqlDbType.Int);
            valorDeRetorno.Direction = ParameterDirection.ReturnValue;
          
            DBhelper.abrirConexion();

            DBhelper.ejecutarProcedure(cmd);

            DBhelper.cerrarConexion();

            return (int)valorDeRetorno.Value;
             
        }


        public void bloquearUsuario() {

            DBhelper.crearConexion();

            SqlCommand cmd = DBhelper.crearCommand("QEPD.bloquearUsuario");
            cmd.Parameters.Add("@usuarioId", SqlDbType.NVarChar).Value = usuarioIngresado.username;

            DBhelper.abrirConexion();

            DBhelper.ejecutarProcedure(cmd);

            DBhelper.cerrarConexion();
            Console.WriteLine("Bloquie");

        }


        public Model.Usuario getUsuario(String nombre) {

            DataTable tablaUsuario;

            DBhelper.crearConexion();

            SqlCommand cmd = DBhelper.crearCommand("QEPD.getUsuario");
            cmd.Parameters.Add("@usuarioNombre", SqlDbType.NVarChar).Value = nombre;

            DBhelper.abrirConexion();

            tablaUsuario = DBhelper.obtenerTabla(cmd);

            foreach (DataRow row in tablaUsuario.Rows) {

                usuarioIngresado.username = ((String)row["IdUsuario"]);
                usuarioIngresado.nombre = ((String)row["Nombre_Usuario"]);
                //usuarioIngresado.setEstado(Convert.ToInt16(row["Estado_Usuario"]));
                usuarioIngresado.logsFallidos = ((Int32)row["Logs_Fallidos"]); 
            
            }

            //usuarioIngresado.setListaDeRoles(getRolesUsuario(usuarioIngresado.getId()));

            return usuarioIngresado;

        }

        public Model.Usuario getUsuarioIngresado() {

            return usuarioIngresado;

        }

       /* public Int32 getCantidadDeLogsFallidosUsuario() {

            return usuarioIngresado.getCantidadLogsFallidos();
        
        }*/


}

}
