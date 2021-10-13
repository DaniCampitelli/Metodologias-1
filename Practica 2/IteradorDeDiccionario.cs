using System;
using System.Collections.Generic;
using System.Text;

namespace Metodologias_1.Practica_2
{
    class IteradorDeDiccionario : Iterador
    {
        Conjunto conj;


        public IteradorDeDiccionario(Diccionario dicc)
        {
            conj = dicc.conj;
            Primero();

        }

        public ElementoIterable Actual()
        {
            return conj.CrearIterador().Actual();
        }

        public bool Fin()
        {
            return conj.CrearIterador().Fin();
        }

        public void Primero()
        {
            conj.CrearIterador().Primero();
        }

        public void Siguiente()
        {
            conj.CrearIterador().Siguiente();

        }
    }
}
