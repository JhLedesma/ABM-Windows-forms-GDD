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

        public DataTable getTablaClientesFiltradosConInactivos(String nombre, String apellido, String mail, int tipoIdentificacion, decimal NumeroIdentificacion)
        {

            DataTable tablaClientesFiltrados;

            DBhelper.crearConexion();

            DBhelper.abrirConexion();

            SqlCommand cmd = DBhelper.crearCommand("TRAEME_LA_COPA_MESSI.getClientesFiltradosConInactivos");
            cmd.Parameters.Add("@Nombre", SqlDbType.NVarChar).Value = nombre;
            cmd.Parameters.Add("@Apellido", SqlDbType.NVarChar).Value = apellido;
            cmd.Parameters.Add("@Mail", SqlDbType.NVarChar).Value = mail;
            cmd.Parameters.Add("@Tipo_Identificacion", SqlDbType.Int).Value = tipoIdentificacion;
            cmd.Parameters.Add("@Numero_Identificacion", SqlDbType.Decimal).Value = NumeroIdentificacion;

            tablaClientesFiltrados = DBhelper.obtenerTabla(cmd);

            DBhelper.cerrarConexion();

            return tablaClientesFiltrados;

        }


        public DataTable getTablaClientesFiltradosActivos(String nombre, String apellido, String mail, int tipoIdentificacion, decimal NumeroIdentificacion)
        {

            DataTable tablaClientesFiltrados;

            DBhelper.crearConexion();

            DBhelper.abrirConexion();

            SqlCommand cmd = DBhelper.crearCommand("TRAEME_LA_COPA_MESSI.getClientesFiltradosActivos");
            cmd.Parameters.Add("@Nombre", SqlDbType.NVarChar).Value = nombre;
            cmd.Parameters.Add("@Apellido", SqlDbType.NVarChar).Value = apellido;
            cmd.Parameters.Add("@Mail", SqlDbType.NVarChar).Value = mail;
            cmd.Parameters.Add("@Tipo_Identificacion", SqlDbType.Int).Value = tipoIdentificacion;
            cmd.Parameters.Add("@Numero_Identificacion", SqlDbType.Decimal).Value = NumeroIdentificacion;

            tablaClientesFiltrados = DBhelper.obtenerTabla(cmd);

            DBhelper.cerrarConexion();

            return tablaClientesFiltrados;

        }


        public void crearCliente(String email, String nombre, String apellido, int tipoDoc, decimal numDoc, decimal telefono, String paisOrigen, String nacionalidad, DateTime fechaNac, String ciudad, String calle, decimal numCalle, decimal piso, String dpto, String localidad, String pais)
        {
            DBhelper.crearConexion();

            DBhelper.abrirConexion();

            SqlCommand cmd = DBhelper.crearCommand("TRAEME_LA_COPA_MESSI.newCliente");
            cmd.Parameters.Add("@email", SqlDbType.NVarChar).Value = email;
            cmd.Parameters.Add("@nombre", SqlDbType.NVarChar).Value = nombre;
            cmd.Parameters.Add("@apellido", SqlDbType.NVarChar).Value = apellido;
            cmd.Parameters.Add("@tipoDoc", SqlDbType.Int).Value = tipoDoc;
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

            DBhelper.ejecutarProcedure(cmd);

            DBhelper.cerrarConexion();
        }


        public int crearClienteReturnId(String email, String nombre, String apellido, int tipoDoc, decimal numDoc, decimal telefono, String paisOrigen, String nacionalidad, DateTime fechaNac, String ciudad, String calle, decimal numCalle, decimal piso, String dpto, String localidad, String pais)
        {
            DBhelper.crearConexion();

            DBhelper.abrirConexion();

            SqlCommand cmd = DBhelper.crearCommand("TRAEME_LA_COPA_MESSI.newClienteReturnId");
            cmd.Parameters.Add("@email", SqlDbType.NVarChar).Value = email;
            cmd.Parameters.Add("@nombre", SqlDbType.NVarChar).Value = nombre;
            cmd.Parameters.Add("@apellido", SqlDbType.NVarChar).Value = apellido;
            cmd.Parameters.Add("@tipoDoc", SqlDbType.Int).Value = tipoDoc;
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

            var valorDeRetorno = cmd.Parameters.Add("@ReturnVal", SqlDbType.Int);
            valorDeRetorno.Direction = ParameterDirection.ReturnValue;

            DBhelper.ejecutarProcedure(cmd);

            DBhelper.cerrarConexion();

            return (int)valorDeRetorno.Value;
        }

        public Model.Cliente getCliente(int idCliente, string mail)
        {
            DBhelper.crearConexion();

            DBhelper.abrirConexion();

            SqlCommand cmd = DBhelper.crearCommand("TRAEME_LA_COPA_MESSI.getCliente");
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = idCliente;
            cmd.Parameters.Add("@mail", SqlDbType.NVarChar).Value = mail;

            DataTable tablaCliente = DBhelper.obtenerTabla(cmd);

            Model.Cliente cliente = new FrbaHotel.Model.Cliente();

            foreach (DataRow row in tablaCliente.Rows)
            {
                    cliente.id = (Int32)row["IdCliente"];
                    cliente.nombre = (String)row["Nombre"];
                    cliente.apellido = (String)row["Apellido"];
                    cliente.mail = (String)row["Email"];
                    cliente.telefono = (decimal)row["Telefono"];
                    cliente.numDoc = (decimal)row["NumDoc"];
                    cliente.tipoDoc = this.getTipoDocumento((Int32)row["TipoDoc"]);
                    cliente.nacionalidad = (String)row["Nacionalidad"];
                    cliente.fechaNac = (DateTime)row["FechaNacimiento"];
                    cliente.paisOrigen = (String)row["PaisOrigen"];
                    cliente.direccion = this.getDireccion((Int32)row["Direccion"]);
                    cliente.estado = Convert.ToInt16(row["Estado"]);
            }

            DBhelper.cerrarConexion();

            return cliente;
        }

        public Model.TipoDocumento getTipoDocumento(int idTipoDoc)
        {
            DBhelper.crearConexion();

            DBhelper.abrirConexion();

            SqlCommand cmd = DBhelper.crearCommand("TRAEME_LA_COPA_MESSI.getTipoDocumento");
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = idTipoDoc;

            DataTable tablaTipoDoc = DBhelper.obtenerTabla(cmd);

            Model.TipoDocumento tipoDoc = new Model.TipoDocumento();

            foreach (DataRow row in tablaTipoDoc.Rows)
            {
                tipoDoc.id = (Int32)row["IdTipo"];
                tipoDoc.descripcion = (String)row["Descripcion"];
            }

            return tipoDoc;
        }

        public Model.Direccion getDireccion(int idDireccion)
        {
            DBhelper.crearConexion();

            DBhelper.abrirConexion();

            SqlCommand cmd = DBhelper.crearCommand("TRAEME_LA_COPA_MESSI.getDireccion");
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = idDireccion;

            DataTable tablaCliente = DBhelper.obtenerTabla(cmd);

            Model.Direccion direccion = new Model.Direccion();

            foreach (DataRow row in tablaCliente.Rows)
            {
                direccion.id = (Int32)row["IdDir"];
                direccion.calle = (String)row["Calle"];
                direccion.ciudad = (String)row["Ciudad"];
                direccion.dpto = (String)row["Departamento"];
                direccion.localidad = (String)row["Localidad"];
                direccion.pais = (String)row["Pais"];
                direccion.piso = (decimal)row["Piso"];
                direccion.numDomicilio = (decimal)row["NroCalle"];
            }

            DBhelper.cerrarConexion();

            return direccion;
        }


        public void modificarCliente(int idCliente, int idDireccion, String email, String nombre, String apellido, int tipoDoc, decimal numDoc, decimal telefono, String paisOrigen, String nacionalidad, DateTime fechaNac, String ciudad, String calle, decimal numCalle, decimal piso, String dpto, String localidad, String pais)
        {
            DBhelper.crearConexion();

            DBhelper.abrirConexion();

            SqlCommand cmd = DBhelper.crearCommand("TRAEME_LA_COPA_MESSI.modificarCliente");
            cmd.Parameters.Add("@email", SqlDbType.NVarChar).Value = email;
            cmd.Parameters.Add("@nombre", SqlDbType.NVarChar).Value = nombre;
            cmd.Parameters.Add("@apellido", SqlDbType.NVarChar).Value = apellido;
            cmd.Parameters.Add("@tipoDoc", SqlDbType.Int).Value = tipoDoc;
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
            cmd.Parameters.Add("@idCliente", SqlDbType.Int).Value = idCliente;
            cmd.Parameters.Add("@idDireccion", SqlDbType.Int).Value = idDireccion;

            cmd.ExecuteNonQuery();

            DBhelper.cerrarConexion();
        }


        public void darBajaCliente(int idCliente, string mail)
        {
            DBhelper.crearConexion();

            DBhelper.abrirConexion();

            SqlCommand cmd = DBhelper.crearCommand("TRAEME_LA_COPA_MESSI.darDeBajaCliente");
            cmd.Parameters.Add("@idCliente", SqlDbType.Int).Value = idCliente;
            cmd.Parameters.Add("@mail", SqlDbType.NVarChar).Value = mail;

            cmd.ExecuteNonQuery();

            DBhelper.cerrarConexion();
        }

        public int validarMail(string mail)
        {
            DBhelper.crearConexion();

            SqlCommand cmd = DBhelper.crearCommand("TRAEME_LA_COPA_MESSI.validarMail");
            cmd.Parameters.Add("@mail", SqlDbType.NVarChar).Value = mail;

            var valorDeRetorno = cmd.Parameters.Add("@ReturnVal", SqlDbType.Int);
            valorDeRetorno.Direction = ParameterDirection.ReturnValue;

            DBhelper.abrirConexion();

            DBhelper.ejecutarProcedure(cmd);

            DBhelper.cerrarConexion();

            return (int)valorDeRetorno.Value;
        }

       
       
    }
}
