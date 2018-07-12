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


namespace FrbaHotel.RegistrarEstadia
{
    public partial class Check_In : Form
    {

        private Int32 idHotel { get; set; }
        private Int32 numReserva { get; set; }
        private List<Model.Cliente> clientesReserva = new List<Model.Cliente>();
        public Int32 idClienteCreado { get; set; }
        public Model.Cliente clienteFiltrado { get; set; }
        public Int32 idSeleccionado { get; set; }
        public String mailClienteCreado { get; set; }

        public Check_In(Int32 hotel, Int32 reserva)
        {
            idHotel = hotel;
            numReserva = reserva;

            clientesReserva.Add(Repositorios.Repo_Reserva.getInstancia().getClienteReserva(hotel,reserva));
            
            InitializeComponent();

            dataGridClientes.DataSource = clientesReserva;
        }

        private void boton_crear_Click(object sender, EventArgs e)
        {
            this.Hide();
            new GenerarModificacionReserva.CrearClienteReserva(this).ShowDialog();

            dataGridClientes.DataSource = null;

            clientesReserva.Add(Repositorios.Repo_Cliente.getInstancia().getCliente(idClienteCreado, mailClienteCreado));

            dataGridClientes.DataSource = clientesReserva;
        }

        private void boton_buscar_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Filtrar_cliente(this).ShowDialog();
            dataGridClientes.DataSource = null;
            clientesReserva.Add(clienteFiltrado);
            dataGridClientes.DataSource = clientesReserva;
        }

        private void boton_confirmar_Click(object sender, EventArgs e)
        {

            Console.WriteLine("--------------------");
            Console.WriteLine(Repositorios.Repo_usuario.getInstancia().usuarioIngresado.username);
            Console.WriteLine("--------------------");


            Repositorios.Repo_Reserva.getInstancia().generarLogEstadia(Repositorios.Repo_usuario.getInstancia().usuarioIngresado.username, numReserva, ConfigurationManager.AppSettings["fecha"]);

            foreach (Model.Cliente cliente in clientesReserva) {

                Repositorios.Repo_Reserva.getInstancia().hacerCheckIn(cliente,numReserva);

            }

            MessageBox.Show("Check-In realizado", "Check-In", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGridClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idSeleccionado = (Int32)(dataGridClientes.Rows[e.RowIndex].Cells["id"].Value);
        }

        private void boton_eliminar_Click(object sender, EventArgs e)
        {

            dataGridClientes.DataSource = null;

            clientesReserva.RemoveAll(x => x.id == idSeleccionado);

            dataGridClientes.DataSource = clientesReserva;
            
        }

        private void boton_volver_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Ingreso_Egreso().ShowDialog();
            this.Close();
        }
    }
}
