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
        public void SetClave(IComparable c)
        {
            this.clave = c;
        }
        public void SetValor(IComparable c)
        {
            this.valor = c;
        }

        public bool SosIgual(IComparable C)
        {
            return clave.SosIgual(C);
        }

        public bool SosMayor(IComparable C)
        {
            return clave.SosMayor(C);
        }

        public bool SosMenor(IComparable C)
        {
            return clave.SosMenor(C);
        }
    }
}
