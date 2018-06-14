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
    public partial class List_Select_Cliente_Eliminar : Form
    {
        const Int32 VACIO = 0;
        int idClienteSeleccionado;
        string mailClienteSeleccionado;

        public List_Select_Cliente_Eliminar()
        {
            InitializeComponent();
            configuarComboBoxTipoDoc();
        }

        public void configuarComboBoxTipoDoc()
        {
            this.listadoTipoIdentificacion.ValueMember = "Objeto";
            this.listadoTipoIdentificacion.DisplayMember = "Descripcion";
            this.listadoTipoIdentificacion.DataSource = Repositorios.RepoTipoDocumento.getInstancia().getTipoDocumentos();
            this.listadoTipoIdentificacion.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idClienteSeleccionado = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["IdCliente"].Value);
            mailClienteSeleccionado = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["Email"].Value);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (idClienteSeleccionado <= VACIO)
            {
                MessageBox.Show("Por favor, seleccione de la grilla un cliente a eliminar clickeando en cualquiera de sus atributos", "Seleccione cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                new AbmCliente.Baja_Cliente(idClienteSeleccionado, mailClienteSeleccionado, this).ShowDialog();
            }
        }

        private void lblFiltrar_Click(object sender, EventArgs e)
        {
            Model.TipoDocumento tipoDoc = (Model.TipoDocumento)listadoTipoIdentificacion.SelectedValue;

            dataGridView1.DataSource = Repositorios.Repo_Cliente.getInstancia().getTablaClientesFiltradosActivos(filtroNombre.Text, filtroApellido.Text, filtroMail.Text, tipoDoc.id, filtroNumeroIdentificacion.Value);
        }

        public void vaciarDataGrid()
        {
            Model.TipoDocumento tipoDoc = (Model.TipoDocumento)listadoTipoIdentificacion.SelectedValue;
            dataGridView1.DataSource = Repositorios.Repo_Cliente.getInstancia().getTablaClientesFiltradosActivos(filtroNombre.Text, filtroApellido.Text, filtroMail.Text, tipoDoc.id, filtroNumeroIdentificacion.Value);
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            new AbmCliente.Abm_Cliente().ShowDialog();
        }
    }
}
