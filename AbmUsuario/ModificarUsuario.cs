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
    public partial class ModificarUsuario : Form
    {
        private Model.Usuario usuarioSeleccionado;
        private List<Model.Hotel> listaHotelesDisponibles = Repositorios.Repo_hotel.getInstancia().getHoteles();
        private List<Model.Hotel> listaHotelesAgregados = new List<Model.Hotel>();
        private Model.Hotel hotelSeleccionado;

        public ModificarUsuario(String username)
        {
            InitializeComponent();
            usuarioSeleccionado = Repositorios.Repo_usuario.getInstancia().getUsuario(username);
            listaHotelesAgregados = usuarioSeleccionado.listaHoteles;
            configuarComboBoxTipoDoc();
            configuarComboBoxRol();
            configuarListadoHotelesAgregados();
            configuarListadoHotelesDisponibles();
            mostrarDatos();
        }


        public void configuarComboBoxTipoDoc()
        {
            this.listadoTipoIdentificacion.ValueMember = "Objeto";
            this.listadoTipoIdentificacion.DisplayMember = "Descripcion";
            this.listadoTipoIdentificacion.DataSource = Repositorios.RepoTipoDocumento.getInstancia().getTipoDocumentos();
            this.listadoTipoIdentificacion.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        public void configuarListadoHotelesAgregados()
        {
            this.listadoHotelesAgregados.ValueMember = "Objeto";
            this.listadoHotelesAgregados.DisplayMember = "IdHotel";
            this.listadoHotelesAgregados.DataSource = listaHotelesAgregados;
            this.listadoHotelesAgregados.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        public void configuarListadoHotelesDisponibles()
        {
            this.listadoHotelesDisponibles.ValueMember = "Objeto";
            this.listadoHotelesDisponibles.DisplayMember = "IdHotel";
            this.listadoHotelesDisponibles.DataSource = listaHotelesDisponibles;
            this.listadoHotelesDisponibles.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        public void configuarComboBoxRol()
        {
            this.ListadoRol.ValueMember = "Objeto";
            this.ListadoRol.DisplayMember = "Nombre";
            this.ListadoRol.DataSource = Repositorios.Repo_Rol.getInstancia().getRoles();
            this.ListadoRol.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        public void mostrarDatos()
        {
            tbUsername.Text = usuarioSeleccionado.username;
            tbPass.Text = usuarioSeleccionado.password;
            tbNombre.Text = usuarioSeleccionado.nombre;
            tbApellido.Text = usuarioSeleccionado.apellido;
            tbMail.Text = usuarioSeleccionado.email;
            numericTelefono.Value = usuarioSeleccionado.telefono;
            numericNumeroIdentificacion.Value = usuarioSeleccionado.nroDocumento;
            listadoTipoIdentificacion.SelectedItem = usuarioSeleccionado.tipoDoc;
            dtFechaNacimiento.Value = usuarioSeleccionado.fechaDeNacimiento;
            tbCalle.Text = usuarioSeleccionado.direccion.calle;
            tbLocalidad.Text = usuarioSeleccionado.direccion.localidad;
            textBox1.Text = usuarioSeleccionado.direccion.ciudad;
            tbPais.Text = usuarioSeleccionado.direccion.pais;
            numericNumero.Value = usuarioSeleccionado.direccion.numDomicilio;
            tbDpto.Text = usuarioSeleccionado.direccion.dpto;
            numericPiso.Value = usuarioSeleccionado.direccion.piso;
            ListadoRol.SelectedItem = usuarioSeleccionado.rolActivo;
            if (usuarioSeleccionado.estado == 0)
            {
                cbEstado.Checked = true;
            }
            else
            {
                cbEstado.Checked = false;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.mostrarDatos();
        }

        private void btnAgregarHotel_Click(object sender, EventArgs e)
        {
            hotelSeleccionado = (Model.Hotel)listadoHotelesDisponibles.SelectedValue;

            listadoHotelesDisponibles.DataSource = null;
            listadoHotelesAgregados.DataSource = null;

            listaHotelesAgregados.Add(hotelSeleccionado);
            listaHotelesDisponibles.Remove(hotelSeleccionado);

            configuarListadoHotelesAgregados(); 
            configuarListadoHotelesDisponibles();
           

            MessageBox.Show("Agregado");
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            hotelSeleccionado = (Model.Hotel)listadoHotelesAgregados.SelectedValue;

            listadoHotelesDisponibles.DataSource = null;
            listadoHotelesAgregados.DataSource = null;

            listaHotelesDisponibles.Add(hotelSeleccionado);
            listaHotelesAgregados.Remove(hotelSeleccionado);

            configuarListadoHotelesAgregados();
            configuarListadoHotelesDisponibles();
        }




    }
}
