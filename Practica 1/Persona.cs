using System;
using System.Collections.Generic;
using System.Text;

namespace Metodologias_1
{
    class Persona : IComparable
    {

        private String nombre;
        private int dni;

        public Persona(String nom, int dni)
        {
            this.nombre = nom;
            this.dni = dni;
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
            return this.dni == ((Persona)C).getDni();
        }

        public virtual bool sosMayor(IComparable C)
        {
            return this.dni > ((Persona)C).getDni();
        }

        public virtual bool sosMenor(IComparable C)
        {
            return this.dni < ((Persona)C).getDni();
        }
    }
}
