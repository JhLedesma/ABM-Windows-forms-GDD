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
   public class Repo_habitacion
    {
        private static Repo_habitacion instancia;
        public Utils.DBhelper DBhelper = Utils.DBhelper.getInstancia();

        public static Repo_habitacion getInstancia()
        {

            if (instancia != null)
            {
                return instancia;
            }
            else
            {
                instancia = new Repo_habitacion();
                return instancia;
            }
        }

        public List<Model.TipoHabitacion> getTiposHabitaciones()
        {

            DataTable TiposHabitacion;

            List<Model.TipoHabitacion> listaTipos = new List<Model.TipoHabitacion>();

            DBhelper.crearConexion();

            SqlCommand cmd = DBhelper.crearCommand("TRAEME_LA_COPA_MESSI.getTiposHabitaciones");
            
            DBhelper.abrirConexion();

            TiposHabitacion = DBhelper.obtenerTabla(cmd);

            DBhelper.cerrarConexion();
            foreach (DataRow row in TiposHabitacion.Rows)
            {
                Model.TipoHabitacion tipoHabitacion = new Model.TipoHabitacion();

                tipoHabitacion.codigo= row.Field<Int32>("Codigo");
                tipoHabitacion.descripcion = row.Field<String>("Descripcion");
                tipoHabitacion.porcentual = row.Field<decimal>("Porcentual");

                listaTipos.Add(tipoHabitacion);
            }

            return listaTipos;
        
        }

        public Int32 crearHabitacion(Int32 idHotel ,Int32 numero, Int32 piso, String ubicacion, Int32 tipoHabitacion, String descripcion)
        {
            
            DBhelper.crearConexion();
            SqlCommand cmd = DBhelper.crearCommand("TRAEME_LA_COPA_MESSI.crearHabitacion");
            cmd.Parameters.Add("@idHotel", SqlDbType.Int).Value = idHotel;
            cmd.Parameters.Add("@numero", SqlDbType.Int).Value = numero;
            cmd.Parameters.Add("@piso", SqlDbType.Int).Value = piso;
            cmd.Parameters.Add("@tipoHabitacion", SqlDbType.Int).Value = tipoHabitacion;
            cmd.Parameters.Add("@ubicacion", SqlDbType.NVarChar).Value = ubicacion;
            cmd.Parameters.Add("@descripcion", SqlDbType.NVarChar).Value = descripcion;

            var valorDeRetorno = cmd.Parameters.Add("@ReturnVal", SqlDbType.Int);
            valorDeRetorno.Direction = ParameterDirection.ReturnValue;

            DBhelper.abrirConexion();

            DBhelper.ejecutarProcedure(cmd);

            DBhelper.cerrarConexion();

            return (int)valorDeRetorno.Value;

        }

        public DataTable getHabitacionesFiltradas(String ubicacion, Int32 idHotel, Int32 idTipo)
        {

            DataTable tablaHabitacionesFiltradas;

            DBhelper.crearConexion();

            DBhelper.abrirConexion();

            SqlCommand cmd = DBhelper.crearCommand("TRAEME_LA_COPA_MESSI.getHabitacionesFiltradas");
            cmd.Parameters.Add("@ubicacion", SqlDbType.NVarChar).Value = ubicacion;
            cmd.Parameters.Add("@idHotel", SqlDbType.Int).Value = idHotel;
            cmd.Parameters.Add("@idTipo", SqlDbType.Int).Value = idTipo;

            tablaHabitacionesFiltradas = DBhelper.obtenerTabla(cmd);

            DBhelper.cerrarConexion();

            return tablaHabitacionesFiltradas;

        }

        public Model.Habitacion getHabitacion(Int32 idHotel, Int32 numeroHab)
        {
            DBhelper.crearConexion();

            DBhelper.abrirConexion();

            SqlCommand cmd = DBhelper.crearCommand("TRAEME_LA_COPA_MESSI.getHabitacion");
            cmd.Parameters.Add("@idHotel", SqlDbType.Int).Value = idHotel;
            cmd.Parameters.Add("@numero", SqlDbType.Int).Value = numeroHab;

            DataTable tablaHabitacion = DBhelper.obtenerTabla(cmd);

            Model.Habitacion habitacion = new FrbaHotel.Model.Habitacion();

            foreach (DataRow row in tablaHabitacion.Rows)
            {

                habitacion.idHotel= (Int32)row["IdHotel"];
                habitacion.numero = (Int32)row["Numero"];
                habitacion.piso= (Int32)row["Piso"];
                habitacion.descripcion = (String)row["Descripcion"];
                habitacion.ubicacion = (String)row["Ubicacion"]; //Esto deberia mostrarlo por combo box, no devolverlo asi

            }

            DBhelper.cerrarConexion();

            return habitacion;
        }

        public Int32 modificarHabitacion(Int32 idHotelModificado, Int32 numeroHabModif, Int32 idHotelNuevo, Int32 numeroHabNuevo, Int32 piso, String ubicacion, String descripcion)
        {
            DBhelper.crearConexion();

            SqlCommand cmd = DBhelper.crearCommand("TRAEME_LA_COPA_MESSI.modificarHabitacion");
            cmd.Parameters.Add("@hotelIdModif", SqlDbType.Int).Value = idHotelModificado;
            cmd.Parameters.Add("@numeroHabModif", SqlDbType.Int).Value = numeroHabModif;
            cmd.Parameters.Add("@hotelIdNuevo", SqlDbType.Int).Value = idHotelNuevo;
            cmd.Parameters.Add("@numeroHabNuevo", SqlDbType.Int).Value = numeroHabNuevo;
            cmd.Parameters.Add("@piso", SqlDbType.Int).Value = piso;
            cmd.Parameters.Add("@ubicacion", SqlDbType.NVarChar).Value = ubicacion;
            cmd.Parameters.Add("@descripcion", SqlDbType.NVarChar).Value = descripcion;

            var valorDeRetorno = cmd.Parameters.Add("@ReturnVal", SqlDbType.Int);
            valorDeRetorno.Direction = ParameterDirection.ReturnValue;

            DBhelper.abrirConexion();

            DBhelper.ejecutarProcedure(cmd);

            DBhelper.cerrarConexion();

            return (int)valorDeRetorno.Value;
        }


        public void darBajaHabitacion(Int32 idHotel, Int32 numeroHab) {

            DBhelper.crearConexion();
            SqlCommand cmd = DBhelper.crearCommand("TRAEME_LA_COPA_MESSI.darBajaHabitacion");
            cmd.Parameters.Add("@idHotel", SqlDbType.Int).Value = idHotel;
            cmd.Parameters.Add("@numeroHab", SqlDbType.Int).Value = numeroHab;

            DBhelper.abrirConexion();

            cmd.ExecuteNonQuery();

            DBhelper.cerrarConexion();
        
        
        }





    }
}
