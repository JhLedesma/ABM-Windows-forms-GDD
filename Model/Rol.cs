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
        public List<Model.Funcionalidad> funcionalidades;


        public Rol(String nombre, Int32 id)
        {

            nombreRol = nombre;
            idRol = id;
            
        }

        public Rol() { }

        public string Nombre //Este metodo es el que usa el selector para mostrar los nombres del objeto,
        
        {

            get
            {
                return nombreRol;
            }
        }


        public Rol Objeto
        {

            get
            {
                return this;
            }
        }

    }
}
