using System;
using System.Collections.Generic;
using System.Text;


namespace Metodologias_1
{
	class Numero : IComparable
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
	}
}
