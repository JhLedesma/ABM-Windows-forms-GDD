using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaHotel.AbmHotel
{
    public partial class Modificar_Hotel : Form
    {

        private Int32 idHotel { get; set; }
        private Model.Hotel hotelSeleccionado { get; set; }
        private List<Model.Regimen> regimenesHotelSelec { get; set; }
        private List<Model.Regimen> regimenesDisponibles { get; set; }
        private Model.Regimen regimenSeleccionado { get; set; }
        

        public Modificar_Hotel(Int32 hotelId)
        {
            this.idHotel = hotelId;
            this.hotelSeleccionado = Repositorios.Repo_hotel.getInstancia().getHotel(hotelId);
            this.regimenesHotelSelec = Repositorios.Repo_hotel.getInstancia().getRegimenes(hotelId);
            this.regimenesDisponibles = Repositorios.Repo_regimen.getInstancia().getRegimenes();

            InitializeComponent();

            actualizarRegimenesDisponibles();

            configuarComboBox();

            mostrarDatos();
        }

        public void mostrarDatos() {

            textBox_nombre.Text = hotelSeleccionado.nombre;
            textBox_mail.Text = hotelSeleccionado.mail;
            textBox_ciudad.Text = hotelSeleccionado.ciudad;
            textBox_calle.Text = hotelSeleccionado.calle;
            textBox_pais.Text = hotelSeleccionado.pais;
            numericTextBox_estrellas.Text = Convert.ToString(hotelSeleccionado.estrellas);
            numericTextBox_nroCalle.Text = Convert.ToString(hotelSeleccionado.nroCalle);
            numericTextBox_porc_est.Text = Convert.ToString(hotelSeleccionado.porcEstrella);
            numericTextBox_telefono.Text = Convert.ToString(hotelSeleccionado.telefono);

        }

        public void configuarComboBox()
        {
            this.comboBox_regimenesAct.ValueMember = "Objeto";
            this.comboBox_regimenesAct.DisplayMember = "Descripcion";
            this.comboBox_regimenesAct.DataSource = regimenesHotelSelec;
            this.comboBox_regimenesAct.DropDownStyle = ComboBoxStyle.DropDownList;

            this.comboBox_regimenes.ValueMember = "Objeto";
            this.comboBox_regimenes.DisplayMember = "Descripcion";
            this.comboBox_regimenes.DataSource = regimenesDisponibles;
            this.comboBox_regimenes.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        public void actualizarRegimenesDisponibles() {
            
            foreach (Model.Regimen r in regimenesHotelSelec)
            {
                regimenesDisponibles.RemoveAll(item => item.descripcion == r.descripcion);
            }

        }

        private void boton_agregar_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(comboBox_regimenes.Text))
            {

                MessageBox.Show("Debe seleccionar un regimen", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            else { 

            regimenSeleccionado = (Model.Regimen)comboBox_regimenes.SelectedValue;

            comboBox_regimenesAct.DataSource = null;
            comboBox_regimenes.DataSource = null;
 
            regimenesHotelSelec.Add(regimenSeleccionado);
            regimenesDisponibles.Remove(regimenSeleccionado);
            
            configuarComboBox();

            MessageBox.Show("Agregado");

            foreach (Model.Regimen r in regimenesDisponibles) {

                Console.WriteLine(r.descripcion);

            }

            foreach (Model.Regimen r in regimenesHotelSelec) {

                Console.WriteLine(r.descripcion);

            }

            }
        }

        private void boton_quitar_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(comboBox_regimenesAct.Text))
            {

                MessageBox.Show("Debe seleccionar un regimen", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            else {

            regimenSeleccionado = (Model.Regimen)comboBox_regimenesAct.SelectedValue;

            comboBox_regimenesAct.DataSource = null;
            comboBox_regimenes.DataSource = null;

            regimenesHotelSelec.Remove(regimenSeleccionado);
            regimenesDisponibles.Add(regimenSeleccionado);

            configuarComboBox();

            MessageBox.Show("Quitado");

            foreach (Model.Regimen r in regimenesDisponibles) {

                Console.WriteLine(r.descripcion);

            }

            foreach (Model.Regimen r in regimenesHotelSelec) {

                Console.WriteLine(r.descripcion);

            }

                }

        }

        private void boton_guardar_Click(object sender, EventArgs e)
        {
            Repositorios.Repo_hotel.getInstancia().modificarHotel(idHotel, textBox_nombre.Text, textBox_mail.Text, numericTextBox_telefono.IntValue, numericTextBox_estrellas.IntValue, numericTextBox_porc_est.IntValue, textBox_pais.Text, textBox_calle.Text, textBox_ciudad.Text, numericTextBox_nroCalle.IntValue);
            MessageBox.Show("Cambios efectuados", "Exito al guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        
    }
}
