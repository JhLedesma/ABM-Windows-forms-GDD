using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaHotel.Model
{
   public class TipoHabitacion
    {
       public String descripcion { get; set; }
       public Int32 codigo { get; set; }
       public decimal porcentual { get; set; }


               public TipoHabitacion(String desc, Int32 cod, Int32 porcent)
        {

            descripcion = desc;
            codigo = cod;
            porcentual = porcent;

            
        }

        public TipoHabitacion() { }

       public string Descripcion //Este metodo es el que usa el selector para mostrar los nombres del objeto,
       {

           get
           {
               return descripcion;
           }
       }


       public TipoHabitacion Objeto
       {

           get
           {
               return this;
           }
       }

       public Int32 Codigo
       {

           get
           {
               return codigo;
           }
       }
    }
}
