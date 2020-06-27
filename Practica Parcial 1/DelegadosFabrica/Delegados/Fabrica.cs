using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Delegados
{
    class Fabrica
    {
        public Dispositivo dispositivo;
        public Maquina maquina;
        public Vehiculo vehiculo;

        public Fabrica()
        {
            dispositivo = new Dispositivo();
            maquina = new Maquina();
            vehiculo = new Vehiculo();
        }

        public void Parar()
        {
            
        }
    }
}
