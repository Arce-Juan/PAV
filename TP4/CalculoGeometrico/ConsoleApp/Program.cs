using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pav.Tp.Evaluacion;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Evaluador.Instancia.Evaluar<Tp3>(31428);
        }
    }
}
