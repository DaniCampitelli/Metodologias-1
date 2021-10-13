using System;
using System.Collections.Generic;
using System.Text;


namespace Metodologias_1.Practica_2
{
    interface IEstrategiaDeComparacion
    {
        bool sosIgual(IComparable c1, IComparable c2);
        bool sosMayor(IComparable c1, IComparable c2);
        bool sosMenor(IComparable c1, IComparable c2);
    }
}
