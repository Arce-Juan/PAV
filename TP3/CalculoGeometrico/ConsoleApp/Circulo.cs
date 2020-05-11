using System;

namespace ConsoleApp
{
    public class Circulo: Figura
    {
        public double Radio { get; set; }

        public override double CalcularArea()
        {
            return Math.Round((Math.PI * Radio * Radio), 2);
        }

    }
}
