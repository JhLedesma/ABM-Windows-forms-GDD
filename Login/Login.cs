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
    public partial class Login : Form
    {

        String contraseñaIngresada;
        String usuarioIngresado;
        int valorValidacion = 0;
        //public Model.Repo_usuario repo_usuarios = Model.Repo_usuario.getInstancia();
        public const Int16 CONTRASEÑAINCORRECTA = 0;
        public const Int16 CORRECTO = 1;
        public const Int16 BLOQUEADO_INEXISTENTE = -1;
        public const Int32 MAXLOGSFALLIDOS = 3;

        public Login()
        {
            InitializeComponent();
        }

          private void aceptarLogin_Click(object sender, EventArgs e)

        {
            valorValidacion = validarUsuario();

            if ( valorValidacion == CORRECTO)

           {
                this.Hide();
                //Repositorios.Repo_usuario.getInstancia().getUsuario(textBoxUsuario.Text);
                //new SeleccionRol.SeleccionRol().ShowDialog();
                Console.WriteLine("Piola");
                this.Close();
           }

           else {

                if (valorValidacion == CONTRASEÑAINCORRECTA){

              Repositorios.Repo_usuario.getInstancia().getUsuario(textBoxUsuario.Text);

              //Console.WriteLine(Repositorios.Repo_usuario.getInstancia().getUsuarioIngresado().getCantidadLogsFallidos());
              //Console.WriteLine(Repositorios.Repo_usuario.getInstancia().getCantidadDeLogsFallidosUsuario());

              //controlarCantidadLogsFallidos();

           }
                else {

                    if (valorValidacion == BLOQUEADO_INEXISTENTE) {

                        this.Hide();
                        MessageBox.Show("Usuario bloqueado por exceder el límite de logs fallidos  o inexistente, consulte un administrador", "Usuario bloqueado o inexistente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        new Login().ShowDialog();

                    }
                
                }

           }
            
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            TextBox textBoxContraseña = (TextBox)sender;
            this.contraseñaIngresada = textBoxContraseña.Text;
        }

        private void textBoxUsuario_TextChanged(object sender, EventArgs e)
        {
            TextBox textBoxUsuario = (TextBox)sender;
            this.usuarioIngresado = textBoxUsuario.Text;
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }


        public int validarUsuario() {

            int valorValidacion = Repositorios.Repo_usuario.getInstancia().validarUsuario(textBoxUsuario.Text, textBoxPassword.Text);

            return valorValidacion;
        
            }


      /* public void controlarCantidadLogsFallidos() {
        
        if (Repositorios.Repo_usuario.getInstancia().getCantidadDeLogsFallidosUsuario() <= MAXLOGSFALLIDOS){

            this.Hide();
            MessageBox.Show("Contraseña o usuario incorrectos", "Error de credenciales", MessageBoxButtons.OK, MessageBoxIcon.Error);
            new Login().ShowDialog();
        
        }

        else {

            this.Hide();
            Repositorios.Repo_usuario.getInstancia().bloquearUsuario();
            MessageBox.Show("Usuario bloqueado por exceder el límite de logs fallidos, consulte un administrador", "Usuario bloqueado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            new Login().ShowDialog();
        
        }

        }*/

    }
}

