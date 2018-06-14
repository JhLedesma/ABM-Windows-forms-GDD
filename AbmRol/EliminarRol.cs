using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaHotel.AbmRol
{
    public partial class EliminarRol : Form
    {
        int aa = 2;
        Model.Rol rolElegido;
        public EliminarRol(Model.Rol elegido)
        {
            rolElegido = elegido;
            InitializeComponent();
            configurarListBox();
            textBox1.Text = rolElegido.Nombre;
            configurarRadioButons();
        }

        private void configurarListBox()
        {
            listBox2.DataSource = null;
            foreach (Model.Funcionalidad func in rolElegido.funcionalidades)
            {

                listBox2.Items.Add(func);
            }

            listBox2.ValueMember = "Objeto";
            listBox2.DisplayMember = "Descripcion";
        }

        private void configurarRadioButons()
        {
            if (rolElegido.estado == 1)
            {
               habilitado.Checked = true;
            }
            else
            {
                inhabilitado.Checked = true;
            }

        }

        private void EliminarRol_Load(object sender, EventArgs e)
        {

            {

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ListaDeRoles(aa).ShowDialog();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Repositorios.Repo_Rol.getInstancia().eliminarRol(rolElegido);
            MessageBox.Show("Rol eliminado correctamente", "Rol eliminado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
