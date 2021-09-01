using System;
using System.Collections.Generic;
using System.Text;

namespace Metodologias_1.Practica_1
{
    interface Icomparable
    {
       abstract bool sosIgual(Icomparable a);
        bool sosMenor(Icomparable a);
        bool sosMayor(Icomparable a);
    }
}
