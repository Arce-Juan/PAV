using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pav.Tp1.Evaluacion;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
            Console.WriteLine("** CALCULO DE FACTORIAL **");
            Console.WriteLine($"el factorial para el numero ingresado es: {CalculoDeFactoria(1)}.");
            Console.ReadLine();
            */
            Evaluador.Instancia.Evaluar(CalculoDeFactoria);
        }

        static decimal CalculoDeFactoria(int numero)
        {
            if (numero <= 2)
                return numero < 0 ? 0 : (numero == 0 ? 1 : numero);
            decimal resultado = 2;
            for (int i = 3; i <= numero; i++)
                resultado = resultado * i;
            return resultado;
        }
    }
}
