using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaHotel.Model
{
    public class EstadoReserva
    {
        int id { get; set; }
        String descripcion { get; set; }

        public EstadoReserva(int id, String desc)
        {
            this.id = id;
            this.descripcion = desc;
        }
    }


}
