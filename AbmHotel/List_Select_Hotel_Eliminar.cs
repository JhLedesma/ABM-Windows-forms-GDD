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
    public partial class List_Select_Hotel_Eliminar : Form
    {

        Int32 idSeleccionado;

        public List_Select_Hotel_Eliminar()
        {
            InitializeComponent();
        }

        private void button_filtrar_Click(object sender, EventArgs e)
        {
            dataGridHoteles.DataSource = Repositorios.Repo_hotel.getInstancia().getTablaHotelesFiltrados(filtroNombre.Text, textBox_ciudad.Text, textBox_pais.Text, numericTextBox_estrellas.Text);
        }

        private void dataGridHoteles_CellClick(object sender, DataGridViewCellEventArgs e)
        { 
            idSeleccionado = Int32.Parse(dataGridHoteles.Rows[e.RowIndex].Cells["IdHotel"].Value.ToString());
        }

        private void button_dar_baja_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Baja_hotel().ShowDialog();
            this.Close();
            /*Repositorios.Repo_hotel.getInstancia().darBajaHotel(idSeleccionado);
            MessageBox.Show("Baja logica realizada con exito", "Baja logica realizada", MessageBoxButtons.OK, MessageBoxIcon.Information);
             */
        }

    }
}
