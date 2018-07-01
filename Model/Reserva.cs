using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaHotel.Model
{
    public class Reserva
    {
        public int id { get; set; }
        public DateTime fechaGeneracion { get; set; }
        public DateTime fechaDesde { get; set; }
        public DateTime fechaHasta { get; set; }
        public Model.TipoHabitacion tipoHabitacion { get; set; }
        public Model.Regimen regimen { get; set; }
        public Model.Hotel hotel { get; set; }
        public Model.EstadoReserva estado { get; set; }
        public Model.Cliente cliente { get; set; }

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
