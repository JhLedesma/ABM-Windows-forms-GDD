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
    public partial class Crear_Habitacion : Form
    {

        public Int32 idHotel { get; set; }

        private List<String> ubicaciones = new List<String>();

        public Crear_Habitacion()
        {
            InitializeComponent();
            ubicaciones.Add("N");
            ubicaciones.Add("S");
            configuarComboBox();
        }


        public void configuarComboBox()
        {
            this.comboBox_ubicacion.DataSource = ubicaciones;
            this.comboBox_ubicacion.DropDownStyle = ComboBoxStyle.DropDownList;

            this.comboBox_tipoHabitacion.ValueMember = "Codigo";
            this.comboBox_tipoHabitacion.DisplayMember = "Descripcion";
            this.comboBox_tipoHabitacion.DataSource = Repositorios.Repo_habitacion.getInstancia().getTiposHabitaciones();
            this.comboBox_tipoHabitacion.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            Int32 respuesta;
   
            respuesta = Repositorios.Repo_habitacion.getInstancia().crearHabitacion(idHotel, numericTextBox_numeroHab.IntValue, numericTextBox_piso.IntValue, comboBox_ubicacion.SelectedValue.ToString(), (Int32)comboBox_tipoHabitacion.SelectedValue);

            comunicarRespuesta(respuesta);
        }

        private void boton_buscar_Click(object sender, EventArgs e)
        {
            this.Hide();
            new List_Select_Hotel(this).ShowDialog();
   
        }

        public void comunicarRespuesta(Int32 rta) {

            if (rta == 0)
            {

                MessageBox.Show("Habitacion creada correctamente", "Habitacion creada", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            else {

                if (rta == 1) {

                    MessageBox.Show("No se puede crear habitacion, ya existe una con el numero indicado", "Error en la creacion", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            
            }
        
        }

    }
}
