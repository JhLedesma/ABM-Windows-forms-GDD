using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaHotel.AbmHabitacion
{
    public partial class Abm_Habitacion : Form
    {
        public Abm_Habitacion()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Crear_Habitacion().ShowDialog();
            this.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Baja_Habitacion().ShowDialog();
            this.Close();
        }

        private void boton_modificar_Click(object sender, EventArgs e)
        {
            this.Hide();
            new List_Select_Habitacion().ShowDialog();
            this.Close();
        }
    }
}
