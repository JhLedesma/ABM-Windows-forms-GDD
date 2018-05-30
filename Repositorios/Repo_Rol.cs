using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaHotel.Repositorios
{
    class Repo_Rol
    {
        public static Repo_Rol instancia;
        public Utils.DBhelper DBhelper = Utils.DBhelper.getInstancia();

        public static Repo_Rol getInstancia()
        {

            if (instancia != null)
            {
                return instancia;
            }
            else
            {
                instancia = new Repo_Rol();
                return instancia;
            }
        }

        public void persistirRol(String nombreRol, String funcionalidad, Int16 estado)
        {


        }


    }
}
