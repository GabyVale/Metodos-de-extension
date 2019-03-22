using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosExtension
{
    static class MetodosString
    {
        public static bool Digito (this string Cadena)
        {
            List<char> ListaChars = Cadena.ToList();
            bool valorBool = ListaChars.All(delegado => Char.IsDigit(delegado));
            return valorBool;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Cadena"></param>
        /// <param name="resultado"></param>
        /// <returns></returns>
        public static bool ContarLetras( this List<char> Cadena, Func<char, bool> resultado)
        {
            #region
            List<char> ListaChars = Cadena.ToList();
            #endregion
            bool valorBool = ListaChars.All(delegado2 => resultado(delegado2));
            return valorBool;
        }


        

    }
}
