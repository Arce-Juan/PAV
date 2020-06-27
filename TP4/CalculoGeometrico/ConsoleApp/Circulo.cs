using System;

namespace ConsoleApp
{
    public class Circulo: IFigura
    {
        public double Radio { get; set; }

        public double CalcularArea()
        {
            return Math.Round((Math.PI * Radio * Radio), 2);
        }

    }
}
