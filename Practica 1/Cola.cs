using System.Collections;

namespace Metodologias_1
{
    class Cola : IColeccionable
    {
        ArrayList colaColeccionable;
        public Cola(int tamanio)
        {
            colaColeccionable = new ArrayList(tamanio);
        }

        public IComparable sacar()
        {
            if (colaColeccionable.Count > 0)
            {
                IComparable primerElemento = (IComparable)colaColeccionable[0];
                colaColeccionable.Remove(colaColeccionable[0]);
                return primerElemento;

            }
            else
            {
                return null;
            }

        }

        public bool agregar(IComparable c)
        {
            if (colaColeccionable.Capacity > colaColeccionable.Count)
            {
                colaColeccionable.Add(c);
                return true;
            }
            return false;
        }

        public bool contiene(IComparable comp)
        {
            foreach (IComparable elemento in colaColeccionable)
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
            return colaColeccionable.Count;
        }

        public IComparable maximo()
        {
            //crear validacion que no este vacia
            IComparable maximo = (IComparable)colaColeccionable[colaColeccionable.Count - 1];
            for (int i = 0; i < colaColeccionable.Count; i++)
            {
                if (maximo.sosMenor((IComparable)colaColeccionable[i]))
                {
                    maximo = (IComparable)colaColeccionable[i];
                }
            }
            return maximo;

        }

        public IComparable minimo()
        {
            //crear validacion que no este vacia
            IComparable minimo = (IComparable)colaColeccionable[colaColeccionable.Count - 1];
            for (int i = 0; i < colaColeccionable.Count; i++)
            {
                if (minimo.sosMayor((IComparable)colaColeccionable[i]))
                {
                    minimo = (IComparable)colaColeccionable[i];
                }
            }
            return minimo;
        }
    }
}
