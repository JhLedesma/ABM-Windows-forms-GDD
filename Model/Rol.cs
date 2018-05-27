using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaHotel.Model
{
    public class Rol
    {
        public Int32 idRol {get;set;}
        public String nombreRol {get;set;}
        public Int16 estado {get;set;}


        public Rol(String nombre, Int32 id)
        {

            nombreRol = nombre;
            idRol = id;
            
        }

        public Rol() { }

    }
}
