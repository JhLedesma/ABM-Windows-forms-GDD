using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; 

namespace FrbaHotel.AbmRol
{
    public partial class CrearRol : Form
    {
              List<Model.Funcionalidad> funcionalidades = Repositorios.Repo_Funcionalidad.getInstancia().getFuncionalidades();
        List<Model.Funcionalidad> funcionalidadesSeleccionadas = new List<Model.Funcionalidad>();
        public CrearRol()
        {
            InitializeComponent();
            configuarComboBox();
        }

        private void CrearRol_Load(object sender, EventArgs e)
        {
            radioInactivo.Checked = true;
        }

        public void configuarComboBox()
        {
            this.comboFuncionalidades.ValueMember = "Objeto";
            this.comboFuncionalidades.DisplayMember = "Descripcion";
            this.comboFuncionalidades.DataSource = funcionalidades;
            this.comboFuncionalidades.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void BotonCrearRol_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(textBoxNombre.Text) || funcionalidadesSeleccionadas.Count==0)
            {
                MessageBox.Show("Por favor complete todos los campos", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //TODO ver los errores
                int validacion = Repositorios.Repo_Rol.instancia.validarRol((string)textBoxNombre.Text);
                if(validacion==1){
                     Repositorios.Repo_Rol.instancia.agregarRol(textBoxNombre.Text,funcionalidadesSeleccionadas,RadioActivo.Checked);
                 }
                 else
                 { MessageBox.Show("Ya existe ese nombre de rol en la base de datos", "Nombre invalido", MessageBoxButtons.OK, MessageBoxIcon.Error); };

               


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Model.Funcionalidad funcionalidadSeleccionada = (Model.Funcionalidad)comboFuncionalidades.SelectedItem;
            funcionalidadesSeleccionadas.Add(funcionalidadSeleccionada);
            comboFuncionalidades.DataSource = null;
            funcionalidades.Remove(funcionalidadSeleccionada);
            configuarComboBox();
            

        }

        private void BotonLimpiar_Click(object sender, EventArgs e)
        {
            textBoxNombre.Text = "";
            
            
        }

        private void BotonVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AbmRol().ShowDialog();
        }
    }
}

