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
    public partial class List_Select_Hotel : Form
    {
        public Int32 idSeleccionado;
        private const Int32 VACIO = 0;
        private Crear_Habitacion controlador;

        public List_Select_Hotel(Crear_Habitacion ControladorCrearHab)
        {
            InitializeComponent();
            controlador = ControladorCrearHab;
        }

        private void button_filtrar_Click(object sender, EventArgs e)
        {
            dataGridHoteles.DataSource = Repositorios.Repo_hotel.getInstancia().getTablaHotelesFiltrados(filtroNombre.Text, textBox_ciudad.Text, textBox_pais.Text, numericTextBox_estrellas.Text);
        }

        private void dataGridHoteles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idSeleccionado = Int32.Parse(dataGridHoteles.Rows[e.RowIndex].Cells["IdHotel"].Value.ToString());
        }

        private void boton_seleccionar_Click(object sender, EventArgs e)
        {
            if (idSeleccionado <= VACIO)
            {

                MessageBox.Show("Por favor seleccione un hotel del filtro de hoteles", "Seleccione hotel", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {

                controlador.idHotel = idSeleccionado;
                this.Hide();
                controlador.Show();
                this.Close();

            }
        }



    }
}
