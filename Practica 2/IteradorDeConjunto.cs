using System;
using System.Collections.Generic;
using System.Text;

namespace Metodologias_1.Practica_2
{
    class IteradorDeConjunto:Iterador
    {
        int actual;
        Conjunto elementos;
        public IteradorDeConjunto(Conjunto conj)
        {
            elementos = conj;
            Primero();
        }
        public ElementoIterable Actual()
        {
            return (ElementoIterable)elementos.conjunto[actual];
        }

        public bool Fin()
        {
            if (actual == elementos.conjunto.Count - 1)
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
