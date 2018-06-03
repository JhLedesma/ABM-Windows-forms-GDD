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

        public void crearCliente(String email, String nombre, String apellido, String tipoDoc, decimal numDoc, decimal telefono, String paisOrigen, String nacionalidad, DateTime fechaNac, String ciudad, String calle, decimal numCalle, decimal piso, String dpto, String localidad, String pais)
        {
            DBhelper.crearConexion();

            DBhelper.abrirConexion();


            SqlCommand cmd = DBhelper.crearCommand("TRAEME_LA_COPA_MESSI.newCliente");
            cmd.Parameters.Add("@email", SqlDbType.NVarChar).Value = email;
            cmd.Parameters.Add("@nombre", SqlDbType.NVarChar).Value = nombre;
            cmd.Parameters.Add("@apellido", SqlDbType.NVarChar).Value = apellido;
            cmd.Parameters.Add("@tipoDoc", SqlDbType.NVarChar).Value = tipoDoc;
            cmd.Parameters.Add("@numDoc", SqlDbType.Decimal).Value = numDoc;
            cmd.Parameters.Add("@telefono", SqlDbType.Decimal).Value = telefono;
            cmd.Parameters.Add("@PaisOrigen", SqlDbType.NVarChar).Value = paisOrigen;
            cmd.Parameters.Add("@Nacionalidad", SqlDbType.NVarChar).Value = nacionalidad;
            cmd.Parameters.Add("@FechaNacimiento", SqlDbType.DateTime).Value = fechaNac;
            cmd.Parameters.Add("@ciudad", SqlDbType.NVarChar).Value = ciudad;
            cmd.Parameters.Add("@calle", SqlDbType.NVarChar).Value = calle;
            cmd.Parameters.Add("@nroCalle", SqlDbType.Decimal).Value = numCalle;
            cmd.Parameters.Add("@piso", SqlDbType.Decimal).Value = piso;
            cmd.Parameters.Add("@dpto", SqlDbType.NVarChar).Value = dpto;
            cmd.Parameters.Add("@localidad", SqlDbType.NVarChar).Value = localidad;
            cmd.Parameters.Add("@pais", SqlDbType.NVarChar).Value = pais;

            cmd.ExecuteNonQuery();

            DBhelper.cerrarConexion();
        }

        


       
    }
}
