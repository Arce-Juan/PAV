using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Triangulo : Figura
    {
        private decimal Base { get; set; }
        private decimal Altura { get; set; }

        public Triangulo(decimal _base, decimal _altura)
        {
            IdTipo = 2;
            Nombre = "Triangulo";
            Base = _base;
            Altura = _altura;
        }
        
        public override decimal CalcularArea()
        {
            return Math.Round(((Base * Altura) / 2), 2);
        }
    }
}
