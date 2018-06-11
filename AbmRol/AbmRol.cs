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
    public partial class AbmRol : Form
    {
        public AbmRol()
        {
            InitializeComponent();
        }

        private void Crear_Click(object sender, EventArgs e)
        {
            this.Hide();
            new CrearRol().ShowDialog();
            this.Close();
        }

        private void AbmRol_Load(object sender, EventArgs e)
        {
       

        }

        
    }
}
