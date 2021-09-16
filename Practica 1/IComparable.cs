using System;
using System.Collections.Generic;
using System.Text;
using Metodologias_1.Practica_2;

namespace Metodologias_1.Practica_1
{
    interface IComparable
    {
       bool sosIgual(IComparable a);
        bool sosMenor(IComparable a);
        bool sosMayor(IComparable a);
    }
}
