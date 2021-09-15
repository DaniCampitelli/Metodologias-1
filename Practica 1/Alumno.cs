using System;
using System.Collections.Generic;
using System.Text;



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
            return this.legajo == ((Alumno)a).getLegajo();
               
        }

        public override bool sosMayor(IComparable C)
        {
            return this.legajo > ((Alumno)C).getLegajo();
        }

        public override bool sosMenor(IComparable C)
        {
            return this.legajo < ((Alumno)C).getLegajo();
        }

    }

}

