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
    public class Repo_listados
    {


        private static Repo_listados instancia;
        public Utils.DBhelper DBhelper = Utils.DBhelper.getInstancia();

        public static Repo_listados getInstancia()
        {

            if (instancia != null)
            {
                return instancia;
            }
            else
            {
                instancia = new Repo_listados();
                return instancia;
            }
        }

        public List<Model.Puntaje_cliente> getPuntosClientes(Int32 trimestre, Int32 anio)
        {

            DataTable puntajes;

            List<Model.Puntaje_cliente> listaDePuntajes = new List<Model.Puntaje_cliente>();

            DBhelper.crearConexion();

            SqlCommand cmd = DBhelper.crearCommand("TRAEME_LA_COPA_MESSI.topCliente");
            cmd.Parameters.Add("@trimestre", SqlDbType.Int).Value = trimestre;
            cmd.Parameters.Add("@anio", SqlDbType.Int).Value = anio;
            cmd.CommandTimeout = 0;

            DBhelper.abrirConexion();

            puntajes = DBhelper.obtenerTabla(cmd);

            DBhelper.cerrarConexion();

            foreach (DataRow row in puntajes.Rows)
            {
                Model.Puntaje_cliente puntaje = new Model.Puntaje_cliente();

                puntaje.idCliente = row.Field<Int32>("idCliente");
                puntaje.puntaje = row.Field<Int32>("puntos");

                listaDePuntajes.Add(puntaje);
            }

            return listaDePuntajes;

        }


        public List<Model.Consumibles_hotel> topConsumiblesFacturados(Int32 trimestre, Int32 anio)
        {

            DataTable consumibles;

            List<Model.Consumibles_hotel> listaDeConsumibles = new List<Model.Consumibles_hotel>();

            DBhelper.crearConexion();

            SqlCommand cmd = DBhelper.crearCommand("TRAEME_LA_COPA_MESSI.topConsumiblesFacturados");
            cmd.Parameters.Add("@trimestre", SqlDbType.Int).Value = trimestre;
            cmd.Parameters.Add("@anio", SqlDbType.Int).Value = anio;
            cmd.CommandTimeout = 0;

            DBhelper.abrirConexion();

            consumibles = DBhelper.obtenerTabla(cmd);

            DBhelper.cerrarConexion();

            foreach (DataRow row in consumibles.Rows)
            {
                Model.Consumibles_hotel consumible = new Model.Consumibles_hotel();

                consumible.idHotel = row.Field<Int32>("idHotel");
                consumible.cant_consumibles = row.Field<Int32>("cantidad");

                listaDeConsumibles.Add(consumible);
            }

            return listaDeConsumibles;

        }

        public List<Model.DiasFueraServ_hotel> topDiasFueraDeServicio(Int32 trimestre, Int32 anio)
        {

            DataTable TablaDiasFueraServ;

            List<Model.DiasFueraServ_hotel> listaDiasFueraServ = new List<Model.DiasFueraServ_hotel>();

            DBhelper.crearConexion();

            SqlCommand cmd = DBhelper.crearCommand("TRAEME_LA_COPA_MESSI.topDiasFueraDeServicio");
            cmd.Parameters.Add("@trimestre", SqlDbType.Int).Value = trimestre;
            cmd.Parameters.Add("@anio", SqlDbType.Int).Value = anio;
            cmd.CommandTimeout = 0;

            DBhelper.abrirConexion();

            TablaDiasFueraServ = DBhelper.obtenerTabla(cmd);

            DBhelper.cerrarConexion();

            foreach (DataRow row in TablaDiasFueraServ.Rows)
            {
                Model.DiasFueraServ_hotel diasFueraServ  = new Model.DiasFueraServ_hotel();

                diasFueraServ.idHotel = row.Field<Int32>("IdHotel");
                diasFueraServ.cant_dias = row.Field<Int32>("Dias_fuera_servicio");

                listaDiasFueraServ.Add(diasFueraServ);
            }

            return listaDiasFueraServ;

        }


        public List<Model.Consumibles_hotel> topReservasCanceladas(Int32 trimestre, Int32 anio)
        {

            DataTable TablaReservasCanc;

            List<Model.Consumibles_hotel> listaReservasCanc = new List<Model.Consumibles_hotel>();

            DBhelper.crearConexion();

            SqlCommand cmd = DBhelper.crearCommand("TRAEME_LA_COPA_MESSI.topReservasCanceladas");
            cmd.Parameters.Add("@trimestre", SqlDbType.Int).Value = trimestre;
            cmd.Parameters.Add("@anio", SqlDbType.Int).Value = anio;
            cmd.CommandTimeout = 0;

            DBhelper.abrirConexion();

            TablaReservasCanc = DBhelper.obtenerTabla(cmd);

            DBhelper.cerrarConexion();

            foreach (DataRow row in TablaReservasCanc.Rows)
            {
                Model.Consumibles_hotel reservasCancelados = new Model.Consumibles_hotel();

                reservasCancelados.idHotel = row.Field<Int32>("IdHotel");
                reservasCancelados.cant_consumibles= row.Field<Int32>("Cantidad_cancelaciones");

                listaReservasCanc.Add(reservasCancelados);
            }

            return listaReservasCanc;

        }


        public List<Model.Datos_hab> topHabitaciones(Int32 trimestre, Int32 anio)
        {

            DataTable TablaDatosHab;

            List<Model.Datos_hab> listaDatosHab = new List<Model.Datos_hab>();

            DBhelper.crearConexion();

            SqlCommand cmd = DBhelper.crearCommand("TRAEME_LA_COPA_MESSI.topHabitacionesOcupadas");
            cmd.Parameters.Add("@trimestre", SqlDbType.Int).Value = trimestre;
            cmd.Parameters.Add("@anio", SqlDbType.Int).Value = anio;
            cmd.CommandTimeout = 0;

            DBhelper.abrirConexion();

            TablaDatosHab = DBhelper.obtenerTabla(cmd);

            DBhelper.cerrarConexion();

            foreach (DataRow row in TablaDatosHab.Rows)
            {
                Model.Datos_hab datosHab = new Model.Datos_hab();

                datosHab.IdHotel = row.Field<Int32>("IdHotel");
                datosHab.NumHabitacion = row.Field<Int32>("NumeroHabitacion");
                datosHab.VecesReservada = row.Field<Int32>("Cantidad_veces_reservada");
                datosHab.NochesOcupada = row.Field<Int32>("Cantidad_noches_ocupada");

                listaDatosHab.Add(datosHab);
            }

            return listaDatosHab;

        }




    }
}
