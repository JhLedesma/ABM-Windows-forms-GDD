using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaHotel.Model
{
   public class Funcionalidad
    {
        public Int32 idFunc {get;set;}
        public String descripcion {get;set;}
        public Int16 estado {get;set;}


        public Funcionalidad(String descripcion_, Int32 id,Int16 estado_)
        {

            descripcion = descripcion_;
            idFunc = id;
            estado = estado_;

            
        }

        public Funcionalidad() { }

        public string getDescripcion //Este metodo es el que usa el selector para mostrar los nombres del objeto,
        
        {

            get
            {
                return descripcion;
            }
        }


        public Funcionalidad Objeto
        {

            get
            {
                return this;
            }
        }

    }
    }

