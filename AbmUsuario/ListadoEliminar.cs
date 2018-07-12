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
    public partial class ListadoEliminar : Form
    {
        String username;

        public ListadoEliminar()
        {
            InitializeComponent();
        }

        private void lblFiltrar_Click(object sender, EventArgs e)
        {
            dataGridModificar.DataSource = Repositorios.Repo_usuario.getInstancia().getTablaUsuariosFiltradosSinInactivos(filtroNombre.Text, filtroApellido.Text, filtroUsername.Text, numericUpDown1.Value);
        }

        private void dataGridModificar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            username = Convert.ToString(dataGridModificar.Rows[e.RowIndex].Cells["Username"].Value);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (username == null)
            {
                MessageBox.Show("Por favor, seleccione de la grilla un cliente a dar de baja clickeando en cualquiera de sus atributos", "Seleccione cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                new AbmUsuario.BajaUsuario(username, this).ShowDialog();
            }
        }

        public void vaciarDataGrid()
        {
            dataGridModificar.DataSource = Repositorios.Repo_usuario.getInstancia().getTablaUsuariosFiltradosConInactivos(filtroNombre.Text, filtroApellido.Text, filtroUsername.Text, numericUpDown1.Value);
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login.SeleccionarFuncionalidad_admin().ShowDialog();
            this.Close();
        }


    }
}
