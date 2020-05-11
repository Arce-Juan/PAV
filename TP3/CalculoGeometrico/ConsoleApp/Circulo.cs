using System;

namespace ConsoleApp
{
    public class Circulo: Figura
    {
        private decimal ladoRadio;
        public Circulo(decimal _ladoRadio)
        {
            this.IdTipo = 3;
            this.Nombre = "Circulo";
            ladoRadio = _ladoRadio;
        }
        public override decimal CalcularArea()
        {
            return (decimal)Math.PI * (this.ladoRadio / 2) * (this.ladoRadio / 2);
        }

    }
}
