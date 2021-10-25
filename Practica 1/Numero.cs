using System;
using System.Collections.Generic;
using System.Text;
using Metodologias_1.Practica_2;


namespace Metodologias_1.Practica_1
{
	class Numero : IComparable,ElementoIterable
	{
		private int valor;
		public Numero(int v)
		{
			valor = v;
		}

		public int getValor()
		{
			return this.valor;
		}
		public void setValor( int n)
		{
			this.valor=n ;
		}
		public bool sosIgual(IComparable C)
		{
			return this.valor == ((Numero)C).getValor();
		}
		public bool sosMenor(IComparable C)
		{
			return this.valor < ((Numero)C).getValor();
		}
		public bool sosMayor(IComparable C)
		{
			return this.valor > ((Numero)C).getValor();
		}

        public void cambiarEstrategia(IEstrategiaDeComparacion x)
        {
            throw new NotImplementedException();
        }
    }
}
