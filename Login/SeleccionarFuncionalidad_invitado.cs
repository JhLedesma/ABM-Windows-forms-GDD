using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaHotel.Login
{
    public partial class SeleccionarFuncionalidad_invitado : Form
    {
        public SeleccionarFuncionalidad_invitado()
        {
            InitializeComponent();
        }

        private void boton_volver_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login().ShowDialog();
            this.Close();
        }

        private void boton_reservar_Click(object sender, EventArgs e)
        {
            this.Hide();
            new GenerarModificacionReserva.Generar_Reserva_Guest().ShowDialog();
            this.Close();
        }

        private void boton_modificar_Click(object sender, EventArgs e)
        {
            this.Hide();
            new GenerarModificacionReserva.ValidarReserva().ShowDialog();
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            new CancelarReserva.Form1().ShowDialog();
            this.Close();
        }

    }
}
