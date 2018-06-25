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

        public Check_In(Int32 hotel, Int32 reserva)
        {
            idHotel = hotel;
            numReserva = reserva;

            clientesReserva.Add(Repositorios.Repo_Reserva.getInstancia().getClienteReserva(hotel,reserva));
            dataGridClientes.DataSource = clientesReserva;
            InitializeComponent();
        }
    }
}
