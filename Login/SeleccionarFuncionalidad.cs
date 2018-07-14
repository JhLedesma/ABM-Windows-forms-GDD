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
    public partial class SeleccionarFuncionalidad : Form
    {

        
        private List<String> funcionalidadesUsuario = new List<string>();
        private List<String> funcionalidadesSistema = new List<string>();

        public SeleccionarFuncionalidad()
        {

            obtenerFuncionalidadesUsuario();
            
            InitializeComponent();

            obtenerFuncionalidadesBotones();

            comprobarFuncionalidades();

        }

        private void obtenerFuncionalidadesUsuario()
        {
            foreach (Model.Funcionalidad func in Repositorios.Repo_usuario.getInstancia().usuarioIngresado.rolActivo.funcionalidades)
            {

                funcionalidadesUsuario.Add(func.descripcion);

            }
        }

        private void obtenerFuncionalidadesBotones() {
            
            funcionalidadesSistema.Add(boton_abm_cliente.Text);
            funcionalidadesSistema.Add(boton_cancelar_reservas.Text);
            funcionalidadesSistema.Add(boton_reservas.Text);
            funcionalidadesSistema.Add(boton_registrar_estadia.Text);  
        
        }

        private void comprobarFuncionalidades() {
        
            List<Button> botonesFuncionalidades = new List<Button>();

            botonesFuncionalidades.Add(boton_abm_cliente);
            botonesFuncionalidades.Add(boton_reservas);
            botonesFuncionalidades.Add(boton_registrar_estadia);
            botonesFuncionalidades.Add(boton_cancelar_reservas);

            foreach (String func in funcionalidadesSistema) {



                if (funcionalidadesUsuario.Contains(func))
                {

                    botonesFuncionalidades.Find(boton => boton.Text == func).Enabled = true;
                
                }
            
            }
            
        
        }

        private void linkLabelFuncAdmin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new SeleccionarFuncionalidad_admin().ShowDialog();
            this.Close();
        }

        private void boton_volver_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login().ShowDialog();
            this.Close();
        }

        private void boton_abm_cliente_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AbmCliente.Abm_Cliente().ShowDialog();
            this.Close();
        }

        private void boton_cancelar_reservas_Click(object sender, EventArgs e)
        {
            this.Hide();
            new CancelarReserva.Form1().ShowDialog();
            this.Close();
        }

        private void boton_registrar_estadia_Click(object sender, EventArgs e)
        {
            this.Hide();
            new RegistrarEstadia.Ingreso_Egreso().ShowDialog();
            this.Close();
        }

        private void boton_reservas_Click(object sender, EventArgs e)
        {
            this.Hide();
            new GenerarModificacionReserva.PanelResservas().ShowDialog();
            this.Close();
        }

        private void boton_cambiarCont_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new CambiarContrasenia().ShowDialog();
            this.Close();
        }
    }
}