using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Delegados
{
    public class Dispositivo
    {
        public int Numero { get; set; }

        public void PararDispositivo()
        {
            Console.WriteLine("Para dispositivo");
        }
    }
}
