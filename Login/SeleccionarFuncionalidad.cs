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

        const int IDADMIN = 1;

        public SeleccionarFuncionalidad()
        {
            InitializeComponent();

        }

        private void linkLabelFuncAdmin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new SeleccionarFuncionalidad_admin().ShowDialog();
            this.Close();
        }

        public void determinarHabilitacionFuncionesAdmin() {

            if (Repositorios.Repo_usuario.getInstancia().getUsuarioIngresado().rolActivo.idRol == IDADMIN) {

                linkLabelFuncAdmin.Enabled = true;
            
            }

            else {

                linkLabelFuncAdmin.Enabled = false;
            
            }

        }
    }
}