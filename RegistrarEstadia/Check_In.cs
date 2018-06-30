using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaHotel.RegistrarEstadia
{
    public partial class Check_In : Form
    {

        private Int32 idHotel { get; set; }
        private Int32 numReserva { get; set; }
        private List<Model.Cliente> clientesReserva = new List<Model.Cliente>();
        public Model.Cliente clienteCreado { get; set; }
        public Model.Cliente clienteFiltrado { get; set; }

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
            /*Deberia abrir la vista crear cliente, crearlo y agregarlo a clientesReserva, espero que jesus pushee los procedures que necesito*/
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
            foreach (Model.Cliente cliente in clientesReserva) {

                Repositorios.Repo_Reserva.getInstancia().hacerCheckIn(cliente);
            
            
            }
        }
    }
}
