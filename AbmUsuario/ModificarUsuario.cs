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

        private void btnModificar_Click(object sender, EventArgs e)
        {
            /*
             if (
                string.IsNullOrEmpty(tbUsername.Text) ||
                string.IsNullOrEmpty(tbPass.Text) ||
               string.IsNullOrWhiteSpace(tbMail.Text) ||
                string.IsNullOrEmpty(tbNombre.Text) ||
                string.IsNullOrEmpty(tbApellido.Text) ||
                numericNumeroIdentificacion.Value == decimal.Zero ||
                numericTelefono.Value == decimal.Zero ||
                string.IsNullOrEmpty(textBox1.Text) ||
                string.IsNullOrEmpty(tbCalle.Text) ||
                numericNumero.Value == decimal.Zero ||
                numericPiso.Value == decimal.Zero ||
                string.IsNullOrWhiteSpace(tbDpto.Text) ||
                string.IsNullOrEmpty(tbLocalidad.Text) ||
                string.IsNullOrWhiteSpace(tbPais.Text)
                 )
             {
                 MessageBox.Show("Por favor complete todos los campos", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Error);
             }
             else */ if (listaHotelesAgregados.Count == 0)
             {
                 MessageBox.Show("Por favor Agregue uno o mas hoteles donde se desempeña el Usuario", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Error);
             }
             else if (Repositorios.Repo_usuario.getInstancia().validarMail(tbMail.Text) == 1 && !tbUsername.Text.Equals(usuarioSeleccionado.username))
             {
                 MessageBox.Show("Por favor ingrese un mail que no registrado", "Mail ya existente", MessageBoxButtons.OK, MessageBoxIcon.Error);
             }
             else
             {
                 Model.Usuario usuario = new Model.Usuario();
                 Model.Direccion direccion = new Model.Direccion();
                 Model.TipoDocumento tipoDoc = (Model.TipoDocumento)listadoTipoIdentificacion.SelectedValue;

                 usuario.username = tbUsername.Text;
                 usuario.password = Model.Encriptador.getInstancia().encriptar(tbPass.Text);
                 usuario.nombre = tbNombre.Text;
                 usuario.apellido = tbApellido.Text;
                 usuario.email = tbMail.Text;
                 usuario.telefono = numericTelefono.Value;
                 usuario.nroDocumento = numericNumeroIdentificacion.Value;
                 usuario.tipoDoc = tipoDoc;
                 usuario.fechaDeNacimiento = dtFechaNacimiento.Value;
                 usuario.direccion = direccion;

                 direccion.id = usuarioSeleccionado.direccion.id;
                 direccion.calle = tbCalle.Text;
                 direccion.ciudad = textBox1.Text;
                 direccion.localidad = tbLocalidad.Text;
                 direccion.pais = tbPais.Text;
                 direccion.dpto = tbDpto.Text;
                 direccion.numDomicilio = numericNumero.Value;
                 direccion.piso = numericPiso.Value;

                 Repositorios.Repo_usuario.getInstancia().modificarUsuario(usuario, (Model.Rol)ListadoRol.SelectedValue, listaHotelesAgregados);

                 MessageBox.Show("Usuario modificado");

                 this.Hide();
                 this.Close();
                 new AbmUsuario.ABM_Usuario().ShowDialog();
             }
        }


        /*
         * Username nvarchar(255) PRIMARY KEY,
            Pass nvarchar(255)  NOT NULL,
            Direccion int FOREIGN KEY REFERENCES TRAEME_LA_COPA_MESSI.Direccion(IdDir) not null,
            Nombre nvarchar(255) not null,
            Apellido nvarchar(255) not null,
            TipoDoc int FOREIGN KEY REFERENCES TRAEME_LA_COPA_MESSI.TipoDoc(IdTipo) not null,
            NroDocumento numeric(18,0) not null,
            Email nvarchar(255) UNIQUE not null,
            Telefono numeric(18,0) not null,
            FechaNacimiento datetime not null,
            LogsFallidos int DEFAULT 0,
            Estado bit DEFAULT 0
         * */

    }
}
