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
     public class Repo_hotel
    {


        private static Repo_hotel instancia;
        public Utils.DBhelper DBhelper = Utils.DBhelper.getInstancia();

        public static Repo_hotel getInstancia()
        {

            if (instancia != null)
            {
                return instancia;
            }
            else
            {
                instancia = new Repo_hotel();
                return instancia;
            }
        }


        public void crearHotel(String nombre, String mail, Int32 telefono, Int32 estrellas, Int32 porcEstrellas, String calle, Int32 nroCalle, String ciudad, String pais)
        {

            DBhelper.crearConexion();
            SqlCommand cmd = DBhelper.crearCommand("TRAEME_LA_COPA_MESSI.crearHotel");
            cmd.Parameters.Add("@nombre", SqlDbType.NVarChar).Value = nombre;
            cmd.Parameters.Add("@mail", SqlDbType.NVarChar).Value = mail;
            cmd.Parameters.Add("@telefono", SqlDbType.Int).Value = telefono;
            cmd.Parameters.Add("@estrellas", SqlDbType.Int).Value = estrellas;
            cmd.Parameters.Add("@porcEstrellas", SqlDbType.Int).Value = porcEstrellas;
            cmd.Parameters.Add("@calle", SqlDbType.NVarChar).Value = calle;
            cmd.Parameters.Add("@nroCalle", SqlDbType.Int).Value = nroCalle;
            cmd.Parameters.Add("@ciudad", SqlDbType.NVarChar).Value = ciudad;
            cmd.Parameters.Add("@pais", SqlDbType.NVarChar).Value = pais;

            DBhelper.abrirConexion();

            cmd.ExecuteNonQuery();

            DBhelper.cerrarConexion();
        }

        public void agregarRegimenHotel(String nombre, String mail, Int32 telefono, String regimen)
        {

            DBhelper.crearConexion();
            SqlCommand cmd = DBhelper.crearCommand("TRAEME_LA_COPA_MESSI.agregarRegimenHotel");
            cmd.Parameters.Add("@nombre", SqlDbType.NVarChar).Value = nombre;
            cmd.Parameters.Add("@mail", SqlDbType.NVarChar).Value = mail;
            cmd.Parameters.Add("@telefono", SqlDbType.Int).Value = telefono;
            cmd.Parameters.Add("@regimen", SqlDbType.NVarChar).Value = regimen;

            DBhelper.abrirConexion();

            cmd.ExecuteNonQuery();

            DBhelper.cerrarConexion();
        }


        public DataTable getTablaHotelesFiltrados(String nombre, String ciudad, String pais, String estrellas)
        {

            DataTable tablaClientesFiltrados;

            DBhelper.crearConexion();

            DBhelper.abrirConexion();

            SqlCommand cmd = DBhelper.crearCommand("TRAEME_LA_COPA_MESSI.getHotelesFiltrados");
            cmd.Parameters.Add("@Nombre", SqlDbType.NVarChar).Value = nombre;
            cmd.Parameters.Add("@Ciudad", SqlDbType.NVarChar).Value = ciudad;
            cmd.Parameters.Add("@Pais", SqlDbType.NVarChar).Value = pais;
            cmd.Parameters.Add("@Estrellas", SqlDbType.NVarChar).Value = estrellas;

            tablaClientesFiltrados = DBhelper.obtenerTabla(cmd);

            DBhelper.cerrarConexion();

            return tablaClientesFiltrados;

        }

        public Int32 darBajaHotel(int idHotel, DateTime fechaInicio, DateTime fechaFin, String descripcion)
        {

            DBhelper.crearConexion();

            SqlCommand cmd = DBhelper.crearCommand("TRAEME_LA_COPA_MESSI.darBajaHotel");
            cmd.Parameters.Add("@hotelId", SqlDbType.Int).Value = idHotel;
            cmd.Parameters.Add("@descripcion", SqlDbType.NVarChar).Value = descripcion;
            cmd.Parameters.Add("@fechaInicio", SqlDbType.DateTime).Value = fechaInicio;
            cmd.Parameters.Add("@fechaFin", SqlDbType.DateTime).Value = fechaFin;

            var valorDeRetorno = cmd.Parameters.Add("@ReturnVal", SqlDbType.Int);
            valorDeRetorno.Direction = ParameterDirection.ReturnValue;

            DBhelper.abrirConexion();

            DBhelper.ejecutarProcedure(cmd);

            DBhelper.cerrarConexion();

            return (int)valorDeRetorno.Value;

        }

  /*      public List<Model.Hotel> getFuncionalidades()
        {

            DataTable Funcionalidades;

            List<Model.Funcionalidad> listaDeFuncionalidades = new List<Model.Funcionalidad>();

            DBhelper.crearConexion();

            SqlCommand cmd = DBhelper.crearCommand("TRAEME_LA_COPA_MESSI.getFuncionalidades");

            DBhelper.abrirConexion();

            Funcionalidades = DBhelper.obtenerTabla(cmd);

            DBhelper.cerrarConexion();
            foreach (DataRow row in Funcionalidades.Rows)
            {
                Model.Funcionalidad funcionalidad = new Model.Funcionalidad();

                funcionalidad.idFunc = row.Field<Int32>("IdFunc");
                funcionalidad.descripcion = row.Field<String>("Descripcion");
                funcionalidad.estado = Convert.ToInt16(row["Estado"]);

                listaDeFuncionalidades.Add(funcionalidad);
            }

            return listaDeFuncionalidades;

        }*/


    }
}
