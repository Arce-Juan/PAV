using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Delegados
{
    public class Instrumento
    {

        //public void PararInstrumento()
        //{
        //    //TODO: código especial
        //    Console.WriteLine("Para instrumento");
        //}

        public bool Suspender(int segundos)
        {
            Console.WriteLine("Suspender instrumento");
            return true;
        }
    }
}
