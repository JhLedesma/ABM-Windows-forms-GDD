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
    public partial class MostrarCodigoReserva : Form
    {
        Model.Usuario usuario;

        public MostrarCodigoReserva(int idReserva)
        {
            InitializeComponent();
            tbReserva.Text = idReserva.ToString();
        }

        public MostrarCodigoReserva(int idReserva, Model.Usuario usuario)
        {
            InitializeComponent();
            tbReserva.Text = idReserva.ToString();
            this.usuario = usuario;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (usuario == null)
            {
                new Login.SeleccionarFuncionalidad_invitado().ShowDialog();
            }
            else
            {
                new GenerarModificacionReserva.PanelResservas().ShowDialog();
            }
            this.Close();
        }
    }
}
