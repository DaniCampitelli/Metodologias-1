using System;
using System.Collections.Generic;
using System.Text;
using Metodologias_1.Practica_1;
//using IComparable = Metodologias_1.Practica_1.IComparable;

namespace Metodologias_1.Practica_2
{
    class PorPromedio : IEstrategiaDeComparacion
    {
        public bool sosIgual(IComparable a, IComparable b)
        {
            return ((Alumno)a).getPromedio() == ((Alumno)b).getPromedio();
        }

        public bool sosMayor(IComparable a, IComparable b)
        {
            return ((Alumno)a).getPromedio() > ((Alumno)b).getPromedio();
        }

        public bool sosMenor(IComparable a, IComparable b)
        {
            return ((Alumno)a).getPromedio() < ((Alumno)b).getPromedio();
        }
    }
