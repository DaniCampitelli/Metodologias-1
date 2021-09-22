using System;
using System.Collections.Generic;
using System.Text;
using Metodologias_1.Practica_2;

namespace Metodologias_1
{
	public interface IComparable
	{
		bool sosIgual(IComparable C);
		bool sosMenor(IComparable C);
		bool sosMayor(IComparable C);
	}
}
