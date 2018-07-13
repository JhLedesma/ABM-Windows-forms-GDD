using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaHotel.GenerarModificacionReserva
{
    public interface GenerarReserva
    {
        void actualizarRegimen(Model.Regimen regimen);
        void actualizarTbCliente(Model.Cliente cliente);
        void configuarComboBoxTipoHabitacion();
        void actualizarCostoHabitacion();
        void ponerPrimerElementoEnSelector();

        List<Model.Habitacion> listaHabitacionesDisponibles { get; set; }
        List<Model.Habitacion> listaHabitacionesAgregadas { get; set; }
        List<Model.TipoHabitacion> listaTipoHabitacionesAgregadas { get; set; }
    }
}
