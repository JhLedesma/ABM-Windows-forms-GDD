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

        private Int32 hotelId;
        private Int32 numeroHab;

        public Modificar_Habitacion(Int32 idHotel, Int32 numeroHabitacion)
        {
            hotelId = idHotel;
            numeroHab = numeroHabitacion; //USO ESTAS DOS VARIABLES?
            habitacionSeleccionada = Repositorios.Repo_habitacion.getInstancia().getHabitacion(idHotel, numeroHabitacion);
            InitializeComponent();

            mostrarDatos();
        }

        private void mostrarDatos() {

            textBox_descripcion.Text = habitacionSeleccionada.descripcion;
            textBox_idHotel.Text = habitacionSeleccionada.idHotel.ToString();
            numericTextBox_numeroHab.Text = habitacionSeleccionada.numero.ToString();
            numericTextBox_piso.Text = habitacionSeleccionada.piso.ToString();

        }
    }
}
