using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace FrbaHotel.Repositorios
{
    public class RepoTipoDocumento
    {
        private static RepoTipoDocumento instancia;
        public Utils.DBhelper DBhelper = Utils.DBhelper.getInstancia();


        public static RepoTipoDocumento getInstancia()
        {
            if (instancia != null)
            {
                return instancia;
            }
            else
            {
                instancia = new RepoTipoDocumento();
                return instancia;
            } 
        }

        public List<Model.TipoDocumento> getTipoDocumentos()
        {
            DBhelper.crearConexion();

            DBhelper.abrirConexion();

            SqlCommand cmd = DBhelper.crearCommand("TRAEME_LA_COPA_MESSI.getTipoDocumentos");

            DataTable tablaTipoDoc = DBhelper.obtenerTabla(cmd);

            List<Model.TipoDocumento> listaTipoDoc = new List<Model.TipoDocumento>();

            foreach (DataRow row in tablaTipoDoc.Rows)
            {
                Model.TipoDocumento tipoDoc = new Model.TipoDocumento();

                tipoDoc.id = (Int32)row["IdTipo"];
                tipoDoc.descripcion = (String)row["Descripcion"];

                listaTipoDoc.Add(tipoDoc);
            }

            DBhelper.cerrarConexion();

            return listaTipoDoc;
        }



    }
}
