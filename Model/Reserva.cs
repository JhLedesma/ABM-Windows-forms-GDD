using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaHotel.Model
{
    public class Reserva
    {
        int id { get; set; }
        DateTime fechaEmision { get; set; }
        DateTime fechaDesde { get; set; }
        DateTime fechaHasta { get; set; }
        Model.TipoHabitacion tipoHabitacion { get; set; }
        Model.Regimen regimen { get; set; }
        Model.Hotel hotel { get; set; }
        Model.EstadoReserva estado { get; set; }
        Model.Cliente cliente { get; set; }

        public decimal getCostoTotal()
        {
            TimeSpan ts = fechaHasta - fechaDesde;
            int diferenciaDeDias = ts.Days + 1;

            decimal costoPorDia = (regimen.precioBase * tipoHabitacion.porcentual) + hotel.porcEstrella;

            return diferenciaDeDias * costoPorDia;
        }

        public decimal getCostoPorDia()
        {
            return (regimen.precioBase * tipoHabitacion.porcentual) + hotel.porcEstrella;
        }
    }
}
