using System;
using System.Collections.Generic;
using System.Text;
using Metodologias_1.Practica_1;
using System.Collections;

namespace Metodologias_1.Practica_2
{
    class IteradorDePila: Iterador
    {
        int actual;
        public List <ElementoIterable> elementos;
        public IteradorDePila(Pila pila)
        {
            this.elementos = pila.pilaColeccionable;
            Primero();
        }
        public ElementoIterable Actual()
        {
            return elementos[actual];
        }

        public bool Fin()
        {
            if (actual == 0)
            {
                return true;
            }
            return false;
        }

        public void Primero()
        {
            actual = (elementos.Count) - 1;
        }

        public void Siguiente()
        {
            actual = -1;
        }

    }
}
