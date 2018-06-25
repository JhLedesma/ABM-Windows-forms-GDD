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

        public Int32 idHotelFiltrado { get; set; }
        private Int32 idHotelSeleccionado{ get; set; }
        private Int32 numeroHabitacion { get; set; }
        private const Int32 VACIO = 0;

        public List_Select_Habitacion(Int32 configuracion)
        {
            ubicaciones.Add("N");
            ubicaciones.Add("S");
            ubicaciones.Add("");
            idHotelFiltrado = -1;
            InitializeComponent();
            configuarComboBox();

            if (configuracion == 1) {

                boton_aceptar.Text = "Dar baja";
                boton_aceptar.Click -= boton_modificar_Click;
                boton_aceptar.Click += boton_aceptar_baja;
            
            }

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
            dataGridHabitaciones.DataSource = Repositorios.Repo_habitacion.getInstancia().getHabitacionesFiltradas(comboBox_ubicacion.SelectedValue.ToString(),idHotelFiltrado, (Int32)comboBox_tipoHabitacion.SelectedValue);
        }

        private void boton_buscar_Click(object sender, EventArgs e)
        {
            this.Hide();
            new List_Select_Hotel(this).ShowDialog();
            textBox_idHotel.Text = idHotelFiltrado.ToString();
        }

        private void boton_modificar_Click(object sender, EventArgs e)
        {
            if (idHotelSeleccionado <= VACIO)
            {

                MessageBox.Show("Por favor seleccione una habitacion del filtro de habitaciones", "Seleccione habitacion", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {

                this.Hide();
                new Modificar_Habitacion(idHotelSeleccionado, numeroHabitacion).ShowDialog();
                this.Close();

            }
        }

        private void boton_aceptar_baja(object sender, EventArgs e)
        {

            if (idHotelSeleccionado <= VACIO)
            {

                MessageBox.Show("Por favor seleccione una habitacion del filtro de habitaciones", "Seleccione habitacion", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {

                Repositorios.Repo_habitacion.getInstancia().darBajaHabitacion(idHotelSeleccionado, numeroHabitacion);
                MessageBox.Show("Baja realizada con exito", "Baja realizada", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }

        private void dataGridHabitaciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idHotelSeleccionado = (Int32)dataGridHabitaciones.Rows[e.RowIndex].Cells["IdHotel"].Value;
            numeroHabitacion = (Int32)dataGridHabitaciones.Rows[e.RowIndex].Cells["Numero"].Value;
            Console.WriteLine(idHotelSeleccionado);
        }

    }
}
