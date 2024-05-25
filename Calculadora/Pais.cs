using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    public static class Pais
    {
        public static List<string> ListarPaises(string continente)
        {
            List<string> paises = new List<string>();
            paises.Add("Chile");
            paises.Add("Perú");
            paises.Add("Argentina");
            paises.Add("Brasil");

            return paises;


        }
    }
}
