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

            if (string.IsNullOrWhiteSpace(textBoxNombre.Text) || funcionalidadesSeleccionadas.Count==0 || (radioInactivo.Checked == false && RadioActivo.Checked == false))
            {
                MessageBox.Show("Por favor complete todos los campos", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                
                int validacion = Repositorios.Repo_Rol.getInstancia().validarRol(textBoxNombre.Text);
                if(validacion==0){
                     int id =Repositorios.Repo_Rol.getInstancia().agregarRol(textBoxNombre.Text,funcionalidadesSeleccionadas,radioInactivo.Checked);
                     Repositorios.Repo_Rol.getInstancia().actualizarFuncPorRol(funcionalidadesSeleccionadas, id);
                     MessageBox.Show("Rol aniadido correctamente", "Rol creado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    
                 }
                 else
                 { MessageBox.Show("Ya existe ese nombre de rol en la base de datos", "Nombre invalido", MessageBoxButtons.OK, MessageBoxIcon.Error); };

               


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (funcionalidades.Count() == 0)
            {

                MessageBox.Show("No hay más funcionalidades para agregar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
            }
            else
            {

                Model.Funcionalidad funcionalidadSeleccionada = (Model.Funcionalidad)comboFuncionalidades.SelectedItem;
                funcionalidadesSeleccionadas.Add(funcionalidadSeleccionada);
                comboFuncionalidades.DataSource = null;
                funcionalidades.Remove(funcionalidadSeleccionada);
                configuarComboBox();
            
            }


        }

        private void BotonLimpiar_Click(object sender, EventArgs e)
        {
            textBoxNombre.Text = "";
            funcionalidades.Clear();
            funcionalidades = Repositorios.Repo_Funcionalidad.getInstancia().getFuncionalidades();
            funcionalidadesSeleccionadas.Clear();
            radioInactivo.Checked = false;
            RadioActivo.Checked = false;
            configuarComboBox();
            
        }

        private void BotonVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AbmRol().ShowDialog();
        }
    }
}

