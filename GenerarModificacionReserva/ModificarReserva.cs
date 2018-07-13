using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace FrbaHotel.GenerarModificacionReserva
{
    public partial class ModificarReserva : Form, GenerarReserva
    {
        decimal idReservaModidicacion = 0;
        Model.Hotel hotelSeleccionado;
        Model.Regimen regimenSeleccionado;
        Model.Usuario usuarioLogueado;
        public List<Model.TipoHabitacion> listaTipoHabitacionesAgregadas { get; set; }
        public List<Model.Habitacion> listaHabitacionesAgregadas { get; set; }
        public List<Model.Habitacion> listaHabitacionesDisponibles { get; set; }

        public ModificarReserva(decimal idReserva)
        {
            InitializeComponent();
            configuarComboBoxHotel();
            configuarComboBoxTipoHabitacion();
            hotelSeleccionado = (Model.Hotel)listadoHoteles.SelectedValue;
            listaTipoHabitacionesAgregadas = new List<Model.TipoHabitacion>();
            listaHabitacionesDisponibles = new List<Model.Habitacion>();
            listaHabitacionesAgregadas = new List<Model.Habitacion>();
            this.idReservaModidicacion = idReserva;
        }

        public ModificarReserva(Model.Usuario usuario, decimal idReserva)
        {
            InitializeComponent();
            configuarComboBoxHotel();
            configuarComboBoxTipoHabitacion();
            hotelSeleccionado = (Model.Hotel)listadoHoteles.SelectedValue;
            listaTipoHabitacionesAgregadas = new List<Model.TipoHabitacion>();
            listaHabitacionesDisponibles = new List<Model.Habitacion>();
            listaHabitacionesAgregadas = new List<Model.Habitacion>();
            this.usuarioLogueado = usuario;
            this.configurarVistaConUsuario();
            this.idReservaModidicacion = idReserva;
        }


        private void btnRegimen_Click(object sender, EventArgs e)
        {
            hotelSeleccionado = (Model.Hotel)listadoHoteles.SelectedValue;
            new GenerarModificacionReserva.ListadoRegimenes(this, hotelSeleccionado.idHotel).ShowDialog();
        }

        public void configuarComboBoxHotel()
        {
            this.listadoHoteles.ValueMember = "Objeto";
            this.listadoHoteles.DisplayMember = "IdHotel";
            this.listadoHoteles.DataSource = Repositorios.Repo_hotel.getInstancia().getHoteles();
            this.listadoHoteles.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        public void configuarComboBoxTipoHabitacion()
        {
            listadoTipoHabitacion.DataSource = null;
            this.listadoTipoHabitacion.ValueMember = "Objeto";
            this.listadoTipoHabitacion.DisplayMember = "Descripcion";
            this.listadoTipoHabitacion.DataSource = listaTipoHabitacionesAgregadas;
            this.listadoTipoHabitacion.DropDownStyle = ComboBoxStyle.DropDownList;
            //if (listaHabitacionesAgregadas.Count > 0) { listadoTipoHabitacion.SelectedItem = listaHabitacionesAgregadas.First(); };
        }

        private void configurarVistaConUsuario()
        {
            listadoHoteles.SelectedItem = usuarioLogueado.hotelActivo;
            listadoHoteles.Enabled = false;
        }

        public void actualizarRegimen(Model.Regimen regimen)
        {
            regimenSeleccionado = regimen;

            this.actualizarTbRegimen(regimen.descripcion);

            decimal sumatoriaPorcentualHabitacion = listaHabitacionesAgregadas.Sum(x => x.tipoHab.porcentual);
            hotelSeleccionado = (Model.Hotel)listadoHoteles.SelectedValue;

            decimal costoPorDia = (regimen.precioBase * sumatoriaPorcentualHabitacion) + hotelSeleccionado.porcEstrella;

            this.actualizarTbCostoDeHabitacion(costoPorDia.ToString());
        }

        private void actualizarTbRegimen(String regimenDescripcion)
        {
            tbRegimen.Text = regimenDescripcion;
        }

        private void actualizarTbCostoDeHabitacion(String costo)
        {
            lblCostoHabitacion.Text = costo;
        }

        private void actualizarRegimen_Click(object sender, EventArgs e)
        {
            if (regimenSeleccionado != null)
            {
                this.actualizarRegimen(regimenSeleccionado);
            }
        }

        private void resetearPorCambioDeHotel(object sender, EventArgs e)
        {
            listaTipoHabitacionesAgregadas.Clear();
            listaHabitacionesDisponibles = new List<Model.Habitacion>();
            listaHabitacionesAgregadas = new List<Model.Habitacion>();

            configuarComboBoxTipoHabitacion();

            lblCostoHabitacion.Text = "0.00";
        }

        public void ponerPrimerElementoEnSelector()
        {
            listadoTipoHabitacion.SelectedItem = listaTipoHabitacionesAgregadas.First();
        }

        public void actualizarCostoHabitacion()
        {
            if (regimenSeleccionado != null)
            {
                this.actualizarRegimen(regimenSeleccionado);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (listaTipoHabitacionesAgregadas.Count == 0)
            {
                MessageBox.Show("Por favor seleccione un tipo de habitacion a reservar", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (regimenSeleccionado != null)
            {
                this.avanzarPaso2();
            }
            else
            {
                hotelSeleccionado = (Model.Hotel)listadoHoteles.SelectedValue;

                new GenerarModificacionReserva.ListadoRegimenes(this, hotelSeleccionado.idHotel).ShowDialog();
                if (regimenSeleccionado != null)
                {
                    this.avanzarPaso2();
                }
            }
        }


        private void btnModificar_Click(object sender, EventArgs e)
        {
            this.volverPaso1();
        }

        private void volverPaso1()
        {
            lblFechaDesde.Enabled = true;
            dtDesde.Enabled = true;
            lblHasta.Enabled = true;
            dtHasta.Enabled = true;
            lblHotel.Enabled = true;
            if (usuarioLogueado == null)
            {
                listadoHoteles.Enabled = true;
            }
            lblTipoDeHabitacion.Enabled = true;
            listadoTipoHabitacion.Enabled = true;
            lblRegimen.Enabled = true;
            btnRegimen.Enabled = true;
            lblHabitacionPorDia.Enabled = true;
            lblCostoHabitacion.Enabled = true;

            btnAgregarHabitacion.Enabled = true;
            btnQuitarHabitacion.Enabled = true;
            btnGuardar.Enabled = true;
            btnModificar.Enabled = false;
            groupBox2.Enabled = false;
        }

        private void avanzarPaso2()
        {
            lblFechaDesde.Enabled = false;
            dtDesde.Enabled = false;
            lblHasta.Enabled = false;
            dtHasta.Enabled = false;
            lblHotel.Enabled = false;
            if (usuarioLogueado == null)
            {
                listadoHoteles.Enabled = false;
            }
            lblTipoDeHabitacion.Enabled = false;
            listadoTipoHabitacion.Enabled = false;
            lblRegimen.Enabled = false;
            btnRegimen.Enabled = false;
            lblHabitacionPorDia.Enabled = false;
            lblCostoHabitacion.Enabled = false;

            btnAgregarHabitacion.Enabled = false;
            btnQuitarHabitacion.Enabled = false;
            btnGuardar.Enabled = false;
            btnModificar.Enabled = true;
            groupBox2.Enabled = true;

            this.mostrarCostoTotalReserva();
        }

        private void mostrarCostoTotalReserva()
        {
            TimeSpan ts = dtHasta.Value - dtDesde.Value;
            int diferenciaDeDias = ts.Days + 1;

            decimal costoTotal = diferenciaDeDias * Convert.ToDecimal(lblCostoHabitacion.Text);
            lblCostoTotal.Text = costoTotal.ToString();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            this.avanzarPaso3();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.volverPaso2();
        }

        private void volverPaso2()
        {
            btnModificar.Enabled = true;
            btnConfirmar.Enabled = true;

            btnCancelar.Enabled = false;
        }

        private void avanzarPaso3()
        {
            btnModificar.Enabled = false;
            btnCancelar.Enabled = true;
            btnConfirmar.Enabled = false;

            btnTerminar.Enabled = true;
        }

        public void actualizarTbCliente(Model.Cliente cliente)
        {
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login.SeleccionarFuncionalidad_invitado().ShowDialog();
            this.Close();
        }

        private void btnAgregarHabitacion_Click(object sender, EventArgs e)
        {
            int var = 0;

            Model.Hotel hotelSeleccionado = (Model.Hotel)listadoHoteles.SelectedValue;

            if (listaHabitacionesDisponibles.Count == 0)
            {
                listaHabitacionesDisponibles = Repositorios.Repo_Reserva.getInstancia().getHabitacionesEnFechaModificacion(dtDesde.Value, dtHasta.Value, hotelSeleccionado.idHotel, idReservaModidicacion);
                if (listaHabitacionesDisponibles.Count == 0)
                {
                    var = 1;
                    MessageBox.Show("Por favor seleccione otra fecha de reserva", "No hay Habitaciones Disponibles", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (var != 1)
            {
                new AgregarHabitacion(this).ShowDialog();
            }
        }


        private void btnQuitarHabitacion_Click(object sender, EventArgs e)
        {
            listaTipoHabitacionesAgregadas.Clear();
            listaHabitacionesDisponibles = new List<Model.Habitacion>();
            listaHabitacionesAgregadas = new List<Model.Habitacion>();

            configuarComboBoxTipoHabitacion();

            lblCostoHabitacion.Text = "0.00";
        }


        private void btnTerminar_Click(object sender, EventArgs e)
        {
            Model.Hotel hotelSeleccionado = (Model.Hotel)listadoHoteles.SelectedValue;

            Model.Reserva reservaCreada = new Model.Reserva();
            reservaCreada.fechaDesde = dtDesde.Value;
            reservaCreada.fechaHasta = dtHasta.Value;
            reservaCreada.hotel = hotelSeleccionado;
            reservaCreada.regimen = regimenSeleccionado;
            reservaCreada.habitaciones = listaHabitacionesAgregadas;


            reservaCreada.id = Convert.ToInt32(idReservaModidicacion);

            Repositorios.Repo_Reserva.getInstancia().modificarReserva(reservaCreada, ConfigurationManager.AppSettings["fecha"]);

            Repositorios.Repo_Reserva.getInstancia().registrarModificacion(usuarioLogueado, reservaCreada.id, ConfigurationManager.AppSettings["fecha"]);

            MessageBox.Show("Reserva " + reservaCreada.id.ToString() + " Modificada Correctamente");

            this.Hide();
            this.Close();
        }















    }
}
