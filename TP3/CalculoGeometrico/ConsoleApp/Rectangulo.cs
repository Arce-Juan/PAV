using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Rectangulo : Figura
    {
        private decimal ladoBase;
        private decimal ladoAltura;

        public Rectangulo(decimal _ladoBase, decimal _ladoAltura)
        {
            this.IdTipo = 5;
            this.Nombre = "Rectangulo";
            this.ladoBase = _ladoBase;
            this.ladoAltura = _ladoAltura;
        }
        public override decimal CalcularArea()
        {
            return this.ladoBase * this.ladoAltura;
        }

    }
}
