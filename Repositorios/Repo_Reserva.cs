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
            DateTime fechaCheckin;
            DBhelper.crearConexion();
            DBhelper.abrirConexion();
            SqlCommand cmd = DBhelper.crearCommand("TRAEME_LA_COPA_MESSI.validarCancelacion");
            cmd.Parameters.Add("@idReserva", SqlDbType.Int).Value = reserva.numeroreserva;
            DataTable fechaRes = DBhelper.obtenerTabla(cmd);
            DBhelper.cerrarConexion();


            if (fechaRes.Rows.Count==0)
            {
                return 1;// No existe tal reserva
            }

            foreach (DataRow row in fechaRes.Rows)
            {
                fechaReserva = ((DateTime)row["FechaReserva"]);
                fechaCheckin = ((DateTime)row["FechaCheckIn"]);

                if ((DateTime.Compare(reserva.fechaCancelacion, fechaReserva) >= 0) || string.IsNullOrEmpty(fechaCheckin.ToString()))
                {
                    return 2; // La cancelacion es demasiado cercana a la fecha de la reserva
                }
            }
            
                DBhelper.crearConexion();
                DBhelper.abrirConexion();
                SqlCommand cmd2 = DBhelper.crearCommand("TRAEME_LA_COPA_MESSI.validarCancelacionUsuario");
                cmd2.Parameters.Add("@usuario", SqlDbType.NVarChar).Value = reserva.usuario;
                var retorno = cmd2.Parameters.Add("@ReturnVal", SqlDbType.Int);
                retorno.Direction = ParameterDirection.ReturnValue;
                DBhelper.ejecutarProcedure(cmd2);
                DBhelper.cerrarConexion();
                if ((int)retorno.Value == 1)
                {
                    return 0; // todo correcto
                }
                else { 
                    return 3; //no existe el usuario
                }
                        
        }

        public void cancelarReserva(Model.ReservaCancelada reserva){
             DBhelper.crearConexion();
            DBhelper.abrirConexion();
            SqlCommand cmd = DBhelper.crearCommand("TRAEME_LA_COPA_MESSI.cancelarReserva");
            cmd.Parameters.Add("@idReserva", SqlDbType.Int).Value = reserva.numeroreserva;
            cmd.Parameters.Add("@nombreUsuario", SqlDbType.NVarChar).Value = reserva.usuario;
            cmd.Parameters.Add("@fechaDeCancelacion", SqlDbType.DateTime).Value = reserva.fechaCancelacion;
            cmd.Parameters.Add("@motivo", SqlDbType.NVarChar).Value = reserva.motivo;
            DBhelper.ejecutarProcedure(cmd);
            DBhelper.cerrarConexion();
        }

        public Int32 comprobarNumReserva(Int32 idHotel, Int32 numeroRes)
        {

            DBhelper.crearConexion();
            SqlCommand cmd = DBhelper.crearCommand("TRAEME_LA_COPA_MESSI.comprobarNumReserva");
            cmd.Parameters.Add("@idHotel", SqlDbType.Int).Value = idHotel;
            cmd.Parameters.Add("@idReserva", SqlDbType.Int).Value = numeroRes;

            var valorDeRetorno = cmd.Parameters.Add("@ReturnVal", SqlDbType.Int);
            valorDeRetorno.Direction = ParameterDirection.ReturnValue;

            DBhelper.abrirConexion();

            DBhelper.ejecutarProcedure(cmd);

            DBhelper.cerrarConexion();

            return (int)valorDeRetorno.Value;

        }


    }
}
    

