using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaHotel.Login
{
    public partial class SeleccionarFuncionalidad_admin : Form
    {
        public SeleccionarFuncionalidad_admin()
        {
            InitializeComponent();
        }

        private void boton_abm_hotel_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AbmHotel.Abm_hotel().ShowDialog();
            this.Close();
        }

        private void boton_volver_Click(object sender, EventArgs e)
        {
            this.Hide();
            new SeleccionarFuncionalidad().ShowDialog();
            this.Close();
        }

        private void boton_abm_habitacion_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AbmHabitacion.Abm_Habitacion().ShowDialog();
            this.Close();
        }
    }
}
