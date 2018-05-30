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
            String nombrePrueba;
            nombrePrueba = dataGridModificar.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();

            MessageBox.Show(nombrePrueba);
        }
    }
}
