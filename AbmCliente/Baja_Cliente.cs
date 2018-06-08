using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaHotel.AbmCliente
{
    public partial class Baja_Cliente : Form
    {
        int idClienteSeleccionado;

        public Baja_Cliente(int idCliente)
        {
            InitializeComponent();
            idClienteSeleccionado = idCliente;
            tbIdCliente.Text = idCliente.ToString();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Repositorios.Repo_Cliente.getInstancia().darBajaCliente(idClienteSeleccionado);

            this.Hide();
            this.Close();

            MessageBox.Show("Cliente dado de baja correctamente");
        }
    }
}
