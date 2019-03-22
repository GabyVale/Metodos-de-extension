using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosExtension
{
    class Program
    {
        static void Main(string[] args)
        {
            string Oracion="1234tt"; //Cadena a revisar
            //char Oracion2;
            bool resultado = Oracion.Digito(); //Digito ya es un metodo de extension creado por mi
            bool resultado2 = Oracion.ToList().ContarLetras(char.IsLetter);
            Console.WriteLine(resultado);
            Console.ReadKey();
        }
    }
}
