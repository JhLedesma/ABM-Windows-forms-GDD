using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaHotel.AbmUsuario
{
    public partial class BajaUsuario : Form
    {
        String usernameSeleccionado;
        ListadoEliminar listadoEliminar;

        public BajaUsuario(String username, ListadoEliminar listadoEliminar)
        {
            InitializeComponent();
            usernameSeleccionado = username;
            this.listadoEliminar = listadoEliminar;
            tbIdUsuario.Text = usernameSeleccionado;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Repositorios.Repo_usuario.getInstancia().darBajaUsuario(usernameSeleccionado);

            this.Hide();
            this.Close();

            MessageBox.Show("Usuario dado de baja correctamente");

            listadoEliminar.vaciarDataGrid();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }
    }
}
