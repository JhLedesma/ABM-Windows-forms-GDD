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
        public MostrarCodigoReserva(int idReserva)
        {
            InitializeComponent();
            tbReserva.Text = idReserva.ToString();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }
    }
}
