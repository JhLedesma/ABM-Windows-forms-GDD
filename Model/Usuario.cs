using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaHotel.Model
{

    public class Usuario
    {
        public String username {get;set;}
        public String password {get;set;}
        public String nombre {get;set;}
        public String apellido {get;set;}
        public Int32 nroDocumento {get;set;}
        public String email {get;set;}
        public Int32 telefono {get;set;}
        public DateTime fechaDeNacimiento {get;set;}
        public Int32 logsFallidos {get;set;}
        public List<Rol> listaDeRoles = new List<Rol>();
        public Rol rolActivo {get;set;}

        public List<Rol> getListaDeRoles()
        {

            return this.listaDeRoles;

        }

        public void setListaDeRoles(List<Rol> listaDeRoles)
        {

            this.listaDeRoles = listaDeRoles;

        }

    }
}
