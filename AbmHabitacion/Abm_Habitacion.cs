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

        private const Int32 CODIGO_BAJA = 1;
        private const Int32 CODIGO_MODIFICACION = 0;

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
            new List_Select_Habitacion(CODIGO_BAJA).ShowDialog();
            this.Close();
        }

        private void boton_modificar_Click(object sender, EventArgs e)
        {
            this.Hide();
            new List_Select_Habitacion(CODIGO_MODIFICACION).ShowDialog();
            this.Close();
        }
    }
}
