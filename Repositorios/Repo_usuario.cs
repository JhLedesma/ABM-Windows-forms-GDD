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
    
        private static Repo_usuario instancia;
        public Model.Usuario usuarioIngresado = new Model.Usuario();
        public Utils.DBhelper DBhelper = Utils.DBhelper.getInstancia();
        

        public static Repo_usuario getInstancia() 
        {

            if (instancia != null)
            {
                return instancia;
            }
            else {
                instancia = new Repo_usuario();
                return instancia;
            }
        }

        public int validarUsuario(String usuario, String contraseña) 
        {

            
            DBhelper.crearConexion();

            SqlCommand cmd = DBhelper.crearCommand("TRAEME_LA_COPA_MESSI.validarUsuario");
            cmd.Parameters.Add("@usuarioNombre", SqlDbType.NVarChar).Value = usuario;
            cmd.Parameters.Add("@pass", SqlDbType.NVarChar).Value = Model.Encriptador.getInstancia().encriptar(contraseña);

            var valorDeRetorno = cmd.Parameters.Add("@ReturnVal", SqlDbType.Int);
            valorDeRetorno.Direction = ParameterDirection.ReturnValue;
          
            DBhelper.abrirConexion();

            DBhelper.ejecutarProcedure(cmd);

            DBhelper.cerrarConexion();

            return (int)valorDeRetorno.Value;
             
        }


        public void bloquearUsuario() 
        {

            DBhelper.crearConexion();

            SqlCommand cmd = DBhelper.crearCommand("TRAEME_LA_COPA_MESSI.bloquearUsuario");
            cmd.Parameters.Add("@usuarioId", SqlDbType.NVarChar).Value = usuarioIngresado.username;

            DBhelper.abrirConexion();

            DBhelper.ejecutarProcedure(cmd);

            DBhelper.cerrarConexion();
            Console.WriteLine("Bloquie");

        }


        public Model.Usuario getUsuarioLogeado(String nombre) 
        {

            DataTable tablaUsuario;

            DBhelper.crearConexion();

            SqlCommand cmd = DBhelper.crearCommand("TRAEME_LA_COPA_MESSI.getUsuario");
            cmd.Parameters.Add("@usuarioNombre", SqlDbType.NVarChar).Value = nombre;

            DBhelper.abrirConexion();

            tablaUsuario = DBhelper.obtenerTabla(cmd);

            foreach (DataRow row in tablaUsuario.Rows) {

                usuarioIngresado.username = ((String)row["Username"]);
                //usuarioIngresado.nombre = ((String)row["Nombre_Usuario"]);
                //usuarioIngresado.setEstado(Convert.ToInt16(row["Estado_Usuario"]));
                usuarioIngresado.logsFallidos = ((Int32)row["LogsFallidos"]); 
            
            }

            usuarioIngresado.setListaDeRoles(getRolesUsuario(usuarioIngresado.username));

            DBhelper.cerrarConexion();

            return usuarioIngresado;
        }


        public Model.Usuario getUsuario(String nombre)
        {
            DBhelper.crearConexion();
            DBhelper.abrirConexion();

            SqlCommand cmd = DBhelper.crearCommand("TRAEME_LA_COPA_MESSI.getUsuario");
            cmd.Parameters.Add("@usuarioNombre", SqlDbType.NVarChar).Value = nombre;

            DataTable tablaUsuario = DBhelper.obtenerTabla(cmd);
            Model.Usuario usuario = new Model.Usuario();

            foreach (DataRow row in tablaUsuario.Rows)
            {
                usuario.username = ((String)row["Username"]);
                usuario.password = ((String)row["Pass"]);
                usuario.nombre = ((String)row["Nombre"]);
                usuario.apellido = ((String)row["Apellido"]);
                usuario.email = ((String)row["Email"]);
                usuario.nroDocumento = ((decimal)row["NroDocumento"]);
                usuario.telefono = ((decimal)row["Telefono"]);
                usuario.fechaDeNacimiento = (DateTime)row["FechaNacimiento"];
                usuario.estado = (Convert.ToInt16(row["Estado"]));
                usuario.logsFallidos = ((Int32)row["LogsFallidos"]);
                usuario.direccion = this.getDireccion((Int32)row["Direccion"]);
                usuario.tipoDoc = this.getTipoDocumento((Int32)row["TipoDoc"]);
                usuario.listaDeRoles = this.getRolesUsuario((String)row["Username"]);
                usuario.listaHoteles = this.getHotelesDeUsuario((String)row["Username"]);
                usuario.rolActivo = usuario.listaDeRoles.First();
            }

            DBhelper.cerrarConexion();

            return usuario;
        }


       /* 
        Username nvarchar(255) PRIMARY KEY,
        Pass nvarchar(255)  NOT NULL,
        Direccion int FOREIGN KEY REFERENCES TRAEME_LA_COPA_MESSI.Direccion(IdDir) not null,
        Nombre nvarchar(255) not null,
        Apellido nvarchar(255) not null,
        TipoDoc int FOREIGN KEY REFERENCES TRAEME_LA_COPA_MESSI.TipoDoc(IdTipo) not null,
        NroDocumento numeric(18,0) not null,
        Email nvarchar(255) UNIQUE not null,
        Telefono numeric(18,0) not null,
        FechaNacimiento datetime not null,
        LogsFallidos int DEFAULT 0,
        Estado bit DEFAULT 0
        */


        public List<Model.Hotel> getHotelesDeUsuario(String username)
        {
            List<Model.Hotel> listaHoteles = new List<Model.Hotel>();

            DBhelper.crearConexion();

            DBhelper.abrirConexion();

            SqlCommand cmd = DBhelper.crearCommand("TRAEME_LA_COPA_MESSI.getHotelesDeUsuario");
            cmd.Parameters.Add("@Username", SqlDbType.NVarChar).Value = username;

            DataTable Hoteles = DBhelper.obtenerTabla(cmd);

            foreach (DataRow row in Hoteles.Rows)
            {
                Model.Hotel hotel = new Model.Hotel();

                hotel.idHotel = row.Field<Int32>("IdHotel");
                hotel.nombre = row.Field<String>("Nombre");
                hotel.mail = row.Field<String>("Mail");
                hotel.telefono = row.Field<Int32>("Telefono");
                hotel.estrellas = row.Field<Int32>("CantEstrellas");
                hotel.porcEstrella = row.Field<Decimal>("PorcentajeEstrellas");
                hotel.fechaCreacion = row.Field<DateTime>("FechaCreacion");

                listaHoteles.Add(hotel);
            }

            DBhelper.cerrarConexion();

            return listaHoteles;
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


        public Model.Usuario getUsuarioIngresado() 
        {

            return usuarioIngresado;

        }

        public Int32 getCantidadDeLogsFallidosUsuario() 
        {

            return usuarioIngresado.logsFallidos;
        
        }

        public List<Model.Rol> getRolesUsuario(String username)
        {

            DataTable tablaRoles;
            List<Model.Rol> listaDeRoles = new List<Model.Rol>();

            DBhelper.crearConexion();

            SqlCommand cmd = DBhelper.crearCommand("TRAEME_LA_COPA_MESSI.getRolesUsuario");
            cmd.Parameters.Add("@IdUsuario", SqlDbType.NVarChar).Value = username;

            DBhelper.abrirConexion();

            tablaRoles = DBhelper.obtenerTabla(cmd);

            foreach (DataRow row in tablaRoles.Rows)
            {

                Model.Rol rol = new Model.Rol();

                rol.nombreRol = ((String)row["Nombre"]);
                rol.idRol = ((Int32)row["IdRol"]);
                rol.estado = (Convert.ToInt16(row["Estado"]));

                listaDeRoles.Add(rol);
            }

            DBhelper.cerrarConexion();

            return listaDeRoles;

        }


        ///ABM Usuario////////////////////////////
        ///

        public void newUsuario(Model.Usuario usuario, Model.Rol rol, List<Model.Hotel> hoteles)
        {
            DBhelper.crearConexion();
            DBhelper.abrirConexion();

            //SqlTransaction transaction = DBhelper.getConexion().BeginTransaction();

            SqlCommand cmd = DBhelper.crearCommand("TRAEME_LA_COPA_MESSI.newUsuario");
            //cmd.Transaction = transaction;

            try
            {

                cmd.Parameters.Add("@user", SqlDbType.NVarChar).Value = usuario.username;
                cmd.Parameters.Add("@pass", SqlDbType.NVarChar).Value = usuario.password;
                cmd.Parameters.Add("@email", SqlDbType.NVarChar).Value = usuario.email;
                cmd.Parameters.Add("@nombre", SqlDbType.NVarChar).Value = usuario.nombre;
                cmd.Parameters.Add("@apellido", SqlDbType.NVarChar).Value = usuario.apellido;
                cmd.Parameters.Add("@tipoDoc", SqlDbType.Int).Value = usuario.tipoDoc.id;
                cmd.Parameters.Add("@numDoc", SqlDbType.Decimal).Value = usuario.nroDocumento;
                cmd.Parameters.Add("@telefono", SqlDbType.Decimal).Value = usuario.telefono;
                cmd.Parameters.Add("@FechaNacimiento", SqlDbType.DateTime).Value = usuario.fechaDeNacimiento;
                cmd.Parameters.Add("@ciudad", SqlDbType.NVarChar).Value = usuario.direccion.ciudad;
                cmd.Parameters.Add("@calle", SqlDbType.NVarChar).Value = usuario.direccion.calle;
                cmd.Parameters.Add("@nroCalle", SqlDbType.Decimal).Value = usuario.direccion.numDomicilio;
                cmd.Parameters.Add("@piso", SqlDbType.Decimal).Value = usuario.direccion.piso;
                cmd.Parameters.Add("@dpto", SqlDbType.NVarChar).Value = usuario.direccion.dpto;
                cmd.Parameters.Add("@localidad", SqlDbType.NVarChar).Value = usuario.direccion.localidad;
                cmd.Parameters.Add("@pais", SqlDbType.NVarChar).Value = usuario.direccion.pais;

                DBhelper.ejecutarProcedure(cmd);

                this.newRolPorUsuario(rol.idRol, usuario.username);

                foreach (Model.Hotel hotel in hoteles)
                {
                    this.newUsuariosPorHotel(hotel.idHotel, usuario.username, rol.Nombre);
                }

                //transaction.Commit();
                DBhelper.cerrarConexion();
            }
            catch (Exception e)
            {
                //transaction.Rollback();
                DBhelper.cerrarConexion();
            }
        }

        private void newRolPorUsuario(int idRol, String username)
        {
            DBhelper.crearConexion();
            DBhelper.abrirConexion();

            //SqlTransaction transaction = DBhelper.getConexion().BeginTransaction();
            SqlCommand cmd = DBhelper.crearCommand("TRAEME_LA_COPA_MESSI.newRolPorUsuario");
            //cmd.Transaction = transaction;

            try 
            {
                cmd.Parameters.Add("@username", SqlDbType.NVarChar).Value = username;
                cmd.Parameters.Add("@Rol", SqlDbType.Int).Value = idRol;

                DBhelper.ejecutarProcedure(cmd);
                //transaction.Commit();
                DBhelper.cerrarConexion();
            }
            catch (Exception e)
            {
                //transaction.Rollback();
                DBhelper.cerrarConexion();
            }
                
        }

        private void newUsuariosPorHotel(int idHotel, String username, String userDesempeño)
        {
            DBhelper.crearConexion();
            DBhelper.abrirConexion();

            //SqlTransaction transaction = DBhelper.getConexion().BeginTransaction();
            SqlCommand cmd = DBhelper.crearCommand("TRAEME_LA_COPA_MESSI.newUsuariosPorHotel");
            //cmd.Transaction = transaction;

            try
            {
                cmd.Parameters.Add("@username", SqlDbType.NVarChar).Value = username;
                cmd.Parameters.Add("@User_desempenio", SqlDbType.NVarChar).Value = userDesempeño;
                cmd.Parameters.Add("@hotelId", SqlDbType.Int).Value = idHotel;

                DBhelper.ejecutarProcedure(cmd);
                //transaction.Commit();
                DBhelper.cerrarConexion();
            }
            catch (Exception e)
            {
                //transaction.Rollback();
                DBhelper.cerrarConexion();
            }
                
        }


        public DataTable getTablaUsuariosFiltradosConInactivos(String nombre, String apellido, String username, decimal NumeroIdentificacion)
        {

            DataTable tablaClientesFiltrados;

            DBhelper.crearConexion();

            DBhelper.abrirConexion();

            SqlCommand cmd = DBhelper.crearCommand("TRAEME_LA_COPA_MESSI.getUsuariosFiltradosConInactivos");
            cmd.Parameters.Add("@Nombre", SqlDbType.NVarChar).Value = nombre;
            cmd.Parameters.Add("@Apellido", SqlDbType.NVarChar).Value = apellido;
            cmd.Parameters.Add("@Username", SqlDbType.NVarChar).Value = username;
            cmd.Parameters.Add("@Numero_Identificacion", SqlDbType.Decimal).Value = NumeroIdentificacion;

            tablaClientesFiltrados = DBhelper.obtenerTabla(cmd);

            DBhelper.cerrarConexion();

            return tablaClientesFiltrados;
        }


        public int validarMail(string mail)
        {
            DBhelper.crearConexion();

            SqlCommand cmd = DBhelper.crearCommand("TRAEME_LA_COPA_MESSI.validarMailUsuario");
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
