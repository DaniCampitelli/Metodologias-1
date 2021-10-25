using System;
using System.Collections.Generic;
using System.Text;
using Metodologias_1.Practica_1;
using System.Collections;


namespace Metodologias_1.Practica_2
{
    class IteradorDeCola:Iterador
    {
        int actual;
        public ArrayList elementos;
        public IteradorDeCola(Cola cola)
        {
            this.elementos = cola.colaColeccionable;
            Primero();
        }
        public ElementoIterable Actual()
        {
            return (ElementoIterable)elementos[actual];
        }

        public bool Fin()
        {
            if (actual == elementos.Count - 1)
            {
                return true;
            }
            return false;
        }

        public void Primero()
        {
            actual = 0;
        }

        public void Siguiente()
        {
            actual = +1;
        }

    }
}
