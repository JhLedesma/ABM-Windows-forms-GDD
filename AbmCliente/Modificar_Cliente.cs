using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaHotel.AbmCliente
{
    public partial class Modificar_Cliente : Form
    {
        Model.Cliente clienteSeleccionado;

        public Modificar_Cliente(int idCliente, string mail)
        {
            InitializeComponent();
            clienteSeleccionado = Repositorios.Repo_Cliente.getInstancia().getCliente(idCliente, mail);
            configuarComboBoxTipoDoc();
            mostrarDatos();
        }

        public void configuarComboBoxTipoDoc()
        {
            this.listadoTipoIdentificacion.ValueMember = "Objeto";
            this.listadoTipoIdentificacion.DisplayMember = "Descripcion";
            this.listadoTipoIdentificacion.DataSource = Repositorios.RepoTipoDocumento.getInstancia().getTipoDocumentos();
            this.listadoTipoIdentificacion.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        public void mostrarDatos()
        {
            tbNombre.Text = clienteSeleccionado.nombre;
            tbApellido.Text = clienteSeleccionado.apellido;
            tbMail.Text = clienteSeleccionado.mail;
            numericTelefono.Value = clienteSeleccionado.telefono;
            numericNumeroIdentificacion.Value = clienteSeleccionado.numDoc;
            listadoTipoIdentificacion.SelectedItem = clienteSeleccionado.tipoDoc;
            tbNacionalidad.Text = clienteSeleccionado.nacionalidad;
            dtFechaNacimiento.Value = clienteSeleccionado.fechaNac;
            tbPaisOrigen.Text = clienteSeleccionado.paisOrigen;
            tbCalle.Text = clienteSeleccionado.direccion.calle;
            tbLocalidad.Text = clienteSeleccionado.direccion.localidad;
            textBox1.Text = clienteSeleccionado.direccion.ciudad;
            tbPais.Text = clienteSeleccionado.direccion.pais;
            numericNumero.Value = clienteSeleccionado.direccion.numDomicilio;
            tbDpto.Text = clienteSeleccionado.direccion.dpto;
            numericPiso.Value = clienteSeleccionado.direccion.piso;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.mostrarDatos();
        }

        private void btnGuardar_Click(object sender, EventArgs e) //Agregar Validacion de que los datos esten llenos y tambien estado
        {
            Model.TipoDocumento tipoDoc = (Model.TipoDocumento)listadoTipoIdentificacion.SelectedValue;

            Repositorios.Repo_Cliente.getInstancia().modificarCliente(
                clienteSeleccionado.id,
                clienteSeleccionado.direccion.id,
                tbMail.Text,
                tbNombre.Text,
                tbApellido.Text,
                tipoDoc.id,
                numericNumeroIdentificacion.Value,
                numericTelefono.Value,
                tbPaisOrigen.Text,
                tbNacionalidad.Text,
                dtFechaNacimiento.Value,
                textBox1.Text,
                tbCalle.Text,
                numericNumero.Value,
                numericPiso.Value,
                tbDpto.Text,
                tbLocalidad.Text,
                tbPais.Text
                );

            MessageBox.Show("Cliente modificado correctamente");

            this.Hide();
            this.Close();
        }



    }
}
