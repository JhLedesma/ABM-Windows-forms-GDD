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
        public List<Model.Funcionalidad> funcionalidades=new List<Funcionalidad>();


        public Rol(String nombre, Int32 id, Int16 estade)
        {

            nombreRol = nombre;
            idRol = id;
            estado = estade;
        }

        public void agregarFuncionalidad(Model.Funcionalidad funcionalidad)
        {
            funcionalidades.Add(funcionalidad);
        }
            
        public void nuevasFuncionalidades(List<Model.Funcionalidad> Lista){
            this.funcionalidades=Lista;
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
