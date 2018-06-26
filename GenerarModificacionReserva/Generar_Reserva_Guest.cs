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
        public Generar_Reserva_Guest()
        {
            InitializeComponent();
            configuarComboBoxHotel();
        }

        private void btnRegimen_Click(object sender, EventArgs e)
        {
            Model.Hotel hotelSeleccionado = (Model.Hotel)listadoHoteles.SelectedValue;
            new GenerarModificacionReserva.ListadoRegimenes(this, hotelSeleccionado.idHotel).ShowDialog();
        }

        public void configuarComboBoxHotel()
        {
            this.listadoHoteles.ValueMember = "Objeto";
            this.listadoHoteles.DisplayMember = "IdHotel";
            this.listadoHoteles.DataSource = Repositorios.Repo_hotel.getInstancia().getHoteles();
            this.listadoHoteles.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        public void actualizarTbRegimen(String nombre)
        {
            tbRegimen.Text = nombre;
        }


    }
}
