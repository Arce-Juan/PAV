using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpresionesLambda
{
    class Program
    {
        static void Main(string[] args)
        {
            // mostrar lista de numeros pares
            List<int> listaNumeros = new List<int>();
            listaNumeros.AddRange(new int[] { 1, 2, 3, 5, 6, 7, 8, 9 });
            List<int> listaPares = listaNumeros.FindAll(x => (x % 2) == 0);
            foreach (int item in listaPares)
                Console.WriteLine(item);
            //Console.Read();

            //mostrar para la lista de nuimero un mensaje si es par y si es impar para cada elemento
            listaNumeros.FindAll(item =>
            {
                if (item % 2 == 0)
                {
                    Console.WriteLine(item + "-es par");
                    return true;
                }
                else
                {
                    Console.WriteLine(item + "-es impar");
                    return false;
                }
            }
            );
            Console.Read();
        }
    }
}
