using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace FrbaHotel.Model
{
    public class Encriptador
    {

        public static Encriptador instancia;

        public Encriptador() { }

        public static Encriptador getInstancia()
        {

            if (instancia != null)
            {

                return instancia;

            }

            else
            {

                instancia = new Encriptador();
                return instancia;

            }

        }

        public String encriptar(String input)
        { //encriptacion con sha256

            SHA256CryptoServiceProvider encargadoDeHash = new SHA256CryptoServiceProvider();

            byte[] inputBytes = Encoding.UTF8.GetBytes(input); //UTF8 es un formato de codigo, tipo que necesita el encargadoDeHash para hashear
            byte[] bytesHasehados = encargadoDeHash.ComputeHash(inputBytes);

            StringBuilder output = new StringBuilder(); //Se usa StringBuilder porque en grandes cantidades de calculo
            //presenta una mejoria de 100ms. Esto me obliga a hacer el .ToString()
            //del return

            foreach (byte b in bytesHasehados)
            {

                output.Append(b.ToString("x2").ToLower()); //Append es la concatenacion del StringBuilder. al .ToString le paso "x2"
                //que es el formato al que quiero que me lo convierta (string de hexa en este caso)
                //ToLower me da la cadena en minuscula

            }

            return output.ToString();

        }

    }
}