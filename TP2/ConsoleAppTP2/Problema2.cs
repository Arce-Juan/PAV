using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ConsoleAppTP2
{
    public class Problema2
    {
        public string CalcularYMostrar(string operador1, string operador2, string operador, out decimal resultado)
        {
            string cadenaResultante;
            try
            {
                decimal numero1 = Decimal.Parse(operador1, new CultureInfo("es-AR"));
                decimal numero2 = Decimal.Parse(operador2, new CultureInfo("es-AR"));
                switch (operador)
                {
                    case "-":
                        resultado = numero1 - numero2;
                        break;
                    case "/":
                        resultado = numero1 / numero2;
                        break;
                    case "*":
                        resultado = numero1 * numero2;
                        break;
                    case "+":
                        resultado = numero1 + numero2;
                        break;
                    default:
                        throw new System.InvalidOperationException("");
                }

                cadenaResultante = $"{numero1}{operador}{numero2}={resultado}";
                cadenaResultante = cadenaResultante.Replace(".", ",");
            }
            catch
            {
                resultado = 0;
                cadenaResultante = "Operacion no valida";
            }
            
            return cadenaResultante;
        }
    }
}
