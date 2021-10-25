using System;
using System.Collections.Generic;
using System.Text;
using Metodologias_1.Practica_1;



namespace Metodologias_1.Practica_2
{
    class PorLegajo : IEstrategiaDeComparacion
    {
        public bool sosIgual(IComparable c1,IComparable c2)
        {
            return ((Alumno)c1).getLegajo() == ((Alumno)c2).getLegajo();

        }

        public bool sosMayor(IComparable c1, IComparable c2)
        {
            return ((Alumno)c1).getLegajo() > ((Alumno)c2).getLegajo();
        }

        public bool sosMenor(IComparable c1, IComparable c2)
        {
            return ((Alumno)c1).getLegajo() < ((Alumno)c2).getLegajo();
        }
    }
}
