using System;
using System.Collections.Generic;

namespace Metodologias_1
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Empecemos!");


            void llenar(IColeccionable cole)
            {
                Random numeroRandom = new Random();
                Numero relleno = new Numero(numeroRandom.Next(99));
                while (cole.agregar(relleno) == true)
                {
                    Console.WriteLine("Agregando  elemento " + relleno.getValor());
                    relleno = new Numero(numeroRandom.Next(99));

                }
                Console.WriteLine("elemento lleno");
            }

            void informar(IColeccionable cole)
            {
                Console.WriteLine("La coleccion tiene " + cole.cuantos() + " elementos");



                Console.WriteLine("El minimo elemento es " + ((Numero)cole.minimo()).getValor());
                Console.WriteLine("El maximo elemento es " + ((Numero)cole.maximo()).getValor());

                Console.WriteLine("Ingrese un valor a buscar ");
                int n1 = Convert.ToInt32(Console.ReadLine());
                Numero valorBuscado = new Numero(n1);
                Console.WriteLine("valor ingresado " + valorBuscado.getValor());
                if (cole.contiene(valorBuscado) == true)
                {
                    Console.WriteLine("El elemento leído está en la colección");
                }
                else
                {
                    Console.WriteLine("El elemento leído NO está en la colección");
                }
            }


            void InformarPersona(IColeccionable cole)
            {
                Console.WriteLine("La coleccion tiene " + cole.cuantos() + " elementos");
                Console.WriteLine("El DNI minimo es " + ((Persona)cole.minimo()).getDni());
                Console.WriteLine("El DNI maximo es " + ((Persona)cole.maximo()).getDni());

                Console.WriteLine("Ingrese un valor a buscar ");
                int n1 = Convert.ToInt32(Console.ReadLine());
                Persona dniBuscado = new Persona("nombre X ", n1);
                Console.WriteLine("valor ingresado " + dniBuscado.getDni());
                if (cole.contiene(dniBuscado) == true)
                {
                    Console.WriteLine("El elemento leído está en la colección");
                }
                else
                {
                    Console.WriteLine("El elemento leído NO está en la colección");
                }


            }


            void InformarAlumnos(IColeccionable cole)
            {
                Console.WriteLine("La coleccion tiene " + cole.cuantos() + " elementos");
                Console.WriteLine("El Legajo minimo es " + ((Alumno)cole.minimo()).getLegajo());
                Console.WriteLine("El Legajo maximo es " + ((Alumno)cole.maximo()).getLegajo());

                Console.WriteLine("Ingrese el legajo a buscar ");
                int n1 = Convert.ToInt32(Console.ReadLine());
                Alumno legajoBuscado = new Alumno("x", 0, n1, 0);
                Console.WriteLine("valor ingresado " + legajoBuscado.getLegajo());
                if (cole.contiene(legajoBuscado) == true)
                {
                    Console.WriteLine("El legajo buscado leído está en la colección");
                }
                else
                {
                    Console.WriteLine("El legajo buscado NO está en la colección");
                }


            }

            void llenarPersonas(IColeccionable cole)
            {
                List<String> listaDeNombres = new List<string>()
                {
                 "Juan Percha",
                 "Juanita Viale",
                 "Esteban Quito",
                 "Abel D Retido",
                 "Agustin Vertebrado",
                 "Alba Babosa",
                 "Aldo Lorido",
                 "Alberto Matazo",
                 "Alen Guado",
                 "Alex Plosivo",
                 "Alfonsin Sesos",
                 "Ines Tornudo",
                 "Irma Tematica",
                 "Isaac A Mocos",
                 "Ivan Pirito",
                 "Jacobo Quete",
                 "Jaime Talero",
                 "Jazmin Secto",
                 "Jaime Jillas",
                 "Joel Electrico",
                 "Jhonny Latrago",
                 "Joaquin Odoro",
                 "Jessi Nojos",
                 "Norma Cita",
                 "Olaf E. Itado",
                 "Nico Tinoso",
                 "Omar Tillado",
                 "Omar Ciano",
                 "Omar Garita",
                 "Oscar Mado",
                 "Tomas Todonte",
                 "Vicente Rorifico",
                 "Victor Ticolis"

                };

                Random puntero = new Random();
                Random dniRandom = new Random();
                int dniR = dniRandom.Next(111111, 99999999);

                Persona persona = new Persona(listaDeNombres[puntero.Next(listaDeNombres.Count - 1)], dniR);

                while (cole.agregar(persona) == true)

                {
                    Console.WriteLine("Agregando  elemento " + persona.getNombre() + " con DNI " + persona.getDni());
                    dniR = dniRandom.Next(111111, 99999999);
                    persona = new Persona(listaDeNombres[puntero.Next(listaDeNombres.Count - 1)], dniR);


                }

                Console.WriteLine("elemento lleno de personas");
            }

            void llenarAlumnos(IColeccionable cole)
            {
                List<String> listaDeNombres = new List<string>()
                {
                 "Juan Percha",
                 "Juanita Viale",
                 "Esteban Quito",
                 "Abel D Retido",
                 "Agustin Vertebrado",
                 "Alba Babosa",
                 "Aldo Lorido",
                 "Alberto Matazo",
                 "Alen Guado",
                 "Alex Plosivo",
                 "Alfonsin Sesos",
                 "Ines Tornudo",
                 "Irma Tematica",
                 "Isaac A Mocos",
                 "Ivan Pirito",
                 "Jacobo Quete",
                 "Jaime Talero",
                 "Jazmin Secto",
                 "Jaime Jillas",
                 "Joel Electrico",
                 "Jhonny Latrago",
                 "Joaquin Odoro",
                 "Jessi Nojos",
                 "Norma Cita",
                 "Olaf E. Itado",
                 "Nico Tinoso",
                 "Omar Tillado",
                 "Omar Ciano",
                 "Omar Garita",
                 "Oscar Mado",
                 "Tomas Todonte",
                 "Vicente Rorifico",
                 "Victor Ticolis"

                };

                Random puntero = new Random();
                Random dniRandom = new Random();
                Random legajoRandom = new Random();
                Random promedioRandom = new Random();
                int dniR = dniRandom.Next(111111, 99999999);
                int legajoR = legajoRandom.Next(1111, 99999);
                int promedioR = promedioRandom.Next(11, 99);


                Alumno alumno = new Alumno(listaDeNombres[puntero.Next(listaDeNombres.Count - 1)], dniR, legajoR, promedioR);

                while (cole.agregar(alumno) == true)

                {
                    Console.WriteLine("Agregando  elemento " + alumno.getNombre() + " con DNI " + alumno.getDni() + " ,legajo: " + alumno.getLegajo() + " y un promedio de: " + alumno.getPromedio());
                    dniR = dniRandom.Next(111111, 99999999);
                    legajoR = legajoRandom.Next(1111, 99999);
                    promedioR = promedioRandom.Next(11, 99);
                    alumno = new Alumno(listaDeNombres[puntero.Next(listaDeNombres.Count - 1)], dniR, legajoR, promedioR);


                }

                Console.WriteLine("elemento lleno de Alumnos");
            }

            IColeccionable pilaPersonas = new Pila(20);
            IColeccionable colaPersonas = new Cola(20);


            llenarAlumnos(pilaPersonas);
            llenarAlumnos(colaPersonas);





            ColeccionMultiple c = new ColeccionMultiple(pilaPersonas, colaPersonas);

            InformarAlumnos(c);


            // informar(pilaPersonas);

            //Console.WriteLine("Maximo "+ ((Persona)c.maximo()).getDni());

            //Console.WriteLine("minimo " +((Persona)c.minimo()).getDni());


            //Persona test = new Persona("Esteban", 30265789);

            //Persona test2 = new Persona("Patricio", 29265789);

            // Console.WriteLine("La persona" + test.getNombre() + "tiene el dni "+ test.getDni()+ "y su dni es mayor"+ test.sosMayor(test2) );
            /*
            Alumno test = new Alumno("Esteban", 30265789, 16488, 89);

            Alumno test2 = new Alumno("Patricio", 29265789, 22478, 70);

            Console.WriteLine("La persona " + test.getNombre() + " tiene el promedio "+ test.getPromedio()+ " y su promedio es mayor "+ test.sosMayor(test2) + " que el de "+ test2.getNombre());
            */










            //Numero n1, n2, n3;
            //n1 = new Numero(2);
            //n2 = new Numero(5);
            // n3 = new Numero(3);




            //Console.WriteLine("es igual" + n1.sosIgual(n2));
            //Console.WriteLine("es menor" + n1.sosMenor(n2));
            //Console.WriteLine("es mayor" + n1.sosMayor(n2));
            //Console.WriteLine("n1 vale " + n1.getValor());






            //Agregando elementos y mostrando si es exitoso o no
            //Console.WriteLine("Agregando  n1 " + test.agregar(n1));
            //Console.WriteLine("Agregando  n2 " + test.agregar(n2));
            //Console.WriteLine("Agregando  n3 " + test.agregar(n3));

            // test de contiene "positivo"
            //Console.WriteLine("test de ALE Contiene n1 ? " + test.contiene(n1));
            //test de cuantos
            //Console.WriteLine("test tiene " + test.cuantos() + " elementos");
            //test de contiene "negativo"
            //Console.WriteLine("test Contiene n3 ? " + test.contiene(n3));
            // test de mayor numero
            //Console.WriteLine("el mayor es numero es  " + ((Numero)test.maximo()).getValor());

            //test de sacar
            //  while (test.cuantos() > 0)
            //  {
            //      Console.WriteLine("Elemento  " + ((Numero)test.sacar()).getValor());
            //  }




            //informar(test);

            // llenar(colaP);

            //informar(test2);



            /*Console.WriteLine(c.contiene(n1));

            Console.WriteLine(c.cuantos());

            Console.WriteLine(((Numero)c.maximo()).getValor());
            */

            //informar(pilaP);
            //informar(colaP);




            //informar(test);
            //Console.WriteLine(test.cuantos());

            //test de sacar
            //while (test.cuantos() > 0)
            //{
            //Console.WriteLine("Elemento  " + ((Numero)test.sacar()).getValor());
            //}


            //llenar(test2);
            //Console.WriteLine(test2.cuantos());
            //test de sacar
            //while (test2.cuantos() > 0)
            //{
            //    Console.WriteLine("Sacando Elemento  " + ((Numero)test2.sacar()).getValor());
            //}
            /*
            string author1 = "Mahesh Chand";
            string author2 = "Praveen Kumar";
            string author3 = "Mahesh Chand";

            Console.WriteLine((String.Equals(author1, author3)));
            */

            // STRATEGY
            /*          Console.WriteLine("Esto es el STRATEGY");

                      Alumno test = new Alumno("Patricio", 30265789, 16488, 89);//los legajos los puse iguales 

                      Alumno test2 = new Alumno("Patricio", 29265789, 16488, 70);

                      Console.WriteLine("La persona " + test.getNombre() + " tiene el promedio " + test.getPromedio() + " y su promedio es mayor " + test.sosMayor(test2) + " que el de " + test2.getNombre());


                      Console.WriteLine("Esto es el STRATEGY");


                      Console.WriteLine(test.sosIgual(test2));//false (esta comparando los dni )


                      IEstrategiaDeComparacion comparapornom = new PorNombre(test);//instancio otra estrategia

                      test.Cambiarestrategia(comparapornom);//cambio la estrategia
                      Console.WriteLine(test.sosIgual(test2));//true porque los nombres son iguales
                      IEstrategiaDeComparacion porlegajo = new PorLegajo(test);//instancio otra estrategia
                      test.Cambiarestrategia(porlegajo);//cambio la estrategia
                      Console.WriteLine(test.sosMayor(test2));//true porque los nombres son iguales

          */

        }
    }
}
