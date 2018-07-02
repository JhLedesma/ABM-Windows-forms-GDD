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
    public partial class Ingreso_Egreso : Form
    {
        public Ingreso_Egreso()
        {
            InitializeComponent();
        }

        private void boton_check_in_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Input_reserva().ShowDialog();
            this.Close();
        }

        private void boton_check_out_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Check_out().ShowDialog();
            this.Close();
        }

        private void boton_volver_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login.SeleccionarFuncionalidad().ShowDialog();
            this.Close();
        }
    }
}
