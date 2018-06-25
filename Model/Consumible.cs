using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaHotel.Model
{
    class Consumible
    {
        public string nombre { get; set; }
        public Int32 cantidad { get; set; }
        public Int32 id { get; set; }
        public Decimal precio { get; set; }

        public void Consumible(string nombre, Int32 cantidad, Int32 id, Int32 precio)
        {
            this.nombre = nombre;
            this.cantidad = cantidad;
            this.id = id;
            this.precio = precio;
        }
    }
}
