using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaHotel.Model
{
    class ReservaCancelada
    {
        public Int32 numeroreserva { get; set; }
        public String motivo { get; set; }
        public DateTime fechaCancelacion { get; set; }
        public String usuario { get; set; }

   
    }
}
