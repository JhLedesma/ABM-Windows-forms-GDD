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


        public void crearHotel(String nombre, String mail, Int32 telefono, Int32 estrellas, Int32 porcEstrellas, String regimen, String calle, Int32 nroCalle, String ciudad, String pais)
        {

            DBhelper.crearConexion();
            SqlCommand cmd = DBhelper.crearCommand("TRAEME_LA_COPA_MESSI.crearHotel");
            cmd.Parameters.Add("@nombre", SqlDbType.NVarChar).Value = nombre;
            cmd.Parameters.Add("@mail", SqlDbType.NVarChar).Value = mail;
            cmd.Parameters.Add("@telefono", SqlDbType.Int).Value = telefono;
            cmd.Parameters.Add("@estrellas", SqlDbType.Int).Value = estrellas;
            cmd.Parameters.Add("@porcEstrellas", SqlDbType.Int).Value = porcEstrellas;
            cmd.Parameters.Add("@regimen", SqlDbType.NVarChar).Value = regimen;
            cmd.Parameters.Add("@calle", SqlDbType.NVarChar).Value = calle;
            cmd.Parameters.Add("@nroCalle", SqlDbType.Int).Value = nroCalle;
            cmd.Parameters.Add("@ciudad", SqlDbType.NVarChar).Value = ciudad;
            cmd.Parameters.Add("@pais", SqlDbType.NVarChar).Value = pais;

            DBhelper.abrirConexion();

            cmd.ExecuteNonQuery();

            DBhelper.cerrarConexion();
        }


    }
}
