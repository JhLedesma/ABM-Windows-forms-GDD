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

        public String contraseñaIngresada;
        public String usuarioIngresado;
        public int valorValidacion = 0;
        public int cantidadRolesDelUsuario;
        public const Int16 CONTRASEÑAINCORRECTA = 0;
        public const Int16 CORRECTO = 1;
        public const Int16 BLOQUEADO_INEXISTENTE = -1;
        public const Int32 MAXLOGSFALLIDOS = 3;
        Repositorios.Repo_usuario repo_usuario = Repositorios.Repo_usuario.getInstancia();

        public Login()
        {
            InitializeComponent();
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

            int valorValidacion = repo_usuario.validarUsuario(textBoxUsuario.Text, textBoxPassword.Text);

            return valorValidacion;
        
            }

        private void aceptarLogin_Click(object sender, EventArgs e)
        {
                  
            valorValidacion = validarUsuario();

            if ( valorValidacion == CORRECTO)

           {
                Console.WriteLine("LOGIN ACEPTADO");
                this.Hide();
                repo_usuario.getUsuarioLogeado(textBoxUsuario.Text);
                cantidadRolesDelUsuario = repo_usuario.usuarioIngresado.listaDeRoles.Count();

                if(cantidadRolesDelUsuario > 1)
                {
                
                new SeleccionDeRol().ShowDialog();
                this.Close();

                }

                else {

                    Console.WriteLine("TIENE 1 SOLO ROL");
                    repo_usuario.usuarioIngresado.rolActivo = repo_usuario.usuarioIngresado.listaDeRoles.First();
                    this.Hide();
                    new SeleccionarFuncionalidad().ShowDialog();
                    this.Close();
                    Console.WriteLine(repo_usuario.usuarioIngresado.rolActivo.nombreRol);
                
                } 
           }

           else {
               
                if (valorValidacion == CONTRASEÑAINCORRECTA){

              Console.WriteLine("LOGIN FALLIDO");

              repo_usuario.getUsuarioLogeado(textBoxUsuario.Text);

              controlarCantidadLogsFallidos();

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


       public void controlarCantidadLogsFallidos() {
        
        if (repo_usuario.getCantidadDeLogsFallidosUsuario() <= MAXLOGSFALLIDOS){

            this.Hide();
            MessageBox.Show("Contraseña o usuario incorrectos", "Error de credenciales", MessageBoxButtons.OK, MessageBoxIcon.Error);
            new Login().ShowDialog();
        
        }

        else {

            this.Hide();
            repo_usuario.bloquearUsuario();
            MessageBox.Show("Usuario bloqueado por exceder el límite de logs fallidos, consulte un administrador", "Usuario bloqueado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            new Login().ShowDialog();
        
        }

        }

       private void boton_guest_Click(object sender, EventArgs e)
       {
           this.Hide();
           new SeleccionarFuncionalidad_invitado().ShowDialog();
           this.Close();
       }

    }
}

