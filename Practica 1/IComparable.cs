using System;
using System.Collections.Generic;
using System.Text;

namespace Metodologias_1.Practica_1
{
    interface IComparable
    {
       bool sosIgual(IComparable a);
        bool sosMenor(IComparable a);
        bool sosMayor(IComparable a);
    }
}
