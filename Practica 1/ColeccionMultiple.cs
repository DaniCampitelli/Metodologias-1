using System;
using System.Collections.Generic;
using System.Text;

namespace Metodologias_1.Practica_1
{
    class ColeccionMultiple : IColeccionable
    {
        IColeccionable pil;
        IColeccionable col;

        public ColeccionMultiple(IColeccionable pil, IColeccionable col)
        {
            this.pil = pil;
            this.col = col;

        }


        public bool agregar(IComparable c)
        {
            throw new NotImplementedException();
        }

        public bool contiene(IComparable c)

        {
            if (this.pil.contiene(c) == true || this.col.contiene(c) == true)
            {
                return true;
            }
            return false;

        }


        public int cuantos()
        {
            int cantidadPila = pil.cuantos();

            int cantidadCola = col.cuantos();

            return cantidadPila + cantidadCola;

        }

        public IComparable maximo()
        {
            if (((IComparable)pil.maximo()).sosMayor((IComparable)col.maximo()))
            {
                return pil.maximo();
            }
            return col.maximo();


        }

        public IComparable minimo()
        {
            if (((IComparable)pil.minimo()).sosMenor((IComparable)col.minimo()))
            {
                return pil.minimo();
            }
            return col.minimo();
        }

        public IComparable sacar()
        {
            throw new NotImplementedException();
        }

    }
}

