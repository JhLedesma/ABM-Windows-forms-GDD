using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaHotel.Model
{
    static class main
    {

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new AbmHotel.Abm_hotel());
            //Application.Run(new Login.Login());
            //Application.Run(new AbmRol.AbmRol());
            //Application.Run(new AbmCliente.Abm_Cliente());
            //Application.Run(new AbmHabitacion.Crear_Habitacion());
            Application.Run(new AbmHabitacion.List_Select_Habitacion());

        }
    }
}
