using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaHotel.AbmHabitacion
{
    public partial class Modificar_Habitacion : Form
    {

        private Model.Habitacion habitacionSeleccionada;
        public List<String> ubicaciones = new List<string>();

        private Int32 hotelId;
        private Int32 numeroHab;

        public Modificar_Habitacion(Int32 idHotel, Int32 numeroHabitacion)
        {
            hotelId = idHotel;
            numeroHab = numeroHabitacion;

            habitacionSeleccionada = Repositorios.Repo_habitacion.getInstancia().getHabitacion(idHotel, numeroHabitacion);

            InitializeComponent();

            ubicaciones.Add("S");
            ubicaciones.Add("N");

            configuarComboBox();

            mostrarDatos();
        }

        private void mostrarDatos() {

            textBox_descripcion.Text = habitacionSeleccionada.descripcion;
            numericTextBox_idHotel.Text = habitacionSeleccionada.idHotel.ToString();
            numericTextBox_numeroHab.Text = habitacionSeleccionada.numero.ToString();
            numericTextBox_piso.Text = habitacionSeleccionada.piso.ToString();

        }

        public void configuarComboBox()
        {
            this.comboBox_ubicacion.DataSource = ubicaciones;
            this.comboBox_ubicacion.DropDownStyle = ComboBoxStyle.DropDownList;

            if (habitacionSeleccionada.ubicacion == "S")
            {

                this.comboBox_ubicacion.SelectedIndex = 0;

            }

            else this.comboBox_ubicacion.SelectedIndex = 1;

        }

        private void boton_guardar_Click(object sender, EventArgs e) /*A modo de simplificacion, se elimina de las tablas consumiblePorHabitacion y habitacionPorReserva toda referencia a la habitacion modif*/
        {

            /* DOS BUGS ENCONTRADOS, SI SE PONE UN NUMERO DE HAB QUE YA EXISTE Y DSPS SE PONE UNO QUE NO EXISTE SIGUE TIRANDO ERROR*/
            /*SI SE PONE UN NUMERO DE HOTEL QUE YA TIENE ESE NUM DE HAB Y DSPS SE PONE UNO QUE NO LA TIENE, SE ELIMINA LA HAB PARA EL HOTEL QUE LA TENIA PERO NO SE AGREGA AL QUE NO LA TIENE*/
           Int32 codigoRta;

           Console.WriteLine(numericTextBox_idHotel.IntValue);
           Console.WriteLine(numericTextBox_numeroHab.IntValue);

           codigoRta = Repositorios.Repo_habitacion.getInstancia().modificarHabitacion(hotelId, numeroHab,numericTextBox_idHotel.IntValue, numericTextBox_numeroHab.IntValue, numericTextBox_piso.IntValue, comboBox_ubicacion.SelectedValue.ToString(), textBox_descripcion.Text);

           Console.WriteLine(codigoRta);

           comunicarRta(codigoRta);

        }

        private void comunicarRta(Int32 codigo){

            if (codigo == 1)
            {

                MessageBox.Show("Modificaciones aplicadas", "Resultado de modificacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            else {

                MessageBox.Show("No se puede realizar las modificaciones, los datos ingresados corresponden a una habitacion ya existente en el sistema", "Resultado modificacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
            }
        
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            new Login.SeleccionarFuncionalidad().ShowDialog();
        }
    }
}
