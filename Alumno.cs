﻿using System;
using System.Collections.Generic;
using System.Text;



namespace Metodologias_1
{
    public class Alumno : Persona
    {
        private int legajo;
        private int promedio;



        public Alumno(String nom, int dni, int leg, int prom)
            : base(nom, dni)
        {

            this.legajo = leg;
            this.promedio = prom;
            this.IEstrategiadecomparacion = new Estrategiapordni();
        }

        public int getLegajo()
        {
            return this.legajo;
        }

        public int getPromedio()
        {
            return this.promedio;
        }

        public override bool sosIgual(IComparable C)
        {
            return this.promedio == ((Alumno)C).getPromedio();
        }

        public override bool sosMayor(IComparable C)
        {
            return this.promedio > ((Alumno)C).getPromedio();
        }

        public override bool sosMenor(IComparable C)
        {
            return this.promedio < ((Alumno)C).getPromedio();
        }
        void Cambiarestrategia(IEstrategiadecomparacion nuevaestrategia)
        {
            this.estrategia = nuevaestrategia;
        }
    }

}

