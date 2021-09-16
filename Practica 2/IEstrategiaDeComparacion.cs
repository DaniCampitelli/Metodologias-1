using System;
using System.Collections.Generic;
using System.Text;
using Metodologias_1.Practica_1;
//using IComparable = Metodologias_1.Practica_1.IComparable;

namespace Metodologias_1.Practica_2
{
    interface IEstrategiaDeComparacion
    {
            bool sosIgual(IComparable c1, IComparable c2);
            bool sosMayor(IComparable c1, IComparable c2);
            bool sosMenor(IComparable c1, IComparable c2);

    }
}
