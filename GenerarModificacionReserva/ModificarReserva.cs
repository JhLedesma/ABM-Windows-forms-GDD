using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaHotel.GenerarModificacionReserva
{
    public partial class ModificarReserva : Form
    {
        decimal idReservaModidicacion = 0;
        Model.Usuario usuarioLogueado;
        public List<Model.TipoHabitacion> listaTipoHabitacionesAgregadas { get; set; }
        public List<Model.Habitacion> listaHabitacionesAgregadas { get; set; }
        public List<Model.Habitacion> listaHabitacionesDisponibles { get; set; }

        public ModificarReserva(decimal idReserva)
        {
            InitializeComponent();
        }

        public ModificarReserva(Model.Usuario usuario, decimal idReserva)
        {
            InitializeComponent();
        }




    }
}
