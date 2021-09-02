using System;
using System.Collections.Generic;
using System.Text;
 
namespace Metodologias_1.Practica_1
{
    interface IColeccionable
    {
        int cuantos();
    public IComparable minimo();
    public IComparable maximo();
    bool agregar(IComparable c);
    IComparable sacar();// preguntar ari
    bool contiene(IComparable c); 
}
}




