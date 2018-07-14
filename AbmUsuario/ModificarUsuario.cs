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
        private List<Model.Rol> listaRolesAgregados = new List<Model.Rol>();
        private List<Model.Rol> listaRolesDisponibles = Repositorios.Repo_Rol.getInstancia().getRoles();
        private Model.Hotel hotelSeleccionado;
        private Model.Rol rolSeleccionado;

        public ModificarUsuario(String username)
        {
            InitializeComponent();   

            usuarioSeleccionado = Repositorios.Repo_usuario.getInstancia().getUsuario(username);

            configuarComboBoxTipoDoc();

            
            mostrarDatos();

            listaHotelesAgregados = usuarioSeleccionado.listaHoteles;

            listaHotelesDisponibles = listaHotelesDisponibles.Where(h => !listaHotelesAgregados.Select(h2 => h2.idHotel).ToList().Contains(h.idHotel)).ToList();

            listaRolesAgregados = Repositorios.Repo_usuario.getInstancia().getRolesUsuario(tbUsername.Text);

            listaRolesDisponibles = listaRolesDisponibles.Where(r => !listaRolesAgregados.Select(r2 => r2.idRol).ToList().Contains(r.idRol)).ToList();

            configuarComboBoxRol();

            configuarListadoHoteles();

        }


        public void configuarComboBoxTipoDoc()
        {
            this.listadoTipoIdentificacion.ValueMember = "Objeto";
            this.listadoTipoIdentificacion.DisplayMember = "Descripcion";
            this.listadoTipoIdentificacion.DataSource = Repositorios.RepoTipoDocumento.getInstancia().getTipoDocumentos();
            this.listadoTipoIdentificacion.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        public void configuarListadoHoteles()
        {
            listaHotelesDisponibles = listaHotelesDisponibles.Where(h => !listaHotelesAgregados.Select(h2 => h2.idHotel).ToList().Contains(h.idHotel)).ToList();

            this.listadoHoteles.ValueMember = "Objeto";
            this.listadoHoteles.DisplayMember = "IdHotel";
            this.listadoHoteles.DataSource = listaHotelesDisponibles;
            this.listadoHoteles.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        public void configuarComboBoxRol()
        {
            listaRolesDisponibles = listaRolesDisponibles.Where(r => !listaRolesAgregados.Select(r2 => r2.idRol).ToList().Contains(r.idRol)).ToList();

            this.ListadoRol.ValueMember = "Objeto";
            this.ListadoRol.DisplayMember = "Nombre";
            this.ListadoRol.DataSource = listaRolesDisponibles;
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

        private void btnModificar_Click(object sender, EventArgs e)
        {

            
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
             else 

             if (listaHotelesAgregados.Count == 0)
             {
                 MessageBox.Show("Por favor Agregue uno o mas hoteles donde se desempeña el Usuario", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Error);
             }
             else if (Repositorios.Repo_usuario.getInstancia().validarMail(tbMail.Text) == 1 && !tbUsername.Text.Equals(usuarioSeleccionado.username))
             {
                 MessageBox.Show("Por favor ingrese un mail que no registrado", "Mail ya existente", MessageBoxButtons.OK, MessageBoxIcon.Error);
             }
             else if (listaRolesAgregados.Count == 0)
             {
                 MessageBox.Show("Por favor agregue uno o mas roles para el usuario", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Error);
             }
             else
             {
                 Model.Usuario usuario = new Model.Usuario();
                 Model.Direccion direccion = new Model.Direccion();
                 Model.TipoDocumento tipoDoc = (Model.TipoDocumento)listadoTipoIdentificacion.SelectedValue;
                 //
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
                 if (cbEstado.Checked)
                 {usuario.estado = 0;}
                 else
                 { usuario.estado = 1;}

                 direccion.id = usuarioSeleccionado.direccion.id;
                 direccion.calle = tbCalle.Text;
                 direccion.ciudad = textBox1.Text;
                 direccion.localidad = tbLocalidad.Text;
                 direccion.pais = tbPais.Text;
                 direccion.dpto = tbDpto.Text;
                 direccion.numDomicilio = numericNumero.Value;
                 direccion.piso = numericPiso.Value;

                 Repositorios.Repo_usuario.getInstancia().modificarUsuario(usuario, listaRolesAgregados, listaHotelesAgregados);

                 MessageBox.Show("Usuario modificado");

                 this.Hide();
                 this.Close();
                 new AbmUsuario.ABM_Usuario().ShowDialog();
             }
        }

        private void boton_agregarRol_Click(object sender, EventArgs e)
        {
            if (listaRolesDisponibles.Count == 0) 
            {

                MessageBox.Show("No hay mas roles para agregar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
            }
            else
            {
                rolSeleccionado = (Model.Rol)ListadoRol.SelectedValue;
                listaRolesAgregados.Add(rolSeleccionado);
                configuarComboBoxRol();
            }
        }

        private void boton_borrarRoles_Click(object sender, EventArgs e)
        {
            listaRolesAgregados = new List<Model.Rol>();
            listaRolesDisponibles = Repositorios.Repo_Rol.getInstancia().getRoles();
            configuarComboBoxRol();
        }

        private void boton_borrar_hoteles_Click(object sender, EventArgs e)
        {
            listaHotelesAgregados = new List<Model.Hotel>();
            listaHotelesDisponibles = Repositorios.Repo_hotel.getInstancia().getHoteles();
            configuarListadoHoteles();
        }

        private void boton_agregar_hotel_Click(object sender, EventArgs e)
        {
            if (listaHotelesDisponibles.Count == 0)
            {

                MessageBox.Show("No hay mas hoteles para agregar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                hotelSeleccionado = (Model.Hotel)listadoHoteles.SelectedValue;
                listaHotelesAgregados.Add(hotelSeleccionado);
                configuarListadoHoteles();
            }
        }

    }
}
