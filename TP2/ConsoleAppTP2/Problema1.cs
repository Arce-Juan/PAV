using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTP2
{
    public class Problema1
    {
        public double Calcular(double numero1, double numero2, string operador)
        {
            double resultado;
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
                default:
                    resultado = numero1 + numero2;
                    break;
            }
            return resultado;
        }
    }
}