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
    class Repo_Funcionalidad
    {
        public static Repo_Funcionalidad instancia;
        public Utils.DBhelper DBhelper = Utils.DBhelper.getInstancia();

        public static Repo_Funcionalidad getInstancia()
        {

            if (instancia != null)
            {
                return instancia;
            }
            else
            {
                instancia = new Repo_Funcionalidad();
                return instancia;
            }
        }

        public List<Model.Funcionalidad> getFuncionalidades()
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

        }


    }
}
