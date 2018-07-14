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
    
    public partial class ModificarRol : Form
    {
        int aa = 1;
        Model.Rol rolElegido;
        public ModificarRol(Model.Rol elegido)
        {
            rolElegido = elegido;
            InitializeComponent();
            textBox1.Text = rolElegido.Nombre;
            configurarListBox();
            configurarRadioButons();
        }

    

        public void EstablecerRol(Model.Rol elegido)
        {
            rolElegido = elegido;
        }

        private void configurarListBox()
        {
            LFuncionalidadesActuales.DataSource = null;
            LfuncionalidadesPosibles.DataSource = null;
            foreach(Model.Funcionalidad func in rolElegido.funcionalidades){

            LFuncionalidadesActuales.Items.Add(func);
            }

            LFuncionalidadesActuales.ValueMember = "Objeto";
            LFuncionalidadesActuales.DisplayMember = "Descripcion";

            List<Model.Funcionalidad> aux = Repositorios.Repo_Funcionalidad.getInstancia().getFuncionalidades();
            foreach (Model.Funcionalidad yaAdquirida in rolElegido.funcionalidades)
            {
                aux.Remove(aux.Find(x => x.descripcion == yaAdquirida.descripcion));
            }
            foreach (Model.Funcionalidad func in aux)
            {
                LfuncionalidadesPosibles.Items.Add(func);
            }

            
            LfuncionalidadesPosibles.ValueMember = "Objeto";
            LfuncionalidadesPosibles.DisplayMember = "Descripcion";
        }
        private void configurarRadioButons()
        {
            if (rolElegido.estado == 1)
            {
                radioInhabilitado.Checked = true;
            }
            else
            {
                radioHabilitado.Checked = true;
            }

        }

        private void BotonAgregar_Click(object sender, EventArgs e)
        {
            if (LfuncionalidadesPosibles.SelectedItem != null)
            {
               
                LFuncionalidadesActuales.Items.Add(LfuncionalidadesPosibles.SelectedItem);
                LfuncionalidadesPosibles.Items.Remove(LfuncionalidadesPosibles.SelectedItem);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            if (LFuncionalidadesActuales.SelectedItem != null)
            {
                LFuncionalidadesActuales.DataSource = null;
                
                LfuncionalidadesPosibles.Items.Add(LFuncionalidadesActuales.SelectedItem);
                LFuncionalidadesActuales.Items.Remove(LFuncionalidadesActuales.SelectedItem);
            }
            else { }
        }

        private void BotonLimpiar_Click(object sender, EventArgs e)
        {
            textBox1.Text = rolElegido.Nombre;
            LfuncionalidadesPosibles.Items.Clear();
            LFuncionalidadesActuales.Items.Clear();
            configurarListBox();
            configurarRadioButons();
        }

        private void BotonVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ListaDeRoles(aa).ShowDialog();
            this.Close();
        }

        private void BotonAceptar_Click(object sender, EventArgs e)
        {
            List<Model.Funcionalidad> nuevasFuncionalidades= new List<Model.Funcionalidad>();
            foreach(Model.Funcionalidad funcionalidad in LFuncionalidadesActuales.Items){
                nuevasFuncionalidades.Add(funcionalidad);
                }
            rolElegido.nuevasFuncionalidades(nuevasFuncionalidades);


            if(radioHabilitado.Checked==true){
                rolElegido.estado=0;}
            else {
                rolElegido.estado=1;}

            Repositorios.Repo_Rol.getInstancia().actualizarRol(rolElegido);
            MessageBox.Show("Rol modificado", "Rol modificado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            

    }

        }

