using System;
using System.Collections.Generic;
using System.Text;
using Metodologias_1.Practica_2;



namespace Metodologias_1.Practica_1
{
    class Alumno : Persona
    {
        private int legajo;
        private int promedio;

        public Alumno(String nom, int dni, int leg, int prom)
            : base(nom, dni)
        {

            this.legajo = leg;
            this.promedio = prom;
        }

        public int getLegajo()
        {
            return this.legajo;
        }

        public int getPromedio()
        {
            return this.promedio;
        }

        public override bool sosIgual(IComparable a)
        {
            return estrategia.sosIgual(this, a);

        }

        public override bool sosMayor(IComparable C)
        {
            return estrategia.sosMayor(this, C);
        }

        public override bool sosMenor(IComparable C)
        {
            return estrategia.sosMayor(this, C);
        }

    }

}

