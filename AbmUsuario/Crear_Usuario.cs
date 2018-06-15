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
            this.ListadoRol.ValueMember = "Objeto";
            this.ListadoRol.DisplayMember = "IdHotel";
            this.ListadoRol.DataSource = listaHotelesDisponibles;
            this.ListadoRol.DropDownStyle = ComboBoxStyle.DropDownList;
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
            usuario.tipoDoc = tipoDoc.id;
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
        }



        /*
            CREATE TABLE TRAEME_LA_COPA_MESSI.Usuario( 
            Username nvarchar(255) PRIMARY KEY,
            Pass nvarchar(255)  NOT NULL,
            Direccion int FOREIGN KEY REFERENCES TRAEME_LA_COPA_MESSI.Direccion(IdDir) NULL,
            Nombre nvarchar(255) NULL,
            Apellido nvarchar(255) NULL,
            TipoDoc int FOREIGN KEY REFERENCES TRAEME_LA_COPA_MESSI.TipoDoc(IdTipo),
            NroDocumento numeric(18,0) DEFAULT 0,
            Email nvarchar(255) UNIQUE NULL,
            Telefono numeric(18,0) DEFAULT 0,
            FechaNacimiento datetime NULL,
            LogsFallidos int NOT NULL DEFAULT 0,
            Estado bit DEFAULT 0
            );

            CREATE TABLE TRAEME_LA_COPA_MESSI.Rol(
            IdRol int IDENTITY(1,1) PRIMARY KEY,
            Nombre nvarchar(255) NOT NULL,
            Estado BIT DEFAULT 0 
            );

            CREATE TABLE TRAEME_LA_COPA_MESSI.RolPorUsuario(
            Username nvarchar(255) FOREIGN KEY REFERENCES TRAEME_LA_COPA_MESSI.Usuario(Username),
            IdRol int FOREIGN KEY REFERENCES TRAEME_LA_COPA_MESSI.Rol(IdRol),
            CONSTRAINT IdRolPorUsuario PRIMARY KEY(Username,IdRol)
            );
         
         
            CREATE TABLE TRAEME_LA_COPA_MESSI.Hotel(
            IdHotel int IDENTITY(1,1) PRIMARY KEY,
            Nombre nvarchar(255) DEFAULT '',
            Mail nvarchar(255) DEFAULT '',
            Telefono int DEFAULT -1,
            Direccion int FOREIGN KEY REFERENCES TRAEME_LA_COPA_MESSI.Direccion(IdDir),
            CantEstrellas int  NULL,
            PorcentajeEstrellas numeric(18,0) NULL,
            FechaCreacion datetime DEFAULT GETDATE()
            );

            CREATE TABLE TRAEME_LA_COPA_MESSI.UsuariosPorHotel(
            IdHotel int FOREIGN KEY REFERENCES TRAEME_LA_COPA_MESSI.Hotel(IdHotel),
            Username nvarchar(255) FOREIGN KEY REFERENCES TRAEME_LA_COPA_MESSI.Usuario(Username),
            User_desempenio nvarchar(255) NOT NULL
            CONSTRAINT IdUsuariosPorHotel PRIMARY KEY(IdHotel,Username)
            );
        */

    }
}
