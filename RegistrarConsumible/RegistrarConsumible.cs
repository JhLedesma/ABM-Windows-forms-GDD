using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaHotel.RegistrarConsumible
{
    public partial class RegistrarConsumible : Form
    {
        Model.Habitacion habitacion;
        List<Model.Consumible> consumiblesYServicios = Repositorios.Repo_Consumible.getInstancia().getConsumibles();
        List<Model.Consumible> consumibleSeleccionado = new List<Model.Consumible>();
        DataTable dt = new DataTable();

        public RegistrarConsumible(Model.Habitacion habitacion)
        {
            InitializeComponent();
            this.habitacion = habitacion;
            this.configurarListBox();
        }

        private void RegistrarConsumible_Load(object sender, EventArgs e)
        {

        }
        void configurarListBox(){
            this.listBox1.DataSource = null;
            this.listBox1.ValueMember = "Objeto";
            this.listBox1.DisplayMember = "Nombre";
            this.listBox1.DataSource = consumiblesYServicios;

    }

        private void button4_Click(object sender, EventArgs e)
        {
          

            DataRow row = dt.NewRow();
            row["Consumible"] = ((Model.Consumible)listBox1.SelectedItem).nombre;
            row["Cantidad"] = numericTextBox1.Text;
            

        }
}}
