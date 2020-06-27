using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpresionesLambda
{
    public class Controlador
    {

        public Controlador()
        {

        }

        Action<string> miDelegado;
        public Action<int, int> MiDelegado;

        public decimal Dividir(int numero1, int numero2)
        {
            decimal resultado = 0;
            try
            {
                resultado = numero1 / numero2;
            }
            catch
            {
                MiDelegado.Invoke(numero1, numero2);
            }
            return resultado;
        }

    }
}
