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
        public List_Select_Hotel_Eliminar()
        {
            InitializeComponent();
        }

        private void button_filtrar_Click(object sender, EventArgs e)
        {
            //ESTE METODO ROMPE SI LE PIDO LOS DATOS DEL NUMERIC TEXT BOX, DEBO ARREGLAR ESO, AHORA TIENE UN 3
            //TAMBIEN HAY QUE PREGUNTAR QUE HACEMOS CON AQUELLOS QUE TIENEN NULL EN LO QUE ESTOY FILTRANDO, PORQUE HACE QUE LA BUSQUEDA NO DE RTDOS
            //AHORA ESTA CONFIG PARA QUE TRAIGA TODO LO QUE TENGA NULL EN EL NOMBRE
            dataGridHoteles.DataSource = Repositorios.Repo_hotel.getInstancia().getTablaHotelesFiltrados(filtroNombre.Text, textBox_ciudad.Text, textBox_pais.Text, 4);
        }

    }
}
