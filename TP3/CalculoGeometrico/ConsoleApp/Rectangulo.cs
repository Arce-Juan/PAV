using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Rectangulo : Figura
    {
        private double _base;
        private double altura;

        public double Base { get => _base; set => _base = value; }
        public double Altura { get => altura; set => altura = value; }

        public override double CalcularArea()
        {
            return Math.Round((Base * Altura), 2);
        }

    }
}
