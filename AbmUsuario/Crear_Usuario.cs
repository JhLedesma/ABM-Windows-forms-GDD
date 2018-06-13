using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaHotel.AbmUsuario
{
    public partial class Crear_Usuario : Form
    {
        private List<Model.Hotel> listaHotelesDisponibles = Repositorios.Repo_hotel.getInstancia().getHoteles();
        private List<Model.Hotel> listaHotelesAgregados = new List<Model.Hotel>();
        private Model.Hotel hotelSeleccionado;

        public Crear_Usuario()
        {
            InitializeComponent();
        }


        public void configuarComboBoxRol()
        {
            this.ListadoRol.ValueMember = "Objeto";
            this.ListadoRol.DisplayMember = "Nombre";
            this.ListadoRol.DataSource = Repositorios.Repo_usuario.getInstancia().getRoles();//Cambiar por metodo de Repo Roles
            this.ListadoRol.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        public void configuarComboBoxHotel()
        {
            this.ListadoRol.ValueMember = "Objeto";
            this.ListadoRol.DisplayMember = "Nombre";
            this.ListadoRol.DataSource = listaHotelesDisponibles;
            this.ListadoRol.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnAgregarHotel_Click(object sender, EventArgs e)
        {
            hotelSeleccionado = (Model.Hotel)listadoHoteles.SelectedValue;
            listaHotelesAgregados.Add(hotelSeleccionado);

            listadoHoteles.DataSource = null;
            listaHotelesDisponibles.Remove(hotelSeleccionado);

            configuarComboBoxHotel();

            MessageBox.Show("Agregado");
        }

    }
}
