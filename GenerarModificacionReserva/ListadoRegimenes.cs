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
            Model.Regimen regimen = new Model.Regimen();
            regimen.descripcion = Convert.ToString(dataGrid.Rows[e.RowIndex].Cells["Descripcion"].Value);
            regimen.precioBase = Convert.ToInt32(dataGrid.Rows[e.RowIndex].Cells["PrecioBase"].Value);
            regimen.idRegimen = Convert.ToInt32(dataGrid.Rows[e.RowIndex].Cells["IdRegimen"].Value);

            vistaGenerarReserva.actualizarRegimen(regimen);
            
            this.Hide();
            this.Close();
        }
    }
}
