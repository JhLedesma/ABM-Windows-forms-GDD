using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaHotel.AbmRol
{
    public partial class ListaDeRoles : Form
    {

        List<Model.Rol> roles = Repositorios.Repo_Rol.getInstancia().getRoles();
        public ListaDeRoles()
        {
            InitializeComponent();
            configurarListBox();
           
        }
    
        private void configurarListBox()
        {
            
            this.listBox1.ValueMember = "Objeto";
            
            this.listBox1.DisplayMember = "Nombre";
            this.listBox1.DataSource = roles;
        }

        private void ListaDeRoles_Load(object sender, EventArgs e)
        {
       

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
