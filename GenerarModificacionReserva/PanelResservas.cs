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
    public partial class PanelResservas : Form
    {
        Model.Usuario usuario = Repositorios.Repo_usuario.getInstancia().getUsuarioIngresado();

        public PanelResservas()
        {
            InitializeComponent();
        }

        private void boton_reservar_Click(object sender, EventArgs e)
        {
            new GenerarModificacionReserva.Generar_Reserva_Guest(usuario).ShowDialog();
            this.Close();
        }

        private void boton_modificar_Click(object sender, EventArgs e)
        {
            new GenerarModificacionReserva.ValidarReserva(usuario).ShowDialog();
            this.Close();
        }

        private void boton_volver_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login.SeleccionarFuncionalidad().ShowDialog();
            this.Close();
        }
    }
}
