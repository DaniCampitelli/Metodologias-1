using System;
using System.Collections.Generic;
using System.Text;
using Metodologias_1.Practica_1;
using IComparable = Metodologias_1.Practica_1.IComparable;


namespace Metodologias_1.Practica_2
{
    class Diccionario:IColeccionable
    {
        public Conjunto conj;

        public Numero claveNumerica = new Numero(0);

        int capacidad;
        public Diccionario(int tamanio)
        {
            this.capacidad = tamanio;
            this.conj = new Conjunto(tamanio);
            CrearIterador();
            Console.WriteLine("diccionario creado con exito");
        }



        public bool agregar(IComparable claveNumerica, IComparable valor)
        {
            ClaveValor a = new ClaveValor(claveNumerica, valor);

            foreach (ClaveValor x in this.conj.conjunto)
                if (x.GetClave().SosIgual(claveNumerica))
                {
                    x.SetValor(valor);

                    return true;
                }
            return this.conj.agregar(a);

        }
        public bool agregar(IComparable c)
            {
            
            claveNumerica.setValor(claveNumerica.getValor() + 1);

            return agregar(claveNumerica, c);
            }

      
        public bool contiene(IComparable comp)
        {


            return conj.contiene(comp);


        }

        public Iterador CrearIterador()
        {
            return new IteradorDeDiccionario(this);
        }

        public int cuantos()
        {
            return conj.cuantos();
        }


        public IComparable maximo()
        {
            return conj.maximo();

        }

        public IComparable minimo()
        {
            return conj.minimo();
        }

       

        public IComparable sacar()
        {
            throw new NotImplementedException();
        }

     

        public IComparable ValorDeClave(IComparable buscado)
        {
            foreach (ClaveValor elemento in conj.conjunto)
            {
                if (elemento.SosIgual(buscado))
                    return elemento.GetValor();


            }
            return null;

        }
    }
}
