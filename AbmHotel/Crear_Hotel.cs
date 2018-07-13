using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace FrbaHotel.AbmHotel
{
    public partial class Crear_Hotel : Form
    {

        public List<Model.Regimen> listaDeRegimenesDisponibles = Repositorios.Repo_regimen.getInstancia().getRegimenes();
        public Repositorios.Repo_hotel repo_hotel = Repositorios.Repo_hotel.getInstancia();
        public List<Model.Regimen> regimenesAgregados = new List<Model.Regimen>();
        private Model.Regimen regimenSeleccionado;


        public Crear_Hotel()
        {
            InitializeComponent();
            configuarComboBox();
            numericTextBox_estrellas.MaxLength = 1;        
        }

        public void configuarComboBox()
        {
            this.comboBox_regimen.ValueMember = "Objeto";
            this.comboBox_regimen.DisplayMember = "Descripcion";
            this.comboBox_regimen.DataSource = listaDeRegimenesDisponibles;
            this.comboBox_regimen.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void boton_crearHotel_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(textBox_nombre.Text) || string.IsNullOrWhiteSpace(textBox_mail.Text) || string.IsNullOrWhiteSpace(numericTextBox_telefono.Text) || string.IsNullOrWhiteSpace(numericTextBox_estrellas.Text) || string.IsNullOrWhiteSpace(comboBox_regimen.Text) || string.IsNullOrWhiteSpace(textBox_calle.Text) || string.IsNullOrWhiteSpace(textBox_ciudad.Text) || string.IsNullOrWhiteSpace(textBox_pais.Text) || string.IsNullOrWhiteSpace(numericTextBox_nroCalle.Text))
            {

                MessageBox.Show("Por favor complete todos los campos", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            else{

                if (numericTextBox_estrellas.IntValue <= 5 && numericTextBox_estrellas.IntValue >= 1)
                {

                    repo_hotel.crearHotel(textBox_nombre.Text, textBox_mail.Text, numericTextBox_telefono.IntValue, numericTextBox_estrellas.IntValue, numericTextBox_porc_est.IntValue, textBox_calle.Text, numericTextBox_nroCalle.IntValue, textBox_ciudad.Text, textBox_pais.Text, ConfigurationManager.AppSettings["fecha"]);

                    

                    foreach (Model.Regimen element in regimenesAgregados)
                        {
                            repo_hotel.agregarRegimenHotel(textBox_nombre.Text, textBox_mail.Text, numericTextBox_telefono.IntValue, element.descripcion);
                        }

                    MessageBox.Show("Hotel creado correctamente");

                }

                else
                {

                    MessageBox.Show("La cantidad de estrellas debe ser un número entre 1 y 5", "Error en el ingreso de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }


            }
        }

        private void limpiar_inputs()
        {
            textBox_nombre.Text = string.Empty;
            textBox_mail.Text = string.Empty;
            numericTextBox_telefono.Text = string.Empty;
            numericTextBox_estrellas.Text = string.Empty;
            numericTextBox_nroCalle.Text = string.Empty;
            comboBox_regimen.Text = string.Empty;
            textBox_calle.Text = string.Empty;
            textBox_ciudad.Text = string.Empty;
            textBox_pais.Text = string.Empty;
            numericTextBox_porc_est.Text = string.Empty;
            regimenesAgregados = new List<Model.Regimen>();
            listaDeRegimenesDisponibles = Repositorios.Repo_regimen.getInstancia().getRegimenes();
            configuarComboBox();
        }

        //Falta agregar un chequeo para comboBox vacio
        private void boton_agregar_Click(object sender, EventArgs e)
        {
            regimenSeleccionado = (Model.Regimen)comboBox_regimen.SelectedValue;
            regimenesAgregados.Add(regimenSeleccionado);
            
            comboBox_regimen.DataSource = null;
            listaDeRegimenesDisponibles.Remove(regimenSeleccionado);
            
            configuarComboBox();

            MessageBox.Show("Agregado");
        }

        private void boton_volver_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Abm_hotel().ShowDialog();
            this.Close();
        }

        private void boton_limpiar_Click(object sender, EventArgs e)
        {
            limpiar_inputs();
        }

    }
}
