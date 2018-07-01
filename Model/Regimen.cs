using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaHotel.Model
{
    public class Regimen
    {

        public Int32 idRegimen {get;set;}
        public String descripcion {get;set;}
        public Int32 precioBase {get;set;}

        public Regimen() { }

      /*  public string Descripcion //Este metodo es el que usa el selector para mostrar los nombres del objeto,
        
        {

            get
            {
                return descripcion;
            }
        }
        */

        public Regimen Objeto
        {

            get
            {
                return this;
            }
        }



    }
}
