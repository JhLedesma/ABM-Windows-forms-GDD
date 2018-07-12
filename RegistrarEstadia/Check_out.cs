using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;


namespace FrbaHotel.RegistrarEstadia
{
    public partial class Check_out : Form
    {

        const Int32 HOTELHARCODEAD = 3;

        public Check_out()
        {
            InitializeComponent();
        }


        private void boton_continuar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(numeric_textBox_reserva.Text))
            {
                MessageBox.Show("Por favor ingrese un numero de reserva","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else

            {

                int codigoRta = Repositorios.Repo_Reserva.getInstancia().comprobarNumReservaCheckout(Int32.Parse(numeric_textBox_reserva.Text));
                comunicarRta(codigoRta);

                //El codigo tiene que ser de una reserva que se haya hecho el check in y que no tenga fecha fin, lo busco en logestadia
                
            }
        }

        private void boton_volver_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Ingreso_Egreso().ShowDialog();
            this.Close();
        }

        public void comunicarRta(Int32 codigoRta) {

            if (codigoRta == 1) {

                Repositorios.Repo_Reserva.getInstancia().hacerCheckOut(Repositorios.Repo_usuario.getInstancia().usuarioIngresado.username, Int32.Parse(numeric_textBox_reserva.Text), ConfigurationManager.AppSettings["fecha"]);
                MessageBox.Show("Check-Out realizado con exito, se procede a la facturacion", "Check-Out ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                new RegistrarConsumible.RegistrarConsumible(Int32.Parse(numeric_textBox_reserva.Text)).ShowDialog();
                this.Close();
            
            }

            else {

                if (codigoRta == 2) {

                    MessageBox.Show("No se encuentra el check-in que corresponde a ese codigo de reserva", "Error en el check-out", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                }

                else {

                    if (codigoRta == 3) {

                        MessageBox.Show("Ya se realizo el check-out para este codigo de reserva", "Error en el check-out", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                    }

                    else {
                    
                    if (codigoRta == 4) {

                        MessageBox.Show("No existe una reserva con ese codigo de identificacion", "Error en el check-out", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    
                  }
                
                
                }
            
            }
        
        
        }

    }
}
