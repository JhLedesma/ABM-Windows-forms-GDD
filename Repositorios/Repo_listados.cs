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

                consumible.idHotel = row.Field<Int32>("Fact_idHotel");
                consumible.cant_consumibles = row.Field<Int32>("Cantidad_consumibles");

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




    }
}
