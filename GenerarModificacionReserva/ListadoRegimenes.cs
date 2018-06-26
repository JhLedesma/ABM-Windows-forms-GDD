using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaHotel.GenerarModificacionReserva
{
    public partial class ListadoRegimenes : Form 
    {
        private GenerarReserva vistaGenerarReserva;

        public ListadoRegimenes(GenerarReserva vistaGenerarReserva, int idHotel)
        {
            InitializeComponent();
            this.vistaGenerarReserva = vistaGenerarReserva;
            dataGrid.DataSource = Repositorios.Repo_regimen.getInstancia().getRegimenesDeHotel(idHotel);
        }

        private void dataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            vistaGenerarReserva.actualizarTbRegimen(Convert.ToString(dataGrid.Rows[e.RowIndex].Cells["Descripcion"].Value));
            this.Hide();
            this.Close();
        }
    }
}
