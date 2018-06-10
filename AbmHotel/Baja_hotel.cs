using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaHotel.AbmHotel
{
    public partial class Baja_hotel : Form
    {

        private DateTime fechaDesde;
        private DateTime fechaHasta;

        public Baja_hotel()
        {
            InitializeComponent();
        }

        private void boton_dar_baja_Click(object sender, EventArgs e)
        {
            Console.WriteLine(fecha_desde.Value);
        }


        

    }
}
