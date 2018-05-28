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
    public class Repo_regimen
    {

        public static Repo_regimen instancia;
        public Utils.DBhelper DBhelper = Utils.DBhelper.getInstancia();

        public static Repo_regimen getInstancia()
        {

            if (instancia != null)
            {
                return instancia;
            }
            else
            {
                instancia = new Repo_regimen();
                return instancia;
            }
        }

        public List<Model.Regimen> getRegimenes()
        {

            DataTable tablaRoles;
            List<Model.Regimen> listaDeRegimenes = new List<Model.Regimen>();

            DBhelper.crearConexion();

            SqlCommand cmd = DBhelper.crearCommand("TRAEME_LA_COPA_MESSI.getRegimenes");

            DBhelper.abrirConexion();

            tablaRoles = DBhelper.obtenerTabla(cmd);

            foreach (DataRow row in tablaRoles.Rows)
            {

                Model.Regimen regimen = new Model.Regimen();

                regimen.idRegimen = ((Int32)row["IdRegimenEstadia"]);
                regimen.descripcion = ((String)row["Descripcion"]);
                regimen.precioBase = ((Int32)row["PrecioBase"]);

                listaDeRegimenes.Add(regimen);
            }

            DBhelper.cerrarConexion();

            return listaDeRegimenes;

        }


    }
}
