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
        private Crear_Habitacion controladorCrear;
        private List_Select_Habitacion controladorModif;


        public List_Select_Hotel(Crear_Habitacion ControladorCrearHab)
        {
            InitializeComponent();
            controladorCrear = ControladorCrearHab;
        }

        public List_Select_Hotel(List_Select_Habitacion controladorModifHab)
        {
            InitializeComponent();
            controladorModif = controladorModifHab;
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
                try
                {
                    controladorCrear.idHotel = idSeleccionado;
                    this.Hide();
                    controladorCrear.Show();
                    this.Close();
                }
                catch (NullReferenceException) {

                    controladorModif.idHotelFiltrado = idSeleccionado;
                    this.Hide();
                    controladorModif.Show();
                    this.Close();
                
                }

            }
        }

        private void boton_volver_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            new Crear_Habitacion().ShowDialog();
        }



    }
}
