using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaHotel.Model
{
    public class Cliente
    {
        public int id {get; set;}
        public String nombre { get; set; }
        public String apellido { get; set; }
        public String mail { get; set; }
        public decimal telefono { get; set; }
        public decimal numDoc { get; set; }
        public String tipoDoc { get; set; }
        public String nacionalidad { get; set; }
        public DateTime fechaNac { get; set; }
        public String paisOrigen { get; set; }
        public Model.Direccion direccion { get; set; }

        public Cliente(int id, String nombre, String apellido, String mail, decimal telefono, decimal numDoc, String tipoDoc, String nacionalidad, DateTime fechaNac, String paisOrigen, Model.Direccion direccion)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellido = apellido;
            this.mail = mail;
            this.telefono = telefono;
            this.numDoc = numDoc;
            this.tipoDoc = tipoDoc;
            this.nacionalidad = nacionalidad;
            this.fechaNac = fechaNac;
            this.paisOrigen = paisOrigen;
            this.direccion = direccion;
        }
    }
}
