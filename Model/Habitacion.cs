using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaHotel.Model
{
    public class Habitacion
    {

        public Int32 idHotel { get; set; }
        public String ubicacion { get; set; }
        public String descripcion { get; set; }
        public Int32 piso { get; set; }
        public Int32 numero { get; set; }
        public Int16 estado { get; set; }
        public Model.TipoHabitacion tipoHab { get; set; }


        public Habitacion() { }

    }
}
