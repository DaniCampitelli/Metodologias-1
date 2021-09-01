using System;
using System.Collections.Generic;
using System.Text;

namespace Metodologias_1.Practica_1
{
    class Numero:Icomparable
    {
        int valor;
        public Numero(int n)
        {
            this.valor = n;
        }
        public int getValor ()
        {
            return valor;
        }

        public bool sosIgual(Icomparable a)
        {

            return ((Numero)a).valor == valor;
        }

        public bool sosMayor(Icomparable a)
        {
            return ((Numero)a).valor < valor;
        }

        public bool sosMenor(Icomparable a)
        {
            return ((Numero)a).valor > valor;
        }
    }
}
