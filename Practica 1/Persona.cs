using System;
using System.Collections.Generic;
using System.Text;
using Metodologias_1.Practica_2;

namespace Metodologias_1.Practica_1
{
    class Persona : IComparable
    {

        private String nombre;
        private int dni;
        public IEstrategiaDeComparacion estrategia;

        public Persona(String nom, int dni)
        {
            this.nombre = nom;
            this.dni = dni;
            this.estrategia = new PorDni();
        }

        public String getNombre()
        {
            return this.nombre;
        }

        public int getDni()
        {
            return this.dni;

        }


        public virtual bool sosIgual(IComparable C)
        {
            return C.sosIgual(this);
        }

        public virtual bool sosMayor(IComparable C)
        {
            return C.sosMayor(this);
        }

        public virtual bool sosMenor(IComparable C)
        {
            return C.sosMenor(this);
        }
        public void cambiarEstrategia(IEstrategiaDeComparacion nuevaestrategia)
        {
            {
                this.estrategia = nuevaestrategia;

            }
        }
    }
}
