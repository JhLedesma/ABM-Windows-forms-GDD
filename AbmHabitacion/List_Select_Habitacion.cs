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

        public Int32 idHotel { get; set; }

        public List_Select_Habitacion()
        {
            ubicaciones.Add("N");
            ubicaciones.Add("S");
            ubicaciones.Add("");
            idHotel = -1;
            InitializeComponent();
            configuarComboBox();
        }

        public void configuarComboBox()
        {
            this.comboBox_ubicacion.DataSource = ubicaciones;
            this.comboBox_ubicacion.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBox_ubicacion.SelectedIndex = 2;

            List<Model.TipoHabitacion> listaTipos = Repositorios.Repo_habitacion.getInstancia().getTiposHabitaciones();

            Model.TipoHabitacion objetoParasito = new Model.TipoHabitacion();
            objetoParasito.codigo = -1;
            objetoParasito.descripcion = "";

            listaTipos.Add(objetoParasito);

            this.comboBox_tipoHabitacion.ValueMember = "Codigo";
            this.comboBox_tipoHabitacion.DisplayMember = "Descripcion";
            this.comboBox_tipoHabitacion.DataSource = listaTipos;
            this.comboBox_tipoHabitacion.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBox_tipoHabitacion.SelectedIndex = 5;
        }

        private void button_filtrar_Click(object sender, EventArgs e)
        {
            dataGridHabitaciones.DataSource = Repositorios.Repo_habitacion.getInstancia().getHabitacionesFiltradas(comboBox_ubicacion.SelectedValue.ToString(),idHotel, (Int32)comboBox_tipoHabitacion.SelectedValue);
        }

        private void boton_buscar_Click(object sender, EventArgs e)
        {
            this.Hide();
            new List_Select_Hotel(this).ShowDialog();
            textBox_idHotel.Text = idHotel.ToString();
        }

    }
}
