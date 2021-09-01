using System;
using System.Collections.Generic;
using System.Text;

namespace Metodologias_1.Practica_1
{
    interface IColeccionable
    {
        public int cuantos();
        public int minimo();
        public int maximo();
        public void agregar(Icomparable a);
        public bool contiene(Icomparable a);
    }
}
