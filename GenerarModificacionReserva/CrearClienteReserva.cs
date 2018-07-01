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
    public partial class CrearClienteReserva : Form
    {
        GenerarReserva vistaReserva;
        RegistrarEstadia.Check_In controlerCheckIn;

        public CrearClienteReserva(GenerarReserva vistaReserva)
        {
            InitializeComponent();
            configuarComboBoxTipoDoc();
            this.vistaReserva = vistaReserva;
        }

        public CrearClienteReserva(RegistrarEstadia.Check_In controlerCheckIn)
        {
            InitializeComponent();
            configuarComboBoxTipoDoc();
            this.controlerCheckIn = controlerCheckIn;
        }

        public void configuarComboBoxTipoDoc()
        {
            this.listadoTipoIdentificacion.ValueMember = "Objeto";
            this.listadoTipoIdentificacion.DisplayMember = "Descripcion";
            this.listadoTipoIdentificacion.DataSource = Repositorios.RepoTipoDocumento.getInstancia().getTipoDocumentos();
            this.listadoTipoIdentificacion.DropDownStyle = ComboBoxStyle.DropDownList;
        }


        

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            tbMail.Text = "";
            tbNombre.Text = "";
            tbApellido.Text = "";
            configuarComboBoxTipoDoc();
            numericNumeroIdentificacion.Value = decimal.Zero;
            numericTelefono.Value = decimal.Zero;
            tbPaisOrigen.Text = "";
            tbNacionalidad.Text = "";
            textBox1.Text = "";
            tbCalle.Text = "";
            numericNumero.Value = decimal.Zero;
            numericPiso.Value = decimal.Zero;
            tbDpto.Text = "";
            tbLocalidad.Text = "";
            tbPais.Text = "";
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if (
    string.IsNullOrWhiteSpace(tbMail.Text) ||
    string.IsNullOrEmpty(tbNombre.Text) ||
    string.IsNullOrEmpty(tbApellido.Text) ||
    numericNumeroIdentificacion.Value == decimal.Zero ||
    numericTelefono.Value == decimal.Zero ||
    string.IsNullOrWhiteSpace(tbPaisOrigen.Text) ||
    string.IsNullOrWhiteSpace(tbNacionalidad.Text) ||
    string.IsNullOrEmpty(textBox1.Text) ||
    string.IsNullOrEmpty(tbCalle.Text) ||
    numericNumero.Value == decimal.Zero ||
    numericPiso.Value == decimal.Zero ||
    string.IsNullOrWhiteSpace(tbDpto.Text) ||
    string.IsNullOrEmpty(tbLocalidad.Text) ||
    string.IsNullOrWhiteSpace(tbPais.Text))
            {
                MessageBox.Show("Por favor complete todos los campos", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    if(vistaReserva != null)
                    {

                    int idCliente = crearClienteConRetorno();
                    Model.Cliente clienteCreado = new Model.Cliente();
                    clienteCreado.mail = tbMail.Text;
                    clienteCreado.id = idCliente;
                    vistaReserva.actualizarTbCliente(clienteCreado);

                    this.Hide();
                    this.Close();

                    }

                    else 
                    {
                                    
                    controlerCheckIn.idClienteCreado = crearClienteConRetorno();
                    controlerCheckIn.mailClienteCreado = tbMail.Text;

                    this.Hide();
                    controlerCheckIn.Show();
                    this.Close();
                    
                    }
                }
                
                catch (Exception exec)
                {
                    MessageBox.Show("Por favor ingrese un mail que no registrado", "Mail ya existente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
        }

        private int crearClienteConRetorno()
        {
            Model.TipoDocumento tipoDoc = (Model.TipoDocumento)listadoTipoIdentificacion.SelectedValue;

            int idCliente = Repositorios.Repo_Cliente.getInstancia().crearClienteReturnId(
                tbMail.Text,
                tbNombre.Text,
                tbApellido.Text,
                tipoDoc.id, //combobox
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
                tbPais.Text);

            MessageBox.Show("Cliente creado correctamente");
            return idCliente;
        }

    }
}
