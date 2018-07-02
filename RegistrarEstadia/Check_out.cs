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

               /* int codigoRta = Repositorios.Repo_Reserva.getInstancia().comprobarNumReservaCheckout(Int32.Parse(numeric_textBox_reserva.Text));
                comunicarRta(codigoRta);*/
                //El codigo tiene que ser de una reserva que se haya hecho el check in y que no tenga fecha fin, lo busco en logestadia
                Repositorios.Repo_Reserva.getInstancia().hacerCheckOut(Int32.Parse(numeric_textBox_reserva.Text));
                MessageBox.Show("Check-Out realizado con exito, se procede a la facturacion", "Check-Out ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                new RegistrarConsumible.RegistrarConsumible(Int32.Parse(numeric_textBox_reserva.Text)).ShowDialog();
                this.Close();
            }
        }
    }
}
