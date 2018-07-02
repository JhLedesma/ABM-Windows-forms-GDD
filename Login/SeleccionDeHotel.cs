using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaHotel.Login
{
    public partial class SeleccionDeHotel : Form
    {
        public SeleccionDeHotel()
        {
            InitializeComponent();
            configuarComboBoxHotel();
        }



        public void configuarComboBoxHotel()
        {
            this.listadoHoteles.ValueMember = "Objeto";
            this.listadoHoteles.DisplayMember = "IdHotel";
            this.listadoHoteles.DataSource = Repositorios.Repo_usuario.getInstancia().getUsuarioIngresado().listaHoteles;
            this.listadoHoteles.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            Repositorios.Repo_usuario.getInstancia().getUsuarioIngresado().hotelActivo = (Model.Hotel)listadoHoteles.SelectedValue;
            new SeleccionarFuncionalidad().ShowDialog();

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {

        }



    }
}
