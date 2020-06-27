using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Delegados
{
    public abstract class Elemento
    {
        public string Nombre { get; set; }
        public abstract void Parar();
    }
}
