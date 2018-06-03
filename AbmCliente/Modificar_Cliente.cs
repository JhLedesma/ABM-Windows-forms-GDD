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
    public partial class Modificar_Cliente : Form
    {
        int idClienteSeleccionado;

        public Modificar_Cliente(int idCliente)
        {
            InitializeComponent();
            idClienteSeleccionado = idCliente;
        }
    }
}
