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
    public partial class Generar_Reserva_Guest : Form, GenerarReserva
    {
        Model.Hotel hotelSeleccionado;
        Model.Regimen regimenSeleccionado;

        public Generar_Reserva_Guest()
        {
            InitializeComponent();
            configuarComboBoxHotel();
            configuarComboBoxTipoHabitacion();
            hotelSeleccionado = (Model.Hotel)listadoHoteles.SelectedValue;
        }

        private void btnRegimen_Click(object sender, EventArgs e)
        {
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
            this.listadoTipoHabitacion.ValueMember = "Objeto";
            this.listadoTipoHabitacion.DisplayMember = "Descripcion";
            this.listadoTipoHabitacion.DataSource = Repositorios.Repo_habitacion.getInstancia().getTiposHabitaciones();
            this.listadoTipoHabitacion.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        public void actualizarRegimen(Model.Regimen regimen)
        {
            regimenSeleccionado = regimen;

            this.actualizarTbRegimen(regimen.descripcion);

            Model.TipoHabitacion tipoHabitacionSeleccionado = (Model.TipoHabitacion)listadoTipoHabitacion.SelectedValue;
            decimal costoPorDia = (regimen.precioBase * tipoHabitacionSeleccionado.porcentual) + hotelSeleccionado.porcEstrella;
            this.actualizarCostoDeHabitacion(costoPorDia.ToString());
        }

        private void actualizarTbRegimen(String regimenDescripcion)
        {
            tbRegimen.Text = regimenDescripcion;
        }

        private void actualizarCostoDeHabitacion(String costo)
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (regimenSeleccionado != null)
            {
                this.avanzarPaso2();
            }
            else
            {
                new GenerarModificacionReserva.ListadoRegimenes(this, hotelSeleccionado.idHotel).ShowDialog();
                this.avanzarPaso2();
                //MessageBox.Show("Por favor seleccione un regimen", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }  

        private void btnModificar_Click(object sender, EventArgs e)
        {
            this.volverPaso1();
        }


        private void mostrarCostoTotalReserva()
        {
            TimeSpan ts = dtHasta.Value - dtDesde.Value;
            int diferenciaDeDias = ts.Days + 1;

            decimal costoTotal = diferenciaDeDias * Convert.ToDecimal(lblCostoHabitacion.Text);
            lblCostoTotal.Text = costoTotal.ToString(); 
        }


        private void volverPaso1()
        {
            lblFechaDesde.Enabled = true;
            dtDesde.Enabled = true;
            lblHasta.Enabled = true;
            dtHasta.Enabled = true;
            lblHotel.Enabled = true;
            listadoHoteles.Enabled = true;
            lblTipoDeHabitacion.Enabled = true;
            listadoTipoHabitacion.Enabled = true;
            lblRegimen.Enabled = true;
            btnRegimen.Enabled = true;
            lblHabitacionPorDia.Enabled = true;
            lblCostoHabitacion.Enabled = true;

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
            listadoHoteles.Enabled = false;
            lblTipoDeHabitacion.Enabled = false;
            listadoTipoHabitacion.Enabled = false;
            lblRegimen.Enabled = false;
            btnRegimen.Enabled = false;
            lblHabitacionPorDia.Enabled = false;
            lblCostoHabitacion.Enabled = false;

            btnGuardar.Enabled = false;
            btnModificar.Enabled = true;
            groupBox2.Enabled = true;

            this.mostrarCostoTotalReserva();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            this.avanzarPaso3();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.volverPaso2();
        }

        private void avanzarPaso3()
        {
            btnModificar.Enabled = false;
            btnCancelar.Enabled = true;
            btnConfirmar.Enabled = false;

            groupBox3.Enabled = true;
        }

        private void volverPaso2()
        {
            btnModificar.Enabled = true;
            btnCancelar.Enabled = false;
            btnConfirmar.Enabled = true;

            groupBox3.Enabled = false;
        }




    }
}
