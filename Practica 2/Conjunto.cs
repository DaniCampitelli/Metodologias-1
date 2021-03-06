using System;
using System.Collections.Generic;
using Metodologias_1.Practica_1;

namespace Metodologias_1.Practica_2
{
    class Conjunto : IColeccionable,Iterable
    {
        public List<IComparable> conjunto;
        
        public Conjunto(int tamanio)

        {
            conjunto = new List<IComparable>(tamanio);
          
            Console.WriteLine("conjunto creado con exito");
        }


        public bool pertenece(IComparable c)
        {
            return contiene(c);
        }

        public bool agregar(IComparable c)
        {
            if (conjunto.Capacity > conjunto.Count)
            {

                if (this.pertenece(c))
                    return false;

                else
                    conjunto.Add(c);
                Console.WriteLine(conjunto.Count);
                return true;
            }
            return false;
        }


        public bool contiene(IComparable c)
        {
            foreach (IComparable x in conjunto)

                if (x.sosIgual(c))
                {

                    return true;
                }


            return false;
        }
        public int cuantos()
        {
            return conjunto.Count;
        }

        public IComparable maximo()
        {
            IComparable max = (IComparable)conjunto[0];
            foreach (IComparable x in conjunto)
            {
                if (max.sosMenor(x))
                    max = x;



            }
            return max;
        }

        public IComparable minimo()
        {
            IComparable min = (IComparable)conjunto[0];
            foreach (IComparable x in conjunto)
            {
                if (min.sosMayor(x))
                    min = x;



            }
            return min;
        }

        public IComparable sacar()
        {
            throw new NotImplementedException();
        }

        public Iterador CrearIterador()
        {
            return new IteradorDeConjunto(this);
        }
    }

       
    
}
