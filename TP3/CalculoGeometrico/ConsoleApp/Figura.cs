using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public abstract class Figura
    {
        private int idTipo;
        private string nombre;

        public int IdTipo
        {
            set { idTipo = value; }
            get { return idTipo; }
        }
        public string Nombre
        {
            set { nombre = value; }
            get { return nombre; }
        }

        public abstract decimal CalcularArea();

    }
}
