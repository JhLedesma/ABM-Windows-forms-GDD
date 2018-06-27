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
    public partial class Listado_Cliente : Form
    {
        GenerarReserva vistaGenerarReserva;
        const Int32 VACIO = 0;
        int idClienteSeleccionado;
        string mailClienteSeleccionado;

        public Listado_Cliente(GenerarReserva vistaGenerarReserva)
        {
            InitializeComponent();
            configuarComboBoxTipoDoc();
            this.vistaGenerarReserva = vistaGenerarReserva;
        }

        public void configuarComboBoxTipoDoc()
        {
            this.listadoTipoIdentificacion.ValueMember = "Objeto";
            this.listadoTipoIdentificacion.DisplayMember = "Descripcion";
            this.listadoTipoIdentificacion.DataSource = Repositorios.RepoTipoDocumento.getInstancia().getTipoDocumentos();
            this.listadoTipoIdentificacion.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void dataGridModificar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idClienteSeleccionado = Convert.ToInt32(dataGridModificar.Rows[e.RowIndex].Cells["IdCliente"].Value);
            mailClienteSeleccionado = Convert.ToString(dataGridModificar.Rows[e.RowIndex].Cells["Email"].Value);

            Model.Cliente clienteSeleccionado = Repositorios.Repo_Cliente.getInstancia().getCliente(idClienteSeleccionado, mailClienteSeleccionado);

            vistaGenerarReserva.actualizarTbCliente(clienteSeleccionado);

            this.Hide();
            this.Close();
        }

        private void lblFiltrar_Click(object sender, EventArgs e)
        {
            Model.TipoDocumento tipoDoc = (Model.TipoDocumento)listadoTipoIdentificacion.SelectedValue;

            dataGridModificar.DataSource = Repositorios.Repo_Cliente.getInstancia().getTablaClientesFiltradosActivos(filtroNombre.Text, filtroApellido.Text, filtroMail.Text, tipoDoc.id, numericUpDown1.Value);
        }


    }
}
