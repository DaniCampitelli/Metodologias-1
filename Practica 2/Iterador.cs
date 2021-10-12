using System;
using System.Collections.Generic;
using System.Text;

namespace Metodologias_1.Practica_2
{
    interface Iterador
    {
        void Primero();
        void Siguiente();
        bool Fin();
        ElementoIterable Actual();
    }
}
