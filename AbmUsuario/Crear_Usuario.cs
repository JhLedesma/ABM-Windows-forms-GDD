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
            configuarComboBoxHotel();
            configuarComboBoxRol();
            configuarComboBoxTipoDoc();
        }


        public void configuarComboBoxRol()
        {
            this.ListadoRol.ValueMember = "Objeto";
            this.ListadoRol.DisplayMember = "Nombre";
            this.ListadoRol.DataSource = Repositorios.Repo_Rol.getInstancia().getRoles();
            this.ListadoRol.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        public void configuarComboBoxHotel()
        {
            this.listadoHoteles.ValueMember = "Objeto";
            this.listadoHoteles.DisplayMember = "IdHotel";
            this.listadoHoteles.DataSource = listaHotelesDisponibles;
            this.listadoHoteles.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        public void configuarComboBoxTipoDoc()
        {
            this.listadoTipoIdentificacion.ValueMember = "Objeto";
            this.listadoTipoIdentificacion.DisplayMember = "Descripcion";
            this.listadoTipoIdentificacion.DataSource = Repositorios.RepoTipoDocumento.getInstancia().getTipoDocumentos();
            this.listadoTipoIdentificacion.DropDownStyle = ComboBoxStyle.DropDownList;
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

        //Comprobar que no exista Username
        private void btnCrear_Click(object sender, EventArgs e)
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
             else if(listaHotelesAgregados.Count == 0)
             {
                 MessageBox.Show("Por favor Agregue uno o mas hoteles donde se desempeña el Usuario", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Error);
             }
             else if (Repositorios.Repo_usuario.getInstancia().validarMail(tbMail.Text) == 1)
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

                 direccion.calle = tbCalle.Text;
                 direccion.ciudad = textBox1.Text;
                 direccion.localidad = tbLocalidad.Text;
                 direccion.pais = tbPais.Text;
                 direccion.dpto = tbDpto.Text;
                 direccion.numDomicilio = numericNumero.Value;
                 direccion.piso = numericPiso.Value;

                 Repositorios.Repo_usuario.getInstancia().newUsuario(usuario, (Model.Rol)ListadoRol.SelectedValue, listaHotelesAgregados);

                 MessageBox.Show("Usuario creado");
             }
            
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            tbUsername.Text = "";
            tbPass.Text = "";
            tbMail.Text = "";
            tbNombre.Text = "";
            tbApellido.Text = "";
            configuarComboBoxTipoDoc();
            numericNumeroIdentificacion.Value = decimal.Zero;
            numericTelefono.Value = decimal.Zero;
            textBox1.Text = "";
            tbCalle.Text = "";
            numericNumero.Value = decimal.Zero;
            numericPiso.Value = decimal.Zero;
            tbDpto.Text = "";
            tbLocalidad.Text = "";
            tbPais.Text = "";
            listaHotelesAgregados.Clear();
            listaHotelesDisponibles = Repositorios.Repo_hotel.getInstancia().getHoteles();
            configuarComboBoxHotel();
        }


    }
}
