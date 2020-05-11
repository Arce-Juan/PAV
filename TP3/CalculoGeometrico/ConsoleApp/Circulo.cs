using System;

namespace ConsoleApp
{
    public class Circulo: Figura
    {
        private double radio;

        public double Radio { get => radio; set => radio = value; }

        public override double CalcularArea()
        {
            return Math.Round((Math.PI * Radio * Radio), 2);
        }

    }
}
