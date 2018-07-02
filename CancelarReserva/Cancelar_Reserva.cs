using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaHotel.CancelarReserva
{
    public partial class Form1 : Form
    {
        Model.ReservaCancelada reserva = new Model.ReservaCancelada();
        public Form1()
        {
            InitializeComponent();
        }


        private void aceptar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(numericTextBox1.Text) || string.IsNullOrWhiteSpace(motivo.Text) || (fechacancelacion.Value==null) || string.IsNullOrWhiteSpace(usuario.Text))
            {
                MessageBox.Show("Complete todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                reserva.numeroreserva = numericTextBox1.IntValue;
                reserva.motivo = motivo.Text;
                reserva.fechaCancelacion = fechacancelacion.Value;
                reserva.usuario = usuario.Text;

                int resultadoValidacion = Repositorios.Repo_Reserva.getInstancia().validarCancelacion(reserva);
                switch (resultadoValidacion)
                {
                    case 1:
                        MessageBox.Show("No existe tal reserva", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    case 2:
                        MessageBox.Show("La reserva no puede ser cancelada debido a que ya fue utilizada o falta menos de un dia para que sea activa", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    case 3:
                        MessageBox.Show("El usuario no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    case 0:
                        Repositorios.Repo_Reserva.getInstancia().cancelarReserva(reserva);
                        MessageBox.Show("Reserva cancelada correctamente", "Operacion completada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    default:
                        break;
                }

            }


        }

        private void limpiar_Click(object sender, EventArgs e)
        {
            motivo.ResetText();
            fechacancelacion.ResetText();
            usuario.ResetText();
            numericTextBox1.ResetText();
        }

        private void volver_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login.SeleccionarFuncionalidad().ShowDialog();
            this.Close();
        }
    }
}
