using System;
using System.Collections.Generic;
using System.Text;
using Metodologias_1.Practica_2;
using IComparable = Metodologias_1.Practica_1.IComparable;


namespace Metodologias_1.Practica_2
{
    class ClaveValor: IComparable, ElementoIterable
    {
        IComparable clave;
        IComparable valor;
        public ClaveValor(IComparable c, IComparable v)
        {
            this.clave = c;
            this.valor = v;
        }

        public void cambiarEstrategia(IEstrategiaDeComparacion x)
        {
            clave.cambiarEstrategia(x);
        }

        public IComparable getClave()
        {
            return clave;
        }
        public IComparable getValor()
        {
            return valor;
        }
        public void setClave(IComparable c)
        {
            this.clave = c;
        }
        public void setValor(IComparable c)
        {
            this.valor = c;
        }

        public bool sosIgual(IComparable C)
        {
            return clave.sosIgual(C);
        }

        public bool sosMayor(IComparable C)
        {
            return clave.sosMayor(C);
        }

        public bool sosMenor(IComparable C)
        {
            return clave.sosMenor(C);
        }
    }
}
