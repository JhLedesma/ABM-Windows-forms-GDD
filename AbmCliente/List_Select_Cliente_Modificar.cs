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
    public partial class List_Select_Cliente_Modificar : Form
    {
        const Int32 VACIO = 0;
        int idClienteSeleccionado;
        

        public List_Select_Cliente_Modificar()
        {
            InitializeComponent();
        }

        private void lblFiltrar_Click(object sender, EventArgs e)
        {
            dataGridModificar.DataSource = Repositorios.Repo_Cliente.getInstancia().getTablaClientesFiltrados(filtroNombre.Text, filtroApellido.Text, filtroMail.Text, "", numericUpDown1.Value);
        }

        private void dataGridModificar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idClienteSeleccionado = Convert.ToInt32( dataGridModificar.Rows[e.RowIndex].Cells["IdCliente"].Value);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (idClienteSeleccionado <= VACIO)
            {
                MessageBox.Show("Por favor, seleccione de la grilla una empresa a modificar clickeando en cualquiera de sus atributos", "Seleccione empresa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                new AbmCliente.Modificar_Cliente(idClienteSeleccionado).ShowDialog();
            }
        }



    }
}
