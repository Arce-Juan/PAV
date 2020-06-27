using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegadosYEventos
{
    class MisEventos
    {
        public delegate void DivisionPorCeroEventHandler(object objeto, EventArgs e);
        public event DivisionPorCeroEventHandler EventoDivisionPorCero;

        public class DivisionPorCeroConRetornoEventArg : EventArgs
        {
            public int numeroX { set; get; }
            public int numeroY { set; get; }
            public string mensaje { set; get; }
        }

        public delegate void DivisionPorCeroConRetornoEventHandler(object objeto, DivisionPorCeroConRetornoEventArg e);
        public event DivisionPorCeroConRetornoEventHandler EventoDivisionPorCeroConRetorno;

        public decimal Division(int numero1, int numero2)
        {
            decimal resultado = 0;
            try
            {
                resultado = numero1 / numero2;
            }
            catch
            {
                EventoDivisionPorCero(this, EventArgs.Empty);
            }
            return resultado;
        }

        public decimal DivisionConRetorno(int numero1, int numero2)
        {
            decimal resultado = 0;
            try
            {
                resultado = numero1 / numero2;
            }
            catch
            {
                EventoDivisionPorCeroConRetorno(this,
                    new DivisionPorCeroConRetornoEventArg
                    {
                        numeroX = numero1,
                        numeroY = numero2,
                        mensaje = "Se produjo una excepcion al ejecutar la operacion"
                    }
                );
            }
            return resultado;
        }

    }
}
