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

    }
}
