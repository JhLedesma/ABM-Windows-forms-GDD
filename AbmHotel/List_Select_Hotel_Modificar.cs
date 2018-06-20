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
    public partial class List_Select_Hotel_Modificar : Form
    {

        private Int32 idSeleccionado;
        private const Int32 VACIO = 0;

        public List_Select_Hotel_Modificar()
        {
            InitializeComponent();
        }

        private void button_filtrar_Click(object sender, EventArgs e)
        {        
            dataGridHoteles.DataSource = Repositorios.Repo_hotel.getInstancia().getTablaHotelesFiltrados(filtroNombre.Text, textBox_ciudad.Text, textBox_pais.Text, numericTextBox_estrellas.Text);
        }

        private void dataGridHoteles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idSeleccionado = (Int32)(dataGridHoteles.Rows[e.RowIndex].Cells["IdHotel"].Value);
            Console.WriteLine(idSeleccionado);
        }


        private void button_modificar_Click(object sender, EventArgs e)
        {
            if (idSeleccionado <= VACIO) {

                MessageBox.Show("Por favor seleccione un hotel del filtro de hoteles", "Seleccione hotel", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else{

            this.Hide();
            new Modificar_Hotel(idSeleccionado).ShowDialog();
            this.Close();

            }
        }

        private void boton_volver_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Abm_hotel().ShowDialog();
            this.Close();
        }
    }
}