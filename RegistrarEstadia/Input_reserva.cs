using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaHotel.RegistrarEstadia
{
    public partial class Input_reserva : Form
    {

        private const Int32 IDHOTELHARCODEADO = 3; //DEBE SALIR DEL LOGGIN DEL RECEPCIONISTA

        public Input_reserva()
        {
            InitializeComponent();
        }

        private void boton_siguiente_Click(object sender, EventArgs e)
        {
            Int32 codigoRespuesta;
            codigoRespuesta = Repositorios.Repo_Reserva.getInstancia().comprobarNumReserva(IDHOTELHARCODEADO, Int32.Parse(numeric_textBox_reserva.Text));

            comunicarRespuesta(codigoRespuesta);
        }

        private void comunicarRespuesta(Int32 codigo)
        {

            if (codigo == 1) {

                this.Hide();
                new Check_In(IDHOTELHARCODEADO,Int32.Parse(numeric_textBox_reserva.Text)).ShowDialog();
                this.Close();
            
            }

            else {

                if (codigo == 2) {

                    MessageBox.Show("El check in debe realizarce el mismo dia para el cual se realizo la reserva", "Error en el check-in", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                }

                else {

                    if (codigo == 3) {

                        MessageBox.Show("Su reserva expiro, la fecha de check in es anterior a la fecha del dia de hoy, si lo desea puede solicitar una nueva", "Error en el check-in", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                    }

                    else

                    {
                        if (codigo == 4)
                        {

                            MessageBox.Show("Esta reserva ya fue efectivizada", "Error en el check-in", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                        
                        else
                        {

                        MessageBox.Show("La reserva no existe, compruebe el numero ingresado", "Error en el check-in", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }


                    
                 
                }
           
            
            }
        
        }
    }
}
