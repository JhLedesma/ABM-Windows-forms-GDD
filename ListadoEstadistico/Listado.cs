using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaHotel.ListadoEstadistico
{
    public partial class Listado : Form
    {

        private List<String> listaDeTiposListados = new List<string>();

        public Listado()
        {
            InitializeComponent();

            configurarComponentes();

            configurarComboBox();
        }

        private void configurarComponentes()
        {
            listaDeTiposListados.Add("Hoteles con mayor cantidad de reservas canceladas");
            listaDeTiposListados.Add("Hoteles con mayor cantidad de consumibles facturados");
            listaDeTiposListados.Add("Hoteles con mayor cantidad de dias fuera de servicio");
            listaDeTiposListados.Add("Habitaciones mas ocupadas");
            listaDeTiposListados.Add("Clientes con mayor cantidad de puntos");

            numeric_anio.Minimum = 0;
            numeric_anio.Maximum = 9999;

            numeric_trimestre.Minimum = 1;
            numeric_trimestre.Maximum = 4;

            numeric_trimestre.Value = 1;
            numeric_anio.Value = 2018;
        }

        private void configurarComboBox() {

            this.comboBox_tipo.DataSource = listaDeTiposListados;
            this.comboBox_tipo.DropDownStyle = ComboBoxStyle.DropDownList;
        
        }

        private void boton_buscar_Click(object sender, EventArgs e)
        {

                switch (comboBox_tipo.SelectedIndex)
                {
                    case 0:
                        {
                            Console.WriteLine("Hoteles con mayor cantidad de reservas canceladas");
                        }

                        break;

                    case 1:
                        {
                            dataGrid_estadisticas.DataSource = null;
                            dataGrid_estadisticas.DataSource = Repositorios.Repo_listados.getInstancia().topConsumiblesFacturados((Int32)numeric_trimestre.Value, (Int32)numeric_anio.Value);
                        }

                        break;

                    case 2:
                        {
                            dataGrid_estadisticas.DataSource = null;
                            dataGrid_estadisticas.DataSource = Repositorios.Repo_listados.getInstancia().topDiasFueraDeServicio((Int32)numeric_trimestre.Value, (Int32)numeric_anio.Value);
                        }

                        break;

                    case 3:
                        {
                            Console.WriteLine("Hoteles con mayor cantidad de reservas canceladas");
                        }

                        break;

                    case 4:
                        {
                            MessageBox.Show("Esta estadistica puede tomar al rededor de 30 segundos, por favor espere", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            dataGrid_estadisticas.DataSource = null;
                            dataGrid_estadisticas.DataSource = Repositorios.Repo_listados.getInstancia().getPuntosClientes((Int32)numeric_trimestre.Value, (Int32)numeric_anio.Value);
                        }

                        break;

                    default:
                        {
                            Console.WriteLine("gg");
                        }

                        break;

                }

        }

    }
}
