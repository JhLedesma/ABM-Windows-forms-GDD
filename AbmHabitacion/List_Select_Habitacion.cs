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
    public partial class List_Select_Habitacion : Form
    {

        private List<String> ubicaciones = new List<String>();

        public List_Select_Habitacion()
        {
            ubicaciones.Add("N");
            ubicaciones.Add("S");
            InitializeComponent();
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

        private void button_filtrar_Click(object sender, EventArgs e)
        {
            dataGridHabitaciones.DataSource = Repositorios.Repo_habitacion.getInstancia().getHabitacionesFiltradas(comboBox_ubicacion.SelectedValue.ToString(),0/* Int32.Parse(textBox_idHotel.Text)*/, (Int32)comboBox_tipoHabitacion.SelectedValue);
        }

    }
}
