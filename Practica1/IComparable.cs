using System;
using System.Collections.Generic;
using System.Text;

namespace Metodologias_1
{
	public interface IComparable
	{
		bool sosIgual(IComparable C);
		bool sosMenor(IComparable C);
		bool sosMayor(IComparable C);
	}
}
