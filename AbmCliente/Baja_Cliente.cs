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
        string mailClienteSeleccionado;
        private List_Select_Cliente_Eliminar list_Select_Cliente_Eliminar; //Lo recibe para que cuadno un cliente se elimine, se vuelva a filtrar la tabla, para evitar eliminar dos veces el mismo dato y causar un error

        public Baja_Cliente(int idCliente, string mail, List_Select_Cliente_Eliminar list_Select_Cliente_Eliminar)
        {
            InitializeComponent();
            idClienteSeleccionado = idCliente;
            mailClienteSeleccionado = mail;
            this.list_Select_Cliente_Eliminar = list_Select_Cliente_Eliminar;
            tbIdCliente.Text = idCliente.ToString();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Repositorios.Repo_Cliente.getInstancia().darBajaCliente(idClienteSeleccionado, mailClienteSeleccionado);

            this.Hide();
            this.Close();

            MessageBox.Show("Cliente dado de baja correctamente");

            list_Select_Cliente_Eliminar.vaciarDataGrid();
        }
    }
}
