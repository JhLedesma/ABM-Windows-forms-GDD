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
        Int32 numReserva; 
        List<Model.Consumible> consumiblesYServicios = Repositorios.Repo_Consumible.getInstancia().getConsumibles();
        List<Model.Consumible> consumibleSeleccionado = new List<Model.Consumible>();
        DataTable dt = new DataTable();

        public RegistrarConsumible(Int32 reserva)
        {
            InitializeComponent();
            numReserva = reserva;
            this.configurarListBox();
        }

        private void RegistrarConsumible_Load(object sender, EventArgs e)
        {

        }
        void configurarListBox()
        {
            this.listBox1.DataSource = null;
            this.listBox1.ValueMember = "Objeto";
            this.listBox1.DisplayMember = "Nombre";
            this.listBox1.DataSource = consumiblesYServicios;

        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (listBox1.SelectedItem != null && listBox1.Items.Count != 0 && !string.IsNullOrWhiteSpace(numericTextBox1.Text))
            {
                dataGridView1.Rows.Add(((Model.Consumible)listBox1.SelectedItem).nombre, numericTextBox1.Text);
                ((Model.Consumible)listBox1.SelectedItem).cantidad = numericTextBox1.IntValue;
                consumibleSeleccionado.Add(((Model.Consumible)listBox1.SelectedItem));
                consumiblesYServicios.Remove((Model.Consumible)listBox1.SelectedItem);
                numericTextBox1.Text = null;
                configurarListBox();
            }
        }

        private void eliminarFila_Click(object sender, EventArgs e)
        {

            if (dataGridView1.Rows.Count >0)
            {
                String nombre = (String)dataGridView1.CurrentRow.Cells["Consumible"].Value;

                consumiblesYServicios.Add(consumibleSeleccionado.Find(elem => elem.nombre == nombre));
                consumibleSeleccionado.Remove(consumibleSeleccionado.Find(elem => elem.nombre == nombre));



                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
                configurarListBox();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            consumiblesYServicios = Repositorios.Repo_Consumible.getInstancia().getConsumibles();
            consumibleSeleccionado = new List<Model.Consumible>();
            configurarListBox();
            dataGridView1.Rows.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //No se a donde hay que volver
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Int32 numFactura = Repositorios.Repo_Consumible.getInstancia().crearFactura(numReserva);

            if(consumibleSeleccionado.Count != 0)
            {

                foreach(Model.Consumible c in consumibleSeleccionado)
                {

                Repositorios.Repo_Consumible.getInstancia().facturarConsumible(numFactura, c);

                }

                Repositorios.Repo_Consumible.getInstancia().facturarEstadia(numReserva, numFactura);

                Repositorios.Repo_Consumible.getInstancia().calcularTotalFactura(numFactura);

            }

            MessageBox.Show("Factura creada correctamente", "Factura creada", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Hide();
            new Login.SeleccionarFuncionalidad().ShowDialog();
            this.Close();

            //La llista consumibleSeleccionado contiene todos los objetos Consumible que aparecen en el griud actualizados con sus cantidades. Listos para facturar.
        }

    }
}
