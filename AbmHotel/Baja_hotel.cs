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

        private Int32 idHotel { get; set; }
        private Int32 valorRetorno;

        public Baja_hotel(Int32 hotelId)
        {
            this.idHotel = hotelId;
            InitializeComponent();
            fecha_hasta.Value = fecha_hasta.Value.AddDays(1);
        }

        private void boton_dar_baja_Click(object sender, EventArgs e)
        {
            if (fecha_desde.Value > fecha_hasta.Value)
            {

                MessageBox.Show("La fecha 'desde' no puede ser menor a la fecha 'hasta'", "Error en fechas", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                valorRetorno = Repositorios.Repo_hotel.getInstancia().darBajaHotel(idHotel, fecha_desde.Value, fecha_hasta.Value, descripcion.Text);
                reportarResultado(valorRetorno);
                Console.WriteLine(this.idHotel);
            }
        }

        public void reportarResultado(Int32 valorRetorno) {

            if (valorRetorno == 1)
            {

                MessageBox.Show("Baja exitosa", "Status baja", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            else {

                MessageBox.Show("No se puede realizar la baja, hay reservas que entran en conflicto", "Status baja", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }


        

    }
}
