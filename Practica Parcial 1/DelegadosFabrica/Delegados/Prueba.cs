using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Delegados
{
    class Prueba
    {
        delegate void MiDelegado(int numero);
        MiDelegado m;

        public Prueba()
        {
            m += ProbarDelegado;
            m += ProbarDelegado2;
            m(10);
        }

        public void ProbarDelegado(int numero)
        {
            Console.WriteLine("Numero: {0}", numero * 2);
        }

        public void ProbarDelegado2(int numero)
        {
            Console.WriteLine("Numero: {0}", numero * numero);
        }

    }
}
