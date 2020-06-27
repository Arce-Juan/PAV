using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Delegados
{
    public class Controlador
    {
        public delegate void PararEquipamento();
        public PararEquipamento ParaEquipamento { set; get; }

        public Controlador()
        {
        }

        public void AgregarMetodosADelegado(PararEquipamento equipoAParar)
        {
            ParaEquipamento += equipoAParar;
        }

        public void Parar()
        {
            ParaEquipamento();
        }


    }
}
