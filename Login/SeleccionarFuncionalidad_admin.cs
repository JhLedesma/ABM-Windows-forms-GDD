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
    public partial class SeleccionarFuncionalidad_admin : Form
    {

        private List<String> funcionalidadesUsuario = new List<string>();
        private List<String> funcionalidadesSistema = new List<string>();


        public SeleccionarFuncionalidad_admin()
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

        private void obtenerFuncionalidadesBotones()
        {

            funcionalidadesSistema.Add(boton_abm_habitacion.Text);
            funcionalidadesSistema.Add(boton_abm_hotel.Text);
            funcionalidadesSistema.Add(boton_abm_rol.Text);
            funcionalidadesSistema.Add(boton_abm_usuario.Text);
            funcionalidadesSistema.Add(boton_listado_estadistico.Text);

        }

        private void comprobarFuncionalidades()
        {

            List<Button> botonesFuncionalidades = new List<Button>();

            botonesFuncionalidades.Add(boton_abm_habitacion);
            botonesFuncionalidades.Add(boton_abm_hotel);
            botonesFuncionalidades.Add(boton_abm_rol);
            botonesFuncionalidades.Add(boton_abm_usuario);
            botonesFuncionalidades.Add(boton_listado_estadistico);

            foreach (String func in funcionalidadesSistema)
            {



                if (funcionalidadesUsuario.Contains(func))
                {

                    botonesFuncionalidades.Find(boton => boton.Text == func).Enabled = true;

                }

            }


        }


        private void boton_abm_hotel_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AbmHotel.Abm_hotel().ShowDialog();
            this.Close();
        }

        private void boton_volver_Click(object sender, EventArgs e)
        {
            this.Hide();
            new SeleccionarFuncionalidad().ShowDialog();
            this.Close();
        }

        private void boton_abm_habitacion_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AbmHabitacion.Abm_Habitacion().ShowDialog();
            this.Close();
        }

        private void boton_abm_rol_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AbmRol.AbmRol().ShowDialog();
            this.Close();
        }

        private void boton_abm_usuario_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AbmUsuario.ABM_Usuario().ShowDialog();
            this.Close();
        }

        private void boton_listado_estadistico_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ListadoEstadistico.Listado().ShowDialog();
            this.Close();
        }
    }
}
