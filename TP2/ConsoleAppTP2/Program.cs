using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pav.Tp.Evaluacion;

namespace ConsoleAppTP2 
{
    class Program
    {
        static void Main(string[] args)
        {
            Evaluador.Instancia.Evaluar<Tp2>(31428);
        }
    }
}
