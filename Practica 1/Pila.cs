using System;
using System.Collections.Generic;
using System.Text;

using System.Collections;
using Metodologias_1.Practica_2;

namespace Metodologias_1.Practica_1

{
    class Pila : IColeccionable, Iterable
    {
        public List<ElementoIterable> pilaColeccionable;
        public Pila(int tamanio)
        {
            pilaColeccionable = new List<ElementoIterable>(tamanio);
            CrearIterador();
        }

        public IComparable sacar()
        {
            if (pilaColeccionable.Count > 0)
            {
                IComparable ultimoElemento = (IComparable)pilaColeccionable[pilaColeccionable.Count - 1];
                pilaColeccionable.Remove(pilaColeccionable[pilaColeccionable.Count - 1]);
                return ultimoElemento;

            }
            else
            {
                return null;
            }

        }

        public bool agregar(IComparable c)
        {
            if (pilaColeccionable.Capacity > pilaColeccionable.Count)
            {
                pilaColeccionable.Add((ElementoIterable)c);
                return true;
            }
            return false;
        }

        public bool contiene(IComparable comp)
        {
            foreach (IComparable elemento in this.pilaColeccionable)
            {
                if (comp.sosIgual(elemento))
                {

                    return true;
                }

            }
            return false;
        }

        public int cuantos()
        {
            return pilaColeccionable.Count;
        }

        public IComparable maximo()
        {
            //crear validacion que no este vacia
            IComparable maximo = (IComparable)pilaColeccionable[pilaColeccionable.Count - 1];
            for (int i = 0; i < pilaColeccionable.Count; i++)
            {
                if (maximo.sosMenor((IComparable)pilaColeccionable[i]))
                {
                    maximo = (IComparable)pilaColeccionable[i];
                }
            }
            return maximo;

        }

        public IComparable minimo()
        {
            //crear validacion que no este vacia
            IComparable minimo = (IComparable)pilaColeccionable[pilaColeccionable.Count - 1];
            for (int i = 0; i < pilaColeccionable.Count; i++)
            {
                if (minimo.sosMayor((IComparable)pilaColeccionable[i]))
                {
                    minimo = (IComparable)pilaColeccionable[i];
                }
            }
            return minimo;
        }
        public Iterador CrearIterador()
        {
            return new IteradorDePila(this);
        }
    }

}
