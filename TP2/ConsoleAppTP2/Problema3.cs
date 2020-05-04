using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTP2
{
    public class Problema3
    {
        public bool EsPalindromo (string cadena)
        {
            if (!string.IsNullOrEmpty(cadena))
            {
                string cadenaInvertida = "";
                for (int i = cadena.Length -1; i >= 0; i-- )
                {
                    cadenaInvertida += cadena[i];
                }
                if (cadena.ToLower() == cadenaInvertida.ToLower())
                    return true;
                else
                    return false;

            }
            return false;
        }

        

    }
}
