using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaHotel.Login
{
    public partial class CambiarContrasenia : Form
    {
        public CambiarContrasenia()
        {
            InitializeComponent();
        }

        private void boton_guardar_Click(object sender, EventArgs e)
        {
            if (textBox_contra.Text.Length == 0 || textBox_contraRepe.Text.Length == 0)
            {
                MessageBox.Show("Por favor ingrese todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);           
            }
            else if (textBox_contraRepe.Text != textBox_contra.Text) 
            {
                MessageBox.Show("Los campos ingresados no son iguales, intente de nuevo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            {
                Repositorios.Repo_usuario.getInstancia().cambiarContrasenia(textBox_contra.Text);
                MessageBox.Show("Contrasenia cambiada con exito", "Contrasenia cambiada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void boton_volver_Click(object sender, EventArgs e)
        {
            this.Hide();
            new SeleccionarFuncionalidad().ShowDialog();
            this.Close();
        }
    }
}
