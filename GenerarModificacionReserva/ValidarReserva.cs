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
    public partial class ValidarReserva : Form
    {
        Model.Usuario usuarioIngresado;

        public ValidarReserva()
        {
            InitializeComponent();
        }

        public ValidarReserva(Model.Usuario usuario)
        {
            InitializeComponent();
            this.usuarioIngresado = usuario;
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            int retorno = Repositorios.Repo_Reserva.getInstancia().comprobarSiReservaNoPasoFecha(numReserva.Value, ConfigurationManager.AppSettings["fecha"]);
            
            if (retorno == 1)
            {
                if (usuarioIngresado == null)
                {
                    new ModificarReserva(numReserva.Value).ShowDialog();
                }
                else
                {
                    new ModificarReserva(usuarioIngresado, numReserva.Value).ShowDialog();
                }
           
            }
            else if (retorno == 2)
            {
                MessageBox.Show("Ya no se puede modificar la reserva, el tiempo maximo es hasta un dia antes de la fecha elegida", "Fecha de modificacion de Reserva superada", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("La reserva ingresada no existe Reserva", "No existe Reserva", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.Hide();
            this.Close();
        }
    }
}
