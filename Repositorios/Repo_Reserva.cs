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
    class Repo_Reserva
    {
        public static Repo_Reserva instancia;
        public Utils.DBhelper DBhelper = Utils.DBhelper.getInstancia();
        public static Repo_Reserva getInstancia()
        {

            if (instancia != null)
            {
                return instancia;
            }
            else
            {
                instancia = new Repo_Reserva();
                return instancia;
            }
        }

        public int validarCancelacion(Model.ReservaCancelada reserva)
        {
            DateTime fechaReserva;
            DBhelper.crearConexion();
            DBhelper.abrirConexion();
            SqlCommand cmd = DBhelper.crearCommand("TRAEME_LA_COPA_MESSI.validarCancelacion");
            cmd.Parameters.Add("idReserva", SqlDbType.Int).Value = reserva.numeroreserva;
            DataTable fechaRes = DBhelper.obtenerTabla(cmd);
            DBhelper.cerrarConexion();


            if (fechaRes == null)
            {
                return 1;
            }

            foreach (DataRow row in fechaRes.Rows)
            {
                fechaReserva = ((DateTime)row["FechaReserva"]);

                if (DateTime.Compare(reserva.fechaCancelacion, fechaReserva) >= 0)
                {
                    return 2;
                }}

                DBhelper.crearConexion();
                DBhelper.abrirConexion();
                SqlCommand cmd2 = DBhelper.crearCommand("TRAEME_LA_COPA_MESSI.validarCancelacionUsuario");
                cmd2.Parameters.Add("usuario", SqlDbType.NVarChar).Value = reserva.usuario;
                var retorno = cmd2.Parameters.Add("@ReturnVal", SqlDbType.Int);
                retorno.Direction = ParameterDirection.ReturnValue;
                if ((int)retorno.Value == 1)
                {
                    return 0;
                }
                else { 
                    return 3; 
                }





            }
        }
    }

