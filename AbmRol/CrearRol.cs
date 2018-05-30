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
    public partial class CrearRol : Form
    {
        List<Model.Funcionalidad> funcionalidades;

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
            this.comboFuncionalidades.ValueMember = "Descripcion";
            this.comboFuncionalidades.DisplayMember = "Descripcion";
            this.comboFuncionalidades.DataSource = Repositorios.Repo_Funcionalidad.getInstancia().getFuncionalidades();
            this.comboFuncionalidades.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void BotonCrearRol_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(textBoxNombre.Text) || string.IsNullOrWhiteSpace(comboFuncionalidades.Text))
            {
                MessageBox.Show("Por favor complete todos los campos", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {





            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}

