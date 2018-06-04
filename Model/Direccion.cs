using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaHotel.Model
{
    public class Direccion
    {
        public int id { get; set; }
        public String calle { get; set; }
        public String localidad { get; set; }
        public String ciudad { get; set; }
        public String pais { get; set; }
        public String dpto { get; set; }
        public decimal numDomicilio { get; set; }
        public decimal piso { get; set; }

        public Direccion(int id, String calle, String localidad, String ciudad, String pais, String dpto, decimal numDomicilio, decimal piso)
        {
            this.id = id;
            this.calle = calle;
            this.localidad = localidad;
            this.ciudad = ciudad;
            this.pais = pais;
            this.dpto = dpto;
            this.numDomicilio = numDomicilio;
            this.piso = piso;
        }

        public Direccion() { }
    }
}
