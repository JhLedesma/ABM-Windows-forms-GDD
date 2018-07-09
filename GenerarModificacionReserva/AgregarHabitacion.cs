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
        Model.TipoHabitacion habitacion;
        Generar_Reserva_Guest vista;

        public AgregarHabitacion(Model.TipoHabitacion tipoHabitacion, Generar_Reserva_Guest vista)
        {
            InitializeComponent();
            habitacion = tipoHabitacion;
            this.vista = vista;
            configuarComboBoxTipoHabitacion();
        }

        public void configuarComboBoxTipoHabitacion()
        {
            this.listadoTipoHabitacion.ValueMember = "Objeto";
            this.listadoTipoHabitacion.DisplayMember = "Descripcion";
            this.listadoTipoHabitacion.DataSource = Repositorios.Repo_habitacion.getInstancia().getTiposHabitaciones();
            this.listadoTipoHabitacion.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnAgregarHabitacion_Click(object sender, EventArgs e)
        {
            Model.TipoHabitacion habitacionSeleccionada = (Model.TipoHabitacion)listadoTipoHabitacion.SelectedValue;

            vista.listaHabitacionesAgregados.Add(habitacionSeleccionada);
            vista.configuarComboBoxTipoHabitacion();

            MessageBox.Show("Agregado");

            this.Hide();
            this.Close();
        }




    }
}
