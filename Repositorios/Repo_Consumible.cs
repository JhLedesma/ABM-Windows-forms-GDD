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
    class Repo_Consumible
    {
        private static Repo_Consumible instancia;
        public Utils.DBhelper DBhelper = Utils.DBhelper.getInstancia();


        public static Repo_Consumible getInstancia()
        {
            if (instancia != null)
            {
                return instancia;
            }
            else
            {
                instancia = new Repo_Consumible();
                return instancia;
            }
        }


        public List<Model.Consumible> getConsumibles()
        {

            DataTable Tconsumibles;
            List<Model.Consumible>consumibles= new List<Model.Consumible>();
            DBhelper.crearConexion();
            DBhelper.abrirConexion();
            SqlCommand cmd = DBhelper.crearCommand("TRAEME_LA_COPA_MESSI.getConsumibles");
            Tconsumibles = DBhelper.obtenerTabla(cmd);
            DBhelper.cerrarConexion();
            foreach (DataRow row in Tconsumibles.Rows)
            {
                Model.Consumible consumible = new Model.Consumible();
                consumible.nombre = (String)row["Descripcion"];
                consumible.id = (Decimal)row["IdConsumible"];
                consumible.precio = (Decimal)row["Precio"];
                consumibles.Add(consumible);
            }
            return consumibles;

        }

        public void facturarConsumible(Int32 numFactura, Model.Consumible consumible) {

            DBhelper.crearConexion();
            SqlCommand cmd = DBhelper.crearCommand("TRAEME_LA_COPA_MESSI.facturarConsumible");
            cmd.Parameters.Add("@idConsumible", SqlDbType.Int).Value = consumible.id;
            cmd.Parameters.Add("@cantidad", SqlDbType.Int).Value = consumible.cantidad;
            cmd.Parameters.Add("@factNum", SqlDbType.Decimal).Value = (decimal)numFactura;

            DBhelper.abrirConexion();

            cmd.ExecuteNonQuery();

            DBhelper.cerrarConexion();
        
        }

        public int crearFactura(Int32 numReserva, Int32 idHotel) {

            DBhelper.crearConexion();

            SqlCommand cmd = DBhelper.crearCommand("TRAEME_LA_COPA_MESSI.crearFactura");
            cmd.Parameters.Add("@numReserva", SqlDbType.Int).Value = numReserva;
            cmd.Parameters.Add("@idHotel", SqlDbType.Int).Value = idHotel;

            var valorDeRetorno = cmd.Parameters.Add("@ReturnVal", SqlDbType.Int);
            valorDeRetorno.Direction = ParameterDirection.ReturnValue;

            DBhelper.abrirConexion();

            DBhelper.ejecutarProcedure(cmd);

            DBhelper.cerrarConexion();

            return (int)valorDeRetorno.Value;
        
        }

        public void facturarEstadia(Int32 idReserva, Int32 numFact)
        {

            DBhelper.crearConexion();
            SqlCommand cmd = DBhelper.crearCommand("TRAEME_LA_COPA_MESSI.facturarEstadia");
            cmd.Parameters.Add("@idReserva", SqlDbType.Int).Value = idReserva;
            cmd.Parameters.Add("@factNum", SqlDbType.Int).Value = numFact;

            DBhelper.abrirConexion();

            cmd.ExecuteNonQuery();

            DBhelper.cerrarConexion();

        }

        public void calcularTotalFactura(Int32 numFactura)
        {

            DBhelper.crearConexion();
            SqlCommand cmd = DBhelper.crearCommand("TRAEME_LA_COPA_MESSI.calcularTotalFactura");
            cmd.Parameters.Add("@numFactura", SqlDbType.Int).Value = numFactura;

            DBhelper.abrirConexion();

            cmd.ExecuteNonQuery();

            DBhelper.cerrarConexion();

        }

        public Int32 condicionAllInclusive(Int32 numReserva)
        {
            DBhelper.crearConexion();
            SqlCommand cmd = DBhelper.crearCommand("TRAEME_LA_COPA_MESSI.verificarAllInclusive");
            cmd.Parameters.Add("@numReserva", SqlDbType.Int).Value = numReserva;

            var valorDeRetorno = cmd.Parameters.Add("@ReturnVal", SqlDbType.Int);
            valorDeRetorno.Direction = ParameterDirection.ReturnValue;
            DBhelper.abrirConexion();

            DBhelper.ejecutarProcedure(cmd);

            DBhelper.cerrarConexion();

            return (int)valorDeRetorno.Value;
        }

        public void descontarConsumibles(Int32 numFactura)
        {
            DBhelper.crearConexion();
            SqlCommand cmd = DBhelper.crearCommand("TRAEME_LA_COPA_MESSI.DescontarConsumibles");
            cmd.Parameters.Add("@numFactura", SqlDbType.Int).Value = numFactura;

            DBhelper.abrirConexion();

            cmd.ExecuteNonQuery();

            DBhelper.cerrarConexion();

        }

    }
}
