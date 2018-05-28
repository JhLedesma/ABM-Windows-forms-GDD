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
    public partial class SeleccionDeRol : Form
    {
        
        public Int16 HABILITADO = 0;
        public Model.Rol rolSeleccionado;
        public List<Model.Rol> listaDeRoles = Repositorios.Repo_usuario.getInstancia().usuarioIngresado.getListaDeRoles();
        

        public SeleccionDeRol()
        {
            InitializeComponent();
            configuarComboBox();

        }

        public void configuarComboBox(){
            this.selectorDeRol.ValueMember = "Objeto";
            this.selectorDeRol.DisplayMember = "Nombre";
            this.selectorDeRol.DataSource = listaDeRoles.Where(rol => rol.estado == HABILITADO).ToList();
            this.selectorDeRol.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void selectorDeRol_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox selectorDeRol = (ComboBox)sender;
            this.rolSeleccionado = (Model.Rol)selectorDeRol.SelectedValue;
        }

        private void boton_aceptar_rol_Click(object sender, EventArgs e)
        {  
            this.Hide();
            Repositorios.Repo_usuario.getInstancia().getUsuarioIngresado().rolActivo = rolSeleccionado;
            //new Seleccion_funcionalidades().ShowDialog();
            Console.WriteLine(rolSeleccionado.nombreRol);
            this.Close();
        }

        private void boton_volver_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login().ShowDialog();
            this.Close();
        }

    }
}