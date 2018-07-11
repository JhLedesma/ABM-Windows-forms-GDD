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
    public partial class AgregarHabitacion : Form
    {
        Model.TipoHabitacion tipoHabitacion;
        Generar_Reserva_Guest vista;


        public AgregarHabitacion(Generar_Reserva_Guest vista)
        {
            InitializeComponent();
            this.vista = vista;
            configuarComboBoxTipoHabitacion();
        }

        public void configuarComboBoxTipoHabitacion()
        {
            List<Model.TipoHabitacion> listaTipoHab = vista.listaHabitacionesDisponibles.Select(x => x.tipoHab).ToList();

            List<Model.TipoHabitacion> listaSinRepetidos = 
                (from t in listaTipoHab
                 group t by new { t.Codigo, t.Descripcion, t.porcentual } into grupo
                 where grupo.Count() > 1
                 select new Model.TipoHabitacion()
                 {
                    codigo = grupo.Key.Codigo,
                    descripcion = grupo.Key.Descripcion,
                    porcentual = grupo.Key.porcentual
                 }
                ).OrderBy(x=>x.codigo).ToList();


            this.listadoTipoHabitacion.ValueMember = "Objeto";
            this.listadoTipoHabitacion.DisplayMember = "Descripcion";
            this.listadoTipoHabitacion.DataSource = listaSinRepetidos;
            this.listadoTipoHabitacion.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnAgregarHabitacion_Click(object sender, EventArgs e)
        {
            Model.TipoHabitacion tipoHabitacionSeleccionada = (Model.TipoHabitacion)listadoTipoHabitacion.SelectedValue;

            Model.Habitacion habEliminar = new Model.Habitacion();

            foreach (Model.Habitacion h in vista.listaHabitacionesDisponibles)
            {
                if (h.tipoHab.codigo == tipoHabitacionSeleccionada.codigo)
                {
                    vista.listaTipoHabitacionesAgregadas.Add(tipoHabitacionSeleccionada);
                    vista.configuarComboBoxTipoHabitacion();

                    vista.listaHabitacionesAgregadas.Add(h);
                    habEliminar = h;

                    break;
                }
            }

            vista.listaHabitacionesDisponibles.Remove(habEliminar);

            vista.actualizarCostoHabitacion();

            vista.ponerPrimerElementoEnSelector();

            MessageBox.Show("Agregado");

            this.Hide();
            this.Close();
        }




    }
}
