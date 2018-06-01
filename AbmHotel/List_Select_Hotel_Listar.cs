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
    public partial class List_Select_Hotel_Listar : Form
    {
        public List_Select_Hotel_Listar()
        {
            InitializeComponent();
        }

        private void button_filtrar_Click(object sender, EventArgs e)
        {
            dataGridHoteles.DataSource = Repositorios.Repo_hotel.getInstancia().getTablaHotelesFiltrados(filtroNombre.Text, textBox_ciudad.Text, textBox_pais.Text, numericTextBox_estrellas.Text);
        }

        private void boton_atras_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AbmHotel.Abm_hotel().ShowDialog();
            this.Close();
            
        }

    }
}
